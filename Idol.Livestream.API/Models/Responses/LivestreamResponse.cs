namespace Idol.Livestream.API.Models.Responses;

public class LivestreamResponse
{
    public int Code { get; set; }
    public string Message { get; set; }
    public LivestreamData Data { get; set; }
}

public class LivestreamRecommendResponse
{
    public int Code { get; set; }
    public string Message { get; set; }
    public List<LivestreamRecord> Data { get; set; }
}

public class LivestreamData
{
    public List<LivestreamRecord> Records { get; set; }
    public int Current { get; set; }
    public int Size { get; set; }
    public int Total { get; set; }
}

public class LivestreamRecord
{
    public string RoomCode { get; set; }
    public string AnchorCode { get; set; }
    public string AnchorAccount { get; set; }
    public string AnchorAvatar { get; set; }
    public string Level { get; set; }
    public string LevelIcon { get; set; }
    public string LevelAvatar { get; set; }
    public string RoomTitle { get; set; }
    public string Channel { get; set; }
    public List<string> ChannelList { get; set; } = [];
    public string Cover { get; set; }
    public int ViewCount { get; set; }
    public string LiveStatus { get; set; }
    public List<string> PullList { get; set; } = ["https://new88-live.sgp1.cdn.digitaloceanspaces.com/default480/New88-xem-live-cung-idol_640x360.m3u8"];
    public string LiveMethod { get; set; }
    public long WebTagId { get; set; }
    public string WebTagName { get; set; }
    public string WebTagH5Url { get; set; }
    public string WebTagPcUrl { get; set; }
    public string WebTagH5RsType { get; set; }
    public string WebTagPcRsType { get; set; }
}
