using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class MessageErrorsResponsePhone
{
	[JsonProperty("phone_number")]
	public List<string> Errors { get; set; }
}
