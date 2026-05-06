using System;

namespace Newsletter.Api.Providers.Abstractions;

public interface IPromptProvider
{
    Task<string> GetPromptAsync(string agentName);
}


