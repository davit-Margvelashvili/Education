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
            var elementControls = elements.Select(e => new Elementcontrol(e)).ToList();

            int row = 1, column = 1;
            
            foreach (var element in elementControls)
            {
                if(column == 19)
                {
                    column = 1;
                    row++;
                }
                if(row == 8)
                {
                    break;
                }

                tablePanel.Controls.Add(element);
                tablePanel.SetColumn(element, column);
                tablePanel.SetRow(element, row);

                column++;
            }

        }


    }
}

