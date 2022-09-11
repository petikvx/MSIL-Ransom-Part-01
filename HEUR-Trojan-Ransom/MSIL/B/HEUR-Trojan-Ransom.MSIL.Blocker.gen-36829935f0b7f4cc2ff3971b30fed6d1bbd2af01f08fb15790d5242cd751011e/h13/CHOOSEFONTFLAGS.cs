using System;
using System.Runtime.CompilerServices;
using h;

namespace h13;

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
	static void @_0021_0029_002E_007C_003F_002F_0040_003E14()
	{
		//IL_001a: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_0047: Expected I, but got O
		//IL_0048: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected I, but got O
		//IL_01d6: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got I4
		//IL_0410: Expected I4, but got O
		//IL_045c: Expected O, but got I4
		//IL_04c2: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected I, but got Unknown
		//IL_04f9: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		//IL_05d7: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		if (!(E.C((IntPtr)j.M(n.d())) is UIntPtr))
		{
			do
			{
				object obj = E.C((IntPtr)j.M(n.d()));
				array = j.M(E.C((IntPtr)((obj is IntPtr) ? obj : null)) as byte[]);
				num = (IntPtr)j.M(array);
				if (!(E.C(num) is UIntPtr))
				{
					CHOOSEFONTFLAGS num2 = (CHOOSEFONTFLAGS)n.d();
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					cHOOSEFONTFLAGS = num2;
				}
				else
				{
					_ = E.C(num) is Resource1;
				}
				obj2 = j.M(array);
			}
			while (obj2 != null);
		}
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				while (true)
				{
					if ((object)null != null)
					{
						_003CModule_003E = (_003CModule_003E)(object)j.M(array);
						_003CModule_003E = _003CModule_003E;
					}
					else if ((object)null == null)
					{
						break;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		try
		{
			while ((object)null != null)
			{
				if (uIntPtr == 0)
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
				}
				else
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = E.C(num) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (j)(object)j.M(array);
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / checked(unchecked((nuint)(UIntPtr)n.d()) - uIntPtr) == 0)
				{
					object obj3 = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num)));
					_ = E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null)) is AssmeblyLoader;
					num = default(IntPtr);
					j = E.C(num) as j;
					j = j;
				}
			}
			goto IL_0203;
		}
		IL_0203:
		try
		{
			if (!(E.C((IntPtr)n.d()) is UIntPtr))
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					Resource1 resource = (Resource1)(object)n.d();
					resource = resource;
				}
				finally
				{
					num = default(IntPtr);
					_ = E.C(num) is E;
					goto end_IL_022c;
				}
			}
			while ((object)j.M(array) != null)
			{
				_003CModule_003E = _003CModule_003E;
				_ = (H)j.M(array);
			}
			end_IL_022c:;
		}
		do
		{
			try
			{
				while ((object)null != null)
				{
					X x = (X)n.d();
					x = x;
				}
			}
			catch
			{
				cHOOSEFONT = cHOOSEFONT;
			}
		}
		while (obj2 != null);
		do
		{
			_ = (IAssemblyLoader)(object)n.d();
		}
		while (obj2 != null);
		cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		while ((object)j.M(null) != null)
		{
			do
			{
				_ = (X)j.M(j.M(array));
			}
			while ((object)j.M(j.M(n.d())) != null);
		}
		AssmeblyLoader assmeblyLoader = null;
		assmeblyLoader = assmeblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				UIntPtr intPtr = uIntPtr;
				UIntPtr intPtr2 = uIntPtr;
				object obj6 = E.C(num);
				_003F val;
				checked
				{
					val = unchecked((nuint)intPtr2) - ((obj6 is UIntPtr) ? obj6 : null);
					uIntPtr = default(UIntPtr);
				}
				if ((int)checked(unchecked((nuint)intPtr) + unchecked(val / (nuint)uIntPtr)) == 0)
				{
					h = h;
					h = h;
				}
				continue;
			}
			try
			{
				h = (H)j.M(j.M(array));
			}
			finally
			{
				object obj7 = E.C((IntPtr)n.d());
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj7 is CHOOSEFONTFLAGS) ? obj7 : null);
				continue;
			}
		}
		while (obj2 != null);
		j = j;
		_ = (H)j.M(array);
		_ = (_003CModule_003E)(object)n.d();
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		num = default(IntPtr);
		_ = E.C(num) is _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				e = e;
				e = null;
				nuint num3;
				IntPtr intPtr3;
				IntPtr intPtr4;
				object obj8;
				checked
				{
					num3 = unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr)));
					num = default(IntPtr);
					intPtr3 = num;
					intPtr4 = num;
					obj8 = E.C(num);
				}
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(E.C((nint)checked(unchecked(num3 / checked(unchecked((nuint)(nint)intPtr3 / checked(unchecked((nuint)(nint)intPtr4) * ((obj8 is IntPtr) ? obj8 : null) + unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)j.M(array)))) + unchecked((nuint)(nint)num))) - unchecked((nuint)(nint)(IntPtr)n.d()))) as byte[]);
			}
		}
		while (obj2 != null)
		{
			Resource1 resource = (Resource1)(object)j.M(null);
		}
		_ = (AssmeblyLoader)(object)j.M(null);
		_ = (CHOOSEFONT)j.M(array);
		_ = E.C(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (IAssemblyLoader)(object)j.M(null);
		}
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (X)n.d();
					return;
				}
				e = e;
				cHOOSEFONT = default(CHOOSEFONT);
				e = null;
				IAssemblyLoader assemblyLoader = null;
				assemblyLoader = null;
			}
			catch
			{
				_ = E.C(default(IntPtr)) is Resource1;
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				assmeblyLoader = assmeblyLoader;
				e = e;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (j)(object)n.d();
				}
				finally
				{
					j = j;
					continue;
				}
			}
			while (obj2 != null);
		}
	}
	,
	static void @_002B_0029_003D_007C__002F_0040_007C6()
	{
		//IL_00f9: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_0348: Expected O, but got I4
		//IL_0351: Expected I, but got O
		//IL_0352: Expected O, but got I4
		//IL_03e9: Expected O, but got I4
		//IL_0484: Expected O, but got I4
		//IL_0497: Expected O, but got I4
		//IL_0640: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06c6: Expected O, but got I4
		//IL_06cf: Expected I, but got O
		//IL_06d0: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_0894: Expected O, but got I4
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					while ((object)null != null)
					{
						CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
					continue;
				}
				break;
			}
		}
		else
		{
			h = (H)j.M(n.d());
			h = default(H);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		do
		{
			try
			{
				_ = (AssmeblyLoader)(object)j.M(null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (H)n.d();
					intPtr = default(IntPtr);
					intPtr = default(IntPtr);
					_ = E.C(intPtr) is CHOOSEFONTFLAGS;
					x = default(X);
					_003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				else
				{
					array = null;
					CHOOSEFONT obj2 = (CHOOSEFONT)j.M(array);
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = obj2;
				}
				continue;
			}
		}
		while ((object)null != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				_ = (IAssemblyLoader)(object)j.M(array);
			}
			while ((object)null != null);
		}
		UIntPtr intPtr2 = (UIntPtr)n.d();
		_003F val;
		checked
		{
			nuint num = unchecked((nuint)(UIntPtr)n.d()) - uIntPtr;
			object obj3 = E.C(unchecked((nint)((nuint)(nint)(IntPtr)n.d() / (nuint)intPtr)));
			val = num * ((obj3 is UIntPtr) ? obj3 : null);
			uIntPtr = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		if ((int)checked(unchecked((nuint)intPtr2) + (val - uIntPtr)) == 0)
		{
			_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		}
		else
		{
			do
			{
				try
				{
					Resource1 obj4 = E.C(intPtr) as Resource1;
					resource = null;
					resource = obj4;
				}
				catch
				{
					_ = (IAssemblyLoader)(object)n.d();
				}
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			_ = E.C(intPtr) is j;
			intPtr = default(IntPtr);
			_ = E.C((nint)(checked(unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)n.d())) / (nuint)intPtr)) is _003CModule_003E;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (uIntPtr / uIntPtr / uIntPtr == 0)
		{
			do
			{
				E obj6 = (E)(object)j.M(null);
				e = e;
				e = obj6;
			}
			while ((object)null != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		do
		{
			try
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = assmeblyLoader;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					e = null;
					continue;
				}
				assmeblyLoader = null;
				IAssemblyLoader obj7 = (IAssemblyLoader)(object)n.d();
				assemblyLoader = assemblyLoader;
				assemblyLoader = obj7;
				n = n;
				n = n;
			}
		}
		while (obj != null);
		try
		{
			do
			{
				h = default(H);
				h = h;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			object obj9 = E.C((IntPtr)n.d());
			_003CModule_003E _003CModule_003E = E.C((IntPtr)((obj9 is IntPtr) ? obj9 : null)) as _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			goto IL_0364;
		}
		IL_0364:
		if (uIntPtr == 0 && (UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (CHOOSEFONT)j.M(array);
			}
		}
		try
		{
			do
			{
				try
				{
					e = e;
				}
				catch
				{
					resource = resource;
				}
			}
			while ((object)n.d() != null);
		}
		catch
		{
			do
			{
				object obj11 = E.C(default(IntPtr));
				x = (X)((obj11 is X) ? obj11 : null);
			}
			while (obj != null);
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (nuint)(UIntPtr)n.d() == 0)
				{
					_ = (H)j.M(j.M(null));
				}
				else
				{
					x = x;
				}
			}
			finally
			{
				try
				{
					n = n;
				}
				catch
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
				}
				goto end_IL_03fe;
			}
			end_IL_03fe:;
		}
		finally
		{
			intPtr = default(IntPtr);
			if (!(E.C(intPtr) is UIntPtr))
			{
				_ = E.C(intPtr) is E;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
				}
			}
			goto IL_04cf;
		}
		IL_074d:
		_ = (X)n.d();
		x = x;
		IntPtr num2 = (IntPtr)j.M(null);
		intPtr = default(IntPtr);
		if (!(E.C((nint)checked(unchecked((nuint)(nint)num2) - (unchecked((nuint)unchecked((nint)default(IntPtr)) / checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)j.M(array)))) - unchecked((nuint)intPtr)))) is UIntPtr))
		{
			if (uIntPtr == 0)
			{
				h = h;
			}
			else
			{
				assmeblyLoader = null;
			}
		}
		checked
		{
			try
			{
				if (uIntPtr - unchecked((nuint)(UIntPtr)n.d() / (nuint)(UIntPtr)n.d()) == 0)
				{
					do
					{
						j j = (j)(object)n.d();
						j = j;
					}
					while (obj != null);
				}
			}
			finally
			{
				do
				{
					resource = (Resource1)(object)n.d();
				}
				while ((object)j.M(n.d()) != null);
				goto IL_0865;
			}
		}
		IL_04cf:
		e = null;
		try
		{
			_ = (X)j.M(null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = null;
				}
				else
				{
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = (CHOOSEFONTFLAGS)n.d();
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)n.d()) - uIntPtr) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				while ((object)n.d() != null)
				{
					resource = (Resource1)(object)j.M(j.M(array));
					_ = (H)j.M(array);
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
					_ = (X)j.M(null);
				}
				goto IL_0635;
			}
		}
		try
		{
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		catch
		{
			try
			{
				h = (H)n.d();
			}
			finally
			{
				_ = (j)(object)j.M(null);
				goto end_IL_05f0;
			}
			end_IL_05f0:;
		}
		goto IL_0635;
		IL_0865:
		while ((object)j.M(array) != null)
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			assmeblyLoader = null;
			resource = resource;
			_ = (n)(object)n.d();
		}
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = E.C((IntPtr)n.d()) is CHOOSEFONTFLAGS;
				}
				else
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				return;
			}
			catch
			{
				e = null;
				return;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)j.M(null)) == 0)
				{
					if (uIntPtr == 0)
					{
						resource = null;
					}
					else
					{
						cHOOSEFONT = default(CHOOSEFONT);
					}
				}
				return;
			}
		}
		IL_0635:
		while (E.C(intPtr) is object)
		{
			_ = (n)(object)n.d();
			_ = (j)(object)n.d();
		}
		x = x;
		_ = (H)n.d();
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j.M(array);
			}
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)n.d()))) is CHOOSEFONTFLAGS;
				}
				finally
				{
					object obj18 = E.C(intPtr);
					_ = E.C((IntPtr)((obj18 is IntPtr) ? obj18 : null)) is j;
					goto end_IL_0685;
				}
			}
			resource = resource;
			end_IL_0685:;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
			{
				resource = (Resource1)(object)n.d();
				goto IL_074d;
			}
			try
			{
				_ = (E)(object)n.d();
			}
			finally
			{
				_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(n.d());
				goto IL_074d;
			}
		}
	}
	,
	static void @_002B_002F_002A_007C__002F_0040_002A5()
	{
		//IL_00c0: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_03ca: Expected O, but got I4
		//IL_0467: Expected O, but got I4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected I, but got Unknown
		//IL_048b: Expected O, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected I, but got Unknown
		//IL_049b: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_04df: Expected O, but got I4
		//IL_04f3: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_063e: Expected O, but got I4
		//IL_0650: Expected O, but got I4
		//IL_0669: Expected O, but got I4
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected I, but got Unknown
		//IL_0674: Expected O, but got I4
		//IL_06a4: Expected O, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		_ = (Resource1)(object)j.M(null);
		CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
		nuint num2;
		byte[] array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num2 = unchecked((nuint)(UIntPtr)n.d()) * num;
			array = null;
		}
		num = num2 / (nuint)(UIntPtr)j.M(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		if (num == 0)
		{
			j = j;
			j = null;
			H h = (H)n.d();
			h = h;
			_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E = null;
			goto IL_00de;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			if (num / num == 0)
			{
				assmeblyLoader = null;
				assmeblyLoader = assmeblyLoader;
			}
			else
			{
				intPtr = intPtr;
				_ = E.C(intPtr) is j;
			}
		}
		finally
		{
			_ = (H)j.M(array);
			goto IL_00de;
		}
		IL_01cc:
		intPtr = default(IntPtr);
		_ = (Resource1)(object)j.M(E.C(intPtr) as byte[]);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			checked
			{
				try
				{
					if (unchecked(num / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						X x = x;
						x = default(X);
					}
				}
				catch
				{
					while (true)
					{
						obj = obj;
						if (obj != null)
						{
							_ = (_003CModule_003E)(object)n.d();
							_ = (E)(object)n.d();
							continue;
						}
						break;
					}
				}
			}
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (j)(object)n.d();
				}
				finally
				{
					IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)n.d();
					assemblyLoader = assemblyLoader;
					goto end_IL_0270;
				}
			}
			end_IL_0270:;
		}
		num = default(UIntPtr);
		if (num == 0 && (UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			object obj4 = E.C((IntPtr)j.M(n.d()));
			H h = (H)((obj4 is H) ? obj4 : null);
		}
		do
		{
			nuint num3 = num;
			num = default(UIntPtr);
			nuint num4;
			checked
			{
				if (num3 - unchecked((nuint)default(UIntPtr)) * num == 0)
				{
					do
					{
						j = j;
					}
					while ((object)j.M(array) != null);
					continue;
				}
				num = default(UIntPtr);
				num4 = num - num;
				num = default(UIntPtr);
			}
			if (checked(num4 + (num + num)) / num == 0)
			{
				cHOOSEFONT = (CHOOSEFONT)n.d();
			}
		}
		while (obj != null);
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					_ = E.C((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)intPtr))) is Resource1;
				}
				else
				{
					j = null;
				}
			}
			while ((object)null != null);
		}
		else
		{
			do
			{
				j = j;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			Resource1 resource = null;
			resource = resource;
		}
		try
		{
			cHOOSEFONT = (CHOOSEFONT)n.d();
		}
		catch
		{
			try
			{
				do
				{
					_ = (n)(object)j.M(array);
				}
				while (obj != null);
			}
			catch
			{
				nint intPtr2 = intPtr;
				intPtr = default(IntPtr);
				object obj5 = E.C((IntPtr)checked((/*isinst with value type is only supported in some contexts*/ + unchecked((nuint)(nint)(IntPtr)n.d())) * /*isinst with value type is only supported in some contexts*/));
				_ = E.C((IntPtr)j.M(E.C(checked(intPtr2 + ((obj5 is IntPtr) ? obj5 : null)) / intPtr) as byte[])) is CHOOSEFONT;
			}
		}
		if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
		{
			_ = E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))) is IAssemblyLoader;
			_ = E.C((nint)checked(unchecked((nuint)intPtr) * unchecked((nuint)intPtr))) is IAssemblyLoader;
			_ = (CHOOSEFONT)j.M(array);
			_ = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
		}
		else if (num == 0)
		{
			_ = (X)n.d();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		try
		{
			try
			{
				try
				{
					_ = (CHOOSEFONT)j.M(array);
				}
				finally
				{
					_ = (_003CModule_003E)(object)j.M(array);
					goto end_IL_0533;
				}
				end_IL_0533:;
			}
			finally
			{
				while (obj != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				goto end_IL_0532;
			}
			end_IL_0532:;
		}
		finally
		{
			e = e;
			goto IL_058d;
		}
		IL_058d:
		nuint num5 = num;
		UIntPtr num6 = (UIntPtr)j.M(E.C(intPtr) as byte[]);
		num = default(UIntPtr);
		checked
		{
			if (num5 - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num6 / checked(unchecked((nuint)default(UIntPtr)) * num)) - num * unchecked((nuint)(UIntPtr)j.M(array)))) == 0)
			{
				_ = (Resource1)(object)n.d();
			}
			_ = (Resource1)(object)n.d();
		}
		if (num == 0)
		{
			n n = n;
			n = null;
		}
		else if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			try
			{
				j = E.C(intPtr) as j;
				_ = E.C(intPtr) is H;
				nint num7 = intPtr;
				object obj8 = E.C((IntPtr)n.d());
				_ = E.C(checked(num7 * ((obj8 is IntPtr) ? obj8 : null))) is n;
			}
			catch
			{
				Resource1 resource = (Resource1)(object)n.d();
			}
		}
		else
		{
			nuint num8 = num;
			object obj10 = E.C(intPtr);
			if ((int)checked(num8 + ((obj10 is UIntPtr) ? obj10 : null)) == 0)
			{
				_ = E.C(intPtr) is Resource1;
			}
		}
		if (num == 0)
		{
			while (obj != null)
			{
				j = j;
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)j.M(array);
				}
				catch
				{
					nuint num9;
					nint num10;
					checked
					{
						num9 = unchecked((nuint)intPtr) * unchecked((nuint)(nint)(IntPtr)j.M(array));
						num10 = intPtr;
						intPtr = default(IntPtr);
					}
					_ = E.C((nint)(num9 / checked(unchecked((nuint)num10) + unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)j.M(array))))) is CHOOSEFONTFLAGS;
				}
			}
			while ((object)n.d() != null);
		}
		catch
		{
			IAssemblyLoader assemblyLoader = null;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
				{
					_ = (X)j.M(null);
				}
				else
				{
					_ = (IAssemblyLoader)(object)n.d();
				}
			}
		}
		catch
		{
			j = j;
		}
		_ = (AssmeblyLoader)(object)j.M(array);
		return;
		IL_00de:
		e = e;
		e = e;
		_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		assmeblyLoader = assmeblyLoader;
		cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
		cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		assmeblyLoader = null;
		try
		{
			if (E.C(intPtr) is UIntPtr)
			{
				try
				{
					_ = (E)(object)j.M(n.d());
				}
				finally
				{
					_ = (j)(object)n.d();
					_ = (X)n.d();
					_ = (j)(object)n.d();
					H h = default(H);
					goto end_IL_012f;
				}
			}
			_ = E.C(intPtr) is AssmeblyLoader;
			end_IL_012f:;
		}
		finally
		{
			if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
			{
				j = j;
			}
			goto IL_01cc;
		}
	}
	,
	static void @_007D_0026_002A_007C_002A_002F_0025_003A4()
	{
		//IL_0031: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0090: Expected I, but got O
		//IL_0148: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_033d: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_03a6: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03c7: Expected I4, but got O
		//IL_03dc: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected I, but got Unknown
		//IL_0552: Expected O, but got I4
		//IL_0603: Expected O, but got I4
		//IL_0624: Expected O, but got I4
		//IL_0682: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_073d: Expected O, but got I4
		//IL_075a: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_07e5: Expected O, but got I4
		//IL_07ee: Expected I, but got O
		//IL_07ef: Expected O, but got I4
		nint intPtr;
		do
		{
			try
			{
				do
				{
					_ = (IAssemblyLoader)(object)j.M(n.d());
					intPtr = (IntPtr)n.d();
				}
				while (E.C(intPtr) is object);
			}
			catch
			{
				_ = (n)(object)n.d();
			}
		}
		while ((object)n.d() != null);
		object obj2 = E.C((IntPtr)j.M(null));
		object obj3 = ((obj2 is UIntPtr) ? obj2 : null);
		intPtr = default(IntPtr);
		object obj4 = E.C(intPtr);
		nuint num = (nuint)checked(obj3 - ((obj4 is UIntPtr) ? obj4 : null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		if (num == 0)
		{
			if (num == 0)
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				_ = (n)(object)j.M(null);
				array = n.d();
				_ = (Resource1)(object)j.M(array);
			}
		}
		else
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n obj5 = (n)(object)j.M(array);
					n = (n)(object)j.M(null);
					n = obj5;
				}
			}
			catch
			{
				try
				{
					intPtr = default(IntPtr);
					_ = E.C(intPtr) is H;
				}
				finally
				{
					_ = (AssmeblyLoader)(object)j.M(null);
					goto end_IL_0132;
				}
				end_IL_0132:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		do
		{
			_ = (j)(object)n.d();
			obj7 = obj7;
		}
		while (obj7 != null);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				h = h;
				h = h;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
				while ((object)j.M(n.d()) != null)
				{
					resource = resource;
					resource = null;
				}
			}
			catch
			{
				_ = (j)(object)j.M(null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (num / num == 0)
		{
			while (obj7 != null)
			{
				e = null;
				e = null;
			}
		}
		else
		{
			n = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		try
		{
			while (obj7 != null)
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_ = E.C(intPtr) is H;
				Resource1 resource = null;
				intPtr = default(IntPtr);
				_ = E.C(intPtr) is n;
			}
		}
		finally
		{
			try
			{
				try
				{
					Resource1 resource = null;
				}
				finally
				{
					_ = (E)(object)j.M(array);
					goto end_IL_027e;
				}
				end_IL_027e:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					x = x;
					x = default(X);
				}
				goto IL_0308;
			}
		}
		IL_05f7:
		_003CModule_003E _003CModule_003E;
		checked
		{
			try
			{
				_ = E.C(intPtr) is Resource1;
				h = h;
				_ = E.C(default(IntPtr)) is Resource1;
			}
			finally
			{
				while (obj7 != null)
				{
					num = default(UIntPtr);
					if (num * unchecked((nuint)(UIntPtr)j.M(j.M(null))) == 0)
					{
						_003CModule_003E = null;
					}
				}
				goto IL_0671;
			}
		}
		IL_0308:
		while (true)
		{
			if ((object)null != null)
			{
				if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				}
				else
				{
					e = e;
				}
			}
			else if ((object)null == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		do
		{
			cHOOSEFONT = cHOOSEFONT;
			cHOOSEFONT = cHOOSEFONT;
			intPtr = default(IntPtr);
		}
		while (E.C(intPtr) is object || (object)null != null);
		while ((object)null != null)
		{
			_ = E.C(intPtr) is Resource1;
			_ = (CHOOSEFONTFLAGS)n.d();
			_ = (n)(object)n.d();
		}
		while (obj7 != null)
		{
			try
			{
				_ = (IAssemblyLoader)(object)j.M(array);
			}
			finally
			{
				do
				{
					_ = E.C(intPtr) is _003CModule_003E;
					object obj9 = E.C((IntPtr)j.M(array));
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj9 is CHOOSEFONTFLAGS) ? obj9 : null);
					IAssemblyLoader assemblyLoader = E.C(default(IntPtr)) as IAssemblyLoader;
					assemblyLoader = null;
					intPtr = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked((nuint)intPtr))) is j;
				}
				while ((object)j.M(null) != null);
				continue;
			}
		}
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					x = (X)n.d();
				}
				catch
				{
					_ = (CHOOSEFONT)j.M(array);
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			catch
			{
				while (obj7 != null)
				{
					_003CModule_003E = E.C((IntPtr)n.d()) as _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		_ = (j)(object)n.d();
		_003CModule_003E = (_003CModule_003E)(object)j.M(j.M(j.M(array)));
		_ = (E)(object)j.M(E.C(intPtr) as byte[]);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			h = h;
		}
		else
		{
			while (obj7 != null)
			{
				nint intPtr2 = intPtr;
				IntPtr intPtr3 = (IntPtr)j.M(array);
				intPtr = default(IntPtr);
				object obj12 = E.C(intPtr);
				_ = E.C((nint)checked(intPtr2 - (unchecked((nuint)(nint)intPtr3) + ((obj12 is IntPtr) ? obj12 : null)))) is H;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		try
		{
			try
			{
				while ((object)j.M(array) != null)
				{
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					n = n;
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				try
				{
					x = x;
				}
				catch
				{
					j = null;
					j = j;
				}
				goto end_IL_0562;
			}
			end_IL_0562:;
		}
		finally
		{
			if (num == 0)
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
			}
			goto IL_05f7;
		}
		IL_0671:
		do
		{
			_ = E.C((IntPtr)n.d()) is X;
		}
		while (E.C((IntPtr)j.M(null)) is object);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			_ = (j)(object)n.d();
		}
		else
		{
			while ((object)n.d() != null)
			{
				_ = (Resource1)(object)n.d();
			}
		}
		if (num == 0)
		{
			j = j;
		}
		else
		{
			_ = (CHOOSEFONT)n.d();
		}
		while (true)
		{
			if ((object)null != null)
			{
				do
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				while ((object)null != null);
			}
			else if (!(E.C(default(IntPtr)) is object))
			{
				break;
			}
		}
		intPtr = default(IntPtr);
		if (!(E.C(intPtr) is UIntPtr))
		{
			intPtr = default(IntPtr);
			_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					Resource1 resource = null;
				}
				while ((object)n.d() != null);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					object obj14 = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)intPtr)));
					_ = E.C((IntPtr)((obj14 is IntPtr) ? obj14 : null)) is X;
				}
				return;
			}
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
			}
			finally
			{
				cHOOSEFONT = default(CHOOSEFONT);
				return;
			}
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					e = (E)(object)n.d();
				}
				else
				{
					Resource1 resource = (Resource1)(object)j.M(j.M(null));
				}
			}
			finally
			{
				try
				{
					_ = (IAssemblyLoader)(object)j.M(array);
					return;
				}
				catch
				{
					j = j;
					return;
				}
			}
		}
	}
	,
	static void @_002B_0029_003D_0040_003B_002F_002E_005D2()
	{
		//IL_005b: Expected O, but got I4
		//IL_0064: Expected I, but got O
		//IL_0065: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_006f: Expected O, but got I4
		//IL_0077: Expected I, but got O
		//IL_0127: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_019c: Expected I, but got O
		//IL_019d: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected I, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_037b: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_03fc: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		//IL_043d: Expected O, but got I4
		//IL_047a: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_055d: Expected O, but got I4
		//IL_05ec: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_0704: Expected O, but got I4
		//IL_0725: Expected O, but got I4
		try
		{
			while ((object)null != null)
			{
				j j = null;
				j = j;
			}
		}
		finally
		{
			H obj = (H)j.M(null);
			H h = h;
			h = obj;
			IAssemblyLoader assemblyLoader = assemblyLoader;
			assemblyLoader = assemblyLoader;
			goto IL_004a;
		}
		IL_004a:
		object obj2 = E.C((IntPtr)n.d());
		object obj3 = E.C((IntPtr)((obj2 is IntPtr) ? obj2 : null));
		object obj4 = E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null));
		nuint num = (nuint)(nint)((obj4 is UIntPtr) ? obj4 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		if (num == 0)
		{
			while (true)
			{
				obj5 = obj5;
				if (obj5 != null)
				{
					AssmeblyLoader obj6 = (AssmeblyLoader)(object)n.d();
					assmeblyLoader = null;
					assmeblyLoader = obj6;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
		}
		else
		{
			while (obj5 != null)
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					n obj7 = (n)(object)n.d();
					n = n;
					n = obj7;
					continue;
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				assmeblyLoader = assmeblyLoader;
			}
			else if (!(E.C((IntPtr)n.d()) is UIntPtr))
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		catch
		{
			try
			{
				_ = (IAssemblyLoader)(object)n.d();
			}
			catch
			{
				_ = (CHOOSEFONT)j.M(null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		do
		{
			if (num == 0 && num == 0)
			{
				num2 = num2;
				num2 = default(IntPtr);
				object obj10 = E.C(num2);
				_ = E.C((IntPtr)((obj10 is IntPtr) ? obj10 : null)) is IAssemblyLoader;
			}
		}
		while (obj5 != null);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj5 != null)
			{
				if (unchecked((nuint)(UIntPtr)j.M(n.d())) + num == 0)
				{
					while ((object)n.d() != null)
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = null;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			nint num3 = num2;
			num2 = default(IntPtr);
			nuint num4;
			object obj11;
			checked
			{
				num4 = unchecked((nuint)num3) + unchecked((nuint)num2);
				obj11 = E.C(num2);
			}
			array = E.C((nint)checked(num4 + ((obj11 is IntPtr) ? obj11 : null))) as byte[];
			cHOOSEFONT = (CHOOSEFONT)j.M(array);
			cHOOSEFONT = cHOOSEFONT;
		}
		do
		{
			if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				nuint num5 = num;
				object obj12 = E.C(num2);
				if ((int)checked(num5 * ((obj12 is UIntPtr) ? obj12 : null)) == 0)
				{
					_ = E.C(num2) is n;
				}
			}
			else
			{
				_ = (CHOOSEFONTFLAGS)j.M(null);
			}
		}
		while ((object)null != null);
		if (!(E.C((IntPtr)n.d()) is UIntPtr))
		{
			while (true)
			{
				if (E.C(num2) is object)
				{
					_ = (H)j.M(array);
				}
				else if (obj5 == null)
				{
					break;
				}
			}
		}
		do
		{
			if (num == 0)
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			else
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
			}
		}
		while ((object)null != null);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		try
		{
			x = x;
			x = x;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					_ = E.C((IntPtr)j.M(array)) is j;
				}
				else
				{
					n = null;
				}
			}
			finally
			{
				try
				{
					e = e;
					e = e;
					e = E.C((IntPtr)j.M(null)) as E;
					num2 = default(IntPtr);
					_ = E.C(num2) is j;
					x = x;
				}
				catch
				{
					_ = E.C((nint)checked(unchecked((nuint)num2) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is E;
				}
				goto IL_0409;
			}
		}
		IL_0409:
		num2 = default(IntPtr);
		_ = E.C(num2) is j;
		while (obj5 != null)
		{
			num2 = default(IntPtr);
			j j = E.C(num2) as j;
		}
		try
		{
			Resource1 resource = (Resource1)(object)n.d();
			resource = resource;
			num2 = default(IntPtr);
			_ = E.C(num2) is n;
			e = e;
		}
		catch
		{
			if (num / checked(num - num) == 0)
			{
				while ((object)null != null)
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			else
			{
				try
				{
					assmeblyLoader = null;
					_ = E.C(num2) is CHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
					_ = (n)(object)j.M(array);
				}
				catch
				{
					n = n;
				}
			}
		}
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			if (!(E.C(num2) is UIntPtr))
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (E)(object)n.d();
				}
			}
			else
			{
				_ = E.C((IntPtr)j.M(n.d())) is AssmeblyLoader;
			}
		}
		else
		{
			while (obj5 != null)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)j.M(null);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		do
		{
			try
			{
				try
				{
					cHOOSEFONT = (CHOOSEFONT)n.d();
					_ = (j)(object)n.d();
				}
				finally
				{
					x = default(X);
					_ = (CHOOSEFONTFLAGS)n.d();
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
					_ = (Resource1)(object)j.M(E.C(num2) as byte[]);
					goto end_IL_0599;
				}
				end_IL_0599:;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = null;
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				continue;
			}
		}
		while ((object)null != null);
		try
		{
			try
			{
				num2 = default(IntPtr);
				nint num6 = num2;
				num2 = default(IntPtr);
				_ = E.C((nint)checked(unchecked((nuint)num6) * unchecked((nuint)num2))) is AssmeblyLoader;
				_003CModule_003E _003CModule_003E = E.C((nint)checked(unchecked((nuint)num2) * unchecked((nuint)num2))) as _003CModule_003E;
				num2 = default(IntPtr);
				Resource1 resource = (Resource1)(object)j.M(E.C(num2) as byte[]);
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			}
			catch
			{
				while (obj5 != null)
				{
					_ = (j)(object)n.d();
				}
			}
		}
		catch
		{
			while ((object)null != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					num2 = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)num2) + unchecked((nuint)(nint)(IntPtr)j.M(null)))) is IAssemblyLoader;
				}
				else
				{
					_ = E.C((nint)((nuint)(nint)(IntPtr)j.M(null) / (nuint)num2)) is IAssemblyLoader;
				}
			}
		}
		do
		{
			cHOOSEFONT = cHOOSEFONT;
			_ = (IAssemblyLoader)(object)j.M(null);
		}
		while (obj5 != null);
	}
	,
	static void @_002B_0029_003D_0040_003B_002F_002E_005D2()
	{
		//IL_005b: Expected O, but got I4
		//IL_0064: Expected I, but got O
		//IL_0065: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_006f: Expected O, but got I4
		//IL_0077: Expected I, but got O
		//IL_0127: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_019c: Expected I, but got O
		//IL_019d: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected I, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_037b: Expected O, but got I4
		//IL_03b4: Expected O, but got I4
		//IL_03d0: Expected O, but got I4
		//IL_03fc: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		//IL_043d: Expected O, but got I4
		//IL_047a: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_055d: Expected O, but got I4
		//IL_05ec: Expected O, but got I4
		//IL_0657: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_0704: Expected O, but got I4
		//IL_0725: Expected O, but got I4
		try
		{
			while ((object)null != null)
			{
				j j = null;
				j = j;
			}
		}
		finally
		{
			H obj = (H)j.M(null);
			H h = h;
			h = obj;
			IAssemblyLoader assemblyLoader = assemblyLoader;
			assemblyLoader = assemblyLoader;
			goto IL_004a;
		}
		IL_004a:
		object obj2 = E.C((IntPtr)n.d());
		object obj3 = E.C((IntPtr)((obj2 is IntPtr) ? obj2 : null));
		object obj4 = E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null));
		nuint num = (nuint)(nint)((obj4 is UIntPtr) ? obj4 : null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj5);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		if (num == 0)
		{
			while (true)
			{
				obj5 = obj5;
				if (obj5 != null)
				{
					AssmeblyLoader obj6 = (AssmeblyLoader)(object)n.d();
					assmeblyLoader = null;
					assmeblyLoader = obj6;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
		}
		else
		{
			while (obj5 != null)
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					n obj7 = (n)(object)n.d();
					n = n;
					n = obj7;
					continue;
				}
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				assmeblyLoader = assmeblyLoader;
			}
			else if (!(E.C((IntPtr)n.d()) is UIntPtr))
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		catch
		{
			try
			{
				_ = (IAssemblyLoader)(object)n.d();
			}
			catch
			{
				_ = (CHOOSEFONT)j.M(null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		do
		{
			if (num == 0 && num == 0)
			{
				num2 = num2;
				num2 = default(IntPtr);
				object obj10 = E.C(num2);
				_ = E.C((IntPtr)((obj10 is IntPtr) ? obj10 : null)) is IAssemblyLoader;
			}
		}
		while (obj5 != null);
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			while (obj5 != null)
			{
				if (unchecked((nuint)(UIntPtr)j.M(n.d())) + num == 0)
				{
					while ((object)n.d() != null)
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = null;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			nint num3 = num2;
			num2 = default(IntPtr);
			nuint num4;
			object obj11;
			checked
			{
				num4 = unchecked((nuint)num3) + unchecked((nuint)num2);
				obj11 = E.C(num2);
			}
			array = E.C((nint)checked(num4 + ((obj11 is IntPtr) ? obj11 : null))) as byte[];
			cHOOSEFONT = (CHOOSEFONT)j.M(array);
			cHOOSEFONT = cHOOSEFONT;
		}
		do
		{
			if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
			{
				num = default(UIntPtr);
				nuint num5 = num;
				object obj12 = E.C(num2);
				if ((int)checked(num5 * ((obj12 is UIntPtr) ? obj12 : null)) == 0)
				{
					_ = E.C(num2) is n;
				}
			}
			else
			{
				_ = (CHOOSEFONTFLAGS)j.M(null);
			}
		}
		while ((object)null != null);
		if (!(E.C((IntPtr)n.d()) is UIntPtr))
		{
			while (true)
			{
				if (E.C(num2) is object)
				{
					_ = (H)j.M(array);
				}
				else if (obj5 == null)
				{
					break;
				}
			}
		}
		do
		{
			if (num == 0)
			{
				_ = (_003CModule_003E)(object)n.d();
			}
			else
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
			}
		}
		while ((object)null != null);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		try
		{
			x = x;
			x = x;
		}
		finally
		{
			try
			{
				if (num == 0)
				{
					_ = E.C((IntPtr)j.M(array)) is j;
				}
				else
				{
					n = null;
				}
			}
			finally
			{
				try
				{
					e = e;
					e = e;
					e = E.C((IntPtr)j.M(null)) as E;
					num2 = default(IntPtr);
					_ = E.C(num2) is j;
					x = x;
				}
				catch
				{
					_ = E.C((nint)checked(unchecked((nuint)num2) - unchecked((nuint)unchecked((nint)default(IntPtr))))) is E;
				}
				goto IL_0409;
			}
		}
		IL_0409:
		num2 = default(IntPtr);
		_ = E.C(num2) is j;
		while (obj5 != null)
		{
			num2 = default(IntPtr);
			j j = E.C(num2) as j;
		}
		try
		{
			Resource1 resource = (Resource1)(object)n.d();
			resource = resource;
			num2 = default(IntPtr);
			_ = E.C(num2) is n;
			e = e;
		}
		catch
		{
			if (num / checked(num - num) == 0)
			{
				while ((object)null != null)
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			else
			{
				try
				{
					assmeblyLoader = null;
					_ = E.C(num2) is CHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
					_ = (n)(object)j.M(array);
				}
				catch
				{
					n = n;
				}
			}
		}
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			if (!(E.C(num2) is UIntPtr))
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (E)(object)n.d();
				}
			}
			else
			{
				_ = E.C((IntPtr)j.M(n.d())) is AssmeblyLoader;
			}
		}
		else
		{
			while (obj5 != null)
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)j.M(null);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		do
		{
			try
			{
				try
				{
					cHOOSEFONT = (CHOOSEFONT)n.d();
					_ = (j)(object)n.d();
				}
				finally
				{
					x = default(X);
					_ = (CHOOSEFONTFLAGS)n.d();
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
					_ = (Resource1)(object)j.M(E.C(num2) as byte[]);
					goto end_IL_0599;
				}
				end_IL_0599:;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = null;
					_ = (CHOOSEFONTFLAGS)n.d();
				}
				continue;
			}
		}
		while ((object)null != null);
		try
		{
			try
			{
				num2 = default(IntPtr);
				nint num6 = num2;
				num2 = default(IntPtr);
				_ = E.C((nint)checked(unchecked((nuint)num6) * unchecked((nuint)num2))) is AssmeblyLoader;
				_003CModule_003E _003CModule_003E = E.C((nint)checked(unchecked((nuint)num2) * unchecked((nuint)num2))) as _003CModule_003E;
				num2 = default(IntPtr);
				Resource1 resource = (Resource1)(object)j.M(E.C(num2) as byte[]);
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			}
			catch
			{
				while (obj5 != null)
				{
					_ = (j)(object)n.d();
				}
			}
		}
		catch
		{
			while ((object)null != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					num2 = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)num2) + unchecked((nuint)(nint)(IntPtr)j.M(null)))) is IAssemblyLoader;
				}
				else
				{
					_ = E.C((nint)((nuint)(nint)(IntPtr)j.M(null) / (nuint)num2)) is IAssemblyLoader;
				}
			}
		}
		do
		{
			cHOOSEFONT = cHOOSEFONT;
			_ = (IAssemblyLoader)(object)j.M(null);
		}
		while (obj5 != null);
	}
	,
	static void @_007D_0026_002A_007C_002A_002F_0025_003A4()
	{
		//IL_0031: Expected O, but got I4
		//IL_006f: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0090: Expected I, but got O
		//IL_0148: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_033d: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_03a6: Expected O, but got I4
		//IL_03bf: Expected O, but got I4
		//IL_03c7: Expected I4, but got O
		//IL_03dc: Expected O, but got I4
		//IL_040b: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04ee: Expected O, but got I4
		//IL_0546: Expected O, but got I4
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected I, but got Unknown
		//IL_0552: Expected O, but got I4
		//IL_0603: Expected O, but got I4
		//IL_0624: Expected O, but got I4
		//IL_0682: Expected O, but got I4
		//IL_0699: Expected O, but got I4
		//IL_073d: Expected O, but got I4
		//IL_075a: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_07e5: Expected O, but got I4
		//IL_07ee: Expected I, but got O
		//IL_07ef: Expected O, but got I4
		nint intPtr;
		do
		{
			try
			{
				do
				{
					_ = (IAssemblyLoader)(object)j.M(n.d());
					intPtr = (IntPtr)n.d();
				}
				while (E.C(intPtr) is object);
			}
			catch
			{
				_ = (n)(object)n.d();
			}
		}
		while ((object)n.d() != null);
		object obj2 = E.C((IntPtr)j.M(null));
		object obj3 = ((obj2 is UIntPtr) ? obj2 : null);
		intPtr = default(IntPtr);
		object obj4 = E.C(intPtr);
		nuint num = (nuint)checked(obj3 - ((obj4 is UIntPtr) ? obj4 : null));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		if (num == 0)
		{
			if (num == 0)
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				_ = (n)(object)j.M(null);
				array = n.d();
				_ = (Resource1)(object)j.M(array);
			}
		}
		else
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					n obj5 = (n)(object)j.M(array);
					n = (n)(object)j.M(null);
					n = obj5;
				}
			}
			catch
			{
				try
				{
					intPtr = default(IntPtr);
					_ = E.C(intPtr) is H;
				}
				finally
				{
					_ = (AssmeblyLoader)(object)j.M(null);
					goto end_IL_0132;
				}
				end_IL_0132:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj7);
		do
		{
			_ = (j)(object)n.d();
			obj7 = obj7;
		}
		while (obj7 != null);
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		checked
		{
			if (num - unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				h = h;
				h = h;
			}
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
				while ((object)j.M(n.d()) != null)
				{
					resource = resource;
					resource = null;
				}
			}
			catch
			{
				_ = (j)(object)j.M(null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (num / num == 0)
		{
			while (obj7 != null)
			{
				e = null;
				e = null;
			}
		}
		else
		{
			n = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		try
		{
			while (obj7 != null)
			{
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_ = E.C(intPtr) is H;
				Resource1 resource = null;
				intPtr = default(IntPtr);
				_ = E.C(intPtr) is n;
			}
		}
		finally
		{
			try
			{
				try
				{
					Resource1 resource = null;
				}
				finally
				{
					_ = (E)(object)j.M(array);
					goto end_IL_027e;
				}
				end_IL_027e:;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					x = x;
					x = default(X);
				}
				goto IL_0308;
			}
		}
		IL_05f7:
		_003CModule_003E _003CModule_003E;
		checked
		{
			try
			{
				_ = E.C(intPtr) is Resource1;
				h = h;
				_ = E.C(default(IntPtr)) is Resource1;
			}
			finally
			{
				while (obj7 != null)
				{
					num = default(UIntPtr);
					if (num * unchecked((nuint)(UIntPtr)j.M(j.M(null))) == 0)
					{
						_003CModule_003E = null;
					}
				}
				goto IL_0671;
			}
		}
		IL_0308:
		while (true)
		{
			if ((object)null != null)
			{
				if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
				}
				else
				{
					e = e;
				}
			}
			else if ((object)null == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		do
		{
			cHOOSEFONT = cHOOSEFONT;
			cHOOSEFONT = cHOOSEFONT;
			intPtr = default(IntPtr);
		}
		while (E.C(intPtr) is object || (object)null != null);
		while ((object)null != null)
		{
			_ = E.C(intPtr) is Resource1;
			_ = (CHOOSEFONTFLAGS)n.d();
			_ = (n)(object)n.d();
		}
		while (obj7 != null)
		{
			try
			{
				_ = (IAssemblyLoader)(object)j.M(array);
			}
			finally
			{
				do
				{
					_ = E.C(intPtr) is _003CModule_003E;
					object obj9 = E.C((IntPtr)j.M(array));
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj9 is CHOOSEFONTFLAGS) ? obj9 : null);
					IAssemblyLoader assemblyLoader = E.C(default(IntPtr)) as IAssemblyLoader;
					assemblyLoader = null;
					intPtr = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) + unchecked((nuint)intPtr))) is j;
				}
				while ((object)j.M(null) != null);
				continue;
			}
		}
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					x = (X)n.d();
				}
				catch
				{
					_ = (CHOOSEFONT)j.M(array);
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
			catch
			{
				while (obj7 != null)
				{
					_003CModule_003E = E.C((IntPtr)n.d()) as _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		_ = (j)(object)n.d();
		_003CModule_003E = (_003CModule_003E)(object)j.M(j.M(j.M(array)));
		_ = (E)(object)j.M(E.C(intPtr) as byte[]);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			h = h;
		}
		else
		{
			while (obj7 != null)
			{
				nint intPtr2 = intPtr;
				IntPtr intPtr3 = (IntPtr)j.M(array);
				intPtr = default(IntPtr);
				object obj12 = E.C(intPtr);
				_ = E.C((nint)checked(intPtr2 - (unchecked((nuint)(nint)intPtr3) + ((obj12 is IntPtr) ? obj12 : null)))) is H;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		try
		{
			try
			{
				while ((object)j.M(array) != null)
				{
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					n = n;
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				try
				{
					x = x;
				}
				catch
				{
					j = null;
					j = j;
				}
				goto end_IL_0562;
			}
			end_IL_0562:;
		}
		finally
		{
			if (num == 0)
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
			}
			goto IL_05f7;
		}
		IL_0671:
		do
		{
			_ = E.C((IntPtr)n.d()) is X;
		}
		while (E.C((IntPtr)j.M(null)) is object);
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			_ = (j)(object)n.d();
		}
		else
		{
			while ((object)n.d() != null)
			{
				_ = (Resource1)(object)n.d();
			}
		}
		if (num == 0)
		{
			j = j;
		}
		else
		{
			_ = (CHOOSEFONT)n.d();
		}
		while (true)
		{
			if ((object)null != null)
			{
				do
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				while ((object)null != null);
			}
			else if (!(E.C(default(IntPtr)) is object))
			{
				break;
			}
		}
		intPtr = default(IntPtr);
		if (!(E.C(intPtr) is UIntPtr))
		{
			intPtr = default(IntPtr);
			_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		}
		else
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				do
				{
					Resource1 resource = null;
				}
				while ((object)n.d() != null);
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					object obj14 = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)intPtr)));
					_ = E.C((IntPtr)((obj14 is IntPtr) ? obj14 : null)) is X;
				}
				return;
			}
			try
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
			}
			finally
			{
				cHOOSEFONT = default(CHOOSEFONT);
				return;
			}
		}
		catch
		{
			try
			{
				if (num == 0)
				{
					e = (E)(object)n.d();
				}
				else
				{
					Resource1 resource = (Resource1)(object)j.M(j.M(null));
				}
			}
			finally
			{
				try
				{
					_ = (IAssemblyLoader)(object)j.M(array);
					return;
				}
				catch
				{
					j = j;
					return;
				}
			}
		}
	}
	,
	static void @_002B_002F_002A_007C__002F_0040_002A5()
	{
		//IL_00c0: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_03ca: Expected O, but got I4
		//IL_0467: Expected O, but got I4
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected I, but got Unknown
		//IL_048b: Expected O, but got I4
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected I, but got Unknown
		//IL_049b: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_04df: Expected O, but got I4
		//IL_04f3: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_063e: Expected O, but got I4
		//IL_0650: Expected O, but got I4
		//IL_0669: Expected O, but got I4
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected I, but got Unknown
		//IL_0674: Expected O, but got I4
		//IL_06a4: Expected O, but got I4
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		_ = (Resource1)(object)j.M(null);
		CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
		nuint num2;
		byte[] array;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			num2 = unchecked((nuint)(UIntPtr)n.d()) * num;
			array = null;
		}
		num = num2 / (nuint)(UIntPtr)j.M(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		if (num == 0)
		{
			j = j;
			j = null;
			H h = (H)n.d();
			h = h;
			_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			_003CPrivateImplementationDetails_003E = null;
			goto IL_00de;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			if (num / num == 0)
			{
				assmeblyLoader = null;
				assmeblyLoader = assmeblyLoader;
			}
			else
			{
				intPtr = intPtr;
				_ = E.C(intPtr) is j;
			}
		}
		finally
		{
			_ = (H)j.M(array);
			goto IL_00de;
		}
		IL_01cc:
		intPtr = default(IntPtr);
		_ = (Resource1)(object)j.M(E.C(intPtr) as byte[]);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			checked
			{
				try
				{
					if (unchecked(num / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr)) == 0)
					{
						X x = x;
						x = default(X);
					}
				}
				catch
				{
					while (true)
					{
						obj = obj;
						if (obj != null)
						{
							_ = (_003CModule_003E)(object)n.d();
							_ = (E)(object)n.d();
							continue;
						}
						break;
					}
				}
			}
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (j)(object)n.d();
				}
				finally
				{
					IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)n.d();
					assemblyLoader = assemblyLoader;
					goto end_IL_0270;
				}
			}
			end_IL_0270:;
		}
		num = default(UIntPtr);
		if (num == 0 && (UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			object obj4 = E.C((IntPtr)j.M(n.d()));
			H h = (H)((obj4 is H) ? obj4 : null);
		}
		do
		{
			nuint num3 = num;
			num = default(UIntPtr);
			nuint num4;
			checked
			{
				if (num3 - unchecked((nuint)default(UIntPtr)) * num == 0)
				{
					do
					{
						j = j;
					}
					while ((object)j.M(array) != null);
					continue;
				}
				num = default(UIntPtr);
				num4 = num - num;
				num = default(UIntPtr);
			}
			if (checked(num4 + (num + num)) / num == 0)
			{
				cHOOSEFONT = (CHOOSEFONT)n.d();
			}
		}
		while (obj != null);
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			do
			{
				num = default(UIntPtr);
				if (checked(num + num) == 0)
				{
					_ = E.C((nint)checked(unchecked((nuint)intPtr) + unchecked((nuint)intPtr))) is Resource1;
				}
				else
				{
					j = null;
				}
			}
			while ((object)null != null);
		}
		else
		{
			do
			{
				j = j;
			}
			while (obj != null);
		}
		while (obj != null)
		{
			Resource1 resource = null;
			resource = resource;
		}
		try
		{
			cHOOSEFONT = (CHOOSEFONT)n.d();
		}
		catch
		{
			try
			{
				do
				{
					_ = (n)(object)j.M(array);
				}
				while (obj != null);
			}
			catch
			{
				nint intPtr2 = intPtr;
				intPtr = default(IntPtr);
				object obj5 = E.C((IntPtr)checked((/*isinst with value type is only supported in some contexts*/ + unchecked((nuint)(nint)(IntPtr)n.d())) * /*isinst with value type is only supported in some contexts*/));
				_ = E.C((IntPtr)j.M(E.C(checked(intPtr2 + ((obj5 is IntPtr) ? obj5 : null)) / intPtr) as byte[])) is CHOOSEFONT;
			}
		}
		if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
		{
			_ = E.C((nint)checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)n.d()))) is IAssemblyLoader;
			_ = E.C((nint)checked(unchecked((nuint)intPtr) * unchecked((nuint)intPtr))) is IAssemblyLoader;
			_ = (CHOOSEFONT)j.M(array);
			_ = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
		}
		else if (num == 0)
		{
			_ = (X)n.d();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS;
		try
		{
			try
			{
				try
				{
					_ = (CHOOSEFONT)j.M(array);
				}
				finally
				{
					_ = (_003CModule_003E)(object)j.M(array);
					goto end_IL_0533;
				}
				end_IL_0533:;
			}
			finally
			{
				while (obj != null)
				{
					cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				}
				goto end_IL_0532;
			}
			end_IL_0532:;
		}
		finally
		{
			e = e;
			goto IL_058d;
		}
		IL_058d:
		nuint num5 = num;
		UIntPtr num6 = (UIntPtr)j.M(E.C(intPtr) as byte[]);
		num = default(UIntPtr);
		checked
		{
			if (num5 - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num6 / checked(unchecked((nuint)default(UIntPtr)) * num)) - num * unchecked((nuint)(UIntPtr)j.M(array)))) == 0)
			{
				_ = (Resource1)(object)n.d();
			}
			_ = (Resource1)(object)n.d();
		}
		if (num == 0)
		{
			n n = n;
			n = null;
		}
		else if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			try
			{
				j = E.C(intPtr) as j;
				_ = E.C(intPtr) is H;
				nint num7 = intPtr;
				object obj8 = E.C((IntPtr)n.d());
				_ = E.C(checked(num7 * ((obj8 is IntPtr) ? obj8 : null))) is n;
			}
			catch
			{
				Resource1 resource = (Resource1)(object)n.d();
			}
		}
		else
		{
			nuint num8 = num;
			object obj10 = E.C(intPtr);
			if ((int)checked(num8 + ((obj10 is UIntPtr) ? obj10 : null)) == 0)
			{
				_ = E.C(intPtr) is Resource1;
			}
		}
		if (num == 0)
		{
			while (obj != null)
			{
				j = j;
			}
		}
		try
		{
			do
			{
				try
				{
					_ = (CHOOSEFONTFLAGS)j.M(array);
				}
				catch
				{
					nuint num9;
					nint num10;
					checked
					{
						num9 = unchecked((nuint)intPtr) * unchecked((nuint)(nint)(IntPtr)j.M(array));
						num10 = intPtr;
						intPtr = default(IntPtr);
					}
					_ = E.C((nint)(num9 / checked(unchecked((nuint)num10) + unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)j.M(array))))) is CHOOSEFONTFLAGS;
				}
			}
			while ((object)n.d() != null);
		}
		catch
		{
			IAssemblyLoader assemblyLoader = null;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
				{
					_ = (X)j.M(null);
				}
				else
				{
					_ = (IAssemblyLoader)(object)n.d();
				}
			}
		}
		catch
		{
			j = j;
		}
		_ = (AssmeblyLoader)(object)j.M(array);
		return;
		IL_00de:
		e = e;
		e = e;
		_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		assmeblyLoader = assmeblyLoader;
		cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
		cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		assmeblyLoader = null;
		try
		{
			if (E.C(intPtr) is UIntPtr)
			{
				try
				{
					_ = (E)(object)j.M(n.d());
				}
				finally
				{
					_ = (j)(object)n.d();
					_ = (X)n.d();
					_ = (j)(object)n.d();
					H h = default(H);
					goto end_IL_012f;
				}
			}
			_ = E.C(intPtr) is AssmeblyLoader;
			end_IL_012f:;
		}
		finally
		{
			if ((UIntPtr)j.M(null) == (UIntPtr)(nuint)0u)
			{
				j = j;
			}
			goto IL_01cc;
		}
	}
	,
	static void @_002B_0029_003D_007C__002F_0040_007C6()
	{
		//IL_00f9: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got I4
		//IL_01e9: Expected O, but got I4
		//IL_0228: Expected O, but got I4
		//IL_0251: Expected O, but got I4
		//IL_0348: Expected O, but got I4
		//IL_0351: Expected I, but got O
		//IL_0352: Expected O, but got I4
		//IL_03e9: Expected O, but got I4
		//IL_0484: Expected O, but got I4
		//IL_0497: Expected O, but got I4
		//IL_0640: Expected O, but got I4
		//IL_06b1: Expected O, but got I4
		//IL_06c6: Expected O, but got I4
		//IL_06cf: Expected I, but got O
		//IL_06d0: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_0894: Expected O, but got I4
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		if (checked(uIntPtr + uIntPtr) == 0)
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					while ((object)null != null)
					{
						CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
						cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					}
					continue;
				}
				break;
			}
		}
		else
		{
			h = (H)j.M(n.d());
			h = default(H);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		do
		{
			try
			{
				_ = (AssmeblyLoader)(object)j.M(null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (H)n.d();
					intPtr = default(IntPtr);
					intPtr = default(IntPtr);
					_ = E.C(intPtr) is CHOOSEFONTFLAGS;
					x = default(X);
					_003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				else
				{
					array = null;
					CHOOSEFONT obj2 = (CHOOSEFONT)j.M(array);
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = obj2;
				}
				continue;
			}
		}
		while ((object)null != null);
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				_ = (IAssemblyLoader)(object)j.M(array);
			}
			while ((object)null != null);
		}
		UIntPtr intPtr2 = (UIntPtr)n.d();
		_003F val;
		checked
		{
			nuint num = unchecked((nuint)(UIntPtr)n.d()) - uIntPtr;
			object obj3 = E.C(unchecked((nint)((nuint)(nint)(IntPtr)n.d() / (nuint)intPtr)));
			val = num * ((obj3 is UIntPtr) ? obj3 : null);
			uIntPtr = default(UIntPtr);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		if ((int)checked(unchecked((nuint)intPtr2) + (val - uIntPtr)) == 0)
		{
			_ = E.C(intPtr) is _003CPrivateImplementationDetails_003E;
		}
		else
		{
			do
			{
				try
				{
					Resource1 obj4 = E.C(intPtr) as Resource1;
					resource = null;
					resource = obj4;
				}
				catch
				{
					_ = (IAssemblyLoader)(object)n.d();
				}
			}
			while (obj != null);
		}
		if (uIntPtr == 0)
		{
			_ = E.C(intPtr) is j;
			intPtr = default(IntPtr);
			_ = E.C((nint)(checked(unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)n.d())) / (nuint)intPtr)) is _003CModule_003E;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (uIntPtr / uIntPtr / uIntPtr == 0)
		{
			do
			{
				E obj6 = (E)(object)j.M(null);
				e = e;
				e = obj6;
			}
			while ((object)null != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		do
		{
			try
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					assmeblyLoader = assmeblyLoader;
					assmeblyLoader = assmeblyLoader;
				}
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					e = null;
					continue;
				}
				assmeblyLoader = null;
				IAssemblyLoader obj7 = (IAssemblyLoader)(object)n.d();
				assemblyLoader = assemblyLoader;
				assemblyLoader = obj7;
				n = n;
				n = n;
			}
		}
		while (obj != null);
		try
		{
			do
			{
				h = default(H);
				h = h;
			}
			while (obj != null || obj != null);
		}
		finally
		{
			object obj9 = E.C((IntPtr)n.d());
			_003CModule_003E _003CModule_003E = E.C((IntPtr)((obj9 is IntPtr) ? obj9 : null)) as _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			goto IL_0364;
		}
		IL_0364:
		if (uIntPtr == 0 && (UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				_ = (CHOOSEFONT)j.M(array);
			}
		}
		try
		{
			do
			{
				try
				{
					e = e;
				}
				catch
				{
					resource = resource;
				}
			}
			while ((object)n.d() != null);
		}
		catch
		{
			do
			{
				object obj11 = E.C(default(IntPtr));
				x = (X)((obj11 is X) ? obj11 : null);
			}
			while (obj != null);
		}
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / (nuint)(UIntPtr)n.d() == 0)
				{
					_ = (H)j.M(j.M(null));
				}
				else
				{
					x = x;
				}
			}
			finally
			{
				try
				{
					n = n;
				}
				catch
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
				}
				goto end_IL_03fe;
			}
			end_IL_03fe:;
		}
		finally
		{
			intPtr = default(IntPtr);
			if (!(E.C(intPtr) is UIntPtr))
			{
				_ = E.C(intPtr) is E;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
				}
			}
			goto IL_04cf;
		}
		IL_074d:
		_ = (X)n.d();
		x = x;
		IntPtr num2 = (IntPtr)j.M(null);
		intPtr = default(IntPtr);
		if (!(E.C((nint)checked(unchecked((nuint)(nint)num2) - (unchecked((nuint)unchecked((nint)default(IntPtr)) / checked(unchecked((nuint)intPtr) - unchecked((nuint)(nint)(IntPtr)j.M(array)))) - unchecked((nuint)intPtr)))) is UIntPtr))
		{
			if (uIntPtr == 0)
			{
				h = h;
			}
			else
			{
				assmeblyLoader = null;
			}
		}
		checked
		{
			try
			{
				if (uIntPtr - unchecked((nuint)(UIntPtr)n.d() / (nuint)(UIntPtr)n.d()) == 0)
				{
					do
					{
						j j = (j)(object)n.d();
						j = j;
					}
					while (obj != null);
				}
			}
			finally
			{
				do
				{
					resource = (Resource1)(object)n.d();
				}
				while ((object)j.M(n.d()) != null);
				goto IL_0865;
			}
		}
		IL_04cf:
		e = null;
		try
		{
			_ = (X)j.M(null);
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E _003CModule_003E = null;
				}
				else
				{
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					_ = (CHOOSEFONTFLAGS)n.d();
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (checked(uIntPtr - unchecked((nuint)(UIntPtr)n.d()) - uIntPtr) == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				while ((object)n.d() != null)
				{
					resource = (Resource1)(object)j.M(j.M(array));
					_ = (H)j.M(array);
					_ = (_003CPrivateImplementationDetails_003E)(object)n.d();
					_ = (X)j.M(null);
				}
				goto IL_0635;
			}
		}
		try
		{
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		catch
		{
			try
			{
				h = (H)n.d();
			}
			finally
			{
				_ = (j)(object)j.M(null);
				goto end_IL_05f0;
			}
			end_IL_05f0:;
		}
		goto IL_0635;
		IL_0865:
		while ((object)j.M(array) != null)
		{
			_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
			assmeblyLoader = null;
			resource = resource;
			_ = (n)(object)n.d();
		}
		try
		{
			try
			{
				if (uIntPtr == 0)
				{
					_ = E.C((IntPtr)n.d()) is CHOOSEFONTFLAGS;
				}
				else
				{
					_ = (AssmeblyLoader)(object)n.d();
				}
				return;
			}
			catch
			{
				e = null;
				return;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			checked
			{
				if (uIntPtr + unchecked((nuint)(UIntPtr)j.M(null)) == 0)
				{
					if (uIntPtr == 0)
					{
						resource = null;
					}
					else
					{
						cHOOSEFONT = default(CHOOSEFONT);
					}
				}
				return;
			}
		}
		IL_0635:
		while (E.C(intPtr) is object)
		{
			_ = (n)(object)n.d();
			_ = (j)(object)n.d();
		}
		x = x;
		_ = (H)n.d();
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)j.M(array);
			}
		}
		catch
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)n.d()))) is CHOOSEFONTFLAGS;
				}
				finally
				{
					object obj18 = E.C(intPtr);
					_ = E.C((IntPtr)((obj18 is IntPtr) ? obj18 : null)) is j;
					goto end_IL_0685;
				}
			}
			resource = resource;
			end_IL_0685:;
		}
		uIntPtr = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) + uIntPtr == 0)
			{
				resource = (Resource1)(object)n.d();
				goto IL_074d;
			}
			try
			{
				_ = (E)(object)n.d();
			}
			finally
			{
				_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(n.d());
				goto IL_074d;
			}
		}
	}
	,
	static void @_0021_0029_002E_007C_003F_002F_0040_003E14()
	{
		//IL_001a: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_0047: Expected I, but got O
		//IL_0048: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected I, but got O
		//IL_01d6: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_0215: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got I4
		//IL_0410: Expected I4, but got O
		//IL_045c: Expected O, but got I4
		//IL_04c2: Expected O, but got I4
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected I, but got Unknown
		//IL_04f9: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		//IL_05d7: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		if (!(E.C((IntPtr)j.M(n.d())) is UIntPtr))
		{
			do
			{
				object obj = E.C((IntPtr)j.M(n.d()));
				array = j.M(E.C((IntPtr)((obj is IntPtr) ? obj : null)) as byte[]);
				num = (IntPtr)j.M(array);
				if (!(E.C(num) is UIntPtr))
				{
					CHOOSEFONTFLAGS num2 = (CHOOSEFONTFLAGS)n.d();
					cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
					cHOOSEFONTFLAGS = num2;
				}
				else
				{
					_ = E.C(num) is Resource1;
				}
				obj2 = j.M(array);
			}
			while (obj2 != null);
		}
		UIntPtr uIntPtr = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		checked
		{
			if (uIntPtr - unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				while (true)
				{
					if ((object)null != null)
					{
						_003CModule_003E = (_003CModule_003E)(object)j.M(array);
						_003CModule_003E = _003CModule_003E;
					}
					else if ((object)null == null)
					{
						break;
					}
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j j);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		try
		{
			while ((object)null != null)
			{
				if (uIntPtr == 0)
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = cHOOSEFONT;
				}
				else
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = E.C(num) as _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			if (uIntPtr == 0)
			{
				_ = (j)(object)j.M(array);
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr / checked(unchecked((nuint)(UIntPtr)n.d()) - uIntPtr) == 0)
				{
					object obj3 = E.C((nint)checked(unchecked((nuint)(nint)(IntPtr)n.d()) * unchecked((nuint)num)));
					_ = E.C((IntPtr)((obj3 is IntPtr) ? obj3 : null)) is AssmeblyLoader;
					num = default(IntPtr);
					j = E.C(num) as j;
					j = j;
				}
			}
			goto IL_0203;
		}
		IL_0203:
		try
		{
			if (!(E.C((IntPtr)n.d()) is UIntPtr))
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		catch
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					Resource1 resource = (Resource1)(object)n.d();
					resource = resource;
				}
				finally
				{
					num = default(IntPtr);
					_ = E.C(num) is E;
					goto end_IL_022c;
				}
			}
			while ((object)j.M(array) != null)
			{
				_003CModule_003E = _003CModule_003E;
				_ = (H)j.M(array);
			}
			end_IL_022c:;
		}
		do
		{
			try
			{
				while ((object)null != null)
				{
					X x = (X)n.d();
					x = x;
				}
			}
			catch
			{
				cHOOSEFONT = cHOOSEFONT;
			}
		}
		while (obj2 != null);
		do
		{
			_ = (IAssemblyLoader)(object)n.d();
		}
		while (obj2 != null);
		cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		while ((object)j.M(null) != null)
		{
			do
			{
				_ = (X)j.M(j.M(array));
			}
			while ((object)j.M(j.M(n.d())) != null);
		}
		AssmeblyLoader assmeblyLoader = null;
		assmeblyLoader = assmeblyLoader;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		do
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				UIntPtr intPtr = uIntPtr;
				UIntPtr intPtr2 = uIntPtr;
				object obj6 = E.C(num);
				_003F val;
				checked
				{
					val = unchecked((nuint)intPtr2) - ((obj6 is UIntPtr) ? obj6 : null);
					uIntPtr = default(UIntPtr);
				}
				if ((int)checked(unchecked((nuint)intPtr) + unchecked(val / (nuint)uIntPtr)) == 0)
				{
					h = h;
					h = h;
				}
				continue;
			}
			try
			{
				h = (H)j.M(j.M(array));
			}
			finally
			{
				object obj7 = E.C((IntPtr)n.d());
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)((obj7 is CHOOSEFONTFLAGS) ? obj7 : null);
				continue;
			}
		}
		while (obj2 != null);
		j = j;
		_ = (H)j.M(array);
		_ = (_003CModule_003E)(object)n.d();
		cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		num = default(IntPtr);
		_ = E.C(num) is _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		if (uIntPtr == (UIntPtr)(nuint)0u && uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				e = e;
				e = null;
				nuint num3;
				IntPtr intPtr3;
				IntPtr intPtr4;
				object obj8;
				checked
				{
					num3 = unchecked((nuint)num) - unchecked((nuint)unchecked((nint)default(IntPtr)));
					num = default(IntPtr);
					intPtr3 = num;
					intPtr4 = num;
					obj8 = E.C(num);
				}
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(E.C((nint)checked(unchecked(num3 / checked(unchecked((nuint)(nint)intPtr3 / checked(unchecked((nuint)(nint)intPtr4) * ((obj8 is IntPtr) ? obj8 : null) + unchecked((nuint)(nint)(IntPtr)n.d()) + unchecked((nuint)(nint)(IntPtr)j.M(array)))) + unchecked((nuint)(nint)num))) - unchecked((nuint)(nint)(IntPtr)n.d()))) as byte[]);
			}
		}
		while (obj2 != null)
		{
			Resource1 resource = (Resource1)(object)j.M(null);
		}
		_ = (AssmeblyLoader)(object)j.M(null);
		_ = (CHOOSEFONT)j.M(array);
		_ = E.C(default(IntPtr)) is _003CPrivateImplementationDetails_003E;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (IAssemblyLoader)(object)j.M(null);
		}
		try
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (X)n.d();
					return;
				}
				e = e;
				cHOOSEFONT = default(CHOOSEFONT);
				e = null;
				IAssemblyLoader assemblyLoader = null;
				assemblyLoader = null;
			}
			catch
			{
				_ = E.C(default(IntPtr)) is Resource1;
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				assmeblyLoader = assmeblyLoader;
				e = e;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = (j)(object)n.d();
				}
				finally
				{
					j = j;
					continue;
				}
			}
			while (obj2 != null);
		}
	}

}
