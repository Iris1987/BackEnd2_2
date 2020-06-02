using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("controller")]
    public partial class ControllerClass
    {
        //public ControllerClass()
        //{
        //    ControllerSensor = new HashSet<ControllerSensor>();
        //}
      //  [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // [Column("id")]
        public int Id { get; set; }
       // [Column("controllername")]
        public string Controllername { get; set; }
       // [Column("description")]
        public string Description { get; set; }

       // [ForeignKey("IdController")]
        public ICollection<ControllerSensor> ControllerSensor { get; set; }

        public ControllerClass() { }
    }
}
