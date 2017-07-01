namespace final_year_project
{
    partial class excel
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choose_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.choose_txtbox = new System.Windows.Forms.TextBox();
            this.load_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(797, 419);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 36);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 419);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(84, 36);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 327);
            this.dataGridView1.TabIndex = 2;
            // 
            // choose_btn
            // 
            this.choose_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_btn.Location = new System.Drawing.Point(12, 12);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(84, 23);
            this.choose_btn.TabIndex = 3;
            this.choose_btn.Text = "Choose file";
            this.choose_btn.UseVisualStyleBackColor = true;
            this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(12, 57);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(84, 23);
            this.load_btn.TabIndex = 4;
            this.load_btn.Text = "Load sheet";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // choose_txtbox
            // 
            this.choose_txtbox.Location = new System.Drawing.Point(125, 15);
            this.choose_txtbox.Name = "choose_txtbox";
            this.choose_txtbox.Size = new System.Drawing.Size(152, 20);
            this.choose_txtbox.TabIndex = 5;
            // 
            // load_textBox
            // 
            this.load_textBox.Location = new System.Drawing.Point(125, 60);
            this.load_textBox.Name = "load_textBox";
            this.load_textBox.Size = new System.Drawing.Size(152, 20);
            this.load_textBox.TabIndex = 6;
            // 
            // excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 471);
            this.Controls.Add(this.load_textBox);
            this.Controls.Add(this.choose_txtbox);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.exit_btn);
            this.Name = "excel";
            this.Text = "GRADE FROM EXCELL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.TextBox choose_txtbox;
        private System.Windows.Forms.TextBox load_textBox;
    }
}