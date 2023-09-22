using Newtonsoft.Json;

namespace Schemas.WhatsApp.Base
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public abstract class WhatsAppBaseSchema
	{
		public WhatsAppBaseSchema()
		{
			MessagingProduct = "whatsapp";
			RecipientType = "individual";
		}

		[JsonProperty("messaging_product")]
		public string MessagingProduct { get; set; } = null!;

		[JsonProperty("recipient_type")]
		public string RecipientType { get; set; } = null!;

		[JsonProperty("to")]
		public string To { get; set; } = null!;

		[JsonProperty("type")]
		public string Type { get; protected set; } = null!;
	}
}
