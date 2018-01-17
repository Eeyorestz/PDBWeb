using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.ViewModels
{
    public class SchedulesViewModel
    {
        public IEnumerable<Schedule> Schedules { get; set; }
    }
}
