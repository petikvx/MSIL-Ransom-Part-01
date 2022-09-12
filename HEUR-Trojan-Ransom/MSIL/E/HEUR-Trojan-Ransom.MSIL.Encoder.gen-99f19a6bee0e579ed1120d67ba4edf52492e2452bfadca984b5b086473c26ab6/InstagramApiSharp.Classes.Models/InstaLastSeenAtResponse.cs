using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Classes.Models;

public class InstaLastSeenAtResponse
{
	[JsonExtensionData]
	internal IDictionary<string, JToken> Extras { get; set; }
}
