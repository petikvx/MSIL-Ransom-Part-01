using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns13;
using ns15;
using ns17;
using ns3;
using ns5;
using ns7;

namespace ns8;

internal class Class69 : Class67
{
	internal class Class77
	{
		public Expression expression_0;

		public ParameterExpression parameterExpression_0;

		public bool bool_0;

		public Class77(Expression expression_1, ParameterExpression parameterExpression_1, bool bool_1)
		{
			expression_0 = expression_1;
			parameterExpression_0 = parameterExpression_1;
			bool_0 = bool_1;
		}
	}

	[CompilerGenerated]
	private sealed class Class78<T> where T : notnull
	{
		public Type type_0;

		internal T method_0()
		{
			return (T)Activator.CreateInstance(type_0);
		}

		internal T method_1()
		{
			return (T)Activator.CreateInstance(type_0);
		}
	}

	internal static readonly Class69 class69_0 = new Class69();

	internal static Class67 Instance => class69_0;

	public override Delegate7<object> vmethod_1(MethodBase methodBase_0)
	{
		Class112.smethod_0(methodBase_0, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
		Expression body = Class131.smethod_380(methodBase_0, typeFromHandle, (ParameterExpression?)null, this, parameterExpression);
		return (Delegate7<object>)Expression.Lambda(typeof(Delegate7<object>), body, parameterExpression).Compile();
	}

	public override Delegate1<T, object?> vmethod_0<T>(MethodBase methodBase_0)
	{
		Class112.smethod_0(methodBase_0, "method");
		Type typeFromHandle = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "target");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), "args");
		Expression body = Class131.smethod_380(methodBase_0, typeFromHandle, parameterExpression, this, parameterExpression2);
		return (Delegate1<T, object>)Expression.Lambda(typeof(Delegate1<T, object>), body, parameterExpression, parameterExpression2).Compile();
	}

	public override Func<T> vmethod_2<T>(Type type_0)
	{
		Type type_ = type_0;
		Class112.smethod_0(type_, "type");
		if (type_.smethod_11())
		{
			return () => (T)Activator.CreateInstance(type_);
		}
		try
		{
			Type typeFromHandle = typeof(T);
			Expression expression_ = Expression.New(type_);
			expression_ = method_2(expression_, typeFromHandle);
			return (Func<T>)Expression.Lambda(typeof(Func<T>), expression_).Compile();
		}
		catch
		{
			return () => (T)Activator.CreateInstance(type_);
		}
	}

	public override Func<T, object?> vmethod_3<T>(PropertyInfo propertyInfo_0)
	{
		Class112.smethod_0(propertyInfo_0, "propertyInfo");
		Type typeFromHandle = typeof(T);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		MethodInfo? getMethod = propertyInfo_0.GetGetMethod(nonPublic: true);
		if (getMethod == null)
		{
			throw new ArgumentException("Property does not have a getter.");
		}
		Expression expression_ = ((!getMethod!.IsStatic) ? Expression.MakeMemberAccess(method_2(parameterExpression, propertyInfo_0.DeclaringType), propertyInfo_0) : Expression.MakeMemberAccess(null, propertyInfo_0));
		expression_ = method_2(expression_, typeFromHandle2);
		return (Func<T, object>)Expression.Lambda(typeof(Func<T, object>), expression_, parameterExpression).Compile();
	}

	public override Func<T, object?> vmethod_4<T>(FieldInfo fieldInfo_0)
	{
		Class112.smethod_0(fieldInfo_0, "fieldInfo");
		ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
		Expression expression_ = ((!fieldInfo_0.IsStatic) ? Expression.Field(method_2(parameterExpression, fieldInfo_0.DeclaringType), fieldInfo_0) : Expression.Field(null, fieldInfo_0));
		expression_ = method_2(expression_, typeof(object));
		return Expression.Lambda<Func<T, object>>(expression_, new ParameterExpression[1] { parameterExpression }).Compile();
	}

	public override Action<T, object?> vmethod_5<T>(FieldInfo fieldInfo_0)
	{
		Class112.smethod_0(fieldInfo_0, "fieldInfo");
		if (!fieldInfo_0.DeclaringType.smethod_13() && !fieldInfo_0.IsInitOnly)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "source");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
			Expression expression = ((!fieldInfo_0.IsStatic) ? Expression.Field(method_2(parameterExpression, fieldInfo_0.DeclaringType), fieldInfo_0) : Expression.Field(null, fieldInfo_0));
			Expression right = method_2(parameterExpression2, expression.Type);
			BinaryExpression body = Expression.Assign(expression, right);
			return (Action<T, object>)Expression.Lambda(typeof(Action<T, object>), body, parameterExpression, parameterExpression2).Compile();
		}
		return Class70.class70_0.vmethod_5<T>(fieldInfo_0);
	}

	public override Action<T, object?> vmethod_6<T>(PropertyInfo propertyInfo_0)
	{
		Class112.smethod_0(propertyInfo_0, "propertyInfo");
		if (propertyInfo_0.DeclaringType.smethod_13())
		{
			return Class70.class70_0.vmethod_6<T>(propertyInfo_0);
		}
		Type typeFromHandle = typeof(T);
		Type typeFromHandle2 = typeof(object);
		ParameterExpression parameterExpression = Expression.Parameter(typeFromHandle, "instance");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeFromHandle2, "value");
		Expression expression = method_2(parameterExpression2, propertyInfo_0.PropertyType);
		MethodInfo setMethod = propertyInfo_0.GetSetMethod(nonPublic: true);
		if (setMethod == null)
		{
			throw new ArgumentException("Property does not have a setter.");
		}
		return (Action<T, object>)Expression.Lambda(body: (!setMethod.IsStatic) ? Expression.Call(method_2(parameterExpression, propertyInfo_0.DeclaringType), setMethod, expression) : Expression.Call(setMethod, expression), delegateType: typeof(Action<T, object>), parameters: new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
	}

	internal Expression method_2(Expression expression_0, Type type_0, bool bool_0 = false)
	{
		Type type = expression_0.Type;
		if (!(type == type_0) && (type.smethod_13() || !type_0.IsAssignableFrom(type)))
		{
			if (type_0.smethod_13())
			{
				Expression expression = Expression.Unbox(expression_0, type_0);
				if (bool_0 && type_0.smethod_14())
				{
					MethodInfo method = typeof(Convert).GetMethod("To" + type_0.Name, new Type[1] { typeof(object) });
					if (method != null)
					{
						expression = Expression.Condition(Expression.TypeIs(expression_0, type_0), expression, Expression.Call(method, expression_0));
					}
				}
				return Expression.Condition(Expression.Equal(expression_0, Expression.Constant(null, typeof(object))), Expression.Default(type_0), expression);
			}
			return Expression.Convert(expression_0, type_0);
		}
		return expression_0;
	}
}
