using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal static class L
{
	[ComImport]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface M
	{
		[PreserveSig]
		int GetPath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cch, ref IntPtr pfd, uint fFlags);

		[PreserveSig]
		int GetIDList(out IntPtr ppidl);

		[PreserveSig]
		int SetIDList(IntPtr pidl);

		[PreserveSig]
		int GetDescription([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cch);

		[PreserveSig]
		int SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);

		[PreserveSig]
		int GetWorkingDirectory([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cch);

		[PreserveSig]
		int SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);

		[PreserveSig]
		int GetArguments([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cch);

		[PreserveSig]
		int SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);

		[PreserveSig]
		int GetHotkey(out ushort pwHotkey);

		[PreserveSig]
		int SetHotkey(ushort wHotkey);

		[PreserveSig]
		int GetShowCmd(out int piShowCmd);

		[PreserveSig]
		int SetShowCmd(int iShowCmd);

		[PreserveSig]
		int GetIconLocation([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cch, out int piIcon);

		[PreserveSig]
		int SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);

		[PreserveSig]
		int SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, uint dwReserved);

		[PreserveSig]
		int Resolve(IntPtr hwnd, uint fFlags);

		[PreserveSig]
		int SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
	}

	[ComImport]
	[Guid("00021401-0000-0000-C000-000000000046")]
	[ClassInterface(ClassInterfaceType.None)]
	private class N
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern N();
	}

	internal static M N5NIAW7vydDyg0sqDgvzcHtfRvCA4M()
	{
		return (M)new N();
	}

	unsafe static void L2DofYKcRDvV3gJcDa9zrhZyfFc8qF(object A, object B, object C)
	{
		//IL_0025: Expected O, but got I4
		//IL_006a: Expected O, but got I8
		//IL_00b4: Expected O, but got I8
		//IL_0118: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_0204: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_022b: Expected O, but got I4
		//IL_0233: Expected I4, but got O
		//IL_0246: Expected O, but got I4
		//IL_0272: Expected O, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_02a1: Expected I4, but got O
		//IL_02af: Expected O, but got I4
		//IL_02b8: Expected I4, but got O
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got I4
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Ref, but got Unknown
		//IL_02e9: Expected O, but got F8
		//IL_02fa: Expected I4, but got O
		//IL_02fb: Expected O, but got I4
		//IL_0305: Expected O, but got I4
		//IL_030d: Expected I4, but got O
		//IL_032e: Expected O, but got I4
		//IL_0338: Expected O, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected I4, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_03c9: Incompatible stack heights: 0 vs 1
		//IL_042f: Expected O, but got I4
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected I4, but got Unknown
		//IL_044b: Expected O, but got I4
		//IL_0467: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_047e: Expected I4, but got O
		//IL_04a5: Expected O, but got I4
		//IL_04d7: Expected O, but got I4
		//IL_0506: Expected O, but got I4
		//IL_0511: Expected O, but got I4
		//IL_051a: Expected I4, but got O
		//IL_051b: Expected O, but got I4
		//IL_0523: Expected I4, but got O
		//IL_054a: Expected O, but got I4
		ulong num = 2079612003uL;
		object obj = ((ulong*)num)->CompareTo(checked(num + 1538615066uL));
		object obj2 = ((obj is short) ? obj : null);
		string text = Encoding.UTF8.GetString(Convert.FromBase64String("Wg=="));
		string s = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		NumberStyles num2 = numberStyles;
		numberStyles = default(NumberStyles);
		NumberStyles numberStyles2 = num2;
		string obj3 = ulong.Parse(s, numberStyles) as string;
		IFormatProvider formatProvider = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		formatProvider = formatProvider2;
		if (!((byte)((short*)obj2)->ToString(obj3, formatProvider) != 0))
		{
			text = text;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
			string text3 = text2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string s2);
			object obj4 = ulong.Parse(s2, formatProvider);
			_ = (B)(object)((bool*)((obj4 is bool) ? obj4 : null))->ToString();
		}
		try
		{
			int num3 = (int)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
			int num4 = 984750588;
			num4 = num3;
			string text4 = text;
			text = Encoding.UTF8.GetString(Convert.FromBase64String("RERRT1M="));
			string text5 = text4;
			D d = d;
			d = d;
			object obj5 = sbyte.Parse(text);
			L l = ((long*)((obj5 is long) ? obj5 : null))->GetTypeCode() as L;
			l = null;
		}
		catch
		{
			if (checked(0u * ((text == text) ? 1u : 0u)) == 0)
			{
				_ = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(Encoding.UTF8.GetString(Convert.FromBase64String("T1lTTVZP")), text) is byte;
				object obj6 = int.Parse(Encoding.UTF8.GetString(Convert.FromBase64String("R04=")), formatProvider);
				object obj7 = sbyte.Parse(((long*)((obj6 is long) ? obj6 : null))->ToString(text), numberStyles);
				object obj8 = ((obj7 is byte) ? obj7 : null);
				string s3 = text;
				NumberStyles num5 = numberStyles;
				text = text;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string a);
				string a2 = J.bVRaQDElrHRWbRs8Si8fdGnMeEt9sH(a) as string;
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String("RlZaV0pDV0RP"));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte reference);
				ref sbyte reference2 = ref reference;
				ref sbyte reference3 = ref reference;
				reference = ref *(sbyte*)null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ref sbyte reference4);
				reference = ref reference4;
				text = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(a2, sbyte.TryParse(@string, out reference) as string) as string;
				object obj9 = ((short*)checked(4294948684u + 4294956089u))->GetTypeCode();
				ushort num6 = (ushort)(int)((obj9 is ushort) ? obj9 : null);
				object obj10 = null;
				text = ((ushort*)num6)->CompareTo(obj10) as string;
				object obj11 = global::C.Q469716ncdnqEoQ2YTy3jdePT51y3f(Encoding.UTF8.GetString(Convert.FromBase64String("QkFDVQ==")));
				_003F val = ((obj11 is int) ? obj11 : null) / (int)H.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
				object obj12 = global::C.Q469716ncdnqEoQ2YTy3jdePT51y3f(text);
				object obj13 = ((obj12 is int) ? obj12 : null);
				object obj14 = global::C.Q469716ncdnqEoQ2YTy3jdePT51y3f(text);
				int num4 = (int)((obj14 is int) ? obj14 : null);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out int a3);
				object obj15 = char.GetNumericValue(s4, (int)((int*)checked(-2090214344 * (val - unchecked(obj13 / G.z8HXPtuqQjHZBGdEsVFosIweGTJNtN(a3, (int)/*isinst with value type is only supported in some contexts*/)) * (num4 + unchecked(/*isinst with value type is only supported in some contexts*/ / -356368191)))))->ToString(formatProvider));
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string s5);
				object obj16 = I._6Ku4O4CZlgBZXd4CJD1xgPHqjXWlDK(sbyte.TryParse(s5, (NumberStyles)((obj15 is NumberStyles) ? obj15 : null), formatProvider, out reference) as string);
				numberStyles = (NumberStyles)((obj16 is NumberStyles) ? obj16 : null);
				NumberStyles numberStyles3 = num5;
				formatProvider = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider provider);
				object obj17 = I._6Ku4O4CZlgBZXd4CJD1xgPHqjXWlDK(uint.Parse(s3, default(NumberStyles), provider) as string);
				byte b = (byte)(int)(checked(obj8 + unchecked(225 / checked(((obj17 is byte) ? obj17 : null) + b))) / checked(unchecked((uint)(byte)((bool*)null)->ToString(null)) + 104u - (unchecked(obj10 / ((byte)string.Concat(obj10, obj10, obj10, (object)__arglist()) / b)) + b)));
				if (!((byte*)b)->Equals((byte)checked(b * b)))
				{
					System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
					E e2 = e;
					E obj18 = char.ConvertToUtf32(text, num4) as E;
					e = (E)(object)((bool*)1)->ToString();
					E e3 = obj18;
					E e4 = e2;
					e = null;
				}
			}
		}
		if (true)
		{
			return;
		}
		try
		{
			try
			{
				_ = H.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
			}
			catch
			{
				O o = o;
				o = o;
				long num7 = 1194348652L;
				long num8 = num7;
				num7 = -227869892L;
				long num9 = num8;
				char num10 = char.Parse(text);
				object obj20 = char.IsWhiteSpace(text, -1706124429);
				char c = (char)checked(((obj20 is char) ? obj20 : null) + 20352);
				c = num10;
				_ = global::C.Q469716ncdnqEoQ2YTy3jdePT51y3f(text) is uint;
			}
		}
		catch
		{
			object obj22 = H.LTW51i0GsgQlZnZ6JvWz0kME4Pacev();
			object obj23 = ((obj22 is uint) ? obj22 : null);
			object obj24 = char.Parse(text);
			uint num11 = (uint)(int)checked(obj23 + ((obj24 is uint) ? obj24 : null));
			uint num12 = checked(2123125287u - num11);
			text = text;
			string text6;
			string text7 = text6;
			text = text;
			string text8 = text7;
			string s6;
			object obj25 = int.Parse(s6);
			int a4 = (int)((ushort*)((obj25 is ushort) ? obj25 : null))->ToString(text, null);
			string b2 = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(text, Encoding.UTF8.GetString(Convert.FromBase64String("QkNES0hU"))) as string;
			string c2 = text;
			string d2 = text;
			string string2 = Encoding.UTF8.GetString(Convert.FromBase64String("R1A="));
			object obj26 = ((bool*)/*isinst with value type is only supported in some contexts*/)->Equals(obj: true);
			object obj27 = J.K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT(a4, b2, c2, d2, string2, (int)((obj26 is int) ? obj26 : null));
			sbyte b3 = (sbyte)(int)((obj27 is sbyte) ? obj27 : null);
			string text9 = ((sbyte*)((uint)b3 / (uint)b3))->ToString(formatProvider);
			text = G.z8HXPtuqQjHZBGdEsVFosIweGTJNtN((int)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮, -1659093406) as string;
			string text10;
			string text11 = text10;
			string text12 = text;
			text = text;
			string text13 = text12;
			string text14 = text11;
			string text15 = text9;
			string text16;
			if (!((byte)((uint*)num12)->ToString(text16) != 0))
			{
				_ = (J)(object)G.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮QTtuairtq2pQY8xf38wUaRkl7俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
				_ = (J)(object)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
			}
			else
			{
				F f = f;
				f = null;
			}
		}
	}

	unsafe static void U61l1bvrl4f1YsEQdN5fr114U4CEI9()
	{
		//IL_000c: Expected O, but got I4
		//IL_0016: Expected O, but got I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got I8
		//IL_0107: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected I4, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		//IL_01d0: Expected O, but got I4
		//IL_01e2: Expected O, but got I8
		//IL_01eb: Expected I4, but got O
		//IL_01eb: Expected I4, but got O
		//IL_01eb: Expected I4, but got O
		//IL_01ec: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Ref, but got Unknown
		//IL_0213: Expected O, but got I4
		//IL_0240: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected I4, but got Unknown
		//IL_0295: Expected I4, but got Unknown
		//IL_0299: Expected I4, but got O
		//IL_02c3: Expected O, but got I4
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got I4
		//IL_0354: Expected O, but got I4
		//IL_03a9: Expected O, but got I4
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected I4, but got Unknown
		//IL_03cd: Expected O, but got I4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected I4, but got Unknown
		//IL_045b: Expected O, but got I4
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected I4, but got Unknown
		//IL_0466: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected I4, but got Unknown
		//IL_0502: Expected O, but got I4
		//IL_0525: Expected O, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected Ref, but got Unknown
		//IL_053e: Expected O, but got I4
		//IL_0556: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_05d8: Expected O, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got I4
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Expected O, but got I4
		//IL_067b: Expected O, but got I4
		//IL_06c3: Expected I4, but got Unknown
		//IL_06d3: Expected I4, but got O
		//IL_06d4: Expected O, but got I4
		//IL_06dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Expected O, but got I4
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected Ref, but got Unknown
		//IL_075b: Expected O, but got I4
		//IL_07b1: Expected O, but got I4
		//IL_07c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got I4
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Ref, but got Unknown
		//IL_07e2: Expected O, but got I4
		//IL_0801: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num5);
		while (checked(0u + 0u) != 0)
		{
			object obj = short.Parse(H.LTW51i0GsgQlZnZ6JvWz0kME4Pacev() as string);
			_003F val = ((obj is bool) ? obj : null) / 0;
			uint num = checked((flag ? 1u : 0u) * (flag ? 1u : 0u) * (D.sM7euYYUEU1m0ouYzevg9LqiimjhXX() ? 1u : 0u)) / (flag ? 1u : 0u);
			flag = true;
			uint num4;
			checked
			{
				uint num2 = num + (flag2 ? 1u : 0u);
				bool num3 = D.sM7euYYUEU1m0ouYzevg9LqiimjhXX();
				obj2 = null;
				num4 = num2 - ((num3 ? 1u : 0u) - (unchecked((char*)12281)->Equals(obj2) ? 1u : 0u));
				flag = flag;
			}
			flag = (byte)checked(num4 + (flag3 ? 1u : 0u)) != 0;
			flag = flag4;
			if (checked(unchecked(val / flag) * 1) / ((byte)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮 != 0) == 0)
			{
				num5 = num5;
				num5 = num5;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			while (flag)
			{
				while (checked(1u - 0u) != 0)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String("TFlEQQ=="));
					string a = text;
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String("V0JXTk1TUA=="));
					IFormatProvider obj3 = (IFormatProvider)(object)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
					formatProvider = formatProvider;
					IFormatProvider formatProvider2 = obj3;
					_ = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(a, ulong.Parse(@string, formatProvider) as string) is C;
				}
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text2);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text3);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out short num10);
			do
			{
				try
				{
					object obj4 = ((int*)num6)->Equals(obj2);
					num6 = checked(((obj4 is int) ? obj4 : null) + num6);
					_ = G.z8HXPtuqQjHZBGdEsVFosIweGTJNtN((int)checked(unchecked((uint)num6) * unchecked((uint)num6)), 2024384384) is sbyte;
				}
				catch
				{
					byte num7 = b;
					b = (byte)(checked(106u * unchecked((uint)b)) / (byte)G.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮QTtuairtq2pQY8xf38wUaRkl7俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮);
					byte b2 = num7;
					byte num8 = b;
					text = Encoding.UTF8.GetString(Convert.FromBase64String("QVVFSUdBQg=="));
					text = text2;
					object obj5 = text3.LastIndexOf((char)(int)/*isinst with value type is only supported in some contexts*/, (int)/*isinst with value type is only supported in some contexts*/, (int)/*isinst with value type is only supported in some contexts*/);
					_003F val2 = num8 / checked(((obj5 is byte) ? obj5 : null) + 209);
					num6 = num6;
					object obj6 = ((byte*)val2)->CompareTo((byte)((int*)num9)->ToString());
					object obj7 = ((obj6 is short) ? obj6 : null);
					_003F val3;
					short num12;
					checked
					{
						uint num11 = unchecked((uint)num10) + (unchecked((uint)num10) + unchecked((uint)num10));
						object obj8 = ushort.Parse(Encoding.UTF8.GetString(Convert.FromBase64String("RFVM")), D.sM7euYYUEU1m0ouYzevg9LqiimjhXX() as IFormatProvider);
						val3 = num11 - ((obj8 is short) ? obj8 : null);
						num12 = num10;
					}
					short num13 = (short)((bool*)null)->ToString();
					object obj9 = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(Encoding.UTF8.GetString(Convert.FromBase64String("RFlFSkJJRQ==")), text);
					num10 = (short)(num12 / (num13 / (checked(((obj9 is short) ? obj9 : null) * num10) / num10)));
					short num14 = (short)(int)val3;
					num10 = (short)(int)obj7;
				}
			}
			while (false);
		}
		num6 = num6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int a2);
		object obj12 = G.z8HXPtuqQjHZBGdEsVFosIweGTJNtN(a2, 1941404149);
		object obj13 = ((obj12 is bool) ? obj12 : null);
		bool num15 = flag;
		string s = text;
		long num16 = 452550892L;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num17);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num18);
		if ((int)(obj13 / checked((num15 ? 1u : 0u) + (ulong.TryParse(s, out *unchecked((ulong*)((long*)checked(unchecked((ulong)num16 / 18446744073004809635uL) * 660046762uL + unchecked((ulong)num16)))->ToString())) ? 1u : 0u) - unchecked((D.sM7euYYUEU1m0ouYzevg9LqiimjhXX() ? 1u : 0u) / checked((flag ? 1u : 0u) - 0u)) + 0u)) == 0)
		{
			try
			{
				do
				{
					num6 = 506921049;
					num17 = 1651465026u;
					_ = (B)(object)((uint*)num17)->ToString(J.bVRaQDElrHRWbRs8Si8fdGnMeEt9sH(C.Q469716ncdnqEoQ2YTy3jdePT51y3f(text) as string) as string);
				}
				while (flag);
			}
			finally
			{
				num18 = num18;
				ushort num19 = num18;
				string s2 = text;
				numberStyles = default(NumberStyles);
				numberStyles = default(NumberStyles);
				object obj14 = byte.Parse(s2, numberStyles);
				num18 = (ushort)(num19 / ((obj14 is ushort) ? obj14 : null));
				goto IL_04de;
			}
		}
		bool num20 = flag;
		object obj15 = ((short*)22899)->GetHashCode();
		_003F val4;
		uint num21;
		checked
		{
			val4 = ((obj15 is bool) ? obj15 : null) - unchecked((I._6Ku4O4CZlgBZXd4CJD1xgPHqjXWlDK(Encoding.UTF8.GetString(Convert.FromBase64String("VExaUQ=="))) ? 1u : 0u) / 1u);
			num21 = num17;
		}
		object obj16 = ((sbyte*)103)->CompareTo(-46);
		ref _003F reference = ref *(_003F*)((obj16 is ushort) ? obj16 : null);
		uint num22;
		checked
		{
			num22 = 18859u - unchecked((uint)(num18 / num18));
		}
		object obj17 = J.Q0tUom94drTkG62fawZSxXm4M48FwM(-1498669674 / /*isinst with value type is only supported in some contexts*/, Encoding.UTF8.GetString(Convert.FromBase64String("WlRW")), text, -879851832, num6);
		text = ((short*)(-29786))->ToString(uint.Parse(System.Runtime.CompilerServices.Unsafe.As<_003F, ushort>(ref reference).Equals((ushort)(int)checked(num22 * ((obj17 is ushort) ? obj17 : null))) as string) as string);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text4);
		flag = (byte)checked(val4 - (unchecked((byte)((uint*)num21)->ToString(text4)) != 0)) != 0;
		bool flag5 = num20;
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag6);
			uint num23 = (flag6 ? 1u : 0u) * 0u * 1u;
			string a3 = text;
			text = text;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
			text = text5;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out string b3);
			if (unchecked(num23 / (E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(a3, b3) ? 1u : 0u)) - (0u - (flag ? 1u : 0u)) == 0)
			{
				_ = (O)(object)unchecked((ulong*)num5)->ToString(text, formatProvider);
			}
			goto IL_04de;
		}
		IL_04de:
		if (checked((flag ? 1u : 0u) + (flag ? 1u : 0u)) == 0)
		{
			bool num24 = J.bVRaQDElrHRWbRs8Si8fdGnMeEt9sH(text);
			object obj18 = (object)/*isinst with value type is only supported in some contexts*/;
			object obj19 = byte.Parse(Encoding.UTF8.GetString(Convert.FromBase64String("S1hSTkVYTUlG")), numberStyles);
			_ = ((bool*)checked(1 - (num24 - unchecked(obj18 / checked(((obj19 is bool) ? obj19 : null) + flag)) + 1)))->Equals(H.LTW51i0GsgQlZnZ6JvWz0kME4Pacev()) is ulong;
		}
		else
		{
			A obj20 = ((bool*)checked(1u - unchecked((uint)checked(-0)) - 0u))->GetTypeCode() as A;
			A a4 = a4;
			A a5 = null;
			a4 = obj20;
		}
		ulong num25 = num5;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		if (!((byte)((ulong*)num25)->ToString(text6) != 0))
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string a6);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out string b4);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out B b5);
				while (true)
				{
					object obj21 = C.Q469716ncdnqEoQ2YTy3jdePT51y3f(Encoding.UTF8.GetString(Convert.FromBase64String("SUNOUUZH")));
					object obj22 = ((obj21 is int) ? obj21 : null);
					int num26 = (int)H.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮zrNaizHOhdvtI4I13ZEN7k4ng俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
					object obj23 = C.Q469716ncdnqEoQ2YTy3jdePT51y3f(text);
					_003F val6;
					checked
					{
						_003F val5 = unchecked(num26 / ((obj23 is int) ? obj23 : null)) + num6;
						object obj24 = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(text, Encoding.UTF8.GetString(Convert.FromBase64String("VFVEUVFITVdQ")));
						val6 = val5 + ((obj24 is int) ? obj24 : null);
					}
					text = ((ushort*)50861)->CompareTo(obj2) as string;
					string string2 = Encoding.UTF8.GetString(Convert.FromBase64String("V1FPQVdKQkQ="));
					string string3 = Encoding.UTF8.GetString(Convert.FromBase64String("V0lUQUpS"));
					string e = K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮;
					string text7 = text;
					text = text;
					string[] separator = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(a6, Encoding.UTF8.GetString(Convert.FromBase64String("Tk9aRUVY"))) as string[];
					StringSplitOptions stringSplitOptions = default(StringSplitOptions);
					object obj25 = G.z8HXPtuqQjHZBGdEsVFosIweGTJNtN((int)obj22, (int)checked(unchecked((uint)J.K4tjqr2Q3FznFgWtAQjz3xJ9JtdZIT((int)val6, b4, string2, string3, e, (int)((uint)(int)text7.Split(separator, default(StringSplitOptions)) / (uint)num6))) + unchecked((uint)(int)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮)));
					if (checked(((obj25 is bool) ? obj25 : null) + flag) / flag / byte.TryParse(text, out *(byte*)null) == 0)
					{
						break;
					}
					B b6 = b5;
					b5 = null;
					B b7 = b6;
					b5 = null;
				}
				return;
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out K k2);
				while (true)
				{
					string b8 = text;
					string string4 = Encoding.UTF8.GetString(Convert.FromBase64String("WldQUllI"));
					object obj26 = ushort.Parse(text, formatProvider);
					K k = J.Q0tUom94drTkG62fawZSxXm4M48FwM(-1637420420, b8, string4, (int)((uint)((byte*)checked(41 + ((obj26 is byte) ? obj26 : null)))->GetHashCode() / (uint)num6 / (uint)num6), (int)K.俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮SVwiNVTawNDIKr5Oey8CdaImK俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮) as K;
					k = k2;
					k = k;
				}
				return;
			}
		}
		text = text;
		_003F val7 = /*isinst with value type is only supported in some contexts*// ((ulong)num16 / 18446744072765572944uL);
		object obj27 = ((uint*)num17)->CompareTo(obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string a7);
		_ = E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(E.rsjKGldMxv3c0aGSgVonRmGjVKQWUg(a7, ((long*)checked(val7 * ((obj27 is long) ? obj27 : null)))->ToString()) as string, Encoding.UTF8.GetString(Convert.FromBase64String("Qlk="))) is int;
	}
}
