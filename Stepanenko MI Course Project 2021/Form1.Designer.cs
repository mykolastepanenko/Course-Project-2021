
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorName = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.mode1 = new Stepanenko_MI_Course_Project_2021.Mode();
            this.result1 = new Stepanenko_MI_Course_Project_2021.Result();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.autorMenuItem,
            this.instructionItem,
            this.helpBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.exitToolStripMenuItem.Text = "Закрити";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CloseProgram);
            // 
            // autorMenuItem
            // 
            this.autorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorName});
            this.autorMenuItem.Name = "autorMenuItem";
            this.autorMenuItem.Size = new System.Drawing.Size(61, 23);
            this.autorMenuItem.Text = "Автор";
            // 
            // authorName
            // 
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(338, 24);
            this.authorName.Text = "Отримати інформацію про розробника";
            this.authorName.Click += new System.EventHandler(this.AuthorName_Click);
            // 
            // instructionItem
            // 
            this.instructionItem.Name = "instructionItem";
            this.instructionItem.Size = new System.Drawing.Size(87, 23);
            this.instructionItem.Text = "Інструкція";
            this.instructionItem.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(73, 23);
            this.helpBtn.Text = "&Довідка";
            this.helpBtn.Click += new System.EventHandler(this.Helper);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 382);
            this.panel1.TabIndex = 3;
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(88, 444);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(335, 19);
            this.info.TabIndex = 5;
            this.info.Text = "Для переміщення використовуйте клавіші w, a, s, d.";
            // 
            // mode1
            // 
            this.mode1.Location = new System.Drawing.Point(587, 27);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(316, 461);
            this.mode1.TabIndex = 6;
            // 
            // result1
            // 
            this.result1.Location = new System.Drawing.Point(944, 30);
            this.result1.Name = "result1";
            this.result1.SetScore = "";
            this.result1.Size = new System.Drawing.Size(390, 461);
            this.result1.TabIndex = 7;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Course-Project-2021\\Stepanenko MI Course Project 2021\\bin\\Debug\\netcoreapp3.1\\" +
    "help.html";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator1,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(196, 106);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.toolStripMenuItem1.Text = "Автор";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.AuthorName_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 24);
            this.toolStripMenuItem2.Text = "Інструкція";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Instruction_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 24);
            this.toolStripMenuItem3.Text = "Довідка";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Helper);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(195, 24);
            this.toolStripMenuItem4.Text = "Закрити програму";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.CloseProgram);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 488);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.info);
            this.Controls.Add(this.mode1);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Курсовий проект студента 471 групи Степаненка Миколая Ігоровича. 2021 рік.";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpBtn;
        private System.Windows.Forms.ToolStripMenuItem autorMenuItem;

        private System.Windows.Forms.ToolStripMenuItem authorName;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem instructionItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

