using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Classes.Models.Business;

internal class InstaBusinessCategoryContainer
{
	[JsonExtensionData]
	internal IDictionary<string, JToken> Extras { get; set; }
}
