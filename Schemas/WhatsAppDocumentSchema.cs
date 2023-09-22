using Api.Schemas.WhatsApp.Base;
using Newtonsoft.Json;

namespace Schemas.WhatsApp
{
	[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
	public class WhatsAppDocumentSchema : WhatsAppMultimediaBaseSchema
	{

	}
}
