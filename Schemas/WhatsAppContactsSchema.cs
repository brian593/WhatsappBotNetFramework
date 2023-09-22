using System;
namespace Schemas.WhatsApp
{
	public class WhatsAppContactsSchema
	{
#pragma warning disable IDE1006 // Estilos de nombres
        public WhatsAppProfileSchema profile { get; set; } = null!;
        public string wa_id { get; set; } = null!;
#pragma warning restore IDE1006 // Estilos de nombres

    }
}

