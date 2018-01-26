namespace MasterMind
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.number1 = new System.Windows.Forms.TextBox();
            this.Attempts = new System.Windows.Forms.ListBox();
            this.Matches = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number3 = new System.Windows.Forms.TextBox();
            this.number4 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(38, 345);
            this.number1.MaxLength = 1;
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(45, 41);
            this.number1.TabIndex = 0;
            this.number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number1.TextChanged += new System.EventHandler(this.WriteNumber);
            // 
            // Attempts
            // 
            this.Attempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attempts.FormattingEnabled = true;
            this.Attempts.ItemHeight = 25;
            this.Attempts.Location = new System.Drawing.Point(38, 64);
            this.Attempts.Name = "Attempts";
            this.Attempts.Size = new System.Drawing.Size(131, 254);
            this.Attempts.TabIndex = 4;
            // 
            // Matches
            // 
            this.Matches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matches.FormattingEnabled = true;
            this.Matches.ItemHeight = 25;
            this.Matches.Location = new System.Drawing.Point(206, 64);
            this.Matches.Name = "Matches";
            this.Matches.Size = new System.Drawing.Size(131, 254);
            this.Matches.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "GO!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attempts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Matches";
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(89, 345);
            this.number2.MaxLength = 1;
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(45, 41);
            this.number2.TabIndex = 1;
            this.number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number2.TextChanged += new System.EventHandler(this.WriteNumber);
            // 
            // number3
            // 
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(140, 345);
            this.number3.MaxLength = 1;
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(45, 41);
            this.number3.TabIndex = 2;
            this.number3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number3.TextChanged += new System.EventHandler(this.WriteNumber);
            // 
            // number4
            // 
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(190, 345);
            this.number4.MaxLength = 1;
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(45, 41);
            this.number4.TabIndex = 3;
            this.number4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number4.TextChanged += new System.EventHandler(this.WriteNumber);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 433);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "easy";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(129, 433);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "hard";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 491);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matches);
            this.Controls.Add(this.Attempts);
            this.Controls.Add(this.number1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MasterMind!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.TextBox number4;
        private System.Windows.Forms.ListBox Attempts;
        private System.Windows.Forms.ListBox Matches;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

