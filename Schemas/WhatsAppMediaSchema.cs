using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
    public class WhatsAppMediaSchema
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }
    }
}
