using System;
using Newsletter.Core.Model;

namespace Newsletter.Core.Repositories.Abstractions;

public interface IArticleRepository
{
    /// <summary>
    /// Obtém os artigos publicados na última semana.
    /// </summary> <param name="cancellationToken">Token de cancelamento para a operação assíncrona.</param>
    /// <returns>Uma coleção de artigos publicados na última semana.</returns>
    public Task<IEnumerable<Article>> GetFromLastWeekAsync(CancellationToken cancellationToken);
}
