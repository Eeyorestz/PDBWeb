using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Models;

namespace PDBWebApp.Services.StudioServices
{
    public interface IStudioData
    {
        IEnumerable<Studios> GetAll();
        Studios Get(int id);
        Studios Add(Studios studio);
    }
}
