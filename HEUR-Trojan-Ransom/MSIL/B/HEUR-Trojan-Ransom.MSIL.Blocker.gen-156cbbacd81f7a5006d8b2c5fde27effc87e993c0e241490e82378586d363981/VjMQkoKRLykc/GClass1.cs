using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace VjMQkoKRLykc;

public abstract class GClass1
{
	public class RuleCache<T> where T : class
	{
	}

	private sealed class Class2<T> where T : class
	{
		internal static readonly Class2<T> class2_0 = new Class2<T>();

		internal readonly ReadOnlyCollection<ParameterExpression> readOnlyCollection_0;

		internal readonly LabelTarget labelTarget_0;

		private Class2()
		{
			typeof(T).GetMethod("Invoke");
			ParameterInfo[] array = null;
			ParameterExpression[] array2 = new ParameterExpression[array.Length - 1];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = Expression.Parameter(array[i + 1].ParameterType, "$arg" + i);
			}
		}
	}

	private static readonly LabelTarget labelTarget_0 = Expression.Label("");

	internal Dictionary<Type, object> dictionary_0;

	public static LabelTarget UpdateLabel => labelTarget_0;

	public abstract Expression vmethod_0(object[] object_0, ReadOnlyCollection<ParameterExpression> readOnlyCollection_0, LabelTarget labelTarget_1);

	public virtual T vmethod_1<T>(CallSite<T> callSite_0, object[] object_0) where T : class
	{
		return null;
	}

	internal T method_0<T>(CallSite<T> callSite_0, object[] object_0) where T : class
	{
		T val = vmethod_1(callSite_0, object_0);
		if (val != null)
		{
			return val;
		}
		Class2<T> @class = Class2<T>.class2_0;
		return smethod_1(vmethod_0(object_0, @class.readOnlyCollection_0, @class.labelTarget_0), @class).Compile();
	}

	internal static void smethod_0(byte[] byte_0, int int_0)
	{
		Class0.byte_0[int_0] = (byte)(Class0.byte_0[int_0] ^ byte_0[int_0 % byte_0.Length]);
	}

	private static Expression<T> smethod_1<T>(Expression expression_0, Class2<T> class2_0) where T : class
	{
		ReadOnlyCollectionBuilder<Expression> obj = new ReadOnlyCollectionBuilder<Expression>(3) { expression_0 };
		Expression.Parameter(typeof(CallSite), "");
		Expression item = Expression.Label(UpdateLabel);
		obj.Add(item);
		return null;
	}

	internal RuleCache<T> method_1<T>() where T : class
	{
		if (dictionary_0 == null)
		{
			Interlocked.CompareExchange(ref dictionary_0, new Dictionary<Type, object>(), null);
		}
		Dictionary<Type, object> dictionary = dictionary_0;
		object value;
		lock (dictionary)
		{
			if (!dictionary.TryGetValue(typeof(T), out value))
			{
				dictionary[typeof(T)] = (RuleCache<T>)(value = new RuleCache<T>());
			}
		}
		return value as RuleCache<T>;
	}
}
