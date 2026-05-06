using System;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.AI.Evaluation;
using Microsoft.Extensions.Logging;
using Newsletter.Ai.Providers.Abstractions;
using Newsletter.Core;
using Newsletter.Core.Agents.Abstractions;
using Newsletter.Core.Model;
using OpenAI;
using OpenAI.Chat;

namespace Newsletter.Ai.Agents;

public class NewsletterGeneratorAgent (ILogger<NewsletterGeneratorAgent> logger, IPromptProvider promptProvider) : IAgents<IEnumerable<Article>, string>
{

    private const string Name = "NewsletterGeneratorAgent";
    private const string Prompt = "Gere um conteúdo para newsletter com base neste JSON: ";
    private const float Temperature = 0.7f;

    public async Task<string> RunAsync (IEnumerable<Article> data, CancellationToken cancellationToken)
    {
        logger.LogInformation("Iniciando o processo de geração da newsletter com {ArticleCount} artigos.", data.Count());

        var client = new OpenAIClient(Configuration.OpenAi.ApiKey);

        var instructions = await promptProvider.GetPromptAsync(Name, cancellationToken);

        var agent = client
            .GetChatClient(AiModels.Gpt4OMini)
            .AsAIAgent(new ChatClientAgentOptions
            {
                Name = Name,
                Description = "Agente especialista em gerar conteúdo para newsletter via E-mail",
                ChatOptions = new ChatOptions
                {
                    ModelId = AiModels.Gpt4OMini,
                    Temperature = Temperature,
                    Instructions = instructions
                }
            });
    }
}
    