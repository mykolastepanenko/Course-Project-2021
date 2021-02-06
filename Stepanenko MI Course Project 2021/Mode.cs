using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stepanenko_MI_Course_Project_2021
{
    public partial class Mode : UserControl
    {
        public Mode()
        {
            InitializeComponent();
        }

        public string setChildMode
        {
            set
            {
                switch (value)
                {
                    case "easy":
                        easyMode.Checked = true;
                        break;
                    case "normal":
                        normalMode.Checked = true;
                        break;
                    case "hard":
                        hardMode.Checked = true;
                        break;
                }
                btn_selectMode_Click(null, null);
            }
        }

        private void btn_selectMode_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form1;
            if (easyMode.Checked == true)
            {
                parent.SetMode = "easy";
            }
            else if (normalMode.Checked == true)
            {
                parent.SetMode = "normal";
            }
            else if (hardMode.Checked == true)
            {
                parent.SetMode = "hard";
            }
        }
    }
}
