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
            InitializeComponent();
            InitializeField();
        }
        private void InitializeField()
        {
            for (int i = 0; i < field.Length; i++)
            {
                this.field[i] = new System.Windows.Forms.Button[30];
                for (int j = 0; j < field.Length; j++)
                {
                    this.field[i][j] = new System.Windows.Forms.Button();
                }
            }
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    this.field[i][j].Location = new System.Drawing.Point(i * 25, j * 25);
                    this.field[i][j].Name = "arr" + i + j;
                    this.field[i][j].Size = new System.Drawing.Size(25, 25);
                }
            }
            InitializePlayer();
            InitializeBlock();
            InitializeFinish();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field.Length; j++)
                {
                    this.panel1.Controls.Add(this.field[i][j]);
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
            this.blocks = new Button[field.Length / 2];
            for(int i = 0; i < blocks.Length; i++)
            {
                blocks[i] = new Button();
                blocks[i].BackColor = Color.Black;
                blocks[i].Size = new System.Drawing.Size(25, 25);
                this.panel1.Controls.Add(blocks[i]);
            }
            blocks[0].Location = new System.Drawing.Point(0, 50);
            blocks[1].Location = new System.Drawing.Point(50, 50);
            blocks[2].Location = new System.Drawing.Point(100, 50);
            blocks[3].Location = new System.Drawing.Point(50, 0);
            blocks[4].Location = new System.Drawing.Point(0, 150);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void IsFinish()
        {
            if(finish.Location == player.Location)
            {
                MessageBox.Show("Вітаю, ви дойшли до фініша");
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
