using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public interface IGrouping<out TKey, TElement> : IEnumerable<TElement>, IEnumerable
{
	TKey Key { get; }
}
