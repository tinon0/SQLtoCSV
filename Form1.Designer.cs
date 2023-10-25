namespace SQLtoCSV
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbPanaderia = new System.Windows.Forms.Label();
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.grbSelect = new System.Windows.Forms.GroupBox();
            this.grpFilepath = new System.Windows.Forms.GroupBox();
            this.btnFilepath = new System.Windows.Forms.Button();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbSelect.SuspendLayout();
            this.grpFilepath.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a table:";
            // 
            // lbPanaderia
            // 
            this.lbPanaderia.AutoSize = true;
            this.lbPanaderia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPanaderia.Location = new System.Drawing.Point(125, 9);
            this.lbPanaderia.Name = "lbPanaderia";
            this.lbPanaderia.Size = new System.Drawing.Size(111, 26);
            this.lbPanaderia.TabIndex = 1;
            this.lbPanaderia.Text = "Panaderia";
            // 
            // cboTables
            // 
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Location = new System.Drawing.Point(6, 43);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(151, 21);
            this.cboTables.TabIndex = 4;
            this.cboTables.SelectedIndexChanged += new System.EventHandler(this.cboTables_SelectedIndexChanged);
            // 
            // grbSelect
            // 
            this.grbSelect.Controls.Add(this.label1);
            this.grbSelect.Controls.Add(this.cboTables);
            this.grbSelect.Location = new System.Drawing.Point(18, 68);
            this.grbSelect.Name = "grbSelect";
            this.grbSelect.Size = new System.Drawing.Size(353, 164);
            this.grbSelect.TabIndex = 5;
            this.grbSelect.TabStop = false;
            this.grbSelect.Text = "Select to convert to .CSV";
            // 
            // grpFilepath
            // 
            this.grpFilepath.Controls.Add(this.btnFilepath);
            this.grpFilepath.Controls.Add(this.txtFilepath);
            this.grpFilepath.Location = new System.Drawing.Point(18, 248);
            this.grpFilepath.Name = "grpFilepath";
            this.grpFilepath.Size = new System.Drawing.Size(353, 116);
            this.grpFilepath.TabIndex = 6;
            this.grpFilepath.TabStop = false;
            this.grpFilepath.Text = "Save in";
            this.grpFilepath.Enter += new System.EventHandler(this.grpFilepath_Enter);
            // 
            // btnFilepath
            // 
            this.btnFilepath.Location = new System.Drawing.Point(263, 39);
            this.btnFilepath.Name = "btnFilepath";
            this.btnFilepath.Size = new System.Drawing.Size(41, 20);
            this.btnFilepath.TabIndex = 7;
            this.btnFilepath.Text = "...";
            this.btnFilepath.UseVisualStyleBackColor = true;
            this.btnFilepath.Click += new System.EventHandler(this.btnFilepath_Click);
            // 
            // txtFilepath
            // 
            this.txtFilepath.Location = new System.Drawing.Point(6, 39);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(251, 20);
            this.txtFilepath.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(24, 429);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(347, 40);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "VIEW FILE";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(24, 383);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(347, 40);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "EXPORT to CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(296, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grpFilepath);
            this.Controls.Add(this.grbSelect);
            this.Controls.Add(this.lbPanaderia);
            this.Name = "Form1";
            this.Text = "SQL to .CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSelect.ResumeLayout(false);
            this.grbSelect.PerformLayout();
            this.grpFilepath.ResumeLayout(false);
            this.grpFilepath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPanaderia;
        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.GroupBox grbSelect;
        private System.Windows.Forms.GroupBox grpFilepath;
        private System.Windows.Forms.Button btnFilepath;
        private System.Windows.Forms.TextBox txtFilepath;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnExit;
    }
}

