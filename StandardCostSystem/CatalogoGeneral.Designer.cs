namespace StandardCostSystem
{
    partial class CatalogoGeneral
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
            this.dataGridView_Registers = new System.Windows.Forms.DataGridView();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAreas = new System.Windows.Forms.ComboBox();
            this.cbSubAreas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Registers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Registers
            // 
            this.dataGridView_Registers.AllowUserToAddRows = false;
            this.dataGridView_Registers.AllowUserToDeleteRows = false;
            this.dataGridView_Registers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Registers.Location = new System.Drawing.Point(266, 69);
            this.dataGridView_Registers.Name = "dataGridView_Registers";
            this.dataGridView_Registers.ReadOnly = true;
            this.dataGridView_Registers.Size = new System.Drawing.Size(778, 308);
            this.dataGridView_Registers.TabIndex = 0;
            // 
            // cbCompanies
            // 
            this.cbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(30, 86);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(216, 21);
            this.cbCompanies.TabIndex = 1;
            this.cbCompanies.SelectedIndexChanged += new System.EventHandler(this.cbCompanies_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Areas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sub-Areas";
            // 
            // cbAreas
            // 
            this.cbAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAreas.FormattingEnabled = true;
            this.cbAreas.Location = new System.Drawing.Point(30, 168);
            this.cbAreas.Name = "cbAreas";
            this.cbAreas.Size = new System.Drawing.Size(216, 21);
            this.cbAreas.TabIndex = 5;
            this.cbAreas.SelectedIndexChanged += new System.EventHandler(this.cbAreas_SelectedIndexChanged);
            // 
            // cbSubAreas
            // 
            this.cbSubAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubAreas.FormattingEnabled = true;
            this.cbSubAreas.Location = new System.Drawing.Point(30, 247);
            this.cbSubAreas.Name = "cbSubAreas";
            this.cbSubAreas.Size = new System.Drawing.Size(216, 21);
            this.cbSubAreas.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nuevo registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.subAreaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areaToolStripMenuItem.Text = "Area";
            // 
            // subAreaToolStripMenuItem
            // 
            this.subAreaToolStripMenuItem.Name = "subAreaToolStripMenuItem";
            this.subAreaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subAreaToolStripMenuItem.Text = "SubArea";
            // 
            // CatalogoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSubAreas);
            this.Controls.Add(this.cbAreas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.dataGridView_Registers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CatalogoGeneral";
            this.Text = "Catalogo General";
            this.Load += new System.EventHandler(this.CatalogoGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Registers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Registers;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAreas;
        private System.Windows.Forms.ComboBox cbSubAreas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subAreaToolStripMenuItem;
    }
}