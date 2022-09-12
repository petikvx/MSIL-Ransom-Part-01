using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko;

public class GeckoNodeCollection : IGeckoArray<GeckoNode>, IEnumerable<GeckoNode>, IEnumerable
{
	private nsIDOMNodeList List;

	public virtual int Length => (int)List.GetLengthAttribute();

	public virtual GeckoNode this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return GeckoNode.Create(List.Item((uint)index));
		}
	}

	protected GeckoNodeCollection(nsIDOMNodeList list)
	{
		List = list;
	}

	public virtual IEnumerator<GeckoNode> GetEnumerator()
	{
		int length = Length;
		for (int i = 0; i < length; i++)
		{
			yield return GeckoNode.Create(List.Item((uint)i));
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		using IEnumerator<GeckoNode> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}

	internal static GeckoNodeCollection Create(nsIDOMNodeList list)
	{
		return (list == null) ? null : new GeckoNodeCollection(list);
	}
}
