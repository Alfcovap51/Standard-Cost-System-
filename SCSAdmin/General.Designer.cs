namespace SCSAdmin
{
    partial class General
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubAreas = new System.Windows.Forms.ComboBox();
            this.dtRegisters = new System.Windows.Forms.DataGridView();
            this.btnActualizarCombos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areaToolStripMenuItem,
            this.subAreaToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.registroToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // subAreaToolStripMenuItem
            // 
            this.subAreaToolStripMenuItem.Name = "subAreaToolStripMenuItem";
            this.subAreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subAreaToolStripMenuItem.Text = "SubArea";
            this.subAreaToolStripMenuItem.Click += new System.EventHandler(this.subAreaToolStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procesoToolStripMenuItem.Text = "Concepto";
            this.procesoToolStripMenuItem.Click += new System.EventHandler(this.procesoToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(12, 43);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(0, 18);
            this.lblCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Areas:";
            // 
            // cbAreas
            // 
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(32, 130);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(205, 21);
            this.cbAreas.TabIndex = 4;
            this.cbAreas.SelectedIndexChanged += new System.EventHandler(this.cbAreas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SubAreas";
            // 
            // cbSubAreas
            // 
            this.cbSubAreas.FormattingEnabled = true;
            this.cbSubAreas.Location = new System.Drawing.Point(32, 193);
            this.cbSubAreas.Name = "cbSubAreas";
            this.cbSubAreas.Size = new System.Drawing.Size(205, 21);
            this.cbSubAreas.TabIndex = 6;
            // 
            // dtRegisters
            // 
            this.dtRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRegisters.Location = new System.Drawing.Point(326, 88);
            this.dtRegisters.Name = "dtRegisters";
            this.dtRegisters.Size = new System.Drawing.Size(706, 293);
            this.dtRegisters.TabIndex = 7;
            // 
            // btnActualizarCombos
            // 
            this.btnActualizarCombos.Location = new System.Drawing.Point(36, 254);
            this.btnActualizarCombos.Name = "btnActualizarCombos";
            this.btnActualizarCombos.Size = new System.Drawing.Size(99, 26);
            this.btnActualizarCombos.TabIndex = 8;
            this.btnActualizarCombos.Text = "Actualizar";
            this.btnActualizarCombos.UseVisualStyleBackColor = true;
            this.btnActualizarCombos.Click += new System.EventHandler(this.btnActualizarCombos_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 439);
            this.Controls.Add(this.btnActualizarCombos);
            this.Controls.Add(this.dtRegisters);
            this.Controls.Add(this.cbSubAreas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAreas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "General";
            this.Text = "Catalogo de cuentas La Soledad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRegisters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAreas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubAreas;
        private System.Windows.Forms.DataGridView dtRegisters;
        private System.Windows.Forms.Button btnActualizarCombos;
    }
}

