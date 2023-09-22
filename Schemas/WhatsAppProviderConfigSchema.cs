using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppProviderConfigSchema
	{
		[JsonProperty("username")]
		public string Username { get; set; } = null!;

		[JsonProperty("password")]
		public string Password { get; set; } = null!;

		[JsonProperty("bearer")]
		public string Bearer { get; set; } = null!;
	}
}
