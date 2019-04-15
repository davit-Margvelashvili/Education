using Education.DL.Services;
using Education.UI.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education.UI.Forms
{
    public partial class MainForm : Form
    {
        bool iscollapsed;
        public MainForm()
        {
            InitializeComponent();

            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(new TableControl(new ElementService()));
        }

        private void quizbutton_Click(object sender, EventArgs e)
        {
            QuizControl quizControl = new QuizControl();
            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(quizControl);
        }

        private void hamburgerbutton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(iscollapsed)
            {
                mendeleevpictureBox.Visible = true;
                mendeleevlabel.Visible = true;
                tableInfoButton.Visible = true;
                elementsbutton.Visible = true;
                quizbutton.Visible = true;

                if (menupanel.Width < 235)
                {
                    menupanel.Width += 30;
                }
                else
                {
                    iscollapsed = false;
                    timer.Stop();
                }
            }
            else
            {
                mendeleevpictureBox.Visible = false;
                mendeleevlabel.Visible = false;
                tableInfoButton.Visible = false;
                elementsbutton.Visible = false;
                quizbutton.Visible = false;
                
                if(menupanel.Width > 70)
                {
                    menupanel.Width -= 30;
                }
                else
                {
                    iscollapsed = true;
                    timer.Stop();
                }
            }
        }
        
    }
}
