using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppTextSchema
	{
		public WhatsAppTextSchema()
		{
			PrevieUrl = false;
		}

		[JsonProperty("body")]
		public string Body { get; set; } = null!;

		[JsonProperty("preview_url")]
		public bool PrevieUrl { get; set; } = false!;
	}
}
