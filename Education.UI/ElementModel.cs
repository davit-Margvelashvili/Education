using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.UI
{
    public class ElementModel
    {
        public string Name { get; set; }
        public string ChemicalSymbol { get; set; }
        public int AtomicNumber { get; set; }
        public double Molecularmass { get; set; }
        public double Atomicradius { get; set; }
        public double Thawtemperature { get; set; }
        public string Electricconfiguration { get; set; }
        public string Description { get; set; }
        public Color Color { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public ElementModel(string _name, string _chemicalsymbol, int _atomicnumber, double _molecularmass, double _atomicradius, double _thawtemperature, string _electricconfiguration, string _description)
        {
            Name = _name;
            ChemicalSymbol = _chemicalsymbol;
            AtomicNumber = _atomicnumber;
            Molecularmass = _molecularmass;
            Atomicradius = _atomicradius;
            Thawtemperature = _thawtemperature;
            Electricconfiguration = _electricconfiguration;
            Description = _description;
        }

        public ElementModel()
        {

        }
    }
}

