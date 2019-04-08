using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education.UI.usercontrols
{
    public partial class Elementcontrol : UserControl
    {
        ElementModel element = new ElementModel();
        public Elementcontrol()
        {
            InitializeComponent();
            element.ChemicalSymbol = ChemicalSymbolLabel.Text;
            

        }



        
    }
}
