using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("sensor")]
    public partial class Sensor
    {
        //public Sensor()
        //{
        //    ControllerSensor = new HashSet<ControllerSensor>();
        //}
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column("id")]
        public int Id { get; set; }
       // [Column("sensorname")]
        public string Sensorname { get; set; }
       // [Column("mac")]
        public string Mac { get; set; }
        //[Column("description")]
        public string Description { get; set; }

      //  [ForeignKey("IdSensor")]
        public ICollection<ControllerSensor> ControllerSensor { get; set; }

        public Sensor() { }
    }
}
