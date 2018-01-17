using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.ViewModels
{
    public class WorkoutViewModel
    {
        public IEnumerable<Workouts> Workouts { get; set; }
       
    }
}
