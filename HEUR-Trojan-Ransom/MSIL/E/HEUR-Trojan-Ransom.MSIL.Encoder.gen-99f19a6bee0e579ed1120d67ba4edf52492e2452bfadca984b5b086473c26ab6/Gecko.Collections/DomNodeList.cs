using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko.Collections;

internal sealed class DomNodeList<TWrapper, TGeckoNode> : IEnumerable<TWrapper>, IGeckoArray<TWrapper>, IEnumerable where TWrapper : GeckoNode where TGeckoNode : class, nsIDOMNode
{
	private nsIDOMNodeList _list;

	private Func<TGeckoNode, TWrapper> _translator;

	public int Length => (int)_list.GetLengthAttribute();

	public TWrapper this[int index]
	{
		get
		{
			nsIDOMNode nsIDOMNode = _list.Item((uint)index);
			if (nsIDOMNode is TGeckoNode)
			{
				return ((TGeckoNode)nsIDOMNode).Wrap(_translator);
			}
			return null;
		}
	}

	internal DomNodeList(nsIDOMNodeList list, Func<TGeckoNode, TWrapper> translator)
	{
		_list = list;
		_translator = translator;
	}

	public IEnumerator<TWrapper> GetEnumerator()
	{
		return new GeckoNodeEnumerator<TWrapper, TGeckoNode>(_list, _translator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
