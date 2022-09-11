using System;
using System.Collections.Generic;
using ns12;
using ns15;
using ns19;
using ns20;
using ns21;
using ns7;
using ns8;

namespace ns5;

internal abstract class Class59<T, U, V> : Class58<U, V> where T : Class59<T, U, V> where U : Class38 where V : Class48
{
	private Class73 class73_0 = new Class73();

	internal Class73 FilterData => class73_0;

	public Class59(U gparam_1, string string_0 = null)
		: base(gparam_1)
	{
		if (string_0 != null)
		{
			method_2(string_0);
		}
	}

	public T method_2(string string_0)
	{
		class73_0.string_0 = string_0;
		return (T)this;
	}

	public T method_3(long long_0)
	{
		if (long_0 <= 0L)
		{
			throw new ArgumentOutOfRangeException(Class195.smethod_0(107406844), string.Format(Class122.NumberNotGreaterThanZero, Class195.smethod_0(107406844)));
		}
		class73_0.long_0 = long_0;
		class73_0.long_1 = -1L;
		return (T)this;
	}

	public T method_4(params string[] string_0)
	{
		class73_0.string_1 = string_0;
		return (T)this;
	}

	public T method_5(string string_0, object object_0)
	{
		FilterData.dictionary_0.Add(string_0, object_0);
		return (T)this;
	}

	public T method_6(Class43 class43_0)
	{
		return method_7(class43_0.ToString());
	}

	public T method_7(string string_0)
	{
		foreach (KeyValuePair<string, object> item in Class82.smethod_0(string_0))
		{
			method_5(item.Key, item.Value);
		}
		return (T)this;
	}

	public T method_8(object object_0)
	{
		return method_6(new Class43(object_0));
	}

	protected virtual V vmethod_1(Func<T, V> func_0, T gparam_1)
	{
		try
		{
			return func_0(gparam_1);
		}
		finally
		{
			FilterData.dictionary_0.Clear();
		}
	}

	public virtual T vmethod_2()
	{
		T val = (T)MemberwiseClone();
		val.class73_0 = val.FilterData.method_3();
		return val;
	}
}
