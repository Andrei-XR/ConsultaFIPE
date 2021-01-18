using ConsultaFIPE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaFIPE.Domain.Contracts
{
    public interface IFIPEService
    {
        Task<List<Marca>> ListarMarcasVeiculoAsync(string tipoVeiculo);
        Task<List<Modelo>> ListarModelosMarcaAsync(int codigoMarca);
        Task<Dictionary<string, string>> ListarVersoesModelo(int codigoModelo);
        Task<Veiculo> ConsultarDadosVeiculo(string codigoVersao);
    }
}
