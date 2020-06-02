using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("typevalue")]
    public partial class Typevalue
    {
        //public Typevalue()
        //{
        //    Datasensor = new HashSet<Datasensor>();
        //}

       // [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // [Column("id")]
        public int Id { get; set; }
        //[Column("valuetype")]
        public string Valuetype { get; set; }
       // [Column("dimension")]
        public string Dimension { get; set; }

      //  [ForeignKey("IdTypevalue")]
        public ICollection<Datasensor> Datasensor { get; set; }
        
        public Typevalue() { }
    }
}
