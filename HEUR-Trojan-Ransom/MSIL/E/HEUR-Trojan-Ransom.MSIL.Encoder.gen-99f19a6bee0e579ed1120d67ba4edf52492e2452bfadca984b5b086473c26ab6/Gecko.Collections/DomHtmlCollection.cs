using System;
using System.Collections;
using System.Collections.Generic;
using Gecko.Interop;

namespace Gecko.Collections;

internal sealed class DomHtmlCollection<TWrapper, TGeckoNode> : IEnumerable<TWrapper>, IGeckoArray<TWrapper>, IDomHtmlCollection<TWrapper>, IEnumerable where TWrapper : GeckoNode where TGeckoNode : class, nsIDOMNode
{
	private nsIDOMHTMLCollection _collection;

	private Func<TGeckoNode, TWrapper> _translator;

	public int Length => (int)_collection.GetLengthAttribute();

	public TWrapper this[int index]
	{
		get
		{
			nsIDOMNode nsIDOMNode = _collection.Item((uint)index);
			if (nsIDOMNode is TGeckoNode)
			{
				return ((TGeckoNode)nsIDOMNode).Wrap(_translator);
			}
			return null;
		}
	}

	public TWrapper this[string name]
	{
		get
		{
			nsIDOMNode nsIDOMNode = nsString.Pass(_collection.NamedItem, name);
			if (nsIDOMNode is TGeckoNode)
			{
				return ((TGeckoNode)nsIDOMNode).Wrap(_translator);
			}
			return null;
		}
	}

	public DomHtmlCollection(nsIDOMHTMLCollection collection, Func<TGeckoNode, TWrapper> translator)
	{
		_collection = collection;
		_translator = translator;
	}

	public IEnumerator<TWrapper> GetEnumerator()
	{
		return new GeckoNodeEnumerator<TWrapper, TGeckoNode>(_collection, _translator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
