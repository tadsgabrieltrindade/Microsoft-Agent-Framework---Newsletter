using System;
using Microsoft.Extensions.Logging;
using Newsletter.Core.Services.Abstractions;

namespace Newsletter.Infra.Services;

// Logger é injetado para registrar informações sobre o envio de e-mails, como destinatário, assunto e corpo do e-mail. Em um cenário real, essa implementação poderia ser substituída por um serviço de envio de e-mails real, como SMTP ou um serviço de terceiros.
public class EmailServices (ILogger<EmailServices> logger) : IEmailService
{
    public async Task SendEmailAsync(string toName, string toEmail, string subject, string body, CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken); // Simulate async work

        logger.LogInformation("Email sent to {ToName} ({ToEmail}) with subject '{Subject}' and body: {Body}", toName, toEmail, subject, body);  
    }
}
