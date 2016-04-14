namespace DBS_project
{
    partial class Vehicle_Inventory
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engine_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chasis_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chasis_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fuel_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body_Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model Year:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(587, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Make,
            this.Model,
            this.Engine_No,
            this.Chasis_,
            this.Chasis_No,
            this.Year,
            this.Color,
            this.Mileage,
            this.Fuel_Type,
            this.Body_Style,
            this.Transmission,
            this.Cylinder,
            this.PurchasePrice});
            this.dataGridView1.Location = new System.Drawing.Point(32, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Engine_No
            // 
            this.Engine_No.HeaderText = "Engine No.";
            this.Engine_No.Name = "Engine_No";
            // 
            // Chasis_
            // 
            this.Chasis_.HeaderText = "Column1";
            this.Chasis_.Name = "Chasis_";
            // 
            // Chasis_No
            // 
            this.Chasis_No.HeaderText = "Chasis No.";
            this.Chasis_No.Name = "Chasis_No";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Mileage
            // 
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            // 
            // Fuel_Type
            // 
            this.Fuel_Type.HeaderText = "Fuel Type";
            this.Fuel_Type.Name = "Fuel_Type";
            // 
            // Body_Style
            // 
            this.Body_Style.HeaderText = "Body Style";
            this.Body_Style.Name = "Body_Style";
            // 
            // Transmission
            // 
            this.Transmission.HeaderText = "Transmission";
            this.Transmission.Name = "Transmission";
            // 
            // Cylinder
            // 
            this.Cylinder.HeaderText = "Cylinder";
            this.Cylinder.Name = "Cylinder";
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search Inventory";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vehicle_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Vehicle_Inventory";
            this.Text = "Vehicle_Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engine_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chasis_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chasis_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fuel_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body_Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cylinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.Button button1;
    }
}