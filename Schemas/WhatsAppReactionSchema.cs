using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppReactionSchema
	{
		[JsonProperty("emoji")]
		public string Emoji { get; set; } = null!;

		[JsonProperty("message_id")]
		public string MessageId { get; set; } = null!;
	}
}
