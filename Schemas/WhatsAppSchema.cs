using Api.Schemas.WhatsApp.Base;
using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	public enum MessageTypes
	{
		text,
		image,
		document,
		audio,
		video,
		sticker,
		location,
		reaction,
		read
	}

	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppSchema : WhatsAppBaseSchema
	{
		public WhatsAppSchema(MessageTypes messageTypes)
		{
			if (messageTypes != MessageTypes.read)
				Type = messageTypes.ToString();
			else
				Status = "read";
		}

		#region --Media--
		[JsonProperty("audio")]
		public WhatsAppAudioSchema Audio { get; set; } = null!;

		[JsonProperty("document")]
		public WhatsAppDocumentSchema Document { get; set; } = null!;

		[JsonProperty("image")]
		public WhatsAppImageSchema Image { get; set; } = null!;

		[JsonProperty("video")]
		public WhatsAppVideoSchema Video { get; set; } = null!;

		[JsonProperty("sticker")]
		public WhatsAppStickerSchema Sticker { get; set; } = null!;
		#endregion

		[JsonProperty("text")]
		public WhatsAppTextSchema Text { get; set; } = null!;

		[JsonProperty("location")]
		public WhatsAppLocationSchema Location { get; set; } = null!;

		[JsonProperty("reaction")]
		public WhatsAppReactionSchema Reaction { get; set; } = null!;

		[JsonProperty("status")]
		public string Status { get; private set; } = null!;

		[JsonProperty("message_id")]
		public string MessageId { get; set; } = null!;

		[JsonProperty("context")]
		public WhatsAppContextSchema Context { get; set; } = null!;
	}
}
