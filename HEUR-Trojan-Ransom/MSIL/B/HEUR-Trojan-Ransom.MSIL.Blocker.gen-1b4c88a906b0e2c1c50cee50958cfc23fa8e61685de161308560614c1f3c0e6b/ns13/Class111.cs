using System;
using System.Collections.Concurrent;
using ns14;

namespace ns13;

internal class Class111<T, U>
{
	private readonly ConcurrentDictionary<T, U> concurrentDictionary_0;

	private readonly Func<T, U> func_0;

	public Class111(Func<T, U> func_1)
	{
		Class113.smethod_0(func_1, "creator");
		func_0 = func_1;
		concurrentDictionary_0 = new ConcurrentDictionary<T, U>();
	}

	public U method_0(T gparam_0)
	{
		return concurrentDictionary_0.GetOrAdd(gparam_0, func_0);
	}
}
