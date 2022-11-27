namespace CourseFormApp
{
    partial class CourseFormApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.HeightTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightButton = new System.Windows.Forms.Button();
            this.XBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YBox = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.AddRB = new System.Windows.Forms.RadioButton();
            this.SubRB = new System.Windows.Forms.RadioButton();
            this.MulRB = new System.Windows.Forms.RadioButton();
            this.DivRB = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(698, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Do not Clicks !";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RestartButton.Location = new System.Drawing.Point(615, 386);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(77, 23);
            this.RestartButton.TabIndex = 2;
            this.RestartButton.Text = "Restatrt";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // HeightTexBox
            // 
            this.HeightTexBox.Location = new System.Drawing.Point(407, 30);
            this.HeightTexBox.Name = "HeightTexBox";
            this.HeightTexBox.Size = new System.Drawing.Size(356, 23);
            this.HeightTexBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your height";
            // 
            // HeightButton
            // 
            this.HeightButton.Location = new System.Drawing.Point(407, 59);
            this.HeightButton.Name = "HeightButton";
            this.HeightButton.Size = new System.Drawing.Size(75, 23);
            this.HeightButton.TabIndex = 5;
            this.HeightButton.Text = "Run";
            this.HeightButton.UseVisualStyleBackColor = true;
            this.HeightButton.Click += new System.EventHandler(this.HeightButton_Click);
            // 
            // XBox
            // 
            this.XBox.Location = new System.Drawing.Point(12, 145);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(296, 23);
            this.XBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "X number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y Number";
            // 
            // YBox
            // 
            this.YBox.Location = new System.Drawing.Point(12, 199);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(296, 23);
            this.YBox.TabIndex = 9;
            // 
            // Wynik
            // 
            this.Wynik.BackColor = System.Drawing.SystemColors.Info;
            this.Wynik.Location = new System.Drawing.Point(12, 387);
            this.Wynik.Name = "Wynik";
            this.Wynik.ReadOnly = true;
            this.Wynik.Size = new System.Drawing.Size(296, 23);
            this.Wynik.TabIndex = 10;
            // 
            // Calculate
            // 
            this.Calculate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Calculate.Location = new System.Drawing.Point(12, 358);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(77, 23);
            this.Calculate.TabIndex = 11;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // AddRB
            // 
            this.AddRB.AutoSize = true;
            this.AddRB.Location = new System.Drawing.Point(12, 231);
            this.AddRB.Name = "AddRB";
            this.AddRB.Size = new System.Drawing.Size(47, 19);
            this.AddRB.TabIndex = 12;
            this.AddRB.TabStop = true;
            this.AddRB.Text = "Add";
            this.AddRB.UseVisualStyleBackColor = true;
            // 
            // SubRB
            // 
            this.SubRB.AutoSize = true;
            this.SubRB.Location = new System.Drawing.Point(12, 256);
            this.SubRB.Name = "SubRB";
            this.SubRB.Size = new System.Drawing.Size(74, 19);
            this.SubRB.TabIndex = 13;
            this.SubRB.TabStop = true;
            this.SubRB.Text = "Substract";
            this.SubRB.UseVisualStyleBackColor = true;
            // 
            // MulRB
            // 
            this.MulRB.AutoSize = true;
            this.MulRB.Location = new System.Drawing.Point(12, 281);
            this.MulRB.Name = "MulRB";
            this.MulRB.Size = new System.Drawing.Size(69, 19);
            this.MulRB.TabIndex = 14;
            this.MulRB.TabStop = true;
            this.MulRB.Text = "Multiply";
            this.MulRB.UseVisualStyleBackColor = true;
            // 
            // DivRB
            // 
            this.DivRB.AutoSize = true;
            this.DivRB.Location = new System.Drawing.Point(12, 306);
            this.DivRB.Name = "DivRB";
            this.DivRB.Size = new System.Drawing.Size(58, 19);
            this.DivRB.TabIndex = 15;
            this.DivRB.TabStop = true;
            this.DivRB.Text = "Divide";
            this.DivRB.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(494, 60);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(314, 231);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(295, 179);
            this.LogBox.TabIndex = 17;
            this.LogBox.Text = "Logs: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Logs";
            // 
            // CourseFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.DivRB);
            this.Controls.Add(this.MulRB);
            this.Controls.Add(this.SubRB);
            this.Controls.Add(this.AddRB);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.HeightButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightTexBox);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CourseFormApp";
            this.Text = "ALX Course Form APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button RestartButton;
        private TextBox HeightTexBox;
        private Label label1;
        private Button HeightButton;
        private TextBox XBox;
        private Label label2;
        private Label label3;
        private TextBox YBox;
        private TextBox Wynik;
        private Button Calculate;
        private RadioButton AddRB;
        private RadioButton SubRB;
        private RadioButton MulRB;
        private RadioButton DivRB;
        private MonthCalendar monthCalendar1;
        private TextBox LogBox;
        private Label label4;
    }
}