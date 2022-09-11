using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MySqlX.Failover;
using MySqlX.Sessions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns12;
using ns18;
using ns19;
using ns21;
using ns22;
using ns7;
using ns8;

namespace MySqlX.XDevAPI;

public abstract class BaseSession : IDisposable
{
	private Class79 class79_0;

	private string string_0;

	private bool bool_0;

	internal Class80 class80_0 = new Class80();

	[CompilerGenerated]
	private MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	[CompilerGenerated]
	private Class41 class41_0;

	private Struct23? nullable_0;

	private bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	public MySqlConnectionStringBuilder Settings
	{
		[CompilerGenerated]
		get
		{
			return mySqlConnectionStringBuilder_0;
		}
		[CompilerGenerated]
		private set
		{
			mySqlConnectionStringBuilder_0 = value;
		}
	}

	public Class41 Schema
	{
		[CompilerGenerated]
		get
		{
			return class41_0;
		}
		[CompilerGenerated]
		protected set
		{
			class41_0 = value;
		}
	}

	internal Class79 InternalSession => class79_0;

	internal XInternalSession XSession => InternalSession as XInternalSession;

	internal Struct23 Version
	{
		get
		{
			Struct23? @struct = nullable_0;
			if (!@struct.HasValue)
			{
				Struct23? struct2 = (nullable_0 = XSession.method_5());
				return struct2.Value;
			}
			return @struct.GetValueOrDefault();
		}
	}

	public BaseSession(string connectionString)
	{
		if (string.IsNullOrWhiteSpace(connectionString))
		{
			throw new ArgumentNullException(getString_0(107409669));
		}
		string_0 = method_12(connectionString);
		if (FailoverManager.FailoverGroup != null)
		{
			class79_0 = FailoverManager.smethod_2(string_0, out string_0);
			Settings = new MySqlConnectionStringBuilder(string_0);
		}
		else
		{
			Settings = new MySqlConnectionStringBuilder(string_0);
			class79_0 = Class79.smethod_0(Settings);
		}
		if (!string.IsNullOrWhiteSpace(Settings.Database))
		{
			method_2(Settings.Database);
		}
	}

	public BaseSession(object connectionData)
	{
		if (connectionData == null)
		{
			throw new ArgumentNullException(getString_0(107409612));
		}
		Dictionary<string, object> dictionary = Class110.smethod_0(connectionData);
		if (!dictionary.Keys.Any((string string_0) => string_0.ToLowerInvariant() == _003C_003Ec.getString_0(107409594)))
		{
			dictionary.Add(getString_0(107409591), 33060u);
		}
		Settings = new MySqlConnectionStringBuilder();
		bool flag = false;
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			if (Settings.ContainsKey(item.Key))
			{
				Settings.method_2(item.Key, item.Value, getString_0(107409582));
				if (!flag && !string.IsNullOrEmpty(Settings[getString_0(107409605)].ToString()))
				{
					string string_ = item.Value.ToString();
					if (method_14(string_))
					{
						Settings.method_2(item.Key, string_ = method_19(string_), getString_0(107409582));
					}
					method_17(string_, bool_2: false);
					if (FailoverManager.FailoverGroup != null)
					{
						Settings[getString_0(107409605)] = FailoverManager.FailoverGroup.ActiveHost.Host;
					}
					flag = true;
				}
				continue;
			}
			throw new KeyNotFoundException(string.Format(Class122.InvalidConnectionStringAttribute, item.Key));
		}
		string_0 = Settings.ToString();
		if (FailoverManager.FailoverGroup != null)
		{
			class79_0 = FailoverManager.smethod_2(string_0, out string_0);
			Settings = new MySqlConnectionStringBuilder(string_0);
		}
		else
		{
			class79_0 = Class79.smethod_0(Settings);
		}
		if (!string.IsNullOrWhiteSpace(Settings.Database))
		{
			method_2(Settings.Database);
		}
	}

	public void method_0(string string_1)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			throw new ArgumentNullException(getString_0(107409596));
		}
		if (method_2(string_1).vmethod_0())
		{
			InternalSession.method_1(getString_0(107409555) + string_1 + getString_0(107409566));
		}
	}

	public Class41 method_1(string string_1)
	{
		InternalSession.method_1(getString_0(107409529) + string_1 + getString_0(107409566));
		return new Class41(this, string_1);
	}

	public Class41 method_2(string string_1)
	{
		Schema = new Class41(this, string_1);
		return Schema;
	}

	public List<Class41> method_3()
	{
		Class51 @class = XSession.method_2(getString_0(107409536));
		@class.method_2();
		return @class.Rows.Select((Class55 class55_0) => new Class41(this, class55_0.method_0(getString_0(107408367)))).ToList();
	}

	public void method_4()
	{
		InternalSession.method_1(getString_0(107408967));
	}

	public Class54 method_5()
	{
		return InternalSession.method_1(getString_0(107408910));
	}

	public Class54 method_6()
	{
		return InternalSession.method_1(getString_0(107408933));
	}

	public void method_7()
	{
		if (XSession.SessionState != 0)
		{
			XSession.vmethod_1();
		}
	}

	public string method_8()
	{
		return method_9(string.Format(getString_0(107408888), Guid.NewGuid().ToString().Replace(getString_0(107408899), getString_0(107408894))));
	}

	public string method_9(string string_1)
	{
		InternalSession.method_1(string.Format(getString_0(107408857), string_1));
		return string_1;
	}

	public void method_10(string string_1)
	{
		InternalSession.method_1(string.Format(getString_0(107408868), string_1));
	}

	public void method_11(string string_1)
	{
		InternalSession.method_1(string.Format(getString_0(107408839), string_1));
	}

	protected internal string method_12(string string_1)
	{
		FailoverManager.smethod_0();
		if (Regex.IsMatch(string_1, getString_0(107408786), RegexOptions.IgnoreCase))
		{
			return method_13(string_1);
		}
		return method_16(string_1);
	}

	private string method_13(string string_1)
	{
		Uri uri = null;
		string text = null;
		bool flag = false;
		string text2 = null;
		try
		{
			uri = new Uri(string_1);
		}
		catch (UriFormatException ex)
		{
			if (ex.Message != getString_0(107408757))
			{
				throw ex;
			}
			string[] array = string_1.Split('@', '?');
			if (array.Length == 1)
			{
				throw ex;
			}
			text2 = array[1];
			string text3 = string.Empty;
			flag = method_14(text2);
			bool flag2 = text2.StartsWith(getString_0(107409204)) && text2.Contains(getString_0(107409199));
			if ((!flag && text2.Contains(getString_0(107409194)) && !flag2) || (flag && text2.Contains(getString_0(107409221))) || (text2.StartsWith(getString_0(107409204)) && text2.Contains(getString_0(107409216)) && flag2))
			{
				text3 = text2.Substring(text2.LastIndexOf('/') + 1);
				text2 = text2.Substring(0, text2.Length - text3.Length - 1);
			}
			if (flag)
			{
				text = array[0] + getString_0(107409211) + ((text3 != string.Empty) ? (getString_0(107409194) + text3) : string.Empty) + ((array.Length > 2) ? (getString_0(107409162) + array[2]) : string.Empty);
			}
			else if (flag2)
			{
				text2 = text2.Substring(1, text2.Length - 2);
				int num = method_17(text2, bool_2: true);
				if (FailoverManager.FailoverGroup != null)
				{
					text2 = FailoverManager.FailoverGroup.ActiveHost.Host;
					flag = method_14(FailoverManager.FailoverGroup.ActiveHost.Host);
					text = array[0] + getString_0(107409189) + (flag ? getString_0(107409184) : text2) + ((FailoverManager.FailoverGroup.ActiveHost.Port != -1) ? (getString_0(107409139) + FailoverManager.FailoverGroup.ActiveHost.Port) : string.Empty) + ((text3 != string.Empty) ? (getString_0(107409194) + text3) : string.Empty) + ((array.Length == 3) ? (getString_0(107409162) + array[2]) : string.Empty);
				}
				else
				{
					if (num != 1)
					{
						throw ex;
					}
					text = array[0] + getString_0(107409189) + text2 + ((text3 != string.Empty) ? (getString_0(107409194) + text3) : string.Empty) + ((array.Length == 3) ? (getString_0(107409162) + array[2]) : string.Empty);
				}
			}
		}
		if (uri == null)
		{
			uri = ((text == null) ? new Uri(string_1) : new Uri(text));
		}
		return method_15(uri, text2, flag);
	}

	private bool method_14(string string_1)
	{
		if (!string_1.StartsWith(getString_0(107397228)) && !string_1.StartsWith(getString_0(107409194)) && !string_1.StartsWith(getString_0(107409134)) && !string_1.StartsWith(getString_0(107409161)) && !string_1.StartsWith(getString_0(107409156)) && !string_1.StartsWith(getString_0(107409151)))
		{
			return false;
		}
		return true;
	}

	private string method_15(Uri uri_0, string string_1, bool bool_2)
	{
		List<string> list = new List<string>();
		if (string.IsNullOrWhiteSpace(uri_0.Host))
		{
			throw new UriFormatException(Class122.InvalidUriData + getString_0(107409146));
		}
		list.Add(getString_0(107409105) + (bool_2 ? method_19(string_1) : uri_0.Host));
		list.Add(getString_0(107409124) + ((uri_0.Port == -1) ? 33060 : uri_0.Port));
		if (!string.IsNullOrWhiteSpace(uri_0.UserInfo))
		{
			string[] array = uri_0.UserInfo.Split(new char[1] { ':' });
			if (array.Length > 2)
			{
				throw new UriFormatException(Class122.InvalidUriData + getString_0(107409115));
			}
			list.Add(getString_0(107409070) + Uri.UnescapeDataString(array[0]));
			if (array.Length > 1)
			{
				list.Add(getString_0(107409093) + Uri.UnescapeDataString(array[1]));
			}
		}
		if (uri_0.Segments.Length > 2)
		{
			throw new UriFormatException(Class122.InvalidUriData + getString_0(107409048));
		}
		if (uri_0.Segments.Length > 1)
		{
			list.Add(getString_0(107409035) + Uri.UnescapeDataString(uri_0.Segments[1]));
		}
		if (!string.IsNullOrWhiteSpace(uri_0.Query))
		{
			string[] array2 = Uri.UnescapeDataString(uri_0.Query).Substring(1).Split(new char[1] { '&' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(new char[1] { '=' });
				if (array3.Length <= 2)
				{
					string item = array3[0] + getString_0(107409054) + ((array3.Length == 2) ? array3[1] : getString_0(107409017)).Replace(getString_0(107409008), string.Empty).Replace(getString_0(107409003), string.Empty);
					list.Add(item);
					continue;
				}
				throw new ArgumentException(Class122.InvalidUriQuery + getString_0(107409139) + array3[0]);
			}
		}
		return string.Join(getString_0(107409030), list);
	}

	private string method_16(string string_1)
	{
		string text = string.Empty;
		string[] array = string_1.Substring(0).Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		bool flag = false;
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			int num = text2.IndexOf('=');
			if (num == -1)
			{
				continue;
			}
			string text3 = text2.Substring(0, num);
			string text4 = text2.Substring(num + 1);
			if (text3 != getString_0(107409605) && text3 != getString_0(107409146) && text3 != getString_0(107409025) && text3 != getString_0(107408976) && text3 != getString_0(107408991) && text3 != getString_0(107408434) && text3 != getString_0(107408457))
			{
				if (text3 == getString_0(107409591))
				{
					flag = true;
				}
				text = text + text2 + getString_0(107408404);
				continue;
			}
			if (method_14(text4))
			{
				text4 = method_19(text4);
			}
			if (method_17(text4, bool_2: false) == 1 && FailoverManager.FailoverGroup == null)
			{
				text = getString_0(107409105) + text4 + getString_0(107408404) + text;
			}
		}
		if (FailoverManager.FailoverGroup == null)
		{
			if (!flag)
			{
				return text + getString_0(107408399) + 33060u;
			}
			return text;
		}
		return getString_0(107409105) + FailoverManager.FailoverGroup.ActiveHost.Host + getString_0(107408404) + ((!flag) ? (getString_0(107409124) + 33060u + getString_0(107408404)) : string.Empty) + text;
	}

	private int method_17(string string_1, bool bool_2)
	{
		if (string.IsNullOrWhiteSpace(string_1))
		{
			return -1;
		}
		int num = -1;
		Enum26 enum26_ = Enum26.const_0;
		string[] array = null;
		List<XServer> list = new List<XServer>();
		string_1 = string_1.Replace(getString_0(107395731), getString_0(107397453));
		if (!string_1.StartsWith(getString_0(107409008)) && !string_1.EndsWith(getString_0(107409003)))
		{
			array = string_1.Split(new char[1] { ',' });
			string[] array2 = array;
			foreach (string string_2 in array2)
			{
				if (method_14(string_2))
				{
					list.Add(new XServer(method_19(string_2), -1, -1));
				}
				else
				{
					list.Add(method_18(string_2, bool_2));
				}
			}
			if (array.Length == 1)
			{
				return 1;
			}
			num = array.Length;
		}
		else
		{
			string[] array3 = string_1.Split(new string[1] { getString_0(107408422) }, StringSplitOptions.RemoveEmptyEntries);
			bool? flag = null;
			int num2 = 100;
			string[] array2 = array3;
			foreach (string text in array2)
			{
				string text2 = text;
				if (text2.StartsWith(getString_0(107409008)))
				{
					text2 = text.Substring(1);
				}
				if (text2.EndsWith(getString_0(107409003)))
				{
					text2 = text2.Substring(0, text.Length - 1);
				}
				string[] array4 = text2.Split(new char[1] { ',' });
				string[] array5 = array4[0].Split(new char[1] { '=' });
				if (!(array5[0].ToLowerInvariant() != getString_0(107408991)))
				{
					string text3 = array5[1];
					if (!string.IsNullOrWhiteSpace(text3))
					{
						if (array4.Length == 2)
						{
							if (flag.HasValue && flag == false)
							{
								throw new ArgumentException(Class122.PriorityForAllOrNoHosts);
							}
							flag = flag ?? true;
							string[] array6 = array4[1].Split(new char[1] { '=' });
							if (array6[0].ToLowerInvariant() != getString_0(107408417))
							{
								throw new KeyNotFoundException(string.Format(Class122.KeywordNotFound, getString_0(107408417)));
							}
							if (string.IsNullOrWhiteSpace(array6[1]))
							{
								throw new ArgumentNullException(getString_0(107408417));
							}
							int result = -1;
							int.TryParse(array6[1], out result);
							if (result < 0 || result > 100)
							{
								throw new ArgumentException(Class122.PriorityOutOfLimits);
							}
							list.Add(method_18(method_14(text3) ? method_19(text3) : text3, bool_2, result));
						}
						else
						{
							if (flag.HasValue && flag == true)
							{
								throw new ArgumentException(Class122.PriorityForAllOrNoHosts);
							}
							flag = flag ?? false;
							list.Add(method_18(text3, bool_2, (num2 > 0) ? num2-- : 0));
						}
						continue;
					}
					throw new ArgumentNullException(getString_0(107409605));
				}
				throw new KeyNotFoundException(string.Format(Class122.KeywordNotFound, getString_0(107408991)));
			}
			num = array3.Length;
			enum26_ = Enum26.const_1;
		}
		FailoverManager.smethod_1(list, enum26_);
		return num;
	}

	private XServer method_18(string string_1, bool bool_2, int int_0 = -1, int int_1 = -1)
	{
		string_1 = string_1.Trim();
		int num = -1;
		if (IPAddress.TryParse(string_1, out var address))
		{
			AddressFamily addressFamily = address.AddressFamily;
			if (addressFamily == AddressFamily.InterNetworkV6)
			{
				if (string_1.StartsWith(getString_0(107409204)) && string_1.Contains(getString_0(107409199)) && !string_1.EndsWith(getString_0(107409199)))
				{
					num = string_1.LastIndexOf(getString_0(107409139));
				}
			}
			else
			{
				num = string_1.IndexOf(getString_0(107409139));
			}
		}
		else
		{
			num = string_1.IndexOf(getString_0(107409139));
		}
		if (num != -1)
		{
			if (!bool_2)
			{
				throw new ArgumentException(Class122.PortNotSupported);
			}
			int.TryParse(string_1.Substring(num + 1), out int_1);
			string_1 = string_1.Substring(0, num);
		}
		return new XServer(string_1, int_1, int_0);
	}

	private string method_19(string string_1)
	{
		string_1 = string_1.Replace(getString_0(107408372), getString_0(107409194));
		if (string_1.StartsWith(getString_0(107409008)) && string_1.EndsWith(getString_0(107409003)))
		{
			string_1 = string_1.Substring(1, string_1.Length - 2);
		}
		return string_1;
	}

	protected virtual void vmethod_0(bool bool_2)
	{
		if (!bool_1)
		{
			if (bool_2)
			{
				method_7();
			}
			bool_1 = true;
		}
	}

	void IDisposable.Dispose()
	{
		vmethod_0(bool_2: true);
	}

	[CompilerGenerated]
	private Class41 method_20(Class55 class55_0)
	{
		return new Class41(this, class55_0.method_0(getString_0(107408367)));
	}

	static BaseSession()
	{
		Strings.CreateGetStringDelegate(typeof(BaseSession));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397631), getString_0(107397626)).Replace(getString_0(107397589), getString_0(107397584)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_2: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397579)))
		{
			throw new SecurityException(getString_0(107397554));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_2, [MarshalAs(UnmanagedType.Bool)] out bool bool_3);
}
