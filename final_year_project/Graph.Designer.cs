namespace final_year_project
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.class_cm = new System.Windows.Forms.ComboBox();
            this.subject_cm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // class_cm
            // 
            this.class_cm.FormattingEnabled = true;
            this.class_cm.Items.AddRange(new object[] {
            "SENIOR ONE",
            "SENIOR TWO",
            "SENIOR THREE",
            "SENIOR FOUR"});
            this.class_cm.Location = new System.Drawing.Point(227, 226);
            this.class_cm.Name = "class_cm";
            this.class_cm.Size = new System.Drawing.Size(121, 21);
            this.class_cm.TabIndex = 1;
            // 
            // subject_cm
            // 
            this.subject_cm.FormattingEnabled = true;
            this.subject_cm.Items.AddRange(new object[] {
            "Physics",
            "Math",
            "Geography",
            "History",
            "Chemistry",
            "Commerce",
            "CRE"});
            this.subject_cm.Location = new System.Drawing.Point(227, 276);
            this.subject_cm.Name = "subject_cm";
            this.subject_cm.Size = new System.Drawing.Size(121, 21);
            this.subject_cm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.Location = new System.Drawing.Point(196, 326);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 43);
            this.load.TabIndex = 7;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "Annual perfomance";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(434, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "Annual perfomance";
            series2.Legend = "Legend1";
            series2.Name = "marks";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(376, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 512);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subject_cm);
            this.Controls.Add(this.class_cm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox class_cm;
        private System.Windows.Forms.ComboBox subject_cm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}