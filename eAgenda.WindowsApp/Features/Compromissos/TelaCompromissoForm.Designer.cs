
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class TelaCompromissoForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Assunto = new System.Windows.Forms.TextBox();
            this.txt_Local = new System.Windows.Forms.TextBox();
            this.txt_Link = new System.Windows.Forms.TextBox();
            this.mtxt_Data = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_HoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_HoraFim = new System.Windows.Forms.MaskedTextBox();
            this.cbb_Contato = new System.Windows.Forms.ComboBox();
            this.chb_SemContato = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(152, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(16, 278);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(106, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Horário de início:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Horário de fim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contato:";
            // 
            // txt_Assunto
            // 
            this.txt_Assunto.Location = new System.Drawing.Point(106, 37);
            this.txt_Assunto.Name = "txt_Assunto";
            this.txt_Assunto.Size = new System.Drawing.Size(121, 20);
            this.txt_Assunto.TabIndex = 13;
            // 
            // txt_Local
            // 
            this.txt_Local.Location = new System.Drawing.Point(106, 63);
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.Size = new System.Drawing.Size(121, 20);
            this.txt_Local.TabIndex = 14;
            // 
            // txt_Link
            // 
            this.txt_Link.Location = new System.Drawing.Point(106, 89);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.Size = new System.Drawing.Size(121, 20);
            this.txt_Link.TabIndex = 15;
            // 
            // mtxt_Data
            // 
            this.mtxt_Data.Location = new System.Drawing.Point(106, 115);
            this.mtxt_Data.Mask = "00/00/0000";
            this.mtxt_Data.Name = "mtxt_Data";
            this.mtxt_Data.PromptChar = ' ';
            this.mtxt_Data.Size = new System.Drawing.Size(121, 20);
            this.mtxt_Data.TabIndex = 16;
            this.mtxt_Data.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_HoraInicio
            // 
            this.mtxt_HoraInicio.Location = new System.Drawing.Point(106, 141);
            this.mtxt_HoraInicio.Mask = "00:00";
            this.mtxt_HoraInicio.Name = "mtxt_HoraInicio";
            this.mtxt_HoraInicio.PromptChar = ' ';
            this.mtxt_HoraInicio.Size = new System.Drawing.Size(121, 20);
            this.mtxt_HoraInicio.TabIndex = 17;
            this.mtxt_HoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtxt_HoraFim
            // 
            this.mtxt_HoraFim.Location = new System.Drawing.Point(106, 167);
            this.mtxt_HoraFim.Mask = "00:00";
            this.mtxt_HoraFim.Name = "mtxt_HoraFim";
            this.mtxt_HoraFim.PromptChar = ' ';
            this.mtxt_HoraFim.Size = new System.Drawing.Size(121, 20);
            this.mtxt_HoraFim.TabIndex = 18;
            this.mtxt_HoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // cbb_Contato
            // 
            this.cbb_Contato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Contato.FormattingEnabled = true;
            this.cbb_Contato.Location = new System.Drawing.Point(106, 194);
            this.cbb_Contato.Name = "cbb_Contato";
            this.cbb_Contato.Size = new System.Drawing.Size(121, 21);
            this.cbb_Contato.TabIndex = 19;
            // 
            // chb_SemContato
            // 
            this.chb_SemContato.AutoSize = true;
            this.chb_SemContato.Location = new System.Drawing.Point(14, 229);
            this.chb_SemContato.Name = "chb_SemContato";
            this.chb_SemContato.Size = new System.Drawing.Size(86, 17);
            this.chb_SemContato.TabIndex = 20;
            this.chb_SemContato.Text = "Sem contato";
            this.chb_SemContato.UseVisualStyleBackColor = true;
            this.chb_SemContato.CheckedChanged += new System.EventHandler(this.chb_SemContato_CheckedChanged);
            // 
            // TelaCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 312);
            this.Controls.Add(this.chb_SemContato);
            this.Controls.Add(this.cbb_Contato);
            this.Controls.Add(this.mtxt_HoraFim);
            this.Controls.Add(this.mtxt_HoraInicio);
            this.Controls.Add(this.mtxt_Data);
            this.Controls.Add(this.txt_Link);
            this.Controls.Add(this.txt_Local);
            this.Controls.Add(this.txt_Assunto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCompromissoForm";
            this.Text = "TelaCompromissoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Assunto;
        private System.Windows.Forms.TextBox txt_Local;
        private System.Windows.Forms.TextBox txt_Link;
        private System.Windows.Forms.MaskedTextBox mtxt_Data;
        private System.Windows.Forms.MaskedTextBox mtxt_HoraInicio;
        private System.Windows.Forms.MaskedTextBox mtxt_HoraFim;
        private System.Windows.Forms.ComboBox cbb_Contato;
        private System.Windows.Forms.CheckBox chb_SemContato;
    }
}