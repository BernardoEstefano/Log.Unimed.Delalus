using Log.Application.Referencias;
using System.ComponentModel.DataAnnotations;

namespace Infra.Log
{
    public class LogQuery : ILogQuery
    {
        public Task<bool> GetLog(int id, DataType dataModificacao, int operador, int tipoDeLog, int contratante, int fornecedor, string log)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostLog(int id, DataType dataModificacao, int operador, int tipoDeLog, int contratante, int fornecedor, string log)
        {
            throw new NotImplementedException();
        }
    }
}