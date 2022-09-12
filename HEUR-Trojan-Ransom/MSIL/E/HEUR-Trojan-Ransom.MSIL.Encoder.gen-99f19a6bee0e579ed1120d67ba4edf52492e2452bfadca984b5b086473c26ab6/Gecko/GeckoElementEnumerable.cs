using System.Collections;
using System.Collections.Generic;

namespace Gecko;

internal class GeckoElementEnumerable : IEnumerable<GeckoHtmlElement>, IEnumerable
{
	private nsIDOMXPathResult xpathResult = null;

	internal GeckoElementEnumerable(nsIDOMXPathResult xpathResult)
	{
		this.xpathResult = xpathResult;
	}

	public IEnumerator<GeckoHtmlElement> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
