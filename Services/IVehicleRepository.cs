using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TireApi.Entities;

namespace TireApi.Services 
{
    public interface IVehicleRepository
    {
        IEnumerable<int> GetYears();
        IEnumerable<string> GetMakesByYear(int year);
        IEnumerable<string> GetModelsByYearAndMake(int year, string make);
        IEnumerable<string> GetBodiesByYearAndMakeAndModel(int year,string make, string model);
        IEnumerable<string> GetTrimsByYearAndMakeAndModelAndBody(int year,string make, string model, string body);


    }

}