using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using ns13;
using ns15;

namespace ns19;

internal readonly struct Struct6<T> : IEnumerable<T>, Interface10<T>, IEquatable<Struct6<T>>, IEnumerable where T : JToken
{
	public static readonly Struct6<T> struct6_0 = new Struct6<T>(Enumerable.Empty<T>());

	private readonly IEnumerable<T> ienumerable_0;

	public Interface10<JToken> this[object object_0]
	{
		get
		{
			if (ienumerable_0 == null)
			{
				return Struct6<JToken>.struct6_0;
			}
			return new Struct6<JToken>(ienumerable_0.smethod_11<T, JToken>(object_0));
		}
	}

	public Struct6(IEnumerable<T> ienumerable_1)
	{
		Class112.smethod_0(ienumerable_1, "enumerable");
		ienumerable_0 = ienumerable_1;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return ((IEnumerable<T>)(ienumerable_0 ?? ((object)struct6_0))).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
	}

	bool IEquatable<Struct6<T>>.Equals(Struct6<T> other)
	{
		return object.Equals(ienumerable_0, other.ienumerable_0);
	}

	bool ValueType.Equals(object obj)
	{
		if (obj is Struct6<T> other)
		{
			return System_002EIEquatable_003Cns19_002EStruct6_003CT_003E_003E_002EEquals(other);
		}
		return false;
	}

	int ValueType.GetHashCode()
	{
		if (ienumerable_0 == null)
		{
			return 0;
		}
		return ienumerable_0.GetHashCode();
	}
}
