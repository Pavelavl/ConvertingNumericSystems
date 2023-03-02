namespace ConvertingForm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterNum = new System.Windows.Forms.TextBox();
            this.enterFromBase = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.enterToBase = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(140, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Введите число";
            // 
            // enterNum
            // 
            this.enterNum.BackColor = System.Drawing.SystemColors.Window;
            this.enterNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterNum.Location = new System.Drawing.Point(289, 200);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(132, 33);
            this.enterNum.TabIndex = 1;
            // 
            // enterFromBase
            // 
            this.enterFromBase.BackColor = System.Drawing.SystemColors.Window;
            this.enterFromBase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterFromBase.Location = new System.Drawing.Point(289, 252);
            this.enterFromBase.Name = "enterFromBase";
            this.enterFromBase.Size = new System.Drawing.Size(132, 33);
            this.enterFromBase.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(140, 255);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 26);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "Начальная СС";
            // 
            // enterToBase
            // 
            this.enterToBase.BackColor = System.Drawing.SystemColors.Window;
            this.enterToBase.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterToBase.Location = new System.Drawing.Point(289, 303);
            this.enterToBase.Name = "enterToBase";
            this.enterToBase.Size = new System.Drawing.Size(132, 33);
            this.enterToBase.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(140, 306);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 26);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Конечная СС";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(197, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перевести";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(237, 459);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 26);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Результат:";
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.SystemColors.Window;
            this.Out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Out.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Out.Location = new System.Drawing.Point(217, 491);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(132, 26);
            this.Out.TabIndex = 8;
            this.Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 696);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enterToBase);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.enterFromBase);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.textBox1);
            this.Name = "Main";
            this.Text = "Converting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox enterNum;
        private TextBox enterFromBase;
        private TextBox textBox4;
        private TextBox enterToBase;
        private TextBox textBox6;
        private Button button1;
        private TextBox textBox7;
        private TextBox Out;
    }
}