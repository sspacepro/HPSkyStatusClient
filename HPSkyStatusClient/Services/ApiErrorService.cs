namespace HPSkyStatusClient.Services;

public class ApiErrorService
{
    public async Task<string> GetErrorMessage(HttpResponseMessage response)
    {
        return await response.Content.ReadAsStringAsync();
    }
}