using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PDBWebApp.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string ScheduleValue { get; set; }
        public int WorkoutID { get; set; }
        public int StudioID { get; set; }

    }
}
