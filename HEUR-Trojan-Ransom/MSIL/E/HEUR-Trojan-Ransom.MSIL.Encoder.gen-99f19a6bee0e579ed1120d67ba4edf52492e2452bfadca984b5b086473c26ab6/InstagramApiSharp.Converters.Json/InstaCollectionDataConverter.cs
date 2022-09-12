using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaCollectionDataConverter : JsonConverter
{
	private class InstaCollectionItemsToMedia
	{
		[JsonProperty("media")]
		public InstaMediaItemResponse Media { get; set; }
	}

	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaMediaListResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		List<InstaCollectionItemsToMedia> list = JToken.Load(reader).ToObject<List<InstaCollectionItemsToMedia>>();
		InstaMediaListResponse listMedia = new InstaMediaListResponse();
		list.ForEach(delegate(InstaCollectionItemsToMedia item)
		{
			listMedia.Medias.Add(item.Media);
		});
		return listMedia;
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
