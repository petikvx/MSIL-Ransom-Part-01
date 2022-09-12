using System.Collections;

namespace Newtonsoft.Json.Utilities;

internal interface IWrappedDictionary : IEnumerable, IDictionary, ICollection
{
	object UnderlyingDictionary { get; }
}
