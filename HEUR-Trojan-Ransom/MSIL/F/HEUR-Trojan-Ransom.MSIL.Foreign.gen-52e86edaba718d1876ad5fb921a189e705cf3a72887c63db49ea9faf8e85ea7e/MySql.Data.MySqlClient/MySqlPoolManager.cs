using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;
using ns21;

namespace MySql.Data.MySqlClient;

internal sealed class MySqlPoolManager
{
	private static readonly Dictionary<string, MySqlPool> dictionary_0;

	private static readonly List<MySqlPool> list_0;

	internal static int int_0;

	private static Timer timer_0;

	[NonSerialized]
	internal static GetString getString_0;

	static MySqlPoolManager()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlPoolManager));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399303), getString_0(107399298)).Replace(getString_0(107399261), getString_0(107399256)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399251)))
		{
			throw new SecurityException(getString_0(107399226));
		}
		dictionary_0 = new Dictionary<string, MySqlPool>();
		list_0 = new List<MySqlPool>();
		int_0 = 180;
		timer_0 = new Timer(smethod_9, null, int_0 * 1000 + 8000, int_0 * 1000);
		AppDomain.CurrentDomain.ProcessExit += smethod_0;
		AppDomain.CurrentDomain.DomainUnload += smethod_0;
	}

	private static void smethod_0(object sender, EventArgs e)
	{
		smethod_7();
	}

	private static string smethod_1(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		string text = getString_0(107399125);
		lock (mySqlConnectionStringBuilder_0)
		{
			text = mySqlConnectionStringBuilder_0.ConnectionString;
		}
		if (mySqlConnectionStringBuilder_0.IntegratedSecurity && !mySqlConnectionStringBuilder_0.ConnectionReset)
		{
			try
			{
				WindowsIdentity current = WindowsIdentity.GetCurrent();
				return text + getString_0(107410076) + current.User;
			}
			catch (SecurityException ex)
			{
				throw new MySqlException(Class121.NoWindowsIdentity, ex);
			}
		}
		return text;
	}

	public static MySqlPool smethod_2(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		string key = smethod_1(mySqlConnectionStringBuilder_0);
		lock (dictionary_0)
		{
			dictionary_0.TryGetValue(key, out var value);
			if (value == null)
			{
				value = new MySqlPool(mySqlConnectionStringBuilder_0);
				dictionary_0.Add(key, value);
			}
			else
			{
				value.Settings = mySqlConnectionStringBuilder_0;
			}
			return value;
		}
	}

	public static void smethod_3(Class143 class143_0)
	{
		class143_0.Pool?.method_4(class143_0);
	}

	public static void smethod_4(Class143 class143_0)
	{
		class143_0.Pool?.method_3(class143_0);
	}

	public static void smethod_5(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		string string_;
		try
		{
			string_ = smethod_1(mySqlConnectionStringBuilder_0);
		}
		catch (MySqlException)
		{
			return;
		}
		smethod_6(string_);
	}

	private static void smethod_6(string string_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				MySqlPool mySqlPool = dictionary_0[string_0];
				list_0.Add(mySqlPool);
				mySqlPool.method_7();
				dictionary_0.Remove(string_0);
			}
		}
	}

	public static void smethod_7()
	{
		lock (dictionary_0)
		{
			List<string> list = new List<string>(dictionary_0.Count);
			list.AddRange(dictionary_0.Keys);
			foreach (string item in list)
			{
				smethod_6(item);
			}
		}
	}

	public static void smethod_8(MySqlPool mySqlPool_0)
	{
		list_0.Remove(mySqlPool_0);
	}

	public static void smethod_9(object object_0)
	{
		List<Class143> list = new List<Class143>();
		lock (dictionary_0)
		{
			foreach (MySqlPool item in dictionary_0.Keys.Select((string string_0) => dictionary_0[string_0]))
			{
				list.AddRange(item.method_8());
			}
		}
		foreach (Class143 item2 in list)
		{
			item2.vmethod_1();
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
