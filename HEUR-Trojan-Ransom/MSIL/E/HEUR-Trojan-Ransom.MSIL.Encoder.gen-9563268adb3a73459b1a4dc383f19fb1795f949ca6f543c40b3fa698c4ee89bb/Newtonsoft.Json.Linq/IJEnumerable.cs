using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq;

public interface IJEnumerable<out T> : IEnumerable, IEnumerable<T> where T : notnull, JToken
{
	IJEnumerable<JToken> this[object key] { get; }
}
