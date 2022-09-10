using System.Collections;
using System.Xml.XPath;

namespace Microsoft.XslDebugger;

internal class CachedIterator : XPathNodeIterator
{
	protected ArrayList array;

	protected int index;

	public override XPathNavigator Current
	{
		get
		{
			if (index <= 0)
			{
				return null;
			}
			return (XPathNavigator)array[index - 1];
		}
	}

	public override int CurrentPosition => index;

	public override int Count => array.Count;

	public CachedIterator(ArrayList array)
	{
		this.array = array;
		index = 0;
	}

	public CachedIterator(CachedIterator it)
	{
		array = it.array;
		index = it.index;
	}

	public override XPathNodeIterator Clone()
	{
		return new CachedIterator(this);
	}

	public override bool MoveNext()
	{
		if (index < array.Count)
		{
			index++;
			return true;
		}
		return false;
	}

	public void Reset()
	{
		index = 0;
	}

	public override IEnumerator GetEnumerator()
	{
		CachedIterator cachedIterator = (CachedIterator)Clone();
		cachedIterator.Reset();
		return (IEnumerator)cachedIterator;
	}
}
