using System;
using System.Linq.Expressions;
using System.Reflection;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal static class ReflectionUtil
{
	internal static readonly Type[] EmptyTypes;

	[NonSerialized]
	internal static GetString getString_0;

	internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), getString_0(107471835));
		return Expression.Lambda<Func<IMessage, object>>(Expression.Convert(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
	}

	internal static Func<IMessage, T> CreateFuncIMessageT<T>(MethodInfo method)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), getString_0(107471835));
		return Expression.Lambda<Func<IMessage, T>>(Expression.Convert(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), typeof(T)), new ParameterExpression[1] { parameterExpression }).Compile();
	}

	internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), getString_0(107471830));
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), getString_0(107471789));
		UnaryExpression instance = Expression.Convert(parameterExpression, method.DeclaringType);
		Expression expression = Expression.Convert(parameterExpression2, method.GetParameters()[0].ParameterType);
		return Expression.Lambda<Action<IMessage, object>>(Expression.Call(instance, method, expression), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
	}

	internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IMessage), getString_0(107471830));
		return Expression.Lambda<Action<IMessage>>(Expression.Call(Expression.Convert(parameterExpression, method.DeclaringType), method), new ParameterExpression[1] { parameterExpression }).Compile();
	}

	static ReflectionUtil()
	{
		Strings.CreateGetStringDelegate(typeof(ReflectionUtil));
		EmptyTypes = new Type[0];
	}
}
