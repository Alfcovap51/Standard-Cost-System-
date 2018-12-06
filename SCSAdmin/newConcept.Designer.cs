namespace SCSAdmin
{
    partial class newConcept
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstConcepts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDConcept = new System.Windows.Forms.TextBox();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.btnEliminateExpense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conceptos";
            // 
            // lstConcepts
            // 
            this.lstConcepts.FormattingEnabled = true;
            this.lstConcepts.Location = new System.Drawing.Point(12, 50);
            this.lstConcepts.Name = "lstConcepts";
            this.lstConcepts.Size = new System.Drawing.Size(370, 342);
            this.lstConcepts.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nuevo Concepto";
            // 
            // txtConcept
            // 
            this.txtConcept.Location = new System.Drawing.Point(414, 77);
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.Size = new System.Drawing.Size(157, 20);
            this.txtConcept.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero de concepto";
            // 
            // txtIDConcept
            // 
            this.txtIDConcept.Location = new System.Drawing.Point(414, 143);
            this.txtIDConcept.Name = "txtIDConcept";
            this.txtIDConcept.Size = new System.Drawing.Size(100, 20);
            this.txtIDConcept.TabIndex = 9;
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.Location = new System.Drawing.Point(414, 265);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(130, 39);
            this.btnNewExpense.TabIndex = 10;
            this.btnNewExpense.Text = "Agregar Concepto";
            this.btnNewExpense.UseVisualStyleBackColor = true;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // btnEliminateExpense
            // 
            this.btnEliminateExpense.Location = new System.Drawing.Point(414, 352);
            this.btnEliminateExpense.Name = "btnEliminateExpense";
            this.btnEliminateExpense.Size = new System.Drawing.Size(130, 40);
            this.btnEliminateExpense.TabIndex = 11;
            this.btnEliminateExpense.Text = "Eliminar Concepto";
            this.btnEliminateExpense.UseVisualStyleBackColor = true;
            this.btnEliminateExpense.Click += new System.EventHandler(this.btnEliminateExpense_Click);
            // 
            // newConcept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 421);
            this.Controls.Add(this.btnEliminateExpense);
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.txtIDConcept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConcept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstConcepts);
            this.Controls.Add(this.label3);
            this.Name = "newConcept";
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.newExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstConcepts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDConcept;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Button btnEliminateExpense;
    }
}