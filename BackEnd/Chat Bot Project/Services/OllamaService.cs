using System.Text;
using Newtonsoft.Json;

public class OllamaService
{
    private readonly HttpClient _httpClient;

    public OllamaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> AskAI(string message)
    {
        var body = new
        {
            model = "mistral",
            prompt = message,
            stream = false
        };

        var request = new HttpRequestMessage(
            HttpMethod.Post,
            "http://localhost:11434/api/generate"
        );

        request.Content = new StringContent(
            JsonConvert.SerializeObject(body),
            Encoding.UTF8,
            "application/json"
        );

        var response = await _httpClient.SendAsync(request);
        var json = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Ollama error: {json}");
        }

        dynamic result = JsonConvert.DeserializeObject(json);
        return result.response.ToString();
    }
}
