using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

public abstract class EEBGObaZUydMEwnVyDAocDHUuBCIb
{
	public class HEuehmVMbCsTAIZNQqJaxwFoUZPo<T> where T : class
	{
	}

	private sealed class OREoNJvHBCcspnstcGbwGeXdjHivA<T> where T : class
	{
		internal static readonly OREoNJvHBCcspnstcGbwGeXdjHivA<T> ohKBQGsjtXQkRqZQFrieFHuuPFCM = new OREoNJvHBCcspnstcGbwGeXdjHivA<T>();

		internal readonly ReadOnlyCollection<ParameterExpression> ohKBQGsjtXQkRqZQFrieFHuuPFCM;

		internal readonly LabelTarget ohKBQGsjtXQkRqZQFrieFHuuPFCM;

		private OREoNJvHBCcspnstcGbwGeXdjHivA()
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

	private static readonly LabelTarget vjFMJPJzKpyFXGBQKdERJiFBVJDb = Expression.Label("");

	internal Dictionary<Type, object> LjBAtDhGIYOiVKiMAwtKOACqLEcIb;

	public static LabelTarget PybxvWLpXnnDXwzHTqwOkhkXiZOf => vjFMJPJzKpyFXGBQKdERJiFBVJDb;

	public abstract Expression MsQDpuJHRVUrsqVvmjlnStbcoWpQA(object[] object_0, ReadOnlyCollection<ParameterExpression> readOnlyCollection_0, LabelTarget labelTarget_0);

	public virtual T vmethod_0<T>(CallSite<T> callSite_0, object[] object_0) where T : class
	{
		return null;
	}

	internal T method_0<T>(CallSite<T> callSite_0, object[] object_0) where T : class
	{
		T val = vmethod_0(callSite_0, object_0);
		if (val != null)
		{
			return val;
		}
		OREoNJvHBCcspnstcGbwGeXdjHivA<T> oREoNJvHBCcspnstcGbwGeXdjHivA = OREoNJvHBCcspnstcGbwGeXdjHivA<T>.ohKBQGsjtXQkRqZQFrieFHuuPFCM;
		return smethod_1(MsQDpuJHRVUrsqVvmjlnStbcoWpQA(object_0, oREoNJvHBCcspnstcGbwGeXdjHivA.ohKBQGsjtXQkRqZQFrieFHuuPFCM, oREoNJvHBCcspnstcGbwGeXdjHivA.ohKBQGsjtXQkRqZQFrieFHuuPFCM), oREoNJvHBCcspnstcGbwGeXdjHivA).Compile();
	}

	internal static void smethod_0(byte[] byte_0, int int_0)
	{
		yrqdfhLCBLqZvvsxThBAPacdhtvhA.CSBgAzooWyCfWHphAGeuWZMxejnJA[int_0] = (byte)(yrqdfhLCBLqZvvsxThBAPacdhtvhA.CSBgAzooWyCfWHphAGeuWZMxejnJA[int_0] ^ byte_0[int_0 % byte_0.Length]);
	}

	private static Expression<T> smethod_1<T>(Expression expression_0, OREoNJvHBCcspnstcGbwGeXdjHivA<T> oreoNJvHBCcspnstcGbwGeXdjHivA_0) where T : class
	{
		ReadOnlyCollectionBuilder<Expression> obj = new ReadOnlyCollectionBuilder<Expression>(3) { expression_0 };
		Expression.Parameter(typeof(CallSite), "");
		Expression item = Expression.Label(PybxvWLpXnnDXwzHTqwOkhkXiZOf);
		obj.Add(item);
		return null;
	}

	internal HEuehmVMbCsTAIZNQqJaxwFoUZPo<T> method_1<T>() where T : class
	{
		if (LjBAtDhGIYOiVKiMAwtKOACqLEcIb == null)
		{
			Interlocked.CompareExchange(ref LjBAtDhGIYOiVKiMAwtKOACqLEcIb, new Dictionary<Type, object>(), null);
		}
		Dictionary<Type, object> ljBAtDhGIYOiVKiMAwtKOACqLEcIb = LjBAtDhGIYOiVKiMAwtKOACqLEcIb;
		object value;
		lock (ljBAtDhGIYOiVKiMAwtKOACqLEcIb)
		{
			if (!ljBAtDhGIYOiVKiMAwtKOACqLEcIb.TryGetValue(typeof(T), out value))
			{
				ljBAtDhGIYOiVKiMAwtKOACqLEcIb[typeof(T)] = (HEuehmVMbCsTAIZNQqJaxwFoUZPo<T>)(value = new HEuehmVMbCsTAIZNQqJaxwFoUZPo<T>());
			}
		}
		return value as HEuehmVMbCsTAIZNQqJaxwFoUZPo<T>;
	}
}
