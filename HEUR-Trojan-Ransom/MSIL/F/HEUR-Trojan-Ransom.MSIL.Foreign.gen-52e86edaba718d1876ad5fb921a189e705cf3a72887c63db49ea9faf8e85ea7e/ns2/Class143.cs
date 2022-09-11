using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns17;
using ns21;
using ns22;
using ns5;
using ns6;
using ns7;

namespace ns2;

internal class Class143 : IDisposable
{
	protected Encoding encoding_0;

	protected MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0;

	protected DateTime dateTime_0;

	protected string string_0;

	protected Dictionary<string, string> dictionary_0;

	internal int int_0;

	private bool bool_0;

	protected Interface1 interface1_0;

	internal Class142 class142_0;

	private bool bool_1;

	[CompilerGenerated]
	private DateTime dateTime_1;

	[CompilerGenerated]
	private Class153 class153_0;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private MySqlPool mySqlPool_0;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private Dictionary<int, string> dictionary_1;

	[CompilerGenerated]
	private bool bool_4;

	[NonSerialized]
	internal static GetString getString_0;

	public DateTime IdleSince
	{
		[CompilerGenerated]
		get
		{
			return dateTime_1;
		}
		[CompilerGenerated]
		set
		{
			dateTime_1 = value;
		}
	}

	public int ThreadID => interface1_0.ThreadId;

	public Struct23 Version => interface1_0.Version;

	public MySqlConnectionStringBuilder Settings
	{
		get
		{
			return mySqlConnectionStringBuilder_0;
		}
		set
		{
			mySqlConnectionStringBuilder_0 = value;
		}
	}

	public Encoding Encoding
	{
		get
		{
			return encoding_0;
		}
		set
		{
			encoding_0 = value;
		}
	}

	public Class153 currentTransaction
	{
		[CompilerGenerated]
		get
		{
			return class153_0;
		}
		[CompilerGenerated]
		set
		{
			class153_0 = value;
		}
	}

	public bool IsInActiveUse
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool IsOpen
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		protected set
		{
			bool_3 = value;
		}
	}

	public MySqlPool Pool
	{
		[CompilerGenerated]
		get
		{
			return mySqlPool_0;
		}
		[CompilerGenerated]
		set
		{
			mySqlPool_0 = value;
		}
	}

	public long MaxPacketSize
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		protected set
		{
			long_0 = value;
		}
	}

	protected internal int ConnectionCharSetIndex
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	protected internal Dictionary<int, string> CharacterSets
	{
		[CompilerGenerated]
		get
		{
			return dictionary_1;
		}
		[CompilerGenerated]
		protected set
		{
			dictionary_1 = value;
		}
	}

	public bool SupportsOutputParameters => Version.method_0(5, 5, 0);

	public bool SupportsBatch => (interface1_0.Flags & Enum37.flag_16) > (Enum37)0uL;

	public bool SupportsConnectAttrs => (interface1_0.Flags & Enum37.flag_20) > (Enum37)0uL;

	public bool SupportsPasswordExpiration => (interface1_0.Flags & Enum37.flag_21) > (Enum37)0uL;

	public bool IsPasswordExpired
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		internal set
		{
			bool_4 = value;
		}
	}

	public Class143(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		encoding_0 = Encoding.GetEncoding(getString_0(107407582));
		if (encoding_0 == null)
		{
			throw new MySqlException(Class121.DefaultEncodingNotFound);
		}
		mySqlConnectionStringBuilder_0 = mySqlConnectionStringBuilder_1;
		string_0 = getString_0(107356108);
		ConnectionCharSetIndex = -1;
		MaxPacketSize = 1024L;
		interface1_0 = new Class169(this);
	}

	~Class143()
	{
		vmethod_16(bool_5: false);
	}

	public string method_0(string string_1)
	{
		return dictionary_0[string_1];
	}

	public bool method_1()
	{
		TimeSpan timeSpan = DateTime.Now.Subtract(dateTime_0);
		if (Settings.ConnectionLifeTime != 0)
		{
			return timeSpan.TotalSeconds > (double)Settings.ConnectionLifeTime;
		}
		return false;
	}

	public static Class143 smethod_0(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_1)
	{
		Class143 @class = null;
		try
		{
			if (MySqlTrace.QueryAnalysisEnabled || mySqlConnectionStringBuilder_1.Logging || mySqlConnectionStringBuilder_1.UseUsageAdvisor)
			{
				@class = new Class144(mySqlConnectionStringBuilder_1);
			}
		}
		catch (TypeInitializationException ex)
		{
			if (!(ex.InnerException is SecurityException))
			{
				throw ex;
			}
		}
		if (@class == null)
		{
			@class = new Class143(mySqlConnectionStringBuilder_1);
		}
		try
		{
			@class.vmethod_0();
			return @class;
		}
		catch
		{
			@class.System_002EIDisposable_002EDispose();
			throw;
		}
	}

	public bool method_2(Enum38 enum38_0)
	{
		return (interface1_0.ServerStatus & enum38_0) != 0;
	}

	public virtual void vmethod_0()
	{
		int num = 0;
		while (true)
		{
			try
			{
				dateTime_0 = DateTime.Now;
				interface1_0.imethod_1();
				IsOpen = true;
				break;
			}
			catch (IOException)
			{
				if (num++ >= 5)
				{
					throw;
				}
			}
		}
	}

	public virtual void vmethod_1()
	{
		System_002EIDisposable_002EDispose();
	}

	public virtual void vmethod_2(Class139 class139_0)
	{
		bool flag = false;
		if (dictionary_0 == null)
		{
			flag = true;
			try
			{
				if (Pool != null && Settings.CacheServerProperties)
				{
					if (Pool.ServerProperties == null)
					{
						Pool.ServerProperties = method_3(class139_0);
					}
					dictionary_0 = Pool.ServerProperties;
				}
				else
				{
					dictionary_0 = method_3(class139_0);
				}
				method_5(class139_0);
			}
			catch (MySqlException ex)
			{
				if (ex.Number != 1820)
				{
					throw;
				}
				IsPasswordExpired = true;
				return;
			}
		}
		if (Settings.ConnectionReset || flag)
		{
			string text = mySqlConnectionStringBuilder_0.CharacterSet;
			if (string.IsNullOrEmpty(text))
			{
				text = ((ConnectionCharSetIndex < 0 || !CharacterSets.ContainsKey(ConnectionCharSetIndex)) ? string_0 : CharacterSets[ConnectionCharSetIndex]);
			}
			if (dictionary_0.ContainsKey(getString_0(107352694)))
			{
				MaxPacketSize = Convert.ToInt64(dictionary_0[getString_0(107352694)]);
			}
			MySqlCommand obj = new MySqlCommand(getString_0(107352701), class139_0)
			{
				InternallyCreated = true
			};
			dictionary_0.TryGetValue(getString_0(107352628), out var value);
			dictionary_0.TryGetValue(getString_0(107352599), out var value2);
			if ((value != null && value.ToString() != text) || (value2 != null && value2.ToString() != text))
			{
				MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107353078) + text, class139_0);
				mySqlCommand.InternallyCreated = true;
				mySqlCommand.ExecuteNonQuery();
			}
			obj.ExecuteNonQuery();
			Encoding = Class137.smethod_1(Version, text ?? getString_0(107365799));
			interface1_0.imethod_0();
		}
	}

	private Dictionary<string, string> method_3(Class139 class139_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107353093), class139_0);
		try
		{
			using (Class142 @class = mySqlCommand.method_6())
			{
				while (@class.Read())
				{
					string @string = @class.GetString(0);
					string text = (dictionary[@string] = @class.GetString(1));
				}
			}
			int_0 = method_4(class139_0);
			return dictionary;
		}
		catch (Exception ex)
		{
			MySqlTrace.smethod_4(ThreadID, ex.Message);
			throw;
		}
	}

	private int method_4(Class139 class139_0)
	{
		TimeSpan? timeSpan = new MySqlCommand(getString_0(107353040), class139_0).ExecuteScalar() as TimeSpan?;
		string text = getString_0(107353019);
		if (timeSpan.HasValue)
		{
			text = timeSpan.ToString();
		}
		return int.Parse(text.Substring(0, text.IndexOf(':')));
	}

	private void method_5(Class139 class139_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand(getString_0(107352978), class139_0);
		try
		{
			using Class142 @class = mySqlCommand.method_6();
			CharacterSets = new Dictionary<int, string>();
			while (@class.Read())
			{
				CharacterSets[Convert.ToInt32(@class[getString_0(107409053)], NumberFormatInfo.InvariantInfo)] = @class.GetString(@class.GetOrdinal(getString_0(107352989)));
			}
		}
		catch (Exception ex)
		{
			MySqlTrace.smethod_4(ThreadID, ex.Message);
			throw;
		}
	}

	public virtual List<Class166> vmethod_3(Class139 class139_0)
	{
		List<Class166> list = new List<Class166>();
		using (Class142 @class = new MySqlCommand(getString_0(107352944), class139_0)
		{
			InternallyCreated = true
		}.method_6())
		{
			while (@class.Read())
			{
				list.Add(new Class166(@class.GetString(0), @class.GetInt32(1), @class.GetString(2)));
			}
		}
		EventArgs0 eventArgs = new EventArgs0();
		eventArgs.errors = list.ToArray();
		class139_0?.method_0(eventArgs);
		return list;
	}

	public virtual void vmethod_4(Class167 class167_0)
	{
		interface1_0.imethod_2(class167_0);
		bool_0 = true;
	}

	public virtual Class175 vmethod_5(int int_2, bool bool_5)
	{
		if (!bool_5 && !bool_0 && !method_2(Enum38.flag_2 | Enum38.flag_3))
		{
			return null;
		}
		bool_0 = false;
		int int_3 = -1;
		long long_ = -1L;
		int num = vmethod_6(int_2, ref int_3, ref long_);
		if (num == -1)
		{
			return null;
		}
		if (num > 0)
		{
			return new Class175(this, int_2, num);
		}
		return new Class175(int_3, long_);
	}

	protected virtual int vmethod_6(int int_2, ref int int_3, ref long long_1)
	{
		return interface1_0.imethod_5(ref int_3, ref long_1);
	}

	public virtual bool vmethod_7(int int_2, int int_3)
	{
		return interface1_0.imethod_6(int_2, int_3);
	}

	public virtual bool vmethod_8()
	{
		return vmethod_7(-1, 0);
	}

	public virtual void vmethod_9(string string_1)
	{
		Class167 @class = new Class167(Encoding);
		@class.method_19(string_1);
		vmethod_4(@class);
		vmethod_5(0, bool_5: false);
	}

	public Class145[] method_6(int int_2)
	{
		Class145[] array = new Class145[int_2];
		for (int i = 0; i < int_2; i++)
		{
			array[i] = new Class145(this);
		}
		interface1_0.imethod_14(array);
		return array;
	}

	public virtual int vmethod_10(string string_1, ref Class145[] class145_0)
	{
		return interface1_0.imethod_7(string_1, ref class145_0);
	}

	public Interface0 method_7(int int_2, Class145 class145_0, Interface0 interface0_0)
	{
		return interface1_0.imethod_12(int_2, class145_0, interface0_0);
	}

	public void method_8(Interface0 interface0_0)
	{
		interface1_0.imethod_13(interface0_0);
	}

	public void method_9(int int_2)
	{
		interface1_0.imethod_15(int_2);
	}

	public bool method_10()
	{
		return interface1_0.imethod_4();
	}

	public virtual void vmethod_11(string string_1)
	{
		interface1_0.imethod_10(string_1);
	}

	public virtual void vmethod_12(Class167 class167_0)
	{
		interface1_0.imethod_8(class167_0);
	}

	public virtual void vmethod_13(int int_2)
	{
		interface1_0.imethod_9(int_2);
	}

	public virtual void vmethod_14()
	{
		interface1_0.imethod_11();
	}

	public virtual void vmethod_15(Class139 class139_0, int int_2)
	{
		if (interface1_0.WarningCount > 0)
		{
			vmethod_3(class139_0);
		}
	}

	protected virtual void vmethod_16(bool bool_5)
	{
		if (bool_1)
		{
			return;
		}
		bool_1 = true;
		try
		{
			method_9(1000);
			interface1_0.imethod_3(IsOpen);
			if (mySqlConnectionStringBuilder_0.Pooling)
			{
				MySqlPoolManager.smethod_3(this);
			}
		}
		catch (Exception ex)
		{
			if (bool_5)
			{
				if (!(ex is MySqlException ex2))
				{
					MySqlTrace.smethod_4(0, ex.GetBaseException().Message);
				}
				else
				{
					MySqlTrace.smethod_4(ex2.Number, ex.GetBaseException().Message);
				}
			}
		}
		finally
		{
			class142_0 = null;
			IsOpen = false;
		}
	}

	void IDisposable.Dispose()
	{
		vmethod_16(bool_5: true);
		GC.SuppressFinalize(this);
	}

	static Class143()
	{
		Strings.CreateGetStringDelegate(typeof(Class143));
	}
}
