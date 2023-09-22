using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppContextSchema
	{
		[JsonProperty("message_id")]
		public string MessageId { get; set; } = null!;
	}
}
