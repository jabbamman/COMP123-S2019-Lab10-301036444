using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301036444
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void btnclick(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            switch (tag)
            {
                case "Back":
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                    break;

                case "Close":
                    Application.Exit();
                    break;
            }
        }
    }
}

