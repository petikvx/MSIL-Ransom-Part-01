using System.Collections;
using System.Collections.Generic;
using Gecko.Interop;
using Gecko.WebIDL;

namespace Gecko;

internal class GeckoNodeEnumerable : IEnumerable<GeckoNode>, IEnumerable
{
	private readonly XPathResult _xpathResult;

	internal GeckoNodeEnumerable(XPathResult xpathResult)
	{
		_xpathResult = xpathResult;
	}

	public IEnumerator<GeckoNode> GetEnumerator()
	{
		while (!_xpathResult.InvalidIteratorState)
		{
			GeckoNode result = _xpathResult.IterateNext().Wrap(GeckoNode.Create);
			if (result == null)
			{
				break;
			}
			yield return result;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerator<GeckoNode> i = GetEnumerator();
		while (i.MoveNext())
		{
			yield return i.Current;
		}
	}
}
