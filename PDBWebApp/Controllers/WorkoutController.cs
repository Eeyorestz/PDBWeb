using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PDBWebApp.Services.WorkoutServices;
using PDBWebApp.ViewModels;

namespace PDBWebApp.Controllers
{
    public class WorkoutController : Controller
    {

        private IWorkoutsData _workoutsData;

        public WorkoutController(IWorkoutsData workoutsData)
        {
            _workoutsData = workoutsData;
        }
        [Route("Studio/{id1?}")]
        public IActionResult Workout(int? id1)
        {
            var model = new WorkoutViewModel();
            model.Workouts = _workoutsData.GetAll();
            if (model == null)
            {
                return null;
                 //return RedirectToAction(nameof());
            }
            else
            {
                return View(model);
            }
        }
    }
}
