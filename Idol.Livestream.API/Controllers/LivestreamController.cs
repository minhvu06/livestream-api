using Idol.Livestream.API.Models.Requests;
using Idol.Livestream.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Idol.Livestream.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivestreamController(LivestreamService livestreamService) : Controller
{
    private readonly LivestreamService _livestreamService = livestreamService;

    [HttpGet("recommend")]
    public async Task<IActionResult> GetListRecommend()
    {
        var result = await _livestreamService.GetLiveRecommendRoomsAsync();
        return Ok(result);
    }

    [HttpPost("list")]
    public async Task<IActionResult> GetListLivestream(LivestreamRequest request)
    {
        var result = await _livestreamService.GetLiveRoomsAsync(request);
        return Ok(result);
    }

    [HttpPost("detail")]
    public async Task<IActionResult> GetListLivestream(LivestreamDetailRequest request)
    {
        var result = await _livestreamService.GetLiveRoomDetailAsync(request);
        return Ok(result);
    }
}
