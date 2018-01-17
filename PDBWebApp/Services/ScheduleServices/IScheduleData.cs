using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.Services
{
    public interface IScheduleData
    {
        IEnumerable<Schedule> GetAll(int? studioId, int? workoutID);
        Schedule Get(int id);
    }
}
