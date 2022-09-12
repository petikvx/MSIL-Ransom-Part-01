using System.Collections;

namespace ns10;

internal interface Interface2 : IList, ICollection, IEnumerable
{
	object UnderlyingCollection { get; }
}
