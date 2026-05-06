using System;
using Newsletter.Core.Services.Abstractions;

namespace Newsletter.Infra.Services;

public class NewsletterService : INewsletterService
{
    public Task SendNewsletterAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
