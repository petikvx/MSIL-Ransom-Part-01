using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using _310;

namespace l;

internal sealed class T
{
	private static readonly byte[] H = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	private const int g = 32;

	private static byte[] W = H;

	static void _007D_002F_007D_003A_007D_007C_0024_0028_005E_005E_003D_003A16()
	{
		//IL_00a1: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected I, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_03bd: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected I, but got Unknown
		//IL_05c3: Expected O, but got I4
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected I, but got Unknown
		//IL_05d9: Expected O, but got I4
		//IL_05fa: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0620: Expected I, but got O
		//IL_0621: Expected O, but got I4
		//IL_064c: Expected O, but got I4
		//IL_0661: Expected O, but got I4
		//IL_06e6: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_076a: Expected O, but got I4
		//IL_079d: Expected O, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got I4
		//IL_0834: Expected O, but got I4
		//IL_083d: Expected I, but got O
		//IL_083e: Expected O, but got I4
		//IL_085f: Expected O, but got I4
		//IL_0892: Expected O, but got I4
		//IL_08f6: Expected O, but got I4
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got I4
		//IL_0a49: Expected O, but got I4
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num5);
		try
		{
			_ = (Resource1)(object)F.A();
		}
		catch
		{
			while ((object)null != null)
			{
				nuint num2 = num;
				UIntPtr num3 = (UIntPtr)F.A();
				num = default(UIntPtr);
				checked
				{
					nuint num4 = num + num;
					num = default(UIntPtr);
					num = num2 - unchecked((nuint)num3 / checked(unchecked((nuint)default(UIntPtr)) * (unchecked(checked(num4 + num) / num) - unchecked((nuint)default(UIntPtr)))));
					num = default(UIntPtr);
				}
				if (num == 0)
				{
					_ = y.t((IntPtr)F.A()) is CHOOSEFONTFLAGS;
					continue;
				}
				_ = (IAssemblyLoader)(object)F.A();
				num5 = (nint)checked(unchecked((nuint)(nint)(IntPtr)h(y.t((IntPtr)h(h(y.t(num5) as byte[]))) as byte[])) + unchecked((nuint)num5) - unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)num5));
				nuint num6 = (nuint)unchecked((nint)default(IntPtr)) / (nuint)unchecked((nint)default(IntPtr));
				num5 = default(IntPtr);
				_ = y.t((nint)checked(num6 * unchecked((nuint)num5))) is _003CPrivateImplementationDetails_003E;
				_ = (r)h(F.A());
				_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			try
			{
				resource = null;
				resource = null;
			}
			catch
			{
				_ = (CHOOSEFONTFLAGS)h(null);
			}
			finally
			{
				try
				{
					_ = y.t((IntPtr)h(F.A())) is r;
				}
				finally
				{
					num5 = default(IntPtr);
					_ = y.t(num5) is AssmeblyLoader;
					goto end_IL_016b;
				}
			}
			end_IL_016b:;
		}
		finally
		{
			h h2 = h2;
			h2 = default(h);
			goto IL_01fa;
		}
		IL_0854:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			resource = y.t(num5) as Resource1;
		}
		while (obj3 != null);
		try
		{
			if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)F.A()) is _003CPrivateImplementationDetails_003E;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				nint num7 = num5;
				nuint num9;
				checked
				{
					nuint num8 = unchecked((nuint)num5) + unchecked((nuint)num5);
					num5 = default(IntPtr);
					num9 = num8 * (unchecked((nuint)num5) - unchecked((nuint)num5));
					num5 = default(IntPtr);
				}
				object obj4 = y.t((nint)((nuint)num7 / (num9 / (nuint)num5)));
				object obj5 = ((obj4 is UIntPtr) ? obj4 : null);
				num = default(UIntPtr);
				if ((int)(checked(unchecked((nuint)default(UIntPtr)) - unchecked(obj5 / checked(num * (num * num)))) / (nuint)(UIntPtr)h(null)) == 0)
				{
					_ = (y)(object)F.A();
				}
				else
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = null;
				}
			}
		}
		try
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					h h2 = default(h);
				}
				else
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
			}
			else
			{
				_ = y.t((IntPtr)h(F.A())) is CHOOSEFONT;
			}
		}
		finally
		{
			do
			{
				resource = resource;
			}
			while (obj3 != null);
			goto IL_09c6;
		}
		IL_01fa:
		IntPtr intPtr = (IntPtr)F.A();
		nint intPtr2 = num5;
		num5 = default(IntPtr);
		IntPtr intPtr3 = num5;
		nuint num10;
		object obj7;
		checked
		{
			num10 = unchecked((nuint)(nint)(IntPtr)F.A()) * unchecked((nuint)(nint)(IntPtr)F.A());
			obj7 = y.t(num5);
		}
		_003F val = num10 / ((obj7 is IntPtr) ? obj7 : null) / (nuint)(nint)num5;
		byte[] array = array;
		_003F val2 = val / (nuint)(nint)(IntPtr)h(array);
		IntPtr intPtr4 = (IntPtr)h(h(array));
		object obj8 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)h(array)) * unchecked((nuint)unchecked((nint)default(IntPtr)))));
		_003F val3;
		_003F val4;
		checked
		{
			val3 = val2 * (unchecked((nuint)(nint)intPtr4) * ((obj8 is IntPtr) ? obj8 : null));
			object obj9 = y.t(unchecked((IntPtr)F.A()));
			object obj10 = ((obj9 is IntPtr) ? obj9 : null);
			num5 = default(IntPtr);
			val4 = obj10 * unchecked((nuint)(nint)num5);
		}
		object obj11 = y.t((IntPtr)F.A());
		if (!(y.t((nint)checked(unchecked((nuint)(nint)intPtr) + intPtr2 * (unchecked((nuint)(nint)intPtr3) + val3 * (val4 + ((obj11 is IntPtr) ? obj11 : null))))) is UIntPtr))
		{
			try
			{
				if (num == 0)
				{
					_ = (IAssemblyLoader)(object)F.A();
					_003CPrivateImplementationDetails_003E = null;
					_ = (AssmeblyLoader)(object)F.A();
					_003CPrivateImplementationDetails_003E = null;
				}
				else
				{
					_ = (y)(object)h(array);
				}
			}
			finally
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 == null)
					{
						break;
					}
					_ = y.t(num5) is CHOOSEFONTFLAGS;
				}
				goto IL_039c;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			r2 = (r)F.A();
			r2 = r2;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = y.t(num5) is IAssemblyLoader;
			}
			goto IL_039c;
		}
		IL_05e5:
		num5 = default(IntPtr);
		AssmeblyLoader assmeblyLoader = y.t(num5) as AssmeblyLoader;
		assmeblyLoader = assmeblyLoader;
		do
		{
			try
			{
				try
				{
					object obj12 = y.t(num5);
					_ = (AssmeblyLoader)(object)h(y.t((IntPtr)((obj12 is IntPtr) ? obj12 : null)) as byte[]);
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = y.t(num5) is F;
				}
				finally
				{
					_ = y.t(num5) is _003CModule_003E;
					goto end_IL_060b;
				}
				end_IL_060b:;
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				catch
				{
					_ = (Resource1)(object)h(F.A());
				}
			}
		}
		while (obj3 != null);
		if (num == 0)
		{
			try
			{
				do
				{
					_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) * unchecked((nuint)unchecked((nint)default(IntPtr))) - (unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)(nint)(IntPtr)F.A())))) is CHOOSEFONTFLAGS;
				}
				while (obj3 != null);
			}
			catch
			{
				_ = (r)h(null);
			}
		}
		else
		{
			_ = y.t(default(IntPtr)) is IAssemblyLoader;
			_ = (_003CModule_003E)(object)h(array);
			y y2 = (y)(object)F.A();
		}
		num5 = default(IntPtr);
		if (!(y.t((nint)((nuint)unchecked((nint)default(IntPtr)) / (nuint)num5)) is UIntPtr))
		{
			_ = (_003CModule_003E)(object)F.A();
			goto IL_0854;
		}
		try
		{
			UIntPtr intPtr5 = (UIntPtr)h(array);
			object obj16 = y.t(num5);
			if ((int)((nuint)intPtr5 / ((obj16 is UIntPtr) ? obj16 : null)) == 0)
			{
				_ = (CHOOSEFONT)F.A();
				assmeblyLoader = assmeblyLoader;
				r2 = r2;
				IntPtr num11 = (IntPtr)h(null);
				IntPtr num12 = (IntPtr)F.A();
				num5 = default(IntPtr);
				nuint num13;
				checked
				{
					num13 = unchecked((nuint)(nint)num11) * (unchecked((nuint)(nint)num12) - unchecked((nuint)num5));
					num5 = default(IntPtr);
				}
				_ = y.t((nint)checked(num13 + unchecked((nuint)num5))) is CHOOSEFONTFLAGS;
			}
			else
			{
				y y2 = (y)(object)h(h(array));
			}
		}
		finally
		{
			object obj17 = y.t(num5);
			if (!(y.t((IntPtr)((obj17 is IntPtr) ? obj17 : null)) is UIntPtr))
			{
				assmeblyLoader = assmeblyLoader;
			}
			goto IL_0854;
		}
		IL_09c6:
		_ = (F)(object)h(null);
		_ = (IAssemblyLoader)(object)F.A();
		CHOOSEFONT obj18 = (CHOOSEFONT)F.A();
		CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
		cHOOSEFONT = obj18;
		r2 = default(r);
		_ = (T)(object)F.A();
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (F)(object)h(array);
			}
		}
		else
		{
			_ = y.t(num5) is _003CPrivateImplementationDetails_003E;
		}
		return;
		IL_039c:
		_ = (_003CPrivateImplementationDetails_003E)(object)h(null);
		num5 = default(IntPtr);
		F f = (F)(object)h(h(y.t(num5) as byte[]));
		f = f;
		while ((object)null != null)
		{
			resource = null;
		}
		do
		{
			resource = resource;
		}
		while ((object)null != null);
		r2 = r2;
		_ = y.t(num5) is F;
		nuint num14 = num / (nuint)(UIntPtr)h(h(array));
		num = default(UIntPtr);
		if (checked(num14 + num) == 0)
		{
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)h(array);
			}
			catch
			{
				try
				{
					_ = y.t((IntPtr)F.A()) is T;
				}
				catch
				{
					_ = y.t((IntPtr)F.A()) is F;
					y y2 = y2;
					y2 = y2;
					_ = y.t(num5) is AssmeblyLoader;
				}
			}
		}
		if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
		{
			_ = (F)(object)F.A();
			num5 = default(IntPtr);
			_ = (y)(object)h(y.t(num5) as byte[]);
		}
		else if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			resource = null;
		}
		else
		{
			_ = (AssmeblyLoader)(object)h(null);
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
			while (true)
			{
				if (obj3 != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				else if ((object)h(array) == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				while (true)
				{
					nint num15 = num5;
					num5 = default(IntPtr);
					nuint num16;
					checked
					{
						num16 = unchecked((nuint)num15) * (unchecked((nuint)num5) + unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)num5));
					}
					object obj21 = y.t((IntPtr)F.A());
					object obj22 = y.t((nint)checked(num16 * ((obj21 is IntPtr) ? obj21 : null)));
					if (y.t((IntPtr)(((obj22 is IntPtr) ? obj22 : null) / (nuint)(nint)(IntPtr)h(null))) is object)
					{
						h h2 = default(h);
						continue;
					}
					break;
				}
			}
			goto IL_05e5;
		}
	}

	static void _007C_005D_0029_002D_003B_003F_005D_003A_005E14()
	{
		//IL_0038: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected I, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_0377: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_04a8: Expected O, but got I4
		//IL_050e: Expected O, but got I4
		//IL_053c: Expected O, but got I4
		//IL_0588: Expected O, but got I4
		//IL_05e2: Expected O, but got I4
		//IL_069b: Expected O, but got I4
		//IL_06df: Expected O, but got I4
		//IL_0708: Expected O, but got I4
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got I4
		//IL_0745: Expected I, but got O
		//IL_0746: Expected O, but got I4
		//IL_0760: Expected O, but got I4
		//IL_076a: Expected I, but got O
		//IL_076b: Expected O, but got I4
		//IL_07db: Expected O, but got I4
		//IL_082d: Expected O, but got I4
		//IL_08e6: Expected O, but got I4
		//IL_097b: Expected O, but got I4
		//IL_099a: Expected O, but got I4
		//IL_09e1: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		T t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		try
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					t = null;
					t = null;
					continue;
				}
				break;
			}
		}
		finally
		{
			intPtr = intPtr;
			if (!(y.t(intPtr) is UIntPtr))
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = assmeblyLoader;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					_ = (Resource1)(object)F.A();
				}
			}
			goto IL_00a1;
		}
		IL_00a1:
		F f;
		do
		{
			f = null;
			f = null;
		}
		while ((object)null != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y2);
		Resource1 resource;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			object obj2 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr)));
			_003F val;
			checked
			{
				val = unchecked(((obj2 is IntPtr) ? obj2 : null) / intPtr) + unchecked((nuint)unchecked((nint)default(IntPtr)));
				intPtr = default(IntPtr);
			}
			object obj3 = y.t((IntPtr)checked(val * (unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)intPtr / (nuint)intPtr)) + intPtr));
			object obj4 = ((obj3 is IntPtr) ? obj3 : null);
			array = F.A();
			object obj5 = y.t((IntPtr)(obj4 / ((nuint)(nint)(IntPtr)h(array) / checked(unchecked((nuint)(nint)(IntPtr)h(null)) + unchecked((nuint)(nint)(IntPtr)h(array)) + unchecked((nuint)(nint)(IntPtr)F.A())))));
			r2 = (r)((obj5 is r) ? obj5 : null);
			r2 = default(r);
			r2 = r2;
		}
		finally
		{
			IntPtr num = (IntPtr)F.A();
			intPtr = default(IntPtr);
			object obj6 = y.t((nint)checked(unchecked((nuint)(nint)num) - unchecked((nuint)intPtr / (nuint)(nint)(IntPtr)h(array))));
			if ((int)checked(((obj6 is UIntPtr) ? obj6 : null) - unchecked((nuint)(UIntPtr)F.A())) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Resource1 obj7 = (Resource1)(object)h(array);
					resource = (Resource1)(object)F.A();
					resource = obj7;
				}
				else
				{
					y2 = y2;
					y2 = y2;
				}
			}
			goto IL_0205;
		}
		IL_07ad:
		while (true)
		{
			if (obj != null)
			{
				do
				{
					_ = (Resource1)(object)F.A();
				}
				while (obj != null);
			}
			else if ((object)F.A() == null)
			{
				break;
			}
		}
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is CHOOSEFONTFLAGS;
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
		try
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)h(array)) == 0)
				{
					do
					{
						_ = (CHOOSEFONT)h(array);
						intPtr = default(IntPtr);
					}
					while (y.t(intPtr) is object);
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)F.A();
				t = t;
			}
			goto IL_0866;
		}
		IL_0205:
		_ = (AssmeblyLoader)(object)F.A();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					h obj8 = (h)F.A();
					h2 = h2;
					h2 = obj8;
					f = f;
				}
				else
				{
					assemblyLoader = assemblyLoader;
					assemblyLoader = null;
				}
			}
			else
			{
				do
				{
					nint num2 = intPtr;
					nint num3 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num2) + (unchecked((nuint)num3) - unchecked((nuint)intPtr)))) is F;
				}
				while (obj != null);
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)h(y.t(intPtr) as byte[])) is Resource1;
			}
			else
			{
				do
				{
					_ = (Resource1)(object)F.A();
				}
				while ((object)h(array) != null);
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = y.t((IntPtr)h(null)) is y;
				}
				finally
				{
					_ = (y)(object)F.A();
					goto IL_037d;
				}
			}
			intPtr = default(IntPtr);
			_ = y.t(intPtr) is Resource1;
		}
		goto IL_037d;
		IL_037d:
		_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		if (uIntPtr == 0)
		{
			_ = y.t(intPtr) is CHOOSEFONTFLAGS;
			_ = (CHOOSEFONTFLAGS)h(null);
		}
		else
		{
			checked
			{
				nuint num4 = uIntPtr - uIntPtr + unchecked((nuint)(UIntPtr)h(null));
				uIntPtr = default(UIntPtr);
				nuint num5 = unchecked((nuint)default(UIntPtr)) * (unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) * uIntPtr * unchecked((nuint)default(UIntPtr)));
				uIntPtr = default(UIntPtr);
				if (num4 * ((num5 + uIntPtr + uIntPtr) * uIntPtr * unchecked((nuint)(UIntPtr)F.A())) != 0)
				{
					try
					{
						_ = (Resource1)(object)h(array);
						_ = y.t(unchecked((IntPtr)F.A())) is _003CModule_003E;
					}
					finally
					{
						r2 = r2;
						goto IL_047f;
					}
				}
				_003CPrivateImplementationDetails_003E = null;
			}
		}
		goto IL_047f;
		IL_0866:
		CHOOSEFONT obj9 = (CHOOSEFONT)h(array);
		CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
		cHOOSEFONT = obj9;
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = null;
				}
				else
				{
					_ = (CHOOSEFONTFLAGS)h(array);
					_ = (_003CModule_003E)(object)F.A();
				}
			}
			catch
			{
				while ((object)null != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					_003CModule_003E _003CModule_003E = y.t((IntPtr)h(null)) as _003CModule_003E;
				}
			}
		}
		else
		{
			try
			{
				do
				{
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
				}
				while (obj != null);
			}
			catch
			{
				while ((object)null != null)
				{
					_ = (_003CModule_003E)(object)h(array);
				}
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)h(F.A())))) is CHOOSEFONTFLAGS;
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
			}
		}
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				try
				{
					f = (F)(object)h(null);
				}
				catch
				{
					_ = y.t(intPtr) is IAssemblyLoader;
				}
			}
			else
			{
				resource = y.t((IntPtr)h(null)) as Resource1;
			}
		}
		else
		{
			_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)h(null);
		}
		do
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					y2 = y2;
				}
			}
			catch
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
				}
				catch
				{
					_ = (Resource1)(object)h(F.A());
				}
			}
		}
		while (obj != null);
		return;
		IL_047f:
		_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr))) is T;
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
		t = (T)(object)h(h(array));
		resource = null;
		cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		while ((object)null != null)
		{
			while (obj != null)
			{
				do
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					intPtr = default(IntPtr);
				}
				while ((object)h(y.t(intPtr) as byte[]) != null);
			}
		}
		if (!(y.t(intPtr) is UIntPtr))
		{
			while ((object)null != null)
			{
				try
				{
					y2 = (y)(object)F.A();
				}
				catch
				{
					resource = resource;
					f = f;
					y2 = y2;
					_003CModule_003E obj16 = y.t((IntPtr)F.A()) as _003CModule_003E;
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
					_003CModule_003E = obj16;
				}
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
				{
					nuint num6;
					checked
					{
						num6 = unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)F.A());
						intPtr = default(IntPtr);
					}
					_ = y.t((nint)(num6 / (nuint)intPtr)) is F;
					_ = (IAssemblyLoader)(object)F.A();
					_ = (IAssemblyLoader)(object)F.A();
				}
				else
				{
					_003CModule_003E _003CModule_003E = null;
				}
			}
			finally
			{
				do
				{
					_ = (AssmeblyLoader)(object)h(F.A());
				}
				while (obj != null);
				goto end_IL_05a9;
			}
			end_IL_05a9:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					resource = null;
				}
				finally
				{
					_ = (r)F.A();
					_ = (Resource1)(object)h(F.A());
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					goto end_IL_0637;
				}
			}
			end_IL_0637:;
		}
		try
		{
			intPtr = default(IntPtr);
			if (!(y.t(intPtr) is UIntPtr))
			{
				try
				{
					_ = (IAssemblyLoader)(object)h(array);
				}
				catch
				{
					y2 = y2;
				}
			}
			else
			{
				_ = y.t((IntPtr)h(array)) is CHOOSEFONTFLAGS;
			}
		}
		finally
		{
			nuint num7 = uIntPtr;
			object obj20 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)unchecked((nint)default(IntPtr)))));
			if ((int)checked(num7 - ((obj20 is UIntPtr) ? obj20 : null)) == 0)
			{
				while (obj != null)
				{
					assemblyLoader = assemblyLoader;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					intPtr = default(IntPtr);
					object obj21 = y.t(intPtr);
					object obj22 = y.t((IntPtr)((obj21 is IntPtr) ? obj21 : null));
					object obj23 = ((obj22 is IntPtr) ? obj22 : null);
					object obj24 = y.t((nint)((nuint)(nint)(IntPtr)h(null) / (nuint)intPtr));
					_ = y.t((IntPtr)checked(obj23 * ((obj24 is IntPtr) ? obj24 : null))) is h;
					r2 = default(r);
				}
			}
			goto IL_07ad;
		}
	}

	static void _007C_0021_0029_002D_0025_003F_005D_003A_005B12()
	{
		//IL_003e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_0512: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected I, but got Unknown
		//IL_0589: Expected O, but got I4
		//IL_0592: Expected I, but got O
		//IL_0593: Expected O, but got I4
		//IL_062d: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_0686: Expected O, but got I4
		//IL_06b8: Expected O, but got I4
		//IL_06ea: Expected O, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got I4
		//IL_074f: Expected O, but got I4
		//IL_076c: Expected O, but got I4
		//IL_07ca: Expected O, but got I4
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected I, but got Unknown
		//IL_07d5: Expected O, but got I4
		//IL_0808: Expected O, but got I4
		//IL_085c: Expected O, but got I4
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		byte[] array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		try
		{
			h2 = h2;
			h2 = h2;
		}
		finally
		{
			IntPtr intPtr2 = intPtr;
			object obj = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)unchecked((nint)default(IntPtr)))));
			intPtr = (nint)checked(unchecked((nuint)(nint)intPtr2) * ((obj is IntPtr) ? obj : null));
			array = y.t(intPtr) as byte[];
			_ = (y)(object)h(array);
			cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			_ = (h)F.A();
			y y2 = null;
			y2 = null;
			goto IL_0095;
		}
		IL_0095:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		CHOOSEFONT cHOOSEFONT;
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					assemblyLoader = null;
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = (y)(object)h(y.t(intPtr) as byte[]);
					goto end_IL_00a6;
				}
				end_IL_00a6:;
			}
			catch
			{
				try
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
				catch
				{
					cHOOSEFONT = default(CHOOSEFONT);
					assemblyLoader = null;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONT = default(CHOOSEFONT);
				}
			}
		}
		else
		{
			AssmeblyLoader assmeblyLoader = (AssmeblyLoader)(object)F.A();
			assmeblyLoader = assmeblyLoader;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (true)
		{
			obj4 = obj4;
			if (obj4 != null)
			{
				_ = (y)(object)h(h(y.t(intPtr) as byte[]));
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		nuint num = (UIntPtr)h(array);
		nuint num2 = num;
		intPtr = default(IntPtr);
		object obj5 = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)intPtr)));
		if ((int)checked(unchecked(num2 / ((obj5 is UIntPtr) ? obj5 : null)) - unchecked((nuint)(UIntPtr)F.A())) == 0)
		{
			do
			{
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is Resource1;
			}
			while (obj4 != null || obj4 != null);
		}
		else
		{
			try
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)h(array);
				}
				else
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
			catch
			{
				try
				{
					_ = (IAssemblyLoader)(object)h(null);
				}
				finally
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					goto end_IL_0256;
				}
				end_IL_0256:;
			}
		}
		while (true)
		{
			if ((object)null != null)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is T;
				}
				catch
				{
					_ = y.t(intPtr) is CHOOSEFONTFLAGS;
				}
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		cHOOSEFONT = (CHOOSEFONT)F.A();
		try
		{
			try
			{
				h2 = h2;
			}
			catch
			{
				intPtr = default(IntPtr);
				_ = (r)h(y.t(intPtr) as byte[]);
			}
			finally
			{
				do
				{
					y y2 = (y)(object)h(array);
					r obj9 = (r)F.A();
					r r2 = (r)h(array);
					r2 = obj9;
				}
				while (obj4 != null);
				goto end_IL_02d1;
			}
			end_IL_02d1:;
		}
		catch
		{
			_ = y.t(intPtr) is T;
		}
		try
		{
			while ((object)null != null)
			{
				intPtr = default(IntPtr);
				_ = (_003CModule_003E)(object)h(y.t((nint)checked(unchecked((nuint)intPtr) + (unchecked((nuint)intPtr) - unchecked((nuint)intPtr)))) as byte[]);
			}
		}
		finally
		{
			if (!(y.t(intPtr) is UIntPtr))
			{
				y y2 = (y)(object)F.A();
			}
			goto IL_03cb;
		}
		IL_03cb:
		_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		do
		{
			if (num == 0)
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					T t = (T)(object)h(array);
					t = null;
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)h(null);
					_ = (IAssemblyLoader)(object)h(h(null));
					continue;
				}
			}
			if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
			{
				resource = resource;
				resource = resource;
			}
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (IAssemblyLoader)(object)h(h(array));
					continue;
				}
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is T;
				intPtr = default(IntPtr);
				nint num3 = intPtr;
				intPtr = default(IntPtr);
				F obj11 = y.t((nint)checked(unchecked((nuint)num3) * unchecked((nuint)intPtr))) as F;
				f = f;
				f = obj11;
				_ = (CHOOSEFONTFLAGS)F.A();
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					_ = y.t(intPtr) is F;
					_ = (r)F.A();
					nuint num4;
					object obj13;
					checked
					{
						num4 = unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)F.A());
						object obj12 = y.t(intPtr);
						obj13 = ((obj12 is IntPtr) ? obj12 : null);
					}
					nuint num5 = checked(unchecked((nuint)(nint)(IntPtr)h(null)) - unchecked((nuint)intPtr)) / (nuint)intPtr;
					intPtr = default(IntPtr);
					object obj14 = y.t(intPtr);
					_003F val;
					checked
					{
						val = obj13 - (num5 + (((obj14 is IntPtr) ? obj14 : null) - unchecked((nuint)(nint)intPtr)));
						intPtr = default(IntPtr);
					}
					object obj15 = y.t((nint)checked(num4 * unchecked(val / intPtr)));
					_ = y.t((IntPtr)((obj15 is IntPtr) ? obj15 : null)) is T;
					goto end_IL_04f5;
				}
				end_IL_04f5:;
			}
		}
		while (obj4 != null);
		try
		{
			num = default(UIntPtr);
			nuint num6 = num;
			num = default(UIntPtr);
			nuint num7 = num;
			num = default(UIntPtr);
			nuint num8 = num;
			num = default(UIntPtr);
			if (checked(num6 + (num7 + (num8 + num))) == 0)
			{
				_ = (_003CModule_003E)(object)F.A();
			}
			else if (num == 0)
			{
				_ = (h)F.A();
			}
			else
			{
				y y2 = null;
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is y;
				_ = y.t((IntPtr)h(array)) is F;
			}
		}
		finally
		{
			if ((UIntPtr)h(h(F.A())) == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)F.A()) is F;
				_ = (r)h(array);
				f = null;
			}
			goto IL_06a3;
		}
		IL_06a3:
		do
		{
			_ = y.t((IntPtr)h(array)) is _003CPrivateImplementationDetails_003E;
		}
		while ((object)F.A() != null);
		if (num == 0)
		{
			intPtr = default(IntPtr);
			object obj17 = y.t(intPtr);
			if ((int)checked(((obj17 is UIntPtr) ? obj17 : null) * num) == 0)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is r;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
			}
			else if (!(y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)(nint)(IntPtr)h(array)))) is UIntPtr))
			{
				intPtr = default(IntPtr);
				_ = (h)h(y.t(intPtr) as byte[]);
				_ = (Resource1)(object)h(array);
				_ = (T)(object)h(null);
			}
			else
			{
				nuint num9 = (nuint)unchecked((nint)default(IntPtr)) / (nuint)(nint)(IntPtr)h(null);
				intPtr = default(IntPtr);
				object obj19 = y.t(intPtr);
				_ = y.t((nint)checked(num9 + ((obj19 is IntPtr) ? obj19 : null))) is IAssemblyLoader;
			}
		}
		try
		{
			try
			{
				f = f;
			}
			catch
			{
				while (obj4 != null)
				{
					_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)F.A()))) is _003CModule_003E;
				}
			}
		}
		catch
		{
			_ = (IAssemblyLoader)(object)F.A();
		}
		if (num != 0)
		{
			return;
		}
		object obj22 = y.t((IntPtr)h(h(h(null))));
		if ((int)checked(((obj22 is UIntPtr) ? obj22 : null) + num) == 0)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				cHOOSEFONT = default(CHOOSEFONT);
			}
			else
			{
				_ = (CHOOSEFONT)F.A();
			}
			return;
		}
		try
		{
			_ = (IAssemblyLoader)(object)h(array);
		}
		finally
		{
			_ = (F)(object)h(array);
			return;
		}
	}

	static void _007B_0021_0029_002D_0025_002F_005B_003A_005B11()
	{
		//IL_001e: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_031e: Expected I, but got O
		//IL_031f: Expected O, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_0464: Expected O, but got I4
		//IL_04cf: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got I4
		//IL_05fb: Expected O, but got I4
		//IL_061a: Expected O, but got I4
		y y2 = y2;
		y2 = null;
		object obj;
		nint intPtr;
		do
		{
			_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
			intPtr = default(IntPtr);
			obj = y.t(intPtr) as object;
		}
		while (obj != null);
		T t = t;
		t = t;
		F f = f;
		f = f;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (unchecked((nuint)(UIntPtr)F.A()) - unchecked((nuint)(UIntPtr)F.A()) == 0)
			{
				try
				{
					while ((object)null != null)
					{
						intPtr = default(IntPtr);
						_ = y.t(intPtr) is AssmeblyLoader;
					}
				}
				finally
				{
					_003CModule_003E obj2 = y.t(intPtr) as _003CModule_003E;
					_003CModule_003E = null;
					_003CModule_003E = obj2;
					goto IL_0158;
				}
			}
			goto IL_0158;
		}
		IL_03e9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			while ((object)null != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)h(array);
				}
				catch
				{
					_ = (r)F.A();
				}
			}
		}
		catch
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				r2 = default(r);
				r2 = r2;
			}
			catch
			{
				_ = (IAssemblyLoader)(object)F.A();
			}
		}
		UIntPtr num;
		if (!(y.t((IntPtr)F.A()) is UIntPtr))
		{
			do
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 + num) == 0)
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			while ((object)F.A() != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				while ((object)F.A() != null)
				{
					_ = (CHOOSEFONTFLAGS)F.A();
					t = null;
					assmeblyLoader = assmeblyLoader;
					_ = y.t(intPtr) is F;
				}
			}
			finally
			{
				if (num == 0)
				{
					h2 = default(h);
					h2 = h2;
					h2 = h2;
				}
				goto end_IL_04a5;
			}
			end_IL_04a5:;
		}
		catch
		{
			num = default(UIntPtr);
			nuint intPtr2 = num;
			intPtr = default(IntPtr);
			object obj6 = y.t(intPtr);
			if ((int)(intPtr2 / ((obj6 is UIntPtr) ? obj6 : null)) == 0)
			{
				do
				{
					r2 = r2;
				}
				while ((object)null != null);
			}
		}
		while ((object)null != null)
		{
			if (num == 0)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is _003CModule_003E;
					assmeblyLoader = assmeblyLoader;
					_003CModule_003E = (_003CModule_003E)(object)F.A();
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				cHOOSEFONT = cHOOSEFONT;
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
			}
			finally
			{
				if (num == 0)
				{
					cHOOSEFONT = default(CHOOSEFONT);
					_ = y.t(intPtr) is _003CModule_003E;
					IAssemblyLoader assemblyLoader = null;
					assemblyLoader = null;
					_ = y.t((IntPtr)F.A()) is _003CPrivateImplementationDetails_003E;
				}
				goto IL_0624;
			}
		}
		goto IL_0624;
		IL_0624:
		do
		{
			h2 = h2;
		}
		while ((object)F.A() != null);
		return;
		IL_0292:
		do
		{
			_ = (F)(object)h(array);
		}
		while (obj != null);
		if (num == 0)
		{
			do
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (r)F.A();
				}
			}
			while ((object)F.A() != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while (obj != null)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		try
		{
			nuint num3;
			checked
			{
				num3 = unchecked((nuint)(UIntPtr)h(null)) * num;
			}
			object obj8 = y.t((IntPtr)/*isinst with value type is only supported in some contexts*/);
			if ((int)checked(num3 - ((obj8 is UIntPtr) ? obj8 : null)) == 0)
			{
				do
				{
					nint num4 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num4) - unchecked((nuint)intPtr))) is AssmeblyLoader;
				}
				while ((object)null != null);
			}
			else
			{
				y2 = (y)(object)F.A();
				_ = (F)(object)h(null);
				_003CModule_003E = _003CModule_003E;
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is F;
			}
		}
		finally
		{
			try
			{
				r2 = r2;
				r2 = r2;
			}
			catch
			{
				_ = (CHOOSEFONT)h(array);
			}
			finally
			{
				do
				{
					_ = (AssmeblyLoader)(object)h(F.A());
				}
				while ((object)null != null);
				goto IL_03e9;
			}
		}
		IL_0158:
		while (true)
		{
			if ((object)F.A() != null)
			{
				num = default(UIntPtr);
				UIntPtr intPtr3 = num;
				object obj10 = y.t(intPtr);
				if ((int)checked(unchecked((nuint)intPtr3 / checked(((obj10 is UIntPtr) ? obj10 : null) - unchecked((nuint)num) + (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) + unchecked((nuint)(UIntPtr)F.A()))) - unchecked((nuint)(UIntPtr)F.A())) == 0)
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			assmeblyLoader = assmeblyLoader;
			assmeblyLoader = assmeblyLoader;
			_ = (T)(object)F.A();
			intPtr = default(IntPtr);
			_ = y.t(intPtr) is _003CModule_003E;
			goto IL_0292;
		}
		array = array;
		if ((nuint)(UIntPtr)h(array) / (nuint)(UIntPtr)h(array) == 0)
		{
			try
			{
				f = null;
			}
			finally
			{
				f = y.t(intPtr) as F;
				intPtr = default(IntPtr);
				f = y.t(intPtr) as F;
				object obj11 = y.t((IntPtr)F.A());
				object obj12 = ((obj11 is CHOOSEFONT) ? obj11 : null);
				cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = (CHOOSEFONT)obj12;
				goto IL_0292;
			}
		}
		try
		{
			y2 = y.t((IntPtr)h(array)) as y;
		}
		finally
		{
			intPtr = default(IntPtr);
			_ = y.t((nint)((nuint)intPtr / (nuint)intPtr)) is _003CModule_003E;
			goto IL_0292;
		}
	}

	public static byte[] h(byte[] P_0)
	{
		object obj = new MemoryStream();
		object obj3;
		try
		{
			switch (3)
			{
			default:
			{
				Aes aes = new AesManaged();
				try
				{
					int num = 1;
					while (true)
					{
						switch (num)
						{
						default:
							W = new byte[32];
							((AesManaged)aes).KeySize = 256;
							(aes as AesManaged).BlockSize = 128;
							num = 6;
							continue;
						case 3:
						case 6:
							(aes as AesManaged).Mode = CipherMode.CBC;
							((AesManaged)aes).Padding = PaddingMode.PKCS7;
							goto case 2;
						case 2:
							((AesManaged)aes).Key = W;
							num = 4;
							continue;
						case 4:
						case 5:
						{
							(aes as AesManaged).IV = new byte[16];
							object obj2 = new CryptoStream((MemoryStream)obj, (aes as AesManaged).CreateDecryptor(), CryptoStreamMode.Write);
							try
							{
								int num2 = 3;
								while (true)
								{
									switch (num2)
									{
									default:
										((CryptoStream)obj2).Write(P_0, 0, P_0.Length);
										(obj2 as CryptoStream).FlushFinalBlock();
										break;
									case 2:
									case 4:
										break;
									case 1:
									case 5:
										obj3 = ((MemoryStream)obj).ToArray();
										goto end_IL_00de;
									}
									num2 = 1;
									continue;
									end_IL_00de:
									break;
								}
							}
							finally
							{
								int num3 = 6;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = ((obj2 is CryptoStream) ? 1 : 5);
										goto IL_015d;
									case 1:
									case 2:
										((IDisposable)(CryptoStream)obj2).Dispose();
										break;
									case 5:
										break;
									}
									break;
									IL_015d:
									num3 = num4;
								}
							}
							break;
						}
						}
						break;
					}
				}
				finally
				{
					int num5 = 3;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = (((AesManaged)aes != null) ? 4 : 0);
							goto IL_019f;
						case 4:
							((IDisposable)(AesManaged)aes).Dispose();
							break;
						case 0:
						case 1:
							break;
						}
						break;
						IL_019f:
						num5 = num6;
					}
				}
				break;
			}
			}
		}
		finally
		{
			int num7 = 4;
			while (true)
			{
				int num8;
				switch (num7)
				{
				default:
					num8 = (((MemoryStream)obj != null) ? 1 : 2);
					goto IL_01e1;
				case 1:
					((IDisposable)(obj as MemoryStream)).Dispose();
					break;
				case 2:
				case 3:
				case 6:
					break;
				}
				break;
				IL_01e1:
				num7 = num8;
			}
		}
		switch (4)
		{
		default:
		{
			byte[] result = obj3 as byte[];
			AssmeblyLoader.C[90] = (AssmeblyLoader.C[90] ^ AssmeblyLoader.C[137]) & 0x48;
			return result;
		}
		}
	}

	static void _007B_0021_0029_002D_0025_002F_005B_003A_005B11()
	{
		//IL_001e: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got I4
		//IL_01ff: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0288: Expected O, but got I4
		//IL_0315: Expected O, but got I4
		//IL_031e: Expected I, but got O
		//IL_031f: Expected O, but got I4
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_0464: Expected O, but got I4
		//IL_04cf: Expected O, but got I4
		//IL_0539: Expected O, but got I4
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got I4
		//IL_05fb: Expected O, but got I4
		//IL_061a: Expected O, but got I4
		y y2 = y2;
		y2 = null;
		object obj;
		nint intPtr;
		do
		{
			_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
			intPtr = default(IntPtr);
			obj = y.t(intPtr) as object;
		}
		while (obj != null);
		T t = t;
		t = t;
		F f = f;
		f = f;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (unchecked((nuint)(UIntPtr)F.A()) - unchecked((nuint)(UIntPtr)F.A()) == 0)
			{
				try
				{
					while ((object)null != null)
					{
						intPtr = default(IntPtr);
						_ = y.t(intPtr) is AssmeblyLoader;
					}
				}
				finally
				{
					_003CModule_003E obj2 = y.t(intPtr) as _003CModule_003E;
					_003CModule_003E = null;
					_003CModule_003E = obj2;
					goto IL_0158;
				}
			}
			goto IL_0158;
		}
		IL_03e9:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			while ((object)null != null)
			{
				try
				{
					_ = (_003CModule_003E)(object)h(array);
				}
				catch
				{
					_ = (r)F.A();
				}
			}
		}
		catch
		{
			try
			{
				_003CModule_003E = _003CModule_003E;
				r2 = default(r);
				r2 = r2;
			}
			catch
			{
				_ = (IAssemblyLoader)(object)F.A();
			}
		}
		UIntPtr num;
		if (!(y.t((IntPtr)F.A()) is UIntPtr))
		{
			do
			{
				nuint num2 = num;
				num = default(UIntPtr);
				if (checked(num2 + num) == 0)
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			while ((object)F.A() != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				while ((object)F.A() != null)
				{
					_ = (CHOOSEFONTFLAGS)F.A();
					t = null;
					assmeblyLoader = assmeblyLoader;
					_ = y.t(intPtr) is F;
				}
			}
			finally
			{
				if (num == 0)
				{
					h2 = default(h);
					h2 = h2;
					h2 = h2;
				}
				goto end_IL_04a5;
			}
			end_IL_04a5:;
		}
		catch
		{
			num = default(UIntPtr);
			nuint intPtr2 = num;
			intPtr = default(IntPtr);
			object obj6 = y.t(intPtr);
			if ((int)(intPtr2 / ((obj6 is UIntPtr) ? obj6 : null)) == 0)
			{
				do
				{
					r2 = r2;
				}
				while ((object)null != null);
			}
		}
		while ((object)null != null)
		{
			if (num == 0)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is _003CModule_003E;
					assmeblyLoader = assmeblyLoader;
					_003CModule_003E = (_003CModule_003E)(object)F.A();
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				cHOOSEFONT = cHOOSEFONT;
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
			}
			finally
			{
				if (num == 0)
				{
					cHOOSEFONT = default(CHOOSEFONT);
					_ = y.t(intPtr) is _003CModule_003E;
					IAssemblyLoader assemblyLoader = null;
					assemblyLoader = null;
					_ = y.t((IntPtr)F.A()) is _003CPrivateImplementationDetails_003E;
				}
				goto IL_0624;
			}
		}
		goto IL_0624;
		IL_0624:
		do
		{
			h2 = h2;
		}
		while ((object)F.A() != null);
		return;
		IL_0292:
		do
		{
			_ = (F)(object)h(array);
		}
		while (obj != null);
		if (num == 0)
		{
			do
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (r)F.A();
				}
			}
			while ((object)F.A() != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while (obj != null)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		try
		{
			nuint num3;
			checked
			{
				num3 = unchecked((nuint)(UIntPtr)h(null)) * num;
			}
			object obj8 = y.t((IntPtr)/*isinst with value type is only supported in some contexts*/);
			if ((int)checked(num3 - ((obj8 is UIntPtr) ? obj8 : null)) == 0)
			{
				do
				{
					nint num4 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num4) - unchecked((nuint)intPtr))) is AssmeblyLoader;
				}
				while ((object)null != null);
			}
			else
			{
				y2 = (y)(object)F.A();
				_ = (F)(object)h(null);
				_003CModule_003E = _003CModule_003E;
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is F;
			}
		}
		finally
		{
			try
			{
				r2 = r2;
				r2 = r2;
			}
			catch
			{
				_ = (CHOOSEFONT)h(array);
			}
			finally
			{
				do
				{
					_ = (AssmeblyLoader)(object)h(F.A());
				}
				while ((object)null != null);
				goto IL_03e9;
			}
		}
		IL_0158:
		while (true)
		{
			if ((object)F.A() != null)
			{
				num = default(UIntPtr);
				UIntPtr intPtr3 = num;
				object obj10 = y.t(intPtr);
				if ((int)checked(unchecked((nuint)intPtr3 / checked(((obj10 is UIntPtr) ? obj10 : null) - unchecked((nuint)num) + (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr))) + unchecked((nuint)(UIntPtr)F.A()))) - unchecked((nuint)(UIntPtr)F.A())) == 0)
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			assmeblyLoader = assmeblyLoader;
			assmeblyLoader = assmeblyLoader;
			_ = (T)(object)F.A();
			intPtr = default(IntPtr);
			_ = y.t(intPtr) is _003CModule_003E;
			goto IL_0292;
		}
		array = array;
		if ((nuint)(UIntPtr)h(array) / (nuint)(UIntPtr)h(array) == 0)
		{
			try
			{
				f = null;
			}
			finally
			{
				f = y.t(intPtr) as F;
				intPtr = default(IntPtr);
				f = y.t(intPtr) as F;
				object obj11 = y.t((IntPtr)F.A());
				object obj12 = ((obj11 is CHOOSEFONT) ? obj11 : null);
				cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = (CHOOSEFONT)obj12;
				goto IL_0292;
			}
		}
		try
		{
			y2 = y.t((IntPtr)h(array)) as y;
		}
		finally
		{
			intPtr = default(IntPtr);
			_ = y.t((nint)((nuint)intPtr / (nuint)intPtr)) is _003CModule_003E;
			goto IL_0292;
		}
	}

	static void _007C_0021_0029_002D_0025_003F_005D_003A_005B12()
	{
		//IL_003e: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_0166: Expected O, but got I4
		//IL_01d4: Expected O, but got I4
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03dc: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04d4: Expected O, but got I4
		//IL_0512: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected I, but got Unknown
		//IL_0589: Expected O, but got I4
		//IL_0592: Expected I, but got O
		//IL_0593: Expected O, but got I4
		//IL_062d: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_0686: Expected O, but got I4
		//IL_06b8: Expected O, but got I4
		//IL_06ea: Expected O, but got I4
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got I4
		//IL_074f: Expected O, but got I4
		//IL_076c: Expected O, but got I4
		//IL_07ca: Expected O, but got I4
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected I, but got Unknown
		//IL_07d5: Expected O, but got I4
		//IL_0808: Expected O, but got I4
		//IL_085c: Expected O, but got I4
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		byte[] array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		try
		{
			h2 = h2;
			h2 = h2;
		}
		finally
		{
			IntPtr intPtr2 = intPtr;
			object obj = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)unchecked((nint)default(IntPtr)))));
			intPtr = (nint)checked(unchecked((nuint)(nint)intPtr2) * ((obj is IntPtr) ? obj : null));
			array = y.t(intPtr) as byte[];
			_ = (y)(object)h(array);
			cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			_ = (h)F.A();
			y y2 = null;
			y2 = null;
			goto IL_0095;
		}
		IL_0095:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		CHOOSEFONT cHOOSEFONT;
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					assemblyLoader = null;
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = (y)(object)h(y.t(intPtr) as byte[]);
					goto end_IL_00a6;
				}
				end_IL_00a6:;
			}
			catch
			{
				try
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
				catch
				{
					cHOOSEFONT = default(CHOOSEFONT);
					assemblyLoader = null;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONT = default(CHOOSEFONT);
				}
			}
		}
		else
		{
			AssmeblyLoader assmeblyLoader = (AssmeblyLoader)(object)F.A();
			assmeblyLoader = assmeblyLoader;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (true)
		{
			obj4 = obj4;
			if (obj4 != null)
			{
				_ = (y)(object)h(h(y.t(intPtr) as byte[]));
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		nuint num = (UIntPtr)h(array);
		nuint num2 = num;
		intPtr = default(IntPtr);
		object obj5 = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)intPtr)));
		if ((int)checked(unchecked(num2 / ((obj5 is UIntPtr) ? obj5 : null)) - unchecked((nuint)(UIntPtr)F.A())) == 0)
		{
			do
			{
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is Resource1;
			}
			while (obj4 != null || obj4 != null);
		}
		else
		{
			try
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)h(array);
				}
				else
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
			catch
			{
				try
				{
					_ = (IAssemblyLoader)(object)h(null);
				}
				finally
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					goto end_IL_0256;
				}
				end_IL_0256:;
			}
		}
		while (true)
		{
			if ((object)null != null)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is T;
				}
				catch
				{
					_ = y.t(intPtr) is CHOOSEFONTFLAGS;
				}
			}
			else if (obj4 == null)
			{
				break;
			}
		}
		cHOOSEFONT = (CHOOSEFONT)F.A();
		try
		{
			try
			{
				h2 = h2;
			}
			catch
			{
				intPtr = default(IntPtr);
				_ = (r)h(y.t(intPtr) as byte[]);
			}
			finally
			{
				do
				{
					y y2 = (y)(object)h(array);
					r obj9 = (r)F.A();
					r r2 = (r)h(array);
					r2 = obj9;
				}
				while (obj4 != null);
				goto end_IL_02d1;
			}
			end_IL_02d1:;
		}
		catch
		{
			_ = y.t(intPtr) is T;
		}
		try
		{
			while ((object)null != null)
			{
				intPtr = default(IntPtr);
				_ = (_003CModule_003E)(object)h(y.t((nint)checked(unchecked((nuint)intPtr) + (unchecked((nuint)intPtr) - unchecked((nuint)intPtr)))) as byte[]);
			}
		}
		finally
		{
			if (!(y.t(intPtr) is UIntPtr))
			{
				y y2 = (y)(object)F.A();
			}
			goto IL_03cb;
		}
		IL_03cb:
		_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		do
		{
			if (num == 0)
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					T t = (T)(object)h(array);
					t = null;
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)h(null);
					_ = (IAssemblyLoader)(object)h(h(null));
					continue;
				}
			}
			if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
			{
				resource = resource;
				resource = resource;
			}
		}
		while (obj4 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (IAssemblyLoader)(object)h(h(array));
					continue;
				}
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is T;
				intPtr = default(IntPtr);
				nint num3 = intPtr;
				intPtr = default(IntPtr);
				F obj11 = y.t((nint)checked(unchecked((nuint)num3) * unchecked((nuint)intPtr))) as F;
				f = f;
				f = obj11;
				_ = (CHOOSEFONTFLAGS)F.A();
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				finally
				{
					_ = y.t(intPtr) is F;
					_ = (r)F.A();
					nuint num4;
					object obj13;
					checked
					{
						num4 = unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)F.A());
						object obj12 = y.t(intPtr);
						obj13 = ((obj12 is IntPtr) ? obj12 : null);
					}
					nuint num5 = checked(unchecked((nuint)(nint)(IntPtr)h(null)) - unchecked((nuint)intPtr)) / (nuint)intPtr;
					intPtr = default(IntPtr);
					object obj14 = y.t(intPtr);
					_003F val;
					checked
					{
						val = obj13 - (num5 + (((obj14 is IntPtr) ? obj14 : null) - unchecked((nuint)(nint)intPtr)));
						intPtr = default(IntPtr);
					}
					object obj15 = y.t((nint)checked(num4 * unchecked(val / intPtr)));
					_ = y.t((IntPtr)((obj15 is IntPtr) ? obj15 : null)) is T;
					goto end_IL_04f5;
				}
				end_IL_04f5:;
			}
		}
		while (obj4 != null);
		try
		{
			num = default(UIntPtr);
			nuint num6 = num;
			num = default(UIntPtr);
			nuint num7 = num;
			num = default(UIntPtr);
			nuint num8 = num;
			num = default(UIntPtr);
			if (checked(num6 + (num7 + (num8 + num))) == 0)
			{
				_ = (_003CModule_003E)(object)F.A();
			}
			else if (num == 0)
			{
				_ = (h)F.A();
			}
			else
			{
				y y2 = null;
				intPtr = default(IntPtr);
				_ = y.t(intPtr) is y;
				_ = y.t((IntPtr)h(array)) is F;
			}
		}
		finally
		{
			if ((UIntPtr)h(h(F.A())) == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)F.A()) is F;
				_ = (r)h(array);
				f = null;
			}
			goto IL_06a3;
		}
		IL_06a3:
		do
		{
			_ = y.t((IntPtr)h(array)) is _003CPrivateImplementationDetails_003E;
		}
		while ((object)F.A() != null);
		if (num == 0)
		{
			intPtr = default(IntPtr);
			object obj17 = y.t(intPtr);
			if ((int)checked(((obj17 is UIntPtr) ? obj17 : null) * num) == 0)
			{
				try
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is r;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
				}
			}
			else if (!(y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)(nint)(IntPtr)h(array)))) is UIntPtr))
			{
				intPtr = default(IntPtr);
				_ = (h)h(y.t(intPtr) as byte[]);
				_ = (Resource1)(object)h(array);
				_ = (T)(object)h(null);
			}
			else
			{
				nuint num9 = (nuint)unchecked((nint)default(IntPtr)) / (nuint)(nint)(IntPtr)h(null);
				intPtr = default(IntPtr);
				object obj19 = y.t(intPtr);
				_ = y.t((nint)checked(num9 + ((obj19 is IntPtr) ? obj19 : null))) is IAssemblyLoader;
			}
		}
		try
		{
			try
			{
				f = f;
			}
			catch
			{
				while (obj4 != null)
				{
					_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)F.A()))) is _003CModule_003E;
				}
			}
		}
		catch
		{
			_ = (IAssemblyLoader)(object)F.A();
		}
		if (num != 0)
		{
			return;
		}
		object obj22 = y.t((IntPtr)h(h(h(null))));
		if ((int)checked(((obj22 is UIntPtr) ? obj22 : null) + num) == 0)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				cHOOSEFONT = default(CHOOSEFONT);
			}
			else
			{
				_ = (CHOOSEFONT)F.A();
			}
			return;
		}
		try
		{
			_ = (IAssemblyLoader)(object)h(array);
		}
		finally
		{
			_ = (F)(object)h(array);
			return;
		}
	}

	static void _007C_005D_0029_002D_003B_003F_005D_003A_005E14()
	{
		//IL_0038: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected I, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected I, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		//IL_0344: Expected O, but got I4
		//IL_0377: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		//IL_048f: Expected O, but got I4
		//IL_04a8: Expected O, but got I4
		//IL_050e: Expected O, but got I4
		//IL_053c: Expected O, but got I4
		//IL_0588: Expected O, but got I4
		//IL_05e2: Expected O, but got I4
		//IL_069b: Expected O, but got I4
		//IL_06df: Expected O, but got I4
		//IL_0708: Expected O, but got I4
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got I4
		//IL_0745: Expected I, but got O
		//IL_0746: Expected O, but got I4
		//IL_0760: Expected O, but got I4
		//IL_076a: Expected I, but got O
		//IL_076b: Expected O, but got I4
		//IL_07db: Expected O, but got I4
		//IL_082d: Expected O, but got I4
		//IL_08e6: Expected O, but got I4
		//IL_097b: Expected O, but got I4
		//IL_099a: Expected O, but got I4
		//IL_09e1: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		T t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		try
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					t = null;
					t = null;
					continue;
				}
				break;
			}
		}
		finally
		{
			intPtr = intPtr;
			if (!(y.t(intPtr) is UIntPtr))
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = assmeblyLoader;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					_ = (Resource1)(object)F.A();
				}
			}
			goto IL_00a1;
		}
		IL_00a1:
		F f;
		do
		{
			f = null;
			f = null;
		}
		while ((object)null != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y2);
		Resource1 resource;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			object obj2 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr)));
			_003F val;
			checked
			{
				val = unchecked(((obj2 is IntPtr) ? obj2 : null) / intPtr) + unchecked((nuint)unchecked((nint)default(IntPtr)));
				intPtr = default(IntPtr);
			}
			object obj3 = y.t((IntPtr)checked(val * (unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)intPtr / (nuint)intPtr)) + intPtr));
			object obj4 = ((obj3 is IntPtr) ? obj3 : null);
			array = F.A();
			object obj5 = y.t((IntPtr)(obj4 / ((nuint)(nint)(IntPtr)h(array) / checked(unchecked((nuint)(nint)(IntPtr)h(null)) + unchecked((nuint)(nint)(IntPtr)h(array)) + unchecked((nuint)(nint)(IntPtr)F.A())))));
			r2 = (r)((obj5 is r) ? obj5 : null);
			r2 = default(r);
			r2 = r2;
		}
		finally
		{
			IntPtr num = (IntPtr)F.A();
			intPtr = default(IntPtr);
			object obj6 = y.t((nint)checked(unchecked((nuint)(nint)num) - unchecked((nuint)intPtr / (nuint)(nint)(IntPtr)h(array))));
			if ((int)checked(((obj6 is UIntPtr) ? obj6 : null) - unchecked((nuint)(UIntPtr)F.A())) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					Resource1 obj7 = (Resource1)(object)h(array);
					resource = (Resource1)(object)F.A();
					resource = obj7;
				}
				else
				{
					y2 = y2;
					y2 = y2;
				}
			}
			goto IL_0205;
		}
		IL_07ad:
		while (true)
		{
			if (obj != null)
			{
				do
				{
					_ = (Resource1)(object)F.A();
				}
				while (obj != null);
			}
			else if ((object)F.A() == null)
			{
				break;
			}
		}
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is CHOOSEFONTFLAGS;
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
		try
		{
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)h(array)) == 0)
				{
					do
					{
						_ = (CHOOSEFONT)h(array);
						intPtr = default(IntPtr);
					}
					while (y.t(intPtr) is object);
				}
			}
		}
		finally
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)F.A();
				t = t;
			}
			goto IL_0866;
		}
		IL_0205:
		_ = (AssmeblyLoader)(object)F.A();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		while (obj != null)
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr * uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					h obj8 = (h)F.A();
					h2 = h2;
					h2 = obj8;
					f = f;
				}
				else
				{
					assemblyLoader = assemblyLoader;
					assemblyLoader = null;
				}
			}
			else
			{
				do
				{
					nint num2 = intPtr;
					nint num3 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num2) + (unchecked((nuint)num3) - unchecked((nuint)intPtr)))) is F;
				}
				while (obj != null);
			}
		}
		if (uIntPtr == 0)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)h(y.t(intPtr) as byte[])) is Resource1;
			}
			else
			{
				do
				{
					_ = (Resource1)(object)F.A();
				}
				while ((object)h(array) != null);
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = y.t((IntPtr)h(null)) is y;
				}
				finally
				{
					_ = (y)(object)F.A();
					goto IL_037d;
				}
			}
			intPtr = default(IntPtr);
			_ = y.t(intPtr) is Resource1;
		}
		goto IL_037d;
		IL_037d:
		_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		if (uIntPtr == 0)
		{
			_ = y.t(intPtr) is CHOOSEFONTFLAGS;
			_ = (CHOOSEFONTFLAGS)h(null);
		}
		else
		{
			checked
			{
				nuint num4 = uIntPtr - uIntPtr + unchecked((nuint)(UIntPtr)h(null));
				uIntPtr = default(UIntPtr);
				nuint num5 = unchecked((nuint)default(UIntPtr)) * (unchecked(unchecked((nuint)default(UIntPtr)) / uIntPtr) * uIntPtr * unchecked((nuint)default(UIntPtr)));
				uIntPtr = default(UIntPtr);
				if (num4 * ((num5 + uIntPtr + uIntPtr) * uIntPtr * unchecked((nuint)(UIntPtr)F.A())) != 0)
				{
					try
					{
						_ = (Resource1)(object)h(array);
						_ = y.t(unchecked((IntPtr)F.A())) is _003CModule_003E;
					}
					finally
					{
						r2 = r2;
						goto IL_047f;
					}
				}
				_003CPrivateImplementationDetails_003E = null;
			}
		}
		goto IL_047f;
		IL_0866:
		CHOOSEFONT obj9 = (CHOOSEFONT)h(array);
		CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
		cHOOSEFONT = obj9;
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = null;
				}
				else
				{
					_ = (CHOOSEFONTFLAGS)h(array);
					_ = (_003CModule_003E)(object)F.A();
				}
			}
			catch
			{
				while ((object)null != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					_003CModule_003E _003CModule_003E = y.t((IntPtr)h(null)) as _003CModule_003E;
				}
			}
		}
		else
		{
			try
			{
				do
				{
					assmeblyLoader = (AssmeblyLoader)(object)F.A();
				}
				while (obj != null);
			}
			catch
			{
				while ((object)null != null)
				{
					_ = (_003CModule_003E)(object)h(array);
				}
			}
		}
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				intPtr = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)h(F.A())))) is CHOOSEFONTFLAGS;
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
			}
		}
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				try
				{
					f = (F)(object)h(null);
				}
				catch
				{
					_ = y.t(intPtr) is IAssemblyLoader;
				}
			}
			else
			{
				resource = y.t((IntPtr)h(null)) as Resource1;
			}
		}
		else
		{
			_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)h(null);
		}
		do
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					y2 = y2;
				}
			}
			catch
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
				}
				catch
				{
					_ = (Resource1)(object)h(F.A());
				}
			}
		}
		while (obj != null);
		return;
		IL_047f:
		_ = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)intPtr))) is T;
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is _003CPrivateImplementationDetails_003E;
		t = (T)(object)h(h(array));
		resource = null;
		cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		while ((object)null != null)
		{
			while (obj != null)
			{
				do
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					intPtr = default(IntPtr);
				}
				while ((object)h(y.t(intPtr) as byte[]) != null);
			}
		}
		if (!(y.t(intPtr) is UIntPtr))
		{
			while ((object)null != null)
			{
				try
				{
					y2 = (y)(object)F.A();
				}
				catch
				{
					resource = resource;
					f = f;
					y2 = y2;
					_003CModule_003E obj16 = y.t((IntPtr)F.A()) as _003CModule_003E;
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)F.A();
					_003CModule_003E = obj16;
				}
			}
		}
		try
		{
			try
			{
				if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
				{
					nuint num6;
					checked
					{
						num6 = unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)F.A());
						intPtr = default(IntPtr);
					}
					_ = y.t((nint)(num6 / (nuint)intPtr)) is F;
					_ = (IAssemblyLoader)(object)F.A();
					_ = (IAssemblyLoader)(object)F.A();
				}
				else
				{
					_003CModule_003E _003CModule_003E = null;
				}
			}
			finally
			{
				do
				{
					_ = (AssmeblyLoader)(object)h(F.A());
				}
				while (obj != null);
				goto end_IL_05a9;
			}
			end_IL_05a9:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					resource = null;
				}
				finally
				{
					_ = (r)F.A();
					_ = (Resource1)(object)h(F.A());
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					goto end_IL_0637;
				}
			}
			end_IL_0637:;
		}
		try
		{
			intPtr = default(IntPtr);
			if (!(y.t(intPtr) is UIntPtr))
			{
				try
				{
					_ = (IAssemblyLoader)(object)h(array);
				}
				catch
				{
					y2 = y2;
				}
			}
			else
			{
				_ = y.t((IntPtr)h(array)) is CHOOSEFONTFLAGS;
			}
		}
		finally
		{
			nuint num7 = uIntPtr;
			object obj20 = y.t((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)unchecked((nint)default(IntPtr)))));
			if ((int)checked(num7 - ((obj20 is UIntPtr) ? obj20 : null)) == 0)
			{
				while (obj != null)
				{
					assemblyLoader = assemblyLoader;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					intPtr = default(IntPtr);
					object obj21 = y.t(intPtr);
					object obj22 = y.t((IntPtr)((obj21 is IntPtr) ? obj21 : null));
					object obj23 = ((obj22 is IntPtr) ? obj22 : null);
					object obj24 = y.t((nint)((nuint)(nint)(IntPtr)h(null) / (nuint)intPtr));
					_ = y.t((IntPtr)checked(obj23 * ((obj24 is IntPtr) ? obj24 : null))) is h;
					r2 = default(r);
				}
			}
			goto IL_07ad;
		}
	}

	static void _007D_002F_007D_003A_007D_007C_0024_0028_005E_005E_003D_003A16()
	{
		//IL_00a1: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00df: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01cd: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected I, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_0339: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_03bd: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_0472: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_04ea: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected I, but got Unknown
		//IL_05c3: Expected O, but got I4
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected I, but got Unknown
		//IL_05d9: Expected O, but got I4
		//IL_05fa: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0620: Expected I, but got O
		//IL_0621: Expected O, but got I4
		//IL_064c: Expected O, but got I4
		//IL_0661: Expected O, but got I4
		//IL_06e6: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_076a: Expected O, but got I4
		//IL_079d: Expected O, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got I4
		//IL_0834: Expected O, but got I4
		//IL_083d: Expected I, but got O
		//IL_083e: Expected O, but got I4
		//IL_085f: Expected O, but got I4
		//IL_0892: Expected O, but got I4
		//IL_08f6: Expected O, but got I4
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got I4
		//IL_0a49: Expected O, but got I4
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num5);
		try
		{
			_ = (Resource1)(object)F.A();
		}
		catch
		{
			while ((object)null != null)
			{
				nuint num2 = num;
				UIntPtr num3 = (UIntPtr)F.A();
				num = default(UIntPtr);
				checked
				{
					nuint num4 = num + num;
					num = default(UIntPtr);
					num = num2 - unchecked((nuint)num3 / checked(unchecked((nuint)default(UIntPtr)) * (unchecked(checked(num4 + num) / num) - unchecked((nuint)default(UIntPtr)))));
					num = default(UIntPtr);
				}
				if (num == 0)
				{
					_ = y.t((IntPtr)F.A()) is CHOOSEFONTFLAGS;
					continue;
				}
				_ = (IAssemblyLoader)(object)F.A();
				num5 = (nint)checked(unchecked((nuint)(nint)(IntPtr)h(y.t((IntPtr)h(h(y.t(num5) as byte[]))) as byte[])) + unchecked((nuint)num5) - unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)num5));
				nuint num6 = (nuint)unchecked((nint)default(IntPtr)) / (nuint)unchecked((nint)default(IntPtr));
				num5 = default(IntPtr);
				_ = y.t((nint)checked(num6 * unchecked((nuint)num5))) is _003CPrivateImplementationDetails_003E;
				_ = (r)h(F.A());
				_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			try
			{
				resource = null;
				resource = null;
			}
			catch
			{
				_ = (CHOOSEFONTFLAGS)h(null);
			}
			finally
			{
				try
				{
					_ = y.t((IntPtr)h(F.A())) is r;
				}
				finally
				{
					num5 = default(IntPtr);
					_ = y.t(num5) is AssmeblyLoader;
					goto end_IL_016b;
				}
			}
			end_IL_016b:;
		}
		finally
		{
			h h2 = h2;
			h2 = default(h);
			goto IL_01fa;
		}
		IL_0854:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			resource = y.t(num5) as Resource1;
		}
		while (obj3 != null);
		try
		{
			if ((UIntPtr)h(null) == (UIntPtr)(nuint)0u)
			{
				_ = y.t((IntPtr)F.A()) is _003CPrivateImplementationDetails_003E;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				nint num7 = num5;
				nuint num9;
				checked
				{
					nuint num8 = unchecked((nuint)num5) + unchecked((nuint)num5);
					num5 = default(IntPtr);
					num9 = num8 * (unchecked((nuint)num5) - unchecked((nuint)num5));
					num5 = default(IntPtr);
				}
				object obj4 = y.t((nint)((nuint)num7 / (num9 / (nuint)num5)));
				object obj5 = ((obj4 is UIntPtr) ? obj4 : null);
				num = default(UIntPtr);
				if ((int)(checked(unchecked((nuint)default(UIntPtr)) - unchecked(obj5 / checked(num * (num * num)))) / (nuint)(UIntPtr)h(null)) == 0)
				{
					_ = (y)(object)F.A();
				}
				else
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = null;
				}
			}
		}
		try
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				if (num == 0)
				{
					h h2 = default(h);
				}
				else
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
			}
			else
			{
				_ = y.t((IntPtr)h(F.A())) is CHOOSEFONT;
			}
		}
		finally
		{
			do
			{
				resource = resource;
			}
			while (obj3 != null);
			goto IL_09c6;
		}
		IL_01fa:
		IntPtr intPtr = (IntPtr)F.A();
		nint intPtr2 = num5;
		num5 = default(IntPtr);
		IntPtr intPtr3 = num5;
		nuint num10;
		object obj7;
		checked
		{
			num10 = unchecked((nuint)(nint)(IntPtr)F.A()) * unchecked((nuint)(nint)(IntPtr)F.A());
			obj7 = y.t(num5);
		}
		_003F val = num10 / ((obj7 is IntPtr) ? obj7 : null) / (nuint)(nint)num5;
		byte[] array = array;
		_003F val2 = val / (nuint)(nint)(IntPtr)h(array);
		IntPtr intPtr4 = (IntPtr)h(h(array));
		object obj8 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)h(array)) * unchecked((nuint)unchecked((nint)default(IntPtr)))));
		_003F val3;
		_003F val4;
		checked
		{
			val3 = val2 * (unchecked((nuint)(nint)intPtr4) * ((obj8 is IntPtr) ? obj8 : null));
			object obj9 = y.t(unchecked((IntPtr)F.A()));
			object obj10 = ((obj9 is IntPtr) ? obj9 : null);
			num5 = default(IntPtr);
			val4 = obj10 * unchecked((nuint)(nint)num5);
		}
		object obj11 = y.t((IntPtr)F.A());
		if (!(y.t((nint)checked(unchecked((nuint)(nint)intPtr) + intPtr2 * (unchecked((nuint)(nint)intPtr3) + val3 * (val4 + ((obj11 is IntPtr) ? obj11 : null))))) is UIntPtr))
		{
			try
			{
				if (num == 0)
				{
					_ = (IAssemblyLoader)(object)F.A();
					_003CPrivateImplementationDetails_003E = null;
					_ = (AssmeblyLoader)(object)F.A();
					_003CPrivateImplementationDetails_003E = null;
				}
				else
				{
					_ = (y)(object)h(array);
				}
			}
			finally
			{
				while (true)
				{
					obj3 = obj3;
					if (obj3 == null)
					{
						break;
					}
					_ = y.t(num5) is CHOOSEFONTFLAGS;
				}
				goto IL_039c;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r2);
		try
		{
			r2 = (r)F.A();
			r2 = r2;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = y.t(num5) is IAssemblyLoader;
			}
			goto IL_039c;
		}
		IL_05e5:
		num5 = default(IntPtr);
		AssmeblyLoader assmeblyLoader = y.t(num5) as AssmeblyLoader;
		assmeblyLoader = assmeblyLoader;
		do
		{
			try
			{
				try
				{
					object obj12 = y.t(num5);
					_ = (AssmeblyLoader)(object)h(y.t((IntPtr)((obj12 is IntPtr) ? obj12 : null)) as byte[]);
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = y.t(num5) is F;
				}
				finally
				{
					_ = y.t(num5) is _003CModule_003E;
					goto end_IL_060b;
				}
				end_IL_060b:;
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)F.A();
				}
				catch
				{
					_ = (Resource1)(object)h(F.A());
				}
			}
		}
		while (obj3 != null);
		if (num == 0)
		{
			try
			{
				do
				{
					_ = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) * unchecked((nuint)unchecked((nint)default(IntPtr))) - (unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)(nint)(IntPtr)F.A())))) is CHOOSEFONTFLAGS;
				}
				while (obj3 != null);
			}
			catch
			{
				_ = (r)h(null);
			}
		}
		else
		{
			_ = y.t(default(IntPtr)) is IAssemblyLoader;
			_ = (_003CModule_003E)(object)h(array);
			y y2 = (y)(object)F.A();
		}
		num5 = default(IntPtr);
		if (!(y.t((nint)((nuint)unchecked((nint)default(IntPtr)) / (nuint)num5)) is UIntPtr))
		{
			_ = (_003CModule_003E)(object)F.A();
			goto IL_0854;
		}
		try
		{
			UIntPtr intPtr5 = (UIntPtr)h(array);
			object obj16 = y.t(num5);
			if ((int)((nuint)intPtr5 / ((obj16 is UIntPtr) ? obj16 : null)) == 0)
			{
				_ = (CHOOSEFONT)F.A();
				assmeblyLoader = assmeblyLoader;
				r2 = r2;
				IntPtr num11 = (IntPtr)h(null);
				IntPtr num12 = (IntPtr)F.A();
				num5 = default(IntPtr);
				nuint num13;
				checked
				{
					num13 = unchecked((nuint)(nint)num11) * (unchecked((nuint)(nint)num12) - unchecked((nuint)num5));
					num5 = default(IntPtr);
				}
				_ = y.t((nint)checked(num13 + unchecked((nuint)num5))) is CHOOSEFONTFLAGS;
			}
			else
			{
				y y2 = (y)(object)h(h(array));
			}
		}
		finally
		{
			object obj17 = y.t(num5);
			if (!(y.t((IntPtr)((obj17 is IntPtr) ? obj17 : null)) is UIntPtr))
			{
				assmeblyLoader = assmeblyLoader;
			}
			goto IL_0854;
		}
		IL_09c6:
		_ = (F)(object)h(null);
		_ = (IAssemblyLoader)(object)F.A();
		CHOOSEFONT obj18 = (CHOOSEFONT)F.A();
		CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
		cHOOSEFONT = obj18;
		r2 = default(r);
		_ = (T)(object)F.A();
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			if (num == 0)
			{
				_ = (F)(object)h(array);
			}
		}
		else
		{
			_ = y.t(num5) is _003CPrivateImplementationDetails_003E;
		}
		return;
		IL_039c:
		_ = (_003CPrivateImplementationDetails_003E)(object)h(null);
		num5 = default(IntPtr);
		F f = (F)(object)h(h(y.t(num5) as byte[]));
		f = f;
		while ((object)null != null)
		{
			resource = null;
		}
		do
		{
			resource = resource;
		}
		while ((object)null != null);
		r2 = r2;
		_ = y.t(num5) is F;
		nuint num14 = num / (nuint)(UIntPtr)h(h(array));
		num = default(UIntPtr);
		if (checked(num14 + num) == 0)
		{
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)h(array);
			}
			catch
			{
				try
				{
					_ = y.t((IntPtr)F.A()) is T;
				}
				catch
				{
					_ = y.t((IntPtr)F.A()) is F;
					y y2 = y2;
					y2 = y2;
					_ = y.t(num5) is AssmeblyLoader;
				}
			}
		}
		if ((UIntPtr)h(array) == (UIntPtr)(nuint)0u)
		{
			_ = (F)(object)F.A();
			num5 = default(IntPtr);
			_ = (y)(object)h(y.t(num5) as byte[]);
		}
		else if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			resource = null;
		}
		else
		{
			_ = (AssmeblyLoader)(object)h(null);
		}
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
			while (true)
			{
				if (obj3 != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				else if ((object)h(array) == null)
				{
					break;
				}
			}
		}
		finally
		{
			if (num == 0)
			{
				while (true)
				{
					nint num15 = num5;
					num5 = default(IntPtr);
					nuint num16;
					checked
					{
						num16 = unchecked((nuint)num15) * (unchecked((nuint)num5) + unchecked((nuint)(nint)(IntPtr)F.A()) - unchecked((nuint)num5));
					}
					object obj21 = y.t((IntPtr)F.A());
					object obj22 = y.t((nint)checked(num16 * ((obj21 is IntPtr) ? obj21 : null)));
					if (y.t((IntPtr)(((obj22 is IntPtr) ? obj22 : null) / (nuint)(nint)(IntPtr)h(null))) is object)
					{
						h h2 = default(h);
						continue;
					}
					break;
				}
			}
			goto IL_05e5;
		}
	}
}
