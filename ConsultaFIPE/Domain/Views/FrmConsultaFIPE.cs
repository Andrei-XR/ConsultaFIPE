using ConsultaFIPE.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaFIPE.Domain.Views
{
    public partial class FrmConsultaFIPE : Form
    {
        private FIPEService FIPEService = new FIPEService();

        public FrmConsultaFIPE()
        {
            InitializeComponent();
            CarregarTiposVeiculos();
        }

        #region Carregamentos

        public void CarregarTiposVeiculos()
        {
            CbTipoVeiculos.DataSource = new[]
            {
                new {value = "motos", label = "Moto"},
                new {value = "carros", label = "Carro"},
                new {value = "caminhoes", label = "Caminhão"},
            };
        }

        public async void CarregarMarcasVeiculos()
        {
            btnConsultar.Enabled = false;
            CbMarcas.Enabled = false;
            string tipoVeiculo = (string)CbTipoVeiculos.SelectedValue;
            CbMarcas.DataSource = await FIPEService.ListarMarcasVeiculoAsync(tipoVeiculo);
            ValidarSelecaoMarca();
        }

        public async void CarregarModelosMarca()
        {
            btnConsultar.Enabled = false;
            CbModelos.Enabled = false;
            int codigoMarca = (int)CbMarcas.SelectedValue;
            CbModelos.DataSource = await FIPEService.ListarModelosMarcaAsync(codigoMarca);
            ValidarSelecaoModelo();
        }

        public async void CarregarVersoesModelo()
        {
            btnConsultar.Enabled = false;
            CbVersoes.Enabled = false;
            int codigoModelo = (int)CbModelos.SelectedValue;
            CbVersoes.DataSource = (await FIPEService.ListarVersoesModelo(codigoModelo)).ToList();
            ValidarSelecaoVersao();
        }

        public async void ExibirDadosVeiculo()
        {
            string codigoVeiculo = (string)CbVersoes.SelectedValue;
            var veiculo = await FIPEService.ConsultarDadosVeiculo(codigoVeiculo);

            if (veiculo != null)
            {
                List<string> content = new List<string>
                {
                    " DADOS DO VEICULO ".PadLeft(38,'-').PadRight(56,'-'),
                    "",
                    "MARCA".PadRight(28, '.') + ": " + veiculo.Marca.Nome,
                    "MODELO".PadRight(26, '.') + ": " + veiculo.Modelo.Nome,
                    "VALOR".PadRight(29, '.') + ": " + veiculo.Valor,
                    "ANO".PadRight(32, '.') + ": " + veiculo.Ano,
                    "COMBUTIVEL".PadRight(20, '.') + ": " + veiculo.Combustivel,
                    "CODIGO FIPE".PadRight(22, '.') + ": " + veiculo.CodigoFipe
                };

                ListBoxDadosVeiculo.Items.Clear();
                ListBoxDadosVeiculo.Items.AddRange(content.ToArray());
            }
            
        }

        #endregion

        #region Eventos

        private void CbTipoVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarMarcasVeiculos();
        }

        private void CbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarModelosMarca();
        }

        private void CbModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarVersoesModelo();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            CbTipoVeiculos.SelectedIndex = 0;
            ListBoxDadosVeiculo.Items.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ExibirDadosVeiculo();
        }

        #endregion

        #region Validações
        public void ValidarSelecaoVersao()
        {
            if (CbVersoes.Items.Count > 0)
            {
                CbVersoes.Enabled = true;
                btnConsultar.Enabled = true;
            }
        }

        public void ValidarSelecaoModelo()
        {
            if (CbModelos.Items.Count > 0)
            {
                CbModelos.Enabled = true;
            }
        }

        public void ValidarSelecaoMarca()
        {
            if (CbMarcas.Items.Count > 0)
            {
                CbMarcas.Enabled = true;
            }
        }

        #endregion

    }
}
