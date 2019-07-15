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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();

            switch (tag)
            {
                case "Next":

                    EndForm endForm = new EndForm();
                    endForm.Show();
                    Hide();
                    break;

                case "Close":
                    Application.Exit();
                    break;
            }
        }
    }
}
