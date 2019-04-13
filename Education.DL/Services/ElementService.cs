using Education.BL.Models;
using Education.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.DL.Services
{
    public class ElementService : IElementService
    {
        public IEnumerable<ElementModel> GetElements()
        {
            using (var db = new EducationDataBaseEntities())
            {
                return db.PeriodicTables.Select(t => new  ElementModel
                {
                    AtomicNumber = t.AtomicNumber,
                    Element = t.Element,
                    Symbol = t.Symbol,
                    AtomicMass = t.AtomicMass,
                    NumberofNeutrons = t.NumberofNeutrons,
                    NumberofProtons = t.NumberofProtons,
                    NumberofElectrons = t.NumberofElectrons,
                    PeriodNumber = t.PeriodNumber,
                    GroupNumber = t.GroupNumber,
                    Phase = t.Phase,
                    Radioactive = t.Radioactive,
                    Natural = t.Natural,
                    Metal = t.Metal,
                    Nonmetal = t.Nonmetal,
                    Metalloid = t.Metalloid,
                    ElementType = t.ElementType,
                    AtomicRadius = t.AtomicRadius,
                    Electronegativity = t.Electronegativity,
                    FirstIonization = t.FirstIonization,
                    Density = t.Density,
                    MeltingPoint = t.MeltingPoint,
                    BoilingPoint = t.BoilingPoint,
                    NumberOfIsotopes = t.NumberOfIsotopes,
                    Discoverer = t.Discoverer,
                    DiscoverYear = t.DiscoverYear,
                    SpecificHeat = t.SpecificHeat,
                    NumberofShells = t.NumberofShells,
                    NumberofValence = t.NumberofValence,
                    Row  = t.Row,
                    Column = t.Column
                }).ToList();
             
            }

        }

     
    }
}
