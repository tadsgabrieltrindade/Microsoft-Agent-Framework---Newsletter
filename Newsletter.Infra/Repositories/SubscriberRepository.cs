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
     public async Task<IEnumerable<Subscriber>> GetAllAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken);

        return
        [
            new Subscriber("Andre Baltieri", "hello@balta.io"),
            new Subscriber("Gemini AI", "gemini@example.com"),
            new Subscriber("DotNet User", "user@dotnet.com"),
            new Subscriber("Software Architect", "arch@dev.com"),
            new Subscriber("Clean Code Fan", "bob@uncle.com")
        ];
    }
}
