using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using White.Core.Interceptors;

namespace White.Core.Bricks;

public class DynamicProxyInterceptors : List<IWhiteInterceptor>
{
	public virtual void Process(IInvocation invocation)
	{
		ForEach(delegate(IWhiteInterceptor obj)
		{
			obj.PreProcess(invocation, null);
		});
		invocation.Proceed();
		ForEach(delegate(IWhiteInterceptor obj)
		{
			obj.PostProcess(invocation, null);
		});
	}

	public virtual void Process(IInvocation invocation, CoreInterceptContext interceptedContext)
	{
		ForEach(delegate(IWhiteInterceptor obj)
		{
			obj.PreProcess(invocation, interceptedContext);
		});
		DelegateInvoker.IActionInvokerWrapper actionInvokerWrapper = DelegateInvoker.CreateInvoker(interceptedContext.Target, invocation.get_Method());
		invocation.set_ReturnValue(actionInvokerWrapper.Call(invocation.get_Arguments()));
		ForEach(delegate(IWhiteInterceptor obj)
		{
			obj.PostProcess(invocation, interceptedContext);
		});
	}

	public static string ToString(IInvocation invocation)
	{
		string text = $"Error when invoking {invocation.get_Method().Name}, on {invocation.get_TargetType().Name} with parameters: ";
		return text + string.Join(",", (from argument in invocation.get_Arguments()
			select (argument != null) ? argument.ToString() : "null").ToArray());
	}
}
