namespace Number_system
{
    partial class Main_window
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Input_Text = new System.Windows.Forms.TextBox();
            this.Numeration = new System.Windows.Forms.NumericUpDown();
            this.Conclusion_button = new System.Windows.Forms.Button();
            this.Conclusion_label = new System.Windows.Forms.Label();
            this.Numeration_Con = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration_Con)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.Input_Text);
            this.panel1.Controls.Add(this.Numeration_Con);
            this.panel1.Controls.Add(this.Numeration);
            this.panel1.Controls.Add(this.Conclusion_button);
            this.panel1.Controls.Add(this.Conclusion_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Input_Text
            // 
            this.Input_Text.Location = new System.Drawing.Point(223, 123);
            this.Input_Text.Name = "Input_Text";
            this.Input_Text.Size = new System.Drawing.Size(372, 22);
            this.Input_Text.TabIndex = 3;
            // 
            // Numeration
            // 
            this.Numeration.AllowDrop = true;
            this.Numeration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeration.Location = new System.Drawing.Point(133, 123);
            this.Numeration.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeration.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numeration.Name = "Numeration";
            this.Numeration.Size = new System.Drawing.Size(60, 18);
            this.Numeration.TabIndex = 2;
            this.Numeration.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Conclusion_button
            // 
            this.Conclusion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Conclusion_button.Location = new System.Drawing.Point(325, 280);
            this.Conclusion_button.Name = "Conclusion_button";
            this.Conclusion_button.Size = new System.Drawing.Size(187, 35);
            this.Conclusion_button.TabIndex = 1;
            this.Conclusion_button.Text = "Вывод";
            this.Conclusion_button.UseVisualStyleBackColor = true;
            this.Conclusion_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Conclusion_label
            // 
            this.Conclusion_label.BackColor = System.Drawing.Color.White;
            this.Conclusion_label.Location = new System.Drawing.Point(223, 185);
            this.Conclusion_label.Name = "Conclusion_label";
            this.Conclusion_label.Size = new System.Drawing.Size(372, 23);
            this.Conclusion_label.TabIndex = 0;
            // 
            // Numeration_Con
            // 
            this.Numeration_Con.AllowDrop = true;
            this.Numeration_Con.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeration_Con.Location = new System.Drawing.Point(133, 185);
            this.Numeration_Con.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Numeration_Con.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Numeration_Con.Name = "Numeration_Con";
            this.Numeration_Con.Size = new System.Drawing.Size(60, 18);
            this.Numeration_Con.TabIndex = 2;
            this.Numeration_Con.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Main_window";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration_Con)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Conclusion_label;
        private System.Windows.Forms.Button Conclusion_button;
        private System.Windows.Forms.NumericUpDown Numeration;
        private System.Windows.Forms.TextBox Input_Text;
        private System.Windows.Forms.NumericUpDown Numeration_Con;
    }
}

