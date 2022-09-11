using System.Collections;

namespace System;

internal interface ITupleInternal
{
	int Size { get; }

	int GetHashCode(IEqualityComparer comparer);

	string ToStringEnd();
}
