using System;
using Newsletter.Core.Model;

namespace Newsletter.Core.Repositories.Abstractions;

public interface ISubscriberRepository
{
    /// <summary>
    /// Obtém todos os assinantes.
    /// </summary> <param name="cancellationToken">Token de cancelamento para a operação assíncrona.</param>
    /// <returns>Uma coleção de assinantes.</returns>
    public Task<IEnumerable<Subscriber>> GetAllAsync(CancellationToken cancellationToken);
}
