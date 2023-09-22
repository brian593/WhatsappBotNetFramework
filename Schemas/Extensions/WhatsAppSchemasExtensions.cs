namespace Schemas.WhatsApp.Extensions
{
	public static class WhatsAppSchemasExtensions
	{
		public static WhatsAppContentTypeSchema GetContentType(this WhatsAppHookSchema hookSchema)
		{
			if (hookSchema?.entry?.Length > 0)
			{
				string messageId = hookSchema?.entry?[0]?.changes?[0]?.value?.messages?[0]?.id ?? string.Empty;
				string phoneNumber = hookSchema?.entry?[0]?.changes?[0]?.value?.messages?[0]?.from ?? string.Empty;
				string userName = hookSchema?.entry?[0]?.changes?[0]?.value?.contacts?[0]?.profile?.name ?? string.Empty;
				WhatsAppEntrySchema? entry = hookSchema?.entry[0];
				if (entry?.changes?.Length > 0)
				{
					WhatsAppChangeSchema change = entry.changes[0];
					WhatsAppValueSchema value = change.value;
					if (value?.messages?.Length > 0)
					{
						WhatsAppMessageSchema message = value.messages[0];
						string body = message?.Text?.Body;
						if (body != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.text.ToString(),
								Content = body,
								MessageId = messageId,
								PhoneNumber = phoneNumber,
								UserName = userName
							};
						}

						WhatsAppAudioSchema? audio = message?.Audio;
						if (audio != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.audio.ToString(),
								Content = audio.Id,
								Filename = $"{audio.Id}.ogg",//Los audios no tienen name
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppVideoSchema? video = message?.Video;
						if (video != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.video.ToString(),
								Content = video.Id,
								Filename = $"{video.Id}.mp4",//Los videos no tienen name
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppImageSchema? image = message?.Image;
						if (image != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.image.ToString(),
								Content = image.Id,
								Filename = $"{image.Id}.jpg",//Las imagenes no tienen name
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppDocumentSchema? document = message?.Document;
						if (document != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.document.ToString(),
								Content = document.Id,
								Filename = document.Filename,
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppLocationSchema? location = message?.Location;
						if (location != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.location.ToString(),
								Content = $"lat:{location.Latitude} lon:{location.Longitude}",
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppReactionSchema? reaction = message?.Reaction;
						if (reaction != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.reaction.ToString(),
								Content = reaction.Emoji,
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}

						WhatsAppStickerSchema? sticker = message?.Sticker;
						if (sticker != null)
						{
							return new WhatsAppContentTypeSchema
							{
								Type = MessageTypes.sticker.ToString(),
								Content = sticker.Id,
								MessageId = messageId,
								PhoneNumber = phoneNumber,
                                UserName = userName
                            };
						}
					}
				}
			}
			// Si no se encuentra el cuerpo del texto o es nulo, puedes devolver un valor por defecto o null
			return new WhatsAppContentTypeSchema();
		}
	}
}
