using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using SoundPull.SoundCloud;

namespace SoundPull;

public class SoundPullSession
{
	private readonly HttpClient jsonClient = new HttpClient();

	private readonly JsonSerializer serializer = new JsonSerializer();

	private readonly string clientID;

	private const string apiResolveURL = "https://api.soundcloud.com/resolve.json?url=";

	private const string soundCloudURL = "https://soundcloud.com/";

	public SoundPullSession(string clientID)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		this.clientID = clientID;
	}

	public SoundCloudTrack GetTrack(string userPermalink, string trackPermalink)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		string requestUri = "https://api.soundcloud.com/resolve.json?url=" + ("https://soundcloud.com/" + userPermalink + "/" + trackPermalink).Replace(":", "%3A").Replace("/", "%2F") + "&client_id=" + clientID;
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			return serializer.Deserialize<SoundCloudTrack>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public SoundCloudUser GetUser(string userPermalink)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		string requestUri = "https://api.soundcloud.com/resolve.json?url=" + ("https://soundcloud.com/" + userPermalink).Replace(":", "%3A").Replace("/", "%2F") + "&client_id=" + clientID;
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			return serializer.Deserialize<SoundCloudUser>(val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public SoundCloudPlaylist GetPlaylist(string userPermalink, string playlistPermalink)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		string requestUri = "https://api.soundcloud.com/resolve.json?url=" + ("https://soundcloud.com/" + userPermalink + "/sets/" + playlistPermalink).Replace(":", "%3A").Replace("/", "%2F") + "&client_id=" + clientID;
		using Stream stream = jsonClient.GetStreamAsync(requestUri).Result;
		using StreamReader streamReader = new StreamReader(stream);
		JsonReader val = (JsonReader)new JsonTextReader((TextReader)streamReader);
		try
		{
			return serializer.Deserialize<SoundCloudPlaylist>(val);
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
