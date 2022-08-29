using Log.Application.Referencias;

using Log.Unimed.Delalus.Controllers;
using MediatR;

namespace Log.Application.Delalus.Handlers
{
    public class PostLogHandler : IRequestHandler<PostLogQuery, bool>
    {
        private readonly ILogQuery _postLogQuery;

        public PostLogHandler(ILogQuery postLogHandler)
        {
            _postLogQuery = postLogHandler;
        }

        public async Task<bool> Handle(PostLogQuery request, CancellationToken cancellationTokenPostLogQuery)
        {
            return await _postLogQuery.PostLog(request.Id, request.DataModificacao, request.Operador, request.TipoDeLog, request.Contratante, request.Fornecedor, request.Log);
        }
    }
}
