using System;
using Newsletter.Core.Model;
using Newsletter.Core.Repositories.Abstractions;

namespace Newsletter.Infra.Repositories;

public class SubscriberRepository : ISubscriberRepository
{
    /// <summary>
    /// Responsável por retornar a lista de assinantes cadastrados. Em um cenário real, essa implementação faria uma consulta a um banco de dados ou a um serviço externo para obter os dados dos assinantes.   
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Uma lista de assinantes cadastrados.</returns>
    public Task<IEnumerable<Subscriber>> GetAllAsync(CancellationToken cancellationToken)
    {
        IEnumerable<Subscriber> subscribers =
        [
            new("Alice Silva", "alice@example.com"),
            new("Bruno Costa", "bruno@example.com"),
            new("Carla Souza", "carla@example.com")
        ];

        return Task.FromResult(subscribers);
    }
}
