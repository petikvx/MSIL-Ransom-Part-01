using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public interface ILookup<TKey, TElement> : IEnumerable, IEnumerable<IGrouping<TKey, TElement>>
{
	int Count { get; }

	IEnumerable<TElement> this[TKey key] { get; }

	bool Contains(TKey key);
}
