namespace InventarioBar
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FamilyBox = new System.Windows.Forms.TextBox();
            this.CaloriesBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.RadioButton();
            this.YesButton = new System.Windows.Forms.RadioButton();
            this.Gluten = new System.Windows.Forms.GroupBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.Gluten.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(70, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 20);
            this.NameBox.TabIndex = 1;
            // 
            // FamilyBox
            // 
            this.FamilyBox.Location = new System.Drawing.Point(70, 80);
            this.FamilyBox.Name = "FamilyBox";
            this.FamilyBox.Size = new System.Drawing.Size(120, 20);
            this.FamilyBox.TabIndex = 2;
            // 
            // CaloriesBox
            // 
            this.CaloriesBox.Location = new System.Drawing.Point(70, 106);
            this.CaloriesBox.Name = "CaloriesBox";
            this.CaloriesBox.Size = new System.Drawing.Size(120, 20);
            this.CaloriesBox.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(227, 54);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 267);
            this.textBox5.TabIndex = 15;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(70, 178);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(51, 20);
            this.Create.TabIndex = 5;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(70, 203);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(51, 20);
            this.Read.TabIndex = 6;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(70, 230);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(51, 20);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(70, 256);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(51, 20);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calories";
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(70, 301);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(51, 20);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(139, 301);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(51, 20);
            this.Export.TabIndex = 14;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.Location = new System.Drawing.Point(54, 10);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(39, 17);
            this.NoButton.TabIndex = 15;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // YesButton
            // 
            this.YesButton.AutoSize = true;
            this.YesButton.Checked = true;
            this.YesButton.Location = new System.Drawing.Point(99, 10);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(43, 17);
            this.YesButton.TabIndex = 16;
            this.YesButton.TabStop = true;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // Gluten
            // 
            this.Gluten.Controls.Add(this.NoButton);
            this.Gluten.Controls.Add(this.YesButton);
            this.Gluten.Location = new System.Drawing.Point(16, 132);
            this.Gluten.Name = "Gluten";
            this.Gluten.Size = new System.Drawing.Size(174, 40);
            this.Gluten.TabIndex = 4;
            this.Gluten.TabStop = false;
            this.Gluten.Text = "Gluten";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(70, 28);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(120, 20);
            this.IdBox.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(14, 35);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(16, 13);
            this.Id.TabIndex = 19;
            this.Id.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 416);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.Gluten);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.CaloriesBox);
            this.Controls.Add(this.FamilyBox);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Inventario Bar";
            this.Gluten.ResumeLayout(false);
            this.Gluten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox FamilyBox;
        private System.Windows.Forms.TextBox CaloriesBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.RadioButton NoButton;
        private System.Windows.Forms.RadioButton YesButton;
        private System.Windows.Forms.GroupBox Gluten;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label Id;
    }
}

