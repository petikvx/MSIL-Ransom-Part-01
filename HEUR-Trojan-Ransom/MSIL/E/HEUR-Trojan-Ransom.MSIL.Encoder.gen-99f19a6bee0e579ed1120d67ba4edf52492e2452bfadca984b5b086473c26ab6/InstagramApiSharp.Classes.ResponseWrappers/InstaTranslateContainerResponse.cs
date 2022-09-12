using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTranslateContainerResponse : InstaDefault
{
	[JsonProperty("comment_translations")]
	public List<InstaTranslateResponse> Translations { get; set; }
}
