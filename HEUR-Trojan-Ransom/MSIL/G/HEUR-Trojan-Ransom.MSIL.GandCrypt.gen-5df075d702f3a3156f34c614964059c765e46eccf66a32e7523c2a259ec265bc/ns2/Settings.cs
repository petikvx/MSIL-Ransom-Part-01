using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Globalization;
using System.Runtime.CompilerServices;
using ns1;

namespace ns2;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings settings_0 = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => settings_0;

	unsafe static void abufimakeg6()
	{
		//IL_002c: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Ref, but got Unknown
		//IL_011d: Expected O, but got I4
		//IL_0126: Expected Ref, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Ref, but got Unknown
		//IL_02bf: Expected O, but got I4
		//IL_02d7: Expected O, but got I4
		//IL_02f5: Expected O, but got I4
		//IL_0320: Expected O, but got I4
		//IL_032f: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		do
		{
			try
			{
				_ = (Resources)(object)Control4.smethod_1((byte[])(object)((byte*)180)->ToString());
			}
			catch
			{
				text = "F";
				_ = byte.Parse(text, null) is Settings;
			}
		}
		while ((byte)text.ToCharArray() != 0);
		string text2 = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		_ = (CultureInfo)(object)((byte*)checked(unchecked((uint)b) * 28u))->ToString((IFormatProvider?)null);
		CultureInfo cultureInfo = cultureInfo;
		b = (byte)Control4.smethod_1((byte[])(object)text2.ToLower(cultureInfo));
		byte num = b;
		string s = (string)(object)Default;
		string strA = text.ToUpper();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		uint num2 = checked(0u * (flag ? 1u : 0u));
		flag = (byte)num2 != 0;
		object obj2 = (((byte*)191)->Equals(byte.Parse(s, string.Compare(strA, "TPK", (byte)num2 != 0) as IFormatProvider) as object) as string)[1939866462];
		_003F val;
		string text3;
		char[] anyOf;
		checked
		{
			val = num * ((obj2 is byte) ? obj2 : null) * unchecked((byte)(text + (byte.TryParse(text, out *(byte*)null) as string) + (byte.TryParse(text, out *(byte*)null) as string)));
			text3 = text;
			char[] array = array;
			anyOf = array;
		}
		byte num3 = (byte)Control4.smethod_1(null);
		b = 228;
		ref _003F reference = ref *(_003F*)val;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		object obj3 = ((byte*)b2)->Equals(228);
		_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo(text3.IndexOfAny(anyOf, 1058530146, ((byte*)checked(num3 + ((obj3 is byte) ? obj3 : null)))->CompareTo(null)) as object) is Class1;
		try
		{
			try
			{
			}
			finally
			{
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
				text = text4;
				goto end_IL_012c;
			}
			end_IL_012c:;
		}
		finally
		{
			try
			{
			}
			finally
			{
				goto IL_013f;
			}
		}
		IL_0327:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		Control2 control = Control1.smethod_0(resolveEventArgs_) as Control2;
		control = control;
		Struct2 @struct = default(Struct2);
		return;
		IL_013f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
		try
		{
			try
			{
				_ = (byte)Default;
			}
			finally
			{
				goto end_IL_0140;
			}
			end_IL_0140:;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
			while (true)
			{
				string text5 = text;
				string value = text;
				stringComparison = stringComparison;
				string value2 = "ZEKD".Equals(value, stringComparison) as string;
				stringComparison = default(StringComparison);
				_ = text5.IndexOf(value2, stringComparison) is Class1;
				byte num4 = (byte)Control4.smethod_1(null);
				string format = text;
				object arg = null;
				_ = (Class1)(object)((byte*)(byte)Class4.smethod_0(null, (ResolveEventArgs)(object)((byte*)num4)->ToString((IFormatProvider)(object)string.Format(format, null, arg, null))))->ToString("YZUSB");
				array2 = array2;
				_ = (Class1)(object)Control4.smethod_1(array2);
				if (checked(1u - (flag ? 1u : 0u)) != 0)
				{
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		try
		{
			void @void = text.Normalize();
			void void2 = void2;
			void2 = @void;
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
			byte num7;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
			uint num8;
			ref _003F reference2;
			object obj5;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string value4);
			do
			{
				byte num5 = b;
				b = b;
				string format2 = (string)(object)Class4.smethod_0(null, ((byte*)5)->Equals(null) as ResolveEventArgs);
				arg = arg;
				uint num6;
				object object_;
				checked
				{
					num6 = unchecked((uint)num5) * unchecked((uint)checked(b3 - unchecked((byte)Class4.smethod_0(string.Format(format2, arg2), null))));
					numberStyles = numberStyles;
					num7 = byte.Parse("XEJAI", style);
					num8 = unchecked((uint)(byte)Control4.smethod_1(array2)) - 120u;
					text = "QZQGGR";
					object_ = byte.Parse((string)(object)Control4.smethod_1(array2)) as object;
					resolveEventArgs_ = null;
				}
				char value3 = (char)Class4.smethod_0(object_, resolveEventArgs_);
				string text6 = text;
				text = "GZ";
				reference2 = ref *(_003F*)num6;
				obj5 = text7.LastIndexOf(value3, text6.IndexOf(value4), 1704724438);
			}
			while (System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).CompareTo((byte)checked(num7 + unchecked(num8 / (byte)((byte*)checked(((obj5 is byte) ? obj5 : null) - b))->ToString("WTV", formatProvider)))) is bool);
		}
		try
		{
		}
		catch
		{
		}
		object obj8 = ((byte*)b)->GetHashCode();
		object obj9 = ((obj8 is Struct2) ? obj8 : null);
		@struct = @struct;
		@struct = (Struct2)obj9;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Class4 @class);
			while (true)
			{
				flag = flag;
				if (flag2)
				{
					do
					{
						Class4 obj10 = (Class4)(object)Default;
						_ = byte.Parse(text) is Class4;
						@class = @class;
						@class = obj10;
					}
					while (checked((flag ? 1u : 0u) - 1u) != 0);
					continue;
				}
				break;
			}
		}
		finally
		{
			_ = byte.Parse(text, default(NumberStyles), formatProvider) is Class0;
			goto IL_0327;
		}
	}
}
