using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education.BL.Services;

namespace Education.UI.usercontrols
{
    public partial class TableControl : UserControl
    {
        IElementService ElementService { get; set; }

        public TableControl(IElementService elementService)
        {
            InitializeComponent();
            ElementService = elementService;

            var elements = ElementService.GetElements();
            var elementControls = elements.Where(e => e.Row != null).Select(e => new Elementcontrol(e)).ToList();

            
            foreach (var element in elementControls)
            {
                tablePanel.Controls.Add(element);
                tablePanel.SetColumn(element, element.Column.Value);
                tablePanel.SetRow(element, element.Row.Value);
            }

        }


    }
}

