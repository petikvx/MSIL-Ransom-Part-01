using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace ns0;

internal interface Interface10<out T> : IEnumerable<T>, IEnumerable where T : JToken
{
	Interface10<JToken> this[object object_0] { get; }
}
