using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using l;

namespace _310;

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

	private short g;

	public int nSizeMin;

	public int nSizeMax;

	static void _002B_005D_007D_003A_003D_0025_005D_003A_005B9()
	{
		//IL_006f: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected I, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_0088: Expected I, but got O
		//IL_0089: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_02a1: Expected I, but got O
		//IL_02a2: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_03ec: Expected O, but got I4
		//IL_0445: Expected O, but got I4
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected I, but got Unknown
		//IL_046c: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			do
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				intPtr = intPtr;
				intPtr = default(IntPtr);
				object obj = y.t(intPtr);
				object obj2 = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) + (((obj is IntPtr) ? obj : null) + unchecked((nuint)(nint)intPtr))));
				_ = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is _003CPrivateImplementationDetails_003E;
				_ = y.t(intPtr) is y;
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		F f = null;
		f = f;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		while (obj3 != null)
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
				finally
				{
					IAssemblyLoader assemblyLoader = null;
					assemblyLoader = assemblyLoader;
					goto end_IL_00c3;
				}
				end_IL_00c3:;
			}
			finally
			{
				while (y.t(intPtr) is object)
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = default(CHOOSEFONT);
					f = f;
					array = null;
					_ = (CHOOSEFONTFLAGS)T.h(array);
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while ((object)null != null)
		{
			cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		_ = (CHOOSEFONTFLAGS)F.A();
		r r = (r)F.A();
		r = default(r);
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is y;
		_ = (Resource1)(object)F.A();
		_ = (IAssemblyLoader)(object)F.A();
		Resource1 resource = resource;
		resource = resource;
		f = f;
		_ = (AssmeblyLoader)(object)F.A();
		try
		{
			try
			{
				while ((object)F.A() != null)
				{
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				goto end_IL_0202;
			}
			end_IL_0202:;
		}
		catch
		{
			r = r;
		}
		nuint num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)F.A() != (UIntPtr)(nuint)0u)
			{
				try
				{
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = cHOOSEFONT;
					_ = (CHOOSEFONT)T.h(null);
				}
				finally
				{
					T t = null;
					t = t;
					goto IL_038b;
				}
			}
			try
			{
				y y = null;
				y = y;
			}
			catch
			{
				intPtr = default(IntPtr);
				object obj5 = y.t(intPtr);
				_ = y.t((IntPtr)((obj5 is IntPtr) ? obj5 : null)) is h;
			}
		}
		goto IL_038b;
		IL_038b:
		while (obj3 != null)
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)F.A() / num) * unchecked((nuint)(UIntPtr)T.h(array))) == 0)
				{
					_ = (Resource1)(object)T.h(array);
					r = r;
					object obj7 = y.t((IntPtr)T.h(array));
					cHOOSEFONT = (CHOOSEFONT)((obj7 is CHOOSEFONT) ? obj7 : null);
				}
				else
				{
					intPtr = default(IntPtr);
					AssmeblyLoader assmeblyLoader = y.t(intPtr) as AssmeblyLoader;
					assmeblyLoader = null;
				}
			}
			finally
			{
				resource = resource;
				continue;
			}
		}
		h h;
		while (obj3 != null)
		{
			if (num == 0)
			{
				checked
				{
					if (unchecked(num / num) * unchecked((nuint)(UIntPtr)T.h(null)) == 0)
					{
						f = f;
						_ = (h)T.h(null);
						continue;
					}
					h obj8 = (h)F.A();
					object obj9 = y.t(intPtr);
					h = (h)((obj9 is h) ? obj9 : null);
					h = obj8;
				}
				_ = (CHOOSEFONTFLAGS)F.A();
			}
		}
		IntPtr intPtr2 = (IntPtr)F.A();
		IntPtr intPtr3 = (IntPtr)F.A();
		intPtr = default(IntPtr);
		object obj10 = y.t(intPtr);
		h = (h)T.h(y.t((nint)((nuint)(nint)intPtr2 / checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - (unchecked((nuint)(nint)intPtr3) - ((obj10 is IntPtr) ? obj10 : null)) * unchecked((nuint)(nint)intPtr) * unchecked((nuint)(nint)(IntPtr)T.h(F.A()))))) as byte[]);
		cHOOSEFONT = cHOOSEFONT;
		_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
		num = default(UIntPtr);
		if (checked(num - num) == 0)
		{
			try
			{
				try
				{
					h = h;
				}
				finally
				{
					IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)F.A();
					goto end_IL_04a9;
				}
				end_IL_04a9:;
			}
			finally
			{
				do
				{
					_ = (h)T.h(array);
				}
				while ((object)T.h(F.A()) != null);
				goto IL_052b;
			}
		}
		try
		{
			r = default(r);
		}
		catch
		{
			_ = (AssmeblyLoader)(object)F.A();
		}
		goto IL_052b;
		IL_052b:
		do
		{
			_ = (IAssemblyLoader)(object)T.h(array);
		}
		while (obj3 != null);
		_ = (CHOOSEFONTFLAGS)T.h(null);
	}

	static void _007C_0021_0029_002D_0025_003E_005D_0040_002D3()
	{
		//IL_00cb: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected I, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_030d: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected I, but got Unknown
		//IL_03df: Expected O, but got I4
		//IL_044a: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected I, but got Unknown
		//IL_053b: Expected O, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got I4
		//IL_0651: Expected I, but got O
		//IL_0652: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_06f0: Expected O, but got I4
		//IL_0722: Expected O, but got I4
		byte[] array = null;
		UIntPtr uIntPtr = (UIntPtr)T.h(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (AssmeblyLoader)(object)T.h(array);
			_ = (CHOOSEFONTFLAGS)T.h(T.h(array));
			r = r;
			r = default(r);
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			nint intPtr = num;
			num = default(IntPtr);
			nint num2 = num;
			nuint num3;
			object obj;
			checked
			{
				num3 = unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)T.h(T.h(array)));
				obj = y.t(default(IntPtr));
			}
			num = (nint)(intPtr / checked(num2 + unchecked(num3 / checked(((obj is IntPtr) ? obj : null) + unchecked((nuint)(nint)(IntPtr)T.h(null))))));
			num = default(IntPtr);
			_ = y.t(num) is _003CModule_003E;
			_ = y.t(num) is CHOOSEFONTFLAGS;
			t = (T)(object)T.h(array);
			t = t;
			F obj2 = (F)(object)T.h(array);
			f = (F)(object)T.h(null);
			f = obj2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj3 = y.t((IntPtr)F.A()) as object;
				if (obj3 != null)
				{
					r = (r)T.h(null);
					y = y;
					y = y;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				while ((object)F.A() != null)
				{
					y = y.t((IntPtr)T.h(y.t((IntPtr)F.A()) as byte[])) as y;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		_003CModule_003E _003CModule_003E;
		try
		{
			while ((object)T.h(array) != null)
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = default(CHOOSEFONT);
				}
				else
				{
					t = t;
				}
			}
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					AssmeblyLoader obj4 = y.t(num) as AssmeblyLoader;
					AssmeblyLoader assmeblyLoader = assmeblyLoader;
					assmeblyLoader = obj4;
				}
				else
				{
					_ = (r)T.h(T.h(array));
				}
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)(object)F.A();
				_003CModule_003E = null;
				y = (y)(object)F.A();
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = null;
				goto IL_033e;
			}
		}
		IL_05bb:
		try
		{
			while (obj3 != null)
			{
				object obj5 = y.t(num);
				if ((int)(checked(unchecked((nuint)default(UIntPtr)) - ((obj5 is UIntPtr) ? obj5 : null)) / checked(unchecked((nuint)(UIntPtr)T.h(F.A())) + unchecked((nuint)(UIntPtr)F.A()))) == 0)
				{
					_ = (F)(object)T.h(array);
				}
				else
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			object obj6 = y.t((nint)((nuint)num / (nuint)(nint)(IntPtr)F.A()));
			_ = y.t((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is CHOOSEFONT;
			AssmeblyLoader assmeblyLoader = (AssmeblyLoader)(object)T.h(array);
			_ = (CHOOSEFONTFLAGS)T.h(null);
			goto IL_072d;
		}
		IL_072d:
		while ((object)T.h(null) != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
				}
				else
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(T.h(array));
				}
			}
			finally
			{
				try
				{
					CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)F.A();
					num = default(IntPtr);
					_ = (F)(object)T.h(y.t(num) as byte[]);
					r = r;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
					_ = y.t(num) is F;
				}
				continue;
			}
		}
		return;
		IL_033e:
		while (obj3 != null)
		{
			try
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)T.h(null);
				f = f;
				_ = (h)T.h(y.t((IntPtr)T.h(array)) as byte[]);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					AssmeblyLoader assmeblyLoader = null;
				}
				continue;
			}
		}
		try
		{
			num = default(IntPtr);
			_ = y.t(num) is r;
		}
		finally
		{
			_ = (IAssemblyLoader)(object)F.A();
			goto IL_0375;
		}
		IL_0375:
		Resource1 resource = resource;
		resource = resource;
		if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					num = default(IntPtr);
					nint intPtr2 = num;
					num = default(IntPtr);
					object obj8 = y.t(num);
					_ = y.t(intPtr2 / ((obj8 is IntPtr) ? obj8 : null) / num) is _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					resource = null;
					r = r;
				}
				catch
				{
					_ = (Resource1)(object)T.h(null);
				}
				goto IL_0411;
			}
		}
		goto IL_0411;
		IL_0411:
		_ = (CHOOSEFONTFLAGS)T.h(null);
		do
		{
			t = null;
		}
		while ((object)null != null);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = y.t(num) is IAssemblyLoader;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_042b;
				}
			}
			end_IL_042b:;
		}
		catch
		{
			f = null;
		}
		while (obj3 != null)
		{
			try
			{
				try
				{
					_ = y.t(num) is h;
				}
				finally
				{
					t = t;
					goto end_IL_0475;
				}
				end_IL_0475:;
			}
			catch
			{
				_ = (r)T.h(null);
			}
		}
		_ = (AssmeblyLoader)(object)T.h(array);
		t = null;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
			while ((object)T.h(array) != null)
			{
				num = default(IntPtr);
				nuint num4 = (nuint)num / (nuint)(nint)(IntPtr)T.h(null);
				object obj12 = y.t(num);
				_003F val = checked(num4 * ((obj12 is IntPtr) ? obj12 : null));
				num = default(IntPtr);
				nint num5 = num;
				nint num6 = num;
				num = default(IntPtr);
				object obj13 = y.t((IntPtr)checked(val * ((unchecked((nuint)num5) - (unchecked((nuint)num6) + unchecked((nuint)num))) * unchecked((nuint)num) - unchecked((nuint)num))));
				if ((int)checked(unchecked((nuint)default(UIntPtr)) * ((obj13 is UIntPtr) ? obj13 : null)) == 0)
				{
					h = h;
					h = default(h);
				}
				else
				{
					y = y;
				}
			}
		}
		finally
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = y.t((IntPtr)T.h(array)) is CHOOSEFONT;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
			goto IL_05bb;
		}
	}

	static void _007C_0021_0029_002D_0025_003E_005D_0040_002D3()
	{
		//IL_00cb: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected I, but got Unknown
		//IL_00f6: Expected O, but got I4
		//IL_0105: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_030d: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected I, but got Unknown
		//IL_03df: Expected O, but got I4
		//IL_044a: Expected O, but got I4
		//IL_0481: Expected O, but got I4
		//IL_0503: Expected O, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected I, but got Unknown
		//IL_053b: Expected O, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got I4
		//IL_0651: Expected I, but got O
		//IL_0652: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_06f0: Expected O, but got I4
		//IL_0722: Expected O, but got I4
		byte[] array = null;
		UIntPtr uIntPtr = (UIntPtr)T.h(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r r);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (AssmeblyLoader)(object)T.h(array);
			_ = (CHOOSEFONTFLAGS)T.h(T.h(array));
			r = r;
			r = default(r);
			CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out F f);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out T t);
		if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
		{
			nint intPtr = num;
			num = default(IntPtr);
			nint num2 = num;
			nuint num3;
			object obj;
			checked
			{
				num3 = unchecked((nuint)num) + unchecked((nuint)(nint)(IntPtr)T.h(T.h(array)));
				obj = y.t(default(IntPtr));
			}
			num = (nint)(intPtr / checked(num2 + unchecked(num3 / checked(((obj is IntPtr) ? obj : null) + unchecked((nuint)(nint)(IntPtr)T.h(null))))));
			num = default(IntPtr);
			_ = y.t(num) is _003CModule_003E;
			_ = y.t(num) is CHOOSEFONTFLAGS;
			t = (T)(object)T.h(array);
			t = t;
			F obj2 = (F)(object)T.h(array);
			f = (F)(object)T.h(null);
			f = obj2;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y y);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj3 = y.t((IntPtr)F.A()) as object;
				if (obj3 != null)
				{
					r = (r)T.h(null);
					y = y;
					y = y;
				}
				else if (obj3 == null)
				{
					break;
				}
			}
		}
		else
		{
			while (obj3 != null)
			{
				while ((object)F.A() != null)
				{
					y = y.t((IntPtr)T.h(y.t((IntPtr)F.A()) as byte[])) as y;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E);
		_003CModule_003E _003CModule_003E;
		try
		{
			while ((object)T.h(array) != null)
			{
				if ((UIntPtr)F.A() == (UIntPtr)(nuint)0u)
				{
					CHOOSEFONT cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = default(CHOOSEFONT);
				}
				else
				{
					t = t;
				}
			}
		}
		finally
		{
			try
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					AssmeblyLoader obj4 = y.t(num) as AssmeblyLoader;
					AssmeblyLoader assmeblyLoader = assmeblyLoader;
					assmeblyLoader = obj4;
				}
				else
				{
					_ = (r)T.h(T.h(array));
				}
			}
			finally
			{
				_003CModule_003E = (_003CModule_003E)(object)F.A();
				_003CModule_003E = null;
				y = (y)(object)F.A();
				_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				_003CPrivateImplementationDetails_003E = null;
				goto IL_033e;
			}
		}
		IL_05bb:
		try
		{
			while (obj3 != null)
			{
				object obj5 = y.t(num);
				if ((int)(checked(unchecked((nuint)default(UIntPtr)) - ((obj5 is UIntPtr) ? obj5 : null)) / checked(unchecked((nuint)(UIntPtr)T.h(F.A())) + unchecked((nuint)(UIntPtr)F.A()))) == 0)
				{
					_ = (F)(object)T.h(array);
				}
				else
				{
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
			}
		}
		finally
		{
			object obj6 = y.t((nint)((nuint)num / (nuint)(nint)(IntPtr)F.A()));
			_ = y.t((IntPtr)((obj6 is IntPtr) ? obj6 : null)) is CHOOSEFONT;
			AssmeblyLoader assmeblyLoader = (AssmeblyLoader)(object)T.h(array);
			_ = (CHOOSEFONTFLAGS)T.h(null);
			goto IL_072d;
		}
		IL_072d:
		while ((object)T.h(null) != null)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = y.t((IntPtr)F.A()) is IAssemblyLoader;
				}
				else
				{
					_ = (_003CPrivateImplementationDetails_003E)(object)T.h(T.h(array));
				}
			}
			finally
			{
				try
				{
					CHOOSEFONT cHOOSEFONT = (CHOOSEFONT)F.A();
					num = default(IntPtr);
					_ = (F)(object)T.h(y.t(num) as byte[]);
					r = r;
				}
				catch
				{
					_ = (AssmeblyLoader)(object)F.A();
					_ = y.t(num) is F;
				}
				continue;
			}
		}
		return;
		IL_033e:
		while (obj3 != null)
		{
			try
			{
				CHOOSEFONTFLAGS cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)T.h(null);
				f = f;
				_ = (h)T.h(y.t((IntPtr)T.h(array)) as byte[]);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					AssmeblyLoader assmeblyLoader = null;
				}
				continue;
			}
		}
		try
		{
			num = default(IntPtr);
			_ = y.t(num) is r;
		}
		finally
		{
			_ = (IAssemblyLoader)(object)F.A();
			goto IL_0375;
		}
		IL_0375:
		Resource1 resource = resource;
		resource = resource;
		if ((UIntPtr)T.h(array) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					num = default(IntPtr);
					nint intPtr2 = num;
					num = default(IntPtr);
					object obj8 = y.t(num);
					_ = y.t(intPtr2 / ((obj8 is IntPtr) ? obj8 : null) / num) is _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					resource = null;
					r = r;
				}
				catch
				{
					_ = (Resource1)(object)T.h(null);
				}
				goto IL_0411;
			}
		}
		goto IL_0411;
		IL_0411:
		_ = (CHOOSEFONTFLAGS)T.h(null);
		do
		{
			t = null;
		}
		while ((object)null != null);
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = y.t(num) is IAssemblyLoader;
				}
				finally
				{
					_003CModule_003E = _003CModule_003E;
					goto end_IL_042b;
				}
			}
			end_IL_042b:;
		}
		catch
		{
			f = null;
		}
		while (obj3 != null)
		{
			try
			{
				try
				{
					_ = y.t(num) is h;
				}
				finally
				{
					t = t;
					goto end_IL_0475;
				}
				end_IL_0475:;
			}
			catch
			{
				_ = (r)T.h(null);
			}
		}
		_ = (AssmeblyLoader)(object)T.h(array);
		t = null;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out h h);
			while ((object)T.h(array) != null)
			{
				num = default(IntPtr);
				nuint num4 = (nuint)num / (nuint)(nint)(IntPtr)T.h(null);
				object obj12 = y.t(num);
				_003F val = checked(num4 * ((obj12 is IntPtr) ? obj12 : null));
				num = default(IntPtr);
				nint num5 = num;
				nint num6 = num;
				num = default(IntPtr);
				object obj13 = y.t((IntPtr)checked(val * ((unchecked((nuint)num5) - (unchecked((nuint)num6) + unchecked((nuint)num))) * unchecked((nuint)num) - unchecked((nuint)num))));
				if ((int)checked(unchecked((nuint)default(UIntPtr)) * ((obj13 is UIntPtr) ? obj13 : null)) == 0)
				{
					h = h;
					h = default(h);
				}
				else
				{
					y = y;
				}
			}
		}
		finally
		{
			while (true)
			{
				if (obj3 != null)
				{
					_ = y.t((IntPtr)T.h(array)) is CHOOSEFONT;
				}
				else if ((object)null == null)
				{
					break;
				}
			}
			goto IL_05bb;
		}
	}

	static void _002B_005D_007D_003A_003D_0025_005D_003A_005B9()
	{
		//IL_006f: Expected O, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected I, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_0088: Expected I, but got O
		//IL_0089: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_02a1: Expected I, but got O
		//IL_02a2: Expected O, but got I4
		//IL_034a: Expected O, but got I4
		//IL_036d: Expected O, but got I4
		//IL_03ec: Expected O, but got I4
		//IL_0445: Expected O, but got I4
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected I, but got Unknown
		//IL_046c: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
		if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
		{
			do
			{
				_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
				intPtr = intPtr;
				intPtr = default(IntPtr);
				object obj = y.t(intPtr);
				object obj2 = y.t((nint)checked(unchecked((nuint)unchecked((nint)default(IntPtr))) + (((obj is IntPtr) ? obj : null) + unchecked((nuint)(nint)intPtr))));
				_ = y.t((IntPtr)((obj2 is IntPtr) ? obj2 : null)) is _003CPrivateImplementationDetails_003E;
				_ = y.t(intPtr) is y;
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		F f = null;
		f = f;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte[] array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONT cHOOSEFONT);
		while (obj3 != null)
		{
			try
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
				finally
				{
					IAssemblyLoader assemblyLoader = null;
					assemblyLoader = assemblyLoader;
					goto end_IL_00c3;
				}
				end_IL_00c3:;
			}
			finally
			{
				while (y.t(intPtr) is object)
				{
					cHOOSEFONT = cHOOSEFONT;
					cHOOSEFONT = default(CHOOSEFONT);
					f = f;
					array = null;
					_ = (CHOOSEFONTFLAGS)T.h(array);
					_003CPrivateImplementationDetails_003E _003CPrivateImplementationDetails_003E = null;
					_003CPrivateImplementationDetails_003E = _003CPrivateImplementationDetails_003E;
				}
				continue;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out CHOOSEFONTFLAGS cHOOSEFONTFLAGS);
		while ((object)null != null)
		{
			cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
			cHOOSEFONTFLAGS = default(CHOOSEFONTFLAGS);
		}
		_ = (CHOOSEFONTFLAGS)F.A();
		r r = (r)F.A();
		r = default(r);
		intPtr = default(IntPtr);
		_ = y.t(intPtr) is y;
		_ = (Resource1)(object)F.A();
		_ = (IAssemblyLoader)(object)F.A();
		Resource1 resource = resource;
		resource = resource;
		f = f;
		_ = (AssmeblyLoader)(object)F.A();
		try
		{
			try
			{
				while ((object)F.A() != null)
				{
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = cHOOSEFONT;
				}
			}
			finally
			{
				cHOOSEFONTFLAGS = cHOOSEFONTFLAGS;
				goto end_IL_0202;
			}
			end_IL_0202:;
		}
		catch
		{
			r = r;
		}
		nuint num = default(UIntPtr);
		if (num == 0)
		{
			if ((UIntPtr)F.A() != (UIntPtr)(nuint)0u)
			{
				try
				{
					cHOOSEFONTFLAGS = (CHOOSEFONTFLAGS)F.A();
					cHOOSEFONT = default(CHOOSEFONT);
					cHOOSEFONT = cHOOSEFONT;
					_ = (CHOOSEFONT)T.h(null);
				}
				finally
				{
					T t = null;
					t = t;
					goto IL_038b;
				}
			}
			try
			{
				y y = null;
				y = y;
			}
			catch
			{
				intPtr = default(IntPtr);
				object obj5 = y.t(intPtr);
				_ = y.t((IntPtr)((obj5 is IntPtr) ? obj5 : null)) is h;
			}
		}
		goto IL_038b;
		IL_038b:
		while (obj3 != null)
		{
			try
			{
				if (checked(unchecked((nuint)(UIntPtr)F.A() / num) * unchecked((nuint)(UIntPtr)T.h(array))) == 0)
				{
					_ = (Resource1)(object)T.h(array);
					r = r;
					object obj7 = y.t((IntPtr)T.h(array));
					cHOOSEFONT = (CHOOSEFONT)((obj7 is CHOOSEFONT) ? obj7 : null);
				}
				else
				{
					intPtr = default(IntPtr);
					AssmeblyLoader assmeblyLoader = y.t(intPtr) as AssmeblyLoader;
					assmeblyLoader = null;
				}
			}
			finally
			{
				resource = resource;
				continue;
			}
		}
		h h;
		while (obj3 != null)
		{
			if (num == 0)
			{
				checked
				{
					if (unchecked(num / num) * unchecked((nuint)(UIntPtr)T.h(null)) == 0)
					{
						f = f;
						_ = (h)T.h(null);
						continue;
					}
					h obj8 = (h)F.A();
					object obj9 = y.t(intPtr);
					h = (h)((obj9 is h) ? obj9 : null);
					h = obj8;
				}
				_ = (CHOOSEFONTFLAGS)F.A();
			}
		}
		IntPtr intPtr2 = (IntPtr)F.A();
		IntPtr intPtr3 = (IntPtr)F.A();
		intPtr = default(IntPtr);
		object obj10 = y.t(intPtr);
		h = (h)T.h(y.t((nint)((nuint)(nint)intPtr2 / checked(unchecked((nuint)unchecked((nint)default(IntPtr))) - (unchecked((nuint)(nint)intPtr3) - ((obj10 is IntPtr) ? obj10 : null)) * unchecked((nuint)(nint)intPtr) * unchecked((nuint)(nint)(IntPtr)T.h(F.A()))))) as byte[]);
		cHOOSEFONT = cHOOSEFONT;
		_ = (_003CPrivateImplementationDetails_003E)(object)F.A();
		num = default(UIntPtr);
		if (checked(num - num) == 0)
		{
			try
			{
				try
				{
					h = h;
				}
				finally
				{
					IAssemblyLoader assemblyLoader = (IAssemblyLoader)(object)F.A();
					goto end_IL_04a9;
				}
				end_IL_04a9:;
			}
			finally
			{
				do
				{
					_ = (h)T.h(array);
				}
				while ((object)T.h(F.A()) != null);
				goto IL_052b;
			}
		}
		try
		{
			r = default(r);
		}
		catch
		{
			_ = (AssmeblyLoader)(object)F.A();
		}
		goto IL_052b;
		IL_052b:
		do
		{
			_ = (IAssemblyLoader)(object)T.h(array);
		}
		while (obj3 != null);
		_ = (CHOOSEFONTFLAGS)T.h(null);
	}
}
