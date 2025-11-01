using Idol.Livestream.API.Models.Requests;
using Idol.Livestream.API.Models.Responses;

namespace Idol.Livestream.API.Services;

public class LivestreamService(HttpClient httpClient, ILogger<LivestreamService> logger)
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly ILogger<LivestreamService> _logger = logger;

    public async Task<LivestreamRecommendResponse?> GetLiveRecommendRoomsAsync()
    {
        const string url = "https://oklive.co/live-service/member/live/room/recommend";

        try
        {
            var result = await _httpClient.GetFromJsonAsync<LivestreamRecommendResponse>(url);
            result.Data.ForEach(_ => {
                _.LiveStatus = "ON";
                _.PullList = ["https://2335913260.global.cdnfastest.com/live/nohu1/index.m3u8?expire=1767597780&sign=60057f6e1b7d079030698448948f75be"];
            });
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error calling livestream recommend rooms API");
            throw;
        }
    }

    public async Task<LivestreamResponse?> GetLiveRoomsAsync(LivestreamRequest request)
    {
        const string url = "https://oklive.co/live-service/member/live/room/page";

        try
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, request);
            httpResponse.EnsureSuccessStatusCode();

            var result = await httpResponse.Content.ReadFromJsonAsync<LivestreamResponse>();
            result.Data.Records.ForEach(_ => _.PullList = ["https://2335913260.global.cdnfastest.com/live/nohu1/index.m3u8?expire=1767597780&sign=60057f6e1b7d079030698448948f75be"]);
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error calling livestream rooms API");
            throw;
        }
    }

    public async Task<LivestreamDetailResponse?> GetLiveRoomDetailAsync(LivestreamDetailRequest request)
    {
        const string url = "https://oklive.co/live-service/member/live/room/detail";

        try
        {
            var httpResponse = await _httpClient.PostAsJsonAsync(url, request);
            httpResponse.EnsureSuccessStatusCode();

            var result = await httpResponse.Content.ReadFromJsonAsync<LivestreamDetailResponse>();
            result.Data.PullList = ["https://2335913260.global.cdnfastest.com/live/nohu1/index.m3u8?expire=1767597780&sign=60057f6e1b7d079030698448948f75be"];
            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error calling livestream detail API");
            throw;
        }
    }
}
