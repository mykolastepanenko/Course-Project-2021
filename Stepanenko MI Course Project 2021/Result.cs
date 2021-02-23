using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Stepanenko_MI_Course_Project_2021
{
    public partial class Result : UserControl
    {
        int score;
        public Result()
        {
            InitializeComponent();
        }

        public string SetScore
        {
            set
            {
                label3.Text = value.ToString();
            }
            get
            {
                return label3.Text;
            }
        }

        private void openFile_btn_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("output.txt");
            if (!File.Exists(path)) { using (File.Create(path)) ; }
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath("output.txt");
            if (!File.Exists(path)) { using (File.Create(path)) ; }

            ////Write text in file
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    var parent = this.Parent as Form1;
                    sw.WriteLine(parent.SetPlayerName + " - " + parent.SetMode + " - " + label3.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка записування в файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
