using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PDBWebApp.Services;

namespace PDBWebApp.Controllers
{
    public class FillFormControler : Controller
    {
        private IFillInfoData _fillInfo;

        public FillFormControler(IFillInfoData fillInfo)
        {
            _fillInfo = fillInfo;
        }
    }
}
