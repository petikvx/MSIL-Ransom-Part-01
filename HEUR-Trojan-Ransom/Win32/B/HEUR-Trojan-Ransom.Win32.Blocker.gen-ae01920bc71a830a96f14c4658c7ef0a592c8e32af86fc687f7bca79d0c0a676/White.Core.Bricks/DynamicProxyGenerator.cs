using System;
using Castle.DynamicProxy;

namespace White.Core.Bricks;

public class DynamicProxyGenerator
{
	private static readonly DynamicProxyGenerator ProxyGenerator = new DynamicProxyGenerator();

	private readonly ProxyGenerator generator = new ProxyGenerator();

	public static DynamicProxyGenerator Instance => ProxyGenerator;

	public virtual object CreateProxy(IInterceptor interceptor, Type type)
	{
		if (type.IsInterface)
		{
			return generator.CreateInterfaceProxyWithoutTarget(type, interceptor);
		}
		return generator.CreateClassProxy(type, (IInterceptor[])(object)new IInterceptor[1] { interceptor });
	}
}
