namespace SCSAdmin
{
    partial class newArea
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
            this.txtNewAreaName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewAreaID = new System.Windows.Forms.TextBox();
            this.btnNewArea = new System.Windows.Forms.Button();
            this.lstAreas = new System.Windows.Forms.ListBox();
            this.btnDeleteArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos de una nueva Area en la empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Area";
            // 
            // txtNewAreaName
            // 
            this.txtNewAreaName.Location = new System.Drawing.Point(26, 160);
            this.txtNewAreaName.Name = "txtNewAreaName";
            this.txtNewAreaName.Size = new System.Drawing.Size(234, 20);
            this.txtNewAreaName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID de Area";
            // 
            // txtNewAreaID
            // 
            this.txtNewAreaID.Location = new System.Drawing.Point(26, 91);
            this.txtNewAreaID.Name = "txtNewAreaID";
            this.txtNewAreaID.Size = new System.Drawing.Size(234, 20);
            this.txtNewAreaID.TabIndex = 4;
            // 
            // btnNewArea
            // 
            this.btnNewArea.Location = new System.Drawing.Point(74, 215);
            this.btnNewArea.Name = "btnNewArea";
            this.btnNewArea.Size = new System.Drawing.Size(148, 37);
            this.btnNewArea.TabIndex = 5;
            this.btnNewArea.Text = "Agregar Area";
            this.btnNewArea.UseVisualStyleBackColor = true;
            this.btnNewArea.Click += new System.EventHandler(this.btnNewArea_Click);
            // 
            // lstAreas
            // 
            this.lstAreas.FormattingEnabled = true;
            this.lstAreas.Location = new System.Drawing.Point(434, 40);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(224, 160);
            this.lstAreas.TabIndex = 6;
            // 
            // btnDeleteArea
            // 
            this.btnDeleteArea.Location = new System.Drawing.Point(478, 215);
            this.btnDeleteArea.Name = "btnDeleteArea";
            this.btnDeleteArea.Size = new System.Drawing.Size(148, 37);
            this.btnDeleteArea.TabIndex = 7;
            this.btnDeleteArea.Text = "Eliminar Area";
            this.btnDeleteArea.UseVisualStyleBackColor = true;
            this.btnDeleteArea.Click += new System.EventHandler(this.btnDeleteArea_Click);
            // 
            // newArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 275);
            this.Controls.Add(this.btnDeleteArea);
            this.Controls.Add(this.lstAreas);
            this.Controls.Add(this.btnNewArea);
            this.Controls.Add(this.txtNewAreaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewAreaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newArea";
            this.Text = "Areas ";
            this.Load += new System.EventHandler(this.newArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewAreaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewAreaID;
        private System.Windows.Forms.Button btnNewArea;
        private System.Windows.Forms.ListBox lstAreas;
        private System.Windows.Forms.Button btnDeleteArea;
    }
}