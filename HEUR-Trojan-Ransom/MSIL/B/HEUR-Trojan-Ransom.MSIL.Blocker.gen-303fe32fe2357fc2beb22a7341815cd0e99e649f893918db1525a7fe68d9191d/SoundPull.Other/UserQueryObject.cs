using System.Collections.Generic;
using SoundPull.SoundCloud;

namespace SoundPull.Other;

public class UserQueryObject
{
	public List<SoundCloudUser> collection { get; set; }

	public string next_href { get; set; }
}
