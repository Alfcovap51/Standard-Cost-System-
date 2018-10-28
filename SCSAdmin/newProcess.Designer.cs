namespace SCSAdmin
{
    partial class newExpense
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
            this.label3 = new System.Windows.Forms.Label();
            this.lstAreas = new System.Windows.Forms.ListBox();
            this.lstSubAreas = new System.Windows.Forms.ListBox();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDExpense = new System.Windows.Forms.TextBox();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.btnEliminateExpense = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblSubAreas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gsatos/Concepto";
            // 
            // lstAreas
            // 
            this.lstAreas.FormattingEnabled = true;
            this.lstAreas.Location = new System.Drawing.Point(12, 52);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(131, 121);
            this.lstAreas.TabIndex = 3;
            this.lstAreas.SelectedIndexChanged += new System.EventHandler(this.lstAreas_SelectedValueChanged);
            // 
            // lstSubAreas
            // 
            this.lstSubAreas.FormattingEnabled = true;
            this.lstSubAreas.Location = new System.Drawing.Point(12, 218);
            this.lstSubAreas.Name = "lstSubAreas";
            this.lstSubAreas.Size = new System.Drawing.Size(147, 121);
            this.lstSubAreas.TabIndex = 4;
            this.lstSubAreas.SelectedIndexChanged += new System.EventHandler(this.lstSubAreas_SelectedValueChanged);
            // 
            // lstExpenses
            // 
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.Location = new System.Drawing.Point(192, 52);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(272, 160);
            this.lstExpenses.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nuevo Gasto";
            // 
            // txtExpense
            // 
            this.txtExpense.Location = new System.Drawing.Point(491, 50);
            this.txtExpense.Name = "txtExpense";
            this.txtExpense.Size = new System.Drawing.Size(157, 20);
            this.txtExpense.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero de gasto";
            // 
            // txtIDExpense
            // 
            this.txtIDExpense.Location = new System.Drawing.Point(491, 111);
            this.txtIDExpense.Name = "txtIDExpense";
            this.txtIDExpense.Size = new System.Drawing.Size(100, 20);
            this.txtIDExpense.TabIndex = 9;
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.Location = new System.Drawing.Point(491, 230);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(130, 39);
            this.btnNewExpense.TabIndex = 10;
            this.btnNewExpense.Text = "Agregar Gasto";
            this.btnNewExpense.UseVisualStyleBackColor = true;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // btnEliminateExpense
            // 
            this.btnEliminateExpense.Location = new System.Drawing.Point(192, 230);
            this.btnEliminateExpense.Name = "btnEliminateExpense";
            this.btnEliminateExpense.Size = new System.Drawing.Size(123, 40);
            this.btnEliminateExpense.TabIndex = 11;
            this.btnEliminateExpense.Text = "Eliminar Gasto";
            this.btnEliminateExpense.UseVisualStyleBackColor = true;
            this.btnEliminateExpense.Click += new System.EventHandler(this.btnEliminateExpense_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Presupuesto";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(491, 173);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBudget.TabIndex = 13;
            // 
            // lblSubAreas
            // 
            this.lblSubAreas.AutoSize = true;
            this.lblSubAreas.Location = new System.Drawing.Point(12, 192);
            this.lblSubAreas.Name = "lblSubAreas";
            this.lblSubAreas.Size = new System.Drawing.Size(0, 13);
            this.lblSubAreas.TabIndex = 14;
            // 
            // newExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 351);
            this.Controls.Add(this.lblSubAreas);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminateExpense);
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.txtIDExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstExpenses);
            this.Controls.Add(this.lstSubAreas);
            this.Controls.Add(this.lstAreas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "newExpense";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.newExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstAreas;
        private System.Windows.Forms.ListBox lstSubAreas;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDExpense;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Button btnEliminateExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblSubAreas;
    }
}