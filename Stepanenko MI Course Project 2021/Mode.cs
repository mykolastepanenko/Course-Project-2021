using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            //Перевірка коректності введених даних
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                textBox1.Text = "Player";
                MessageBox.Show("Ви не ввели ім'я гравця. Система вам надає ім'я \"Player\"", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            parent.SetPlayerName = textBox1.Text;

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

        private void inputName_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("../../../input.txt");
            if (!File.Exists(path)) { 
                using (File.Create(path));
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    textBox1.Text = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("../../../input.txt");
            if (!File.Exists(path)) { using (File.Create(path)) ; }
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
