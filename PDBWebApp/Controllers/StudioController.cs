using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDBWebApp.Services.StudioServices;
using PDBWebApp.ViewModels;

namespace PDBWebApp.Controllers
{
    public class StudioController : Controller
    {
        private IStudioData _studioData;
        public StudioController(IStudioData studioData)
        {
            _studioData = studioData;
        }
      
      
        public IActionResult Studio(int? id)
        {
            var model = new StudiosViewModel();
            model.Studios = _studioData.GetAll();
            return View(model);
        }

       
    }
}
