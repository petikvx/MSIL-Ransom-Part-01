using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using ns1;
using ns2;

namespace ns0;

public class @_ : Form
{
	private IContainer icontainer_0;

	private ColumnHeader columnHeader_0;

	internal ListView listView_0;

	public _()
	{
		InitializeComponent();
	}

	private void __Load(object sender, EventArgs e)
	{
		string text = Environment.GetCommandLineArgs()[0];
		foreach (char c in text)
		{
			listView_0.get_Items().get_Item(1).get_SubItems()
				.Add(c.ToString());
		}
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		ListView val = (listView_0 = new ListView());
		columnHeader_0 = new ColumnHeader();
		((Control)this).SuspendLayout();
		listView_0.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[1] { columnHeader_0 });
		((Control)listView_0).set_Dock((DockStyle)5);
		listView_0.set_GridLines(true);
		((Control)listView_0).set_Location(new Point(0, 0));
		((Control)listView_0).set_Name("Ⴃ");
		((Control)listView_0).set_Size(new Size(349, 352));
		((Control)listView_0).set_TabIndex(0);
		listView_0.set_UseCompatibleStateImageBehavior(false);
		listView_0.set_View((View)1);
		columnHeader_0.set_Width(337);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(349, 352));
		((Control)this).get_Controls().Add((Control)(object)listView_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("_");
		((Control)this).set_Text(" ");
		((Form)this).add_Load((EventHandler)__Load);
		((Control)this).ResumeLayout(false);
	}

	unsafe static void awejudor8()
	{
		//IL_0014: Expected O, but got I4
		//IL_0025: Expected O, but got I4
		//IL_008f: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		while (true)
		{
			if (byte.TryParse(text, style, formatProvider, out *(byte*)null))
			{
				try
				{
					text = byte.Parse(text, null) as string;
					_ = string.CompareOrdinal(text, "JVCEI") is byte;
					obj = obj;
					byte b = (byte)checked(unchecked(2u / (uint)(byte)((byte*)(byte)string.Concat(obj, null))->ToString(((byte*)86)->ToString((IFormatProvider)(object)Settings.Default))) * 174u);
					array = array;
					string obj2 = (string)(object)Control4.smethod_1(array);
					formatProvider = formatProvider;
					style = (NumberStyles)((byte*)b)->ToString(obj2, formatProvider);
					style = default(NumberStyles);
					_ = byte.Parse("GNSRPWAFN", style) is void;
				}
				catch
				{
					text = text;
				}
			}
		}
	}

	unsafe static void awejudor9(object object_0)
	{
		//IL_002e: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		object obj = obj;
		object format = obj;
		object[] args = (object[])(object)string.Concat((object)null, obj, obj, (object)__arglist());
		_ = (Control3)(object)string.Format((string)format, args);
		_ = byte.TryParse("WUDGX", out *(byte*)null) is Control0;
		_ = (string)(object)Class4.smethod_0(null, null);
		string text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
		text = text2;
		string text3 = text;
		uint startIndex = 4073857511u / (uint)(int)Class4.smethod_0(null, null);
		object obj2 = Control1.smethod_0(null);
		Control4 control = text3.LastIndexOf('\u0c65', (int)startIndex, ((byte*)((obj2 is byte) ? obj2 : null))->GetHashCode()) as Control4;
		control = control;
		Struct2 @struct = default(Struct2);
		string text4 = text;
		IFormatProvider provider = string.IsNullOrWhiteSpace(text) as IFormatProvider;
		object obj3 = ((byte*)26)->Equals(obj);
		_ = ((byte*)((obj3 is byte) ? obj3 : null))->CompareTo(obj) is string;
		text = text.ToUpperInvariant();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string format2);
		_ = text4.Equals((object?)string.Format(provider, format2, "XHATN".IsNormalized() as object)) is Class4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles2);
		while (true)
		{
			ResolveEventArgs resolveEventArgs_ = (ResolveEventArgs)(object)string.Concat(null, obj, null);
			text = Control1.smethod_0(resolveEventArgs_) as string;
			byte[] byte_ = null;
			string s = text5.Normalize((NormalizationForm)Control4.smethod_1(byte_));
			NumberStyles numberStyles = default(NumberStyles);
			numberStyles = numberStyles2;
			_ = byte.Parse(s, numberStyles) is Class2;
		}
	}

	unsafe static void initadurah11(object object_0)
	{
		//IL_0018: Expected O, but got I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Ref, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0051: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		//IL_0095: Incompatible stack heights: 0 vs 1
		//IL_00bd: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_016a: Expected I4, but got O
		//IL_016b: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01b8: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_0350: Expected O, but got I4
		//IL_037c: Expected O, but got I4
		//IL_0386: Expected O, but got I4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected I4, but got Unknown
		//IL_0393: Expected O, but got I4
		//IL_03cf: Incompatible stack heights: 1 vs 0
		//IL_03dc: Incompatible stack heights: 0 vs 1
		//IL_040b: Expected O, but got I4
		//IL_043e: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		//IL_0473: Expected O, but got I4
		//IL_047d: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_04b6: Expected O, but got I4
		//IL_04dd: Expected O, but got I4
		//IL_0540: Expected O, but got I4
		//IL_054a: Expected O, but got I4
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected I4, but got Unknown
		//IL_058d: Expected O, but got I4
		//IL_05b9: Expected O, but got I4
		//IL_05f2: Expected O, but got I4
		//IL_0606: Expected O, but got I4
		//IL_0636: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected I4, but got Unknown
		//IL_0651: Expected O, but got I4
		//IL_065d: Expected O, but got I4
		//IL_06bd: Expected O, but got I4
		//IL_06d9: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		try
		{
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string[] array);
			while (true)
			{
				object obj = ((byte*)checked(unchecked((uint)b) * 219u))->Equals(124);
				if (((byte*)checked(((obj is byte) ? obj : null) + 151))->Equals(obj2))
				{
					obj2 = obj2;
					b = b;
					byte num = b;
					string text2 = text;
					array = array;
					string[] separator = array;
					object obj3 = ((byte*)(byte)string.Format(text, null))->Equals(obj2);
					text = ((byte*)checked(num * unchecked((byte)text2.Split(separator, (StringSplitOptions)((obj3 is StringSplitOptions) ? obj3 : null)))))->Equals(b) as string;
					string text3 = text;
					num2 = 548664601;
					object object_ = string.Concat((object)null, (object)text3.Substring(548664601), (object)null, (object)__arglist());
					resolveEventArgs_ = null;
					_ = (Control0)(object)Class4.smethod_0(object_, resolveEventArgs_);
					continue;
				}
				break;
			}
		}
		CultureInfo cultureInfo = cultureInfo;
		_ = (Control1)(object)"VIORD".ToLower(cultureInfo);
		object obj5 = ((byte*)198)->GetTypeCode();
		_ = ((byte*)((obj5 is byte) ? obj5 : null))->GetHashCode() is Class4;
		object obj6 = Control1.smethod_0(resolveEventArgs_);
		text = byte.TryParse("XUYL", out *(byte*)((obj6 is ref byte) ? obj6 : null)) as string;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] array2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		NumberStyles numberStyles;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions4);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CompareOptions compareOptions);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
			bool num3;
			do
			{
				string text4 = text;
				string separator2 = "PAYSMWFF".PadRight(num2);
				text = text;
				numberStyles = default(NumberStyles);
				numberStyles = default(NumberStyles);
				NumberStyles style = numberStyles;
				formatProvider = formatProvider;
				IFormatProvider provider = formatProvider;
				string strA = text;
				string strB = text;
				uint indexB;
				uint length;
				CultureInfo culture;
				checked
				{
					indexB = unchecked((uint)(int)Settings.Default / (uint)num2) + unchecked((uint)num2);
					string s = byte.Parse(text, numberStyles) as string;
					object obj7 = string.CompareOrdinal("TMF", "VDQKKYO");
					string obj8 = byte.Parse(s, unchecked((NumberStyles)((obj7 is NumberStyles) ? obj7 : null))) as string;
					array2 = array2;
					length = 1199600684u * unchecked((uint)(int)obj8.TrimEnd(array2));
					culture = cultureInfo;
					compareOptions = compareOptions;
					compareOptions = compareOptions2;
					compareOptions = compareOptions3;
					compareOptions = compareOptions4;
					compareOptions = default(CompareOptions);
					compareOptions = default(CompareOptions);
				}
				object obj9 = string.Compare(strA, -964669342, strB, (int)indexB, (int)length, culture, compareOptions);
				text4.PadRight((int)checked(unchecked((uint)(int)((byte*)(byte)string.Join(separator2, byte.Parse(byte.TryParse(s2, style, provider, out *(byte*)((obj9 is ref byte) ? obj9 : null)) as string, formatProvider) as IEnumerable<string>))->ToString((IFormatProvider?)null)) - unchecked((uint)num2)));
				string text5 = text;
				char[] separator3 = ((byte*)79)->GetHashCode() as char[];
				int count = num2;
				StringSplitOptions options = (StringSplitOptions)Settings.Default;
				num3 = (byte)text5.Split(separator3, count, options) != 0;
				flag = num3;
			}
			while (num3 || text.Equals((object?)null));
		}
		catch
		{
		}
		string separator4 = text;
		object[] array3 = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object[] array4);
		array3 = array4;
		object obj11 = Class4.smethod_0(string.Join(separator4, array3), resolveEventArgs_);
		string text6 = text;
		_ = ((byte*)b)->GetTypeCode() is string;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text7);
		string separator5 = text7.ToUpper(cultureInfo);
		int indexA = num2;
		text = "A";
		uint indexB2 = checked(963934144u * 3628630474u + 1396261205u);
		byte num4 = (byte)Settings.Default;
		byte num5 = b;
		formatProvider = formatProvider;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		string format = ((byte*)77)->ToString(formatProvider2);
		object arg = obj2;
		byte[] array5 = array5;
		_ = (object)Control4.smethod_1(array5);
		obj2 = obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object arg2);
		byte num6 = (byte)string.Concat(((byte*)(217u / (uint)(byte)string.Format(format, arg, arg2)))->Equals("UMVVIIN".PadLeft((int)(checked(unchecked((uint)num2) * unchecked((uint)num2 / ((uint)num2 / (uint)num2))) / 492259033u), '贎')) as IEnumerable<string>);
		b = 185;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b2);
		object obj12 = ((byte*)checked(num4 - 0u * (159u + (num5 - (unchecked((uint)checked(num6 * b2)) - 0u)))))->GetTypeCode();
		object obj13 = ((obj12 is int) ? obj12 : null);
		int num7 = num2;
		IFormatProvider provider2 = formatProvider;
		string s3 = ((byte*)185)->ToString("UHKWWKUZP");
		numberStyles = default(NumberStyles);
		uint num8;
		checked
		{
			num8 = 1620182986u + unchecked((uint)num7 / (uint)(int)string.Format(provider2, "Y", Class4.smethod_0(byte.Parse(s3, numberStyles, (IFormatProvider)(object)Settings.Default) as object, resolveEventArgs_)));
		}
		object obj14 = Control1.smethod_0(((byte*)185)->Equals(112) as ResolveEventArgs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string strB2);
		IEnumerable<string> values = string.Compare("CLMUPREO", indexA, strB2, (int)indexB2, (int)checked(-1416973816 + obj13 * unchecked(num8 / ((obj14 is int) ? obj14 : null)))) as IEnumerable<string>;
		string.Concat(obj11, (object)text6.ToCharArray((int)((uint)(int)string.Join(separator5, values) / (uint)num2), ((byte*)36)->CompareTo(185)), obj2, (object)__arglist());
		while ((byte)Control4.smethod_1(array5) != 0)
		{
		}
		try
		{
			_ = (string)(object)Settings.Default;
		}
		finally
		{
			"XVI".ToLower(cultureInfo);
			goto IL_03ff;
		}
		IL_03ff:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out StringComparison stringComparison);
		try
		{
			try
			{
				while (true)
				{
					_ = text.IndexOfAny(array2) is Control2;
				}
			}
			finally
			{
				_ = (_003CModule_003E)(object)((byte*)b)->ToString();
				goto end_IL_0400;
			}
			end_IL_0400:;
		}
		catch
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Control0 control);
				do
				{
					object obj15 = ((byte*)89)->Equals((byte)checked(134u - unchecked((uint)b)));
					object obj16 = ((obj15 is byte) ? obj15 : null);
					text = "EGGYOZH";
					int startIndex = num2;
					int count2 = (int)Control4.smethod_1(null);
					stringComparison = stringComparison;
					ref _003F reference = ref *(_003F*)obj16;
					object obj17 = "Y".LastIndexOf(value, startIndex, count2, stringComparison);
					Control0 obj18 = "I".IndexOfAny(System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference).CompareTo(((byte*)((obj17 is byte) ? obj17 : null))->CompareTo(obj2) as object) as char[], ((byte*)16)->GetHashCode()) as Control0;
					control = control;
					control = obj18;
				}
				while (checked((flag ? 1u : 0u) + 1u) != 0);
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ResolveEventArgs resolveEventArgs_2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b5);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int startIndex2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out @_ _2);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out @_ _3);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] byte_);
				while (flag)
				{
					_ = string.Equals(text, text, stringComparison) is Class3;
					_2 = _2;
					b = 159;
					object object_2 = ((byte*)b3)->GetHashCode() as object;
					b = 159;
					resolveEventArgs_ = (ResolveEventArgs)(object)((byte*)checked(31u + unchecked((uint)b4)))->ToString("MEDQPO", (IFormatProvider)(object)Control4.smethod_1(array5));
					numberStyles = (NumberStyles)string.Concat(null, Class4.smethod_0(object_2, resolveEventArgs_2), obj2);
					b = byte.Parse("CPNGV", style2);
					object obj19 = ((byte*)checked(221u + unchecked((uint)b5)))->Equals("LXRKJE"[-905651677] as object);
					num2 = checked(((obj19 is int) ? obj19 : null) - num2);
					_2 = (@_)(object)"WC".Remove(startIndex2);
					_2 = _3;
					_2 = _2;
					array5 = byte.Parse((string)"DSVLTZVN".Clone(), (NumberStyles)string.Join(text, array3), formatProvider) as byte[];
					Control4.smethod_1(byte_);
				}
				goto end_IL_0425;
			}
			end_IL_0425:;
		}
		try
		{
			try
			{
				_ = byte.TryParse("YTRYODK", out *(byte*)null) is Class1;
				Class1 @class = @class;
				@class = @class;
			}
			finally
			{
				text = "LNO".IndexOf(text, (int)"XQVKVAJ".Trim((char[])(object)Settings.Default), stringComparison) as string;
				text = text;
				string text8 = text;
				NormalizationForm normalizationForm = normalizationForm;
				_ = text8.IsNormalized(normalizationForm) is Class2;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
				_ = (Class2)(object)((byte*)byte.Parse(s4, formatProvider))->ToString();
				object obj21 = "JTQOHNG".Equals((object?)text.TrimEnd(null));
				ref _003F reference2 = ref *(_003F*)((obj21 is byte) ? obj21 : null);
				byte num9 = b;
				object obj22 = ((byte*)223)->GetTypeCode();
				_ = System.Runtime.CompilerServices.Unsafe.As<_003F, byte>(ref reference2).CompareTo((byte)(num9 / ((obj22 is byte) ? obj22 : null))) is Class2;
				_ = Control1.smethod_0(resolveEventArgs_) is Class2;
				string text9 = text;
				int startIndex3 = num2;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string value2);
				_ = (@_)(object)text9.Insert(startIndex3, value2);
				goto end_IL_05ac;
			}
			end_IL_05ac:;
		}
		finally
		{
			goto IL_068d;
		}
		IL_068d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char[] trimChars);
		while (true)
		{
			bool num10 = flag;
			array2 = array2;
			checked
			{
				if ((num10 ? 1u : 0u) + unchecked((((byte)"M".Trim(trimChars) != 0) ? 1u : 0u) / (((byte)Control4.smethod_1(null) != 0) ? 1u : 0u)) == 0)
				{
					break;
				}
			}
			do
			{
				text = text;
			}
			while ((byte)Class4.smethod_0(obj2, null) != 0);
		}
		try
		{
			_ = byte.Parse(text, numberStyles, null) is Control4;
		}
		finally
		{
			_ = Control1.smethod_0((ResolveEventArgs)(object)((byte*)176)->ToString()) is string;
			return;
		}
	}
}
