namespace DBS_project
{
    partial class Contacts_And_Accounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residential_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select From List The Contact Type You Want And/Or Search Your Desired Contact";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Contact Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter Contacts";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(344, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 21);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Contact1,
            this.Contact2,
            this.Residential_Address});
            this.dataGridView1.Location = new System.Drawing.Point(24, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Contact1
            // 
            this.Contact1.HeaderText = "Contact1";
            this.Contact1.Name = "Contact1";
            // 
            // Contact2
            // 
            this.Contact2.HeaderText = "Contact2";
            this.Contact2.Name = "Contact2";
            // 
            // Residential_Address
            // 
            this.Residential_Address.HeaderText = "Residential Address";
            this.Residential_Address.Name = "Residential_Address";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Cnic,
            this.Job,
            this.Hiredate,
            this.Street,
            this.City,
            this.Zip,
            this.Country,
            this.Contact11,
            this.Contact22});
            this.dataGridView2.Location = new System.Drawing.Point(24, 270);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(516, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            // 
            // Cnic
            // 
            this.Cnic.HeaderText = "CNIC";
            this.Cnic.Name = "Cnic";
            // 
            // Job
            // 
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            // 
            // Hiredate
            // 
            this.Hiredate.HeaderText = "HireDate";
            this.Hiredate.Name = "Hiredate";
            // 
            // Street
            // 
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // Contact11
            // 
            this.Contact11.HeaderText = "Contact1";
            this.Contact11.Name = "Contact11";
            // 
            // Contact22
            // 
            this.Contact22.HeaderText = "Contact2";
            this.Contact22.Name = "Contact22";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.UserName,
            this.Identifier});
            this.dataGridView3.Location = new System.Drawing.Point(24, 452);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(516, 150);
            this.dataGridView3.TabIndex = 6;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Username";
            this.UserName.Name = "UserName";
            // 
            // Identifier
            // 
            this.Identifier.HeaderText = "Identifier";
            this.Identifier.Name = "Identifier";
            // 
            // Contacts_And_Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 630);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Contacts_And_Accounts";
            this.Text = "Contacts_And_Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Residential_Address;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact22;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifier;
    }
}