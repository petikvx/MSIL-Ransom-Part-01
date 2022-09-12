using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaSectionMediaLayoutContentResponse
{
	[JsonProperty("medias")]
	public List<InstaMediaAlbumResponse> Medias { get; set; }
}
