using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters.Json;

internal class InstaTopicalExploreFeedDataConverter : JsonConverter
{
	public override bool CanConvert(Type objectType)
	{
		return objectType == typeof(InstaTopicalExploreFeedResponse);
	}

	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
	{
		JToken jToken = JToken.Load(reader);
		JToken jToken2 = jToken["sectional_items"];
		InstaTopicalExploreFeedResponse instaTopicalExploreFeedResponse = jToken.ToObject<InstaTopicalExploreFeedResponse>();
		foreach (JToken item in (IEnumerable<JToken>)jToken2)
		{
			JToken jToken3 = item["layout_content"];
			if (jToken3 != null)
			{
				JToken jToken4 = jToken3["two_by_two_item"];
				JToken jToken5 = jToken3["fill_items"];
				JToken jToken6 = jToken3["medias"];
				if (jToken6 != null)
				{
					foreach (JToken item2 in (IEnumerable<JToken>)jToken6)
					{
						JToken jToken7 = item2["media"];
						if (jToken7 != null)
						{
							InstaMediaItemResponse media = GetMedia(jToken7);
							instaTopicalExploreFeedResponse.Medias.Add(media);
						}
					}
				}
				if (jToken5 != null)
				{
					foreach (JToken item3 in (IEnumerable<JToken>)jToken5)
					{
						JToken jToken8 = item3["media"];
						if (jToken8 != null)
						{
							InstaMediaItemResponse media2 = GetMedia(jToken8);
							instaTopicalExploreFeedResponse.Medias.Add(media2);
						}
					}
				}
				if (jToken4 != null)
				{
					JToken jToken9 = jToken4["channel"];
					JToken jToken10 = jToken4["igtv"];
					if (jToken9 != null)
					{
						instaTopicalExploreFeedResponse.Channel = GetChannel(jToken9);
					}
					if (jToken10 != null)
					{
						JToken jToken11 = jToken10["tv_guide"];
						if (jToken11 != null)
						{
							JToken jToken12 = jToken11["channels"];
							if (jToken12 != null)
							{
								List<InstaTVChannelResponse> tVs = GetTVs(jToken12);
								if (tVs != null && tVs.Count > 0)
								{
									instaTopicalExploreFeedResponse.TVChannels.AddRange(tVs);
								}
							}
						}
					}
				}
			}
			_ = item["channel"];
			_ = item["media"];
		}
		return instaTopicalExploreFeedResponse;
	}

	private List<InstaTVChannelResponse> GetTVs(JToken token)
	{
		return token.ToObject<List<InstaTVChannelResponse>>();
	}

	private InstaChannelResponse GetChannel(JToken token)
	{
		return token.ToObject<InstaChannelResponse>();
	}

	private InstaMediaItemResponse GetMedia(JToken token)
	{
		return token.ToObject<InstaMediaItemResponse>();
	}

	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value);
	}
}
