using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PDBWebApp.Services;
using PDBWebApp.Services.StudioServices;
using PDBWebApp.ViewModels;

namespace PDBWebApp.Controllers
{
    public class ScheduleController : Controller
    {
        private IScheduleData _scheduleData;
        public ScheduleController(IScheduleData scheduleData)
        {
            _scheduleData = scheduleData;
        }
        [Route("Studio/{id1?}/Workout/{id2?}")]
        public IActionResult ScheduleDetails(int? id1, int? id2)
        {
            var model = new SchedulesViewModel();
            model.Schedules = _scheduleData.GetAll(id1, id2);
            return View(model);
            
        }
    }
}
