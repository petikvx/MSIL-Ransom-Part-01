using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class GeckoNodeEnumerator<TWrapper, TGeckoNode> : IEnumerator<TWrapper>, IDisposable, IEnumerator where TWrapper : class where TGeckoNode : class, nsIDOMNode
{
	private abstract class Wrapper
	{
		public abstract int Length { get; }

		public abstract nsIDOMNode Item(uint index);
	}

	private sealed class Wrapper1 : Wrapper
	{
		private nsIDOMNodeList _list;

		private int _length;

		public override int Length => _length;

		internal Wrapper1(nsIDOMNodeList list)
		{
			_list = list;
			_length = (int)list.GetLengthAttribute();
		}

		public override nsIDOMNode Item(uint index)
		{
			return _list.Item(index);
		}
	}

	private sealed class Wrapper2 : Wrapper
	{
		private nsIDOMHTMLCollection _collection;

		private int _length;

		public override int Length => _length;

		public Wrapper2(nsIDOMHTMLCollection collection)
		{
			_collection = collection;
			_length = (int)collection.GetLengthAttribute();
		}

		public override nsIDOMNode Item(uint index)
		{
			return _collection.Item(index);
		}
	}

	private Wrapper _wrapper;

	private uint _position;

	private TGeckoNode _current;

	private Func<TGeckoNode, TWrapper> _translator;

	public TWrapper Current => _translator(_current);

	object IEnumerator.Current => Current;

	internal GeckoNodeEnumerator(nsIDOMNodeList list, Func<TGeckoNode, TWrapper> translator)
		: this((Wrapper)new Wrapper1(list), translator)
	{
	}

	public GeckoNodeEnumerator(nsIDOMHTMLCollection collection, Func<TGeckoNode, TWrapper> translator)
		: this((Wrapper)new Wrapper2(collection), translator)
	{
	}

	private GeckoNodeEnumerator(Wrapper wrapper, Func<TGeckoNode, TWrapper> translator)
	{
		_wrapper = wrapper;
		_translator = translator;
		_position = 0u;
	}

	public void Dispose()
	{
		if (_wrapper is IDisposable disposable)
		{
			disposable.Dispose();
		}
		_wrapper = null;
		_translator = null;
		GC.SuppressFinalize(this);
	}

	public bool MoveNext()
	{
		nsIDOMNode nsIDOMNode;
		do
		{
			if (_position < _wrapper.Length)
			{
				nsIDOMNode = _wrapper.Item(_position);
				_position++;
				continue;
			}
			return false;
		}
		while (!(nsIDOMNode is TGeckoNode));
		_current = (TGeckoNode)nsIDOMNode;
		return true;
	}

	public void Reset()
	{
		_position = 0u;
		_current = null;
	}
}
