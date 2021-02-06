using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepanenko_MI_Course_Project_2021
{
    public partial class Form1 : Form
    {
        int[] playerLocation = new int[2];
        public Form1()
        {
            mode = "easy";
            InitializeComponent();
            InitializeField();
        }

        public string SetMode
        {
            set
            {
                mode = value;
                for (int i = 0; i < field.Length; i++)
                {
                    for (int j = 0; j < field.Length; j++)
                    {
                        panel1.Controls.Remove(field[i][j]);
                    }
                }
                    InitializeField();
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
            if(playDone == false)
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
            }
            IsFinish();
        }

        private void IsFinish()
        {
            if(finish.Location == player.Location)
            {
                //playDone = true;
                if(mode == "hard")
                {
                    MessageBox.Show("Вітаю, ви дойшли до фініша. Ви пройшли насйкладніший рівень.", "Вітаю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Вітаю, ви дойшли до фініша. Рівень складності буде підвищено", "Вітаю!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                player.Location = new Point(0, 0);
                switch (mode)
                {
                    case "easy":
                        modeElement.setChildMode = "normal";
                        break;
                    case "normal":
                        modeElement.setChildMode = "hard";
                        break;
                    case "hard":
                        modeElement.setChildMode = "hard";
                        break;
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
    }
}
