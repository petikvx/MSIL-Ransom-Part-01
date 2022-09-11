using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MySql.Data.MySqlClient;

public sealed class BaseTableCache
{
	private struct Struct24
	{
		public DateTime dateTime_0;

		public object object_0;
	}

	[CompilerGenerated]
	private sealed class Class180
	{
		public DateTime dateTime_0;

		public BaseTableCache baseTableCache_0;

		internal _003C_003Ef__AnonymousType0<string, TimeSpan> method_0(string string_0)
		{
			return new
			{
				key = string_0,
				diff = dateTime_0.Subtract(baseTableCache_0.dictionary_0[string_0].dateTime_0)
			};
		}
	}

	protected int int_0;

	private Dictionary<string, Struct24> dictionary_0 = new Dictionary<string, Struct24>();

	public BaseTableCache(int maxCacheAge)
	{
		int_0 = maxCacheAge;
	}

	public virtual void vmethod_0(string string_0, object object_0)
	{
		vmethod_3();
		Struct24 value = default(Struct24);
		value.dateTime_0 = DateTime.Now;
		value.object_0 = object_0;
		lock (dictionary_0)
		{
			if (!dictionary_0.ContainsKey(string_0))
			{
				dictionary_0.Add(string_0, value);
			}
		}
	}

	public virtual object vmethod_1(string string_0, int int_1)
	{
		vmethod_3();
		lock (dictionary_0)
		{
			if (!dictionary_0.ContainsKey(string_0))
			{
				return null;
			}
			Struct24 @struct = dictionary_0[string_0];
			if (DateTime.Now.Subtract(@struct.dateTime_0).TotalSeconds > (double)int_1)
			{
				return null;
			}
			return @struct.object_0;
		}
	}

	public void method_0(string string_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				dictionary_0.Remove(string_0);
			}
		}
	}

	public virtual void vmethod_2()
	{
		lock (dictionary_0)
		{
			dictionary_0.Clear();
		}
	}

	protected virtual void vmethod_3()
	{
		DateTime dateTime_0 = DateTime.Now;
		List<string> list = new List<string>();
		lock (dictionary_0)
		{
			list.AddRange(from string_0 in dictionary_0.Keys
				select new
				{
					key = string_0,
					diff = dateTime_0.Subtract(dictionary_0[string_0].dateTime_0)
				} into _003C_003Ef__AnonymousType0_0
				where _003C_003Ef__AnonymousType0_0.diff.TotalSeconds > (double)int_0
				select _003C_003Ef__AnonymousType0_0.key);
			foreach (string item in list)
			{
				dictionary_0.Remove(item);
			}
		}
	}

	[CompilerGenerated]
	private bool method_1(_003C_003Ef__AnonymousType0<string, TimeSpan> _003C_003Ef__AnonymousType0_0)
	{
		return _003C_003Ef__AnonymousType0_0.diff.TotalSeconds > (double)int_0;
	}
}
