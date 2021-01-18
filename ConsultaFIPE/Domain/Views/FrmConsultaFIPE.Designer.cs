
namespace ConsultaFIPE.Domain.Views
{
    partial class FrmConsultaFIPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaFIPE));
            this.LblVeiculo = new System.Windows.Forms.Label();
            this.CbTipoVeiculos = new System.Windows.Forms.ComboBox();
            this.LblMarcas = new System.Windows.Forms.Label();
            this.CbMarcas = new System.Windows.Forms.ComboBox();
            this.LblModelos = new System.Windows.Forms.Label();
            this.CbModelos = new System.Windows.Forms.ComboBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.CbVersoes = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.ListBoxDadosVeiculo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblVeiculo
            // 
            this.LblVeiculo.AutoSize = true;
            this.LblVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVeiculo.Location = new System.Drawing.Point(13, 29);
            this.LblVeiculo.Name = "LblVeiculo";
            this.LblVeiculo.Size = new System.Drawing.Size(56, 16);
            this.LblVeiculo.TabIndex = 0;
            this.LblVeiculo.Text = "Veiculo:";
            // 
            // CbTipoVeiculos
            // 
            this.CbTipoVeiculos.DisplayMember = "label";
            this.CbTipoVeiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTipoVeiculos.FormattingEnabled = true;
            this.CbTipoVeiculos.Location = new System.Drawing.Point(83, 26);
            this.CbTipoVeiculos.Name = "CbTipoVeiculos";
            this.CbTipoVeiculos.Size = new System.Drawing.Size(299, 24);
            this.CbTipoVeiculos.TabIndex = 1;
            this.CbTipoVeiculos.ValueMember = "value";
            this.CbTipoVeiculos.SelectedIndexChanged += new System.EventHandler(this.CbTipoVeiculos_SelectedIndexChanged);
            // 
            // LblMarcas
            // 
            this.LblMarcas.AutoSize = true;
            this.LblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarcas.Location = new System.Drawing.Point(13, 70);
            this.LblMarcas.Name = "LblMarcas";
            this.LblMarcas.Size = new System.Drawing.Size(56, 16);
            this.LblMarcas.TabIndex = 0;
            this.LblMarcas.Text = "Marcas:";
            // 
            // CbMarcas
            // 
            this.CbMarcas.DisplayMember = "nome";
            this.CbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarcas.Enabled = false;
            this.CbMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbMarcas.FormattingEnabled = true;
            this.CbMarcas.Location = new System.Drawing.Point(83, 67);
            this.CbMarcas.Name = "CbMarcas";
            this.CbMarcas.Size = new System.Drawing.Size(299, 24);
            this.CbMarcas.TabIndex = 1;
            this.CbMarcas.ValueMember = "codigo";
            this.CbMarcas.SelectedIndexChanged += new System.EventHandler(this.CbMarcas_SelectedIndexChanged);
            // 
            // LblModelos
            // 
            this.LblModelos.AutoSize = true;
            this.LblModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModelos.Location = new System.Drawing.Point(13, 111);
            this.LblModelos.Name = "LblModelos";
            this.LblModelos.Size = new System.Drawing.Size(64, 16);
            this.LblModelos.TabIndex = 0;
            this.LblModelos.Text = "Modelos:";
            // 
            // CbModelos
            // 
            this.CbModelos.DisplayMember = "nome";
            this.CbModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbModelos.Enabled = false;
            this.CbModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbModelos.FormattingEnabled = true;
            this.CbModelos.Location = new System.Drawing.Point(83, 108);
            this.CbModelos.Name = "CbModelos";
            this.CbModelos.Size = new System.Drawing.Size(299, 24);
            this.CbModelos.TabIndex = 1;
            this.CbModelos.ValueMember = "codigo";
            this.CbModelos.SelectedIndexChanged += new System.EventHandler(this.CbModelos_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(13, 152);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(55, 16);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão:";
            // 
            // CbVersoes
            // 
            this.CbVersoes.DisplayMember = "value";
            this.CbVersoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVersoes.Enabled = false;
            this.CbVersoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVersoes.FormattingEnabled = true;
            this.CbVersoes.Location = new System.Drawing.Point(83, 149);
            this.CbVersoes.Name = "CbVersoes";
            this.CbVersoes.Size = new System.Drawing.Size(299, 24);
            this.CbVersoes.TabIndex = 1;
            this.CbVersoes.ValueMember = "key";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(83, 198);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(144, 32);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(238, 198);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(144, 32);
            this.BtnLimpar.TabIndex = 2;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // ListBoxDadosVeiculo
            // 
            this.ListBoxDadosVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxDadosVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxDadosVeiculo.FormattingEnabled = true;
            this.ListBoxDadosVeiculo.IntegralHeight = false;
            this.ListBoxDadosVeiculo.ItemHeight = 16;
            this.ListBoxDadosVeiculo.Location = new System.Drawing.Point(399, 26);
            this.ListBoxDadosVeiculo.Name = "ListBoxDadosVeiculo";
            this.ListBoxDadosVeiculo.Size = new System.Drawing.Size(345, 204);
            this.ListBoxDadosVeiculo.TabIndex = 3;
            // 
            // FrmConsultaFIPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 242);
            this.Controls.Add(this.ListBoxDadosVeiculo);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.CbVersoes);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.CbModelos);
            this.Controls.Add(this.LblModelos);
            this.Controls.Add(this.CbMarcas);
            this.Controls.Add(this.LblMarcas);
            this.Controls.Add(this.CbTipoVeiculos);
            this.Controls.Add(this.LblVeiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaFIPE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta FIPE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVeiculo;
        private System.Windows.Forms.ComboBox CbTipoVeiculos;
        private System.Windows.Forms.Label LblMarcas;
        private System.Windows.Forms.ComboBox CbMarcas;
        private System.Windows.Forms.Label LblModelos;
        private System.Windows.Forms.ComboBox CbModelos;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.ComboBox CbVersoes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.ListBox ListBoxDadosVeiculo;
    }
}