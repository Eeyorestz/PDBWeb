using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PDBWebApp.Models
{
    public class FillInfo
    {
        [Key]
        public int NumberOfCard { get; set; }
        public string CardType { get; set; }
        public string FirstAndFamilyName { get; set; }
        public double Honorary { get; set; }
        public int Money { get; set; }
        public string Receipt { get; set; }
        public string WayOfPaying { get; set; }
    }
}
