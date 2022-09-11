using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using HtmlAgilityPack;
using Newtonsoft.Json;
using SoundPull.Other;
using SoundPull.SoundCloud.Subresources;

namespace SoundPull.SoundCloud;

public class SoundCloudUser
{
	private const string apiURL = "https://api.soundcloud.com/";

	private readonly HttpClient jsonClient = new HttpClient();

	private readonly HtmlWeb webClient = new HtmlWeb();

	private readonly JsonSerializer serializer = new JsonSerializer();

	public readonly string kind = "user";

	public int id { get; set; }

	public string permalink { get; set; }

	public string username { get; set; }

	public string last_modified { get; set; }

	public string uri { get; set; }

	public string permalink_url { get; set; }

	public string avatar_url { get; set; }

	public string country { get; set; }

	public string first_name { get; set; }

	public string last_name { get; set; }

	public string full_name { get; set; }

	public string description { get; set; }

	public string city { get; set; }

	public string discogs_name { get; set; }

	public string myspace_name { get; set; }

	public string website { get; set; }

	public string website_title { get; set; }

	public int? track_count { get; set; }

	public int? playlist_count { get; set; }

	public bool online { get; set; }

	public string plan { get; set; }

	public int? public_favorites_count { get; set; }

	public int? followers_count { get; set; }

	public int? followings_count { get; set; }

	public int? likes_count { get; set; }

	public int? reposts_count { get; set; }

	public int? comments_count { get; set; }

	public TrackQueryObject GetTracksResource(string clientID)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0))];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(1.2384058440442351 + Math.Tanh(1.0))] = "/tracks?linked_partitioning=1&limit=50&client_id=";
		array[Convert.ToInt32(4.0 - Math.Truncate(1.5))] = clientID;
		string requestUri = string.Concat(array);
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			return val2.Deserialize<TrackQueryObject>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public TrackQueryObject GetFavoritesResource(string clientID)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(4.0)];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(1.0 + Math.Abs(1.0))] = "/favorites?linked_partitioning=1&limit=50&client_id=";
		array[Convert.ToInt32(3.070737201667703 - Math.Cos(1.5))] = clientID;
		string requestUri = string.Concat(array);
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			return val2.Deserialize<TrackQueryObject>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public PlaylistQueryObject GetPlaylistResource(string clientID)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(4.0)];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(0.4425922753450977 + Math.Tan(1.0))] = "/playlists?linked_partitioning=1&limit=50&client_id=";
		array[Convert.ToInt32(4.0 - Math.Floor(1.5))] = clientID;
		string requestUri = string.Concat(array);
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			return val2.Deserialize<PlaylistQueryObject>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public UserQueryObject GetFollowingsResource(string clientID)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(4.693147180559945 - Math.Log(2.0))];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(2.0)] = "/followings?linked_partitioning=1&limit=50&client_id=";
		array[3] = clientID;
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

	public UserQueryObject GetFollowersResource(string clientID)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(2.0 + Math.Floor(2.0))];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))] = "/followers?linked_partitioning=1&limit=50&client_id=";
		array[Convert.ToInt32(2.0 + Math.Truncate(1.5))] = clientID;
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

	public List<SoundCloudComment> GetCommentResource(string clientID)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		object[] array = new object[Convert.ToInt32(4.0)];
		array[0] = "https://api.soundcloud.com/users/";
		array[1] = id;
		array[Convert.ToInt32(3.0 - Math.Ceiling(1.0))] = "/comments?client_id=";
		array[Convert.ToInt32(5.0 - Math.Round(1.5))] = clientID;
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

	public List<SoundCloudTrack> GetTrackReposts(string clientID)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		List<SoundCloudTrack> list = new List<SoundCloudTrack>();
		string text = permalink_url + "/reposts";
		HtmlDocument val = webClient.Load(text);
		HtmlNodeCollection val2 = val.get_DocumentNode().SelectNodes("//div[@id='app']//h2//a[starts-with(@href, '/')]");
		int num = 0;
		foreach (HtmlNode item in (IEnumerable<HtmlNode>)val2)
		{
			if (num % Convert.ToInt32(1.0 + Math.Sqrt(1.0)) == 0)
			{
				string attributeValue = item.GetAttributeValue("href", "null");
				string requestUri = "http://api.soundcloud.com/resolve?url=http://soundcloud.com" + attributeValue + "&client_id=" + clientID;
				using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
				using StreamReader streamReader = new StreamReader(stream);
				JsonReader val3 = (JsonReader)new JsonTextReader((TextReader)streamReader);
				try
				{
					list.Add(serializer.Deserialize<SoundCloudTrack>(val3));
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			num++;
		}
		return list;
	}
}
