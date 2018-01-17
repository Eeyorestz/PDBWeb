using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDBWebApp.Data;
using PDBWebApp.Models;
using SQLitePCL;

namespace PDBWebApp.Services.StudioServices
{
    
    public class SQLStudioData : IStudioData
    {
        private PDBWebAppDbContext _context;
        public SQLStudioData(PDBWebAppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Studios> GetAll()
        {
            return _context.Studioses.OrderBy(s => s.Id);
        }

        public Studios Get(int id)
        {
            return _context.Studioses.FirstOrDefault(s => s.Id == id);
        }

        public Studios Add(Studios studio)
        {
            _context.Studioses.Add(studio);
            _context.SaveChanges();
            return studio;
        }
    }
}
