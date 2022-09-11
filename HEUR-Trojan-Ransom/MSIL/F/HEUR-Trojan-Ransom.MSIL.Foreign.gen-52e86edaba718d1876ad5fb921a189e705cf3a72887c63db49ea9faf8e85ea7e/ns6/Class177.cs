using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns20;

namespace ns6;

internal sealed class Class177
{
	private Dictionary<int, object> dictionary_0;

	[CompilerGenerated]
	private readonly Class176 class176_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal Class176 Collection
	{
		[CompilerGenerated]
		get
		{
			return class176_0;
		}
	}

	internal object this[string string_0]
	{
		get
		{
			return method_2(string_0);
		}
		set
		{
			method_1(string_0, value);
		}
	}

	internal object this[int int_0]
	{
		get
		{
			int key = Collection.dictionary_1[int_0];
			if (!dictionary_0.ContainsKey(key))
			{
				dictionary_0[key] = null;
			}
			return dictionary_0[key];
		}
		set
		{
			dictionary_0[Collection.dictionary_1[int_0]] = value;
		}
	}

	public Class177(Class176 class176_1)
	{
		class176_0 = class176_1;
		method_0();
	}

	internal void method_0()
	{
		dictionary_0 = new Dictionary<int, object>();
	}

	private void method_1(string string_0, object object_0)
	{
		int int_ = Collection.dictionary_0[string_0];
		this[int_] = object_0;
	}

	private object method_2(string string_0)
	{
		int num = Collection.dictionary_0[string_0];
		if (!dictionary_0.ContainsKey(num))
		{
			dictionary_0[num] = null;
		}
		return this[num];
	}

	internal void method_3(Class177 class177_0)
	{
		if (Collection.Columns.Count != class177_0.Collection.Columns.Count)
		{
			throw new InvalidOperationException(getString_0(107376108));
		}
		for (int i = 0; i < Collection.Columns.Count; i++)
		{
			class177_0[i] = this[i];
		}
	}

	static Class177()
	{
		Strings.CreateGetStringDelegate(typeof(Class177));
	}
}
