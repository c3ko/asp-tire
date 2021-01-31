using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace TireApi.Entities
{
    [Table("vehicles_vehicle")]
    public class Vehicle 
    {
        [Key]
        public int id{ get; set; }
        public int year{ get; set; }
        public string make{ get; set; }
        public string model{ get; set; }
        public string body{ get; set; }
        public string trim{ get; set; }
        

        public ICollection<Vehiclefitment> VehicleFitments {get; set;}
        public ICollection<OEMFitment> OEMFitments {get; set;}
        public ICollection<NonOEMFitment> NonOEMFitments {get; set;}
    }

}