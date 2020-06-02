using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("vw_sensorsdata")]
    public partial class SensordataVW
    {
        [Column("controllersensorid")]
        public int ControllerSensorID { get; set; }
        [Column("sensor")]
        public string Sensor { get; set; }
        [Column("room")]
        public string Room { get; set; }
        [Column("controller")]
        public string Controller { get; set; }
        [Column("date_time")]
        public DateTime DateTime { get; set; }
        [Column("valuetype")]
        public string ValueType { get; set; }
        [Column("data")]
        public double Data { get; set; }
        [Column("dimension")]
        public string Dimension { get; set; }
        [Column("typevalueid")]
        public int TypeValueID { get; set; }

        public SensordataVW()
        {

        }
    }
}
