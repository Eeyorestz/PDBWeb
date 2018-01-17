using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Data;
using PDBWebApp.Models;

namespace PDBWebApp.Services.WorkoutServices
{
    public class SQLWorkoutData : IWorkoutsData
    {
        private PDBWebAppDbContext _context;

        public SQLWorkoutData(PDBWebAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Workouts> GetAll()
        {
            return _context.Workouts.OrderBy(s => s.Id);
        }

        public Workouts Get(int id)
        {
            return _context.Workouts.FirstOrDefault(s => s.Id == id);
        }
    }
}
