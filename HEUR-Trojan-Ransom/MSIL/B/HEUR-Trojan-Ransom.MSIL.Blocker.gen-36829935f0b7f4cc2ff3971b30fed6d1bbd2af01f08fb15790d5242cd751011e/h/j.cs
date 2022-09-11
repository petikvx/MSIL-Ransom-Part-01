using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using h13;

namespace h;

internal sealed class j
{
	private static readonly byte[] L = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	private const int E = 32;

	private static byte[] s = L;

	static void @_002B_003E_002A_007C__002F_0040_002619()
	{
		//IL_0043: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0183: Expected I, but got O
		//IL_0184: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected I, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_01ce: Expected I, but got O
		//IL_01cf: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_048a: Expected O, but got I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected I, but got Unknown
		//IL_04ab: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected I, but got Unknown
		//IL_0548: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		//IL_057d: Expected O, but got I4
		//IL_06f8: Expected O, but got I4
		//IL_0764: Expected O, but got I4
		//IL_07a1: Expected O, but got I4
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		AssmeblyLoader assmeblyLoader = null;
		assmeblyLoader = assmeblyLoader;
		nint intPtr = default(IntPtr);
		intPtr = default(IntPtr);
		IAssemblyLoader obj = global::h.E.C(intPtr) as IAssemblyLoader;
		IAssemblyLoader assemblyLoader = assemblyLoader;
		assemblyLoader = obj;
		assmeblyLoader = global::h.E.C(intPtr) as AssmeblyLoader;
		byte[] array = array;
		_ = (CHOOSEFONTFLAGS)M(array);
		_ = (E)(object)n.d();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		if (!(global::h.E.C(intPtr) is UIntPtr))
		{
			do
			{
				UIntPtr num = (UIntPtr)M(array);
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) * uIntPtr == 0)
					{
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
					else
					{
						h = h;
						h = default(H);
					}
					obj2 = M(n.d());
				}
			}
			while (obj2 != null);
		}
		else
		{
			try
			{
				do
				{
					_ = (n)(object)n.d();
					_ = global::h.E.C((IntPtr)n.d()) is Resource1;
					intPtr = default(IntPtr);
					object obj3 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) + (unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)M(array)))));
					_ = global::h.E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null)) is n;
					_ = (n)(object)n.d();
				}
				while ((object)null != null);
			}
			catch
			{
				IntPtr intPtr2 = (IntPtr)n.d();
				object obj4 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)intPtr)));
				object obj5 = global::h.E.C((nint)((nuint)(nint)intPtr2 / ((obj4 is IntPtr) ? obj4 : null)));
				if (!(global::h.E.C((IntPtr)((obj5 is IntPtr) ? obj5 : null)) is UIntPtr))
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					_ = (n)(object)n.d();
				}
			}
		}
		_ = (CHOOSEFONTFLAGS)n.d();
		_ = global::h.E.C(intPtr) is H;
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
			while ((object)null != null)
			{
				try
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = default(CHOOSEFONT);
				}
				finally
				{
					_ = (E)(object)M(n.d());
					_ = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is H;
					cHOOSEFONT = default(CHOOSEFONT);
					intPtr = default(IntPtr);
					assemblyLoader = global::h.E.C(intPtr) as IAssemblyLoader;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		try
		{
			try
			{
				try
				{
					_ = (X)n.d();
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				}
				finally
				{
					e = e;
					e = e;
					goto end_IL_02b4;
				}
				end_IL_02b4:;
			}
			finally
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					_ = (_003CModule_003E)(object)n.d();
					intPtr = default(IntPtr);
					nuint num2 = (nuint)intPtr / (nuint)intPtr;
					IntPtr num3 = (IntPtr)M(array);
					intPtr = default(IntPtr);
					nuint num4;
					checked
					{
						num4 = unchecked((nuint)(nint)num3) * unchecked((nuint)intPtr);
						intPtr = default(IntPtr);
					}
					_ = global::h.E.C((nint)checked(num2 - (num4 - (unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))))) is AssmeblyLoader;
					n n2 = (n)(object)n.d();
					n2 = n2;
				}
				finally
				{
					x = x;
					x = x;
					goto end_IL_02b3;
				}
			}
			end_IL_02b3:;
		}
		finally
		{
			_ = global::h.E.C((IntPtr)M(M(array))) is AssmeblyLoader;
			goto IL_03b9;
		}
		IL_03b9:
		x = x;
		_ = (j)(object)n.d();
		while ((object)M(array) != null)
		{
			try
			{
				UIntPtr num5 = (UIntPtr)M(null);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num5) - uIntPtr == 0)
					{
						_ = (CHOOSEFONT)M(array);
					}
				}
			}
			catch
			{
				cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				_ = global::h.E.C(intPtr) is IAssemblyLoader;
				x = x;
				intPtr = default(IntPtr);
				nuint num6;
				nuint num7;
				checked
				{
					num6 = unchecked((nuint)intPtr) * unchecked((nuint)intPtr);
					intPtr = default(IntPtr);
					num7 = unchecked((nuint)intPtr) + unchecked((nuint)intPtr);
				}
				object obj7 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)M(array)) + unchecked((nuint)(nint)(IntPtr)M(global::h.E.C(intPtr) as byte[]))));
				assmeblyLoader = global::h.E.C((nint)checked(num6 + num7 * (((obj7 is IntPtr) ? obj7 : null) + unchecked((nuint)(nint)(IntPtr)M(n.d()))))) as AssmeblyLoader;
			}
		}
		do
		{
			if ((UIntPtr)M(array) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (H)M(array);
					_003CPrivateImplementationDetails_003E obj9 = (_003CPrivateImplementationDetails_003E)(object)M(n.d());
					object obj10 = global::h.E.C(intPtr);
					_003F val = ((obj10 is IntPtr) ? obj10 : null) / (nuint)(nint)(IntPtr)M(array);
					intPtr = default(IntPtr);
					_003F val2 = checked((val - intPtr) * intPtr);
					intPtr = default(IntPtr);
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = global::h.E.C((IntPtr)checked(val2 - intPtr)) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = obj9;
					intPtr = default(IntPtr);
					_ = global::h.E.C(intPtr) is CHOOSEFONT;
				}
				catch
				{
					_ = global::h.E.C(intPtr) is CHOOSEFONTFLAGS;
				}
			}
			else
			{
				do
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = (H)n.d();
					x = x;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		do
		{
			try
			{
				h = (H)M(array);
			}
			finally
			{
				n n2 = null;
				continue;
			}
		}
		while ((object)n.d() != null || (object)null != null);
		e = e;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			UIntPtr num8 = uIntPtr;
			UIntPtr num9 = (UIntPtr)n.d();
			UIntPtr num10 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((nuint)num8 / checked(unchecked((nuint)num9) - (unchecked((nuint)num10) + uIntPtr)) == 0)
			{
				_003CModule_003E obj12 = (_003CModule_003E)(object)M(array);
				_003CModule_003E = null;
				_003CModule_003E = obj12;
				_ = (CHOOSEFONT)n.d();
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while ((object)n.d() != null)
				{
					_ = (Resource1)(object)M(array);
					h = default(H);
					_ = (IAssemblyLoader)(object)M(null);
				}
			}
		}
		while (obj2 != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				if (!(global::h.E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))) is UIntPtr))
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				else
				{
					_ = (_003CModule_003E)(object)n.d();
				}
			}
		}
		do
		{
			try
			{
				while (obj2 != null)
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				nint num11 = intPtr;
				intPtr = default(IntPtr);
				_ = global::h.E.C((nint)checked(unchecked((nuint)num11) - unchecked((nuint)intPtr))) is CHOOSEFONTFLAGS;
			}
		}
		while (obj2 != null);
		assemblyLoader = assemblyLoader;
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = global::h.E.C(intPtr) is X;
					h = h;
					_ = (n)(object)n.d();
					_ = (n)(object)n.d();
				}
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				catch
				{
					n n2 = (n)(object)n.d();
				}
			}
		}
	}

	static void @_003B_0025_002F_007C__002F_002E_002A18()
	{
		//IL_0040: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01bd: Expected I, but got O
		//IL_01be: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected I, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_0347: Expected O, but got I4
		//IL_0363: Expected O, but got I4
		//IL_03e8: Expected O, but got I4
		//IL_03f7: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected I, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_05a3: Expected I, but got O
		//IL_05a4: Expected O, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got I4
		//IL_06f7: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_078f: Expected O, but got I4
		//IL_0798: Expected I, but got O
		//IL_0799: Expected O, but got I4
		//IL_0814: Expected O, but got I4
		//IL_0849: Expected O, but got I4
		//IL_0889: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		try
		{
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				x = x;
				x = default(X);
				object obj = global::h.E.C(num);
				num = (nint)checked(((obj is IntPtr) ? obj : null) + (unchecked((nuint)num) - unchecked((nuint)num)));
				_ = global::h.E.C(num) is CHOOSEFONTFLAGS;
			}
			else
			{
				try
				{
					array = null;
					_ = (IAssemblyLoader)(object)M(array);
				}
				catch
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					resource = resource;
					resource = resource;
					h = h;
					h = h;
					_ = (CHOOSEFONTFLAGS)n.d();
				}
			}
		}
		catch
		{
			try
			{
				_ = global::h.E.C((IntPtr)n.d()) is n;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					E e = e;
					e = e;
				}
				else
				{
					_ = (n)(object)M(n.d());
				}
				goto end_IL_00c6;
			}
			end_IL_00c6:;
		}
		while ((object)M(null) != null)
		{
			resource = global::h.E.C(num) as Resource1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					nint num2 = num;
					num = default(IntPtr);
					object obj4 = global::h.E.C((IntPtr)M(global::h.E.C((nint)(checked(unchecked((nuint)num2) + unchecked((nuint)num)) / (nuint)(nint)(IntPtr)M(array))) as byte[]));
					_ = global::h.E.C((IntPtr)((obj4 is IntPtr) ? obj4 : null)) is CHOOSEFONTFLAGS;
				}
			}
			else
			{
				num = default(IntPtr);
				if (!(global::h.E.C(num) is UIntPtr))
				{
					_003CModule_003E obj5 = global::h.E.C((IntPtr)n.d()) as _003CModule_003E;
					_003CModule_003E = (_003CModule_003E)(object)n.d();
					_003CModule_003E = obj5;
				}
				else
				{
					object obj6 = global::h.E.C((IntPtr)M(array));
					_003F val = ((obj6 is IntPtr) ? obj6 : null) / num;
					object obj7 = global::h.E.C(num);
					_ = (X)M(M(global::h.E.C((IntPtr)checked(val - ((obj7 is IntPtr) ? obj7 : null))) as byte[]));
				}
			}
		}
		finally
		{
			_ = (n)(object)n.d();
			goto IL_02a3;
		}
		IL_02a3:
		while ((object)null != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (Resource1)(object)n.d();
			}
		}
		x = default(X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n2);
		while (obj8 != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					resource = resource;
				}
			}
			catch
			{
				do
				{
					n2 = n2;
					n2 = n2;
					obj8 = obj8;
				}
				while (obj8 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Resource1)(object)M(null);
				}
				finally
				{
					_ = (n)(object)n.d();
					_ = global::h.E.C(num) is X;
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = null;
					_ = global::h.E.C(num) is _003CModule_003E;
					goto end_IL_031e;
				}
				end_IL_031e:;
			}
			finally
			{
				try
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				finally
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					goto IL_0468;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		try
		{
			UIntPtr num3 = (UIntPtr)M(array);
			UIntPtr num4 = (UIntPtr)M(array);
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num3) + (unchecked((nuint)num4) - uIntPtr)) == 0)
			{
				_ = global::h.E.C((IntPtr)M(M(null))) is AssmeblyLoader;
				IAssemblyLoader obj10 = global::h.E.C(num) as IAssemblyLoader;
				assemblyLoader = assemblyLoader;
				assemblyLoader = obj10;
			}
			else
			{
				_ = (j)(object)n.d();
				_ = (E)(object)n.d();
				h = h;
				assemblyLoader = global::h.E.C(num) as IAssemblyLoader;
			}
		}
		finally
		{
			do
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			while ((object)M(array) != null);
			goto IL_0468;
		}
		IL_0468:
		do
		{
			_ = (E)(object)M(array);
		}
		while (obj8 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (uIntPtr == 0)
		{
			do
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = null;
			}
			while (obj8 != null);
		}
		else
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				h = default(H);
			}
		}
		try
		{
			n2 = null;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) / (nuint)(UIntPtr)n.d() == 0)
			{
				try
				{
					_ = (E)(object)n.d();
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)M(array);
				}
			}
		}
		IntPtr intPtr = (IntPtr)n.d();
		IntPtr num5 = (IntPtr)M(array);
		num = default(IntPtr);
		object obj15 = global::h.E.C((nint)checked(unchecked((nuint)(nint)num5) * (unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)M(M(array))))));
		object obj16 = global::h.E.C((nint)checked(unchecked((nuint)(nint)intPtr) - ((obj15 is IntPtr) ? obj15 : null)));
		object obj17 = global::h.E.C((IntPtr)((obj16 is IntPtr) ? obj16 : null));
		if ((int)checked((((obj17 is UIntPtr) ? obj17 : null) - uIntPtr) * uIntPtr - uIntPtr) == 0)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		_ = (CHOOSEFONT)M(n.d());
		try
		{
			try
			{
				assemblyLoader = (IAssemblyLoader)(object)n.d();
			}
			finally
			{
				do
				{
					n2 = n2;
				}
				while (obj8 != null);
				goto end_IL_05da;
			}
			end_IL_05da:;
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					_ = (AssmeblyLoader)(object)n.d();
					goto end_IL_060b;
				}
			}
			try
			{
				j j2 = null;
				j2 = null;
			}
			catch
			{
				x = (X)M(null);
			}
			end_IL_060b:;
		}
		checked
		{
			if (uIntPtr == 0)
			{
				num = default(IntPtr);
				resource = global::h.E.C(num) as Resource1;
			}
			else
			{
				do
				{
					nuint num6 = unchecked((nuint)(UIntPtr)M(null)) + uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num6 * uIntPtr == 0)
					{
						_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					}
					else
					{
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
				}
				while (obj8 != null);
			}
		}
		try
		{
			if (!(global::h.E.C((IntPtr)M(global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num))) as byte[])) is UIntPtr))
			{
				try
				{
					_ = (_003CModule_003E)(object)M(array);
				}
				finally
				{
					_ = (E)(object)n.d();
					goto end_IL_06e1;
				}
			}
			end_IL_06e1:;
		}
		catch
		{
			try
			{
				_ = (Resource1)(object)n.d();
			}
			catch
			{
				nint num7 = num;
				nint num8 = num;
				num = default(IntPtr);
				nint num9 = num;
				num = default(IntPtr);
				object obj20 = global::h.E.C((nint)((nuint)num7 / checked(unchecked((nuint)num8) + unchecked((nuint)num9 / checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)num))))));
				_ = global::h.E.C((IntPtr)((obj20 is IntPtr) ? obj20 : null)) is n;
			}
			finally
			{
				try
				{
					_ = (Resource1)(object)n.d();
				}
				finally
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					goto end_IL_073e;
				}
			}
			end_IL_073e:;
		}
		do
		{
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				catch
				{
					_ = (n)(object)n.d();
					_ = (n)(object)n.d();
				}
			}
			catch
			{
				try
				{
					num = default(IntPtr);
					_ = (CHOOSEFONTFLAGS)M(global::h.E.C(num) as byte[]);
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_07fe;
				}
				end_IL_07fe:;
			}
		}
		while ((object)null != null);
		try
		{
			if (!(global::h.E.C(num) is UIntPtr) && checked(uIntPtr + unchecked((nuint)(UIntPtr)M(n.d()))) == 0)
			{
				_ = global::h.E.C((nint)checked(unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is _003CPrivateImplementationDetails_003E;
			}
		}
		catch
		{
			do
			{
				assmeblyLoader = null;
			}
			while (obj8 != null);
		}
	}

	static void @_002D_0029_003A_007C__0040_0040_003A17()
	{
		//IL_0042: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I, but got Unknown
		//IL_0059: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_009c: Expected I, but got O
		//IL_009d: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected I, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_0407: Expected I, but got O
		//IL_0408: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_04fd: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected I, but got Unknown
		//IL_0536: Expected O, but got I4
		//IL_05a9: Expected O, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected I, but got Unknown
		//IL_05b4: Expected O, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0649: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06f7: Expected O, but got I4
		//IL_074b: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_078f: Expected I, but got O
		//IL_0790: Expected O, but got I4
		//IL_0799: Expected I, but got O
		//IL_079a: Expected O, but got I4
		//IL_07b8: Expected O, but got I4
		//IL_0881: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_092a: Expected O, but got I4
		nint num = default(IntPtr);
		num = (nint)checked(unchecked((nuint)num) * unchecked((nuint)num / (nuint)(nint)(IntPtr)n.d()));
		nint intPtr = num;
		nint intPtr2 = num;
		num = default(IntPtr);
		object obj = global::h.E.C((nint)checked(unchecked((nuint)(nint)num) - /*isinst with value type is only supported in some contexts*/));
		checked
		{
			_ = global::h.E.C(intPtr * unchecked(intPtr2 / ((obj is IntPtr) ? obj : null))) is n;
		}
		CHOOSEFONTFLAGS num2 = (CHOOSEFONTFLAGS)n.d();
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		cHOOSEFONTFLAGS = num2;
		_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
		num = default(IntPtr);
		object obj2 = global::h.E.C(num);
		_ = global::h.E.C((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is IAssemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		UIntPtr intPtr3 = uIntPtr;
		_003F val;
		object obj3;
		checked
		{
			val = unchecked((nuint)uIntPtr) + (unchecked((nuint)default(UIntPtr)) - /*isinst with value type is only supported in some contexts*/);
			obj3 = global::h.E.C(num);
		}
		uIntPtr = (nuint)(nint)checked(unchecked((nuint)intPtr3) + (val - ((obj3 is UIntPtr) ? obj3 : null)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(IntPtr);
				_ = global::h.E.C((nint)checked(unchecked((nuint)num) * unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)n.d()))) is CHOOSEFONTFLAGS;
			}
			while ((object)null != null);
		}
		else
		{
			try
			{
				num = default(IntPtr);
				_ = global::h.E.C((nint)((nuint)num / (nuint)num)) is j;
			}
			catch
			{
				do
				{
					_ = (X)n.d();
					obj4 = obj4;
				}
				while (obj4 != null);
			}
		}
		byte[] array = null;
		IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)M(array);
		assemblyLoader = assemblyLoader;
		Resource1 resource = null;
		resource = resource;
		X x = x;
		x = x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			object obj6 = global::h.E.C(num);
			if ((int)checked(((obj6 is UIntPtr) ? obj6 : null) + (unchecked((nuint)(UIntPtr)n.d()) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				do
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
				}
				while ((object)n.d() != null);
			}
		}
		else if ((UIntPtr)M(array) == (UIntPtr)(nuint)0u)
		{
			_ = (n)(object)n.d();
		}
		num = default(IntPtr);
		_ = global::h.E.C(num) is H;
		UIntPtr num3 = (UIntPtr)M(array);
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)num3 / uIntPtr) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
				do
				{
					e = e;
					e = e;
				}
				while (obj4 != null);
			}
		}
		try
		{
			while ((object)null != null)
			{
				_ = (CHOOSEFONT)n.d();
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
			while (global::h.E.C((IntPtr)n.d()) is object)
			{
				_003CPrivateImplementationDetails_003E obj7 = (_003CPrivateImplementationDetails_003E)(object)n.d();
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = obj7;
			}
		}
		finally
		{
			try
			{
				_ = (E)(object)M(null);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
				do
				{
					H obj9 = (H)n.d();
					h = h;
					h = obj9;
				}
				while ((object)n.d() != null);
			}
			goto IL_0333;
		}
		IL_0333:
		do
		{
			try
			{
				_ = (H)n.d();
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)M(array);
				_003CModule_003E = null;
				n n2 = (n)(object)M(null);
				n2 = n2;
			}
			finally
			{
				assemblyLoader = assemblyLoader;
				continue;
			}
		}
		while (obj4 != null || (object)null != null);
		resource = resource;
		do
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				num = default(IntPtr);
				_ = (CHOOSEFONT)M(global::h.E.C(num) as byte[]);
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)M(null);
			}
		}
		while (obj4 != null);
		object obj11 = global::h.E.C((nint)((nuint)(nint)(IntPtr)n.d() / (nuint)num));
		j obj12 = global::h.E.C((IntPtr)((obj11 is IntPtr) ? obj11 : null)) as j;
		j j2 = null;
		j2 = obj12;
		num = default(IntPtr);
		_ = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)num))) is CHOOSEFONTFLAGS;
		_ = (CHOOSEFONTFLAGS)M(array);
		_ = (H)M(array);
		nuint num4 = uIntPtr / uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num4 * uIntPtr + uIntPtr * uIntPtr * unchecked((nuint)(UIntPtr)M(array)) == 0)
			{
				do
				{
					_ = (n)(object)M(array);
				}
				while ((object)n.d() != null);
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			while ((object)null != null)
			{
				_ = (_003CModule_003E)(object)M(array);
				_ = (n)(object)n.d();
				IntPtr intPtr4 = (IntPtr)M(array);
				num = default(IntPtr);
				object obj13 = global::h.E.C(num);
				_ = global::h.E.C((nint)(checked(unchecked((nuint)(nint)intPtr4 / ((obj13 is IntPtr) ? obj13 : null)) + (unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr))))) / (nuint)unchecked((nint)default(IntPtr)))) is Resource1;
			}
		}
		_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			uIntPtr = default(UIntPtr);
			nuint intPtr5 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint intPtr6 = uIntPtr;
			nuint intPtr7 = uIntPtr;
			num = default(IntPtr);
			nuint num5 = (nuint)num / checked(unchecked((nuint)num) * unchecked((nuint)unchecked((nint)default(IntPtr))));
			num = default(IntPtr);
			object obj14 = global::h.E.C((nint)(num5 / /*isinst with value type is only supported in some contexts*/));
			if ((int)checked(intPtr5 - (intPtr6 + (intPtr7 + ((obj14 is UIntPtr) ? obj14 : null)))) == 0)
			{
				try
				{
					AssmeblyLoader obj15 = (AssmeblyLoader)(object)n.d();
					assmeblyLoader = global::h.E.C(num) as AssmeblyLoader;
					assmeblyLoader = obj15;
				}
				finally
				{
					cHOOSEFONT = (CHOOSEFONT)M(array);
					goto end_IL_0552;
				}
			}
			try
			{
				_ = global::h.E.C(default(IntPtr)) is IAssemblyLoader;
			}
			catch
			{
				_ = (H)n.d();
			}
			end_IL_0552:;
		}
		catch
		{
			try
			{
				_ = global::h.E.C((IntPtr)n.d()) is n;
			}
			catch
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			finally
			{
				try
				{
					_ = (IAssemblyLoader)(object)M(array);
				}
				catch
				{
					assemblyLoader = assemblyLoader;
				}
				goto end_IL_0636;
			}
			end_IL_0636:;
		}
		do
		{
			_ = (_003CPrivateImplementationDetails_003E)(object)M(null);
		}
		while (global::h.E.C(default(IntPtr)) is object);
		do
		{
			try
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				finally
				{
					_ = (n)(object)n.d();
					goto end_IL_06bb;
				}
				end_IL_06bb:;
			}
			catch
			{
				try
				{
					assemblyLoader = global::h.E.C(default(IntPtr)) as IAssemblyLoader;
				}
				catch
				{
					_ = (H)M(array);
					_ = (CHOOSEFONT)n.d();
					_ = (E)(object)n.d();
				}
			}
		}
		while ((object)null != null);
		if (!(global::h.E.C(default(IntPtr)) is UIntPtr))
		{
			do
			{
				try
				{
					assmeblyLoader = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					assemblyLoader = assemblyLoader;
					num = default(IntPtr);
					object obj22 = global::h.E.C(num);
					object obj23 = global::h.E.C((IntPtr)((obj22 is IntPtr) ? obj22 : null));
					_ = global::h.E.C((IntPtr)((obj23 is IntPtr) ? obj23 : null)) is Resource1;
					_ = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)unchecked((nint)default(IntPtr))))) is Resource1;
					continue;
				}
			}
			while (obj4 != null);
		}
		try
		{
			do
			{
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)M(array);
			}
			while ((object)null != null);
		}
		catch
		{
			try
			{
				try
				{
					assemblyLoader = assemblyLoader;
					x = (X)n.d();
					_ = (Resource1)(object)n.d();
				}
				finally
				{
					x = default(X);
					goto end_IL_07ec;
				}
				end_IL_07ec:;
			}
			catch
			{
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					_ = (n)(object)M(array);
				}
			}
		}
		try
		{
			while (obj4 != null)
			{
				try
				{
					_ = (H)M(null);
					num = default(IntPtr);
					object obj26 = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)num)));
					x = (X)((obj26 is X) ? obj26 : null);
					j2 = j2;
					resource = null;
				}
				catch
				{
					E e = null;
				}
			}
		}
		catch
		{
			while (obj4 != null)
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)n.d();
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				catch
				{
					assemblyLoader = global::h.E.C((IntPtr)M(array)) as IAssemblyLoader;
				}
			}
		}
		_ = global::h.E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)(nint)(IntPtr)n.d()))) is j;
		try
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					cHOOSEFONT = cHOOSEFONT;
				}
			}
		}
		catch
		{
			_ = (n)(object)M(array);
		}
	}

	public static byte[] M(byte[] P_0)
	{
		Stream stream = new MemoryStream();
		Array array = default(Array);
		try
		{
			switch (4)
			{
			default:
			{
				object obj = new AesManaged();
				try
				{
					int num = 1;
					while (true)
					{
						switch (num)
						{
						default:
							s = new byte[32];
							(obj as AesManaged).KeySize = 256;
							(obj as AesManaged).BlockSize = 128;
							goto case 5;
						case 5:
							num = 2;
							continue;
						case 2:
						case 3:
							(obj as AesManaged).Mode = CipherMode.CBC;
							goto case 4;
						case 4:
							(obj as AesManaged).Padding = PaddingMode.PKCS7;
							((AesManaged)obj).Key = s;
							num = 6;
							continue;
						case 6:
						{
							(obj as AesManaged).IV = new byte[16];
							object obj2 = new CryptoStream(stream as MemoryStream, ((AesManaged)obj).CreateDecryptor(), CryptoStreamMode.Write);
							try
							{
								int num2 = 4;
								while (true)
								{
									switch (num2)
									{
									case 5:
										array = ((MemoryStream)stream).ToArray();
										goto end_IL_00de;
									case 3:
										goto end_IL_00de;
									}
									((CryptoStream)obj2).Write(P_0, 0, P_0.Length);
									((CryptoStream)obj2).FlushFinalBlock();
									num2 = 5;
									continue;
									end_IL_00de:
									break;
								}
							}
							finally
							{
								int num3 = 2;
								while (true)
								{
									int num4;
									switch (num3)
									{
									default:
										num4 = (((CryptoStream)obj2 == null) ? 5 : 3);
										goto IL_015d;
									case 3:
										((IDisposable)(obj2 as CryptoStream)).Dispose();
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
					int num5 = 1;
					while (true)
					{
						int num6;
						switch (num5)
						{
						default:
							num6 = (((AesManaged)obj == null) ? 5 : 3);
							goto IL_019f;
						case 3:
							((IDisposable)(AesManaged)obj).Dispose();
							break;
						case 5:
						case 6:
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
			int num7 = 5;
			while (true)
			{
				int num8;
				switch (num7)
				{
				default:
					num8 = (((MemoryStream)stream == null) ? 3 : 2);
					goto IL_01e1;
				case 2:
					((IDisposable)(MemoryStream)stream).Dispose();
					break;
				case 3:
					break;
				}
				break;
				IL_01e1:
				num7 = num8;
			}
		}
		switch (2)
		{
		default:
		{
			byte[] result = array as byte[];
			h.E.W.k[308] = (char)((h.E.W.k[308] + h.E.W.k[97]) & '/');
			return result;
		}
		}
	}

	static void @_002D_0029_003A_007C__0040_0040_003A17()
	{
		//IL_0042: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I, but got Unknown
		//IL_0059: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_009c: Expected I, but got O
		//IL_009d: Expected O, but got I4
		//IL_00c2: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected I, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got I4
		//IL_02e0: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_0407: Expected I, but got O
		//IL_0408: Expected O, but got I4
		//IL_042e: Expected O, but got I4
		//IL_04fd: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected I, but got Unknown
		//IL_0536: Expected O, but got I4
		//IL_05a9: Expected O, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected I, but got Unknown
		//IL_05b4: Expected O, but got I4
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got I4
		//IL_0617: Expected O, but got I4
		//IL_0649: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06f7: Expected O, but got I4
		//IL_074b: Expected O, but got I4
		//IL_0786: Expected O, but got I4
		//IL_078f: Expected I, but got O
		//IL_0790: Expected O, but got I4
		//IL_0799: Expected I, but got O
		//IL_079a: Expected O, but got I4
		//IL_07b8: Expected O, but got I4
		//IL_0881: Expected O, but got I4
		//IL_08f3: Expected O, but got I4
		//IL_092a: Expected O, but got I4
		nint num = default(IntPtr);
		num = (nint)checked(unchecked((nuint)num) * unchecked((nuint)num / (nuint)(nint)(IntPtr)n.d()));
		nint intPtr = num;
		nint intPtr2 = num;
		num = default(IntPtr);
		object obj = global::h.E.C((nint)checked(unchecked((nuint)(nint)num) - /*isinst with value type is only supported in some contexts*/));
		checked
		{
			_ = global::h.E.C(intPtr * unchecked(intPtr2 / ((obj is IntPtr) ? obj : null))) is n;
		}
		CHOOSEFONTFLAGS num2 = (CHOOSEFONTFLAGS)n.d();
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		cHOOSEFONTFLAGS = num2;
		_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
		num = default(IntPtr);
		object obj2 = global::h.E.C(num);
		_ = global::h.E.C((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is IAssemblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		UIntPtr intPtr3 = uIntPtr;
		_003F val;
		object obj3;
		checked
		{
			val = unchecked((nuint)uIntPtr) + (unchecked((nuint)default(UIntPtr)) - /*isinst with value type is only supported in some contexts*/);
			obj3 = global::h.E.C(num);
		}
		uIntPtr = (nuint)(nint)checked(unchecked((nuint)intPtr3) + (val - ((obj3 is UIntPtr) ? obj3 : null)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(IntPtr);
				_ = global::h.E.C((nint)checked(unchecked((nuint)num) * unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)n.d()))) is CHOOSEFONTFLAGS;
			}
			while ((object)null != null);
		}
		else
		{
			try
			{
				num = default(IntPtr);
				_ = global::h.E.C((nint)((nuint)num / (nuint)num)) is j;
			}
			catch
			{
				do
				{
					_ = (X)n.d();
					obj4 = obj4;
				}
				while (obj4 != null);
			}
		}
		byte[] array = null;
		IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)M(array);
		assemblyLoader = assemblyLoader;
		Resource1 resource = null;
		resource = resource;
		X x = x;
		x = x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			object obj6 = global::h.E.C(num);
			if ((int)checked(((obj6 is UIntPtr) ? obj6 : null) + (unchecked((nuint)(UIntPtr)n.d()) + unchecked((nuint)default(UIntPtr)))) == 0)
			{
				do
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
				}
				while ((object)n.d() != null);
			}
		}
		else if ((UIntPtr)M(array) == (UIntPtr)(nuint)0u)
		{
			_ = (n)(object)n.d();
		}
		num = default(IntPtr);
		_ = global::h.E.C(num) is H;
		UIntPtr num3 = (UIntPtr)M(array);
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)num3 / uIntPtr) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
				do
				{
					e = e;
					e = e;
				}
				while (obj4 != null);
			}
		}
		try
		{
			while ((object)null != null)
			{
				_ = (CHOOSEFONT)n.d();
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
			while (global::h.E.C((IntPtr)n.d()) is object)
			{
				_003CPrivateImplementationDetails_003E obj7 = (_003CPrivateImplementationDetails_003E)(object)n.d();
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = obj7;
			}
		}
		finally
		{
			try
			{
				_ = (E)(object)M(null);
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
				do
				{
					H obj9 = (H)n.d();
					h = h;
					h = obj9;
				}
				while ((object)n.d() != null);
			}
			goto IL_0333;
		}
		IL_0333:
		do
		{
			try
			{
				_ = (H)n.d();
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)M(array);
				_003CModule_003E = null;
				n n2 = (n)(object)M(null);
				n2 = n2;
			}
			finally
			{
				assemblyLoader = assemblyLoader;
				continue;
			}
		}
		while (obj4 != null || (object)null != null);
		resource = resource;
		do
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				num = default(IntPtr);
				_ = (CHOOSEFONT)M(global::h.E.C(num) as byte[]);
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)M(null);
			}
		}
		while (obj4 != null);
		object obj11 = global::h.E.C((nint)((nuint)(nint)(IntPtr)n.d() / (nuint)num));
		j obj12 = global::h.E.C((IntPtr)((obj11 is IntPtr) ? obj11 : null)) as j;
		j j2 = null;
		j2 = obj12;
		num = default(IntPtr);
		_ = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)num))) is CHOOSEFONTFLAGS;
		_ = (CHOOSEFONTFLAGS)M(array);
		_ = (H)M(array);
		nuint num4 = uIntPtr / uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (num4 * uIntPtr + uIntPtr * uIntPtr * unchecked((nuint)(UIntPtr)M(array)) == 0)
			{
				do
				{
					_ = (n)(object)M(array);
				}
				while ((object)n.d() != null);
			}
			uIntPtr = default(UIntPtr);
		}
		if (uIntPtr == 0)
		{
			while ((object)null != null)
			{
				_ = (_003CModule_003E)(object)M(array);
				_ = (n)(object)n.d();
				IntPtr intPtr4 = (IntPtr)M(array);
				num = default(IntPtr);
				object obj13 = global::h.E.C(num);
				_ = global::h.E.C((nint)(checked(unchecked((nuint)(nint)intPtr4 / ((obj13 is IntPtr) ? obj13 : null)) + (unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr))))) / (nuint)unchecked((nint)default(IntPtr)))) is Resource1;
			}
		}
		_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			uIntPtr = default(UIntPtr);
			nuint intPtr5 = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint intPtr6 = uIntPtr;
			nuint intPtr7 = uIntPtr;
			num = default(IntPtr);
			nuint num5 = (nuint)num / checked(unchecked((nuint)num) * unchecked((nuint)unchecked((nint)default(IntPtr))));
			num = default(IntPtr);
			object obj14 = global::h.E.C((nint)(num5 / /*isinst with value type is only supported in some contexts*/));
			if ((int)checked(intPtr5 - (intPtr6 + (intPtr7 + ((obj14 is UIntPtr) ? obj14 : null)))) == 0)
			{
				try
				{
					AssmeblyLoader obj15 = (AssmeblyLoader)(object)n.d();
					assmeblyLoader = global::h.E.C(num) as AssmeblyLoader;
					assmeblyLoader = obj15;
				}
				finally
				{
					cHOOSEFONT = (CHOOSEFONT)M(array);
					goto end_IL_0552;
				}
			}
			try
			{
				_ = global::h.E.C(default(IntPtr)) is IAssemblyLoader;
			}
			catch
			{
				_ = (H)n.d();
			}
			end_IL_0552:;
		}
		catch
		{
			try
			{
				_ = global::h.E.C((IntPtr)n.d()) is n;
			}
			catch
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			finally
			{
				try
				{
					_ = (IAssemblyLoader)(object)M(array);
				}
				catch
				{
					assemblyLoader = assemblyLoader;
				}
				goto end_IL_0636;
			}
			end_IL_0636:;
		}
		do
		{
			_ = (_003CPrivateImplementationDetails_003E)(object)M(null);
		}
		while (global::h.E.C(default(IntPtr)) is object);
		do
		{
			try
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				finally
				{
					_ = (n)(object)n.d();
					goto end_IL_06bb;
				}
				end_IL_06bb:;
			}
			catch
			{
				try
				{
					assemblyLoader = global::h.E.C(default(IntPtr)) as IAssemblyLoader;
				}
				catch
				{
					_ = (H)M(array);
					_ = (CHOOSEFONT)n.d();
					_ = (E)(object)n.d();
				}
			}
		}
		while ((object)null != null);
		if (!(global::h.E.C(default(IntPtr)) is UIntPtr))
		{
			do
			{
				try
				{
					assmeblyLoader = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					assemblyLoader = assemblyLoader;
					num = default(IntPtr);
					object obj22 = global::h.E.C(num);
					object obj23 = global::h.E.C((IntPtr)((obj22 is IntPtr) ? obj22 : null));
					_ = global::h.E.C((IntPtr)((obj23 is IntPtr) ? obj23 : null)) is Resource1;
					_ = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)unchecked((nint)default(IntPtr))))) is Resource1;
					continue;
				}
			}
			while (obj4 != null);
		}
		try
		{
			do
			{
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)M(array);
			}
			while ((object)null != null);
		}
		catch
		{
			try
			{
				try
				{
					assemblyLoader = assemblyLoader;
					x = (X)n.d();
					_ = (Resource1)(object)n.d();
				}
				finally
				{
					x = default(X);
					goto end_IL_07ec;
				}
				end_IL_07ec:;
			}
			catch
			{
				if (checked(uIntPtr * uIntPtr) == 0)
				{
					_ = (n)(object)M(array);
				}
			}
		}
		try
		{
			while (obj4 != null)
			{
				try
				{
					_ = (H)M(null);
					num = default(IntPtr);
					object obj26 = global::h.E.C((nint)checked(unchecked((nuint)num) + unchecked((nuint)num)));
					x = (X)((obj26 is X) ? obj26 : null);
					j2 = j2;
					resource = null;
				}
				catch
				{
					E e = null;
				}
			}
		}
		catch
		{
			while (obj4 != null)
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)n.d();
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				catch
				{
					assemblyLoader = global::h.E.C((IntPtr)M(array)) as IAssemblyLoader;
				}
			}
		}
		_ = global::h.E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - unchecked((nuint)(nint)(IntPtr)n.d()))) is j;
		try
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					cHOOSEFONT = cHOOSEFONT;
				}
			}
		}
		catch
		{
			_ = (n)(object)M(array);
		}
	}

	static void @_003B_0025_002F_007C__002F_002E_002A18()
	{
		//IL_0040: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_00d8: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01bd: Expected I, but got O
		//IL_01be: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_01f7: Expected O, but got I4
		//IL_0227: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected I, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_0347: Expected O, but got I4
		//IL_0363: Expected O, but got I4
		//IL_03e8: Expected O, but got I4
		//IL_03f7: Expected O, but got I4
		//IL_0435: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected I, but got Unknown
		//IL_059a: Expected O, but got I4
		//IL_05a3: Expected I, but got O
		//IL_05a4: Expected O, but got I4
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got I4
		//IL_06f7: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_078f: Expected O, but got I4
		//IL_0798: Expected I, but got O
		//IL_0799: Expected O, but got I4
		//IL_0814: Expected O, but got I4
		//IL_0849: Expected O, but got I4
		//IL_0889: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		try
		{
			uIntPtr = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				x = x;
				x = default(X);
				object obj = global::h.E.C(num);
				num = (nint)checked(((obj is IntPtr) ? obj : null) + (unchecked((nuint)num) - unchecked((nuint)num)));
				_ = global::h.E.C(num) is CHOOSEFONTFLAGS;
			}
			else
			{
				try
				{
					array = null;
					_ = (IAssemblyLoader)(object)M(array);
				}
				catch
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					resource = resource;
					resource = resource;
					h = h;
					h = h;
					_ = (CHOOSEFONTFLAGS)n.d();
				}
			}
		}
		catch
		{
			try
			{
				_ = global::h.E.C((IntPtr)n.d()) is n;
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					E e = e;
					e = e;
				}
				else
				{
					_ = (n)(object)M(n.d());
				}
				goto end_IL_00c6;
			}
			end_IL_00c6:;
		}
		while ((object)M(null) != null)
		{
			resource = global::h.E.C(num) as Resource1;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					nint num2 = num;
					num = default(IntPtr);
					object obj4 = global::h.E.C((IntPtr)M(global::h.E.C((nint)(checked(unchecked((nuint)num2) + unchecked((nuint)num)) / (nuint)(nint)(IntPtr)M(array))) as byte[]));
					_ = global::h.E.C((IntPtr)((obj4 is IntPtr) ? obj4 : null)) is CHOOSEFONTFLAGS;
				}
			}
			else
			{
				num = default(IntPtr);
				if (!(global::h.E.C(num) is UIntPtr))
				{
					_003CModule_003E obj5 = global::h.E.C((IntPtr)n.d()) as _003CModule_003E;
					_003CModule_003E = (_003CModule_003E)(object)n.d();
					_003CModule_003E = obj5;
				}
				else
				{
					object obj6 = global::h.E.C((IntPtr)M(array));
					_003F val = ((obj6 is IntPtr) ? obj6 : null) / num;
					object obj7 = global::h.E.C(num);
					_ = (X)M(M(global::h.E.C((IntPtr)checked(val - ((obj7 is IntPtr) ? obj7 : null))) as byte[]));
				}
			}
		}
		finally
		{
			_ = (n)(object)n.d();
			goto IL_02a3;
		}
		IL_02a3:
		while ((object)null != null)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (Resource1)(object)n.d();
			}
		}
		x = default(X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n2);
		while (obj8 != null)
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					resource = resource;
				}
			}
			catch
			{
				do
				{
					n2 = n2;
					n2 = n2;
					obj8 = obj8;
				}
				while (obj8 != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (Resource1)(object)M(null);
				}
				finally
				{
					_ = (n)(object)n.d();
					_ = global::h.E.C(num) is X;
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = null;
					_ = global::h.E.C(num) is _003CModule_003E;
					goto end_IL_031e;
				}
				end_IL_031e:;
			}
			finally
			{
				try
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				finally
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					goto IL_0468;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		try
		{
			UIntPtr num3 = (UIntPtr)M(array);
			UIntPtr num4 = (UIntPtr)M(array);
			uIntPtr = default(UIntPtr);
			if (checked(unchecked((nuint)num3) + (unchecked((nuint)num4) - uIntPtr)) == 0)
			{
				_ = global::h.E.C((IntPtr)M(M(null))) is AssmeblyLoader;
				IAssemblyLoader obj10 = global::h.E.C(num) as IAssemblyLoader;
				assemblyLoader = assemblyLoader;
				assemblyLoader = obj10;
			}
			else
			{
				_ = (j)(object)n.d();
				_ = (E)(object)n.d();
				h = h;
				assemblyLoader = global::h.E.C(num) as IAssemblyLoader;
			}
		}
		finally
		{
			do
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			while ((object)M(array) != null);
			goto IL_0468;
		}
		IL_0468:
		do
		{
			_ = (E)(object)M(array);
		}
		while (obj8 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		if (uIntPtr == 0)
		{
			do
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = null;
			}
			while (obj8 != null);
		}
		else
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				catch
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				h = default(H);
			}
		}
		try
		{
			n2 = null;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (checked(uIntPtr - uIntPtr) / (nuint)(UIntPtr)n.d() == 0)
			{
				try
				{
					_ = (E)(object)n.d();
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)M(array);
				}
			}
		}
		IntPtr intPtr = (IntPtr)n.d();
		IntPtr num5 = (IntPtr)M(array);
		num = default(IntPtr);
		object obj15 = global::h.E.C((nint)checked(unchecked((nuint)(nint)num5) * (unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)M(M(array))))));
		object obj16 = global::h.E.C((nint)checked(unchecked((nuint)(nint)intPtr) - ((obj15 is IntPtr) ? obj15 : null)));
		object obj17 = global::h.E.C((IntPtr)((obj16 is IntPtr) ? obj16 : null));
		if ((int)checked((((obj17 is UIntPtr) ? obj17 : null) - uIntPtr) * uIntPtr - uIntPtr) == 0)
		{
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		_ = (CHOOSEFONT)M(n.d());
		try
		{
			try
			{
				assemblyLoader = (IAssemblyLoader)(object)n.d();
			}
			finally
			{
				do
				{
					n2 = n2;
				}
				while (obj8 != null);
				goto end_IL_05da;
			}
			end_IL_05da:;
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					assemblyLoader = assemblyLoader;
				}
				finally
				{
					_ = (AssmeblyLoader)(object)n.d();
					goto end_IL_060b;
				}
			}
			try
			{
				j j2 = null;
				j2 = null;
			}
			catch
			{
				x = (X)M(null);
			}
			end_IL_060b:;
		}
		checked
		{
			if (uIntPtr == 0)
			{
				num = default(IntPtr);
				resource = global::h.E.C(num) as Resource1;
			}
			else
			{
				do
				{
					nuint num6 = unchecked((nuint)(UIntPtr)M(null)) + uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num6 * uIntPtr == 0)
					{
						_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					}
					else
					{
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
				}
				while (obj8 != null);
			}
		}
		try
		{
			if (!(global::h.E.C((IntPtr)M(global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num))) as byte[])) is UIntPtr))
			{
				try
				{
					_ = (_003CModule_003E)(object)M(array);
				}
				finally
				{
					_ = (E)(object)n.d();
					goto end_IL_06e1;
				}
			}
			end_IL_06e1:;
		}
		catch
		{
			try
			{
				_ = (Resource1)(object)n.d();
			}
			catch
			{
				nint num7 = num;
				nint num8 = num;
				num = default(IntPtr);
				nint num9 = num;
				num = default(IntPtr);
				object obj20 = global::h.E.C((nint)((nuint)num7 / checked(unchecked((nuint)num8) + unchecked((nuint)num9 / checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)num))))));
				_ = global::h.E.C((IntPtr)((obj20 is IntPtr) ? obj20 : null)) is n;
			}
			finally
			{
				try
				{
					_ = (Resource1)(object)n.d();
				}
				finally
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					goto end_IL_073e;
				}
			}
			end_IL_073e:;
		}
		do
		{
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				catch
				{
					_ = (n)(object)n.d();
					_ = (n)(object)n.d();
				}
			}
			catch
			{
				try
				{
					num = default(IntPtr);
					_ = (CHOOSEFONTFLAGS)M(global::h.E.C(num) as byte[]);
				}
				finally
				{
					assmeblyLoader = assmeblyLoader;
					goto end_IL_07fe;
				}
				end_IL_07fe:;
			}
		}
		while ((object)null != null);
		try
		{
			if (!(global::h.E.C(num) is UIntPtr) && checked(uIntPtr + unchecked((nuint)(UIntPtr)M(n.d()))) == 0)
			{
				_ = global::h.E.C((nint)checked(unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is _003CPrivateImplementationDetails_003E;
			}
		}
		catch
		{
			do
			{
				assmeblyLoader = null;
			}
			while (obj8 != null);
		}
	}

	static void @_002B_003E_002A_007C__002F_0040_002619()
	{
		//IL_0043: Expected O, but got I4
		//IL_005d: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_0183: Expected I, but got O
		//IL_0184: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected I, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_01ce: Expected I, but got O
		//IL_01cf: Expected O, but got I4
		//IL_020c: Expected O, but got I4
		//IL_0275: Expected O, but got I4
		//IL_02a0: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		//IL_0425: Expected O, but got I4
		//IL_0475: Expected O, but got I4
		//IL_048a: Expected O, but got I4
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected I, but got Unknown
		//IL_04ab: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected I, but got Unknown
		//IL_0548: Expected O, but got I4
		//IL_0568: Expected O, but got I4
		//IL_057d: Expected O, but got I4
		//IL_06f8: Expected O, but got I4
		//IL_0764: Expected O, but got I4
		//IL_07a1: Expected O, but got I4
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		AssmeblyLoader assmeblyLoader = null;
		assmeblyLoader = assmeblyLoader;
		nint intPtr = default(IntPtr);
		intPtr = default(IntPtr);
		IAssemblyLoader obj = global::h.E.C(intPtr) as IAssemblyLoader;
		IAssemblyLoader assemblyLoader = assemblyLoader;
		assemblyLoader = obj;
		assmeblyLoader = global::h.E.C(intPtr) as AssmeblyLoader;
		byte[] array = array;
		_ = (CHOOSEFONTFLAGS)M(array);
		_ = (E)(object)n.d();
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		if (!(global::h.E.C(intPtr) is UIntPtr))
		{
			do
			{
				UIntPtr num = (UIntPtr)M(array);
				uIntPtr = default(UIntPtr);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num) * uIntPtr == 0)
					{
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
					else
					{
						h = h;
						h = default(H);
					}
					obj2 = M(n.d());
				}
			}
			while (obj2 != null);
		}
		else
		{
			try
			{
				do
				{
					_ = (n)(object)n.d();
					_ = global::h.E.C((IntPtr)n.d()) is Resource1;
					intPtr = default(IntPtr);
					object obj3 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) + (unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)M(array)))));
					_ = global::h.E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null)) is n;
					_ = (n)(object)n.d();
				}
				while ((object)null != null);
			}
			catch
			{
				IntPtr intPtr2 = (IntPtr)n.d();
				object obj4 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)intPtr)));
				object obj5 = global::h.E.C((nint)((nuint)(nint)intPtr2 / ((obj4 is IntPtr) ? obj4 : null)));
				if (!(global::h.E.C((IntPtr)((obj5 is IntPtr) ? obj5 : null)) is UIntPtr))
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					_ = (n)(object)n.d();
				}
			}
		}
		_ = (CHOOSEFONTFLAGS)n.d();
		_ = global::h.E.C(intPtr) is H;
		if (uIntPtr == 0)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
			while ((object)null != null)
			{
				try
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = default(CHOOSEFONT);
				}
				finally
				{
					_ = (E)(object)M(n.d());
					_ = global::h.E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is H;
					cHOOSEFONT = default(CHOOSEFONT);
					intPtr = default(IntPtr);
					assemblyLoader = global::h.E.C(intPtr) as IAssemblyLoader;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		try
		{
			try
			{
				try
				{
					_ = (X)n.d();
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				}
				finally
				{
					e = e;
					e = e;
					goto end_IL_02b4;
				}
				end_IL_02b4:;
			}
			finally
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)M(array);
					_ = (_003CModule_003E)(object)n.d();
					intPtr = default(IntPtr);
					nuint num2 = (nuint)intPtr / (nuint)intPtr;
					IntPtr num3 = (IntPtr)M(array);
					intPtr = default(IntPtr);
					nuint num4;
					checked
					{
						num4 = unchecked((nuint)(nint)num3) * unchecked((nuint)intPtr);
						intPtr = default(IntPtr);
					}
					_ = global::h.E.C((nint)checked(num2 - (num4 - (unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))))) is AssmeblyLoader;
					n n2 = (n)(object)n.d();
					n2 = n2;
				}
				finally
				{
					x = x;
					x = x;
					goto end_IL_02b3;
				}
			}
			end_IL_02b3:;
		}
		finally
		{
			_ = global::h.E.C((IntPtr)M(M(array))) is AssmeblyLoader;
			goto IL_03b9;
		}
		IL_03b9:
		x = x;
		_ = (j)(object)n.d();
		while ((object)M(array) != null)
		{
			try
			{
				UIntPtr num5 = (UIntPtr)M(null);
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num5) - uIntPtr == 0)
					{
						_ = (CHOOSEFONT)M(array);
					}
				}
			}
			catch
			{
				cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				_ = global::h.E.C(intPtr) is IAssemblyLoader;
				x = x;
				intPtr = default(IntPtr);
				nuint num6;
				nuint num7;
				checked
				{
					num6 = unchecked((nuint)intPtr) * unchecked((nuint)intPtr);
					intPtr = default(IntPtr);
					num7 = unchecked((nuint)intPtr) + unchecked((nuint)intPtr);
				}
				object obj7 = global::h.E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)M(array)) + unchecked((nuint)(nint)(IntPtr)M(global::h.E.C(intPtr) as byte[]))));
				assmeblyLoader = global::h.E.C((nint)checked(num6 + num7 * (((obj7 is IntPtr) ? obj7 : null) + unchecked((nuint)(nint)(IntPtr)M(n.d()))))) as AssmeblyLoader;
			}
		}
		do
		{
			if ((UIntPtr)M(array) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (H)M(array);
					_003CPrivateImplementationDetails_003E obj9 = (_003CPrivateImplementationDetails_003E)(object)M(n.d());
					object obj10 = global::h.E.C(intPtr);
					_003F val = ((obj10 is IntPtr) ? obj10 : null) / (nuint)(nint)(IntPtr)M(array);
					intPtr = default(IntPtr);
					_003F val2 = checked((val - intPtr) * intPtr);
					intPtr = default(IntPtr);
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = global::h.E.C((IntPtr)checked(val2 - intPtr)) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = obj9;
					intPtr = default(IntPtr);
					_ = global::h.E.C(intPtr) is CHOOSEFONT;
				}
				catch
				{
					_ = global::h.E.C(intPtr) is CHOOSEFONTFLAGS;
				}
			}
			else
			{
				do
				{
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = (H)n.d();
					x = x;
				}
				while (obj2 != null);
			}
		}
		while (obj2 != null);
		do
		{
			try
			{
				h = (H)M(array);
			}
			finally
			{
				n n2 = null;
				continue;
			}
		}
		while ((object)n.d() != null || (object)null != null);
		e = e;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			UIntPtr num8 = uIntPtr;
			UIntPtr num9 = (UIntPtr)n.d();
			UIntPtr num10 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if ((nuint)num8 / checked(unchecked((nuint)num9) - (unchecked((nuint)num10) + uIntPtr)) == 0)
			{
				_003CModule_003E obj12 = (_003CModule_003E)(object)M(array);
				_003CModule_003E = null;
				_003CModule_003E = obj12;
				_ = (CHOOSEFONT)n.d();
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while ((object)n.d() != null)
				{
					_ = (Resource1)(object)M(array);
					h = default(H);
					_ = (IAssemblyLoader)(object)M(null);
				}
			}
		}
		while (obj2 != null)
		{
			try
			{
				if (uIntPtr == 0)
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				if (!(global::h.E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))) is UIntPtr))
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				else
				{
					_ = (_003CModule_003E)(object)n.d();
				}
			}
		}
		do
		{
			try
			{
				while (obj2 != null)
				{
					assemblyLoader = assemblyLoader;
				}
			}
			catch
			{
				nint num11 = intPtr;
				intPtr = default(IntPtr);
				_ = global::h.E.C((nint)checked(unchecked((nuint)num11) - unchecked((nuint)intPtr))) is CHOOSEFONTFLAGS;
			}
		}
		while (obj2 != null);
		assemblyLoader = assemblyLoader;
		try
		{
			_003CModule_003E = _003CModule_003E;
		}
		catch
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = global::h.E.C(intPtr) is X;
					h = h;
					_ = (n)(object)n.d();
					_ = (n)(object)n.d();
				}
			}
			catch
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				catch
				{
					n n2 = (n)(object)n.d();
				}
			}
		}
	}
}
