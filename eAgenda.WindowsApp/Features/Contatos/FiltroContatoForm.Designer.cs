
namespace eAgenda.WindowsApp.Features.Contatos
{
    partial class FiltroContatoForm
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
            this.rdbPorCargo = new System.Windows.Forms.RadioButton();
            this.rdbPorEmpresa = new System.Windows.Forms.RadioButton();
            this.rdbSemAgrupamento = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbPorCargo
            // 
            this.rdbPorCargo.AutoSize = true;
            this.rdbPorCargo.Location = new System.Drawing.Point(12, 80);
            this.rdbPorCargo.Name = "rdbPorCargo";
            this.rdbPorCargo.Size = new System.Drawing.Size(214, 17);
            this.rdbPorCargo.TabIndex = 11;
            this.rdbPorCargo.TabStop = true;
            this.rdbPorCargo.Text = "Visualizar contatos agrupados por cargo";
            this.rdbPorCargo.UseVisualStyleBackColor = true;
            // 
            // rdbPorEmpresa
            // 
            this.rdbPorEmpresa.AutoSize = true;
            this.rdbPorEmpresa.Location = new System.Drawing.Point(12, 46);
            this.rdbPorEmpresa.Name = "rdbPorEmpresa";
            this.rdbPorEmpresa.Size = new System.Drawing.Size(227, 17);
            this.rdbPorEmpresa.TabIndex = 10;
            this.rdbPorEmpresa.TabStop = true;
            this.rdbPorEmpresa.Text = "Visualizar contatos agrupados por empresa";
            this.rdbPorEmpresa.UseVisualStyleBackColor = true;
            // 
            // rdbSemAgrupamento
            // 
            this.rdbSemAgrupamento.AutoSize = true;
            this.rdbSemAgrupamento.Location = new System.Drawing.Point(12, 12);
            this.rdbSemAgrupamento.Name = "rdbSemAgrupamento";
            this.rdbSemAgrupamento.Size = new System.Drawing.Size(200, 17);
            this.rdbSemAgrupamento.TabIndex = 9;
            this.rdbSemAgrupamento.TabStop = true;
            this.rdbSemAgrupamento.Text = "Visualizar contatos sem agrupamento";
            this.rdbSemAgrupamento.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(199, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(12, 118);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // FiltroContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 153);
            this.Controls.Add(this.rdbPorCargo);
            this.Controls.Add(this.rdbPorEmpresa);
            this.Controls.Add(this.rdbSemAgrupamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FiltroContatoForm";
            this.Text = "Agrupamento de contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPorCargo;
        private System.Windows.Forms.RadioButton rdbPorEmpresa;
        private System.Windows.Forms.RadioButton rdbSemAgrupamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}