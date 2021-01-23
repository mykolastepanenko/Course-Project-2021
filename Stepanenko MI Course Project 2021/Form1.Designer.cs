
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
            this.button1 = new System.Windows.Forms.Button();
            for (int i = 0; i < myBtn.Length; i++)
            {
                this.myBtn[i] = new System.Windows.Forms.Button[30];
                for (int j = 0; j < myBtn.Length; j++)
                {
                    this.myBtn[i][j] = new System.Windows.Forms.Button();
                }
            }
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            //
            // myBtn
            //
            for (int i = 0; i < myBtn.Length; i++)
            {
                for (int j = 0; j < myBtn.Length; j++)
                {
                    this.myBtn[i][j].Location = new System.Drawing.Point(i * 25, (j+1) * 25);
                    this.myBtn[i][j].Name = "arr" + i + j;
                    this.myBtn[i][j].Size = new System.Drawing.Size(25, 25);
                }
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 691);
            this.Controls.Add(this.button1);
            for (int i = 0; i < myBtn.Length; i++)
            {
                for (int j = 0; j < myBtn.Length; j++)
                {
                    this.Controls.Add(this.myBtn[i][j]);
                }
            }
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button[][] myBtn = new System.Windows.Forms.Button[30][];
    }
}

