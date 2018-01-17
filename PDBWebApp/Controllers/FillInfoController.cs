using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDBWebApp.Services;

namespace PDBWebApp.Controllers
{
    public class FillInfoController : Controller
    {
        private IFillInfoData _fillInfo;

        public FillInfoController(IFillInfoData fillInfo)
        {
            _fillInfo = fillInfo;
        }
        [HttpGet]
        [Route("Studio/{id1?}/Workout/{id2?}/FillForm")]
        public IActionResult FillForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Studio/{id1?}/Workout/{id2?}/FillForm")]
        IActionResult FillForm(int? id1, int? id2)
        {
            return null;
            //var newWorkout = new Studios();
            //newWorkout.Name = model.Name;

            //newWorkout = _studioData.Add(newWorkout);
            //return RedirectToAction(nameof(Details), new { id = newWorkout.Id });
        }


    }
}
