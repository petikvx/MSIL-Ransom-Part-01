using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using ns0;
using ns1;

namespace ns2;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("", "")]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(Assembly.GetEntryAssembly()!.GetName().Name + ".Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static byte[] Byte_0 => (byte[])ResourceManager_0.GetObject("ႷႥ", cultureInfo_0);

	internal Resources()
	{
	}

	unsafe static void awejudorakaxix10(object object_0, object object_1)
	{
		//IL_0072: Expected O, but got I4
		//IL_0084: Expected Void, but got O
		//IL_00ad: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_012f: Expected I4, but got O
		//IL_0164: Expected O, but got I4
		//IL_017d: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_021a: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_0234: Expected I4, but got O
		//IL_0235: Expected O, but got I4
		//IL_023e: Expected I4, but got O
		//IL_023f: Expected O, but got I4
		//IL_0273: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_029c: Expected I4, but got O
		//IL_02ac: Expected O, but got I4
		//IL_02c9: Expected O, but got I4
		//IL_02d2: Expected I4, but got O
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected I4, but got Unknown
		//IL_02e7: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_033c: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Control2 control);
				do
				{
					control = control;
					control = null;
					text = (string)(object)Control4.smethod_1((byte[])(object)Settings.Default);
				}
				while ((byte)string.Join(text, (object?[])null) != 0);
			}
			catch
			{
				byte[] array = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array2);
				array = array2;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array3);
				array = array3;
				array = null;
				_ = (Class3)(object)Control4.smethod_1(array);
			}
		}
		catch
		{
			Control4.smethod_1(null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		object obj5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		do
		{
			b = b;
			object obj3 = ((byte*)(b / b))->Equals((byte)((byte*)133)->ToString());
			object obj4 = ((obj3 is void) ? obj3 : null);
			void @void = default(void);
			@void = obj4;
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E2;
			_003CModule_003E = null;
			b = b;
			((byte*)b2)->ToString();
			obj5 = byte.Parse(text, (IFormatProvider)(object)Settings.Default);
		}
		while (checked(1 * ((obj5 is bool) ? obj5 : null)) != 0);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		try
		{
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					text = "EA";
					uint num;
					IFormatProvider formatProvider;
					checked
					{
						num = 13u * unchecked((uint)b);
						formatProvider = text.CompareTo(string.IsNullOrWhiteSpace(text) as string) as IFormatProvider;
					}
					string value = ((byte*)num)->ToString(formatProvider);
					string[] array4 = array4;
					string[] separator = array4;
					string s = byte.Parse(text) as string;
					_ = byte.Parse((string)(object)Settings.Default) is IFormatProvider;
					formatProvider = formatProvider;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
					object obj6 = byte.Parse(s, provider);
					char value2 = (char)(int)((obj6 is char) ? obj6 : null);
					int count = "XKSRMUHXJ".LastIndexOf(value2);
					StringSplitOptions stringSplitOptions = stringSplitOptions;
					StringComparison stringComparison = (StringComparison)"FU".Split(separator, count, default(StringSplitOptions));
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
					_ = text2.StartsWith(value, default(StringComparison)) is string;
					text = text;
					obj7 = obj7;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
					obj7 = ((byte*)236)->Equals(obj8) as object;
					System.Runtime.CompilerServices.Unsafe.SkipInit(out string format);
					text = string.Format(format, obj7, Control4.smethod_1(byte.Parse("OJXRKQHKS") as byte[])).GetTypeCode() as string;
					goto end_IL_00b5;
				}
				end_IL_00b5:;
			}
			finally
			{
				goto end_IL_00b4;
			}
			end_IL_00b4:;
		}
		catch
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string format2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref byte result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out GClass0 gClass);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array5);
		while (true)
		{
			try
			{
				_ = ((byte*)248)->GetTypeCode() is byte;
				string s2 = text;
				byte num2 = b;
				IFormatProvider formatProvider = (IFormatProvider)(object)((byte*)146)->ToString(text, (IFormatProvider)(object)((byte*)b)->ToString());
				text = text;
				object arg = obj7;
				obj7 = obj7;
				string s3 = (((byte*)num2)->CompareTo((byte)string.Format(provider2, format2, arg, arg2, obj7)) as string).Length as string;
				string s4 = text;
				numberStyles = numberStyles;
				object obj10 = byte.Parse(s3, (NumberStyles)/*isinst with value type is only supported in some contexts*/);
				text = byte.Parse(s2, (NumberStyles)((obj10 is NumberStyles) ? obj10 : null)) as string;
				text = "SMCSRRH";
				byte num3 = byte.Parse(s5, formatProvider);
				NumberStyles style = (NumberStyles)(text + "MELTO");
				text = text;
				IFormatProvider provider3 = text3.EndsWith(text) as IFormatProvider;
				object obj11 = byte.Parse((string)text.Clone());
				result = ref *(byte*)((obj11 is ref byte) ? obj11 : null);
				object obj12 = byte.TryParse("EFLCSSS", style, provider3, out result);
				b = (byte)(int)((obj12 is byte) ? obj12 : null);
				int num4 = num3 / b3;
				object obj13 = ((byte*)75)->CompareTo(b);
				object obj14 = ((obj13 is byte) ? obj13 : null);
				text = text;
				char[] separator2 = (char[])(object)Settings.Default;
				object obj15 = ((byte*)1)->GetHashCode();
				b = (byte)(num4 / (obj14 / (byte)text4.Split(separator2, (StringSplitOptions)((obj15 is StringSplitOptions) ? obj15 : null))));
			}
			catch
			{
				GClass0 obj16 = ((byte*)b)->GetHashCode() as GClass0;
				gClass = gClass;
				gClass = gClass2;
				numberStyles = default(NumberStyles);
				_ = byte.TryParse("WSMSY", numberStyles, null, out result) is GClass0;
				gClass = gClass;
				gClass = obj16;
				_ = Control1.smethod_0(null) is Control3;
				_ = byte.Parse("O", (NumberStyles)((byte*)196)->ToString()) is _003CPrivateImplementationDetails_003E;
				string text5 = text;
				array5 = array5;
				array5 = array5;
				_ = text5.LastIndexOfAny(array5) is byte;
			}
		}
	}
}
