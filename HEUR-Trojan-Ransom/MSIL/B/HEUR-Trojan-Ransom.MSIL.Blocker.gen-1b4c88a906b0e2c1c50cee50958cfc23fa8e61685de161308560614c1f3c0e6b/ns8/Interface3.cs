using System.Collections;

namespace ns8;

internal interface Interface3 : IDictionary, IEnumerable, ICollection
{
	object UnderlyingDictionary { get; }
}
