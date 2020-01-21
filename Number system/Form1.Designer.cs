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
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Input_Text = new System.Windows.Forms.TextBox();
            this.Numeration_Con = new System.Windows.Forms.NumericUpDown();
            this.Numeration = new System.Windows.Forms.NumericUpDown();
            this.Conclusion_button = new System.Windows.Forms.Button();
            this.Conclusion_texBox = new System.Windows.Forms.TextBox();
            this.Label_Close = new System.Windows.Forms.Label();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration_Con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(112)))), ((int)(((byte)(35)))));
            this.Main_Panel.Controls.Add(this.Label_Close);
            this.Main_Panel.Controls.Add(this.Conclusion_texBox);
            this.Main_Panel.Controls.Add(this.Input_Text);
            this.Main_Panel.Controls.Add(this.Numeration_Con);
            this.Main_Panel.Controls.Add(this.Numeration);
            this.Main_Panel.Controls.Add(this.Conclusion_button);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(633, 550);
            this.Main_Panel.TabIndex = 0;
            this.Main_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.Main_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            // 
            // Input_Text
            // 
            this.Input_Text.Location = new System.Drawing.Point(176, 162);
            this.Input_Text.Name = "Input_Text";
            this.Input_Text.Size = new System.Drawing.Size(372, 22);
            this.Input_Text.TabIndex = 3;
            // 
            // Numeration_Con
            // 
            this.Numeration_Con.AllowDrop = true;
            this.Numeration_Con.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeration_Con.Location = new System.Drawing.Point(73, 228);
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
            10,
            0,
            0,
            0});
            // 
            // Numeration
            // 
            this.Numeration.AllowDrop = true;
            this.Numeration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Numeration.Location = new System.Drawing.Point(73, 162);
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
            this.Conclusion_button.Location = new System.Drawing.Point(222, 352);
            this.Conclusion_button.Name = "Conclusion_button";
            this.Conclusion_button.Size = new System.Drawing.Size(187, 35);
            this.Conclusion_button.TabIndex = 1;
            this.Conclusion_button.Text = "Вывод";
            this.Conclusion_button.UseVisualStyleBackColor = true;
            this.Conclusion_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Conclusion_texBox
            // 
            this.Conclusion_texBox.Location = new System.Drawing.Point(176, 228);
            this.Conclusion_texBox.Name = "Conclusion_texBox";
            this.Conclusion_texBox.ReadOnly = true;
            this.Conclusion_texBox.Size = new System.Drawing.Size(372, 22);
            this.Conclusion_texBox.TabIndex = 3;
            // 
            // Label_Close
            // 
            this.Label_Close.AutoSize = true;
            this.Label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Close.Location = new System.Drawing.Point(607, 0);
            this.Label_Close.Name = "Label_Close";
            this.Label_Close.Size = new System.Drawing.Size(26, 25);
            this.Label_Close.TabIndex = 4;
            this.Label_Close.Text = "X";
            this.Label_Close.Click += new System.EventHandler(this.Label_Close_Click);
            this.Label_Close.MouseEnter += new System.EventHandler(this.Label_Close_MouseEnter);
            this.Label_Close.MouseLeave += new System.EventHandler(this.Label_Close_MouseLeave);
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 550);
            this.Controls.Add(this.Main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_window";
            this.Text = "Form1";
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration_Con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Button Conclusion_button;
        private System.Windows.Forms.NumericUpDown Numeration;
        private System.Windows.Forms.TextBox Input_Text;
        private System.Windows.Forms.NumericUpDown Numeration_Con;
        private System.Windows.Forms.TextBox Conclusion_texBox;
        private System.Windows.Forms.Label Label_Close;
    }
}

