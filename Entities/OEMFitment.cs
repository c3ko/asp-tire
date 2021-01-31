using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TireApi.Entities
{
    [Table("fitments_oemfitment")]
    public class OEMFitment
    {
        public int id { get; set; }
        public double size{ get; set; }

        public string wheel_size{ get; set; }
        public string wheel_size_rear{ get; set; }

        public string p_metric{ get; set; }

        public string tire_size{ get; set; }
        public string tire_size_rear{ get; set; }

        public string speed_rating{ get; set; }
        public string speed_rating_rear{ get; set; }

        public string load_index{ get; set; }
        public string load_index_rear{ get; set; }

        public string tp_front_psi{ get; set; }
        public string tp_rear_psi{ get; set; }

        public string offset_min_front{ get; set; }
        public string offset_max_front{ get; set; }
        public string offset_min_rear{ get; set; }
        public string offset_max_rear{ get; set; }

    }
}