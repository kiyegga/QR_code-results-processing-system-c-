namespace final_year_project
{
    partial class Grade
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.class_cm = new System.Windows.Forms.ComboBox();
            this.term_cm = new System.Windows.Forms.ComboBox();
            this.subject_cm = new System.Windows.Forms.ComboBox();
            this.excel = new System.Windows.Forms.Button();
            this.year_cm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(810, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUBJECT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TERM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "YEAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "CLASS";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(731, 480);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnload
            // 
            this.btnload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(731, 72);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(67, 30);
            this.btnload.TabIndex = 14;
            this.btnload.Text = "LOAD";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // class_cm
            // 
            this.class_cm.FormattingEnabled = true;
            this.class_cm.Items.AddRange(new object[] {
            "Senior one ",
            "Senior two",
            "Senior three",
            "Senior four"});
            this.class_cm.Location = new System.Drawing.Point(79, 72);
            this.class_cm.Name = "class_cm";
            this.class_cm.Size = new System.Drawing.Size(87, 21);
            this.class_cm.TabIndex = 15;
            this.class_cm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // term_cm
            // 
            this.term_cm.FormattingEnabled = true;
            this.term_cm.Items.AddRange(new object[] {
            "First term",
            "Second term",
            "Third term"});
            this.term_cm.Location = new System.Drawing.Point(390, 72);
            this.term_cm.Name = "term_cm";
            this.term_cm.Size = new System.Drawing.Size(96, 21);
            this.term_cm.TabIndex = 16;
            // 
            // subject_cm
            // 
            this.subject_cm.FormattingEnabled = true;
            this.subject_cm.Items.AddRange(new object[] {
            "History",
            "English",
            "Math",
            "Physics",
            "Chemistry",
            "Geography",
            "CRE",
            "Commerce",
            "Entreprenuership",
            "Computer",
            "Foods and Nutrition",
            "Music",
            "French",
            "Germany",
            "Luganda",
            "Kiswahiri",
            ""});
            this.subject_cm.Location = new System.Drawing.Point(572, 72);
            this.subject_cm.Name = "subject_cm";
            this.subject_cm.Size = new System.Drawing.Size(95, 21);
            this.subject_cm.TabIndex = 17;
            // 
            // excel
            // 
            this.excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel.Location = new System.Drawing.Point(446, 430);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(126, 36);
            this.excel.TabIndex = 18;
            this.excel.Text = "USE EXCEL SHEET";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // year_cm
            // 
            this.year_cm.FormattingEnabled = true;
            this.year_cm.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.year_cm.Location = new System.Drawing.Point(227, 75);
            this.year_cm.Name = "year_cm";
            this.year_cm.Size = new System.Drawing.Size(96, 21);
            this.year_cm.TabIndex = 21;
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 526);
            this.Controls.Add(this.year_cm);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.subject_cm);
            this.Controls.Add(this.term_cm);
            this.Controls.Add(this.class_cm);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Grade";
            this.Text = "Grade";
            this.Load += new System.EventHandler(this.Grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox class_cm;
        private System.Windows.Forms.ComboBox term_cm;
        private System.Windows.Forms.ComboBox subject_cm;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.ComboBox year_cm;
    }
}