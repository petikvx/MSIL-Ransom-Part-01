using System;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;
using ns20;
using ns21;
using ns22;
using ns6;

namespace ns11;

internal struct Struct12 : Interface0
{
	[CompilerGenerated]
	private readonly byte[] byte_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private Guid guid_0;

	[NonSerialized]
	internal static GetString getString_0;

	public byte[] Bytes
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	public bool OldGuids
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		private set
		{
			bool_1 = value;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Guid;

	object Interface0.Value => Value;

	public Guid Value
	{
		[CompilerGenerated]
		get
		{
			return guid_0;
		}
		[CompilerGenerated]
		private set
		{
			guid_0 = value;
		}
	}

	Type Interface0.SystemType => typeof(Guid);

	string Interface0.MySqlTypeName
	{
		get
		{
			if (!OldGuids)
			{
				return getString_0(107357672);
			}
			return getString_0(107357659);
		}
	}

	public Struct12(byte[] byte_1)
	{
		OldGuids = false;
		Value = new Guid(byte_1);
		IsNull = false;
		byte_0 = byte_1;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_2, object object_0, int int_0)
	{
		Guid guid_ = Guid.Empty;
		string text = object_0 as string;
		byte[] array = object_0 as byte[];
		if (object_0 is Guid)
		{
			guid_ = (Guid)object_0;
		}
		else
		{
			try
			{
				if (text != null)
				{
					guid_ = new Guid(text);
				}
				else if (array != null)
				{
					guid_ = new Guid(array);
				}
			}
			catch (Exception ex)
			{
				throw new MySqlException(Class121.DataNotInSupportedFormat, ex);
			}
		}
		if (OldGuids)
		{
			method_1(class167_0, guid_, bool_2);
			return;
		}
		guid_.ToString(getString_0(107357610));
		if (bool_2)
		{
			class167_0.method_17(guid_.ToString(getString_0(107357610)));
		}
		else
		{
			class167_0.method_18(getString_0(107408168) + MySqlHelper.smethod_31(guid_.ToString(getString_0(107357610))) + getString_0(107408168));
		}
	}

	private void method_1(Class167 class167_0, Guid guid_1, bool bool_2)
	{
		byte[] array = guid_1.ToByteArray();
		if (bool_2)
		{
			class167_0.method_16(array.Length);
			class167_0.method_4(array);
			return;
		}
		class167_0.method_18(getString_0(107359408));
		class167_0.method_3(39);
		smethod_0(array, array.Length, class167_0);
		class167_0.method_3(39);
	}

	private static void smethod_0(byte[] byte_1, int int_0, Class167 class167_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			byte b = byte_1[i];
			switch (b)
			{
			case 0:
				class167_0.method_3(92);
				class167_0.method_3(48);
				break;
			default:
				class167_0.method_3(b);
				break;
			case 34:
			case 39:
			case 92:
				class167_0.method_3(92);
				class167_0.method_3(b);
				break;
			}
		}
	}

	private Struct12 method_2(Class167 class167_0, long long_0)
	{
		if (long_0 == -1L)
		{
			long_0 = class167_0.method_8();
		}
		byte[] byte_ = new byte[long_0];
		class167_0.method_2(byte_, 0, (int)long_0);
		Struct12 result = new Struct12(byte_);
		result.OldGuids = OldGuids;
		return result;
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_2)
	{
		Struct12 @struct = default(Struct12);
		@struct.IsNull = true;
		@struct.OldGuids = OldGuids;
		if (!bool_2)
		{
			if (OldGuids)
			{
				return method_2(class167_0, long_0);
			}
			string empty = string.Empty;
			empty = ((long_0 != -1L) ? class167_0.method_22(long_0) : class167_0.method_20());
			@struct.Value = new Guid(empty);
			@struct.IsNull = false;
		}
		return @struct;
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		int num = (int)class167_0.method_8();
		class167_0.Position += num;
	}

	public static void smethod_1(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359348)] = getString_0(107357637);
		@class[getString_0(107359367)] = MySqlDbType.Guid;
		@class[getString_0(107359314)] = 0;
		@class[getString_0(107359329)] = getString_0(107357659);
		@class[getString_0(107359280)] = null;
		@class[getString_0(107359255)] = getString_0(107357628);
		@class[getString_0(107358709)] = false;
		@class[getString_0(107358680)] = true;
		@class[getString_0(107358695)] = false;
		@class[getString_0(107358642)] = true;
		@class[getString_0(107358653)] = true;
		@class[getString_0(107358624)] = false;
		@class[getString_0(107358583)] = true;
		@class[getString_0(107358598)] = false;
		@class[getString_0(107358549)] = false;
		@class[getString_0(107358520)] = false;
		@class[getString_0(107358535)] = 0;
		@class[getString_0(107358486)] = 0;
		@class[getString_0(107358501)] = DBNull.Value;
		@class[getString_0(107358956)] = false;
		@class[getString_0(107358931)] = null;
		@class[getString_0(107358937)] = null;
		@class[getString_0(107358916)] = null;
	}

	static Struct12()
	{
		Strings.CreateGetStringDelegate(typeof(Struct12));
	}
}
