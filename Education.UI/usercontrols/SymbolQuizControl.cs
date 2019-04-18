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
    public partial class SymbolQuizControl : UserControl
    {
        
        ElementModel element = new ElementModel();

        public SymbolQuizControl()
        {
            InitializeComponent();
            element.Element = SymbolLabel.Text;
        }

      

        private void Answer1LAbel_Click(object sender, EventArgs e)
        {
            if(sender is Label label)
            {
                if(element.Symbol == label.Text)
                {
                    AnswerChecklabel.Visible = true;
                }
                else
                {
                    AnswerChecklabel.ForeColor = Color.Red;
                    AnswerChecklabel.Text = "Wrong Answer";
                    AnswerChecklabel.Visible = true;
                }
            }
        }
    }
}
