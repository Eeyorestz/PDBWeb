using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Data;
using PDBWebApp.Models;
using SQLitePCL;

namespace PDBWebApp.Services
{
    
    public class SQLScheduleData : IScheduleData
    {
        private PDBWebAppDbContext _context;
        public SQLScheduleData(PDBWebAppDbContext context)
        {
            _context = context;
            
        }
        public IEnumerable<Schedule> GetAll(int? studioID, int? workoutID)
        {
            return _context.Schedules.Where(s => s.StudioID == studioID && s.WorkoutID== workoutID);
        }

        public Schedule Get(int id)
        {
            return _context.Schedules.FirstOrDefault(s => s.Id == id);
        }

    }
}
