using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using h;

namespace h13;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
public struct CHOOSEFONT
{
	public int lStructSize;

	public IntPtr hwndOwner;

	public IntPtr hDC;

	public IntPtr lpLogFont;

	public int iPointSize;

	public int Flags;

	public int rgbColors;

	public IntPtr lCustData;

	public IntPtr lpfnHook;

	public string lpTemplateName;

	public IntPtr hInstance;

	public string lpszStyle;

	public short nFontType;

	private short Q;

	public int nSizeMin;

	public int nSizeMax;

	static void @_002B_002F_002A_007D__002F_002D_002A7()
	{
		//IL_001c: Expected O, but got I4
		//IL_0024: Expected I, but got O
		//IL_002e: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got I4
		//IL_034c: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected I, but got Unknown
		//IL_0553: Expected O, but got I4
		//IL_0596: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		nint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				while (true)
				{
					obj = obj;
					if (obj == null)
					{
						break;
					}
					object obj2 = E.C(default(IntPtr));
					num = (nint)((obj2 is IntPtr) ? obj2 : null);
					_ = E.C(num) is CHOOSEFONTFLAGS;
				}
			}
			catch
			{
				UIntPtr intPtr = (UIntPtr)n.d();
				nuint intPtr2 = num2;
				array = n.d();
				object obj3 = E.C((IntPtr)j.M(array));
				num2 = (nuint)(nint)checked(unchecked((nuint)intPtr) + (intPtr2 + ((obj3 is UIntPtr) ? obj3 : null)));
				if (num2 == 0)
				{
					AssmeblyLoader obj4 = (AssmeblyLoader)(object)j.M(array);
					assmeblyLoader = null;
					assmeblyLoader = obj4;
				}
			}
		}
		catch
		{
			_ = (n)(object)n.d();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		while (E.C(default(IntPtr)) is object)
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					n = n;
					n = null;
				}
			}
		}
		while (obj != null)
		{
			j j = (j)(object)n.d();
			j = j;
		}
		n = n;
		num = default(IntPtr);
		_ = E.C(num) is Resource1;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)n.d();
					assemblyLoader = assemblyLoader;
					assemblyLoader = null;
					assmeblyLoader = (AssmeblyLoader)(object)j.M(null);
					_ = (H)j.M(array);
				}
				else
				{
					_ = (CHOOSEFONT)j.M(null);
				}
			}
		}
		E e = null;
		e = e;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = E.C(num) is H;
				}
				finally
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					goto end_IL_01d6;
				}
			}
			try
			{
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
			}
			finally
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				goto end_IL_01d6;
			}
			end_IL_01d6:;
		}
		catch
		{
			assmeblyLoader = E.C(num) as AssmeblyLoader;
		}
		while (obj != null)
		{
			assemblyLoader = null;
		}
		Resource1 resource = resource;
		resource = null;
		UIntPtr intPtr3 = (UIntPtr)j.M(n.d());
		num2 = default(UIntPtr);
		UIntPtr intPtr4 = num2;
		object obj8 = E.C(num);
		if ((int)checked(unchecked((nuint)intPtr3) + (unchecked((nuint)intPtr4 / ((obj8 is UIntPtr) ? obj8 : null)) - unchecked((nuint)(UIntPtr)j.M(null)))) == 0)
		{
			do
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
					_ = (IAssemblyLoader)(object)n.d();
					e = E.C((IntPtr)n.d()) as E;
					_ = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					assemblyLoader = (IAssemblyLoader)(object)j.M(array);
					continue;
				}
			}
			while (obj != null);
		}
		else
		{
			num = default(IntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			if (!(E.C((nint)checked(unchecked((nuint)num) * unchecked((nuint)num))) is UIntPtr))
			{
				try
				{
					_ = (j)(object)n.d();
					assemblyLoader = null;
					CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
					_003CModule_003E = (_003CModule_003E)(object)j.M(array);
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_03ac;
				}
			}
		}
		goto IL_03ac;
		IL_03ac:
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
				}
				catch
				{
					nint num3 = num;
					num = default(IntPtr);
					_ = E.C((nint)((nuint)num3 / (nuint)num)) is _003CPrivateImplementationDetails_003E;
				}
			}
			catch
			{
				while (true)
				{
					num = default(IntPtr);
					if (E.C((nint)checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)n.d()))) is object)
					{
						_ = (j)(object)n.d();
						continue;
					}
					break;
				}
			}
		}
		else
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				finally
				{
					_ = (X)n.d();
					goto IL_04aa;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = E.C((IntPtr)j.M(null)) is j;
			}
		}
		goto IL_04aa;
		IL_04aa:
		while ((object)null != null)
		{
			assmeblyLoader = (AssmeblyLoader)(object)j.M(null);
		}
		assemblyLoader = (IAssemblyLoader)(object)n.d();
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (true)
				{
					num = default(IntPtr);
					if ((object)j.M(E.C(num) as byte[]) != null)
					{
						_ = (IAssemblyLoader)(object)n.d();
						continue;
					}
					break;
				}
			}
			catch
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					n = n;
				}
				else
				{
					nint intPtr5 = num;
					num = default(IntPtr);
					object obj11 = E.C(num);
					_ = E.C(intPtr5 / ((obj11 is IntPtr) ? obj11 : null) / num) is Resource1;
				}
			}
		}
		resource = null;
		while ((object)null != null)
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (n)(object)j.M(array);
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)n.d();
					_ = E.C(num) is X;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		while ((object)null != null)
		{
			_ = (CHOOSEFONTFLAGS)n.d();
		}
	}

	static void @_002B_0029_003A_007C__0026_002B_005E1()
	{
		//IL_009f: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected I, but got Unknown
		//IL_03f6: Expected O, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected I, but got Unknown
		//IL_0401: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_052a: Expected O, but got I4
		//IL_05b2: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_0629: Expected I, but got O
		//IL_062a: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_0715: Expected O, but got I4
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				assmeblyLoader = assmeblyLoader;
				assmeblyLoader = null;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		finally
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					array = null;
					intPtr = (IntPtr)j.M(j.M(array));
					intPtr = default(IntPtr);
					nint num = intPtr;
					nuint num2;
					object obj2;
					checked
					{
						num2 = unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) + unchecked((nuint)intPtr));
						obj2 = E.C(intPtr);
					}
					_ = E.C((nint)checked(num * (num2 + ((obj2 is IntPtr) ? obj2 : null) - intPtr))) is AssmeblyLoader;
					continue;
				}
				break;
			}
			goto IL_00c6;
		}
		IL_00c6:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		checked
		{
			if (unchecked((nuint)(UIntPtr)j.M(array)) * unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				x = x;
				x = x;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			if (!(E.C((IntPtr)j.M(array)) is UIntPtr))
			{
				_003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			while (obj != null)
			{
				resource = resource;
				resource = resource;
			}
			goto IL_014a;
		}
		IL_037b:
		_ = E.C((IntPtr)n.d()) is X;
		IntPtr intPtr2 = (IntPtr)j.M(array);
		IntPtr intPtr3 = (IntPtr)j.M(array);
		IntPtr num3 = (IntPtr)j.M(null);
		intPtr = default(IntPtr);
		object obj3 = E.C((nint)checked(unchecked((nuint)(nint)intPtr3) * /*isinst with value type is only supported in some contexts*/));
		if (!(E.C((nint)checked(unchecked((nuint)(nint)intPtr2) - ((obj3 is IntPtr) ? obj3 : null))) is UIntPtr) && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			x = default(X);
		}
		_ = E.C((IntPtr)j.M(null)) is CHOOSEFONTFLAGS;
		nuint uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = E.C((IntPtr)j.M(array)) is _003CPrivateImplementationDetails_003E;
				}
				while ((object)null != null);
			}
			finally
			{
				_ = E.C(intPtr) is AssmeblyLoader;
				goto IL_0495;
			}
		}
		goto IL_0495;
		IL_0495:
		do
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				j j = null;
				j = null;
			}
		}
		while ((object)n.d() != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		try
		{
			try
			{
				cHOOSEFONT = (CHOOSEFONT)n.d();
				cHOOSEFONT = cHOOSEFONT;
				e = e;
				cHOOSEFONT = cHOOSEFONT;
			}
			catch
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
					assemblyLoader = E.C(intPtr) as IAssemblyLoader;
					assemblyLoader = assemblyLoader;
					n = n;
					h = h;
				}
			}
		}
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		while (true)
		{
			if (obj != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (H)j.M(array);
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		_003CPrivateImplementationDetails_003E = null;
		try
		{
			try
			{
				_ = E.C((IntPtr)n.d()) is _003CPrivateImplementationDetails_003E;
			}
			finally
			{
				cHOOSEFONT = cHOOSEFONT;
				goto end_IL_05a0;
			}
			end_IL_05a0:;
		}
		catch
		{
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			IntPtr num4 = (IntPtr)n.d();
			intPtr = default(IntPtr);
			object obj7 = E.C((nint)checked(unchecked((nuint)(nint)num4) - (unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)n.d()))));
			if (!(E.C((IntPtr)((obj7 is IntPtr) ? obj7 : null)) is UIntPtr))
			{
				_ = (AssmeblyLoader)(object)n.d();
			}
		}
		else if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			intPtr = default(IntPtr);
			_ = E.C(intPtr) is X;
			_ = (CHOOSEFONTFLAGS)j.M(array);
		}
		try
		{
			try
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
					_003CPrivateImplementationDetails_003E = null;
				}
				finally
				{
					_ = (X)n.d();
					goto end_IL_067f;
				}
				end_IL_067f:;
			}
			finally
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
					_ = (CHOOSEFONT)j.M(null);
					_ = (CHOOSEFONT)j.M(array);
					_ = (Resource1)(object)j.M(array);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)n.d();
					x = (X)j.M(array);
					_ = E.C(intPtr) is _003CModule_003E;
				}
				goto end_IL_067e;
			}
			end_IL_067e:;
		}
		finally
		{
			assemblyLoader = assemblyLoader;
			goto IL_074c;
		}
		IL_014a:
		UIntPtr num5 = (UIntPtr)j.M(array);
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)num5 / checked(uIntPtr - uIntPtr) / (uIntPtr / (nuint)(UIntPtr)j.M(array)))) == 0)
		{
			try
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					e = e;
					e = e;
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
				}
			}
			catch
			{
				e = e;
			}
		}
		else
		{
			resource = resource;
		}
		do
		{
			try
			{
				do
				{
					_003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				while (obj != null);
			}
			catch
			{
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		while (obj != null);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					_ = (CHOOSEFONT)j.M(array);
					h = (H)n.d();
					h = h;
					_ = (IAssemblyLoader)(object)j.M(array);
					_ = (n)(object)n.d();
				}
			}
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
			{
				while ((object)j.M(array) != null)
				{
					assmeblyLoader = assmeblyLoader;
					IntPtr num6 = (IntPtr)j.M(null);
					intPtr = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)(nint)num6) + unchecked((nuint)intPtr))) is H;
				}
			}
			else
			{
				while (E.C((IntPtr)n.d()) is object)
				{
					_003CModule_003E = _003CModule_003E;
					resource = resource;
					_ = (IAssemblyLoader)(object)n.d();
					resource = null;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = E.C(intPtr) is n;
					x = x;
				}
				catch
				{
					n = null;
					n = null;
				}
			}
			goto IL_037b;
		}
		IL_074c:
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (CHOOSEFONT)n.d();
			}
		}
		do
		{
			_ = (H)n.d();
		}
		while ((object)null != null);
	}

	static void @_002B_0029_003A_007C__0026_002B_005E1()
	{
		//IL_009f: Expected O, but got I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected I, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_02d8: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_034f: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03eb: Expected O, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected I, but got Unknown
		//IL_03f6: Expected O, but got I4
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected I, but got Unknown
		//IL_0401: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_0470: Expected O, but got I4
		//IL_048c: Expected O, but got I4
		//IL_052a: Expected O, but got I4
		//IL_05b2: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_0629: Expected I, but got O
		//IL_062a: Expected O, but got I4
		//IL_0668: Expected O, but got I4
		//IL_0715: Expected O, but got I4
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				assmeblyLoader = assmeblyLoader;
				assmeblyLoader = null;
			}
			else if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		finally
		{
			while (true)
			{
				obj = null;
				if (obj != null)
				{
					array = null;
					intPtr = (IntPtr)j.M(j.M(array));
					intPtr = default(IntPtr);
					nint num = intPtr;
					nuint num2;
					object obj2;
					checked
					{
						num2 = unchecked((nuint)intPtr) - (unchecked((nuint)intPtr) + unchecked((nuint)intPtr));
						obj2 = E.C(intPtr);
					}
					_ = E.C((nint)checked(num * (num2 + ((obj2 is IntPtr) ? obj2 : null) - intPtr))) is AssmeblyLoader;
					continue;
				}
				break;
			}
			goto IL_00c6;
		}
		IL_00c6:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out X x);
		checked
		{
			if (unchecked((nuint)(UIntPtr)j.M(array)) * unchecked((nuint)(UIntPtr)n.d()) == 0)
			{
				x = x;
				x = x;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Resource1 resource);
		try
		{
			if (!(E.C((IntPtr)j.M(array)) is UIntPtr))
			{
				_003CModule_003E = null;
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			while (obj != null)
			{
				resource = resource;
				resource = resource;
			}
			goto IL_014a;
		}
		IL_037b:
		_ = E.C((IntPtr)n.d()) is X;
		IntPtr intPtr2 = (IntPtr)j.M(array);
		IntPtr intPtr3 = (IntPtr)j.M(array);
		IntPtr num3 = (IntPtr)j.M(null);
		intPtr = default(IntPtr);
		object obj3 = E.C((nint)checked(unchecked((nuint)(nint)intPtr3) * /*isinst with value type is only supported in some contexts*/));
		if (!(E.C((nint)checked(unchecked((nuint)(nint)intPtr2) - ((obj3 is IntPtr) ? obj3 : null))) is UIntPtr) && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			x = default(X);
		}
		_ = E.C((IntPtr)j.M(null)) is CHOOSEFONTFLAGS;
		nuint uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				do
				{
					_ = E.C((IntPtr)j.M(array)) is _003CPrivateImplementationDetails_003E;
				}
				while ((object)null != null);
			}
			finally
			{
				_ = E.C(intPtr) is AssmeblyLoader;
				goto IL_0495;
			}
		}
		goto IL_0495;
		IL_0495:
		do
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				j j = null;
				j = null;
			}
		}
		while ((object)n.d() != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out E e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out H h);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		try
		{
			try
			{
				cHOOSEFONT = (CHOOSEFONT)n.d();
				cHOOSEFONT = cHOOSEFONT;
				e = e;
				cHOOSEFONT = cHOOSEFONT;
			}
			catch
			{
				assmeblyLoader = assmeblyLoader;
			}
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
					assemblyLoader = E.C(intPtr) as IAssemblyLoader;
					assemblyLoader = assemblyLoader;
					n = n;
					h = h;
				}
			}
		}
		CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		while (true)
		{
			if (obj != null)
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (H)j.M(array);
				}
			}
			else if (obj == null)
			{
				break;
			}
		}
		_003CPrivateImplementationDetails_003E = null;
		try
		{
			try
			{
				_ = E.C((IntPtr)n.d()) is _003CPrivateImplementationDetails_003E;
			}
			finally
			{
				cHOOSEFONT = cHOOSEFONT;
				goto end_IL_05a0;
			}
			end_IL_05a0:;
		}
		catch
		{
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
		{
			IntPtr num4 = (IntPtr)n.d();
			intPtr = default(IntPtr);
			object obj7 = E.C((nint)checked(unchecked((nuint)(nint)num4) - (unchecked((nuint)intPtr) + unchecked((nuint)(nint)(IntPtr)n.d()))));
			if (!(E.C((IntPtr)((obj7 is IntPtr) ? obj7 : null)) is UIntPtr))
			{
				_ = (AssmeblyLoader)(object)n.d();
			}
		}
		else if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			intPtr = default(IntPtr);
			_ = E.C(intPtr) is X;
			_ = (CHOOSEFONTFLAGS)j.M(array);
		}
		try
		{
			try
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
					_003CPrivateImplementationDetails_003E = null;
				}
				finally
				{
					_ = (X)n.d();
					goto end_IL_067f;
				}
				end_IL_067f:;
			}
			finally
			{
				try
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)j.M(array);
					_ = (CHOOSEFONT)j.M(null);
					_ = (CHOOSEFONT)j.M(array);
					_ = (Resource1)(object)j.M(array);
				}
				catch
				{
					_003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)n.d();
					x = (X)j.M(array);
					_ = E.C(intPtr) is _003CModule_003E;
				}
				goto end_IL_067e;
			}
			end_IL_067e:;
		}
		finally
		{
			assemblyLoader = assemblyLoader;
			goto IL_074c;
		}
		IL_014a:
		UIntPtr num5 = (UIntPtr)j.M(array);
		uIntPtr = default(UIntPtr);
		if (checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)num5 / checked(uIntPtr - uIntPtr) / (uIntPtr / (nuint)(UIntPtr)j.M(array)))) == 0)
		{
			try
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					e = e;
					e = e;
				}
				else
				{
					assmeblyLoader = assmeblyLoader;
				}
			}
			catch
			{
				e = e;
			}
		}
		else
		{
			resource = resource;
		}
		do
		{
			try
			{
				do
				{
					_003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				while (obj != null);
			}
			catch
			{
				cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)j.M(array);
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
			}
		}
		while (obj != null);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)null != null)
				{
					_ = (CHOOSEFONT)j.M(array);
					h = (H)n.d();
					h = h;
					_ = (IAssemblyLoader)(object)j.M(array);
					_ = (n)(object)n.d();
				}
			}
		}
		while (obj != null);
		try
		{
			if ((UIntPtr)j.M(array) == (UIntPtr)(nuint)0u)
			{
				while ((object)j.M(array) != null)
				{
					assmeblyLoader = assmeblyLoader;
					IntPtr num6 = (IntPtr)j.M(null);
					intPtr = default(IntPtr);
					_ = E.C((nint)checked(unchecked((nuint)(nint)num6) + unchecked((nuint)intPtr))) is H;
				}
			}
			else
			{
				while (E.C((IntPtr)n.d()) is object)
				{
					_003CModule_003E = _003CModule_003E;
					resource = resource;
					_ = (IAssemblyLoader)(object)n.d();
					resource = null;
				}
			}
		}
		finally
		{
			while (obj != null)
			{
				try
				{
					_ = E.C(intPtr) is n;
					x = x;
				}
				catch
				{
					n = null;
					n = null;
				}
			}
			goto IL_037b;
		}
		IL_074c:
		while (obj != null)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (CHOOSEFONT)n.d();
			}
		}
		do
		{
			_ = (H)n.d();
		}
		while ((object)null != null);
	}

	static void @_002B_002F_002A_007D__002F_002D_002A7()
	{
		//IL_001c: Expected O, but got I4
		//IL_0024: Expected I, but got O
		//IL_002e: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected I, but got Unknown
		//IL_0103: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_02b6: Expected O, but got I4
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got I4
		//IL_034c: Expected O, but got I4
		//IL_03df: Expected O, but got I4
		//IL_041e: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected I, but got Unknown
		//IL_0553: Expected O, but got I4
		//IL_0596: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		nint num;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out UIntPtr num2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out AssmeblyLoader assmeblyLoader);
		try
		{
			try
			{
				while (true)
				{
					obj = obj;
					if (obj == null)
					{
						break;
					}
					object obj2 = E.C(default(IntPtr));
					num = (nint)((obj2 is IntPtr) ? obj2 : null);
					_ = E.C(num) is CHOOSEFONTFLAGS;
				}
			}
			catch
			{
				UIntPtr intPtr = (UIntPtr)n.d();
				nuint intPtr2 = num2;
				array = n.d();
				object obj3 = E.C((IntPtr)j.M(array));
				num2 = (nuint)(nint)checked(unchecked((nuint)intPtr) + (intPtr2 + ((obj3 is UIntPtr) ? obj3 : null)));
				if (num2 == 0)
				{
					AssmeblyLoader obj4 = (AssmeblyLoader)(object)j.M(array);
					assmeblyLoader = null;
					assmeblyLoader = obj4;
				}
			}
		}
		catch
		{
			_ = (n)(object)n.d();
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n n);
		while (E.C(default(IntPtr)) is object)
		{
			if (num2 == 0)
			{
				num2 = default(UIntPtr);
				if (num2 == 0)
				{
					n = n;
					n = null;
				}
			}
		}
		while (obj != null)
		{
			j j = (j)(object)n.d();
			j = j;
		}
		n = n;
		num = default(IntPtr);
		_ = E.C(num) is Resource1;
		num2 = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IAssemblyLoader assemblyLoader);
		if (num2 == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				if (num2 == (UIntPtr)(nuint)0u)
				{
					_ = (CHOOSEFONTFLAGS)n.d();
					assemblyLoader = assemblyLoader;
					assemblyLoader = null;
					assmeblyLoader = (AssmeblyLoader)(object)j.M(null);
					_ = (H)j.M(array);
				}
				else
				{
					_ = (CHOOSEFONT)j.M(null);
				}
			}
		}
		E e = null;
		e = e;
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = E.C(num) is H;
				}
				finally
				{
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
					goto end_IL_01d6;
				}
			}
			try
			{
				_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = (_003CPrivateImplementationDetails_003E)(object)j.M(null);
			}
			finally
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
				goto end_IL_01d6;
			}
			end_IL_01d6:;
		}
		catch
		{
			assmeblyLoader = E.C(num) as AssmeblyLoader;
		}
		while (obj != null)
		{
			assemblyLoader = null;
		}
		Resource1 resource = resource;
		resource = null;
		UIntPtr intPtr3 = (UIntPtr)j.M(n.d());
		num2 = default(UIntPtr);
		UIntPtr intPtr4 = num2;
		object obj8 = E.C(num);
		if ((int)checked(unchecked((nuint)intPtr3) + (unchecked((nuint)intPtr4 / ((obj8 is UIntPtr) ? obj8 : null)) - unchecked((nuint)(UIntPtr)j.M(null)))) == 0)
		{
			do
			{
				try
				{
					_ = (AssmeblyLoader)(object)n.d();
					_ = (IAssemblyLoader)(object)n.d();
					e = E.C((IntPtr)n.d()) as E;
					_ = (AssmeblyLoader)(object)n.d();
				}
				finally
				{
					assemblyLoader = (IAssemblyLoader)(object)j.M(array);
					continue;
				}
			}
			while (obj != null);
		}
		else
		{
			num = default(IntPtr);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
			if (!(E.C((nint)checked(unchecked((nuint)num) * unchecked((nuint)num))) is UIntPtr))
			{
				try
				{
					_ = (j)(object)n.d();
					assemblyLoader = null;
					CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
					_003CModule_003E = (_003CModule_003E)(object)j.M(array);
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto IL_03ac;
				}
			}
		}
		goto IL_03ac;
		IL_03ac:
		if (num2 == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					assmeblyLoader = assmeblyLoader;
				}
				catch
				{
					nint num3 = num;
					num = default(IntPtr);
					_ = E.C((nint)((nuint)num3 / (nuint)num)) is _003CPrivateImplementationDetails_003E;
				}
			}
			catch
			{
				while (true)
				{
					num = default(IntPtr);
					if (E.C((nint)checked(unchecked((nuint)num) - unchecked((nuint)(nint)(IntPtr)n.d()))) is object)
					{
						_ = (j)(object)n.d();
						continue;
					}
					break;
				}
			}
		}
		else
		{
			if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (AssmeblyLoader)(object)j.M(array);
				}
				finally
				{
					_ = (X)n.d();
					goto IL_04aa;
				}
			}
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = E.C((IntPtr)j.M(null)) is j;
			}
		}
		goto IL_04aa;
		IL_04aa:
		while ((object)null != null)
		{
			assmeblyLoader = (AssmeblyLoader)(object)j.M(null);
		}
		assemblyLoader = (IAssemblyLoader)(object)n.d();
		if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
		{
			try
			{
				while (true)
				{
					num = default(IntPtr);
					if ((object)j.M(E.C(num) as byte[]) != null)
					{
						_ = (IAssemblyLoader)(object)n.d();
						continue;
					}
					break;
				}
			}
			catch
			{
				if ((UIntPtr)n.d() == (UIntPtr)(nuint)0u)
				{
					n = n;
				}
				else
				{
					nint intPtr5 = num;
					num = default(IntPtr);
					object obj11 = E.C(num);
					_ = E.C(intPtr5 / ((obj11 is IntPtr) ? obj11 : null) / num) is Resource1;
				}
			}
		}
		resource = null;
		while ((object)null != null)
		{
			while (true)
			{
				if (obj != null)
				{
					_ = (n)(object)j.M(array);
					CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)n.d();
					_ = E.C(num) is X;
				}
				else if (obj == null)
				{
					break;
				}
			}
		}
		while ((object)null != null)
		{
			_ = (CHOOSEFONTFLAGS)n.d();
		}
	}
}
