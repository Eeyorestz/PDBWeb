
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PDBWebApp.Models;
using PDBWebApp.Services;
using PDBWebApp.Services.StudioServices;
using PDBWebApp.Services.WorkoutServices;
using PDBWebApp.ViewModels;

namespace PDBWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IStudioData _studioData;
       
        public HomeController(IStudioData studioData, IWorkoutsData workoutsData, IScheduleData scheduleData)
        {
            _studioData = studioData;
           
        }

        public IActionResult Index()
        {
            var model = new StudiosViewModel();
            model.Studios = _studioData.GetAll();

            return View(model);
        }


    
        [HttpGet]
        public IActionResult FillInfo()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult FillInfo(StudiosEditModel model)
        //{
        //   var newWorkout = new Studios();
        //    newWorkout.Name = model.Name;
           
        //    newWorkout = _studioData.Add(newWorkout);
        //    return RedirectToAction(nameof(Details), new {id = newWorkout.Id});
        //}
    }
}
