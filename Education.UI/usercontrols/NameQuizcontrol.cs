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
    public partial class NameQuizcontrol : UserControl
    {
        bool isCorrectAnswer;
        public NameQuizcontrol()
        {
            InitializeComponent();
        }

        private void AnswerChecklabel_Click(object sender, EventArgs e)
        {
            if (isCorrectAnswer == true)
                AnswerChecklabel.Visible = true;
            else
            {
                AnswerChecklabel.ForeColor = Color.Red;
                AnswerChecklabel.Text = "Wrong Answer";
                AnswerChecklabel.Visible = true;
            }
        }

    }
}
