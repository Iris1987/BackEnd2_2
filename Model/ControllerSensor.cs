using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("controller_sensor")]
    public partial class ControllerSensor
    {
        //public ControllerSensor()
        //{
        //    Datasensor = new HashSet<Datasensor>();
            
        //}

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column("id")]
        public int Id { get; set; }
        
        //
        //[Column("id_controller")]
        public int IdController { get; set; }
        public ControllerClass Controller { get; set; }
        //

        //
       // [Column("id_sensor")]
        public int IdSensor { get; set; }
        public  Sensor Sensors { get; set; }
        //
        
       // [Column("room")]
        public string Room { get; set; }
      //  [Column("dateInstall")]
        public DateTime? DateInstall { get; set; }
       // [Column("state")]
        public string State { get; set; }

        
        

       // [ForeignKey("IdControllersensor")]
        public ICollection<Datasensor> Datasensor { get; set; }
       
        public ControllerSensor() { }
    }
}
