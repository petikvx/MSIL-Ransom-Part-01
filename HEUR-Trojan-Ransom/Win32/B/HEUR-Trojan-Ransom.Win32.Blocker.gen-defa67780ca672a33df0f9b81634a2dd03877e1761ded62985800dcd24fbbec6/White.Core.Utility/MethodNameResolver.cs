using System;
using System.Linq.Expressions;

namespace White.Core.Utility;

internal static class MethodNameResolver
{
	public static string NameFor<T>(Expression<Action<T>> invocation)
	{
		if (invocation.Body is MethodCallExpression methodCallExpression)
		{
			return methodCallExpression.Method.Name;
		}
		return null;
	}
}
