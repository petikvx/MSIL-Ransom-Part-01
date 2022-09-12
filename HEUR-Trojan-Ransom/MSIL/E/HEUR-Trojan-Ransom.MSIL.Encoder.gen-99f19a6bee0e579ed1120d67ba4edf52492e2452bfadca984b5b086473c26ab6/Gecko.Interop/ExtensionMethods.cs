using System;

namespace Gecko.Interop;

public static class ExtensionMethods
{
	public static TWrapper Wrap<TGeckoObject, TWrapper>(this TGeckoObject obj, Func<TGeckoObject, TWrapper> wrapper) where TGeckoObject : class where TWrapper : class
	{
		return (obj == null) ? null : wrapper(obj);
	}

	public static TWrapper Wrap<TGeckoObject1, TGeckoObject2, TWrapper>(this TGeckoObject1 obj, Func<TGeckoObject1, TGeckoObject2> getter, Func<TGeckoObject2, TWrapper> wrapper) where TGeckoObject1 : class where TGeckoObject2 : class where TWrapper : class
	{
		if (obj == null)
		{
			return null;
		}
		TGeckoObject2 val = getter(obj);
		return (val == null) ? null : wrapper(val);
	}

	public static ComPtr<TCOMObject> AsComPtr<TCOMObject>(this TCOMObject obj) where TCOMObject : class
	{
		if (obj == null)
		{
			return null;
		}
		return new ComPtr<TCOMObject>(obj);
	}
}
