using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;
using ns22;
using ns8;

namespace ns13;

internal class Class50 : Class49<Class55>
{
	[NonSerialized]
	internal static GetString getString_1;

	public ReadOnlyCollection<Class47> Columns => list_3.AsReadOnly();

	public ReadOnlyCollection<Class55> Rows => list_2.AsReadOnly();

	public object this[int int_2] => method_7(int_2);

	internal Class50(Class79 class79_1)
		: base(class79_1)
	{
	}

	private object method_7(int int_2)
	{
		if (int_0 == list_2.Count)
		{
			throw new InvalidOperationException(getString_1(107407812));
		}
		return list_2[int_0][int_2];
	}

	public int method_8(string string_0)
	{
		if (!base.NameMap.ContainsKey(string_0))
		{
			throw new MySqlException(getString_1(107407783) + string_0 + getString_1(107407758));
		}
		return base.NameMap[string_0];
	}

	protected override Class55 vmethod_1(bool bool_3)
	{
		List<byte[]> list = base.Protocol.vmethod_0(this);
		if (list == null)
		{
			return null;
		}
		if (bool_3)
		{
			return new Class55(base.NameMap, null);
		}
		object[] array = new object[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = Columns[i].class87_0.delegate1_0(list[i]);
		}
		return new Class55(base.NameMap, array);
	}

	static Class50()
	{
		Strings.CreateGetStringDelegate(typeof(Class50));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397668), getString_1(107397663)).Replace(getString_1(107397626), getString_1(107397621)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_3: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397616)))
		{
			throw new SecurityException(getString_1(107397591));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_3, [MarshalAs(UnmanagedType.Bool)] out bool bool_4);
}
