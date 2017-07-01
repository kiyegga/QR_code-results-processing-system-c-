namespace final_year_project
{
    partial class bio_data
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.class_cm = new System.Windows.Forms.ComboBox();
            this.year_cm = new System.Windows.Forms.ComboBox();
            this.term_cm = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.student_no_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.marks_txt = new System.Windows.Forms.TextBox();
            this.subject_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exam_type = new System.Windows.Forms.ComboBox();
            this.update_text = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(916, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(52, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "ADD STUDENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(247, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "VIEW";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(395, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 32);
            this.button5.TabIndex = 5;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(523, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "YEAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TERM";
            // 
            // class_cm
            // 
            this.class_cm.FormattingEnabled = true;
            this.class_cm.Items.AddRange(new object[] {
            "senior one ",
            "senior two",
            "senior three",
            "senior four"});
            this.class_cm.Location = new System.Drawing.Point(141, 76);
            this.class_cm.Name = "class_cm";
            this.class_cm.Size = new System.Drawing.Size(140, 21);
            this.class_cm.TabIndex = 10;
            // 
            // year_cm
            // 
            this.year_cm.FormattingEnabled = true;
            this.year_cm.Items.AddRange(new object[] {
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
            this.year_cm.Location = new System.Drawing.Point(366, 79);
            this.year_cm.Name = "year_cm";
            this.year_cm.Size = new System.Drawing.Size(140, 21);
            this.year_cm.TabIndex = 11;
            // 
            // term_cm
            // 
            this.term_cm.FormattingEnabled = true;
            this.term_cm.Items.AddRange(new object[] {
            "Term one",
            "Term two",
            "Term three"});
            this.term_cm.Location = new System.Drawing.Point(575, 82);
            this.term_cm.Name = "term_cm";
            this.term_cm.Size = new System.Drawing.Size(122, 21);
            this.term_cm.TabIndex = 12;
            this.term_cm.SelectedIndexChanged += new System.EventHandler(this.term_cm_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(978, 287);
            this.dataGridView1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "STUDENT_NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "STUDENT_NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "SUBJECT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(797, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "MARKS";
            // 
            // student_no_txt
            // 
            this.student_no_txt.Location = new System.Drawing.Point(177, 127);
            this.student_no_txt.Name = "student_no_txt";
            this.student_no_txt.Size = new System.Drawing.Size(123, 20);
            this.student_no_txt.TabIndex = 22;
            this.student_no_txt.TextChanged += new System.EventHandler(this.student_no_txt_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(420, 130);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(121, 20);
            this.name_txt.TabIndex = 23;
            // 
            // marks_txt
            // 
            this.marks_txt.Location = new System.Drawing.Point(869, 134);
            this.marks_txt.Name = "marks_txt";
            this.marks_txt.Size = new System.Drawing.Size(131, 20);
            this.marks_txt.TabIndex = 24;
            // 
            // subject_txt
            // 
            this.subject_txt.Location = new System.Drawing.Point(649, 134);
            this.subject_txt.Name = "subject_txt";
            this.subject_txt.Size = new System.Drawing.Size(122, 20);
            this.subject_txt.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "TYPE OF EXAM";
            // 
            // exam_type
            // 
            this.exam_type.FormattingEnabled = true;
            this.exam_type.Items.AddRange(new object[] {
            "Beginning of Term",
            "Mid Term",
            "End of Term"});
            this.exam_type.Location = new System.Drawing.Point(879, 82);
            this.exam_type.Name = "exam_type";
            this.exam_type.Size = new System.Drawing.Size(121, 21);
            this.exam_type.TabIndex = 27;
            // 
            // update_text
            // 
            this.update_text.Location = new System.Drawing.Point(658, 14);
            this.update_text.Name = "update_text";
            this.update_text.Size = new System.Drawing.Size(85, 33);
            this.update_text.TabIndex = 28;
            this.update_text.Text = "UPDATE";
            this.update_text.UseVisualStyleBackColor = true;
            this.update_text.Click += new System.EventHandler(this.update_text_Click);
            // 
            // bio_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 551);
            this.Controls.Add(this.update_text);
            this.Controls.Add(this.exam_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.subject_txt);
            this.Controls.Add(this.marks_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.student_no_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.term_cm);
            this.Controls.Add(this.year_cm);
            this.Controls.Add(this.class_cm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bio_data";
            this.Text = "STUDENT BIO DATA";
            this.Load += new System.EventHandler(this.bio_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox class_cm;
        private System.Windows.Forms.ComboBox year_cm;
        private System.Windows.Forms.ComboBox term_cm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox student_no_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox marks_txt;
        private System.Windows.Forms.TextBox subject_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox exam_type;
        private System.Windows.Forms.Button update_text;
    }
}