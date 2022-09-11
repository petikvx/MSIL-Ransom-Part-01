using System.Collections.Generic;
using SoundPull.SoundCloud;

namespace SoundPull.Other;

public class PlaylistQueryObject
{
	public List<SoundCloudPlaylist> collection { get; set; }

	public string next_href { get; set; }
}
