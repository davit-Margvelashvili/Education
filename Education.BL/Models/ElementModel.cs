using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Models
{
    public class ElementModel
    {
        public int AtomicNumber { get; set; }
        public string Element { get; set; }
        public string Symbol { get; set; }
        public decimal AtomicMass { get; set; }
        public int NumberofNeutrons { get; set; }
        public int NumberofProtons { get; set; }
        public int NumberofElectrons { get; set; }
        public int PeriodNumber { get; set; }
        public int? GroupNumber { get; set; }
        public string Phase { get; set; }
        public string Radioactive { get; set; }
        public string Natural { get; set; }
        public string Metal { get; set; }
        public string Nonmetal { get; set; }
        public string Metalloid { get; set; }
        public string ElementType { get; set; }
        public decimal? AtomicRadius { get; set; }
        public decimal? Electronegativity { get; set; }
        public decimal? FirstIonization { get; set; }
        public decimal? Density { get; set; }
        public decimal? MeltingPoint { get; set; }
        public decimal? BoilingPoint { get; set; }
        public int? NumberOfIsotopes { get; set; }
        public string Discoverer { get; set; }
        public int? DiscoverYear { get; set; }
        public decimal? SpecificHeat { get; set; }
        public int NumberofShells { get; set; }
        public int? NumberofValence { get; set; }

    }
}

