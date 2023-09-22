using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppProviderSchema
	{
		[JsonProperty("name")]
		public string Name { get; set; } = null!;

		[JsonProperty("type")]
		public string Type { get; set; } = null!;

		[JsonProperty("config")]
		public WhatsAppProviderConfigSchema Config { get; set; } = null!;
	}
}
