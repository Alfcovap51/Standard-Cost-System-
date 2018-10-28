namespace SCSAdmin
{
    partial class newSubArea
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
            this.lstAreas = new System.Windows.Forms.ListBox();
            this.lblSubAreas = new System.Windows.Forms.Label();
            this.lstSubAreas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDSubArea = new System.Windows.Forms.TextBox();
            this.txtNameSubArea = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Areas de la empresa";
            // 
            // lstAreas
            // 
            this.lstAreas.FormattingEnabled = true;
            this.lstAreas.Location = new System.Drawing.Point(24, 77);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(159, 173);
            this.lstAreas.TabIndex = 1;
            this.lstAreas.SelectedIndexChanged += new System.EventHandler(this.lstAreas_SelectedIndexChanged);
            this.lstAreas.SelectedValueChanged += new System.EventHandler(this.lstAreas_SelectedValueChanged);
            // 
            // lblSubAreas
            // 
            this.lblSubAreas.AutoSize = true;
            this.lblSubAreas.Location = new System.Drawing.Point(230, 26);
            this.lblSubAreas.Name = "lblSubAreas";
            this.lblSubAreas.Size = new System.Drawing.Size(0, 13);
            this.lblSubAreas.TabIndex = 2;
            // 
            // lstSubAreas
            // 
            this.lstSubAreas.FormattingEnabled = true;
            this.lstSubAreas.Location = new System.Drawing.Point(233, 77);
            this.lstSubAreas.Name = "lstSubAreas";
            this.lstSubAreas.Size = new System.Drawing.Size(174, 173);
            this.lstSubAreas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de SubArea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID SubArea";
            // 
            // txtIDSubArea
            // 
            this.txtIDSubArea.Location = new System.Drawing.Point(552, 110);
            this.txtIDSubArea.Name = "txtIDSubArea";
            this.txtIDSubArea.Size = new System.Drawing.Size(193, 20);
            this.txtIDSubArea.TabIndex = 6;
            // 
            // txtNameSubArea
            // 
            this.txtNameSubArea.Location = new System.Drawing.Point(552, 199);
            this.txtNameSubArea.Name = "txtNameSubArea";
            this.txtNameSubArea.Size = new System.Drawing.Size(193, 20);
            this.txtNameSubArea.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar SubArea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar SubArea";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newSubArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNameSubArea);
            this.Controls.Add(this.txtIDSubArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSubAreas);
            this.Controls.Add(this.lblSubAreas);
            this.Controls.Add(this.lstAreas);
            this.Controls.Add(this.label1);
            this.Name = "newSubArea";
            this.Text = "SubAreas";
            this.Load += new System.EventHandler(this.newSubArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAreas;
        private System.Windows.Forms.Label lblSubAreas;
        private System.Windows.Forms.ListBox lstSubAreas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDSubArea;
        private System.Windows.Forms.TextBox txtNameSubArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}