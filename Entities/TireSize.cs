using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TireApi.Entities
{
    [Table("tires_tiresize")]
    public class TireSize 
    {
        [Key]
        public int id{ get; set; }
        public double width{ get; set; }
        public double aspect_ratio{ get; set; }
        public double diameter{ get; set; }
        public double metric{ get; set; }
    }
}