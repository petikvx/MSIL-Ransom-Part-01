using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Collections;
using Gecko.Interop;

namespace Gecko.DOM;

public class GeckoNamedNodeMap : IGeckoArray<GeckoNode>, IEnumerable<GeckoNode>, IEnumerable
{
	private ComPtr<nsIDOMMozNamedAttrMap> _map;

	public int Length => (int)_map.Instance.GetLengthAttribute();

	public GeckoNode this[int index]
	{
		get
		{
			if (index < 0 || index >= Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _map.Instance.Item((uint)index).Wrap(GeckoNode.Create);
		}
	}

	public GeckoNode this[string name] => nsString.Pass(_map.Instance.GetNamedItem, name).Wrap(GeckoNode.Create);

	public GeckoNode this[string namespaceUri, string localName] => nsString.Pass(_map.Instance.GetNamedItemNS, namespaceUri, localName).Wrap(GeckoNode.Create);

	public GeckoNamedNodeMap(nsIDOMMozNamedAttrMap map)
	{
		_map = new ComPtr<nsIDOMMozNamedAttrMap>(map);
	}

	public GeckoNode RemoveNamedItem(string name)
	{
		return nsString.Pass(_map.Instance.RemoveNamedItem, name).Wrap(GeckoNode.Create);
	}

	public IEnumerator<GeckoNode> GetEnumerator()
	{
		int length = Length;
		for (int i = 0; i < length; i++)
		{
			yield return GeckoNode.Create(_map.Instance.Item((uint)i));
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
