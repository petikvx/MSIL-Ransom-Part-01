using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns10;
using ns11;
using ns13;
using ns14;
using ns15;
using ns16;
using ns17;
using ns19;
using ns2;
using ns20;
using ns21;
using ns26;
using ns3;
using ns4;
using ns5;
using ns8;

namespace ns7;

internal sealed class Class145
{
	public string string_0;

	public int int_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public Encoding encoding_0;

	protected int int_1;

	protected Struct23 struct23_0;

	protected Class143 class143_0;

	protected bool bool_0;

	[CompilerGenerated]
	private MySqlDbType mySqlDbType_0;

	[CompilerGenerated]
	private byte byte_0;

	[CompilerGenerated]
	private byte byte_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private Enum35 enum35_0;

	[CompilerGenerated]
	private readonly List<Type> list_0 = new List<Type>();

	[NonSerialized]
	internal static GetString getString_0;

	public int CharacterSetIndex
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			method_4();
		}
	}

	public MySqlDbType Type
	{
		[CompilerGenerated]
		get
		{
			return mySqlDbType_0;
		}
		[CompilerGenerated]
		protected set
		{
			mySqlDbType_0 = value;
		}
	}

	public byte Precision
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
		[CompilerGenerated]
		set
		{
			byte_0 = value;
		}
	}

	public byte Scale
	{
		[CompilerGenerated]
		get
		{
			return byte_1;
		}
		[CompilerGenerated]
		set
		{
			byte_1 = value;
		}
	}

	public int MaxLength
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public Enum35 Flags
	{
		[CompilerGenerated]
		get
		{
			return enum35_0;
		}
		[CompilerGenerated]
		protected set
		{
			enum35_0 = value;
		}
	}

	public bool IsAutoIncrement => (Flags & Enum35.flag_9) > (Enum35)0;

	public bool IsNumeric => (Flags & Enum35.flag_12) > (Enum35)0;

	public bool AllowsNull => (Flags & Enum35.flag_0) == 0;

	public bool IsUnique => (Flags & Enum35.flag_2) > (Enum35)0;

	public bool IsPrimaryKey => (Flags & Enum35.flag_1) > (Enum35)0;

	public bool IsBlob
	{
		get
		{
			if ((Type >= MySqlDbType.TinyBlob && Type <= MySqlDbType.Blob) || (Type >= MySqlDbType.TinyText && Type <= MySqlDbType.Text))
			{
				return true;
			}
			return (Flags & Enum35.flag_4) > (Enum35)0;
		}
	}

	public bool IsBinary
	{
		get
		{
			if (bool_0)
			{
				return CharacterSetIndex == 63;
			}
			return false;
		}
	}

	public bool IsUnsigned => (Flags & Enum35.flag_5) > (Enum35)0;

	public bool IsTextField
	{
		get
		{
			if (Type != MySqlDbType.VarString && Type != MySqlDbType.VarChar && Type != MySqlDbType.String)
			{
				if (Type == MySqlDbType.Guid)
				{
					return !class143_0.Settings.OldGuids;
				}
				return false;
			}
			return true;
		}
	}

	private int CharacterLength => int_0 / MaxLength;

	public List<Type> TypeConversions
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public Class145(Class143 class143_1)
	{
		class143_0 = class143_1;
		struct23_0 = class143_1.Version;
		MaxLength = 1;
		bool_0 = true;
	}

	public void method_0(MySqlDbType mySqlDbType_1, Enum35 enum35_1)
	{
		Flags = enum35_1;
		Type = mySqlDbType_1;
		if (string.IsNullOrEmpty(string_3) && string.IsNullOrEmpty(string_4) && IsBinary && class143_0.Settings.FunctionsReturnString)
		{
			CharacterSetIndex = class143_0.ConnectionCharSetIndex;
		}
		if (IsUnsigned)
		{
			switch (mySqlDbType_1)
			{
			case MySqlDbType.Byte:
				Type = MySqlDbType.UByte;
				return;
			case MySqlDbType.Int16:
				Type = MySqlDbType.UInt16;
				return;
			case MySqlDbType.Int32:
				Type = MySqlDbType.UInt32;
				return;
			case MySqlDbType.Int64:
				Type = MySqlDbType.UInt64;
				return;
			case MySqlDbType.Int24:
				Type = MySqlDbType.UInt24;
				return;
			}
		}
		if (IsBlob)
		{
			if (IsBinary && class143_0.Settings.TreatBlobsAsUTF8)
			{
				bool flag = false;
				Regex regex = class143_0.Settings.method_0();
				Regex regex2 = class143_0.Settings.method_1();
				if (regex != null && regex.IsMatch(string_1))
				{
					flag = true;
				}
				else if (regex == null && regex2 != null && !regex2.IsMatch(string_1))
				{
					flag = true;
				}
				if (flag)
				{
					bool_0 = false;
					encoding_0 = Encoding.GetEncoding(getString_0(107407620));
					int_1 = -1;
					MaxLength = 4;
				}
			}
			if (!IsBinary)
			{
				switch (mySqlDbType_1)
				{
				case MySqlDbType.TinyBlob:
					Type = MySqlDbType.TinyText;
					break;
				case MySqlDbType.MediumBlob:
					Type = MySqlDbType.MediumText;
					break;
				case MySqlDbType.Blob:
					Type = MySqlDbType.Text;
					break;
				case MySqlDbType.LongBlob:
					Type = MySqlDbType.LongText;
					break;
				}
			}
		}
		if (class143_0.Settings.RespectBinaryFlags)
		{
			method_2();
		}
		if (Type == MySqlDbType.String && CharacterLength == 36 && !class143_0.Settings.OldGuids)
		{
			Type = MySqlDbType.Guid;
		}
		if (!IsBinary)
		{
			return;
		}
		if (class143_0.Settings.RespectBinaryFlags)
		{
			switch (mySqlDbType_1)
			{
			case MySqlDbType.String:
				Type = MySqlDbType.Binary;
				break;
			case MySqlDbType.VarString:
			case MySqlDbType.VarChar:
				Type = MySqlDbType.VarBinary;
				break;
			}
		}
		if (CharacterSetIndex == 63)
		{
			CharacterSetIndex = class143_0.ConnectionCharSetIndex;
		}
		if (Type == MySqlDbType.Binary && int_0 == 16 && class143_0.Settings.OldGuids)
		{
			Type = MySqlDbType.Guid;
		}
	}

	public void method_1(Type type_0)
	{
		if (!TypeConversions.Contains(type_0))
		{
			TypeConversions.Add(type_0);
		}
	}

	private void method_2()
	{
		string text = string.Empty;
		if (string_2 != null)
		{
			text = Class135.smethod_0(string_2);
		}
		if (text.StartsWith(getString_0(107352968), StringComparison.Ordinal))
		{
			bool_0 = false;
		}
	}

	public Interface0 method_3()
	{
		Interface0 @interface = smethod_0(Type);
		if (@interface is Struct8 && int_0 == 1 && class143_0.Settings.TreatTinyAsBoolean)
		{
			Struct8 @struct = (Struct8)(object)@interface;
			@struct.TreatAsBoolean = true;
			@interface = @struct;
		}
		else if (@interface is Struct12 struct2)
		{
			struct2.OldGuids = class143_0.Settings.OldGuids;
			@interface = struct2;
		}
		return @interface;
	}

	public static Interface0 smethod_0(MySqlDbType mySqlDbType_1)
	{
		switch (mySqlDbType_1)
		{
		case MySqlDbType.UByte:
			return default(Struct19);
		case MySqlDbType.UInt16:
			return default(Struct20);
		case MySqlDbType.UInt64:
			return default(Struct22);
		case MySqlDbType.UInt32:
		case MySqlDbType.UInt24:
			return new Struct21(mySqlDbType_1, bool_2: true);
		case MySqlDbType.Geometry:
			return new Struct11(mySqlDbType_1, bool_1: true);
		case MySqlDbType.Decimal:
		case MySqlDbType.NewDecimal:
			return default(Struct9);
		case MySqlDbType.Byte:
			return default(Struct8);
		case MySqlDbType.Int16:
			return default(Struct13);
		case MySqlDbType.Float:
			return default(Struct16);
		case MySqlDbType.Double:
			return default(Struct10);
		case MySqlDbType.Int64:
			return default(Struct15);
		case MySqlDbType.Time:
			return default(Struct18);
		case MySqlDbType.Int32:
		case MySqlDbType.Int24:
		case MySqlDbType.Year:
			return new Struct14(mySqlDbType_1, bool_2: true);
		case MySqlDbType.Timestamp:
		case MySqlDbType.Date:
		case MySqlDbType.DateTime:
		case MySqlDbType.Newdate:
			return new MySqlDateTime(mySqlDbType_1, isNull: true);
		case MySqlDbType.Bit:
			return default(Struct7);
		default:
			throw new MySqlException(getString_0(107352959));
		case MySqlDbType.Guid:
			return default(Struct12);
		case (MySqlDbType)6:
		case MySqlDbType.VarString:
		case MySqlDbType.JSON:
		case MySqlDbType.Enum:
		case MySqlDbType.Set:
		case MySqlDbType.VarChar:
		case MySqlDbType.String:
		case MySqlDbType.TinyText:
		case MySqlDbType.MediumText:
		case MySqlDbType.LongText:
		case MySqlDbType.Text:
			return new Struct17(mySqlDbType_1, bool_1: true);
		case MySqlDbType.TinyBlob:
		case MySqlDbType.MediumBlob:
		case MySqlDbType.LongBlob:
		case MySqlDbType.Blob:
		case MySqlDbType.Binary:
		case MySqlDbType.VarBinary:
			return new Struct6(mySqlDbType_1, bool_1: true);
		}
	}

	private void method_4()
	{
		Dictionary<int, string> characterSets = class143_0.CharacterSets;
		Struct23 version = class143_0.Version;
		if (characterSets != null && characterSets.Count != 0 && CharacterSetIndex != -1 && characterSets[CharacterSetIndex] != null)
		{
			Class138 @class = Class137.smethod_0(version, characterSets[CharacterSetIndex]);
			MaxLength = @class.int_0;
			encoding_0 = Class137.smethod_1(version, characterSets[CharacterSetIndex]);
		}
	}

	static Class145()
	{
		Strings.CreateGetStringDelegate(typeof(Class145));
	}
}
