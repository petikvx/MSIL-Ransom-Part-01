using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountTwoFactor
{
	[JsonProperty("backup_codes")]
	public List<string> BackupCodes { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }

	[JsonProperty("error_type")]
	internal string ErrorType { get; set; }

	[JsonProperty("message")]
	public string Message { get; set; }
}
