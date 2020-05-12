namespace ExcellFileImport
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
            this.bBT = new System.Windows.Forms.Button();
            this.bTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showDGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // bBT
            // 
            this.bBT.Location = new System.Drawing.Point(419, 36);
            this.bBT.Name = "bBT";
            this.bBT.Size = new System.Drawing.Size(181, 33);
            this.bBT.TabIndex = 0;
            this.bBT.Text = "Browse";
            this.bBT.UseVisualStyleBackColor = true;
            this.bBT.Click += new System.EventHandler(this.bBT_Click);
            // 
            // bTB
            // 
            this.bTB.Enabled = false;
            this.bTB.Location = new System.Drawing.Point(49, 36);
            this.bTB.Multiline = true;
            this.bTB.Name = "bTB";
            this.bTB.Size = new System.Drawing.Size(298, 33);
            this.bTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBT);
            this.groupBox1.Controls.Add(this.bTB);
            this.groupBox1.Location = new System.Drawing.Point(76, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse";
            // 
            // showDGV
            // 
            this.showDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDGV.Location = new System.Drawing.Point(44, 168);
            this.showDGV.Name = "showDGV";
            this.showDGV.Size = new System.Drawing.Size(749, 283);
            this.showDGV.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(583, 467);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(210, 33);
            this.saveBT.TabIndex = 4;
            this.saveBT.Text = "Save To Database";
            this.saveBT.UseVisualStyleBackColor = true;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 530);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.showDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBT;
        private System.Windows.Forms.TextBox bTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView showDGV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveBT;
    }
}

