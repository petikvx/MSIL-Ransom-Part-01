using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using ns1;
using ns13;
using ns16;
using ns3;
using ns5;
using ns8;
using ns9;

namespace ns14;

internal static class Class7
{
	[CompilerGenerated]
	private static Func<Class35>? func_0;

	public static readonly string string_0 = "true";

	public static readonly string string_1 = "false";

	public static readonly string string_2 = "null";

	public static readonly string string_3 = "undefined";

	public static readonly string string_4 = "Infinity";

	public static readonly string string_5 = "-Infinity";

	public static readonly string string_6 = "NaN";

	public static Func<Class35>? DefaultSettings
	{
		[CompilerGenerated]
		get
		{
			return func_0;
		}
		[CompilerGenerated]
		set
		{
			func_0 = value;
		}
	}

	public static string smethod_0(int int_0)
	{
		return int_0.ToString(null, CultureInfo.InvariantCulture);
	}

	public static string smethod_1(short short_0)
	{
		return short_0.ToString(null, CultureInfo.InvariantCulture);
	}

	[CLSCompliant(false)]
	public static string smethod_2(ushort ushort_0)
	{
		return ushort_0.ToString(null, CultureInfo.InvariantCulture);
	}

	[CLSCompliant(false)]
	public static string smethod_3(uint uint_0)
	{
		return uint_0.ToString(null, CultureInfo.InvariantCulture);
	}

	public static string smethod_4(long long_0)
	{
		return long_0.ToString(null, CultureInfo.InvariantCulture);
	}

	internal static string smethod_5(BigInteger bigInteger_0)
	{
		return bigInteger_0.ToString(null, CultureInfo.InvariantCulture);
	}

	[CLSCompliant(false)]
	public static string smethod_6(ulong ulong_0)
	{
		return ulong_0.ToString(null, CultureInfo.InvariantCulture);
	}

	public static string smethod_7(float float_0)
	{
		return Class131.smethod_25((double)float_0, float_0.ToString("R", CultureInfo.InvariantCulture));
	}

	internal static string smethod_8(float float_0, Enum5 enum5_0, char char_0, bool bool_0)
	{
		return smethod_9(float_0, Class131.smethod_25((double)float_0, float_0.ToString("R", CultureInfo.InvariantCulture)), enum5_0, char_0, bool_0);
	}

	private static string smethod_9(double double_0, string string_7, Enum5 enum5_0, char char_0, bool bool_0)
	{
		if (enum5_0 != Enum5.const_1 && (double.IsInfinity(double_0) || double.IsNaN(double_0)))
		{
			if (enum5_0 == Enum5.const_2)
			{
				if (bool_0)
				{
					return string_2;
				}
				return "0.0";
			}
			return char_0 + string_7 + char_0;
		}
		return string_7;
	}

	public static string smethod_10(double double_0)
	{
		return Class131.smethod_25(double_0, double_0.ToString("R", CultureInfo.InvariantCulture));
	}

	internal static string smethod_11(double double_0, Enum5 enum5_0, char char_0, bool bool_0)
	{
		return smethod_9(double_0, Class131.smethod_25(double_0, double_0.ToString("R", CultureInfo.InvariantCulture)), enum5_0, char_0, bool_0);
	}

	public static string smethod_12(byte byte_0)
	{
		return byte_0.ToString(null, CultureInfo.InvariantCulture);
	}

	[CLSCompliant(false)]
	public static string smethod_13(sbyte sbyte_0)
	{
		return sbyte_0.ToString(null, CultureInfo.InvariantCulture);
	}

	public static string smethod_14(decimal decimal_0)
	{
		return Class131.smethod_162(decimal_0.ToString(null, CultureInfo.InvariantCulture));
	}

	internal static string smethod_15(Guid guid_0, char char_0)
	{
		string text = guid_0.ToString("D", CultureInfo.InvariantCulture);
		string text2 = char_0.ToString(CultureInfo.InvariantCulture);
		return text2 + text + text2;
	}

	[DebuggerStepThrough]
	public static string smethod_16(object? object_0)
	{
		return smethod_21(object_0, null, null);
	}

	[DebuggerStepThrough]
	public static string smethod_17(object? object_0, Enum7 enum7_0)
	{
		return smethod_22(object_0, enum7_0, null);
	}

	[DebuggerStepThrough]
	public static string smethod_18(object? object_0, params Class8[] class8_0)
	{
		Class35 class35_ = ((class8_0 == null || class8_0.Length == 0) ? null : new Class35
		{
			Converters = class8_0
		});
		return smethod_21(object_0, null, class35_);
	}

	[DebuggerStepThrough]
	public static string smethod_19(object? object_0, Enum7 enum7_0, params Class8[] class8_0)
	{
		Class35 class35_ = ((class8_0 == null || class8_0.Length == 0) ? null : new Class35
		{
			Converters = class8_0
		});
		return smethod_23(object_0, null, enum7_0, class35_);
	}

	[DebuggerStepThrough]
	public static string smethod_20(object? object_0, Class35? class35_0)
	{
		return smethod_21(object_0, null, class35_0);
	}

	[DebuggerStepThrough]
	public static string smethod_21(object? object_0, Type? type_0, Class35? class35_0)
	{
		Class33 class33_ = Class131.smethod_311(class35_0);
		return Class131.smethod_350(class33_, type_0, object_0);
	}

	[DebuggerStepThrough]
	public static string smethod_22(object? object_0, Enum7 enum7_0, Class35? class35_0)
	{
		return smethod_23(object_0, null, enum7_0, class35_0);
	}

	[DebuggerStepThrough]
	public static string smethod_23(object? object_0, Type? type_0, Enum7 enum7_0, Class35? class35_0)
	{
		Class33 @class = Class131.smethod_311(class35_0);
		@class.Formatting = enum7_0;
		return Class131.smethod_350(@class, type_0, object_0);
	}

	[DebuggerStepThrough]
	public static object? smethod_24(string string_7)
	{
		return smethod_33(string_7, null, null);
	}

	[DebuggerStepThrough]
	public static object? smethod_25(string string_7, Class35 class35_0)
	{
		return smethod_33(string_7, null, class35_0);
	}

	[DebuggerStepThrough]
	public static object? smethod_26(string string_7, Type type_0)
	{
		return smethod_33(string_7, type_0, null);
	}

	[DebuggerStepThrough]
	public static T? smethod_27<T>(string string_7)
	{
		return smethod_31<T>(string_7, null);
	}

	[DebuggerStepThrough]
	public static T? smethod_28<T>(string string_7, T gparam_0)
	{
		return smethod_27<T>(string_7);
	}

	[DebuggerStepThrough]
	public static T? smethod_29<T>(string string_7, T gparam_0, Class35 class35_0)
	{
		return smethod_31<T>(string_7, class35_0);
	}

	[DebuggerStepThrough]
	public static T? smethod_30<T>(string string_7, params Class8[] class8_0)
	{
		return (T)smethod_32(string_7, typeof(T), class8_0);
	}

	[DebuggerStepThrough]
	public static T? smethod_31<T>(string string_7, Class35? class35_0)
	{
		return (T)smethod_33(string_7, typeof(T), class35_0);
	}

	[DebuggerStepThrough]
	public static object? smethod_32(string string_7, Type type_0, params Class8[] class8_0)
	{
		Class35 class35_ = ((class8_0 == null || class8_0.Length == 0) ? null : new Class35
		{
			Converters = class8_0
		});
		return smethod_33(string_7, type_0, class35_);
	}

	public static object? smethod_33(string string_7, Type? type_0, Class35? class35_0)
	{
		Class112.smethod_0(string_7, "value");
		Class33 @class = Class131.smethod_311(class35_0);
		if (!Class131.smethod_192(@class))
		{
			@class.CheckAdditionalContent = true;
		}
		using Class29 class28_ = new Class29(new StringReader(string_7));
		return @class.method_5(class28_, type_0);
	}

	[DebuggerStepThrough]
	public static void smethod_34(string string_7, object object_0)
	{
		Class131.smethod_28((Class35)null, string_7, object_0);
	}

	public static XmlDocument? smethod_35(string string_7, string? string_8)
	{
		return smethod_36(string_7, string_8, bool_0: false);
	}

	public static XmlDocument? smethod_36(string string_7, string? string_8, bool bool_0)
	{
		return smethod_37(string_7, string_8, bool_0, bool_1: false);
	}

	public static XmlDocument? smethod_37(string string_7, string? string_8, bool bool_0, bool bool_1)
	{
		Class26 @class = new Class26();
		@class.DeserializeRootElementName = string_8;
		@class.WriteArrayAttribute = bool_0;
		@class.EncodeSpecialCharacters = bool_1;
		return (XmlDocument)smethod_32(string_7, typeof(XmlDocument), @class);
	}

	public static XDocument? smethod_38(string string_7, string? string_8)
	{
		return smethod_39(string_7, string_8, bool_0: false);
	}

	public static XDocument? smethod_39(string string_7, string? string_8, bool bool_0)
	{
		return smethod_40(string_7, string_8, bool_0, bool_1: false);
	}

	public static XDocument? smethod_40(string string_7, string? string_8, bool bool_0, bool bool_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		Class26 @class = new Class26();
		@class.DeserializeRootElementName = string_8;
		@class.WriteArrayAttribute = bool_0;
		@class.EncodeSpecialCharacters = bool_1;
		return (XDocument)smethod_32(string_7, typeof(XDocument), @class);
	}
}
