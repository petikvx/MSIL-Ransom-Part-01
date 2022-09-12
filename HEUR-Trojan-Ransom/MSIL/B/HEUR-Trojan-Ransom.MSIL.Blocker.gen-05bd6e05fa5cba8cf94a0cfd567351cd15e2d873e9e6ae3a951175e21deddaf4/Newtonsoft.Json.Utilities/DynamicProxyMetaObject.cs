using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using ns10;
using ns15;
using ns17;
using ns18;

namespace Newtonsoft.Json.Utilities;

internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
{
	private delegate DynamicMetaObject Delegate0(DynamicMetaObject? errorSuggestion);

	private sealed class Class54 : GetMemberBinder
	{
		internal Class54(InvokeMemberBinder invokeMemberBinder_0)
			: base(invokeMemberBinder_0.Name, invokeMemberBinder_0.IgnoreCase)
		{
		}

		DynamicMetaObject GetMemberBinder.FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class Class55
	{
		public GetMemberBinder getMemberBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_0)
		{
			return getMemberBinder_0.FallbackGetMember(dynamicProxyMetaObject_0, dynamicMetaObject_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class56
	{
		public SetMemberBinder setMemberBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return setMemberBinder_0.FallbackSetMember(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class57
	{
		public DeleteMemberBinder deleteMemberBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_0)
		{
			return deleteMemberBinder_0.FallbackDeleteMember(dynamicProxyMetaObject_0, dynamicMetaObject_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class58
	{
		public ConvertBinder convertBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_0)
		{
			return convertBinder_0.FallbackConvert(dynamicProxyMetaObject_0, dynamicMetaObject_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class59
	{
		public InvokeMemberBinder invokeMemberBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return invokeMemberBinder_0.FallbackInvokeMember(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}

		internal DynamicMetaObject method_1(DynamicMetaObject? dynamicMetaObject_1)
		{
			return invokeMemberBinder_0.FallbackInvoke(dynamicMetaObject_1, dynamicMetaObject_0, null);
		}
	}

	[CompilerGenerated]
	private sealed class Class60
	{
		public CreateInstanceBinder createInstanceBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return createInstanceBinder_0.FallbackCreateInstance(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class61
	{
		public InvokeBinder invokeBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return invokeBinder_0.FallbackInvoke(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class62
	{
		public BinaryOperationBinder binaryOperationBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return binaryOperationBinder_0.FallbackBinaryOperation(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class63
	{
		public UnaryOperationBinder unaryOperationBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_0)
		{
			return unaryOperationBinder_0.FallbackUnaryOperation(dynamicProxyMetaObject_0, dynamicMetaObject_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class64
	{
		public GetIndexBinder getIndexBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return getIndexBinder_0.FallbackGetIndex(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	[CompilerGenerated]
	private sealed class Class65
	{
		public SetIndexBinder setIndexBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		public DynamicMetaObject dynamicMetaObject_1;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_2)
		{
			return setIndexBinder_0.FallbackSetIndex(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1, dynamicMetaObject_2);
		}
	}

	[CompilerGenerated]
	private sealed class Class66
	{
		public DeleteIndexBinder deleteIndexBinder_0;

		public DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;

		public DynamicMetaObject[] dynamicMetaObject_0;

		internal DynamicMetaObject method_0(DynamicMetaObject? dynamicMetaObject_1)
		{
			return deleteIndexBinder_0.FallbackDeleteIndex(dynamicProxyMetaObject_0, dynamicMetaObject_0, dynamicMetaObject_1);
		}
	}

	private readonly Class52<T> class52_0;

	private static Expression[] NoArgs => Class45.smethod_10<Expression>();

	internal DynamicProxyMetaObject(Expression expression, T value, Class52<T> proxy)
		: base(expression, BindingRestrictions.Empty, value)
	{
		class52_0 = proxy;
	}

	private bool method_0(string string_0)
	{
		Type type = class52_0.GetType();
		Type typeFromHandle = typeof(Class52<T>);
		return Class4.smethod_727(string_0, type, typeFromHandle);
	}

	DynamicMetaObject DynamicMetaObject.BindGetMember(GetMemberBinder binder)
	{
		GetMemberBinder getMemberBinder_0 = binder;
		if (!method_0("TryGetMember"))
		{
			return base.BindGetMember(getMemberBinder_0);
		}
		return method_1("TryGetMember", getMemberBinder_0, NoArgs, (DynamicMetaObject? dynamicMetaObject_0) => getMemberBinder_0.FallbackGetMember(this, dynamicMetaObject_0));
	}

	DynamicMetaObject DynamicMetaObject.BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
	{
		SetMemberBinder setMemberBinder_0 = binder;
		DynamicMetaObject dynamicMetaObject_2 = value;
		if (!method_0("TrySetMember"))
		{
			return base.BindSetMember(setMemberBinder_0, dynamicMetaObject_2);
		}
		return method_3("TrySetMember", setMemberBinder_0, smethod_0(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => setMemberBinder_0.FallbackSetMember(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	DynamicMetaObject DynamicMetaObject.BindDeleteMember(DeleteMemberBinder binder)
	{
		DeleteMemberBinder deleteMemberBinder_0 = binder;
		if (!method_0("TryDeleteMember"))
		{
			return base.BindDeleteMember(deleteMemberBinder_0);
		}
		return method_4("TryDeleteMember", deleteMemberBinder_0, NoArgs, (DynamicMetaObject? dynamicMetaObject_0) => deleteMemberBinder_0.FallbackDeleteMember(this, dynamicMetaObject_0));
	}

	DynamicMetaObject DynamicMetaObject.BindConvert(ConvertBinder binder)
	{
		ConvertBinder convertBinder_0 = binder;
		if (!method_0("TryConvert"))
		{
			return base.BindConvert(convertBinder_0);
		}
		return method_1("TryConvert", convertBinder_0, NoArgs, (DynamicMetaObject? dynamicMetaObject_0) => convertBinder_0.FallbackConvert(this, dynamicMetaObject_0));
	}

	DynamicMetaObject DynamicMetaObject.BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
	{
		InvokeMemberBinder invokeMemberBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_2 = args;
		if (!method_0("TryInvokeMember"))
		{
			return base.BindInvokeMember(invokeMemberBinder_0, dynamicMetaObject_2);
		}
		Delegate0 @delegate = (DynamicMetaObject? dynamicMetaObject_1) => invokeMemberBinder_0.FallbackInvokeMember(this, dynamicMetaObject_2, dynamicMetaObject_1);
		return method_2("TryInvokeMember", invokeMemberBinder_0, smethod_1(dynamicMetaObject_2), method_2("TryGetMember", new Class54(invokeMemberBinder_0), NoArgs, @delegate(null), (DynamicMetaObject? dynamicMetaObject_1) => invokeMemberBinder_0.FallbackInvoke(dynamicMetaObject_1, dynamicMetaObject_2, null)), null);
	}

	DynamicMetaObject DynamicMetaObject.BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
	{
		CreateInstanceBinder createInstanceBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_2 = args;
		if (!method_0("TryCreateInstance"))
		{
			return base.BindCreateInstance(createInstanceBinder_0, dynamicMetaObject_2);
		}
		return method_1("TryCreateInstance", createInstanceBinder_0, smethod_1(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => createInstanceBinder_0.FallbackCreateInstance(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	DynamicMetaObject DynamicMetaObject.BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
	{
		InvokeBinder invokeBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_2 = args;
		if (!method_0("TryInvoke"))
		{
			return base.BindInvoke(invokeBinder_0, dynamicMetaObject_2);
		}
		return method_1("TryInvoke", invokeBinder_0, smethod_1(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => invokeBinder_0.FallbackInvoke(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	DynamicMetaObject DynamicMetaObject.BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
	{
		BinaryOperationBinder binaryOperationBinder_0 = binder;
		DynamicMetaObject dynamicMetaObject_2 = arg;
		if (!method_0("TryBinaryOperation"))
		{
			return base.BindBinaryOperation(binaryOperationBinder_0, dynamicMetaObject_2);
		}
		return method_1("TryBinaryOperation", binaryOperationBinder_0, smethod_0(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => binaryOperationBinder_0.FallbackBinaryOperation(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	DynamicMetaObject DynamicMetaObject.BindUnaryOperation(UnaryOperationBinder binder)
	{
		UnaryOperationBinder unaryOperationBinder_0 = binder;
		if (!method_0("TryUnaryOperation"))
		{
			return base.BindUnaryOperation(unaryOperationBinder_0);
		}
		return method_1("TryUnaryOperation", unaryOperationBinder_0, NoArgs, (DynamicMetaObject? dynamicMetaObject_0) => unaryOperationBinder_0.FallbackUnaryOperation(this, dynamicMetaObject_0));
	}

	DynamicMetaObject DynamicMetaObject.BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
	{
		GetIndexBinder getIndexBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_2 = indexes;
		if (!method_0("TryGetIndex"))
		{
			return base.BindGetIndex(getIndexBinder_0, dynamicMetaObject_2);
		}
		return method_1("TryGetIndex", getIndexBinder_0, smethod_1(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => getIndexBinder_0.FallbackGetIndex(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	DynamicMetaObject DynamicMetaObject.BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
	{
		SetIndexBinder setIndexBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_3 = indexes;
		DynamicMetaObject dynamicMetaObject_4 = value;
		if (!method_0("TrySetIndex"))
		{
			return base.BindSetIndex(setIndexBinder_0, dynamicMetaObject_3, dynamicMetaObject_4);
		}
		return method_3("TrySetIndex", setIndexBinder_0, smethod_2(dynamicMetaObject_3, dynamicMetaObject_4), (DynamicMetaObject? dynamicMetaObject_2) => setIndexBinder_0.FallbackSetIndex(this, dynamicMetaObject_3, dynamicMetaObject_4, dynamicMetaObject_2));
	}

	DynamicMetaObject DynamicMetaObject.BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
	{
		DeleteIndexBinder deleteIndexBinder_0 = binder;
		DynamicMetaObject[] dynamicMetaObject_2 = indexes;
		if (!method_0("TryDeleteIndex"))
		{
			return base.BindDeleteIndex(deleteIndexBinder_0, dynamicMetaObject_2);
		}
		return method_4("TryDeleteIndex", deleteIndexBinder_0, smethod_1(dynamicMetaObject_2), (DynamicMetaObject? dynamicMetaObject_1) => deleteIndexBinder_0.FallbackDeleteIndex(this, dynamicMetaObject_2, dynamicMetaObject_1));
	}

	private static IEnumerable<Expression> smethod_0(params DynamicMetaObject[] dynamicMetaObject_0)
	{
		return dynamicMetaObject_0.Select(delegate(DynamicMetaObject dynamicMetaObject_0)
		{
			Expression expression = dynamicMetaObject_0.Expression;
			return (!expression.Type.smethod_13()) ? expression : System.Linq.Expressions.Expression.Convert(expression, typeof(object));
		});
	}

	private static Expression[] smethod_1(DynamicMetaObject[] dynamicMetaObject_0)
	{
		return new NewArrayExpression[1] { System.Linq.Expressions.Expression.NewArrayInit(typeof(object), smethod_0(dynamicMetaObject_0)) };
	}

	private static Expression[] smethod_2(DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1)
	{
		Expression expression = dynamicMetaObject_1.Expression;
		return new Expression[2]
		{
			System.Linq.Expressions.Expression.NewArrayInit(typeof(object), smethod_0(dynamicMetaObject_0)),
			expression.Type.smethod_13() ? System.Linq.Expressions.Expression.Convert(expression, typeof(object)) : expression
		};
	}

	private static ConstantExpression smethod_3(DynamicMetaObjectBinder dynamicMetaObjectBinder_0)
	{
		Type type = dynamicMetaObjectBinder_0.GetType();
		while (!type.smethod_12())
		{
			type = type.smethod_6();
		}
		return System.Linq.Expressions.Expression.Constant(dynamicMetaObjectBinder_0, type);
	}

	private DynamicMetaObject method_1(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, Delegate0 delegate0_0, Delegate0? delegate0_1 = null)
	{
		DynamicMetaObject dynamicMetaObject_ = delegate0_0(null);
		return method_2(string_0, dynamicMetaObjectBinder_0, ienumerable_0, dynamicMetaObject_, delegate0_1);
	}

	private DynamicMetaObject method_2(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, DynamicMetaObject dynamicMetaObject_0, Delegate0? delegate0_0)
	{
		ParameterExpression parameterExpression = System.Linq.Expressions.Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
		list.Add(smethod_3(dynamicMetaObjectBinder_0));
		list.smethod_1(ienumerable_0);
		list.Add(parameterExpression);
		DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
		if (dynamicMetaObjectBinder_0.ReturnType != typeof(object))
		{
			dynamicMetaObject = new DynamicMetaObject(System.Linq.Expressions.Expression.Convert(dynamicMetaObject.Expression, dynamicMetaObjectBinder_0.ReturnType), dynamicMetaObject.Restrictions);
		}
		if (delegate0_0 != null)
		{
			dynamicMetaObject = delegate0_0!(dynamicMetaObject);
		}
		return new DynamicMetaObject(System.Linq.Expressions.Expression.Block(new ParameterExpression[1] { parameterExpression }, System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression.Constant(class52_0), typeof(Class52<T>).GetMethod(string_0), list), dynamicMetaObject.Expression, dynamicMetaObject_0.Expression, dynamicMetaObjectBinder_0.ReturnType)), method_5().Merge(dynamicMetaObject.Restrictions).Merge(dynamicMetaObject_0.Restrictions));
	}

	private DynamicMetaObject method_3(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, Delegate0 delegate0_0)
	{
		DynamicMetaObject dynamicMetaObject = delegate0_0(null);
		ParameterExpression parameterExpression = System.Linq.Expressions.Expression.Parameter(typeof(object), null);
		IList<Expression> list = new List<Expression>();
		list.Add(System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
		list.Add(smethod_3(dynamicMetaObjectBinder_0));
		list.smethod_1(ienumerable_0);
		list[list.Count - 1] = System.Linq.Expressions.Expression.Assign(parameterExpression, list[list.Count - 1]);
		return new DynamicMetaObject(System.Linq.Expressions.Expression.Block(new ParameterExpression[1] { parameterExpression }, System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression.Constant(class52_0), typeof(Class52<T>).GetMethod(string_0), list), parameterExpression, dynamicMetaObject.Expression, typeof(object))), method_5().Merge(dynamicMetaObject.Restrictions));
	}

	private DynamicMetaObject method_4(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_0, Delegate0 delegate0_0)
	{
		DynamicMetaObject dynamicMetaObject = delegate0_0(null);
		IList<Expression> list = new List<Expression>();
		list.Add(System.Linq.Expressions.Expression.Convert(base.Expression, typeof(T)));
		list.Add(smethod_3(dynamicMetaObjectBinder_0));
		list.smethod_1(expression_0);
		return new DynamicMetaObject(System.Linq.Expressions.Expression.Condition(System.Linq.Expressions.Expression.Call(System.Linq.Expressions.Expression.Constant(class52_0), typeof(Class52<T>).GetMethod(string_0), list), System.Linq.Expressions.Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), method_5().Merge(dynamicMetaObject.Restrictions));
	}

	private BindingRestrictions method_5()
	{
		if (base.Value == null && base.HasValue)
		{
			return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
		}
		return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
	}

	IEnumerable<string> DynamicMetaObject.GetDynamicMemberNames()
	{
		return class52_0.vmethod_0((T)base.Value);
	}
}
