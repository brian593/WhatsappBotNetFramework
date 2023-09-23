using System;
namespace Api
{
	public class Settings
	{
        public string Url { get; set; } = null!;
        public string InstanceId { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string VerifyToken { get; set; } = null!;
        public string DownloadFilePath { get; set; } = null!;
        public string BotName { get; set; } = null!;
        public string BotStickerId { get; set; } = null!;
        public string UrlBotSticker { get; set; } = null!;

        public string RiveFileName { get; set; } = null!;
    }
}

