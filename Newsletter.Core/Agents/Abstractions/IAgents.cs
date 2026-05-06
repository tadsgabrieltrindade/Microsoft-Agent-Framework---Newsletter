using System;

namespace Newsletter.Core.Agents.Abstractions;


/// <summary>
/// Interface genérica para agentes que processam dados de entrada e retornam uma resposta.
/// </summary>
/// <typeparam name="TData"></typeparam>
/// <typeparam name="TResponse"></typeparam>

public interface IAgents<in TData, TResponse>
        where TData : class
        where TResponse : class
{
    /// <summary>
    /// Executa a ação do agente com os dados fornecidos e retorna uma resposta.
    /// </summary> <param name="data">Os dados de entrada para o agente.</param>
    /// <param name="cancellationToken">Token de cancelamento para a operação assíncrona.</param>
    Task<TResponse> ExecuteAsync(TData data, CancellationToken cancellationToken);
}
