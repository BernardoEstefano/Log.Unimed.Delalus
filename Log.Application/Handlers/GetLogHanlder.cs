using Log.Application.Referencias;
using Log.Unimed.Controllers;
using MediatR;

namespace Log.Application.Handlers
{
    public class GetLogHanlder : IRequestHandler<GetLogQuery, bool>
    {
        private readonly ILogQuery _getLogQuery;

        public GetLogHanlder(ILogQuery getLogQuery)
        {
            _getLogQuery = getLogQuery;
        }
        public async Task<bool> Handle(GetLogQuery request, CancellationToken cancellationToken)
        {
            return await _getLogQuery.GetLog(request.Id, request.DataModificacao, request.Operador, request.TipoDeLog, request.Contratante, request.Fornecedor, request.Log);
        }
    }
}
