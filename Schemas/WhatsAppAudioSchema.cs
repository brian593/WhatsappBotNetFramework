using Api.Schemas.WhatsApp.Base;
using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppAudioSchema : WhatsAppMultimediaBaseSchema
	{
		[JsonProperty("mime_type")]
		public string MimeType { get; set; } = null!;

		[JsonProperty("sha256")]
		public string Sha256 { get; set; } = null!;

		[JsonProperty("voice")]
		public bool Voice { get; set; }
	}
}
