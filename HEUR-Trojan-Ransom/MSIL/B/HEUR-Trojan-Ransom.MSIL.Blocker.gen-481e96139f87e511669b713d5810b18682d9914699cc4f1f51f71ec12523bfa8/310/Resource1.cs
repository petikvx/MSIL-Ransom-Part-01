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
using l;

namespace _310;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Resource1
{
	internal sealed class v
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 86)]
		private struct P
		{
		}

		private static readonly Array T;

		private static readonly object b;

		private static readonly Array u;

		internal static P q/* Not supported: data(AA 81 AB 81 AA 81 F6 88 B4 D1 BA D1 B5 D1 FD F2 F5 D8 3D DE 89 F7 7C D3 37 D1 FA D1 AE C6 F2 F2 EB D8 39 DE 8A F7 6A D3 3E D1 78 6D 79 6D 7A 6D A9 6F 00 C0 04 C0 03 C0 82 C0 4B C0 18 D7 53 E3 A9 2C A1 2C AD 2C 08 23 AC 0A 2E 2E 2B 2C F8 2C A4 3B EB 0F D2 25) */;

		internal static string E(int P_0, int P_1, int P_2, v P_3)
		{
			ICloneable cloneable = default(ICloneable);
			int num6 = default(int);
			object obj6 = default(object);
			Array array = default(Array);
			object obj3 = default(object);
			char c = default(char);
			int num7 = default(int);
			int num5 = default(int);
			int num8 = default(int);
			int num4 = default(int);
			while (true)
			{
				int num = P_0 ^ 0x522D032 ^ P_2;
				object obj = b;
				char[] obj2 = (char[])obj;
				int num2 = obj2[num];
				num2 = obj2[num + 2] ^ num2;
				int num3 = 9;
				while (true)
				{
					switch (num3)
					{
					default:
						/*OpCode not supported: LdMemberToken*/;
						num3 = 1;
						continue;
					case 1:
						break;
					case 9:
					case 12:
						num3 = (((cloneable = ((string[])u)[num2]) == null) ? 5 : 16);
						continue;
					case 16:
						return (string)cloneable;
					case 5:
					{
						char[] obj4 = (char[])obj;
						char[] obj5 = (char[])T;
						num6 = num;
						obj6 = obj5;
						array = obj4;
						num3 = 3;
						continue;
					}
					case 3:
						obj3 = new StringBuilder();
						c = ((char[])array)[num6];
						goto case 14;
					case 14:
						num7 = ((char[])array)[num6 + 1] ^ c;
						num3 = 7;
						continue;
					case 7:
						num6 += 3;
						num5 = (num7 & 0x1F) | ((num7 & 0xFFC0) >> 1);
						num3 = 17;
						continue;
					case 17:
						num3 = (((num7 & 0x20) == 0) ? 6 : 13);
						continue;
					case 13:
						num5 = (num5 << 15) | ((array as char[])[num6++] ^ c);
						num3 = 6;
						continue;
					case 6:
						num8 = (obj6 as char[]).Length;
						num4 = 1;
						goto case 2;
					case 2:
						num3 = 8;
						continue;
					case 10:
						(obj3 as StringBuilder).Append((char)(c ^ ((char[])array)[num6 + num5 - num4] ^ (obj6 as char[])[(num4 + num6 + 17) % num8]));
						num3 = 15;
						continue;
					case 15:
						num4++;
						num3 = 8;
						continue;
					case 8:
						num3 = ((num4 <= num5) ? 10 : 11);
						continue;
					case 11:
						cloneable = (obj3 as StringBuilder).ToString();
						((string[])u)[num2] = (string)cloneable;
						num3 = 0;
						continue;
					case 0:
						return cloneable as string;
					}
					break;
				}
			}
		}

		static v()
		{
			//Discarded unreachable code: IL_00d8
			int num = 3;
			Array array = default(Array);
			while (true)
			{
				switch (num)
				{
				default:
					b = new char[43]
					{
						'膪', '膫', '膪', '裶', '톴', '톺', '통', '\uf2fd', '\ud8f5', '\ude3d',
						'\uf789', '퍼', '턷', '퇺', '욮', '\uf2f2', '\ud8eb', '\ude39', '\uf78a', '퍪',
						'턾', '浸', '浹', '浺', '澩', '쀀', '쀄', '쀃', '삂', '쁋',
						'휘', '\ue353', 'ⲩ', 'ⲡ', 'ⲭ', '⌈', 'બ', '⸮', 'Ⱛ', '\u2cf8',
						'㮤', '\u0feb', '◒'
					};
					array = new char[8];
					((char[])array)[7] = 'ᝪ';
					num = 1;
					continue;
				case 1:
					((char[])array)[1] = 'ç';
					(array as char[])[0] = '>';
					num = 4;
					continue;
				case 4:
					(array as char[])[5] = 'न';
					((char[])array)[3] = '♐';
					num = 2;
					continue;
				case 2:
					((char[])array)[6] = '⌧';
					goto case 7;
				case 7:
					((char[])array)[2] = 'ʧ';
					num = 5;
					continue;
				case 5:
				case 6:
					(array as char[])[4] = '\u0fe8';
					u = new string[5];
					break;
				case 0:
					break;
				}
				break;
			}
			T = array as char[];
		}
	}

	private static ResourceManager P;

	private static CultureInfo d;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager j
	{
		get
		{
			char[] a = y.A;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				default:
				{
					ResourceManager p = P;
					y.A[180] = (char)((y.A[180] | y.A[160]) & '\u001e');
					num = ((p != null) ? (a[114] - 28352) : 5);
					break;
				}
				case 3:
				case 5:
					P = new ResourceManager("Project1.Resource1", typeof(Resource1).Assembly);
					num = 0;
					break;
				case 0:
				case 4:
					return P;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo S
	{
		get
		{
			return d;
		}
		set
		{
			d = value;
		}
	}

	internal static Bitmap M => (Bitmap)j.GetObject(v.E(86167605, 7, 7, null), d);

	internal static Bitmap I => (Bitmap)j.GetObject(v.E(86167590, 4, 1, null), d);

	static void _007D_0025_003A_003A_007C_0040_0024_0025_007B_005E_007C_003A21()
	{
		//IL_003d: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected I, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got I4
		//IL_03c7: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		//IL_04cf: Expected O, but got I4
		//IL_04d8: Expected I, but got O
		//IL_04d9: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			do
			{
				try
				{
					resource = null;
					resource = null;
					resource = null;
					array = null;
					num = (IntPtr)T.h(array);
					num = default(IntPtr);
					resource = y.t(num) as Resource1;
				}
				catch
				{
					num = default(IntPtr);
					_ = y.t(num) is IAssemblyLoader;
				}
				obj2 = F.A();
			}
			while (obj2 != null);
		}
		finally
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					num = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num) * unchecked((nuint)(nint)(IntPtr)F.A()))) is F;
					f = f;
					f = f;
					_ = y.t(num) is CHOOSEFONTFLAGS;
				}
			}
			goto IL_00ec;
		}
		IL_00ec:
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
			_003CModule_003E = _003CModule_003E;
		}
		_ = (AssmeblyLoader)(object)T.h(null);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		try
		{
			try
			{
				h h = (h)F.A();
				h = h;
			}
			catch
			{
				resource = null;
			}
		}
		catch
		{
			f = f;
		}
		finally
		{
			try
			{
				do
				{
					nint intPtr = num;
					nint intPtr2 = num;
					IntPtr intPtr3 = (IntPtr)T.h(array);
					num = default(IntPtr);
					nint intPtr4 = num;
					num = default(IntPtr);
					object obj5 = y.t(num);
					_003F val;
					checked
					{
						val = unchecked((nuint)(nint)intPtr3) - (intPtr4 - (((obj5 is IntPtr) ? obj5 : null) - (unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)F.A()))));
						num = default(IntPtr);
					}
					_ = (CHOOSEFONTFLAGS)T.h(y.t(intPtr / checked(intPtr2 + (val + (unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(null)))) + num)) as byte[]);
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = null;
					r = r;
					r = r;
					_ = (_003CModule_003E)(object)F.A();
					_ = y.t((nint)checked(unchecked((nuint)num) * unchecked((nuint)num))) is h;
				}
				finally
				{
					_003CPrivateImplementationDetails_003E obj6 = y.t((IntPtr)F.A()) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
					_003CPrivateImplementationDetails_003E = obj6;
					resource = resource;
					r = r;
					goto IL_0279;
				}
			}
		}
		IL_0343:
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		if ((nuint)(UIntPtr)T.h(null) / (nuint)(UIntPtr)F.A() == 0)
		{
			do
			{
				y = y.t(num) as y;
				y = null;
			}
			while (obj2 != null || obj2 != null);
		}
		resource = resource;
		_ = (Resource1)(object)F.A();
		while (obj2 != null)
		{
			num = default(IntPtr);
			_ = y.t((nint)((nuint)num / (nuint)num)) is _003CPrivateImplementationDetails_003E;
			assmeblyLoader = assmeblyLoader;
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				do
				{
					num = default(IntPtr);
					_ = y.t(num) is IAssemblyLoader;
					y = y;
				}
				while (obj2 != null);
			}
		}
		else
		{
			_003CPrivateImplementationDetails_003E = null;
		}
		resource = resource;
		_ = (Resource1)(object)T.h(null);
		_ = y.t((IntPtr)F.A()) is Resource1;
		if (checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
		{
			resource = (Resource1)(object)T.h(array);
		}
		else
		{
			while (obj2 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (h)F.A();
					continue;
				}
				_ = (h)T.h(array);
				object obj7 = y.t(num);
				_ = y.t((IntPtr)((obj7 is IntPtr) ? obj7 : null)) is CHOOSEFONT;
				_ = (IAssemblyLoader)(object)T.h(null);
			}
		}
		try
		{
			try
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					y = y;
				}
				finally
				{
					_ = (r)T.h(array);
					goto end_IL_04f7;
				}
				end_IL_04f7:;
			}
			finally
			{
				try
				{
					h h = default(h);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				goto end_IL_04f6;
			}
			end_IL_04f6:;
		}
		catch
		{
			_ = y.t(default(IntPtr)) is _003CModule_003E;
		}
		try
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				do
				{
					y = y;
				}
				while ((object)null != null);
			}
		}
		finally
		{
			try
			{
				try
				{
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_0597;
				}
				end_IL_0597:;
			}
			catch
			{
				if ((UIntPtr)T.h(T.h(array)) == (UIntPtr)(nuint)0u)
				{
					_ = (h)T.h(null);
				}
				else
				{
					y = (y)(object)T.h(array);
				}
			}
			goto IL_0606;
		}
		IL_0606:
		do
		{
			r = (r)T.h(array);
		}
		while (obj2 != null);
		try
		{
			do
			{
				r = r;
			}
			while (obj2 != null || obj2 != null);
			return;
		}
		catch
		{
			_ = (Resource1)(object)T.h(null);
			return;
		}
		IL_0279:
		try
		{
			while (obj2 != null)
			{
				try
				{
					r = (r)T.h(F.A());
				}
				catch
				{
					resource = null;
				}
			}
		}
		catch
		{
			T obj13 = (T)(object)T.h(array);
			T t = t;
			t = obj13;
		}
		uIntPtr = default(UIntPtr);
		nuint num2 = uIntPtr;
		num = default(IntPtr);
		object obj15 = y.t(num);
		if ((int)checked(num2 + ((obj15 is UIntPtr) ? obj15 : null) * (uIntPtr * uIntPtr)) == 0)
		{
			try
			{
				while (obj2 != null)
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
				}
			}
			finally
			{
				CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = cHOOSEFONT;
				goto IL_0343;
			}
		}
		goto IL_0343;
	}

	internal Resource1()
	{
	}

	static void _007D_0025_003A_003A_007C_0040_0024_0025_007B_005E_007C_003A21()
	{
		//IL_003d: Expected O, but got I4
		//IL_005f: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected I, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_0230: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_02f7: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got I4
		//IL_03c7: Expected O, but got I4
		//IL_040f: Expected O, but got I4
		//IL_0457: Expected O, but got I4
		//IL_04cf: Expected O, but got I4
		//IL_04d8: Expected I, but got O
		//IL_04d9: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			do
			{
				try
				{
					resource = null;
					resource = null;
					resource = null;
					array = null;
					num = (IntPtr)T.h(array);
					num = default(IntPtr);
					resource = y.t(num) as Resource1;
				}
				catch
				{
					num = default(IntPtr);
					_ = y.t(num) is IAssemblyLoader;
				}
				obj2 = F.A();
			}
			while (obj2 != null);
		}
		finally
		{
			uIntPtr = uIntPtr;
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while (obj2 != null)
				{
					num = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num) * unchecked((nuint)(nint)(IntPtr)F.A()))) is F;
					f = f;
					f = f;
					_ = y.t(num) is CHOOSEFONTFLAGS;
				}
			}
			goto IL_00ec;
		}
		IL_00ec:
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
			_003CModule_003E = _003CModule_003E;
		}
		_ = (AssmeblyLoader)(object)T.h(null);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		try
		{
			try
			{
				h h = (h)F.A();
				h = h;
			}
			catch
			{
				resource = null;
			}
		}
		catch
		{
			f = f;
		}
		finally
		{
			try
			{
				do
				{
					nint intPtr = num;
					nint intPtr2 = num;
					IntPtr intPtr3 = (IntPtr)T.h(array);
					num = default(IntPtr);
					nint intPtr4 = num;
					num = default(IntPtr);
					object obj5 = y.t(num);
					_003F val;
					checked
					{
						val = unchecked((nuint)(nint)intPtr3) - (intPtr4 - (((obj5 is IntPtr) ? obj5 : null) - (unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)F.A()))));
						num = default(IntPtr);
					}
					_ = (CHOOSEFONTFLAGS)T.h(y.t(intPtr / checked(intPtr2 + (val + (unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(null)))) + num)) as byte[]);
				}
				while (obj2 != null);
			}
			finally
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = null;
					r = r;
					r = r;
					_ = (_003CModule_003E)(object)F.A();
					_ = y.t((nint)checked(unchecked((nuint)num) * unchecked((nuint)num))) is h;
				}
				finally
				{
					_003CPrivateImplementationDetails_003E obj6 = y.t((IntPtr)F.A()) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
					_003CPrivateImplementationDetails_003E = obj6;
					resource = resource;
					r = r;
					goto IL_0279;
				}
			}
		}
		IL_0343:
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		if ((nuint)(UIntPtr)T.h(null) / (nuint)(UIntPtr)F.A() == 0)
		{
			do
			{
				y = y.t(num) as y;
				y = null;
			}
			while (obj2 != null || obj2 != null);
		}
		resource = resource;
		_ = (Resource1)(object)F.A();
		while (obj2 != null)
		{
			num = default(IntPtr);
			_ = y.t((nint)((nuint)num / (nuint)num)) is _003CPrivateImplementationDetails_003E;
			assmeblyLoader = assmeblyLoader;
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				do
				{
					num = default(IntPtr);
					_ = y.t(num) is IAssemblyLoader;
					y = y;
				}
				while (obj2 != null);
			}
		}
		else
		{
			_003CPrivateImplementationDetails_003E = null;
		}
		resource = resource;
		_ = (Resource1)(object)T.h(null);
		_ = y.t((IntPtr)F.A()) is Resource1;
		if (checked(uIntPtr * unchecked((nuint)default(UIntPtr))) == 0)
		{
			resource = (Resource1)(object)T.h(array);
		}
		else
		{
			while (obj2 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (h)F.A();
					continue;
				}
				_ = (h)T.h(array);
				object obj7 = y.t(num);
				_ = y.t((IntPtr)((obj7 is IntPtr) ? obj7 : null)) is CHOOSEFONT;
				_ = (IAssemblyLoader)(object)T.h(null);
			}
		}
		try
		{
			try
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					y = y;
				}
				finally
				{
					_ = (r)T.h(array);
					goto end_IL_04f7;
				}
				end_IL_04f7:;
			}
			finally
			{
				try
				{
					h h = default(h);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				goto end_IL_04f6;
			}
			end_IL_04f6:;
		}
		catch
		{
			_ = y.t(default(IntPtr)) is _003CModule_003E;
		}
		try
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				do
				{
					y = y;
				}
				while ((object)null != null);
			}
		}
		finally
		{
			try
			{
				try
				{
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_0597;
				}
				end_IL_0597:;
			}
			catch
			{
				if ((UIntPtr)T.h(T.h(array)) == (UIntPtr)(nuint)0u)
				{
					_ = (h)T.h(null);
				}
				else
				{
					y = (y)(object)T.h(array);
				}
			}
			goto IL_0606;
		}
		IL_0606:
		do
		{
			r = (r)T.h(array);
		}
		while (obj2 != null);
		try
		{
			do
			{
				r = r;
			}
			while (obj2 != null || obj2 != null);
			return;
		}
		catch
		{
			_ = (Resource1)(object)T.h(null);
			return;
		}
		IL_0279:
		try
		{
			while (obj2 != null)
			{
				try
				{
					r = (r)T.h(F.A());
				}
				catch
				{
					resource = null;
				}
			}
		}
		catch
		{
			T obj13 = (T)(object)T.h(array);
			T t = t;
			t = obj13;
		}
		uIntPtr = default(UIntPtr);
		nuint num2 = uIntPtr;
		num = default(IntPtr);
		object obj15 = y.t(num);
		if ((int)checked(num2 + ((obj15 is UIntPtr) ? obj15 : null) * (uIntPtr * uIntPtr)) == 0)
		{
			try
			{
				while (obj2 != null)
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
				}
			}
			finally
			{
				CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = cHOOSEFONT;
				goto IL_0343;
			}
		}
		goto IL_0343;
	}
}
