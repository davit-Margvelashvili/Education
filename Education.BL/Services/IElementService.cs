using Education.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL.Services
{
    public interface IElementService
    {
        IEnumerable<ElementModel> GetElements();
    }
}
