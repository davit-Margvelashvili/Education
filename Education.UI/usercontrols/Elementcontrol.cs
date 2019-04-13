using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education.BL.Models;

namespace Education.UI.usercontrols
{
    public partial class Elementcontrol : UserControl
    {
        public ElementModel Element { get; set; }
        public Elementcontrol(ElementModel element)
        {
            InitializeComponent();
            Element = element;

            ChemicalSymbolLabel.Text = Element.Symbol;
        }



        
    }
}
