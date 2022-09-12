using System.Collections;

namespace ns12;

internal interface Interface3 : IEnumerable, IDictionary, ICollection
{
	object UnderlyingDictionary { get; }
}
