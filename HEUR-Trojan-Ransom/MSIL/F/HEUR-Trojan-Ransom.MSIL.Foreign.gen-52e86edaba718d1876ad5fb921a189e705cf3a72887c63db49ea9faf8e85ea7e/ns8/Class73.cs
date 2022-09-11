using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySqlX.Protocol.X;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns12;

namespace ns8;

internal class Class73
{
	public long long_0 = -1L;

	public long long_1 = -1L;

	public string string_0;

	public Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	public Dictionary<string, int> dictionary_1;

	public bool bool_0;

	public string[] string_1;

	[NonSerialized]
	internal static GetString getString_0;

	public bool HasLimit => long_0 != -1L;

	public List<Order> method_0(bool bool_1)
	{
		return new ExprParser(Class103.smethod_24(string_1), bool_1).method_33();
	}

	public Expr method_1(bool bool_1)
	{
		ExprParser exprParser = new ExprParser(string_0, bool_1);
		Expr result = exprParser.method_31();
		if (exprParser.method_39() > 0)
		{
			dictionary_1 = exprParser.method_40();
		}
		return result;
	}

	public IEnumerable<Scalar> method_2(Dictionary<string, object> dictionary_2)
	{
		if (dictionary_1 != null && dictionary_1.Count != 0)
		{
			Scalar[] array = new Scalar[dictionary_1.Count];
			{
				foreach (KeyValuePair<string, object> item in dictionary_2)
				{
					if (dictionary_1.ContainsKey(item.Key.ToLowerInvariant()))
					{
						array[dictionary_1[item.Key.ToLowerInvariant()]] = Class103.smethod_22(item.Value);
						continue;
					}
					throw new ArgumentNullException(string.Format(Class122.UnknownPlaceholder, item.Key));
				}
				return array;
			}
		}
		throw new ArgumentException(Class122.NoPlaceholders);
	}

	public Class73 method_3()
	{
		return (Class73)MemberwiseClone();
	}

	static Class73()
	{
		Strings.CreateGetStringDelegate(typeof(Class73));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397752), getString_0(107397747)).Replace(getString_0(107397710), getString_0(107397705)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397700)))
		{
			throw new SecurityException(getString_0(107397675));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
