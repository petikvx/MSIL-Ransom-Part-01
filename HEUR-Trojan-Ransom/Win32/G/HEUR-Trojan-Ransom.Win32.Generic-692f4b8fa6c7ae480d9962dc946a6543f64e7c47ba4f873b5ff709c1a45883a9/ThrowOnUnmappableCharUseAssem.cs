using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class ThrowOnUnmappableCharUseAssem
{
	private static ResourceManager __9__25_6;

	private static CultureInfo Byte02;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager SetObserved
	{
		get
		{
			int[] array = new int[1] { -564964 };
			if (__9__25_6 == null)
			{
				string string_ = string.Concat(char.ToString('编') + char.ToString('缪') + "缰缭缵缍", char.ToString('缬') + "缗缬", char.ToString('缯') + "缣缲缲缣缠缮缧缁缪缣缰缗缱缧缃缱缱缧缯");
				object[] array2 = new object[(nint)((Array)(object)(char.ToString('\u0349') + "\u0364\u036c")).LongLength];
				array2[0] = '՜';
				array2[array[0] - -564965] = Convert.ToInt32("11111111111111001010010001000001", 2) ^ Convert.ToInt32("37777176711", 8);
				array2[2] = "Օᬉ";
				_003CModule_003E.TryFormatDecimal(ref string_, array2);
				ResourceManager resourceManager = (__9__25_6 = new ResourceManager(string_, typeof(ThrowOnUnmappableCharUseAssem).Assembly));
			}
			return __9__25_6;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Iso3166CountryName
	{
		get
		{
			return Byte02;
		}
		set
		{
			Byte02 = value;
		}
	}

	internal static Bitmap Reverse
	{
		get
		{
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			char[] array = new char[1] { '\u0001' };
			int[] array2 = new int[1] { 22644 };
			ResourceManager setObserved = SetObserved;
			string string_ = "ꉝꉆ";
			object[] array3 = new object[(nint)((Array)(object)(char.ToString('\u0304') + char.ToString('\u031e') + "\u0332\u0330\u0344")).LongLength];
			array3[0] = array2[0];
			array3[(uint)array[0]] = (char)Convert.ToInt32(char.ToString('1') + char.ToString('2') + "630", 8);
			array3[checked(-392841 - Convert.ToInt32("fffa0175", 16))] = 6858;
			array3[3] = string.Concat(char.ToString('\u0952'), char.ToString('Ā'), char.ToString('ý') + char.ToString('\u0093') + "\u0004\u0003\r");
			array3[4] = Convert.ToInt32("110" + char.ToString('1') + "01011110", 2);
			_003CModule_003E.TryFormatDecimal(ref string_, array3);
			object @object = setObserved.GetObject(string_, Byte02);
			return (Bitmap)@object;
		}
	}

	internal ThrowOnUnmappableCharUseAssem()
	{
	}
}
