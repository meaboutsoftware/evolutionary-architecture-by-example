namespace EvolutionaryArchitecture.Fitnet.Contracts;

using Common.Api;

internal static class ContractsApiPaths
{
    private const string ContractsRootApi = $"{ApiPaths.Root}/contracts";
    
    internal const string Prepare = ContractsRootApi;
    internal const string Sign = $"{ContractsRootApi}/{{id}}";
}