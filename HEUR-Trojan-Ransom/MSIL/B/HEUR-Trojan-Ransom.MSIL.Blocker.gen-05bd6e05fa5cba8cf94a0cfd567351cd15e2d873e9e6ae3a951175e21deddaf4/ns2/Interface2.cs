using System.Collections;

namespace ns2;

internal interface Interface2 : IList, IEnumerable, ICollection
{
	object UnderlyingCollection { get; }
}
