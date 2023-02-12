using FormulaOneInfo.ApplicationCore.Constants;
using FormulaOneInfo.ApplicationCore.Services;
using Microsoft.Extensions.DependencyInjection;
using Refit;
namespace FormulaOneInfo.Infrastructure.ApiSportsAgent;

public static class ApiSportsAgentExtension
{
    public static void AddApiSportsAgent(this IServiceCollection services)
    {
        services.AddRefitClient<IFormulaOneServiceApi>()
            .ConfigureHttpClient(_ =>
            {
                _.BaseAddress = new Uri(Common.FormulaOneBaseUrl);
                _.DefaultRequestHeaders.Add("x-rapidapi-host", "api-formula-1.p.rapidapi.com");
                _.DefaultRequestHeaders.Add("x-rapidapi-key", "");
            });
    }
}