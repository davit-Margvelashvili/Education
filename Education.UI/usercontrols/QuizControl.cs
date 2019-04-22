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
    public partial class QuizControl : UserControl
    {
        public QuizControl()
        {
            InitializeComponent();
        }

        private void NameStartButton_Click(object sender, EventArgs e)
        {
             
            NameQuizcontrol nameQuizcontrol = new NameQuizcontrol();
            QuizContentPanel.Controls.Clear();
            QuizContentPanel.Controls.Add(nameQuizcontrol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SymbolQuizControl symbolQuizControl = new SymbolQuizControl();
            QuizContentPanel.Controls.Clear();
            QuizContentPanel.Controls.Add(symbolQuizControl);
        }

      
    }
}
