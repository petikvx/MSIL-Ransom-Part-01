using System;
using System.Collections.Generic;

namespace Gecko;

public class GeckoHtmlElementCollection : GeckoElementCollection
{
	private nsIDOMHTMLCollection Collection;

	public override int Length => (int)((Collection != null) ? Collection.GetLengthAttribute() : 0);

	public override GeckoHtmlElement this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return GeckoHtmlElement.Create((nsIDOMHTMLElement)Collection.Item((uint)index));
		}
	}

	internal GeckoHtmlElementCollection(nsIDOMHTMLCollection col)
		: base(null)
	{
		Collection = col;
	}

	public override IEnumerator<GeckoHtmlElement> GetEnumerator()
	{
		int length = Length;
		for (int i = 0; i < length; i++)
		{
			yield return GeckoHtmlElement.Create((nsIDOMHTMLElement)Collection.Item((uint)i));
		}
	}
}
