using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using SoundPull.Other;
using SoundPull.SoundCloud.Subresources;

namespace SoundPull.SoundCloud;

public class SoundCloudTrack
{
	private const string apiURL = "https://api.soundcloud.com/";

	private readonly HttpClient jsonClient = new HttpClient();

	public readonly string kind = "track";

	public int id { get; set; }

	public string created_at { get; set; }

	public int user_id { get; set; }

	public int duration { get; set; }

	public bool? commentable { get; set; }

	public string state { get; set; }

	public int original_content_size { get; set; }

	public string last_modified { get; set; }

	public string sharing { get; set; }

	public string tag_list { get; set; }

	public string permalink { get; set; }

	public bool? streamable { get; set; }

	public string embeddable_by { get; set; }

	public string purchase_url { get; set; }

	public string purchase_title { get; set; }

	public int? label_id { get; set; }

	public string genre { get; set; }

	public string title { get; set; }

	public string description { get; set; }

	public string label_name { get; set; }

	public string release { get; set; }

	public string track_type { get; set; }

	public string key_signature { get; set; }

	public string isrc { get; set; }

	public string video_url { get; set; }

	public string bpm { get; set; }

	public int? release_year { get; set; }

	public int? release_month { get; set; }

	public int? relaese_day { get; set; }

	public string original_format { get; set; }

	public string license { get; set; }

	public string uri { get; set; }

	public SoundCloudUser user { get; set; }

	public string permalink_url { get; set; }

	public string artwork_url { get; set; }

	public string stream_url { get; set; }

	public string download_url { get; set; }

	public int playback_count { get; set; }

	public int download_count { get; set; }

	public int favoritings_count { get; set; }

	public int reposts_count { get; set; }

	public int comment_count { get; set; }

	public bool? downloadable { get; set; }

	public string waveform_url { get; set; }

	public string attachments_url { get; set; }

	public string policy { get; set; }

	public string monetization_model { get; set; }

	public List<SoundCloudComment> GetCommentResource(string clientID)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(3.6989700043360187 + Math.Log10(2.0))];
		array[0] = "https://api.soundcloud.com/tracks/";
		array[1] = id;
		array[Convert.ToInt32(2.8414709848078967 - Math.Sin(1.0))] = "/comments?client_id=";
		array[Convert.ToInt32(17.10141994717172 - Math.Tan(1.5))] = clientID;
		string requestUri = string.Concat(array);
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			return val2.Deserialize<List<SoundCloudComment>>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public UserQueryObject GetFavoritersResource(string clientID)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(2.0 + Math.Floor(2.0))];
		array[0] = "https://api.soundcloud.com/tracks/";
		array[1] = id;
		array[Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0))] = "/favoriters?linked_partitioning=1&limit=50&client_id=";
		array[Convert.ToInt32(3.9051482536448665 - Math.Tanh(1.5))] = clientID;
		string requestUri = string.Concat(array);
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			return val2.Deserialize<UserQueryObject>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
