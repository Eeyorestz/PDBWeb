using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.Services
{
    public interface IFillInfoData
    {
        IEnumerable<FillInfo> GetAll(int? studioId, int? workoutID);
        FillInfo Get(int id);
    }
}
