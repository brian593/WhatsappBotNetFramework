using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppLocationSchema
	{
		[JsonProperty("longitude")]
		public string Longitude { get; set; } = null!;

		[JsonProperty("latitude")]
		public string Latitude { get; set; } = null!;

		[JsonProperty("name")]
		public string Name { get; set; } = null!;

		[JsonProperty("address")]
		public string Address { get; set; } = null!;
	}
}
