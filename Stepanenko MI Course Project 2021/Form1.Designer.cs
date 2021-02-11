
using System;

namespace Stepanenko_MI_Course_Project_2021
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.mode1 = new Stepanenko_MI_Course_Project_2021.Mode();
            this.result1 = new Stepanenko_MI_Course_Project_2021.Result();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 358);
            this.panel1.TabIndex = 3;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(596, 460);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(335, 19);
            this.info.TabIndex = 5;
            this.info.Text = "Для переміщення використовуйте клавіші w, a, s, d.";
            // 
            // mode1
            // 
            this.mode1.Location = new System.Drawing.Point(596, 44);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(343, 413);
            this.mode1.TabIndex = 6;
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(956, 44);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(390, 413);
            this.result1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 488);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.mode1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button[][] field = new System.Windows.Forms.Button[10][];
        private System.Windows.Forms.Button player = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button finish = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button[] blocks;
        private int counter = 0;
        private string mode;
        private bool isStart;
        private bool isFinish;
        private System.Windows.Forms.Panel panel1;
        private Mode modeElement;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private DateTime score;
        private DateTime timeStart;
        private DateTime timeFinish;
        private Mode mode1;
        private Result result1;
    }
}

