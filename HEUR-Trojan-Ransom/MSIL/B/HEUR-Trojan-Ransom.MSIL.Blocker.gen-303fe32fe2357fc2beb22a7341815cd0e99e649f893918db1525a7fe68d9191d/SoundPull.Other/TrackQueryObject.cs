using System.Collections.Generic;
using SoundPull.SoundCloud;

namespace SoundPull.Other;

public class TrackQueryObject
{
	public List<SoundCloudTrack> collection { get; set; }

	public string next_href { get; set; }
}
