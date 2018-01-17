﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PDBWebApp.Models
{
    public class Workouts
    {
        public int Id { get; set; }
        [Display(Name = "Workout name")]
        public string Name { get; set; }
    }
}
