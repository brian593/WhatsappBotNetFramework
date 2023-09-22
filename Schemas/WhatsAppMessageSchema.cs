namespace Schemas.WhatsApp
{
	public class WhatsAppMessageSchema
	{
#pragma warning disable IDE1006 // Estilos de nombres
		public string id { get; set; } = null!;

		public string from { get; set; } = null!;
#pragma warning restore IDE1006 // Estilos de nombres
		public WhatsAppAudioSchema Audio { get; set; } = null!;
		public WhatsAppImageSchema Image { get; set; } = null!;
		public WhatsAppVideoSchema Video { get; set; } = null!;
		public WhatsAppTextSchema Text { get; set; } = null!;
		public WhatsAppDocumentSchema Document { get; set; } = null!;
		public WhatsAppLocationSchema Location { get; set; } = null!;
		public WhatsAppReactionSchema Reaction { get; set; } = null!;
		public string Status { get; private set; } = null!;
		public WhatsAppStickerSchema Sticker { get; set; } = null!;
		public string MessageId { get; set; } = null!;
		public WhatsAppContextSchema Context { get; set; } = null!;
	}
}
