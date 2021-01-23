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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                if(player.Location.Y != 0)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X, player.Location.Y - 25);
                }
            }
            if (e.KeyCode == Keys.S)
            {
                if(player.Location.Y != field.Length * 25 - 25)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X, player.Location.Y + 25);
                }
            }
            if (e.KeyCode == Keys.A)
            {
                if(player.Location.X != 0)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X - 25, player.Location.Y);
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if(player.Location.X != field.Length * 25 - 25)
                {
                    this.player.Location = new System.Drawing.Point(player.Location.X + 25, player.Location.Y);
                }
            }
        }
    }
}
