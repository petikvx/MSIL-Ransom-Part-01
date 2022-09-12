using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Classes.Models.Business;

internal class InstaBusinessCityLocationContainer
{
	[JsonExtensionData]
	internal IDictionary<string, JToken> Extras { get; set; }
}
