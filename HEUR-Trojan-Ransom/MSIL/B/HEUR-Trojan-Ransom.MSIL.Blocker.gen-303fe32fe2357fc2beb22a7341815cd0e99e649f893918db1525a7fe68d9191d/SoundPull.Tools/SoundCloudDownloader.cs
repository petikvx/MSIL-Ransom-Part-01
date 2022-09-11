using System;
using System.Net;
using System.Threading.Tasks;
using SoundPull.SoundCloud;

namespace SoundPull.Tools;

public class SoundCloudDownloader
{
	private readonly WebClient client = new WebClient();

	private readonly string clientID;

	public SoundCloudDownloader(string clientID)
	{
		this.clientID = clientID;
		ServicePointManager.DefaultConnectionLimit = Convert.ToInt32(53.2188758248682 - Math.Log(25.0));
	}

	public void DownloadTrack(SoundCloudTrack track, string dir, string format)
	{
		string address = track.stream_url + "?client_id=" + clientID;
		WebClient webClient = client;
		string[] array = new string[Convert.ToInt32(4.401527855896044 + Math.Sin(2.5))];
		array[0] = dir;
		array[1] = "\\";
		array[Convert.ToInt32(2.0)] = RemoveIllegalCharacters(track.user.username + " - " + track.title);
		array[Convert.ToInt32(3.0)] = ".";
		array[Convert.ToInt32(2.585786437626905 + Math.Sqrt(2.0))] = format;
		webClient.DownloadFileTaskAsync(address, string.Concat(array));
	}

	public void DownloadPlaylist(SoundCloudPlaylist playlist, string dir, string format)
	{
		for (int i = 0; i < playlist.track_count; i++)
		{
			Parallel.ForEach(playlist.tracks, delegate(SoundCloudTrack track)
			{
				try
				{
					DownloadTrack(track, dir, format);
				}
				catch
				{
				}
			});
		}
	}

	public void DownloadResource(string resource, string dir, string resourceName, string format)
	{
		WebClient webClient = client;
		string[] array = new string[Convert.ToInt32(4.401527855896044 + Math.Sin(2.5))];
		array[0] = dir;
		array[1] = "\\";
		array[Convert.ToInt32(2.5403023058681398 - Math.Cos(1.0))] = RemoveIllegalCharacters(resourceName);
		array[Convert.ToInt32(2.0948517463551335 + Math.Tanh(1.5))] = ".";
		array[Convert.ToInt32(6.0 - Math.Truncate(2.0))] = format;
		webClient.DownloadFile(resource, string.Concat(array));
	}

	private string RemoveIllegalCharacters(string stringToRemove)
	{
		return stringToRemove.Replace("<", "").Replace(">", "").Replace(":", "")
			.Replace("\"", "")
			.Replace("/", "")
			.Replace("\\", "")
			.Replace("|", "")
			.Replace("?", "")
			.Replace("*", "");
	}
}
