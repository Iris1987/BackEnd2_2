using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("datasensor")]
    public partial class Datasensor
    {
       // [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // [Column("id")]
        public int Id { get; set; }
        
        //
       // [Column("id_controllersensor")]
        public int IdControllersensor { get; set; }
        public ControllerSensor Controllersensor { get; set; }
        //

      //  [Column("date_time")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateTime { get; set; }

      //  [Column("data")]
        public double Data { get; set; }

        //
        [Column("id_typevalue")]
        public int IdTypevalue { get; set; }
        public Typevalue Typevalue { get; set; }
        //
        
       

        public Datasensor()
        { }
    }
}
