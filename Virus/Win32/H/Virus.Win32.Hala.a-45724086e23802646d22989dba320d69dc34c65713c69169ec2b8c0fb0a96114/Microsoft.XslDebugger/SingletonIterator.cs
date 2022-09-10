using System.Collections;
using System.Xml.XPath;

namespace Microsoft.XslDebugger;

internal class SingletonIterator : XPathNodeIterator
{
	protected XPathNavigator contextNode;

	protected int position;

	protected int last;

	protected bool visited;

	public int Position
	{
		get
		{
			return position;
		}
		set
		{
			position = value;
		}
	}

	public int Last
	{
		get
		{
			return last;
		}
		set
		{
			last = value;
		}
	}

	public override XPathNavigator Current => contextNode;

	public override int CurrentPosition => Position;

	public override int Count => Last;

	public SingletonIterator(XPathNavigator context)
	{
		contextNode = context;
		visited = false;
	}

	public SingletonIterator(XPathNavigator context, int pos, int last)
	{
		contextNode = context;
		position = pos;
		this.last = last;
	}

	public override XPathNodeIterator Clone()
	{
		return new SingletonIterator(contextNode, Position, Last);
	}

	public override bool MoveNext()
	{
		if (!visited)
		{
			visited = true;
			return true;
		}
		return false;
	}

	public void Reset()
	{
		visited = false;
	}

	public override IEnumerator GetEnumerator()
	{
		return null;
	}
}
