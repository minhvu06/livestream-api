namespace Idol.Livestream.API.Models.Responses;

public class LivestreamDetailResponse
{
    public int Code { get; set; }
    public string Message { get; set; }
    public LivestreamDetailData Data { get; set; }
}

public class LivestreamDetailData
{
    public string RemainDisabledTime { get; set; }
    public string TotalDisabledTime { get; set; }
    public bool Disabled { get; set; }
    public string RoomId { get; set; }
    public int ClickCount { get; set; }
    // public List<RightAd> RightAds { get; set; }
    public string GiftValue { get; set; }
    public string LiveMethod { get; set; }
    public List<string> WelcomeList { get; set; }
    // public PinMsg PinMsg { get; set; }
    // public UserPermission UserPermission { get; set; }
    public string RoomCode { get; set; }
    public string AnchorCode { get; set; }
    public string AnchorAccount { get; set; }
    public string AnchorAvatar { get; set; }
    public string LevelId { get; set; }
    public string LevelName { get; set; }
    public string LevelIcon { get; set; }
    public string LevelCartoon { get; set; }
    public string LevelAvatar { get; set; }
    public string RoomTitle { get; set; }
    public string Channel { get; set; }
    public List<string> ChannelList { get; set; } = [];
    public string Cover { get; set; }
    public int ViewCount { get; set; }
    public string FollowStatus { get; set; }
    public string? LiveStatus { get; set; }
    public List<string> PullList { get; set; } = ["https://new88-live.sgp1.cdn.digitaloceanspaces.com/default480/New88-xem-live-cung-idol_640x360.m3u8"];
    public int WebTagId { get; set; }
    public string WebTagName { get; set; }
    public string WebTagH5Url { get; set; }
    public string WebTagPcUrl { get; set; }
    public string WebTagH5RsType { get; set; }
    public string WebTagPcRsType { get; set; }
    public int FansCount { get; set; }
    public long ServerTime { get; set; }
}

public class RightAd
{
    public string? RedirectUrl { get; set; }
    public string AppUrl { get; set; }
    public string WebUrl { get; set; }
    public string AppRedirectUrl { get; set; }
    public string WebRedirectUrl { get; set; }
}

public class PinMsg
{
    public string RoomCode { get; set; }
    public string? NickName { get; set; }
    public string? Avatar { get; set; }
    public string? AccountCode { get; set; }
    public string? AccountType { get; set; }
    public string? LevelName { get; set; }
    public string? LevelIcon { get; set; }
    public string? Text { get; set; }
    public string? MsgId { get; set; }
    public string Action { get; set; }
}

public class UserPermission
{
    public string MsgPin { get; set; }
    public string MsgDel { get; set; }
    public string MsgLight { get; set; }
    public string MsgFilter { get; set; }
    public string MsgLimit { get; set; }
    public string MsgForbid { get; set; }
}
