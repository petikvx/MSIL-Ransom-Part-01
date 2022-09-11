using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns20;
using ns22;
using ns6;

namespace ns14;

internal struct Struct8 : Interface0
{
	[CompilerGenerated]
	private readonly bool bool_0;

	[CompilerGenerated]
	private sbyte sbyte_0;

	[CompilerGenerated]
	private bool bool_1;

	[NonSerialized]
	internal static GetString getString_0;

	public bool IsNull
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
	}

	MySqlDbType Interface0.MySqlDbType => MySqlDbType.Byte;

	object Interface0.Value
	{
		get
		{
			if (TreatAsBoolean)
			{
				return Convert.ToBoolean(Value);
			}
			return Value;
		}
	}

	public sbyte Value
	{
		[CompilerGenerated]
		get
		{
			return sbyte_0;
		}
		[CompilerGenerated]
		set
		{
			sbyte_0 = value;
		}
	}

	Type Interface0.SystemType
	{
		get
		{
			if (!TreatAsBoolean)
			{
				return typeof(sbyte);
			}
			return typeof(bool);
		}
	}

	string Interface0.MySqlTypeName => getString_0(107408521);

	internal bool TreatAsBoolean
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public Struct8(bool bool_2)
	{
		bool_0 = bool_2;
		Value = 0;
		TreatAsBoolean = false;
	}

	public Struct8(sbyte sbyte_1)
	{
		bool_0 = false;
		Value = sbyte_1;
		TreatAsBoolean = false;
	}

	void Interface0.imethod_0(Class167 class167_0, bool bool_2, object object_0, int int_0)
	{
		sbyte b = (object_0 as sbyte?) ?? Convert.ToSByte(object_0);
		if (bool_2)
		{
			class167_0.method_3((byte)b);
		}
		else
		{
			class167_0.method_18(b.ToString());
		}
	}

	Interface0 Interface0.imethod_1(Class167 class167_0, long long_0, bool bool_2)
	{
		if (bool_2)
		{
			return new Struct8(bool_2: true);
		}
		if (long_0 == -1L)
		{
			return new Struct8((sbyte)class167_0.method_1());
		}
		string s = class167_0.method_22(long_0);
		Struct8 @struct = new Struct8(sbyte.Parse(s, NumberStyles.Any, CultureInfo.InvariantCulture));
		@struct.TreatAsBoolean = TreatAsBoolean;
		return @struct;
	}

	void Interface0.imethod_2(Class167 class167_0)
	{
		class167_0.method_1();
	}

	internal static void smethod_0(Class176 class176_0)
	{
		Class177 @class = class176_0.method_4();
		@class[getString_0(107359315)] = getString_0(107408521);
		@class[getString_0(107359334)] = MySqlDbType.Byte;
		@class[getString_0(107359281)] = 0;
		@class[getString_0(107359296)] = getString_0(107408521);
		@class[getString_0(107359247)] = null;
		@class[getString_0(107359222)] = getString_0(107358830);
		@class[getString_0(107358676)] = true;
		@class[getString_0(107358647)] = true;
		@class[getString_0(107358662)] = false;
		@class[getString_0(107358609)] = true;
		@class[getString_0(107358620)] = true;
		@class[getString_0(107358591)] = false;
		@class[getString_0(107358550)] = true;
		@class[getString_0(107358565)] = true;
		@class[getString_0(107358516)] = false;
		@class[getString_0(107358487)] = false;
		@class[getString_0(107358502)] = 0;
		@class[getString_0(107358453)] = 0;
		@class[getString_0(107358468)] = DBNull.Value;
		@class[getString_0(107358923)] = false;
		@class[getString_0(107358898)] = null;
		@class[getString_0(107358904)] = null;
		@class[getString_0(107358883)] = null;
	}

	static Struct8()
	{
		Strings.CreateGetStringDelegate(typeof(Struct8));
	}
}
