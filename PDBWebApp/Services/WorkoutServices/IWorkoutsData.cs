using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.Services.WorkoutServices
{
    public interface IWorkoutsData
    {
        IEnumerable<Workouts> GetAll();
        Workouts Get(int id);      
    }
}
