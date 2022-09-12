using System.Collections;

namespace ns19;

internal interface Interface3 : ICollection, IEnumerable, IDictionary
{
	object UnderlyingDictionary { get; }
}
