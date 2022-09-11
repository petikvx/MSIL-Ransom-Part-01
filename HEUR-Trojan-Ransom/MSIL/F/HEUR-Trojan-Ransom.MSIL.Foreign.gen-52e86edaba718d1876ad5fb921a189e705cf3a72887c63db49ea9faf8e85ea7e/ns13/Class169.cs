using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns14;
using ns15;
using ns19;
using ns2;
using ns20;
using ns21;
using ns22;
using ns3;
using ns6;
using ns7;

namespace ns13;

internal sealed class Class169 : Interface1
{
	private Struct23 struct23_0;

	private int int_0;

	protected byte[] byte_0;

	protected Enum38 enum38_0;

	protected Class168 class168_0;

	protected Stream stream_0;

	private BitArray bitArray_0;

	private Class167 class167_0;

	private Enum37 enum37_0;

	private Class143 class143_0;

	private int int_1;

	private Class112 class112_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Enum37 Flags => enum37_0;

	public int ThreadId => int_0;

	public Struct23 Version => struct23_0;

	public Enum38 ServerStatus => enum38_0;

	public int WarningCount => int_1;

	public Class167 Packet => class167_0;

	internal MySqlConnectionStringBuilder Settings => class143_0.Settings;

	internal Encoding Encoding => class143_0.Encoding;

	public Class169(Class143 class143_1)
	{
		class143_0 = class143_1;
		int_0 = -1;
	}

	private void method_0(MySqlException mySqlException_0)
	{
		if (mySqlException_0.IsFatal)
		{
			class143_0.vmethod_1();
		}
	}

	internal void method_1(Class167 class167_1)
	{
		class168_0.method_4(class167_1);
	}

	internal void method_2()
	{
		byte[] byte_ = new byte[4];
		class168_0.method_5(byte_, 0);
	}

	internal Class167 method_3()
	{
		return class167_0 = class168_0.method_2();
	}

	internal void method_4(bool bool_0)
	{
		try
		{
			if (bool_0)
			{
				class167_0 = class168_0.method_2();
			}
			if (class167_0.method_1() != 0)
			{
				throw new MySqlException(getString_0(107375893), isFatal: true, null);
			}
			class167_0.method_8();
			class167_0.method_8();
			if (class167_0.HasMoreData)
			{
				enum38_0 = (Enum38)class167_0.method_13(2);
				class167_0.method_13(2);
				if (class167_0.HasMoreData)
				{
					class167_0.method_20();
				}
			}
		}
		catch (MySqlException mySqlException_)
		{
			method_0(mySqlException_);
			throw;
		}
	}

	public void imethod_10(string string_0)
	{
		byte[] bytes = Encoding.GetBytes(string_0);
		class167_0.method_0();
		class167_0.method_3(2);
		class167_0.method_4(bytes);
		method_10(class167_0);
		method_4(bool_0: true);
	}

	public void imethod_0()
	{
		class168_0.MaxPacketSize = (ulong)class143_0.MaxPacketSize;
		class168_0.Encoding = Encoding;
	}

	public void imethod_1()
	{
		try
		{
			stream_0 = Class134.smethod_1(Settings);
			if (Settings.IncludeSecurityAsserts)
			{
				Class155.smethod_0(bool_0: false).Assert();
			}
		}
		catch (SecurityException)
		{
			throw;
		}
		catch (Exception inner)
		{
			throw new MySqlException(Class121.UnableToConnectToHost, 1042, inner);
		}
		if (stream_0 == null)
		{
			throw new MySqlException(Class121.UnableToConnectToHost, 1042);
		}
		int num = 16581375;
		class168_0 = new Class168(stream_0, Encoding, bool_0: false);
		class168_0.method_1((int)(Settings.ConnectionTimeout * 1000));
		class167_0 = class168_0.method_2();
		class167_0.method_1();
		string string_ = class167_0.method_23();
		struct23_0 = Struct23.smethod_0(string_);
		int_0 = class167_0.method_13(4);
		byte[] array = class167_0.method_25();
		num = 16777215;
		Enum37 @enum = (Enum37)0uL;
		if (class167_0.HasMoreData)
		{
			@enum = (Enum37)class167_0.method_13(2);
		}
		class143_0.ConnectionCharSetIndex = class167_0.method_1();
		enum38_0 = (Enum38)class167_0.method_13(2);
		uint num2 = (uint)class167_0.method_13(2);
		@enum = (Enum37)((ulong)@enum | (ulong)(num2 << 16));
		class167_0.Position += 11;
		byte[] array2 = class167_0.method_25();
		byte_0 = new byte[array.Length + array2.Length];
		array.CopyTo(byte_0, 0);
		array2.CopyTo(byte_0, array.Length);
		string text = getString_0(107399193);
		text = (((@enum & Enum37.flag_19) == (Enum37)0uL) ? getString_0(107409417) : class167_0.method_23());
		method_5(@enum);
		class167_0.method_0();
		class167_0.method_14((int)enum37_0, 4);
		class167_0.method_14(num, 4);
		class167_0.method_3(33);
		class167_0.method_4(new byte[23]);
		if ((@enum & Enum37.flag_11) == (Enum37)0uL)
		{
			if (Settings.SslMode != 0)
			{
				throw new MySqlException(string.Format(Class121.NoServerSSLSupport, Settings.Server));
			}
		}
		else if (Settings.SslMode != 0)
		{
			class168_0.method_4(class167_0);
			class168_0 = new Class133(Settings).method_1(ref stream_0, Encoding, Settings.ToString());
			class167_0.method_0();
			class167_0.method_14((int)enum37_0, 4);
			class167_0.method_14(num, 4);
			class167_0.method_3(33);
			class167_0.method_4(new byte[23]);
		}
		method_6(text, bool_0: false);
		if ((enum37_0 & Enum37.flag_5) != (Enum37)0uL)
		{
			class168_0 = new Class168(stream_0, Encoding, bool_0: true);
		}
		class167_0.Version = struct23_0;
		class168_0.MaxBlockSize = num;
	}

	private void method_5(Enum37 enum37_1)
	{
		Enum37 @enum = Enum37.flag_7;
		if (!Settings.UseAffectedRows)
		{
			@enum |= Enum37.flag_1;
		}
		@enum |= Enum37.flag_9;
		@enum |= Enum37.flag_13;
		if (Settings.AllowBatch)
		{
			@enum |= Enum37.flag_16;
		}
		@enum |= Enum37.flag_17;
		if ((enum37_1 & Enum37.flag_2) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_2;
		}
		if ((enum37_1 & Enum37.flag_5) != (Enum37)0uL && Settings.UseCompression)
		{
			@enum |= Enum37.flag_5;
		}
		@enum |= Enum37.flag_0;
		if (Settings.InteractiveSession)
		{
			@enum |= Enum37.flag_10;
		}
		if ((enum37_1 & Enum37.flag_3) != (Enum37)0uL && Settings.Database != null && Settings.Database.Length > 0)
		{
			@enum |= Enum37.flag_3;
		}
		if ((enum37_1 & Enum37.flag_15) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_15;
		}
		if ((enum37_1 & Enum37.flag_11) != (Enum37)0uL && Settings.SslMode != 0)
		{
			@enum |= Enum37.flag_11;
		}
		if ((enum37_1 & Enum37.flag_18) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_18;
		}
		if ((enum37_1 & Enum37.flag_19) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_19;
		}
		if ((enum37_1 & Enum37.flag_20) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_20;
		}
		if ((enum37_1 & Enum37.flag_21) != (Enum37)0uL)
		{
			@enum |= Enum37.flag_21;
		}
		enum37_0 = @enum;
	}

	public void method_6(string string_0, bool bool_0)
	{
		if (string_0 != null)
		{
			if (Settings.IntegratedSecurity)
			{
				string_0 = getString_0(107375860);
			}
			class112_0 = Class112.smethod_0(string_0, this, byte_0);
		}
		class112_0.method_0(bool_0);
	}

	public void imethod_11()
	{
		int_1 = 0;
		class168_0.Encoding = Encoding;
		class168_0.SequenceByte = 0;
		class167_0.method_0();
		class167_0.method_3(17);
		method_6(null, bool_0: true);
	}

	public void imethod_2(Class167 class167_1)
	{
		int_1 = 0;
		class167_1.method_7(4L, 3);
		method_10(class167_1);
		enum38_0 |= Enum38.flag_3;
	}

	public void imethod_3(bool bool_0)
	{
		try
		{
			if (bool_0)
			{
				try
				{
					class167_0.method_0();
					class167_0.method_3(1);
					method_10(class167_0);
				}
				catch (Exception ex)
				{
					MySqlTrace.smethod_4(ThreadId, ex.ToString());
				}
			}
			if (class168_0 != null)
			{
				class168_0.method_0();
			}
			class168_0 = null;
		}
		catch (Exception)
		{
		}
	}

	public bool imethod_4()
	{
		try
		{
			class167_0.method_0();
			class167_0.method_3(14);
			method_10(class167_0);
			method_4(bool_0: true);
			return true;
		}
		catch (Exception)
		{
			class143_0.vmethod_1();
			return false;
		}
	}

	public int imethod_5(ref int int_2, ref long long_0)
	{
		try
		{
			class167_0 = class168_0.method_2();
		}
		catch (TimeoutException)
		{
			throw;
		}
		catch (Exception)
		{
			enum38_0 &= ~(Enum38.flag_2 | Enum38.flag_3);
			throw;
		}
		int num = (int)class167_0.method_8();
		if (-1 == num)
		{
			string string_ = class167_0.method_23();
			method_7(string_);
			return imethod_5(ref int_2, ref long_0);
		}
		if (num == 0)
		{
			enum38_0 &= ~(Enum38.flag_2 | Enum38.flag_3);
			int_2 = (int)class167_0.method_8();
			long_0 = class167_0.method_8();
			enum38_0 = (Enum38)class167_0.method_13(2);
			int_1 += class167_0.method_13(2);
			if (class167_0.HasMoreData)
			{
				class167_0.method_20();
			}
		}
		return num;
	}

	private void method_7(string string_0)
	{
		byte[] array = new byte[8196];
		long num = 0L;
		try
		{
			using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			num = fileStream.Length;
			while (num > 0L)
			{
				int num2 = fileStream.Read(array, 4, (int)((num > 8192L) ? 8192L : num));
				class168_0.method_5(array, num2);
				num -= num2;
			}
			class168_0.method_5(array, 0);
		}
		catch (Exception ex)
		{
			throw new MySqlException(getString_0(107375819), ex);
		}
	}

	private void method_8(int int_2)
	{
		bitArray_0 = null;
		byte[] array = new byte[(int_2 + 9) / 8];
		class167_0.method_1();
		class167_0.method_2(array, 0, array.Length);
		bitArray_0 = new BitArray(array);
	}

	public Interface0 imethod_12(int int_2, Class145 class145_0, Interface0 interface0_0)
	{
		long num = -1L;
		bool bool_;
		if (bitArray_0 != null)
		{
			bool_ = bitArray_0[int_2 + 2];
		}
		else
		{
			num = class167_0.method_8();
			bool_ = num == -1L;
		}
		class167_0.Encoding = class145_0.encoding_0;
		class167_0.Version = struct23_0;
		return interface0_0.imethod_1(class167_0, num, bool_);
	}

	public void imethod_13(Interface0 interface0_0)
	{
		int num = -1;
		if (bitArray_0 == null)
		{
			num = (int)class167_0.method_8();
			if (num == -1)
			{
				return;
			}
		}
		if (num > -1)
		{
			class167_0.Position += num;
		}
		else
		{
			interface0_0.imethod_2(class167_0);
		}
	}

	public void imethod_14(Class145[] class145_0)
	{
		for (int i = 0; i < class145_0.Length; i++)
		{
			method_9(class145_0[i]);
		}
		method_12();
	}

	private void method_9(Class145 class145_0)
	{
		class168_0.Encoding = Encoding;
		class167_0 = class168_0.method_2();
		class145_0.encoding_0 = Encoding;
		class145_0.string_0 = class167_0.method_20();
		class145_0.string_5 = class167_0.method_20();
		class145_0.string_3 = class167_0.method_20();
		class145_0.string_4 = class167_0.method_20();
		class145_0.string_1 = class167_0.method_20();
		class145_0.string_2 = class167_0.method_20();
		class167_0.method_1();
		class145_0.CharacterSetIndex = class167_0.method_13(2);
		class145_0.int_0 = class167_0.method_13(4);
		MySqlDbType mySqlDbType = (MySqlDbType)class167_0.method_1();
		Enum35 @enum = (Enum35)(((enum37_0 & Enum37.flag_2) == (Enum37)0uL) ? class167_0.method_1() : class167_0.method_13(2));
		class145_0.Scale = class167_0.method_1();
		if (class167_0.HasMoreData)
		{
			class167_0.method_13(2);
		}
		if (mySqlDbType == MySqlDbType.Decimal || mySqlDbType == MySqlDbType.NewDecimal)
		{
			class145_0.Precision = (((@enum & Enum35.flag_5) != 0) ? ((byte)class145_0.int_0) : ((byte)(class145_0.int_0 - 1)));
			if (class145_0.Scale != 0)
			{
				class145_0.Precision--;
			}
		}
		class145_0.method_0(mySqlDbType, @enum);
	}

	private void method_10(Class167 class167_1)
	{
		try
		{
			int_1 = 0;
			class168_0.SequenceByte = 0;
			class168_0.method_4(class167_1);
		}
		catch (MySqlException mySqlException_)
		{
			method_0(mySqlException_);
			throw;
		}
	}

	public void imethod_8(Class167 class167_1)
	{
		int_1 = 0;
		class167_1.method_7(4L, 23);
		method_10(class167_1);
		enum38_0 |= Enum38.flag_3;
	}

	private void method_11()
	{
		if (!class167_0.IsLastPacket)
		{
			throw new MySqlException(getString_0(107375738));
		}
		class167_0.method_1();
		if (class167_0.HasMoreData)
		{
			int_1 += class167_0.method_13(2);
			enum38_0 = (Enum38)class167_0.method_13(2);
		}
	}

	private void method_12()
	{
		class167_0 = class168_0.method_2();
		method_11();
	}

	public int imethod_7(string string_0, ref Class145[] class145_0)
	{
		class167_0.Length = string_0.Length * 4 + 5;
		byte[] buffer = class167_0.Buffer;
		int bytes = Encoding.GetBytes(string_0, 0, string_0.Length, class167_0.Buffer, 5);
		class167_0.Position = bytes + 5;
		buffer[4] = 22;
		method_10(class167_0);
		class167_0 = class168_0.method_2();
		if (class167_0.method_1() != 0)
		{
			throw new MySqlException(getString_0(107375733));
		}
		int result = class167_0.method_13(4);
		int num = class167_0.method_13(2);
		int num2 = class167_0.method_13(2);
		class167_0.method_13(3);
		if (num2 > 0)
		{
			class145_0 = class143_0.method_6(num2);
			for (int i = 0; i < class145_0.Length; i++)
			{
				class145_0[i].encoding_0 = Encoding;
			}
		}
		if (num > 0)
		{
			while (num-- > 0)
			{
				class167_0 = class168_0.method_2();
			}
			method_12();
		}
		return result;
	}

	public bool imethod_6(int int_2, int int_3)
	{
		class167_0 = class168_0.method_2();
		if (class167_0.IsLastPacket)
		{
			method_11();
			return false;
		}
		bitArray_0 = null;
		if (int_2 > 0)
		{
			method_8(int_3);
		}
		return true;
	}

	public void imethod_9(int int_2)
	{
		class167_0.method_0();
		class167_0.method_3(25);
		class167_0.method_14(int_2, 4);
		class168_0.SequenceByte = 0;
		class168_0.method_4(class167_0);
	}

	public void imethod_15(int int_2)
	{
		if (class168_0 != null)
		{
			class168_0.method_1(int_2);
		}
	}

	internal void method_13()
	{
		if ((enum37_0 & Enum37.flag_20) == (Enum37)0uL)
		{
			return;
		}
		string text = string.Empty;
		Class165 @class = new Class165();
		PropertyInfo[] properties = @class.GetType().GetProperties();
		foreach (PropertyInfo obj in properties)
		{
			string text2 = obj.Name;
			object[] customAttributes = obj.GetCustomAttributes(typeof(DisplayNameAttribute), inherit: false);
			if (customAttributes.Length != 0)
			{
				text2 = (customAttributes[0] as DisplayNameAttribute).DisplayName;
			}
			string text3 = (string)obj.GetValue(@class, null);
			text += string.Format(getString_0(107406234), (char)text2.Length, text2);
			text += string.Format(getString_0(107406234), (char)text3.Length, text3);
		}
		class167_0.method_17(text);
	}

	static Class169()
	{
		Strings.CreateGetStringDelegate(typeof(Class169));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399371), getString_0(107399366)).Replace(getString_0(107399329), getString_0(107399324)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399319)))
		{
			throw new SecurityException(getString_0(107399294));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
