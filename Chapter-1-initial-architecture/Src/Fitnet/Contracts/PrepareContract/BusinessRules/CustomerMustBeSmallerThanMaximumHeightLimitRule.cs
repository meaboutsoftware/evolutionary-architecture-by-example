namespace EvolutionaryArchitecture.Fitnet.Contracts.PrepareContract.BusinessRules;

using Common.BusinessRulesEngine;

internal sealed class CustomerMustBeSmallerThanMaximumHeightLimitRule : IBusinessRule
{
    private const int MAXIMUM_HEIGHT = 210;
    
    private readonly int _height;
   
    internal CustomerMustBeSmallerThanMaximumHeightLimitRule(int height) => _height = height;

    public bool IsMet() => _height <= MAXIMUM_HEIGHT;

    public string Error => "Customer height must fit maximum limit for gym instruments";
}