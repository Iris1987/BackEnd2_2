using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class SensorContext : DbContext
    {

        public SensorContext() { }

        public SensorContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ControllerClass> Controllers { get;  }
        public DbSet<Sensor> Sensors { get; }
        public DbSet<ControllerSensor> ControllerSensors { get; }
        public DbSet<Datasensor> DataSensors { get; set; }
        public DbSet<Typevalue> TypeValues { get; }
        public DbSet<SensordataVW> SensorDataVWs { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SensordataVW>()
               .HasKey(c=>new {c.Controller,c.ControllerSensorID,c.Data,c.DateTime,c.Dimension,c.Room,c.TypeValueID,c.ValueType });

            modelBuilder.Entity<ControllerClass>(entity =>
            {
                entity.ToTable("controller");

                //entity.HasComment("Kontrollerite loetelu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Controllername)
                    .IsRequired()
                    .HasColumnName("controllername")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasColumnName("description");
            });

            modelBuilder.Entity<ControllerSensor>(entity =>
            {
                entity.ToTable("controller_sensor");

                //entity.HasComment("Kontrolleri-anduri paar, kus andur asub, millal on pandut");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('controllersensor_id_seq'::regclass)");

                entity.Property(e => e.DateInstall)
                    .HasColumnName("dateInstall")
                    .HasColumnType("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.IdController).HasColumnName("id_controller");

                entity.Property(e => e.IdSensor).HasColumnName("id_sensor");

                entity.Property(e => e.Room)
                    .HasColumnName("room")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Controller)
                    .WithMany(p => p.ControllerSensor)
                    .HasForeignKey(d => d.IdController)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkid_c");

                entity.HasOne(d => d.Sensors)
                    .WithMany(p => p.ControllerSensor)
                    .HasForeignKey(d => d.IdSensor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkid_s");
            });

            modelBuilder.Entity<Datasensor>(entity =>
            {
                entity.ToTable("datasensor");

                //entity.HasComment("Andurite näidud, mõõtmisandmed");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IdControllersensor).HasColumnName("id_controllersensor");

                entity.Property(e => e.IdTypevalue).HasColumnName("id_typevalue");

                entity.HasOne(d => d.Controllersensor)
                    .WithMany(p => p.Datasensor)
                    .HasForeignKey(d => d.IdControllersensor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkid_cs");

                entity.HasOne(d => d.Typevalue)
                    .WithMany(p => p.Datasensor)
                    .HasForeignKey(d => d.IdTypevalue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkid_tv");
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.ToTable("sensor");

                //entity.HasComment("Andurite loetelu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Mac)
                    .HasColumnName("mac")
                    .HasMaxLength(50);

                entity.Property(e => e.Sensorname)
                    .IsRequired()
                    .HasColumnName("sensorname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Typevalue>(entity =>
            {
                entity.ToTable("typevalue");

                //entity.HasComment("Mõõtude parameetrid ja ühikud");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dimension)
                    .HasColumnName("dimension")
                    .HasMaxLength(50);

                entity.Property(e => e.Valuetype)
                    .IsRequired()
                    .HasColumnName("valuetype")
                    .HasMaxLength(50);
            });
            
    }
    }
}

