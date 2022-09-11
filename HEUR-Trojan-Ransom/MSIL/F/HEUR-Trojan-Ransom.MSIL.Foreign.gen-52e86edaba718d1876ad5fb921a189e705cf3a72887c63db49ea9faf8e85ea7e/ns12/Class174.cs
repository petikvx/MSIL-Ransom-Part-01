using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns20;
using ns21;
using ns6;
using ns7;

namespace ns12;

internal sealed class Class174
{
	private readonly Dictionary<int, Class173> dictionary_0;

	private readonly Queue<int> queue_0;

	private readonly int int_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class174(int int_1)
	{
		int_0 = int_1;
		queue_0 = new Queue<int>(int_0);
		dictionary_0 = new Dictionary<int, Class173>(int_0);
	}

	public Class173 method_0(Class139 class139_0, string string_0, string string_1)
	{
		Class173 value = null;
		if (string_1 != null)
		{
			int hashCode = string_1.GetHashCode();
			lock (dictionary_0)
			{
				dictionary_0.TryGetValue(hashCode, out value);
			}
		}
		if (value == null)
		{
			value = method_2(class139_0, string_0);
			class139_0.PerfMonitor.vmethod_0();
			if (class139_0.Settings.Logging)
			{
				MySqlTrace.smethod_2(class139_0.ServerThread, string.Format(Class121.HardProcQuery, string_0));
			}
		}
		else
		{
			class139_0.PerfMonitor.vmethod_1();
			if (class139_0.Settings.Logging)
			{
				MySqlTrace.smethod_2(class139_0.ServerThread, string.Format(Class121.SoftProcQuery, string_0));
			}
		}
		return value;
	}

	internal string method_1(string string_0, Class173 class173_0)
	{
		string text = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(string_0);
		stringBuilder.Append(getString_0(107410767));
		string text2 = getString_0(107399212);
		if (class173_0.class176_1 != null)
		{
			foreach (Class177 row in class173_0.class176_1.Rows)
			{
				if (row[getString_0(107352973)].Equals(0))
				{
					text = getString_0(107375671);
					continue;
				}
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, getString_0(107375666), new object[1] { text2 });
				text2 = getString_0(107406190);
			}
		}
		stringBuilder.Append(getString_0(107410762));
		return text + stringBuilder.ToString();
	}

	private Class173 method_2(Class139 class139_0, string string_0)
	{
		Class173 @class = smethod_0(class139_0, string_0);
		if (int_0 <= 0)
		{
			return @class;
		}
		int hashCode = method_1(string_0, @class).GetHashCode();
		lock (dictionary_0)
		{
			if (dictionary_0.Keys.Count >= int_0)
			{
				method_3();
			}
			if (!dictionary_0.ContainsKey(hashCode))
			{
				dictionary_0[hashCode] = @class;
				queue_0.Enqueue(hashCode);
				return @class;
			}
			return @class;
		}
	}

	private void method_3()
	{
		int key = queue_0.Dequeue();
		dictionary_0.Remove(key);
	}

	private static Class173 smethod_0(Class139 class139_0, string string_0)
	{
		string text = string.Empty;
		string text2 = string_0;
		int num = string_0.IndexOf(getString_0(107398987));
		if (num != -1)
		{
			text = string_0.Substring(0, num);
			text2 = string_0.Substring(num + 1, string_0.Length - num - 1);
		}
		string[] array = new string[4]
		{
			null,
			(text.Length > 0) ? text : class139_0.method_8(),
			text2,
			null
		};
		Class176 @class = class139_0.method_14(getString_0(107381708), array);
		if (@class.Rows.Count > 1)
		{
			throw new MySqlException(Class121.ProcAndFuncSameName);
		}
		if (@class.Rows.Count == 0)
		{
			throw new MySqlException(string.Format(Class121.InvalidProcName, text2, text));
		}
		Class173 obj = new Class173
		{
			class176_0 = @class
		};
		Class160 class2 = new Class160(class139_0);
		string[] string_ = class2.method_6(array);
		Class176 class3 = (obj.class176_1 = class2.vmethod_14(string_, @class));
		return obj;
	}

	static Class174()
	{
		Strings.CreateGetStringDelegate(typeof(Class174));
	}
}
