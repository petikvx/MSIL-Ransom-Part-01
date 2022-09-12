using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gecko.Interop;

namespace Gecko;

public class GeckoWindowCollection : IEnumerable<GeckoWindow>, IEnumerable
{
	private ComPtr<nsIDOMWindowCollection> _collection;

	public virtual uint Count => _collection.Instance.GetLengthAttribute();

	[IndexerName("Items")]
	public virtual GeckoWindow this[uint index]
	{
		get
		{
			if (index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return _collection.Instance.Item(index).Wrap((nsIDOMWindow x) => new GeckoWindow(x));
		}
	}

	public GeckoWindowCollection(nsIDOMWindowCollection collection)
	{
		_collection = new ComPtr<nsIDOMWindowCollection>(collection);
	}

	public virtual IEnumerator<GeckoWindow> GetEnumerator()
	{
		uint length = Count;
		for (uint i = 0u; i < length; i++)
		{
			yield return _collection.Instance.Item(i).Wrap((nsIDOMWindow x) => new GeckoWindow(x));
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		using IEnumerator<GeckoWindow> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}

	public void Dispose()
	{
		Xpcom.DisposeObject(ref _collection);
		GC.SuppressFinalize(this);
	}

	~GeckoWindowCollection()
	{
		Xpcom.DisposeObject(ref _collection);
	}
}
