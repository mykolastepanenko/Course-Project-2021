using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Stepanenko_MI_Course_Project_2021
{
    public partial class Form1 : Form
    {
        public static string connectString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Path.GetFullPath("../../../database.mdb"));
        int[] playerLocation = new int[2];
        public Form1()
        {
            isStart = false;
            isFinish = false;
            player.Name = "Player";
            mode = "easy";
            InitializeComponent();
            try
            {
                using (StreamWriter sw = new StreamWriter(helpPath, false, System.Text.Encoding.Default))
                {
                    helpProvider1.HelpNamespace = helpPath;
                    sw.WriteLine(helpContext);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string SetMode
        {
            set
            {
                mode = value;
                if (panel1.Controls.Count != 0)
                {
                    for (int i = 0; i < field.Length; i++)
                    {
                        for (int j = 0; j < field.Length; j++)
                        {
                            panel1.Controls.Remove(field[i][j]);
                        }
                    }
                }
                InitializeField();
                isStart = true;
                isFinish = false;
            }
            get
            {
                return mode;
            }
        }

        public string SetPlayerName
        {
            set
            {
                player.Name = value;
            }
            get
            {
                return player.Name;
            }
        }

        private void FieldBelowStart()
        {
            for (int i = 0; i < field.Length; i++)
            {
                this.field[i] = new System.Windows.Forms.Button[30];
                for (int j = 0; j < field.Length; j++)
                {
                    this.field[i][j] = new System.Windows.Forms.Button();
                    this.field[i][j].Location = new System.Drawing.Point(i * 25, j * 25);
                    this.field[i][j].Name = "arr" + i + j;
                    this.field[i][j].Size = new System.Drawing.Size(25, 25);
                    this.panel1.Controls.Add(this.field[i][j]);
                }
            }
        }

        private void InitializeField()
        {
            if (blocks != null)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    panel1.Controls.Remove(blocks[i]);
                }
            }
            for (int i = 0; i < field.Length; i++)
            {
                this.field[i] = new System.Windows.Forms.Button[30];
                for (int j = 0; j < field.Length; j++)
                {
                    this.field[i][j] = new System.Windows.Forms.Button();
                    this.field[i][j].Location = new System.Drawing.Point(i * 25, j * 25);
                    this.field[i][j].Name = "arr" + i + j;
                    this.field[i][j].Size = new System.Drawing.Size(25, 25);

                }
            }
            InitializePlayer();
            InitializeFinish();
            InitializeBlock();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    this.panel1.Controls.Add(field[i][j]);
                }
            }
        }
        private void InitializePlayer()
        {
            player.BackColor = Color.Red;
            player.Size = new System.Drawing.Size(25, 25);
            player.Location = new System.Drawing.Point(0, 0);
            this.panel1.Controls.Add(player);
        }

        private void InitializeFinish()
        {
            finish.BackColor = Color.Green;
            finish.Size = new System.Drawing.Size(25, 25);
            finish.Location = new System.Drawing.Point(field.Length * 25 - 25, field.Length * 25 - 25);
            this.panel1.Controls.Add(finish);
        }

        private void InitializeBlock()
        {
            RunTimer();
            Random random = new Random();
            Point checkStartLocation = new Point(0, 0);
            this.blocks = new Button[field.Length];
            if (mode == "easy")
            {
                this.blocks = new Button[field.Length];
            }
            else if(mode == "normal")
            {
                this.blocks = new Button[field.Length * 2];
            }
            else if(mode == "hard")
            {
                this.blocks = new Button[field.Length * 4];
            }
            if(random.Next(0,2) == 0){
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i] = new Button();
                    blocks[i].BackColor = Color.Black;
                    blocks[i].Size = new System.Drawing.Size(25, 25);
                    blocks[i].Location = new System.Drawing.Point(random.Next(1, field.Length - 1) * 25, random.Next(0, field.Length - 1) * 25);
                    this.panel1.Controls.Add(blocks[i]);
                }
            }
            else {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i] = new Button();
                    blocks[i].BackColor = Color.Black;
                    blocks[i].Size = new System.Drawing.Size(25, 25);
                    blocks[i].Location = new System.Drawing.Point(random.Next(0, field.Length - 1) * 25, random.Next(1, field.Length - 1) * 25);
                    this.panel1.Controls.Add(blocks[i]);
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(isStart == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    MoveUp();
                }
                if (e.KeyCode == Keys.S)
                {
                    MoveDown();
                }
                if (e.KeyCode == Keys.A)
                {
                    MoveLeft();
                }
                if (e.KeyCode == Keys.D)
                {
                    MoveRight();
                }
                IsFinish();
            }
            else
            {
                if(e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.A || e.KeyCode == Keys.D)
                {
                    writeAfterFinish();
                }
            }
        }

        private void writeAfterFinish()
        {
            if (isFinish == true)
            {
                counter++;
                if (counter == 5)
                {
                    if (MessageBox.Show("Розпочати нову гру?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SetMode = mode;
                    }
                    counter = 0;
                }
            }
        }

        private void IsFinish()
        {
            if(finish.Location == player.Location)
            {
                StopTimer();
                isStart = false;
                isFinish = true;
                if (mode == "hard")
                {
                    MessageBox.Show("Вітаю, ви дойшли до фініша. Ви пройшли насйкладніший рівень.", "Вітаю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вітаю, ви дойшли до фініша! Ваш час " + result1.SetScore, "Вітаю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MoveUp()
        {
            if (player.Location.Y != 0)
            {
                bool isBlocker = false;
                foreach (Button item in blocks)
                {
                    if (player.Location.X == item.Location.X && player.Location.Y - 25 == item.Location.Y)
                    {
                        isBlocker = true;
                    }
                }

                if (isBlocker == false)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X, player.Location.Y - 25);
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 3)
                    {
                        MessageBox.Show("Перед вами перешкода. Виберіть інший шлях", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter = 0;
                    }
                }
            }
        }
        private void MoveDown()
        {
            if (player.Location.Y != field.Length * 25 - 25)
            {
                bool isBlocker = false;
                foreach (Button item in blocks)
                {
                    if (player.Location.X == item.Location.X && player.Location.Y + 25 == item.Location.Y)
                    {
                        isBlocker = true;
                    }
                }

                if (isBlocker == false)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X, player.Location.Y + 25);
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 3)
                    {
                        MessageBox.Show("Перед вами перешкода. Виберіть інший шлях", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter = 0;
                    }
                }
            }
        }
        private void MoveLeft()
        {
            if (player.Location.X != 0)
            {
                bool isBlocker = false;
                foreach (Button item in blocks)
                {
                    if (player.Location.X - 25 == item.Location.X && player.Location.Y == item.Location.Y)
                    {
                        isBlocker = true;
                    }
                }

                if (isBlocker == false)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X - 25, player.Location.Y);
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 3)
                    {
                        MessageBox.Show("Перед вами перешкода. Виберіть інший шлях", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter = 0;
                    }
                }
            }
        }
        private void MoveRight()
        {
            if (player.Location.X != field.Length * 25 - 25)
            {
                bool isBlocker = false;
                foreach (Button item in blocks)
                {
                    if (player.Location.X + 25 == item.Location.X && player.Location.Y == item.Location.Y)
                    {
                        isBlocker = true;
                    }
                }

                if (isBlocker == false)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X + 25, player.Location.Y);
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 3)
                    {
                        MessageBox.Show("Перед вами перешкода. Виберіть інший шлях", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        counter = 0;
                    }
                }
            }
        }
        public void RunTimer()
        {
            timeStart = DateTime.Now;
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = 1000;
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }
        private void timer_tick(object sender, EventArgs e)
        {
            timeFinish = DateTime.Now;
            result1.SetScore = timeFinish.Subtract(timeStart).ToString().Substring(0, 8);
        }

        private void CloseProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AuthorName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дану роботу створив студент 471 групи Степаненко Миколай Ігорович.\n" +
                "Перед вами курсовий проект на тему \"Задача про лабіринт\"", 
                "Автор даної програми", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
        private void Helper(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Path.GetFullPath("help.html"));
        }
        private void Instruction_Click(object sender, EventArgs e)
        {
            InstructionForm instructionForm = new InstructionForm();
            instructionForm.Show();
        }
        string helpPath = "help.html";
        string helpContext = "<!DOCTYPE html><html lang='en'><head> <meta charset='UTF-8'> <meta name='viewport' content='width=device-width, initial-scale=1.0'> <title>Довідка до курсового проекту Степаненка Миколая Ігоровича</title> <style> h1, h2{ text-align: center; } nav{ width: 100%; margin: auto; line-height: 1.5; } .center { margin: auto; } @media screen and (min-width: 720px){ nav{ width: 50%; margin: auto; } } @media screen and (min-width: 900px){ nav{ width: 35%; margin: auto; } } </style></head><body> <div class='container'> <h1>Довідка програми 'Задача про лабіринт'</h1> <h2>Інструкція користувача</h2> <nav> <ul> <li>Введіть ім'я гравця.</li> <li>За бажанням змініть режим складності.</li> <li>Досягніть фінішу оминаючи перешкоди</li> <li>Для переміщення використовуйте клавіші w,a,s,d.</li> <li>За бажанням збережіть результат у файл.</li> <li>За бажанням розпочніть нову гру.</li> </ul> </nav> <div class='center'> <h2>Інформація про автора програми</h2> <p>Дану роботу створив студент 471 групи Степаненко Миколай Ігорович. Перед вами курсовий проект на тему 'Задача про лабіринт'.</p> </div> </div></body></html>";

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
