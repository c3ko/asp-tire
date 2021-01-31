
using TireApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TireApi.Services
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly FitmentContext _context;

        public VehicleRepository(FitmentContext context)
        {
            _context = context;
        }

        public IEnumerable<int> GetYears()
        {
            List<int> years = _context.Vehicles
                .Select(v => v.year)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
            
            return years;
        }

        public IEnumerable<string> GetMakesByYear(int year)
        {
            List<string> makes = _context.Vehicles
                .Where(v => v.year == year)
                .Select(v => v.make)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
            
            return makes;
        }

        public IEnumerable<string> GetModelsByYearAndMake(int year, string make)
        {
            List<string> models = _context.Vehicles
                .Where(v => v.year == year && v.make == make)
                .Select(v => v.model)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            return models;
        }

        public IEnumerable<string> GetBodiesByYearAndMakeAndModel(int year, string make, string model)
        {
            List<string> bodies = _context.Vehicles
                .Where(v => v.year == year && v.make == make && v.model == model)
                .Select(v => v.body)
                .Distinct()
                .OrderBy(y => y)
                .ToList();

            return bodies;
        }

        public IEnumerable<string> GetTrimsByYearAndMakeAndModelAndBody(int year, string make, string model, string body)
        {
            List<string> trims = _context.Vehicles
                .Where(v => v.year == year && v.make == make && v.model == model && v.body == body)
                .Select(v => v.trim)
                .Distinct()
                .OrderBy(y => y)
                .ToList();
            return trims;
        }
    }
}