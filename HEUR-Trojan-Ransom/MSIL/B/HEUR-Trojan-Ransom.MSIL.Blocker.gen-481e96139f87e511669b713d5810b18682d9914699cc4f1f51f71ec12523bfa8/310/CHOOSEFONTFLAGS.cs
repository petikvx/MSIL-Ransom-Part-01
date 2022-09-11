using System;
using System.Runtime.CompilerServices;
using l;

namespace _310;

[Flags]
public enum CHOOSEFONTFLAGS
{
	CF_SCREENFONTS = 1,
	CF_PRINTERFONTS = 2,
	CF_BOTH = 3,
	CF_SHOWHELP = 4,
	CF_ENABLEHOOK = 8,
	CF_ENABLETEMPLATE = 0x10,
	CF_ENABLETEMPLATEHANDLE = 0x20,
	CF_INITTOLOGFONTSTRUCT = 0x40,
	CF_USESTYLE = 0x80,
	CF_EFFECTS = 0x100,
	CF_APPLY = 0x200,
	CF_ANSIONLY = 0x400,
	CF_SCRIPTSONLY = 0x400,
	CF_NOVECTORFONTS = 0x800,
	CF_NOOEMFONTS = 0x800,
	CF_NOSIMULATIONS = 0x1000,
	CF_LIMITSIZE = 0x2000,
	CF_FIXEDPITCHONLY = 0x4000,
	CF_WYSIWYG = 0x8000,
	CF_FORCEFONTEXIST = 0x10000,
	CF_SCALABLEONLY = 0x20000,
	CF_TTONLY = 0x40000,
	CF_NOFACESEL = 0x80000,
	CF_NOSTYLESEL = 0x100000,
	CF_NOSIZESEL = 0x200000,
	CF_SELECTSCRIPT = 0x400000,
	CF_NOSCRIPTSEL = 0x800000,
	CF_NOVERTFONTS = 0x1000000,
	CF_INACTIVEFONTS = 0x2000000,
	static void _007D_0023_0040_003A_005D_0040_0024_0028_0040_005E_007C_003F15()
	{
		//IL_0043: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected I, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_02dd: Expected I, but got O
		//IL_02de: Expected O, but got I4
		//IL_0303: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_03d6: Expected I, but got O
		//IL_03d7: Expected O, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got I4
		//IL_04c9: Expected O, but got I4
		//IL_04ff: Expected O, but got I4
		//IL_05c9: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0656: Expected O, but got I4
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected I, but got Unknown
		//IL_0665: Expected O, but got I4
		//IL_067a: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_0703: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_0742: Expected O, but got I4
		//IL_07a5: Expected O, but got I4
		//IL_0865: Expected O, but got I4
		//IL_094a: Expected O, but got I4
		//IL_0960: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while ((object)null != null)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		r r;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		try
		{
			do
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					num = num;
					_ = y.t(num) is CHOOSEFONTFLAGS;
					goto IL_004a;
				}
				IL_004a:
				obj = null;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					num = default(IntPtr);
					_ = y.t(num) is CHOOSEFONTFLAGS;
				}
			}
			finally
			{
				do
				{
					array = array;
					r = (r)T.h(array);
					r = default(r);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				while (obj != null);
				goto IL_00d4;
			}
		}
		IL_0258:
		UIntPtr num2;
		if (checked(unchecked((nuint)(UIntPtr)F.A()) + (num2 - num2)) == 0)
		{
			r = r;
			_ = (T)(object)F.A();
			_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)num))) is CHOOSEFONT;
		}
		while (obj != null)
		{
			if (num2 / (nuint)(UIntPtr)F.A() == 0)
			{
				while (y.t((nint)((nuint)(nint)(IntPtr)T.h(array) / (nuint)(nint)(IntPtr)F.A())) is object)
				{
					num = default(IntPtr);
					object obj2 = y.t(num);
					_ = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is _003CModule_003E;
				}
			}
			else
			{
				do
				{
					_ = (h)T.h(array);
				}
				while (obj != null);
			}
		}
		h h;
		if (num2 == 0 && checked(num2 + num2) == 0)
		{
			h = (h)T.h(array);
			h = h;
		}
		while (obj != null)
		{
			_ = (_003CModule_003E)(object)F.A();
		}
		r = default(r);
		_ = y.t(num) is h;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(IntPtr);
			object obj3 = y.t(num);
			object obj4 = y.t((IntPtr)((obj3 is IntPtr) ? obj3 : null));
			if ((int)checked(((obj4 is UIntPtr) ? obj4 : null) + unchecked((nuint)default(UIntPtr)) + unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)T.h(array)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					_ = (AssmeblyLoader)(object)F.A();
					goto IL_043d;
				}
			}
		}
		goto IL_043d;
		IL_043d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		try
		{
			try
			{
				do
				{
					t = t;
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
					_ = (CHOOSEFONT)F.A();
					num = default(IntPtr);
					nuint num3;
					nint num4;
					checked
					{
						num3 = unchecked((nuint)num) * unchecked((nuint)(nint)(IntPtr)F.A());
						num = default(IntPtr);
						num4 = num;
						num = default(IntPtr);
					}
					_ = y.t((nint)checked(num3 * unchecked((nuint)(nint)(IntPtr)T.h(y.t((nint)checked(unchecked((nuint)num4) * unchecked((nuint)num) * (unchecked((nuint)num) - unchecked((nuint)num)))) as byte[]) / (nuint)(nint)(IntPtr)T.h(array)))) is y;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					num = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(null)))) is T;
				}
				catch
				{
					_ = (F)(object)T.h(array);
				}
				goto end_IL_043e;
			}
			end_IL_043e:;
		}
		finally
		{
			num2 = default(UIntPtr);
			checked
			{
				if ((unchecked(unchecked((nuint)default(UIntPtr)) / checked((num2 + (num2 - num2)) * (num2 - (num2 + num2)))) + unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (CHOOSEFONT)T.h(array);
				}
				goto IL_0590;
			}
		}
		IL_00d4:
		num2 = default(UIntPtr);
		checked
		{
			num2 *= num2 + unchecked((nuint)(UIntPtr)F.A());
			if (num2 == 0)
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
			else
			{
				try
				{
					if (num2 == 0)
					{
						_ = y.t(num) is AssmeblyLoader;
					}
				}
				catch
				{
					_ = y.t(default(IntPtr)) is r;
					F obj6 = y.t(default(IntPtr)) as F;
					F f = f;
					f = obj6;
					num = default(IntPtr);
					nint intPtr = num;
					nint num5 = num;
					nuint num6 = unchecked((nuint)num) + unchecked((nuint)unchecked((nint)default(IntPtr)));
					num = default(IntPtr);
					object obj7;
					unchecked
					{
						obj7 = y.t((nint)checked(unchecked((nuint)num5) + unchecked(num6 / (nuint)num)));
					}
					_ = y.t(intPtr * (((obj7 is IntPtr) ? obj7 : null) * (unchecked((nuint)(nint)(IntPtr)F.A()) * (unchecked((nuint)num) + unchecked((nuint)num))))) is CHOOSEFONTFLAGS;
				}
			}
			num2 = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		if (num2 == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = y.t((IntPtr)T.h(array)) is F;
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
					assmeblyLoader = assmeblyLoader;
					t = t;
					t = t;
				}
			}
			finally
			{
				do
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				}
				while (obj != null);
				goto IL_0258;
			}
		}
		goto IL_0258;
		IL_07de:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			y y = null;
			t = t;
			_ = (r)T.h(array);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
				}
			}
			catch
			{
				_ = (T)(object)F.A();
				_ = y.t(default(IntPtr)) is CHOOSEFONT;
				cHOOSEFONT = cHOOSEFONT;
				h = h;
			}
		}
		else
		{
			_ = (IAssemblyLoader)(object)T.h(array);
		}
		if (num2 != (UIntPtr)(nuint)0u)
		{
			return;
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				_ = (Resource1)(object)F.A();
				return;
			}
			num = default(IntPtr);
			nuint num7;
			IntPtr num8;
			nuint num11;
			checked
			{
				num7 = unchecked((nuint)num) + unchecked((nuint)num);
				num = default(IntPtr);
				num8 = num;
				IntPtr num9 = unchecked((IntPtr)F.A());
				IntPtr num10 = num;
				num = default(IntPtr);
				num11 = unchecked(checked(unchecked((nuint)(nint)num9) + unchecked((nuint)(nint)num10 / (nuint)num / (nuint)num)) / (nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(array));
				num = default(IntPtr);
			}
			_ = y.t((nint)checked(num7 - unchecked((nuint)(nint)num8 / (nuint)(nint)(IntPtr)T.h(y.t((nint)checked(num11 * unchecked(checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)num)) / (nuint)num))) as byte[])))) is _003CPrivateImplementationDetails_003E;
		}
		return;
		IL_0590:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					num = default(IntPtr);
					nint num12 = num;
					num = default(IntPtr);
					_ = (y)(object)T.h(y.t((nint)((nuint)num12 / (nuint)num)) as byte[]);
					_ = (AssmeblyLoader)(object)T.h(F.A());
				}
				catch
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					IAssemblyLoader assemblyLoader = assemblyLoader;
					assemblyLoader = null;
					_ = y.t(num) is r;
					r = r;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					num = default(IntPtr);
					object obj11 = y.t(num);
					_ = y.t((IntPtr)(((obj11 is IntPtr) ? obj11 : null) / num)) is AssmeblyLoader;
				}
				finally
				{
					_ = (CHOOSEFONT)T.h(y.t(num) as byte[]);
					goto end_IL_062d;
				}
			}
			try
			{
				assmeblyLoader = assmeblyLoader;
				r = r;
				IAssemblyLoader assemblyLoader = null;
			}
			catch
			{
				assmeblyLoader = assmeblyLoader;
			}
			end_IL_062d:;
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = y.t(default(IntPtr)) is Resource1;
				}
				else
				{
					_ = y.t(default(IntPtr)) is y;
				}
			}
		}
		catch
		{
			_ = y.t((IntPtr)T.h(array)) is _003CModule_003E;
			num = default(IntPtr);
			_ = y.t((nint)((nuint)num / (nuint)num)) is CHOOSEFONT;
			assmeblyLoader = assmeblyLoader;
			cHOOSEFONT = (CHOOSEFONT)F.A();
			cHOOSEFONT = default(CHOOSEFONT);
		}
		try
		{
			do
			{
				_ = (Resource1)(object)F.A();
			}
			while (obj != null);
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
			do
			{
				y obj15 = y.t(default(IntPtr)) as y;
				y = y;
				y = obj15;
			}
			while ((object)F.A() != null);
		}
		finally
		{
			h = (h)F.A();
			goto IL_07de;
		}
	}
	,
	static void _007C_005D_0029_002D_005B_0028_005D_003A_005B4()
	{
		//IL_0011: Expected O, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_012a: Expected I4, but got O
		//IL_016d: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_0192: Expected I, but got O
		//IL_0193: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected I, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_0306: Expected I, but got O
		//IL_0307: Expected O, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected I, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_03dd: Expected I, but got O
		//IL_03de: Expected O, but got I4
		//IL_048a: Expected O, but got I4
		//IL_04cd: Expected O, but got I4
		//IL_04f7: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_0525: Expected O, but got I4
		//IL_0586: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_0759: Expected O, but got I4
		//IL_07c6: Expected O, but got I4
		//IL_082f: Expected O, but got I4
		//IL_084a: Expected O, but got I4
		//IL_0877: Expected O, but got I4
		//IL_08f5: Expected O, but got I4
		//IL_096c: Expected O, but got I4
		//IL_0997: Expected O, but got I4
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		h h;
		while (obj != null)
		{
			do
			{
				object obj2 = y.t(intPtr);
				intPtr = (nint)(checked(((obj2 is IntPtr) ? obj2 : null) + unchecked((nuint)(nint)(IntPtr)F.A())) / (nuint)unchecked((nint)default(IntPtr)));
				intPtr = default(IntPtr);
				if (!(y.t(intPtr) is UIntPtr))
				{
					_ = (AssmeblyLoader)(object)F.A();
					_ = (IAssemblyLoader)(object)F.A();
					h = default(h);
					h = default(h);
				}
				obj = obj;
			}
			while (obj != null);
		}
		y y = null;
		y = y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		try
		{
			_ = (IAssemblyLoader)(object)F.A();
			_ = y.t(default(IntPtr)) is h;
		}
		catch
		{
			while (obj != null)
			{
				while ((object)null != null)
				{
					_ = (F)(object)T.h(y.t(default(IntPtr)) as byte[]);
					object obj3 = y.t(default(IntPtr));
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj3 is CHOOSEFONTFLAGS) ? obj3 : null);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					array = array;
					_ = (Resource1)(object)T.h(array);
				}
			}
		}
		object obj5 = y.t((IntPtr)F.A());
		h = (h)((obj5 is h) ? obj5 : null);
		intPtr = default(IntPtr);
		object obj6 = y.t(intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (!(y.t((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is UIntPtr))
		{
			while (obj != null)
			{
				UIntPtr intPtr2 = (UIntPtr)F.A();
				object obj7 = y.t(intPtr);
				num = (nuint)(nint)(checked(unchecked((nuint)intPtr2 / ((obj7 is UIntPtr) ? obj7 : null)) - (unchecked((nuint)(UIntPtr)T.h(null)) + num)) / unchecked((nuint)default(UIntPtr)));
				if (num == 0)
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
					_003CPrivateImplementationDetails_003E = null;
					continue;
				}
				intPtr = default(IntPtr);
				IntPtr num2 = intPtr;
				IntPtr num3 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num2) + (unchecked((nuint)(nint)num3) - unchecked((nuint)intPtr)))) is T;
			}
		}
		try
		{
			try
			{
				nint num4 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)num4) - unchecked((nuint)intPtr))) is T;
			}
			finally
			{
				while (obj != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				goto end_IL_023e;
			}
			end_IL_023e:;
		}
		catch
		{
			while (obj != null)
			{
				while (y.t(intPtr) is object)
				{
					_ = (h)T.h(array);
				}
			}
		}
		IntPtr intPtr3 = (IntPtr)T.h(array);
		intPtr = default(IntPtr);
		nuint num5;
		checked
		{
			num5 = unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)intPtr);
		}
		object obj9 = y.t((IntPtr)/*isinst with value type is only supported in some contexts*/);
		_ = y.t((nint)checked(unchecked((nuint)(nint)intPtr3) + num5 * ((obj9 is IntPtr) ? obj9 : null) * unchecked((nuint)(nint)(IntPtr)F.A()))) is _003CModule_003E;
		_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)T.h(F.A())) + unchecked((nuint)(nint)(IntPtr)T.h(F.A())))) is AssmeblyLoader;
		_ = y.t(intPtr) is T;
		_003CModule_003E _003CModule_003E;
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					intPtr = default(IntPtr);
					_003CPrivateImplementationDetails_003E = y.t((nint)checked(unchecked((nuint)intPtr) * unchecked((nuint)intPtr))) as _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			_003CModule_003E obj10 = y.t(intPtr) as _003CModule_003E;
			intPtr = default(IntPtr);
			object obj11 = y.t(intPtr);
			_003CModule_003E = y.t((IntPtr)((obj11 is IntPtr) ? obj11 : null)) as _003CModule_003E;
			_003CModule_003E = obj10;
			goto IL_04a7;
		}
		IL_072a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		if (!(y.t((IntPtr)F.A()) is UIntPtr))
		{
			if (!(y.t((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)F.A()))) is UIntPtr))
			{
				h = (h)F.A();
				_ = (F)(object)F.A();
			}
			else
			{
				while (obj != null)
				{
					resource = resource;
				}
			}
		}
		else if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = y.t(intPtr) is r;
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		try
		{
			if (num == 0)
			{
				try
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
			}
		}
		finally
		{
			while ((object)null != null)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is IAssemblyLoader;
				}
				catch
				{
					_ = y.t((IntPtr)F.A()) is F;
				}
			}
			goto IL_085b;
		}
		IL_04a7:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while ((object)null != null)
		{
			while ((object)null != null)
			{
				if ((UIntPtr)T.h(F.A()) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
					continue;
				}
				Resource1 obj14 = (Resource1)(object)T.h(T.h(null));
				resource = resource;
				resource = obj14;
				intPtr = default(IntPtr);
				IntPtr num6 = intPtr;
				IntPtr num7 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num6) * unchecked(checked(unchecked((nuint)(nint)num7) * unchecked((nuint)intPtr)) / (nuint)(nint)(IntPtr)T.h(array)) * unchecked((nuint)(nint)(IntPtr)F.A()))) is T;
				r = r;
				r = r;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = y.t(intPtr) is AssmeblyLoader;
				}
				catch
				{
					_ = y.t((nint)((nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)T.h(y.t(intPtr) as byte[]))) is _003CModule_003E;
				}
			}
			else
			{
				do
				{
					T t = y.t(intPtr) as T;
					t = t;
				}
				while (obj != null);
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					T t = null;
					h = default(h);
					_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)intPtr))) is Resource1;
				}
				catch
				{
					nint num8 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num8) + unchecked((nuint)intPtr))) is T;
				}
			}
		}
		r = default(r);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (F)(object)T.h(array);
				}
			}
			finally
			{
				num = default(UIntPtr);
				nuint num9 = num;
				num = default(UIntPtr);
				if (checked(num9 + num) / num == 0)
				{
					_ = (r)T.h(array);
				}
				else
				{
					assmeblyLoader = null;
					assmeblyLoader = null;
				}
				goto end_IL_05c8;
			}
			end_IL_05c8:;
		}
		catch
		{
			if (num == 0)
			{
				do
				{
					object obj18 = y.t((IntPtr)T.h(array));
					object obj19 = ((obj18 is CHOOSEFONT) ? obj18 : null);
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = (CHOOSEFONT)obj19;
				}
				while ((object)T.h(array) != null);
			}
		}
		_ = y.t((IntPtr)F.A()) is r;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		if (!(y.t(intPtr) is UIntPtr))
		{
			while ((object)null != null)
			{
				do
				{
					f = null;
					f = null;
				}
				while (obj != null);
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(null);
					f = null;
					cHOOSEFONT = (CHOOSEFONT)T.h(array);
				}
				finally
				{
					resource = null;
					continue;
				}
			}
			while ((object)null != null);
		}
		finally
		{
			y = y;
			_ = (r)F.A();
			goto IL_072a;
		}
		IL_085b:
		try
		{
			r = r;
			cHOOSEFONT = cHOOSEFONT;
			_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
			_003CModule_003E = null;
		}
		catch
		{
			resource = resource;
			_ = (CHOOSEFONTFLAGS)F.A();
		}
		if (num == 0)
		{
			assmeblyLoader = null;
		}
		else
		{
			while (obj != null)
			{
				if (num == 0)
				{
					r = r;
					_ = (AssmeblyLoader)(object)F.A();
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
				}
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		}
		else
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			resource = null;
		}
		try
		{
			_ = (y)(object)F.A();
		}
		catch
		{
			try
			{
				_003CPrivateImplementationDetails_003E = null;
			}
			finally
			{
				f = f;
				goto end_IL_0946;
			}
			end_IL_0946:;
		}
		do
		{
			if (!(y.t(intPtr) is UIntPtr))
			{
				UIntPtr intPtr4 = num;
				intPtr = default(IntPtr);
				object obj23 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr) + unchecked((nuint)intPtr)));
				if ((int)checked(unchecked((nuint)intPtr4) - ((obj23 is UIntPtr) ? obj23 : null)) == 0)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(F.A());
				}
			}
		}
		while (obj != null);
		do
		{
			_ = (_003CModule_003E)(object)T.h(array);
		}
		while (obj != null || obj != null);
	}
	,
	static void _007C_005D_0029_002D_005B_0028_005D_003A_005B4()
	{
		//IL_0011: Expected O, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_012a: Expected I4, but got O
		//IL_016d: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_0192: Expected I, but got O
		//IL_0193: Expected O, but got I4
		//IL_01b6: Expected O, but got I4
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected I, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_0259: Expected O, but got I4
		//IL_02ab: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		//IL_0306: Expected I, but got O
		//IL_0307: Expected O, but got I4
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected I, but got Unknown
		//IL_031e: Expected O, but got I4
		//IL_0352: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_03bc: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_03dd: Expected I, but got O
		//IL_03de: Expected O, but got I4
		//IL_048a: Expected O, but got I4
		//IL_04cd: Expected O, but got I4
		//IL_04f7: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_0525: Expected O, but got I4
		//IL_0586: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_0759: Expected O, but got I4
		//IL_07c6: Expected O, but got I4
		//IL_082f: Expected O, but got I4
		//IL_084a: Expected O, but got I4
		//IL_0877: Expected O, but got I4
		//IL_08f5: Expected O, but got I4
		//IL_096c: Expected O, but got I4
		//IL_0997: Expected O, but got I4
		//IL_099b: Unknown result type (might be due to invalid IL or missing references)
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		h h;
		while (obj != null)
		{
			do
			{
				object obj2 = y.t(intPtr);
				intPtr = (nint)(checked(((obj2 is IntPtr) ? obj2 : null) + unchecked((nuint)(nint)(IntPtr)F.A())) / (nuint)unchecked((nint)default(IntPtr)));
				intPtr = default(IntPtr);
				if (!(y.t(intPtr) is UIntPtr))
				{
					_ = (AssmeblyLoader)(object)F.A();
					_ = (IAssemblyLoader)(object)F.A();
					h = default(h);
					h = default(h);
				}
				obj = obj;
			}
			while (obj != null);
		}
		y y = null;
		y = y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		try
		{
			_ = (IAssemblyLoader)(object)F.A();
			_ = y.t(default(IntPtr)) is h;
		}
		catch
		{
			while (obj != null)
			{
				while ((object)null != null)
				{
					_ = (F)(object)T.h(y.t(default(IntPtr)) as byte[]);
					object obj3 = y.t(default(IntPtr));
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj3 is CHOOSEFONTFLAGS) ? obj3 : null);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					array = array;
					_ = (Resource1)(object)T.h(array);
				}
			}
		}
		object obj5 = y.t((IntPtr)F.A());
		h = (h)((obj5 is h) ? obj5 : null);
		intPtr = default(IntPtr);
		object obj6 = y.t(intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (!(y.t((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is UIntPtr))
		{
			while (obj != null)
			{
				UIntPtr intPtr2 = (UIntPtr)F.A();
				object obj7 = y.t(intPtr);
				num = (nuint)(nint)(checked(unchecked((nuint)intPtr2 / ((obj7 is UIntPtr) ? obj7 : null)) - (unchecked((nuint)(UIntPtr)T.h(null)) + num)) / unchecked((nuint)default(UIntPtr)));
				if (num == 0)
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
					_003CPrivateImplementationDetails_003E = null;
					continue;
				}
				intPtr = default(IntPtr);
				IntPtr num2 = intPtr;
				IntPtr num3 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num2) + (unchecked((nuint)(nint)num3) - unchecked((nuint)intPtr)))) is T;
			}
		}
		try
		{
			try
			{
				nint num4 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)num4) - unchecked((nuint)intPtr))) is T;
			}
			finally
			{
				while (obj != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				goto end_IL_023e;
			}
			end_IL_023e:;
		}
		catch
		{
			while (obj != null)
			{
				while (y.t(intPtr) is object)
				{
					_ = (h)T.h(array);
				}
			}
		}
		IntPtr intPtr3 = (IntPtr)T.h(array);
		intPtr = default(IntPtr);
		nuint num5;
		checked
		{
			num5 = unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)intPtr);
		}
		object obj9 = y.t((IntPtr)/*isinst with value type is only supported in some contexts*/);
		_ = y.t((nint)checked(unchecked((nuint)(nint)intPtr3) + num5 * ((obj9 is IntPtr) ? obj9 : null) * unchecked((nuint)(nint)(IntPtr)F.A()))) is _003CModule_003E;
		_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)T.h(F.A())) + unchecked((nuint)(nint)(IntPtr)T.h(F.A())))) is AssmeblyLoader;
		_ = y.t(intPtr) is T;
		_003CModule_003E _003CModule_003E;
		try
		{
			while (obj != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					intPtr = default(IntPtr);
					_003CPrivateImplementationDetails_003E = y.t((nint)checked(unchecked((nuint)intPtr) * unchecked((nuint)intPtr))) as _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			_003CModule_003E obj10 = y.t(intPtr) as _003CModule_003E;
			intPtr = default(IntPtr);
			object obj11 = y.t(intPtr);
			_003CModule_003E = y.t((IntPtr)((obj11 is IntPtr) ? obj11 : null)) as _003CModule_003E;
			_003CModule_003E = obj10;
			goto IL_04a7;
		}
		IL_072a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		if (!(y.t((IntPtr)F.A()) is UIntPtr))
		{
			if (!(y.t((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)F.A()))) is UIntPtr))
			{
				h = (h)F.A();
				_ = (F)(object)F.A();
			}
			else
			{
				while (obj != null)
				{
					resource = resource;
				}
			}
		}
		else if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = y.t(intPtr) is r;
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		try
		{
			if (num == 0)
			{
				try
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
			}
		}
		finally
		{
			while ((object)null != null)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is IAssemblyLoader;
				}
				catch
				{
					_ = y.t((IntPtr)F.A()) is F;
				}
			}
			goto IL_085b;
		}
		IL_04a7:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while ((object)null != null)
		{
			while ((object)null != null)
			{
				if ((UIntPtr)T.h(F.A()) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
					continue;
				}
				Resource1 obj14 = (Resource1)(object)T.h(T.h(null));
				resource = resource;
				resource = obj14;
				intPtr = default(IntPtr);
				IntPtr num6 = intPtr;
				IntPtr num7 = intPtr;
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num6) * unchecked(checked(unchecked((nuint)(nint)num7) * unchecked((nuint)intPtr)) / (nuint)(nint)(IntPtr)T.h(array)) * unchecked((nuint)(nint)(IntPtr)F.A()))) is T;
				r = r;
				r = r;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = y.t(intPtr) is AssmeblyLoader;
				}
				catch
				{
					_ = y.t((nint)((nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)T.h(y.t(intPtr) as byte[]))) is _003CModule_003E;
				}
			}
			else
			{
				do
				{
					T t = y.t(intPtr) as T;
					t = t;
				}
				while (obj != null);
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					T t = null;
					h = default(h);
					_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)intPtr))) is Resource1;
				}
				catch
				{
					nint num8 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num8) + unchecked((nuint)intPtr))) is T;
				}
			}
		}
		r = default(r);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				if (num == 0)
				{
					_ = (F)(object)T.h(array);
				}
			}
			finally
			{
				num = default(UIntPtr);
				nuint num9 = num;
				num = default(UIntPtr);
				if (checked(num9 + num) / num == 0)
				{
					_ = (r)T.h(array);
				}
				else
				{
					assmeblyLoader = null;
					assmeblyLoader = null;
				}
				goto end_IL_05c8;
			}
			end_IL_05c8:;
		}
		catch
		{
			if (num == 0)
			{
				do
				{
					object obj18 = y.t((IntPtr)T.h(array));
					object obj19 = ((obj18 is CHOOSEFONT) ? obj18 : null);
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = (CHOOSEFONT)obj19;
				}
				while ((object)T.h(array) != null);
			}
		}
		_ = y.t((IntPtr)F.A()) is r;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		if (!(y.t(intPtr) is UIntPtr))
		{
			while ((object)null != null)
			{
				do
				{
					f = null;
					f = null;
				}
				while (obj != null);
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(null);
					f = null;
					cHOOSEFONT = (CHOOSEFONT)T.h(array);
				}
				finally
				{
					resource = null;
					continue;
				}
			}
			while ((object)null != null);
		}
		finally
		{
			y = y;
			_ = (r)F.A();
			goto IL_072a;
		}
		IL_085b:
		try
		{
			r = r;
			cHOOSEFONT = cHOOSEFONT;
			_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
			_003CModule_003E = null;
		}
		catch
		{
			resource = resource;
			_ = (CHOOSEFONTFLAGS)F.A();
		}
		if (num == 0)
		{
			assmeblyLoader = null;
		}
		else
		{
			while (obj != null)
			{
				if (num == 0)
				{
					r = r;
					_ = (AssmeblyLoader)(object)F.A();
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
				}
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		}
		else
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			resource = null;
		}
		try
		{
			_ = (y)(object)F.A();
		}
		catch
		{
			try
			{
				_003CPrivateImplementationDetails_003E = null;
			}
			finally
			{
				f = f;
				goto end_IL_0946;
			}
			end_IL_0946:;
		}
		do
		{
			if (!(y.t(intPtr) is UIntPtr))
			{
				UIntPtr intPtr4 = num;
				intPtr = default(IntPtr);
				object obj23 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr) + unchecked((nuint)intPtr)));
				if ((int)checked(unchecked((nuint)intPtr4) - ((obj23 is UIntPtr) ? obj23 : null)) == 0)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(F.A());
				}
			}
		}
		while (obj != null);
		do
		{
			_ = (_003CModule_003E)(object)T.h(array);
		}
		while (obj != null || obj != null);
	}
	,
	static void _007D_0023_0040_003A_005D_0040_0024_0028_0040_005E_007C_003F15()
	{
		//IL_0043: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected I, but got Unknown
		//IL_01c6: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_02dd: Expected I, but got O
		//IL_02de: Expected O, but got I4
		//IL_0303: Expected O, but got I4
		//IL_03a1: Expected O, but got I4
		//IL_03cd: Expected O, but got I4
		//IL_03d6: Expected I, but got O
		//IL_03d7: Expected O, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got I4
		//IL_04c9: Expected O, but got I4
		//IL_04ff: Expected O, but got I4
		//IL_05c9: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0656: Expected O, but got I4
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected I, but got Unknown
		//IL_0665: Expected O, but got I4
		//IL_067a: Expected O, but got I4
		//IL_06e4: Expected O, but got I4
		//IL_0703: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_0742: Expected O, but got I4
		//IL_07a5: Expected O, but got I4
		//IL_0865: Expected O, but got I4
		//IL_094a: Expected O, but got I4
		//IL_0960: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while ((object)null != null)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		r r;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		try
		{
			do
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					num = num;
					_ = y.t(num) is CHOOSEFONTFLAGS;
					goto IL_004a;
				}
				IL_004a:
				obj = null;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					num = default(IntPtr);
					_ = y.t(num) is CHOOSEFONTFLAGS;
				}
			}
			finally
			{
				do
				{
					array = array;
					r = (r)T.h(array);
					r = default(r);
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				while (obj != null);
				goto IL_00d4;
			}
		}
		IL_0258:
		UIntPtr num2;
		if (checked(unchecked((nuint)(UIntPtr)F.A()) + (num2 - num2)) == 0)
		{
			r = r;
			_ = (T)(object)F.A();
			_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)num))) is CHOOSEFONT;
		}
		while (obj != null)
		{
			if (num2 / (nuint)(UIntPtr)F.A() == 0)
			{
				while (y.t((nint)((nuint)(nint)(IntPtr)T.h(array) / (nuint)(nint)(IntPtr)F.A())) is object)
				{
					num = default(IntPtr);
					object obj2 = y.t(num);
					_ = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is _003CModule_003E;
				}
			}
			else
			{
				do
				{
					_ = (h)T.h(array);
				}
				while (obj != null);
			}
		}
		h h;
		if (num2 == 0 && checked(num2 + num2) == 0)
		{
			h = (h)T.h(array);
			h = h;
		}
		while (obj != null)
		{
			_ = (_003CModule_003E)(object)F.A();
		}
		r = default(r);
		_ = y.t(num) is h;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(IntPtr);
			object obj3 = y.t(num);
			object obj4 = y.t((IntPtr)((obj3 is IntPtr) ? obj3 : null));
			if ((int)checked(((obj4 is UIntPtr) ? obj4 : null) + unchecked((nuint)default(UIntPtr)) + unchecked(unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)T.h(array)) + unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					_ = (AssmeblyLoader)(object)F.A();
					goto IL_043d;
				}
			}
		}
		goto IL_043d;
		IL_043d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		try
		{
			try
			{
				do
				{
					t = t;
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
					_ = (CHOOSEFONT)F.A();
					num = default(IntPtr);
					nuint num3;
					nint num4;
					checked
					{
						num3 = unchecked((nuint)num) * unchecked((nuint)(nint)(IntPtr)F.A());
						num = default(IntPtr);
						num4 = num;
						num = default(IntPtr);
					}
					_ = y.t((nint)checked(num3 * unchecked((nuint)(nint)(IntPtr)T.h(y.t((nint)checked(unchecked((nuint)num4) * unchecked((nuint)num) * (unchecked((nuint)num) - unchecked((nuint)num)))) as byte[]) / (nuint)(nint)(IntPtr)T.h(array)))) is y;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					num = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(null)))) is T;
				}
				catch
				{
					_ = (F)(object)T.h(array);
				}
				goto end_IL_043e;
			}
			end_IL_043e:;
		}
		finally
		{
			num2 = default(UIntPtr);
			checked
			{
				if ((unchecked(unchecked((nuint)default(UIntPtr)) / checked((num2 + (num2 - num2)) * (num2 - (num2 + num2)))) + unchecked((nuint)default(UIntPtr))) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (CHOOSEFONT)T.h(array);
				}
				goto IL_0590;
			}
		}
		IL_00d4:
		num2 = default(UIntPtr);
		checked
		{
			num2 *= num2 + unchecked((nuint)(UIntPtr)F.A());
			if (num2 == 0)
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
			else
			{
				try
				{
					if (num2 == 0)
					{
						_ = y.t(num) is AssmeblyLoader;
					}
				}
				catch
				{
					_ = y.t(default(IntPtr)) is r;
					F obj6 = y.t(default(IntPtr)) as F;
					F f = f;
					f = obj6;
					num = default(IntPtr);
					nint intPtr = num;
					nint num5 = num;
					nuint num6 = unchecked((nuint)num) + unchecked((nuint)unchecked((nint)default(IntPtr)));
					num = default(IntPtr);
					object obj7;
					unchecked
					{
						obj7 = y.t((nint)checked(unchecked((nuint)num5) + unchecked(num6 / (nuint)num)));
					}
					_ = y.t(intPtr * (((obj7 is IntPtr) ? obj7 : null) * (unchecked((nuint)(nint)(IntPtr)F.A()) * (unchecked((nuint)num) + unchecked((nuint)num))))) is CHOOSEFONTFLAGS;
				}
			}
			num2 = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		if (num2 == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = y.t((IntPtr)T.h(array)) is F;
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
					assmeblyLoader = assmeblyLoader;
					t = t;
					t = t;
				}
			}
			finally
			{
				do
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				}
				while (obj != null);
				goto IL_0258;
			}
		}
		goto IL_0258;
		IL_07de:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = _003CModule_003E;
			y y = null;
			t = t;
			_ = (r)T.h(array);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
				}
			}
			catch
			{
				_ = (T)(object)F.A();
				_ = y.t(default(IntPtr)) is CHOOSEFONT;
				cHOOSEFONT = cHOOSEFONT;
				h = h;
			}
		}
		else
		{
			_ = (IAssemblyLoader)(object)T.h(array);
		}
		if (num2 != (UIntPtr)(nuint)0u)
		{
			return;
		}
		num2 = default(UIntPtr);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				_ = (Resource1)(object)F.A();
				return;
			}
			num = default(IntPtr);
			nuint num7;
			IntPtr num8;
			nuint num11;
			checked
			{
				num7 = unchecked((nuint)num) + unchecked((nuint)num);
				num = default(IntPtr);
				num8 = num;
				IntPtr num9 = unchecked((IntPtr)F.A());
				IntPtr num10 = num;
				num = default(IntPtr);
				num11 = unchecked(checked(unchecked((nuint)(nint)num9) + unchecked((nuint)(nint)num10 / (nuint)num / (nuint)num)) / (nuint)num) - unchecked((nuint)(nint)(IntPtr)T.h(array));
				num = default(IntPtr);
			}
			_ = y.t((nint)checked(num7 - unchecked((nuint)(nint)num8 / (nuint)(nint)(IntPtr)T.h(y.t((nint)checked(num11 * unchecked(checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)num)) / (nuint)num))) as byte[])))) is _003CPrivateImplementationDetails_003E;
		}
		return;
		IL_0590:
		try
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					num = default(IntPtr);
					nint num12 = num;
					num = default(IntPtr);
					_ = (y)(object)T.h(y.t((nint)((nuint)num12 / (nuint)num)) as byte[]);
					_ = (AssmeblyLoader)(object)T.h(F.A());
				}
				catch
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					IAssemblyLoader assemblyLoader = assemblyLoader;
					assemblyLoader = null;
					_ = y.t(num) is r;
					r = r;
				}
			}
		}
		catch
		{
			num2 = default(UIntPtr);
			if (num2 == (UIntPtr)(nuint)0u)
			{
				try
				{
					num = default(IntPtr);
					object obj11 = y.t(num);
					_ = y.t((IntPtr)(((obj11 is IntPtr) ? obj11 : null) / num)) is AssmeblyLoader;
				}
				finally
				{
					_ = (CHOOSEFONT)T.h(y.t(num) as byte[]);
					goto end_IL_062d;
				}
			}
			try
			{
				assmeblyLoader = assmeblyLoader;
				r = r;
				IAssemblyLoader assemblyLoader = null;
			}
			catch
			{
				assmeblyLoader = assmeblyLoader;
			}
			end_IL_062d:;
		}
		try
		{
			if (num2 == (UIntPtr)(nuint)0u)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = y.t(default(IntPtr)) is Resource1;
				}
				else
				{
					_ = y.t(default(IntPtr)) is y;
				}
			}
		}
		catch
		{
			_ = y.t((IntPtr)T.h(array)) is _003CModule_003E;
			num = default(IntPtr);
			_ = y.t((nint)((nuint)num / (nuint)num)) is CHOOSEFONT;
			assmeblyLoader = assmeblyLoader;
			cHOOSEFONT = (CHOOSEFONT)F.A();
			cHOOSEFONT = default(CHOOSEFONT);
		}
		try
		{
			do
			{
				_ = (Resource1)(object)F.A();
			}
			while (obj != null);
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
			do
			{
				y obj15 = y.t(default(IntPtr)) as y;
				y = y;
				y = obj15;
			}
			while ((object)F.A() != null);
		}
		finally
		{
			h = (h)F.A();
			goto IL_07de;
		}
	}

}
