using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

public interface IGeckoArray<T> : IEnumerable<T>, IEnumerable
{
	T this[int index] { get; }

	int Length { get; }
}
