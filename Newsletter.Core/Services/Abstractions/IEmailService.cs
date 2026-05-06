using System;

namespace Newsletter.Core.Services.Abstractions;

public interface IEmailService
{
        /// <summary>
        ///     Envia um email para um destinatário específico.
        /// </summary> <param name="toName">O nome do destinatário.</param>
        /// <param name="toEmail">O endereço de email do destinatário.</param>
        /// <param name="subject">O assunto do email.</param>
        /// <param name="body">O conteúdo do email.</param>
        /// <param name="cancellationToken">Token de cancelamento para a operação assíncrona.</param>
        /// <returns>Uma tarefa que representa a operação assíncrona de envio do email.</returns>   
    Task SendEmailAsync(
        string toName,
        string toEmail, 
        string subject, 
        string body, 
        CancellationToken cancellationToken
    );
}
