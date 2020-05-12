namespace StudentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sexCB = new System.Windows.Forms.ComboBox();
            this.dbDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cgpaTB = new System.Windows.Forms.TextBox();
            this.rollTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveBT = new System.Windows.Forms.Button();
            this.sBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CGPA  :";
            // 
            // cBT
            // 
            this.cBT.Location = new System.Drawing.Point(297, 34);
            this.cBT.Name = "cBT";
            this.cBT.Size = new System.Drawing.Size(87, 32);
            this.cBT.TabIndex = 3;
            this.cBT.Text = "Cancel";
            this.cBT.UseVisualStyleBackColor = true;
            this.cBT.Click += new System.EventHandler(this.cBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sexCB);
            this.groupBox1.Controls.Add(this.dbDTP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cgpaTB);
            this.groupBox1.Controls.Add(this.rollTB);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(131, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 308);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Form";
            // 
            // sexCB
            // 
            this.sexCB.AllowDrop = true;
            this.sexCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexCB.FormattingEnabled = true;
            this.sexCB.Location = new System.Drawing.Point(131, 207);
            this.sexCB.Name = "sexCB";
            this.sexCB.Size = new System.Drawing.Size(189, 21);
            this.sexCB.TabIndex = 9;
            // 
            // dbDTP
            // 
            this.dbDTP.Location = new System.Drawing.Point(131, 251);
            this.dbDTP.Name = "dbDTP";
            this.dbDTP.Size = new System.Drawing.Size(189, 20);
            this.dbDTP.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sex";
            // 
            // cgpaTB
            // 
            this.cgpaTB.Location = new System.Drawing.Point(131, 162);
            this.cgpaTB.Multiline = true;
            this.cgpaTB.Name = "cgpaTB";
            this.cgpaTB.Size = new System.Drawing.Size(189, 31);
            this.cgpaTB.TabIndex = 5;
            // 
            // rollTB
            // 
            this.rollTB.Location = new System.Drawing.Point(131, 103);
            this.rollTB.Multiline = true;
            this.rollTB.Name = "rollTB";
            this.rollTB.Size = new System.Drawing.Size(189, 31);
            this.rollTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(131, 45);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(189, 31);
            this.nameTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(221, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Result Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveBT);
            this.groupBox2.Controls.Add(this.sBT);
            this.groupBox2.Controls.Add(this.cBT);
            this.groupBox2.Location = new System.Drawing.Point(131, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(37, 34);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(79, 32);
            this.saveBT.TabIndex = 5;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // sBT
            // 
            this.sBT.Location = new System.Drawing.Point(164, 34);
            this.sBT.Name = "sBT";
            this.sBT.Size = new System.Drawing.Size(91, 32);
            this.sBT.TabIndex = 4;
            this.sBT.Text = "Show";
            this.sBT.UseVisualStyleBackColor = true;
            this.sBT.Click += new System.EventHandler(this.sBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button sBT;
        private System.Windows.Forms.TextBox cgpaTB;
        private System.Windows.Forms.TextBox rollTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ComboBox sexCB;
        private System.Windows.Forms.DateTimePicker dbDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

