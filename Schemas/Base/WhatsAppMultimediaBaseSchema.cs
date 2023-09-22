using Newtonsoft.Json;

namespace Schemas.WhatsApp.Base
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public abstract class WhatsAppMultimediaBaseSchema
	{
		[JsonProperty("link")]
		public string Link { get; set; } = null!;

		[JsonProperty("id")] //MEDIA-OBJECT-ID
		public string Id { get; set; } = null!;

		[JsonProperty("caption")]
		public string Caption { get; set; } = null!;

		[JsonProperty("filename")]
		public string Filename { get; set; } = null!;

		[JsonProperty("provider")]
		public WhatsAppProviderSchema Provider { get; set; } = null!;
	}
}
