using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq;

public interface IJEnumerable<out T> : IEnumerable<T>, IEnumerable where T : notnull, JToken
{
	IJEnumerable<JToken> this[object key] { get; }
}
