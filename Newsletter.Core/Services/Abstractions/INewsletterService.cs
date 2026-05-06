using System;

namespace Newsletter.Core.Services.Abstractions;

public interface INewsletterService
{
    /// <summary>
    /// Envia a newsletter para os assinantes.
    /// </summary> <param name="cancellationToken">Token de cancelamento para a operação assíncrona.</param>
    /// <returns>Uma tarefa que representa a operação assíncrona de envio da newsletter.</returns>
    Task SendNewsletterAsync(CancellationToken cancellationToken);
}
