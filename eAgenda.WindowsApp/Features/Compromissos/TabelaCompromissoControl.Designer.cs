﻿
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class TabelaCompromissoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridCompromissos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCompromissos
            // 
            this.gridCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompromissos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCompromissos.Location = new System.Drawing.Point(0, 0);
            this.gridCompromissos.Name = "gridCompromissos";
            this.gridCompromissos.Size = new System.Drawing.Size(453, 386);
            this.gridCompromissos.TabIndex = 1;
            // 
            // TabelaCompromissoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCompromissos);
            this.Name = "TabelaCompromissoControl";
            this.Size = new System.Drawing.Size(453, 386);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompromissos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCompromissos;
    }
}
