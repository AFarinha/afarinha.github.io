using System.Net.Http.Json;
using System.Text.Json;

namespace AndreFarinhaPortfolio.Services;

public sealed class PortfolioDataService(HttpClient httpClient)
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    public async Task<IReadOnlyList<T>> GetListAsync<T>(string fileName)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<T>>($"data/{fileName}", JsonOptions) ?? [];
        }
        catch
        {
            return [];
        }
    }

    public async Task<T?> GetAsync<T>(string fileName)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<T>($"data/{fileName}", JsonOptions);
        }
        catch
        {
            return default;
        }
    }
}

