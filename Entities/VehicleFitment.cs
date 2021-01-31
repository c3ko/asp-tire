using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TireApi.Entities
{
    [Table("fitments_vehiclefitment")]

    public class Vehiclefitment
    {
        [Key]
        public int id{ get; set; }
        public string bolt_pattern{ get; set; }
        public double hubbore{ get; set; }
        public double max_wheel_load{ get; set; }
        public string nut_or_bolt{ get; set; }
        public string nut_bolt_thread_type{ get; set; }
        public double nut_bolt_hex{ get; set; }
        public double bolt_length{ get; set; }
        public double min_bolt_length{ get; set; }
        public double max_bolt_length{ get; set; }
        public string nut_bolt_torque{ get; set; }
        public double axle_weight_front{ get; set; }
        public double axle_weight_rear{ get; set; }
        public int vehicle_id{ get; set; }
        [ForeignKey("vehicle_id")]
        public Vehicle vehicle;

    }
}