using System.Collections;

namespace Newtonsoft.Json.Utilities;

internal interface IWrappedDictionary : IDictionary, IEnumerable, ICollection
{
	object UnderlyingDictionary { get; }
}
