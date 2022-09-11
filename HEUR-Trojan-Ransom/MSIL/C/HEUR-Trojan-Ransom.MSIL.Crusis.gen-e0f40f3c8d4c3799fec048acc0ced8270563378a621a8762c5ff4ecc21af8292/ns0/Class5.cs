using System;
using System.Drawing;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal sealed class Class5
{
	private static Color color_0 = Color.LightGray;

	private static readonly uint[] uint_0;

	internal virtual Expression vmethod_0(Expression expression_0)
	{
		throw new NotImplementedException();
	}

	internal virtual Expression vmethod_1(Expression expression_0)
	{
		return vmethod_0(expression_0);
	}

	public static byte[] smethod_0(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	internal virtual Expression vmethod_2(Expression expression_0)
	{
		return expression_0;
	}

	public static uint smethod_1(uint uint_1, byte[] byte_0, int int_0, int int_1)
	{
		uint_1 ^= 0xFFFFFFFFu;
		while (--int_1 >= 0)
		{
			int_0++;
			uint_1 = uint_0[(uint_1 ^ byte_0[int_0]) & 0xFF] ^ (uint_1 >> 8);
		}
		uint_1 ^= 0xFFFFFFFFu;
		return uint_1;
	}

	unsafe static void smethod_2()
	{
		//IL_001a: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_009b: Expected O, but got I8
		//IL_00a5: Expected O, but got I4
		//IL_00cc: Expected O, but got I8
		//IL_00e7: Expected O, but got I4
		//IL_0119: Expected O, but got I8
		//IL_0123: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got I4
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got I4
		//IL_015b: Expected I4, but got O
		//IL_0174: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_0197: Expected I4, but got O
		//IL_019f: Expected O, but got I4
		//IL_01b5: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_020d: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_0229: Expected I4, but got O
		//IL_0260: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_027e: Expected I4, but got O
		//IL_029b: Expected O, but got I4
		//IL_02a6: Expected I4, but got O
		//IL_02a7: Expected O, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected I4, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_02bb: Expected I4, but got O
		//IL_02bc: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected I8, but got Unknown
		//IL_0349: Expected O, but got I8
		//IL_036b: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_03c2: Expected I4, but got O
		//IL_03d4: Expected O, but got I4
		//IL_03e4: Expected O, but got I8
		//IL_03fa: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_043f: Expected I4, but got O
		//IL_0452: Expected O, but got I4
		//IL_0466: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_0493: Expected I4, but got O
		//IL_0513: Expected O, but got I
		//IL_0522: Expected O, but got I4
		//IL_0551: Expected O, but got I8
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got I4
		//IL_0591: Expected O, but got I4
		//IL_05a4: Expected O, but got I8
		//IL_05d5: Expected O, but got I4
		//IL_05f3: Expected O, but got I4
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Expected I4, but got Unknown
		//IL_063e: Expected O, but got I4
		//IL_0647: Expected I4, but got O
		//IL_0648: Expected O, but got I4
		//IL_0662: Expected O, but got I4
		//IL_0689: Expected O, but got I4
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0699: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected I4, but got Unknown
		//IL_06a5: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected I4, but got Unknown
		//IL_06cc: Expected O, but got I4
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected Ref, but got Unknown
		//IL_06e2: Expected O, but got I4
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected I4, but got Unknown
		//IL_06f0: Expected O, but got I4
		//IL_0702: Expected O, but got I4
		//IL_071c: Expected O, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Ref, but got Unknown
		//IL_0728: Expected O, but got I4
		//IL_0737: Expected O, but got I4
		//IL_0745: Expected I4, but got O
		//IL_0750: Expected O, but got I4
		//IL_075c: Expected O, but got I4
		//IL_0779: Expected O, but got I4
		//IL_078f: Expected O, but got I4
		//IL_0798: Expected I4, but got O
		//IL_0799: Expected O, but got I4
		//IL_07a2: Expected I4, but got O
		//IL_07a3: Expected O, but got I4
		//IL_07a9: Expected I4, but got O
		//IL_07c7: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		//IL_0850: Expected O, but got I4
		//IL_0856: Expected I4, but got O
		//IL_086d: Expected O, but got I4
		//IL_0879: Expected I4, but got O
		//IL_088f: Expected O, but got I4
		//IL_08b9: Expected O, but got I4
		//IL_08d5: Expected O, but got I4
		//IL_08df: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_090f: Expected O, but got I4
		//IL_091b: Expected O, but got I4
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0925: Expected I4, but got Unknown
		//IL_0926: Expected O, but got I4
		//IL_0930: Expected O, but got I4
		//IL_093d: Expected O, but got I8
		//IL_0956: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out char c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out BindingFlags bindingFlags);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num6);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num16);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out sbyte b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles numberStyles);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj15);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Settings settings);
			do
			{
				settings = settings;
				object obj = bool.TryParse("BiSWAsVmwHxMOEt2OXIeYbLRusPHXvGiqufHF64kisb6GAXYw1h9D5fnCZr3TloOB8AR969PYoLa0g==", out *(bool*)Settings.Default);
				_ = (Settings)(object)((ushort*)((obj is ushort) ? obj : null))->ToString(char.IsLetterOrDigit('痵') as string);
				c = '\u0001';
				object obj2 = char.IsPunctuation('\u0001');
				object obj3 = ((sbyte*)((obj2 is sbyte) ? obj2 : null))->GetTypeCode();
				settings = ((int*)((obj3 is int) ? obj3 : null))->Equals(null) as Settings;
			}
			while (checked(((unchecked((byte)Settings.Default) != 0) ? 1u : 0u) + ((flag = flag) ? 1u : 0u)) != 0);
		}
		catch
		{
			bindingFlags = bindingFlags;
			BindingFlags bindingFlags_ = bindingFlags;
			PropertyInfo[] propertyInfo_ = null;
			Type[] type_ = (Type[])(object)Settings.Default;
			num = (nint)((nuint)num / (nuint)num);
			object obj4 = ((IntPtr*)num)->ToInt64();
			_ = ((sbyte*)((obj4 is sbyte) ? obj4 : null))->GetHashCode() is ParameterModifier[];
			ParameterModifier[] array = null;
			array = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array2);
			array = array2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ParameterModifier[] array3);
			array = array3;
			short num2 = (short)Class0.smethod_5(bindingFlags_, propertyInfo_, null, type_, array);
			string obj5 = ((IntPtr*)num)->ToInt64() as string;
			formatProvider = formatProvider;
			text = (((byte)((short*)num2)->ToString(obj5, formatProvider) != 0) ? ((bool*)1) : ((bool*)null))->CompareTo(flag) as string;
			string s = text;
			char[] anyOf = (char[])(object)Settings.Default;
			int num3 = num3;
			int num4 = num3;
			uint num5 = (uint)Settings.Default;
			object obj6 = ((sbyte*)/*isinst with value type is only supported in some contexts*/)->GetHashCode();
			object obj7;
			checked
			{
				_ = unchecked(num5 / ((obj6 is uint) ? obj6 : null)) * unchecked((uint)((long*)(-1026783873L))->ToString(short.Parse(text) as string, formatProvider));
				obj7 = bool.Parse("YtF6wNMxrxtmxZp2CmhHxTJeHGFcVoeyCNSLJLHX/HCwzodE2l9LxDdfO3WtsiSS1tY94VU9h57RSw==");
			}
			num6 = (uint)(int)((obj7 is uint) ? obj7 : null);
			uint num7 = num6;
			string s2 = text;
			numberStyles = default(NumberStyles);
			num3 = (int)((uint)num4 / (uint)(int)((uint*)num7)->ToString(int.Parse(s2, numberStyles) as string, formatProvider));
			object obj8 = "xXf+UQ9XWTPlkR7DnBikzhIx5BWTVq4ROk9KGxSOa9h6aYifDvipWGZvpnk31g7kcyyffAk/29PD3A==".IndexOfAny(anyOf, num3, num3);
			b = (sbyte)(int)((obj8 is sbyte) ? obj8 : null);
			string s3 = ((sbyte*)b)->GetHashCode() as string;
			bindingFlags = default(BindingFlags);
			BindingFlags bindingFlags_2 = bindingFlags;
			string obj9 = (flag ? ((bool*)1) : ((bool*)null))->GetHashCode() as string;
			int num8 = num3;
			num = default(IntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num9);
			nuint num10 = (nuint)num9 / (nuint)unchecked((nint)default(IntPtr));
			num = default(IntPtr);
			_ = ((IntPtr)(nint)num10 != (IntPtr)num) is byte[];
			byte[] array4 = array4;
			uint num12;
			checked
			{
				uint num11 = unchecked((uint)(int)Class0.smethod_1(array4, null)) * unchecked((uint)num3);
				object obj10 = unchecked((long*)1743556460L)->CompareTo(null);
				num12 = unchecked((uint)num8) - (num11 + unchecked((uint)((short*)((obj10 is short) ? obj10 : null))->GetHashCode()));
			}
			object obj11 = ((byte*)137)->GetTypeCode();
			num3 = (int)((obj11 is int) ? obj11 : null);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
			num3 = (int)checked(unchecked(num12 / checked(unchecked((uint)num13) * unchecked((uint)num3))) * 2625798281u);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
			num3 = num14;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
			object obj12 = short.Parse(s3, (IFormatProvider)Class0.smethod_5(bindingFlags_2, null, (Type)(object)obj9.Substring((int)checked(unchecked((uint)num15) + 1887098396u)), null, array));
			object obj13 = ushort.TryParse(s, out *(ushort*)((obj12 is ref ushort) ? obj12 : null));
			object obj14 = ((short*)((obj13 is short) ? obj13 : null))->GetTypeCode();
			num16 = (ushort)(int)((obj14 is ushort) ? obj14 : null);
			ushort num17 = num16;
			char num18 = c;
			obj15 = null;
			ref _003F reference = ref *(_003F*)num17;
			object obj16 = ((short*)30592)->Equals((short)checked(-25129 + /*isinst with value type is only supported in some contexts*/));
			Class3 obj17 = ((sbyte*)checked(16u - unchecked((uint)(sbyte)System.Runtime.CompilerServices.Unsafe.As<_003F, ushort>(ref reference).ToString(sbyte.Parse(char.IsHighSurrogate((char)(int)((obj16 is char) ? obj16 : null)) as string) as string))))->Equals(-14) as Class3;
			Class3 @class = @class;
			@class = obj17;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ulong num19);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out MethodBase[] array5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num23);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out int num24);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IFormatProvider formatProvider3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type type2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ushort num26);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Class0 class4);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out long num31);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out uint num32);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ref int result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s9);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Type[] type_3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out NumberStyles style3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string string_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num36);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num35);
		do
		{
			try
			{
				object obj19 = Class0.smethod_2(null);
				_003F val;
				checked
				{
					val = 1357394258L - ((obj19 is ulong) ? obj19 : null);
					ulong num20 = num19;
					string text2 = text;
					formatProvider = formatProvider;
					formatProvider = formatProvider;
					num19 = num20 - unchecked((ulong)((byte*)11)->ToString(text2, formatProvider2));
				}
				num19 = (ulong)(long)val;
			}
			finally
			{
				while (((ulong*)1778738380L)->CompareTo(917921233uL) is bool)
				{
					void @void = default(void);
					_ = ulong.Parse(text) is void;
					uint num21;
					string s4;
					object obj21;
					MethodBase[] methodBase_;
					checked
					{
						num21 = unchecked((uint)(short)Settings.Default) + 4294967279u;
						s4 = text;
						object obj20 = ushort.Parse("j+LAcvY70ftxshpmIF1nWcRd3Ao0nfMw1++CnBHu2R2ICqqr4DoJsWFOX984tLUoUF5Sex9FW3Mg+g==");
						obj21 = ((obj20 is BindingFlags) ? obj20 : null);
						array5 = array5;
						methodBase_ = array5;
					}
					Type[] type_2 = int.Parse((((byte)Class0.smethod_0(bindingFlags, array5, null, null) != 0) ? ((bool*)1) : ((bool*)null))->Equals(flag) as string, (NumberStyles)((Class0)(object)((short*)2055)->ToString()).method_0(null, null, null), formatProvider) as Type[];
					object obj22 = long.Parse(string.Format((string)(object)Class0.smethod_0((BindingFlags)obj21, methodBase_, type_2, null), ((sbyte*)(-8))->CompareTo(b) as object[]), null);
					object obj23 = ((obj22 is NumberStyles) ? obj22 : null);
					sbyte num22 = b;
					string s5 = ((long*)(long)Settings.Default)->GetHashCode() as string;
					object obj24 = string.Compare("51qkXXIcPVPAvVHH73igqIya69mTh4yIiO6kmxGW+KLX1Lm2d3X1TL2BWmS7qk17mgHCIaiA4jHzzA==", -1591369052, text, (int)checked(286337771u - 736555855u), 2114145068, ignoreCase: true, (CultureInfo)(object)((sbyte*)(sbyte)((char*)(ushort)c)->ToString(null))->ToString(formatProvider));
					numberStyles = (NumberStyles)((obj24 is NumberStyles) ? obj24 : null);
					string text3 = text;
					text = ((long*)1471052011L)->GetTypeCode() as string;
					object obj25 = ((ulong*)(num19 / num19))->CompareTo(null);
					object obj26 = ((obj25 is BindingFlags) ? obj25 : null);
					BindingFlags bindingFlags_3 = bindingFlags;
					Class0 class2 = null;
					Class0 class3 = class2;
					object object_ = obj15;
					object obj27 = ((short*)13304)->GetTypeCode();
					int num3 = (int)((obj27 is int) ? obj27 : null);
					num3 = (int)checked(2719631713u * unchecked((uint)num23));
					uint num25 = 1195389880u / ((uint)num24 / 1219917360u / (uint)(int)((ushort*)6765)->ToString() / checked(unchecked((uint)num3) * 548765379u));
					string text4 = text;
					formatProvider = null;
					formatProvider = null;
					_ = (Type)(object)((int*)num25)->ToString(text4, formatProvider3);
					Type type = null;
					type = type2;
					num16 = (ushort)((ushort)class3.method_0(object_, type, null) / num16);
					char value = (char)Class0.smethod_0(bindingFlags_3, (MethodBase[])(object)((ushort*)checked(num26 * (28673u + unchecked((uint)num16))))->ToString(text), null, null);
					object obj28 = (nint)(IntPtr)num3;
					object obj29 = ((short*)((obj28 is short) ? obj28 : null))->CompareTo(-29596);
					int num27 = (int)((long*)((obj29 is long) ? obj29 : null))->ToString("EgL2V+s70+CaJt8esOLXCA67rK1+nfYbEIWWx7k2/4HEThUIrEVGnRRzx2gAviVbZc0BEB95xcVJBQ==");
					string s6 = text;
					numberStyles = default(NumberStyles);
					object obj30 = long.Parse(s6, numberStyles, (IFormatProvider)(object)Settings.Default);
					_003F val2 = checked(num27 + ((obj30 is int) ? obj30 : null));
					ushort num28 = num16;
					uint num29 = num6;
					uint num30 = num6;
					class2 = null;
					object object_2 = ((int*)num3)->GetHashCode() as object;
					text = "DYO75rsbHS4pmJfrRigCTgeEVv1+ake8+TEKIDrVAGXsAVbGGhuBjueoCh55oPJ6RepgaL43i0M19Q==";
					object obj31 = ((ushort*)checked(52903u * unchecked((uint)(ushort)((uint*)checked(num30 - unchecked(615972021u / (uint)class4.method_0(object_2, short.Parse(s7, null) as Type, (CultureInfo)(object)Class0.smethod_3(obj15, ulong.Parse("5hBHeeTMUXlQQ3dS+ygSu8GjSb9bbpAJ30OY7T6moHEmZjMz0Z7vFYuLrZhSKsRaWQ0kVU+7GCch2A==", numberStyles) as ResolveEventArgs)))))->ToString("Ysuzop1WPzLnf6uYd1eg4OaBXx0TlStrBv/BJs/X63Y54+YczO4qLjb5D9BMtw085bMHDOI/46lEQQ==", null))))->GetHashCode();
					object obj32 = ((obj31 is long) ? obj31 : null);
					num31 = 1269413997L;
					object obj33 = ((long*)obj32)->CompareTo(1269413997L);
					num6 = (uint)(int)checked(79620799 + num29 * ((obj33 is uint) ? obj33 : null));
					num6 = num32;
					byte[] array4 = null;
					int int_ = num3;
					text = "oVvAfNPubSyPZvhUZQBcY5o/g0GnjzW8r4oMt+950plgiWSz2hiQ1NL9fOquhUHg9dNvHmBW9zOgSA==";
					int num33 = (int)((int*)(-1988073127))->ToString(text5);
					object obj34 = text.Equals(text, (StringComparison)/*isinst with value type is only supported in some contexts*/);
					object obj35 = smethod_1(804802775u, smethod_1(1443460869u, null, int_, (int)((uint)num33 / (uint)(int)((IntPtr*)((obj34 is IntPtr) ? obj34 : null))->ToString("a9Acys86EnCCxU/4a9bjqq35woF4r9+OTHWhDGPt5GtCn8157CQA4nbssw8aCQ8Oz88pVOdPvwhvLA=="))) as byte[], (int)((uint*)num6)->ToString("UW66peHPafMqaLaHcqC79r3UjlOb8pFrv2gC35F4aZ7nmyooJT8b/b3mv53dSF3GnAeXQhdLzrUn4w==", formatProvider), (int)Settings.Default);
					_003F val3 = checked(((obj35 is int) ? obj35 : null) + 812063596);
					num3 = num3;
					object obj36 = ((long*)(/*isinst with value type is only supported in some contexts*/ / -268953729L))->Equals(obj15);
					MethodBase[] methodBase_2;
					string s8;
					NumberStyles style;
					object obj38;
					checked
					{
						methodBase_2 = "dKqGFVJpm6L17Fej4lu3cGCGQzBtxAR+fAwXtwOIbzo1yffe2ngzQ1pl+eU6kKeeR+0YQB7DVGKeKw==".IndexOf(value, val2 * unchecked(((obj36 is int) ? obj36 : null) / num3)) as MethodBase[];
						s8 = text;
						style = numberStyles;
						object obj37 = char.IsSurrogate(text, num3);
						obj38 = ((obj37 is short) ? obj37 : null);
					}
					object obj39 = ((ulong*)1676286073L)->CompareTo(obj15);
					IFormatProvider provider = ((short*)checked(obj38 - (-32596 - ((obj39 is short) ? obj39 : null))))->GetHashCode() as IFormatProvider;
					result = ref *(int*)null;
					type_2 = int.TryParse(s8, style, provider, out result) as Type[];
					object obj40 = text3.LastIndexOf(int.Parse(s9, (NumberStyles)Class0.smethod_0((BindingFlags)obj26, methodBase_2, type_3, null)) as string, num3);
					object obj41 = ((obj40 is short) ? obj40 : null);
					text = "Agbxe4F9Uy2ZymAcu5uQd0BufF1i1oNNN8dqRnQyvYJNeuIUHvoQ3Ylo2eXzFCQRjVAfGsCCzJ1suA==";
					int style2 = (int)obj23;
					ref _003F reference2 = ref *(_003F*)num22;
					object obj42 = ushort.Parse(s5, style3, (IFormatProvider)(object)((short*)obj41)->ToString(((ushort*)(ushort)smethod_0(string_))->GetHashCode() as string, formatProvider));
					object obj43 = ushort.Parse(s4, (NumberStyles)style2, System.Runtime.CompilerServices.Unsafe.As<_003F, sbyte>(ref reference2).CompareTo((sbyte)(int)((obj42 is sbyte) ? obj42 : null)) as IFormatProvider);
					num35 = (short)(int)((obj43 is short) ? obj43 : null);
					num35 = num36;
					num35 = (short)num21;
				}
				continue;
			}
		}
		while (bool.TryParse(text, out *(bool*)null));
		Class4 class5 = class5;
		class5 = null;
		if (((ushort*)51429)->CompareTo(obj15) is bool)
		{
			num16 = (ushort)smethod_0((string)(object)Settings.Default);
		}
		b = b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out short num37);
		while (true)
		{
			string s10 = text;
			object obj44 = ((sbyte*)b)->GetTypeCode();
			if (!int.TryParse(s10, (NumberStyles)((obj44 is NumberStyles) ? obj44 : null), null, out result))
			{
				break;
			}
			while (true)
			{
				num = (nint)checked(unchecked((nuint)num) + unchecked((nuint)unchecked((nint)default(IntPtr))));
				object obj45 = ((IntPtr*)intPtr)->Equals(null);
				num35 = (short)(int)((obj45 is short) ? obj45 : null);
				if (((short*)num37)->Equals(obj15))
				{
					_ = (sbyte)smethod_0("0/ME+MPsy5krYTl/XvX2JP5VKCxMKBlY+V/QBsL2DKWB/gujZVCCLg4Td/mnVP5hdj4hw/BvtnUN9A==");
				}
				else if (!((byte*)31)->Equals(obj15))
				{
					break;
				}
			}
		}
		byte b2 = b2;
		text = uint.Parse(((byte*)b2)->ToString((IFormatProvider?)null), numberStyles) as string;
		string s11 = text;
		string s12 = text;
		_ = ((long*)checked(unchecked((ulong)num31) + (unchecked((ulong)(long)Settings.Default) + unchecked((ulong)(long)Settings.Default))))->GetTypeCode() is NumberStyles;
		_ = (NumberStyles)Settings.Default;
		numberStyles = numberStyles;
		object obj46 = uint.TryParse(s11, out *(uint*)/*isinst with value type is only supported in some contexts*/);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s13);
		_ = char.IsHighSurrogate(s13, (int)((int*)((obj46 is int) ? obj46 : null))->ToString()) is string;
		uint num38 = num6;
		obj15 = null;
		ref _003F reference3 = ref *(_003F*)775776814;
		object obj48 = ((short*)/*isinst with value type is only supported in some contexts*/)->CompareTo(num35);
		object obj49 = System.Runtime.CompilerServices.Unsafe.As<_003F, uint>(ref reference3).CompareTo((uint)(int)checked(num38 * ((obj48 is uint) ? obj48 : null)));
		_ = ((long*)((obj49 is long) ? obj49 : null))->GetHashCode() is Class1;
		_ = ulong.Parse(text) is string;
		text = text;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text6);
		text = text6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string s14);
		_ = ushort.TryParse(s14, numberStyles, null, out *(ushort*)null) is Resources;
		_ = (Class0)(object)((IntPtr*)default(IntPtr))->ToString();
	}
}
