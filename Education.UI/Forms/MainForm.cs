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
        public MainForm()
        {
            InitializeComponent();

            contentpanel.Controls.Clear();
            contentpanel.Controls.Add(new TableControl(new ElementService()));
        }

       
    }
}
