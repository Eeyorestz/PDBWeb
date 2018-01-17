using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Data;
using PDBWebApp.Models;
using SQLitePCL;

namespace PDBWebApp.Services
{
    
    public class SQLFillInfoData : IFillInfoData
    {
        private PDBWebAppDbContext _context;

        public SQLFillInfoData(PDBWebAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<FillInfo> GetAll(int? studioId, int? workoutID)
        {
            throw new NotImplementedException();
        }

        public FillInfo Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
