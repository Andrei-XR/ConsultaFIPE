using ConsultaFIPE.Domain.Contracts;
using ConsultaFIPE.Domain.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaFIPE.Domain.Services
{
    public class FIPEService : IFIPEService
    {
        private string Url = $@"https://parallelum.com.br/fipe/api/v1/motos/marcas";

        private HttpClient Client;

        private HttpResponseMessage Response;

        private string UriModelos;

        private string UriVersaoModelo;

        public async Task<Veiculo> ConsultarDadosVeiculo(string codigoVersao)
        {
            Veiculo veiculo = null;

            using (Client = new HttpClient())
            {
                Response = await Client.GetAsync($"{Url}{UriModelos}{UriVersaoModelo}/{codigoVersao}");

                if (Response.IsSuccessStatusCode)
                {
                    var content = await Response.Content.ReadAsStringAsync();
                    var jsonVeiculo = JObject.Parse(content);

                    veiculo = new Veiculo
                    {
                        Ano = (int)JObject.Parse(jsonVeiculo.ToString()).GetValue("AnoModelo"),
                        CodigoFipe = JObject.Parse(jsonVeiculo.ToString()).GetValue("CodigoFipe").ToString(),
                        Combustivel = JObject.Parse(jsonVeiculo.ToString()).GetValue("Combustivel").ToString(),
                        Valor = JObject.Parse(jsonVeiculo.ToString()).GetValue("Valor").ToString(),
                        Marca = new Marca { Nome = JObject.Parse(jsonVeiculo.ToString()).GetValue("Marca").ToString() },
                        Modelo = new Modelo {  Nome = JObject.Parse(jsonVeiculo.ToString()).GetValue("Modelo").ToString() }
                    };
                }
            }

            return veiculo;
        }

        public async Task<List<Marca>> ListarMarcasVeiculoAsync(string tipoVeiculo)
        {
            Url = $@"https://parallelum.com.br/fipe/api/v1/{tipoVeiculo}/marcas";
            List<Marca> marcas = new List<Marca>();

            using (Client = new HttpClient())
            {
                Response = await Client.GetAsync(Url);

                if (Response.IsSuccessStatusCode)
                {
                    var content = await Response.Content.ReadAsStringAsync();
                    content = content.Replace("[", "{ 'marcas': [").Replace("]", "]}");

                    var jsonMarcas = JObject.Parse(content).GetValue("marcas");

                    foreach (var json in jsonMarcas)
                    {
                        marcas.Add(new Marca
                        {
                            Nome = JObject.Parse(json.ToString()).GetValue("nome").ToString(),
                            Codigo = (int)JObject.Parse(json.ToString()).GetValue("codigo"),
                        });
                    }
                }
            }

            return marcas;
        }

        public async Task<List<Modelo>> ListarModelosMarcaAsync(int codigoMarca)
        {
            UriModelos = $@"/{codigoMarca}/modelos";
            List<Modelo> modelos = new List<Modelo>();

            using (Client = new HttpClient())
            {
                Response = await Client.GetAsync($"{Url}{UriModelos}");

                if (Response.IsSuccessStatusCode)
                {
                    var content = await Response.Content.ReadAsStringAsync();

                    var jsonModelos = JObject.Parse(content).GetValue("modelos");

                    foreach (var json in jsonModelos)
                    {
                        modelos.Add(new Modelo
                        {
                            Nome = JObject.Parse(json.ToString()).GetValue("nome").ToString(),
                            Codigo = (int)JObject.Parse(json.ToString()).GetValue("codigo")
                        });
                    }
                }
            }

            return modelos;
        }

        public async Task<Dictionary<string, string>> ListarVersoesModelo(int codigoModelo)
        {
            UriVersaoModelo = $@"/{codigoModelo}/anos";
            Dictionary<string, string> versoes = new Dictionary<string, string>();

            using (Client = new HttpClient())
            {
                Response = await Client.GetAsync($"{Url}{UriModelos}{UriVersaoModelo}");

                if (Response.IsSuccessStatusCode)
                {
                    var content = await Response.Content.ReadAsStringAsync();
                    content = content.Replace("[", "{ 'versoes': [").Replace("]", "]}");

                    var jsonModelos = JObject.Parse(content).GetValue("versoes");

                    foreach (var json in jsonModelos)
                    {
                        versoes.Add(
                                JObject.Parse(json.ToString()).GetValue("codigo").ToString(),
                                JObject.Parse(json.ToString()).GetValue("nome").ToString()
                            );
                    }
                }
            }

            return versoes;
        }
    }
}
