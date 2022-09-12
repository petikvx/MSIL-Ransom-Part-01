using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using ns0;
using ns10;
using ns14;
using ns3;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns13;

internal static class Class8
{
	[CompilerGenerated]
	private static Func<Class36>? func_0;

	public static readonly string string_0 = "true";

	public static readonly string string_1 = "false";

	public static readonly string string_2 = "null";

	public static readonly string string_3 = "undefined";

	public static readonly string string_4 = "Infinity";

	public static readonly string string_5 = "-Infinity";

	public static readonly string string_6 = "NaN";

	public static Func<Class36>? DefaultSettings
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
		return Class7.smethod_660((double)float_0, float_0.ToString("R", CultureInfo.InvariantCulture));
	}

	internal static string smethod_8(float float_0, Enum5 enum5_0, char char_0, bool bool_0)
	{
		return smethod_9(float_0, Class7.smethod_660((double)float_0, float_0.ToString("R", CultureInfo.InvariantCulture)), enum5_0, char_0, bool_0);
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
		return Class7.smethod_660(double_0, double_0.ToString("R", CultureInfo.InvariantCulture));
	}

	internal static string smethod_11(double double_0, Enum5 enum5_0, char char_0, bool bool_0)
	{
		return smethod_9(double_0, Class7.smethod_660(double_0, double_0.ToString("R", CultureInfo.InvariantCulture)), enum5_0, char_0, bool_0);
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
		return Class7.smethod_767(decimal_0.ToString(null, CultureInfo.InvariantCulture));
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
	public static string smethod_18(object? object_0, params Class9[] class9_0)
	{
		Class36 class36_ = ((class9_0 == null || class9_0.Length == 0) ? null : new Class36
		{
			Converters = class9_0
		});
		return smethod_21(object_0, null, class36_);
	}

	[DebuggerStepThrough]
	public static string smethod_19(object? object_0, Enum7 enum7_0, params Class9[] class9_0)
	{
		Class36 class36_ = ((class9_0 == null || class9_0.Length == 0) ? null : new Class36
		{
			Converters = class9_0
		});
		return smethod_23(object_0, null, enum7_0, class36_);
	}

	[DebuggerStepThrough]
	public static string smethod_20(object? object_0, Class36? class36_0)
	{
		return smethod_21(object_0, null, class36_0);
	}

	[DebuggerStepThrough]
	public static string smethod_21(object? object_0, Type? type_0, Class36? class36_0)
	{
		Class34 class34_ = Class7.smethod_380(class36_0);
		return Class7.smethod_69(class34_, type_0, object_0);
	}

	[DebuggerStepThrough]
	public static string smethod_22(object? object_0, Enum7 enum7_0, Class36? class36_0)
	{
		return smethod_23(object_0, null, enum7_0, class36_0);
	}

	[DebuggerStepThrough]
	public static string smethod_23(object? object_0, Type? type_0, Enum7 enum7_0, Class36? class36_0)
	{
		Class34 @class = Class7.smethod_380(class36_0);
		@class.Formatting = enum7_0;
		return Class7.smethod_69(@class, type_0, object_0);
	}

	[DebuggerStepThrough]
	public static object? smethod_24(string string_7)
	{
		return smethod_33(string_7, null, null);
	}

	[DebuggerStepThrough]
	public static object? smethod_25(string string_7, Class36 class36_0)
	{
		return smethod_33(string_7, null, class36_0);
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
	public static T? smethod_29<T>(string string_7, T gparam_0, Class36 class36_0)
	{
		return smethod_31<T>(string_7, class36_0);
	}

	[DebuggerStepThrough]
	public static T? smethod_30<T>(string string_7, params Class9[] class9_0)
	{
		return (T)smethod_32(string_7, typeof(T), class9_0);
	}

	[DebuggerStepThrough]
	public static T? smethod_31<T>(string string_7, Class36? class36_0)
	{
		return (T)smethod_33(string_7, typeof(T), class36_0);
	}

	[DebuggerStepThrough]
	public static object? smethod_32(string string_7, Type type_0, params Class9[] class9_0)
	{
		Class36 class36_ = ((class9_0 == null || class9_0.Length == 0) ? null : new Class36
		{
			Converters = class9_0
		});
		return smethod_33(string_7, type_0, class36_);
	}

	public static object? smethod_33(string string_7, Type? type_0, Class36? class36_0)
	{
		Class113.smethod_0(string_7, "value");
		Class34 @class = Class7.smethod_380(class36_0);
		if (!Class7.smethod_676(@class))
		{
			@class.CheckAdditionalContent = true;
		}
		using Class30 class29_ = new Class30(new StringReader(string_7));
		return @class.method_5(class29_, type_0);
	}

	[DebuggerStepThrough]
	public static void smethod_34(string string_7, object object_0)
	{
		Class7.smethod_269((Class36)null, object_0, string_7);
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
		Class27 @class = new Class27();
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
		Class27 @class = new Class27();
		@class.DeserializeRootElementName = string_8;
		@class.WriteArrayAttribute = bool_0;
		@class.EncodeSpecialCharacters = bool_1;
		return (XDocument)smethod_32(string_7, typeof(XDocument), @class);
	}
}
