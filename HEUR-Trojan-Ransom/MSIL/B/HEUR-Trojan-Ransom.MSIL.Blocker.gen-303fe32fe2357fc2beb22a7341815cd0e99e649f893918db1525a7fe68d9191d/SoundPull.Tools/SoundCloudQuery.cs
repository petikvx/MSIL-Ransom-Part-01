using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using SoundPull.Other;

namespace SoundPull.Tools;

public class SoundCloudQuery
{
	private readonly HttpClient jsonClient = new HttpClient();

	private readonly string clientID;

	private const string apiURL = "https://api.soundcloud.com/";

	public SoundCloudQuery(string clientID)
	{
		this.clientID = clientID;
	}

	public Tuple<TrackQueryObject, UserQueryObject, PlaylistQueryObject> GetAllQuery(string query, int limit)
	{
		TrackQueryObject trackQuery = GetTrackQuery(query, limit);
		UserQueryObject userQuery = GetUserQuery(query, limit);
		PlaylistQueryObject playlistQuery = GetPlaylistQuery(query, limit);
		return Tuple.Create(trackQuery, userQuery, playlistQuery);
	}

	public TrackQueryObject GetTrackQuery(string query, int limit)
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		if (limit > Convert.ToInt32(190.0 + Math.Sqrt(100.0)) || limit < 1)
		{
			limit = Convert.ToInt32(50.132351750097776 + Math.Sin(25.0));
		}
		object[] array = new object[Convert.ToInt32(3.0 + Math.Round(3.0))];
		array[0] = "https://api.soundcloud.com/tracks.json?q=";
		array[1] = query;
		array[Convert.ToInt32(2.0)] = "&linked_partitioning=1&limit=";
		array[Convert.ToInt32(4.0 - Math.Truncate(1.5))] = limit;
		array[Convert.ToInt32(1.8149601367384811 - Math.Tan(2.0))] = "&client_id=";
		array[Convert.ToInt32(5.98661429815143 - Math.Tanh(2.5))] = clientID;
		string text = string.Concat(array).Replace(" ", "%20");
		Console.WriteLine(text);
		using Stream stream = jsonClient.GetStreamAsync(text).Result;
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

	public UserQueryObject GetUserQuery(string query, int limit)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		if (limit > Convert.ToInt32(300.0 - Math.Truncate(100.0)) || limit < 1)
		{
			limit = Convert.ToInt32(50.0);
		}
		object[] array = new object[Convert.ToInt32(6.9950547536867305 - Math.Tanh(3.0))];
		array[0] = "https://api.soundcloud.com/users.json?q=";
		array[1] = query;
		array[Convert.ToInt32(3.5574077246549023 - Math.Tan(1.0))] = "&linked_partitioning=1&limit=";
		array[Convert.ToInt32(1.0 + Math.Round(1.5))] = limit;
		array[Convert.ToInt32(3.3068528194400546 + Math.Log(2.0))] = "&client_id=";
		array[Convert.ToInt32(7.0 - Math.Round(2.5))] = clientID;
		string requestUri = string.Concat(array).Replace(" ", "%20");
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

	public PlaylistQueryObject GetPlaylistQuery(string query, int limit)
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		if (limit > Convert.ToInt32(201.0 - Math.Tanh(100.0)) || limit < 1)
		{
			limit = Convert.ToInt32(49.866473592978465 - Math.Tan(25.0));
		}
		object[] array = new object[Convert.ToInt32(3.0 + Math.Floor(3.0))];
		array[0] = "https://api.soundcloud.com/playlists.json?q=";
		array[1] = query;
		array[Convert.ToInt32(2.0 + Math.Log10(1.0))] = "&linked_partitioning=1&limit=";
		array[Convert.ToInt32(17.10141994717172 - Math.Tan(1.5))] = limit;
		array[Convert.ToInt32(6.0 - Math.Round(2.0))] = "&client_id=";
		array[Convert.ToInt32(4.252977702761339 - Math.Tan(2.5))] = clientID;
		string requestUri = string.Concat(array).Replace(" ", "%20");
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

	public TrackQueryObject GetNextTrackInQuery(string link)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		using Stream stream = jsonClient.GetStreamAsync(link).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			TrackQueryObject trackQueryObject = val2.Deserialize<TrackQueryObject>(val);
			link = trackQueryObject.next_href;
			return trackQueryObject;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public UserQueryObject GetNextUserInQuery(string link)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		using Stream stream = jsonClient.GetStreamAsync(link).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			UserQueryObject userQueryObject = val2.Deserialize<UserQueryObject>(val);
			link = userQueryObject.next_href;
			return userQueryObject;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public PlaylistQueryObject GetNextPlaylistInQuery(string link)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		using Stream stream = jsonClient.GetStreamAsync(link).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			JsonSerializer val2 = new JsonSerializer();
			PlaylistQueryObject playlistQueryObject = val2.Deserialize<PlaylistQueryObject>(val);
			link = playlistQueryObject.next_href;
			return playlistQueryObject;
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public string GetClientID()
	{
		return clientID;
	}
}
