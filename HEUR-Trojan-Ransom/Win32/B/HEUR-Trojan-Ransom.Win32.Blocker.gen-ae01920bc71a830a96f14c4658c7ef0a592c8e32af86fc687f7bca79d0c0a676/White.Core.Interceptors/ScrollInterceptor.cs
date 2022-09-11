using Castle.DynamicProxy;
using White.Core.UIItems;

namespace White.Core.Interceptors;

public class ScrollInterceptor : IWhiteInterceptor
{
	public virtual void PreProcess(IInvocation invocation, CoreInterceptContext context)
	{
		if (!invocation.get_Method().Name.StartsWith("get_") && !"ToString".Equals(invocation.get_Method().Name))
		{
			context.ActionListener.ActionPerforming((UIItem)context.UiItem);
		}
	}

	public virtual void PostProcess(IInvocation invocation, CoreInterceptContext context)
	{
	}
}
