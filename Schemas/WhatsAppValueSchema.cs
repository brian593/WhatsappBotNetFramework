namespace Schemas.WhatsApp
{
	public class WhatsAppValueSchema
	{
        //public int ad_id { get; set; }
        //public long form_id { get; set; }
        //public long leadgen_id { get; set; }
        //public int created_time { get; set; }
        //public long page_id { get; set; }
        //public int adgroup_id { get; set; }

#pragma warning disable IDE1006 // Estilos de nombres
        public WhatsAppContactsSchema[] contacts { get; set; } = null!;
        public WhatsAppMessageSchema[] messages { get; set; } = null!;

#pragma warning restore IDE1006 // Estilos de nombres
	}
}
