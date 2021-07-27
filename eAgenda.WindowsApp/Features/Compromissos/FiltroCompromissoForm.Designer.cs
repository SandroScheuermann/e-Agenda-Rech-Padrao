
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class FiltroCompromissoForm
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
            this.rdbEntre = new System.Windows.Forms.RadioButton();
            this.rdbPassados = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pickerDe = new System.Windows.Forms.DateTimePicker();
            this.pickerPara = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbEntre
            // 
            this.rdbEntre.AutoSize = true;
            this.rdbEntre.Location = new System.Drawing.Point(12, 80);
            this.rdbEntre.Name = "rdbEntre";
            this.rdbEntre.Size = new System.Drawing.Size(171, 17);
            this.rdbEntre.TabIndex = 11;
            this.rdbEntre.TabStop = true;
            this.rdbEntre.Text = "Visualizar compromissos entre :";
            this.rdbEntre.UseVisualStyleBackColor = true;
            // 
            // rdbPassados
            // 
            this.rdbPassados.AutoSize = true;
            this.rdbPassados.Location = new System.Drawing.Point(12, 46);
            this.rdbPassados.Name = "rdbPassados";
            this.rdbPassados.Size = new System.Drawing.Size(186, 17);
            this.rdbPassados.TabIndex = 10;
            this.rdbPassados.TabStop = true;
            this.rdbPassados.Text = "Visualizar compromissos passados";
            this.rdbPassados.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(12, 12);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(181, 17);
            this.rdbTodos.TabIndex = 9;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Visualizar todos os compromissos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(130, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(24, 196);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // pickerDe
            // 
            this.pickerDe.Location = new System.Drawing.Point(12, 119);
            this.pickerDe.Name = "pickerDe";
            this.pickerDe.Size = new System.Drawing.Size(212, 20);
            this.pickerDe.TabIndex = 12;
            // 
            // pickerPara
            // 
            this.pickerPara.Location = new System.Drawing.Point(12, 158);
            this.pickerPara.Name = "pickerPara";
            this.pickerPara.Size = new System.Drawing.Size(212, 20);
            this.pickerPara.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "e";
            // 
            // FiltroCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickerPara);
            this.Controls.Add(this.pickerDe);
            this.Controls.Add(this.rdbEntre);
            this.Controls.Add(this.rdbPassados);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FiltroCompromissoForm";
            this.Text = "Filtro de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbEntre;
        private System.Windows.Forms.RadioButton rdbPassados;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker pickerDe;
        private System.Windows.Forms.DateTimePicker pickerPara;
        private System.Windows.Forms.Label label1;
    }
}