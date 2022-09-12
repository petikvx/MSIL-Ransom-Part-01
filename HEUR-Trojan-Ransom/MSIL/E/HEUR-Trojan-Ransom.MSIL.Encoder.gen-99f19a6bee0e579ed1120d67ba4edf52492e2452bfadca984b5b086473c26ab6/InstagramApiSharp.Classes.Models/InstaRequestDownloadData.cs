using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaRequestDownloadData
{
	[JsonProperty("success")]
	public bool Success { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }
}
