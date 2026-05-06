using System;
using Newsletter.Core.Model;
using Newsletter.Core.Repositories.Abstractions;

namespace Newsletter.Infra.Repositories;

public class ArticleRepository : IArticleRepository
{

    /// <summary>
    /// Responsável por retornar a lista de artigos publicados na última semana. Em um cenário real, essa implementação faria uma consulta a um banco de dados ou a um serviço externo para obter os dados dos artigos publicados recentemente.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Uma lista de artigos publicados na última semana.</returns>
    public async Task<IEnumerable<Article>> GetFromLastWeekAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken); // Simulate async work

        return
        [
            new("Article 1", "/articles/article-1", "Content of article 1", DateTime.UtcNow.AddDays(-3)),
            new("Article 2", "/articles/article-2", "Content of article 2", DateTime.UtcNow.AddDays(-5)),
            new("Article 3", "/articles/article-3", "Content of article 3", DateTime.UtcNow.AddDays(-6)),
            new("Article 4", "/articles/article-4", "Content of article 4", DateTime.UtcNow.AddDays(-7))
        ];
    }
}
