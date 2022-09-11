using System;
using System.Linq.Expressions;

namespace White.Core.Utility;

internal static class PropertyResolver
{
	public static string NameFor<T>(Expression<Func<T>> getter)
	{
		if (getter.Body is MemberExpression memberExpression)
		{
			return memberExpression.Member.Name;
		}
		if (!(getter.Body is UnaryExpression unaryExpression) || !(unaryExpression.Operand is MemberExpression memberExpression2))
		{
			throw new ArgumentException("'getter' should be a member expression");
		}
		return memberExpression2.Member.Name;
	}

	public static string NameFor<TObj, TProp>(Expression<Func<TObj, TProp>> getter)
	{
		if (getter.Body is MemberExpression memberExpression)
		{
			return memberExpression.Member.Name;
		}
		if (!(getter.Body is UnaryExpression unaryExpression) || !(unaryExpression.Operand is MemberExpression memberExpression2))
		{
			throw new ArgumentException("'getter' should be a member expression");
		}
		return memberExpression2.Member.Name;
	}
}
