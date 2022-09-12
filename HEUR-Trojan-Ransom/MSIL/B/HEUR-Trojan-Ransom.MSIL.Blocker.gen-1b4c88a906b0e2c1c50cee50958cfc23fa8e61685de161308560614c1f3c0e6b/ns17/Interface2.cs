using System.Collections;

namespace ns17;

internal interface Interface2 : IList, IEnumerable, ICollection
{
	object UnderlyingCollection { get; }
}
