namespace DemoAddDeleteUpdate
{
    partial class addStudentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sSemesterCB = new System.Windows.Forms.ComboBox();
            this.sSessionCB = new System.Windows.Forms.ComboBox();
            this.sRegisTB = new System.Windows.Forms.TextBox();
            this.sExamRollTB = new System.Windows.Forms.TextBox();
            this.sClassRollTB = new System.Windows.Forms.TextBox();
            this.sNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelSBT = new System.Windows.Forms.Button();
            this.addSBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(47, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 61);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Access";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Student Form";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.sSemesterCB);
            this.groupBox2.Controls.Add(this.sSessionCB);
            this.groupBox2.Controls.Add(this.sRegisTB);
            this.groupBox2.Controls.Add(this.sExamRollTB);
            this.groupBox2.Controls.Add(this.sClassRollTB);
            this.groupBox2.Controls.Add(this.sNameTB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(47, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(451, 292);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // sSemesterCB
            // 
            this.sSemesterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sSemesterCB.FormattingEnabled = true;
            this.sSemesterCB.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.sSemesterCB.Location = new System.Drawing.Point(156, 242);
            this.sSemesterCB.Margin = new System.Windows.Forms.Padding(4);
            this.sSemesterCB.Name = "sSemesterCB";
            this.sSemesterCB.Size = new System.Drawing.Size(253, 21);
            this.sSemesterCB.TabIndex = 11;
            // 
            // sSessionCB
            // 
            this.sSessionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sSessionCB.FormattingEnabled = true;
            this.sSessionCB.Items.AddRange(new object[] {
            "2010-2011"});
            this.sSessionCB.Location = new System.Drawing.Point(156, 196);
            this.sSessionCB.Margin = new System.Windows.Forms.Padding(4);
            this.sSessionCB.Name = "sSessionCB";
            this.sSessionCB.Size = new System.Drawing.Size(139, 21);
            this.sSessionCB.TabIndex = 10;
            // 
            // sRegisTB
            // 
            this.sRegisTB.Location = new System.Drawing.Point(156, 154);
            this.sRegisTB.Margin = new System.Windows.Forms.Padding(4);
            this.sRegisTB.Name = "sRegisTB";
            this.sRegisTB.Size = new System.Drawing.Size(253, 20);
            this.sRegisTB.TabIndex = 9;
            // 
            // sExamRollTB
            // 
            this.sExamRollTB.Location = new System.Drawing.Point(156, 112);
            this.sExamRollTB.Margin = new System.Windows.Forms.Padding(4);
            this.sExamRollTB.Name = "sExamRollTB";
            this.sExamRollTB.Size = new System.Drawing.Size(253, 20);
            this.sExamRollTB.TabIndex = 8;
            // 
            // sClassRollTB
            // 
            this.sClassRollTB.Location = new System.Drawing.Point(156, 69);
            this.sClassRollTB.Margin = new System.Windows.Forms.Padding(4);
            this.sClassRollTB.Name = "sClassRollTB";
            this.sClassRollTB.Size = new System.Drawing.Size(253, 20);
            this.sClassRollTB.TabIndex = 7;
            // 
            // sNameTB
            // 
            this.sNameTB.Location = new System.Drawing.Point(156, 28);
            this.sNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.sNameTB.Name = "sNameTB";
            this.sNameTB.Size = new System.Drawing.Size(253, 20);
            this.sNameTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Semester: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Session: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Registration: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exam Roll: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class Roll:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelSBT);
            this.groupBox3.Controls.Add(this.addSBT);
            this.groupBox3.Location = new System.Drawing.Point(47, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 71);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
            // 
            // cancelSBT
            // 
            this.cancelSBT.Location = new System.Drawing.Point(314, 19);
            this.cancelSBT.Name = "cancelSBT";
            this.cancelSBT.Size = new System.Drawing.Size(95, 34);
            this.cancelSBT.TabIndex = 1;
            this.cancelSBT.Text = "Cancel";
            this.cancelSBT.UseVisualStyleBackColor = true;
            this.cancelSBT.Click += new System.EventHandler(this.cancelSBT_Click);
            // 
            // addSBT
            // 
            this.addSBT.Location = new System.Drawing.Point(156, 19);
            this.addSBT.Name = "addSBT";
            this.addSBT.Size = new System.Drawing.Size(126, 34);
            this.addSBT.TabIndex = 0;
            this.addSBT.Text = "Add Student Info";
            this.addSBT.UseVisualStyleBackColor = true;
            this.addSBT.Click += new System.EventHandler(this.addSBT_Click);
            // 
            // addStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sSemesterCB;
        private System.Windows.Forms.ComboBox sSessionCB;
        private System.Windows.Forms.TextBox sRegisTB;
        private System.Windows.Forms.TextBox sExamRollTB;
        private System.Windows.Forms.TextBox sClassRollTB;
        private System.Windows.Forms.TextBox sNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cancelSBT;
        private System.Windows.Forms.Button addSBT;
        private System.Windows.Forms.Label label7;

    }
}