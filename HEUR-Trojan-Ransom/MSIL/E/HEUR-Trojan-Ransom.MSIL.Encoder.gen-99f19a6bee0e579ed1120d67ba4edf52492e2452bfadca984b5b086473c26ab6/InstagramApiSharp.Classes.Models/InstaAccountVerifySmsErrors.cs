using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountVerifySmsErrors
{
	[JsonProperty("verification_code")]
	public List<string> VerificationCode { get; set; }
}
