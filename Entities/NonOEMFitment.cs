using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TireApi.Entities
{
    [Table("fitments_nonoemfitment")]
    public class NonOEMFitment
    {
        [Key]
        public int id {get; set;}
        public double size {get; set;}
        public string fitment_type {get; set;}
        public string wheel_size {get; set;}
        public string tire_size {get; set;}
        public string application {get; set;}
        public double offset_min {get; set;}
        public double offset_max {get; set;}
        public int vehicle_id;

        [ForeignKey("vehicle_id")]
        public Vehicle vehicle;
    }
}