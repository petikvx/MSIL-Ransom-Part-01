using System;
using System.Collections.Generic;

namespace Gecko;

public static class GeckoWrapperCache
{
	public static bool Enabled = false;
}
internal class GeckoWrapperCache<InterfaceType, WrapperType>
{
	public delegate WrapperType CreateWrapper(InterfaceType instance);

	private readonly Dictionary<InterfaceType, WeakReference> m_cache = new Dictionary<InterfaceType, WeakReference>();

	private readonly CreateWrapper m_creator;

	public GeckoWrapperCache(CreateWrapper creator)
	{
		m_creator = creator;
	}

	public WrapperType Get(InterfaceType instance)
	{
		if (instance == null)
		{
			return default(WrapperType);
		}
		if (!GeckoWrapperCache.Enabled)
		{
			return m_creator(instance);
		}
		if (m_cache.TryGetValue(instance, out var value))
		{
			object target = value.Target;
			if (target != null)
			{
				return (WrapperType)target;
			}
		}
		WrapperType val = m_creator(instance);
		m_cache[instance] = new WeakReference(val);
		return val;
	}
}
