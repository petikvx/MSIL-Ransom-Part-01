using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using MySqlX.Protocol.X;
using Mysqlx.Connection;
using Mysqlx.Expect;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns17;
using ns18;
using ns19;
using ns2;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns5;
using ns6;
using ns7;
using ns8;

namespace MySqlX.Sessions;

internal sealed class XInternalSession : Class79
{
	private Class86 class86_0;

	private Class109 class109_0;

	private Class109 class109_1;

	private bool bool_1;

	[NonSerialized]
	internal static GetString getString_1;

	public XInternalSession(MySqlConnectionStringBuilder settings)
		: base(settings)
	{
	}

	protected override void vmethod_0()
	{
		bool flag = mySqlConnectionStringBuilder_0.ConnectionProtocol == Enum41.const_5 || mySqlConnectionStringBuilder_0.ConnectionProtocol == Enum41.const_5;
		stream_0 = Stream0.smethod_2(mySqlConnectionStringBuilder_0, flag);
		if (stream_0 == null)
		{
			throw new MySqlException(Class122.UnableToConnect);
		}
		class109_0 = new Class109(stream_0);
		class109_1 = new Class109(stream_0);
		class86_0 = new Class86(class109_0, class109_1);
		mySqlConnectionStringBuilder_0.CharacterSet = (string.IsNullOrWhiteSpace(mySqlConnectionStringBuilder_0.CharacterSet) ? getString_1(107407020) : mySqlConnectionStringBuilder_0.CharacterSet);
		Encoding encoding = Encoding.GetEncoding((string.Compare(mySqlConnectionStringBuilder_0.CharacterSet, getString_1(107407020), ignoreCase: true) == 0) ? getString_1(107407039) : mySqlConnectionStringBuilder_0.CharacterSet);
		method_11(Enum23.const_2, bool_2: false);
		method_6();
		if (mySqlConnectionStringBuilder_0.SslMode != 0)
		{
			if (!bool_1)
			{
				throw new MySqlException(string.Format(Class121.NoServerSSLSupport, mySqlConnectionStringBuilder_0.Server));
			}
			new Class133(mySqlConnectionStringBuilder_0).method_1(ref stream_0, encoding, mySqlConnectionStringBuilder_0.ToString());
			class109_0 = new Class109(stream_0);
			class109_1 = new Class109(stream_0);
			class86_0.method_31(class109_0, class109_1);
		}
		if (mySqlConnectionStringBuilder_0.Auth == MySqlAuthenticationMode.Default)
		{
			if ((mySqlConnectionStringBuilder_0.SslMode != 0 && bool_1) || mySqlConnectionStringBuilder_0.ConnectionProtocol == Enum41.const_5)
			{
				mySqlConnectionStringBuilder_0.Auth = MySqlAuthenticationMode.PLAIN;
				method_8();
			}
			else
			{
				bool flag2 = false;
				mySqlConnectionStringBuilder_0.Auth = MySqlAuthenticationMode.MYSQL41;
				try
				{
					method_7();
					flag2 = true;
				}
				catch (MySqlException ex)
				{
					if (ex.Code != 1045)
					{
						throw;
					}
				}
				if (!flag2)
				{
					try
					{
						mySqlConnectionStringBuilder_0.Auth = MySqlAuthenticationMode.SHA256_MEMORY;
						method_10();
						flag2 = true;
					}
					catch (MySqlException ex2)
					{
						if (ex2.Code == 1045)
						{
							throw new MySqlException(1045u, getString_1(107406998), Class122.AuthenticationFailed);
						}
						throw;
					}
				}
			}
		}
		else
		{
			switch (mySqlConnectionStringBuilder_0.Auth)
			{
			default:
				throw new NotImplementedException(mySqlConnectionStringBuilder_0.Auth.ToString());
			case MySqlAuthenticationMode.PLAIN:
				method_8();
				break;
			case MySqlAuthenticationMode.MYSQL41:
				method_7();
				break;
			case MySqlAuthenticationMode.EXTERNAL:
				method_9();
				break;
			case MySqlAuthenticationMode.SHA256_MEMORY:
				method_10();
				break;
			}
		}
		method_11(Enum23.const_1, bool_2: false);
	}

	private void method_6()
	{
		class86_0.method_4();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (mySqlConnectionStringBuilder_0.SslMode != 0 && class86_0.Capabilities.Capabilities_.FirstOrDefault((Capability capability_0) => capability_0.Name.ToLowerInvariant() == _003C_003Ec.getString_0(107406992)) != null)
		{
			bool_1 = true;
			dictionary.Add(getString_1(107406989), getString_1(107407016));
		}
		class86_0.method_5(dictionary);
	}

	private void method_7()
	{
		Class114 @class = new Class114(mySqlConnectionStringBuilder_0);
		class86_0.method_0(@class.AuthName, null, null);
		byte[] byte_ = class86_0.method_1();
		class86_0.method_2(@class.method_6(byte_));
		class86_0.method_3();
	}

	private void method_8()
	{
		Class116 @class = new Class116(mySqlConnectionStringBuilder_0);
		class86_0.method_0(@class.AuthName, @class.method_8(), null);
		class86_0.method_3();
	}

	private void method_9()
	{
		class86_0.method_0(getString_1(107407011), Encoding.UTF8.GetBytes(getString_1(107397612)), null);
		class86_0.method_3();
	}

	private void method_10()
	{
		Class118 @class = new Class118();
		class86_0.method_0(@class.PluginName, null, null);
		byte[] byte_ = class86_0.method_1();
		string s = string.Format(getString_1(107406966), mySqlConnectionStringBuilder_0.Database, mySqlConnectionStringBuilder_0.UserID);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		byte[] array = @class.method_5(mySqlConnectionStringBuilder_0.Password, byte_);
		byte[] array2 = new byte[bytes.Length + array.Length];
		bytes.CopyTo(array2, 0);
		array.CopyTo(array2, bytes.Length);
		class86_0.method_2(array2);
		class86_0.method_3();
	}

	protected void method_11(Enum23 enum23_1, bool bool_2)
	{
		if (enum23_1 != base.SessionState || bool_2)
		{
			_ = base.SessionState;
			base.SessionState = enum23_1;
		}
	}

	internal override Class85 vmethod_2()
	{
		return class86_0;
	}

	public override void vmethod_1()
	{
		try
		{
			class86_0.method_15();
		}
		finally
		{
			base.SessionState = Enum23.const_0;
			stream_0.Dispose();
		}
	}

	public void method_12(string string_0, string string_1)
	{
		method_18(Class99.string_0, true, new KeyValuePair<string, object>(getString_1(107409755), string_0), new KeyValuePair<string, object>(getString_1(107408054), string_1));
	}

	public void method_13(string string_0, string string_1)
	{
		method_18(Class99.string_2, true, new KeyValuePair<string, object>(getString_1(107409755), string_0), new KeyValuePair<string, object>(getString_1(107408054), string_1));
	}

	public Class54 method_14(Class69 class69_0)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		list.Add(new KeyValuePair<string, object>(getString_1(107408054), class69_0.class71_0.IndexName));
		list.Add(new KeyValuePair<string, object>(getString_1(107406953), class69_0.Target.Name));
		list.Add(new KeyValuePair<string, object>(getString_1(107409755), class69_0.Target.Schema.Name));
		list.Add(new KeyValuePair<string, object>(getString_1(107406936), false));
		if (class69_0.class71_0.Type != null)
		{
			list.Add(new KeyValuePair<string, object>(getString_1(107407866), class69_0.class71_0.Type));
		}
		for (int i = 0; i < class69_0.class71_0.Fields.Count; i++)
		{
			Class71.Class72 @class = class69_0.class71_0.Fields[i];
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add(getString_1(107406927), @class.Field);
			if (@class.Type != null)
			{
				dictionary.Add(getString_1(107407866), (@class.Type == getString_1(107407345)) ? getString_1(107406950) : @class.Type);
			}
			if (!@class.Required.HasValue)
			{
				dictionary.Add(getString_1(107408360), (@class.Type == getString_1(107407368)) ? true : false);
			}
			else
			{
				dictionary.Add(getString_1(107408360), @class.Required.Value);
			}
			if (@class.Options.HasValue)
			{
				dictionary.Add(getString_1(107408347), (ulong)@class.Options.Value);
			}
			if (@class.Srid.HasValue)
			{
				dictionary.Add(getString_1(107408302), (ulong)@class.Srid.Value);
			}
			list.Add(new KeyValuePair<string, object>(getString_1(107406937), dictionary));
		}
		return method_19(Class99.string_1, bool_2: false, list.ToArray());
	}

	public void method_15(string string_0, string string_1, string string_2)
	{
		List<KeyValuePair<string, object>> list = new List<KeyValuePair<string, object>>();
		list.Add(new KeyValuePair<string, object>(getString_1(107409755), string_0));
		list.Add(new KeyValuePair<string, object>(getString_1(107406953), string_1));
		list.Add(new KeyValuePair<string, object>(getString_1(107408054), string_2));
		method_18(Class99.string_3, bool_2: false, list.ToArray());
	}

	public long method_16(Class41 class41_0, string string_0)
	{
		string string_ = string.Format(getString_1(107406920), ExprUnparser.smethod_8(class41_0.Name), ExprUnparser.smethod_8(string_0));
		return (long)method_4(string_);
	}

	public bool method_17(Class41 class41_0, string string_0)
	{
		string string_ = string.Format(getString_1(107406879), class41_0.Name, string_0);
		return (ulong)(long)method_4(string_) > 0uL;
	}

	private Class54 method_18(string string_0, bool bool_2, params KeyValuePair<string, object>[] keyValuePair_0)
	{
		class86_0.method_18(getString_1(107407029), string_0, keyValuePair_0);
		return new Class54(this);
	}

	private Class54 method_19(string string_0, bool bool_2, params KeyValuePair<string, object>[] keyValuePair_0)
	{
		class86_0.method_19(getString_1(107407029), string_0, keyValuePair_0);
		return new Class54(this);
	}

	public List<T> method_20<T>(Class41 class41_0, params string[] string_0) where T : Class38
	{
		for (int i = 0; i < string_0.Length; i++)
		{
			string_0[i] = string_0[i].ToUpperInvariant();
		}
		ReadOnlyCollection<Class55> readOnlyCollection = method_22(getString_1(107407261), new KeyValuePair<string, object>(getString_1(107409755), class41_0.Name)).method_2();
		List<T> list = new List<T>();
		foreach (Class55 item2 in readOnlyCollection)
		{
			if (!string_0.Contains(item2.method_0(getString_1(107407866)).ToUpperInvariant()))
			{
				continue;
			}
			List<object> list2 = new List<object>(new object[2]
			{
				class41_0,
				item2.method_0(getString_1(107408054))
			});
			if (item2[getString_1(107408054)] is byte[])
			{
				byte[] array = item2[getString_1(107408054)] as byte[];
				list2[1] = Encoding.UTF8.GetString(array, 0, array.Length);
			}
			string text = item2.method_0(getString_1(107407866)).ToUpperInvariant();
			if (!(text == getString_1(107408629)))
			{
				if (text == getString_1(107408620))
				{
					list2.Add(true);
				}
			}
			else
			{
				list2.Add(false);
			}
			T item = (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.NonPublic, null, list2.ToArray(), null);
			list.Add(item);
		}
		return list;
	}

	public string method_21(Class41 class41_0, string string_0)
	{
		return (method_22(getString_1(107407261), new KeyValuePair<string, object>(getString_1(107409755), class41_0.Name), new KeyValuePair<string, object>(getString_1(107407212), string_0)).method_4() ?? throw new MySqlException(string.Format(Class122.NoObjectFound, string_0))).method_0(getString_1(107407866));
	}

	public Class51 method_22(string string_0, params KeyValuePair<string, object>[] keyValuePair_0)
	{
		class86_0.method_18(getString_1(107407029), string_0, keyValuePair_0);
		return new Class51(this);
	}

	public Class54 method_23(Class39 class39_0, Class43[] class43_0, List<string> list_0, bool bool_2)
	{
		class86_0.method_22(class39_0.Schema.Name, bool_0: false, class39_0.Name, class43_0, null, bool_2);
		return new Class54(this);
	}

	public Class54 method_24(Class65 class65_0)
	{
		class86_0.method_24(class65_0.Target.Schema.Name, class65_0.Target.Name, bool_0: false, class65_0.FilterData);
		return new Class54(this);
	}

	public Class54 method_25(Class60 class60_0)
	{
		class86_0.method_24(class60_0.Target.Schema.Name, class60_0.Target.Name, bool_0: true, class60_0.FilterData);
		return new Class54(this);
	}

	public Class54 method_26(Class64 class64_0)
	{
		class86_0.method_25(class64_0.Target.Schema.Name, class64_0.Target.Name, bool_0: false, class64_0.FilterData, class64_0.list_0);
		return new Class54(this);
	}

	public Class54 method_27(Class62 class62_0)
	{
		class86_0.method_25(class62_0.Target.Schema.Name, class62_0.Target.Name, bool_0: true, class62_0.FilterData, class62_0.list_0);
		return new Class54(this);
	}

	public Class53 method_28(Class63 class63_0)
	{
		class86_0.method_27(class63_0.Target.Schema.Name, class63_0.Target.Name, bool_0: false, class63_0.FilterData, class63_0.class74_0);
		return new Class53(this);
	}

	public Class51 method_29(Class61 class61_0)
	{
		class86_0.method_27(class61_0.Target.Schema.Name, class61_0.Target.Name, bool_0: true, class61_0.FilterData, class61_0.class74_0);
		return new Class51(this);
	}

	public Class54 method_30(Class66 class66_0)
	{
		class86_0.method_22(class66_0.Target.Schema.Name, bool_0: true, class66_0.Target.Name, class66_0.list_0.ToArray(), class66_0.string_0, bool_1: false);
		return new Class54(this);
	}

	protected Class54 method_31(Open.Types.Condition.Class29.Enum11 enum11_0)
	{
		class86_0.method_28(enum11_0);
		return new Class54(this);
	}

	public Class54 method_32()
	{
		return method_31(Open.Types.Condition.Class29.Enum11.const_3);
	}

	static XInternalSession()
	{
		Strings.CreateGetStringDelegate(typeof(XInternalSession));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397790), getString_1(107397785)).Replace(getString_1(107397748), getString_1(107397743)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397738)))
		{
			throw new SecurityException(getString_1(107397713));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
