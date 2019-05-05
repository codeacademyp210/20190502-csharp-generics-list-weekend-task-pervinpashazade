namespace MyFormList
{
    partial class MyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.idBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.salaryBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.salaryLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.positionBox);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.positionLabel);
            this.panel1.Controls.Add(this.surnameBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 426);
            this.panel1.TabIndex = 0;
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.idBox.Location = new System.Drawing.Point(72, 28);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(145, 20);
            this.idBox.TabIndex = 12;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idLabel.Location = new System.Drawing.Point(15, 29);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(167, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 32);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // salaryBox
            // 
            this.salaryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.salaryBox.Location = new System.Drawing.Point(72, 158);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(145, 20);
            this.salaryBox.TabIndex = 10;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nameBox.Location = new System.Drawing.Point(72, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(145, 20);
            this.nameBox.TabIndex = 2;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salaryLabel.Location = new System.Drawing.Point(15, 159);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(42, 17);
            this.salaryLabel.TabIndex = 9;
            this.salaryLabel.Text = "Maaş";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(15, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(25, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Ad";
            // 
            // positionBox
            // 
            this.positionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.positionBox.Location = new System.Drawing.Point(72, 132);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(145, 20);
            this.positionBox.TabIndex = 8;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameLabel.Location = new System.Drawing.Point(15, 81);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(48, 17);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Soyad";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.positionLabel.Location = new System.Drawing.Point(15, 133);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 17);
            this.positionLabel.TabIndex = 7;
            this.positionLabel.Text = "Vəzifə";
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.surnameBox.Location = new System.Drawing.Point(72, 80);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(145, 20);
            this.surnameBox.TabIndex = 4;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.emailBox.Location = new System.Drawing.Point(72, 106);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(145, 20);
            this.emailBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailLabel.Location = new System.Drawing.Point(15, 107);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(254, 282);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 33);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 262);
            this.dataGridView1.TabIndex = 14;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panel1);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

