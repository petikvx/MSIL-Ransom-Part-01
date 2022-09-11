using Castle.DynamicProxy;

namespace White.Core.Interceptors;

public class FocusInterceptor : IWhiteInterceptor
{
	public virtual void PreProcess(IInvocation invocation, CoreInterceptContext context)
	{
		if (!invocation.get_Method().Name.StartsWith("get_") && !"ToString".Equals(invocation.get_Method().Name))
		{
			context.UiItem.Focus();
		}
	}

	public virtual void PostProcess(IInvocation invocation, CoreInterceptContext context)
	{
	}
}
