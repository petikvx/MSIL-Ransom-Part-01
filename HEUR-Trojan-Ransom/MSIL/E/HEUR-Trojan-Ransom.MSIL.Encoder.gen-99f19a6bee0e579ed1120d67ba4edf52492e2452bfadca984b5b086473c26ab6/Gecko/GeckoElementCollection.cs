using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Collections;

namespace Gecko;

public class GeckoElementCollection : IGeckoArray<GeckoHtmlElement>, IEnumerable<GeckoHtmlElement>, IEnumerable
{
	private nsIDOMNodeList List;

	public virtual int Length => (int)((List != null) ? List.GetLengthAttribute() : 0);

	public virtual GeckoHtmlElement this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return GeckoHtmlElement.Create((nsIDOMHTMLElement)List.Item((uint)index));
		}
	}

	internal GeckoElementCollection(nsIDOMNodeList list)
	{
		List = list;
	}

	public virtual IEnumerator<GeckoHtmlElement> GetEnumerator()
	{
		int length = Length;
		for (int i = 0; i < length; i++)
		{
			yield return GeckoHtmlElement.Create((nsIDOMHTMLElement)List.Item((uint)i));
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		using IEnumerator<GeckoHtmlElement> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}
}
