using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using h;

namespace h13;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Resource1
{
	internal sealed class F
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct R
		{
		}

		private static readonly Array Y;

		private static readonly object S;

		private static readonly Array M;

		internal static R V/* Not supported: data(F7 DE F6 DE F7 DE 2A C5 84 FE 8A FE 85 FE 7D F7 78 E5 3F EA 4D D4 7E C4 FA E0 BA DE F2 E0 72 F7 66 E5 3B EA 4E D4 68 C4 F3 E0 4A 9E 4B 9E 48 9E 89 A4 A5 28 A1 28 A6 28 DA 36 9E 08 D1 36 46 21 D6 56 DE 56 D2 56 45 42 27 7C 63 6C A9 48 F7 76 B7 48 24 5F 10 4D) */;

		internal static string L(int P_0, int P_1, int P_2)
		{
			IComparable comparable = default(IComparable);
			int num6 = default(int);
			object obj6 = default(object);
			object obj3 = default(object);
			object obj2 = default(object);
			char c = default(char);
			int num7 = default(int);
			int num5 = default(int);
			int num8 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = P_1 ^ 0x1FB6094B ^ P_2;
				object s = S;
				char[] obj = (char[])s;
				int num2 = obj[num];
				num2 = obj[num + 2] ^ num2;
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 14;
						continue;
					case 14:
						break;
					case 3:
						num3 = (((comparable = ((string[])M)[num2]) == null) ? 9 : 5);
						continue;
					case 5:
					case 8:
						return comparable as string;
					case 9:
					{
						char[] obj4 = (char[])s;
						char[] obj5 = (char[])Y;
						num6 = num;
						obj6 = obj5;
						obj3 = obj4;
						num3 = 1;
						continue;
					}
					case 1:
						obj2 = new StringBuilder();
						c = ((char[])obj3)[num6];
						num7 = ((char[])obj3)[num6 + 1] ^ c;
						num3 = 2;
						continue;
					case 2:
						num6 += 3;
						num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
						num3 = 13;
						continue;
					case 13:
						num3 = (((num7 & 0x20) == 0) ? 15 : 7);
						continue;
					case 7:
					case 16:
						num5 = (num5 << 15) | (((char[])obj3)[num6++] ^ c);
						num3 = 15;
						continue;
					case 15:
						num8 = (obj6 as char[]).Length;
						goto case 12;
					case 12:
						num4 = 1;
						num3 = 11;
						continue;
					case 6:
						(obj2 as StringBuilder).Append((char)(c ^ (obj3 as char[])[num6 + num5 - num4] ^ ((char[])obj6)[(num4 + num6 + 17) % num8]));
						num3 = 0;
						continue;
					case 0:
						num4++;
						num3 = 11;
						continue;
					case 11:
						num3 = ((num4 <= num5) ? 6 : 10);
						continue;
					case 10:
						comparable = (obj2 as StringBuilder).ToString();
						((string[])M)[num2] = (string)comparable;
						num3 = 17;
						continue;
					case 17:
						return comparable as string;
					}
					break;
				}
			}
		}

		static F()
		{
			//Discarded unreachable code: IL_00db
			int num = 1;
			object obj = default(object);
			while (true)
			{
				switch (num)
				{
				case 0:
					(obj as char[])[2] = '㪕';
					((char[])obj)[5] = 'ᮕ';
					num = 5;
					continue;
				case 3:
				case 5:
				case 7:
					((char[])obj)[4] = 'ᓚ';
					goto case 2;
				case 2:
					((char[])obj)[6] = 'গ';
					num = 4;
					continue;
				case 4:
					((char[])obj)[7] = 'Ḇ';
					(obj as char[])[1] = 'Ḛ';
					num = 6;
					continue;
				case 6:
					((char[])obj)[3] = '⪤';
					M = new string[5];
					Y = (char[])obj;
					return;
				}
				S = new char[43]
				{
					'\udef7', '\udef6', '\udef7', '씪', 'ﺄ', 'ﺊ', 'ﺅ', '\uf77d', '\ue578', '\uea3f',
					'푍', '쑾', '\ue0fa', '\udeba', '\ue0f2', '\uf772', '\ue566', '\uea3b', '푎', '쑨',
					'\ue0f3', '鹊', '鹋', '鹈', 'ꒉ', '⢥', '⢡', '⢦', '㛚', '\u089e',
					'㛑', 'ⅆ', '囖', '回', '囒', '䉅', '簧', '汣', '䢩', '盷',
					'䢷', '弤', '䴐'
				};
				obj = new char[8];
				(obj as char[])[0] = '⁎';
				num = 0;
			}
		}
	}

	private static ResourceManager Q;

	private static CultureInfo I;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager n
	{
		get
		{
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
					num = ((Q != null) ? 4 : 2);
					break;
				case 0:
				case 2:
					Q = new ResourceManager("Project1.Resource1", typeof(Resource1).Assembly);
					num = 4;
					break;
				case 4:
				{
					ResourceManager result = Q;
					h.E.W.k[408] = (char)((h.E.W.k[408] * h.E.W.k[338]) & 'Ä');
					return result;
				}
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo q
	{
		get
		{
			return I;
		}
		set
		{
			I = value;
		}
	}

	internal static Bitmap E => (Bitmap)n.GetObject(F.L(6, 532023625, 2), I);

	internal static Bitmap i => (Bitmap)n.GetObject(F.L(2, 532023641, 7), I);

	static void @_002B_0029_003D_007C__0040_0040_002A20()
	{
		//IL_0076: Expected O, but got I4
		//IL_007f: Expected I, but got O
		//IL_0080: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0217: Expected I, but got O
		//IL_0218: Expected O, but got I4
		//IL_028e: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03bd: Expected O, but got I4
		//IL_0424: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_0504: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (AssmeblyLoader)(object)n.d();
				obj = obj;
			}
			while (obj != null);
		}
		UIntPtr intPtr = uIntPtr;
		byte[] array = array;
		nint num = (IntPtr)j.M(j.M(j.M(array)));
		object obj2 = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)j.M(global::h.E.C((IntPtr)/*isinst with value type is only supported in some contexts*/) as byte[])) + unchecked((nuint)(nint)(IntPtr)j.M(array))));
		_003F val;
		object obj3;
		checked
		{
			val = unchecked((nuint)intPtr) * ((obj2 is UIntPtr) ? obj2 : null);
			obj3 = global::h.E.C(num);
		}
		if (checked(val * ((obj3 is UIntPtr) ? obj3 : null)) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (CHOOSEFONTFLAGS)n.d();
			}
			else
			{
				_ = (E)(object)n.d();
			}
		}
		AssmeblyLoader assmeblyLoader = assmeblyLoader;
		assmeblyLoader = assmeblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		try
		{
			h = h;
			h = h;
		}
		catch
		{
			_ = (CHOOSEFONTFLAGS)j.M(j.M(array));
		}
		do
		{
			_ = (_003CModule_003E)(object)j.M(global::h.E.C(num) as byte[]);
		}
		while ((object)n.d() != null);
		_003CModule_003E _003CModule_003E;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
			while (obj != null)
			{
				try
				{
					x = x;
					x = default(X);
					x = x;
				}
				finally
				{
					num = default(IntPtr);
					_003CModule_003E obj5 = global::h.E.C(num) as _003CModule_003E;
					_003CModule_003E = (_003CModule_003E)(object)j.M(n.d());
					_003CModule_003E = obj5;
					continue;
				}
			}
		}
		_ = (IAssemblyLoader)(object)n.d();
		_003CModule_003E = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		try
		{
			do
			{
				try
				{
					_ = (X)j.M(n.d());
				}
				finally
				{
					object obj6 = global::h.E.C((IntPtr)j.M(array));
					_ = global::h.E.C((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is H;
					continue;
				}
			}
			while ((object)null != null);
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					n = (n)(object)n.d();
					n = null;
				}
				else
				{
					_003CModule_003E = null;
				}
			}
			catch
			{
				try
				{
					h = h;
					_ = (CHOOSEFONTFLAGS)n.d();
					num = default(IntPtr);
					object obj7 = global::h.E.C(num);
					X x = (X)((obj7 is X) ? obj7 : null);
					goto end_IL_0265;
				}
				finally
				{
					h = h;
					h = h;
					goto end_IL_0265;
				}
				end_IL_0265:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		while ((object)null != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					resource = resource;
					resource = resource;
					_ = global::h.E.C(num) is X;
				}
				catch
				{
					n = null;
				}
			}
			else
			{
				do
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				while ((object)j.M(j.M(null)) != null);
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (checked((uIntPtr + uIntPtr) * unchecked((nuint)(UIntPtr)n.d())) == 0)
		{
			while (obj != null)
			{
				try
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				catch
				{
					_ = (X)j.M(null);
					_ = global::h.E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)unchecked((nint)default(IntPtr))))) is CHOOSEFONTFLAGS;
					_003CPrivateImplementationDetails_003E obj11 = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
					num = default(IntPtr);
					_003CPrivateImplementationDetails_003E = global::h.E.C(num) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = obj11;
				}
			}
			goto IL_0493;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				resource = resource;
			}
			else
			{
				_ = (X)n.d();
			}
		}
		finally
		{
			num = default(IntPtr);
			_ = global::h.E.C(num) is Resource1;
			_ = (_003CPrivateImplementationDetails_003E)(object)j.M(j.M(j.M(array)));
			n = n;
			goto IL_0493;
		}
		IL_0493:
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = global::h.E.C(num) is H;
				}
			}
			catch
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)j.M(null) != null)
			{
				try
				{
					n = null;
				}
				catch
				{
					j j = null;
					j = null;
				}
			}
		}
		else
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
				num = default(IntPtr);
			}
			while (global::h.E.C(num) is object);
		}
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n)(object)j.M(array);
				}
				finally
				{
					_ = (E)(object)n.d();
					goto end_IL_050e;
				}
			}
			E obj15 = (E)(object)n.d();
			E e = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)j.M(array)) - unchecked((nuint)num))) as E;
			e = obj15;
			end_IL_050e:;
		}
		catch
		{
			try
			{
				try
				{
					n = n;
				}
				catch
				{
					_ = (CHOOSEFONTFLAGS)j.M(n.d());
				}
			}
			catch
			{
				h = default(H);
			}
		}
		while ((object)null != null)
		{
			_ = (H)j.M(null);
		}
	}

	internal Resource1()
	{
	}

	static void @_002B_0029_003D_007C__0040_0040_002A20()
	{
		//IL_0076: Expected O, but got I4
		//IL_007f: Expected I, but got O
		//IL_0080: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got I4
		//IL_019e: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_0217: Expected I, but got O
		//IL_0218: Expected O, but got I4
		//IL_028e: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03bd: Expected O, but got I4
		//IL_0424: Expected O, but got I4
		//IL_047c: Expected O, but got I4
		//IL_0504: Expected O, but got I4
		//IL_0545: Expected O, but got I4
		nuint uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (AssmeblyLoader)(object)n.d();
				obj = obj;
			}
			while (obj != null);
		}
		UIntPtr intPtr = uIntPtr;
		byte[] array = array;
		nint num = (IntPtr)j.M(j.M(j.M(array)));
		object obj2 = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)j.M(global::h.E.C((IntPtr)/*isinst with value type is only supported in some contexts*/) as byte[])) + unchecked((nuint)(nint)(IntPtr)j.M(array))));
		_003F val;
		object obj3;
		checked
		{
			val = unchecked((nuint)intPtr) * ((obj2 is UIntPtr) ? obj2 : null);
			obj3 = global::h.E.C(num);
		}
		if (checked(val * ((obj3 is UIntPtr) ? obj3 : null)) == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (CHOOSEFONTFLAGS)n.d();
			}
			else
			{
				_ = (E)(object)n.d();
			}
		}
		AssmeblyLoader assmeblyLoader = assmeblyLoader;
		assmeblyLoader = assmeblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		try
		{
			h = h;
			h = h;
		}
		catch
		{
			_ = (CHOOSEFONTFLAGS)j.M(j.M(array));
		}
		do
		{
			_ = (_003CModule_003E)(object)j.M(global::h.E.C(num) as byte[]);
		}
		while ((object)n.d() != null);
		_003CModule_003E _003CModule_003E;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
			while (obj != null)
			{
				try
				{
					x = x;
					x = default(X);
					x = x;
				}
				finally
				{
					num = default(IntPtr);
					_003CModule_003E obj5 = global::h.E.C(num) as _003CModule_003E;
					_003CModule_003E = (_003CModule_003E)(object)j.M(n.d());
					_003CModule_003E = obj5;
					continue;
				}
			}
		}
		_ = (IAssemblyLoader)(object)n.d();
		_003CModule_003E = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		try
		{
			do
			{
				try
				{
					_ = (X)j.M(n.d());
				}
				finally
				{
					object obj6 = global::h.E.C((IntPtr)j.M(array));
					_ = global::h.E.C((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is H;
					continue;
				}
			}
			while ((object)null != null);
		}
		catch
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					n = (n)(object)n.d();
					n = null;
				}
				else
				{
					_003CModule_003E = null;
				}
			}
			catch
			{
				try
				{
					h = h;
					_ = (CHOOSEFONTFLAGS)n.d();
					num = default(IntPtr);
					object obj7 = global::h.E.C(num);
					X x = (X)((obj7 is X) ? obj7 : null);
					goto end_IL_0265;
				}
				finally
				{
					h = h;
					h = h;
					goto end_IL_0265;
				}
				end_IL_0265:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		while ((object)null != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				try
				{
					resource = resource;
					resource = resource;
					_ = global::h.E.C(num) is X;
				}
				catch
				{
					n = null;
				}
			}
			else
			{
				do
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				while ((object)j.M(j.M(null)) != null);
			}
		}
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (checked((uIntPtr + uIntPtr) * unchecked((nuint)(UIntPtr)n.d())) == 0)
		{
			while (obj != null)
			{
				try
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				catch
				{
					_ = (X)j.M(null);
					_ = global::h.E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)unchecked((nint)default(IntPtr))))) is CHOOSEFONTFLAGS;
					_003CPrivateImplementationDetails_003E obj11 = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
					num = default(IntPtr);
					_003CPrivateImplementationDetails_003E = global::h.E.C(num) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = obj11;
				}
			}
			goto IL_0493;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				resource = resource;
			}
			else
			{
				_ = (X)n.d();
			}
		}
		finally
		{
			num = default(IntPtr);
			_ = global::h.E.C(num) is Resource1;
			_ = (_003CPrivateImplementationDetails_003E)(object)j.M(j.M(j.M(array)));
			n = n;
			goto IL_0493;
		}
		IL_0493:
		while (obj != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = global::h.E.C(num) is H;
				}
			}
			catch
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while ((object)j.M(null) != null)
			{
				try
				{
					n = null;
				}
				catch
				{
					j j = null;
					j = null;
				}
			}
		}
		else
		{
			do
			{
				_003CModule_003E = _003CModule_003E;
				num = default(IntPtr);
			}
			while (global::h.E.C(num) is object);
		}
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (n)(object)j.M(array);
				}
				finally
				{
					_ = (E)(object)n.d();
					goto end_IL_050e;
				}
			}
			E obj15 = (E)(object)n.d();
			E e = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)j.M(array)) - unchecked((nuint)num))) as E;
			e = obj15;
			end_IL_050e:;
		}
		catch
		{
			try
			{
				try
				{
					n = n;
				}
				catch
				{
					_ = (CHOOSEFONTFLAGS)j.M(n.d());
				}
			}
			catch
			{
				h = default(H);
			}
		}
		while ((object)null != null)
		{
			_ = (H)j.M(null);
		}
	}
}
