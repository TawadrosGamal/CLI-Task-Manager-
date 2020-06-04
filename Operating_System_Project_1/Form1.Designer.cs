namespace Operating_System_Project_1
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
            this.proc_lab = new System.Windows.Forms.Label();
            this.st_btn = new System.Windows.Forms.Button();
            this.ed_btn = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.ls1 = new System.Windows.Forms.ListView();
            this.processname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processcpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proc_lab
            // 
            this.proc_lab.Location = new System.Drawing.Point(25, 48);
            this.proc_lab.Name = "proc_lab";
            this.proc_lab.Size = new System.Drawing.Size(100, 23);
            this.proc_lab.TabIndex = 0;
            this.proc_lab.Text = "Process Name:";
            // 
            // st_btn
            // 
            this.st_btn.Location = new System.Drawing.Point(92, 113);
            this.st_btn.Name = "st_btn";
            this.st_btn.Size = new System.Drawing.Size(75, 23);
            this.st_btn.TabIndex = 1;
            this.st_btn.Text = "Start";
            this.st_btn.UseVisualStyleBackColor = true;
            this.st_btn.Click += new System.EventHandler(this.St_btn_Click);
            // 
            // ed_btn
            // 
            this.ed_btn.Location = new System.Drawing.Point(191, 113);
            this.ed_btn.Name = "ed_btn";
            this.ed_btn.Size = new System.Drawing.Size(75, 23);
            this.ed_btn.TabIndex = 2;
            this.ed_btn.Text = "End";
            this.ed_btn.UseVisualStyleBackColor = true;
            this.ed_btn.Click += new System.EventHandler(this.Ed_btn_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(109, 45);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(204, 20);
            this.txt1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd4);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Controls.Add(this.rd2);
            this.groupBox1.Controls.Add(this.rd1);
            this.groupBox1.Location = new System.Drawing.Point(66, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Priorities";
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(6, 126);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(76, 17);
            this.rd4.TabIndex = 3;
            this.rd4.TabStop = true;
            this.rd4.Text = "RUNNING";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.Rd4_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(6, 88);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(84, 17);
            this.rd3.TabIndex = 2;
            this.rd3.TabStop = true;
            this.rd3.Text = "VERY HIGH";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.Rd3_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(6, 55);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(52, 17);
            this.rd2.TabIndex = 1;
            this.rd2.TabStop = true;
            this.rd2.Text = "HIGH";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.Rd2_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(7, 20);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(50, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "LOW";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.Rd1_CheckedChanged);
            // 
            // ls1
            // 
            this.ls1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processname,
            this.processid,
            this.processcpu});
            this.ls1.FullRowSelect = true;
            this.ls1.GridLines = true;
            this.ls1.HideSelection = false;
            this.ls1.Location = new System.Drawing.Point(342, 12);
            this.ls1.Name = "ls1";
            this.ls1.Size = new System.Drawing.Size(435, 383);
            this.ls1.TabIndex = 6;
            this.ls1.UseCompatibleStateImageBehavior = false;
            this.ls1.View = System.Windows.Forms.View.Details;
            // 
            // processname
            // 
            this.processname.Text = "Name";
            this.processname.Width = 109;
            // 
            // processid
            // 
            this.processid.Text = "ID";
            this.processid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.processid.Width = 133;
            // 
            // processcpu
            // 
            this.processcpu.Text = "CPU ";
            this.processcpu.Width = 188;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.ls1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.ed_btn);
            this.Controls.Add(this.st_btn);
            this.Controls.Add(this.proc_lab);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label proc_lab;
        private System.Windows.Forms.Button st_btn;
        private System.Windows.Forms.Button ed_btn;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.ListView ls1;
        private System.Windows.Forms.ColumnHeader processname;
        private System.Windows.Forms.ColumnHeader processid;
        private System.Windows.Forms.ColumnHeader processcpu;
    }
}

