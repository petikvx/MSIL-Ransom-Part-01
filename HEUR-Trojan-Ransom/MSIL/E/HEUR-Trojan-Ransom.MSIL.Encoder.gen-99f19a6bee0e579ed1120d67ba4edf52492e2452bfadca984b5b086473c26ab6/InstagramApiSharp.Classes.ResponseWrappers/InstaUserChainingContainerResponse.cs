using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserChainingContainerResponse : InstaDefault
{
	[JsonProperty("is_backup")]
	public bool IsBackup { get; set; }

	[JsonProperty("users")]
	public List<InstaUserChainingResponse> Users { get; set; }
}
