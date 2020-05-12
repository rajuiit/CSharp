namespace Biomedical_Parameter_Treatment.doctor
{
    partial class homepage
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edit_patientB = new System.Windows.Forms.Button();
            this.add_patientB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.show_patientB = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.logoutB = new System.Windows.Forms.Button();
            this.assign_patientB = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.doctoridL = new System.Windows.Forms.Label();
            this.treatment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biomedical parameter Treatment";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(409, 17);
            this.toolStripStatusLabel1.Text = "Developed By: Institute of Information Technology, Jahangirnagar University";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.edit_patientB);
            this.panel2.Controls.Add(this.add_patientB);
            this.panel2.Location = new System.Drawing.Point(50, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 123);
            this.panel2.TabIndex = 18;
            // 
            // edit_patientB
            // 
            this.edit_patientB.Location = new System.Drawing.Point(13, 56);
            this.edit_patientB.Name = "edit_patientB";
            this.edit_patientB.Size = new System.Drawing.Size(169, 23);
            this.edit_patientB.TabIndex = 1;
            this.edit_patientB.Text = "Edit patient";
            this.edit_patientB.UseVisualStyleBackColor = true;
            // 
            // add_patientB
            // 
            this.add_patientB.Location = new System.Drawing.Point(13, 15);
            this.add_patientB.Name = "add_patientB";
            this.add_patientB.Size = new System.Drawing.Size(169, 23);
            this.add_patientB.TabIndex = 0;
            this.add_patientB.Text = "Add a New patient";
            this.add_patientB.UseVisualStyleBackColor = true;
            this.add_patientB.Click += new System.EventHandler(this.add_patientB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.treatment);
            this.panel3.Controls.Add(this.show_patientB);
            this.panel3.Location = new System.Drawing.Point(286, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 123);
            this.panel3.TabIndex = 19;
            // 
            // show_patientB
            // 
            this.show_patientB.Location = new System.Drawing.Point(13, 9);
            this.show_patientB.Name = "show_patientB";
            this.show_patientB.Size = new System.Drawing.Size(169, 41);
            this.show_patientB.TabIndex = 0;
            this.show_patientB.Text = "Show Sending Patient Information && Treatment";
            this.show_patientB.UseVisualStyleBackColor = true;
            this.show_patientB.Click += new System.EventHandler(this.show_patientB_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.assign_patientB);
            this.panel4.Location = new System.Drawing.Point(515, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 123);
            this.panel4.TabIndex = 20;
            // 
            // logoutB
            // 
            this.logoutB.Location = new System.Drawing.Point(603, 12);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(98, 23);
            this.logoutB.TabIndex = 1;
            this.logoutB.Text = "Logout";
            this.logoutB.UseVisualStyleBackColor = true;
            this.logoutB.Click += new System.EventHandler(this.logoutB_Click);
            // 
            // assign_patientB
            // 
            this.assign_patientB.Location = new System.Drawing.Point(13, 15);
            this.assign_patientB.Name = "assign_patientB";
            this.assign_patientB.Size = new System.Drawing.Size(169, 23);
            this.assign_patientB.TabIndex = 0;
            this.assign_patientB.Text = "Assign patient to Doctor";
            this.assign_patientB.UseVisualStyleBackColor = true;
            this.assign_patientB.Click += new System.EventHandler(this.assign_patientB_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.doctoridL);
            this.panel5.Controls.Add(this.logoutB);
            this.panel5.Location = new System.Drawing.Point(13, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 47);
            this.panel5.TabIndex = 21;
            // 
            // doctoridL
            // 
            this.doctoridL.AutoSize = true;
            this.doctoridL.Location = new System.Drawing.Point(33, 17);
            this.doctoridL.Name = "doctoridL";
            this.doctoridL.Size = new System.Drawing.Size(53, 13);
            this.doctoridL.TabIndex = 2;
            this.doctoridL.Text = "Doctor ID";
            // 
            // treatment
            // 
            this.treatment.Location = new System.Drawing.Point(13, 68);
            this.treatment.Name = "treatment";
            this.treatment.Size = new System.Drawing.Size(169, 41);
            this.treatment.TabIndex = 1;
            this.treatment.Text = "Show Recieving Patient Information && Treatment";
            this.treatment.UseVisualStyleBackColor = true;
            this.treatment.Click += new System.EventHandler(this.treatment_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 428);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button edit_patientB;
        private System.Windows.Forms.Button add_patientB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button show_patientB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button assign_patientB;
        private System.Windows.Forms.Button logoutB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label doctoridL;
        private System.Windows.Forms.Button treatment;
    }
}