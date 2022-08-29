using Log.Unimed.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Log.Application.Referencias
{
    public interface ILogQuery
    {
        Task<bool> GetLog(int id, DataType dataModificacao, int operador, int tipoDeLog, int contratante, int fornecedor, string log);
        Task<bool> PostLog(int id, DataType dataModificacao, int operador, int tipoDeLog, int contratante, int fornecedor, string log);
    }
}