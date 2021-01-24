
namespace Stepanenko_MI_Course_Project_2021
{
    partial class Mode
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.easyMode = new System.Windows.Forms.RadioButton();
            this.normalMode = new System.Windows.Forms.RadioButton();
            this.hardMode = new System.Windows.Forms.RadioButton();
            this.btn_selectMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рівень складності";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // easyMode
            // 
            this.easyMode.AutoSize = true;
            this.easyMode.Checked = true;
            this.easyMode.Location = new System.Drawing.Point(9, 47);
            this.easyMode.Name = "easyMode";
            this.easyMode.Size = new System.Drawing.Size(118, 23);
            this.easyMode.TabIndex = 1;
            this.easyMode.TabStop = true;
            this.easyMode.Text = "Легкий режим";
            this.easyMode.UseVisualStyleBackColor = true;
            // 
            // normalMode
            // 
            this.normalMode.AutoSize = true;
            this.normalMode.Location = new System.Drawing.Point(9, 77);
            this.normalMode.Name = "normalMode";
            this.normalMode.Size = new System.Drawing.Size(132, 23);
            this.normalMode.TabIndex = 2;
            this.normalMode.Text = "Середній режим";
            this.normalMode.UseVisualStyleBackColor = true;
            // 
            // hardMode
            // 
            this.hardMode.AutoSize = true;
            this.hardMode.Location = new System.Drawing.Point(9, 107);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(136, 23);
            this.hardMode.TabIndex = 3;
            this.hardMode.Text = "Складний режим";
            this.hardMode.UseVisualStyleBackColor = true;
            // 
            // btn_selectMode
            // 
            this.btn_selectMode.Location = new System.Drawing.Point(45, 164);
            this.btn_selectMode.Name = "btn_selectMode";
            this.btn_selectMode.Size = new System.Drawing.Size(190, 26);
            this.btn_selectMode.TabIndex = 4;
            this.btn_selectMode.Text = "Запустити гру";
            this.btn_selectMode.UseVisualStyleBackColor = true;
            this.btn_selectMode.Click += new System.EventHandler(this.btn_selectMode_Click);
            // 
            // Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_selectMode);
            this.Controls.Add(this.hardMode);
            this.Controls.Add(this.normalMode);
            this.Controls.Add(this.easyMode);
            this.Controls.Add(this.label1);
            this.Name = "Mode";
            this.Size = new System.Drawing.Size(299, 213);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easyMode;
        private System.Windows.Forms.RadioButton normalMode;
        private System.Windows.Forms.RadioButton hardMode;
        private System.Windows.Forms.Button btn_selectMode;
    }
}
