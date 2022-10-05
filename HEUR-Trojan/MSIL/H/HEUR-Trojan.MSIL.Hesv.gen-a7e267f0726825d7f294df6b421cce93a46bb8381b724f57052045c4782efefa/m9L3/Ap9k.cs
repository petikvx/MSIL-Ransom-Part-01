using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ff60;
using Jc0j;
using Microsoft.VisualBasic.CompilerServices;
using Xn90;
using Yk3n;
using b2LG;
using b4HG;
using b5SD;
using b7SY;
using c4SC;
using d2BW;
using f3MN;
using i4AJ;
using m1H0;
using n2CG;
using r3ST;
using t2F3;

namespace m9L3;

public class Ap9k
{
	internal static void t7P1()
	{
		try
		{
			Type[] exportedTypes = z0KX().GetExportedTypes();
			foreach (Type type_ in exportedTypes)
			{
				Ci80.Ta97(type_);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static object g3CH()
	{
		return AppDomain.CurrentDomain;
	}

	private static Assembly z0KX()
	{
		object obj = g3CH();
		object[] obj2 = new object[1] { Lg1t.O };
		object[] array = obj2;
		bool[] obj3 = new bool[1] { true };
		bool[] array2 = obj3;
		Assembly result = (Assembly)NewLateBinding.LateGet(obj, (Type)null, "Load", obj2, (string[])null, (Type[])null, obj3);
		if (array2[0])
		{
			Lg1t.O = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
		}
		return result;
	}

	static void Jr7f()
	{
		UIntPtr num = (UIntPtr)y6H4.Default;
		nuint uIntPtr = uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4X8 j4X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6H4 y6H);
		checked
		{
			if (unchecked((nuint)num) * (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr))) == 0)
			{
				try
				{
					y6H = null;
					y6H = null;
				}
				finally
				{
					_ = (k2Z8)(object)y6H4.Default;
					goto IL_0061;
				}
			}
			while (true)
			{
				obj = y6H4.Default;
				if (obj == null)
				{
					break;
				}
				try
				{
					j4X = (j4X8)(object)y6H4.Default;
					j4X = null;
				}
				catch
				{
					_ = (Xz8a)(object)y6H4.Default;
				}
			}
			goto IL_0061;
		}
		IL_0589:
		while (obj != null)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap9k ap9k);
		m3SM m3SM;
		checked
		{
			try
			{
				if ((uIntPtr - unchecked((nuint)(UIntPtr)y6H4.Default)) * (uIntPtr * unchecked((nuint)(UIntPtr)y6H4.Default)) != 0)
				{
					try
					{
						_ = (m3SM)(object)y6H4.Default;
					}
					finally
					{
						m3SM = null;
						goto end_IL_058c;
					}
				}
				ap9k = ap9k;
				end_IL_058c:;
			}
			finally
			{
				goto IL_05c4;
			}
		}
		IL_01e0:
		_ = (k2Z8)(object)y6H4.Default;
		_ = (e7DL)(object)y6H4.Default;
		_ = (Xz8a)(object)y6H4.Default;
		k2Z8 k2Z = null;
		k2Z = k2Z;
		_ = (k2Z8)(object)y6H4.Default;
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
			}
		}
		finally
		{
			do
			{
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (e7DL)(object)y6H4.Default;
				}
			}
			while (obj != null);
			goto IL_023c;
		}
		IL_0061:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj09 kj);
		Dw8x dw8x;
		if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
		{
			_ = (j4X8)(object)y6H4.Default;
		}
		else
		{
			try
			{
				try
				{
					dw8x = null;
					dw8x = dw8x;
				}
				catch
				{
					n2M8 obj3 = (n2M8)(object)y6H4.Default;
					n2M8 n2M = n2M;
					n2M = obj3;
				}
			}
			catch
			{
				try
				{
					_ = (d3YR)(object)y6H4.Default;
				}
				catch
				{
					_ = y6H4.Default;
					kj = (Kj09)(object)y6H4.Default;
					kj = kj;
					_ = (_003CModule_003E)(object)y6H4.Default;
				}
			}
		}
		m3SM = null;
		m3SM = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7DL e7DL);
		do
		{
			e7DL obj7 = (e7DL)(object)y6H4.Default;
			e7DL = e7DL;
			e7DL = obj7;
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xz8a xz8a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ci80 ci);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (m3SM)(object)y6H4.Default;
		}
		else
		{
			try
			{
			}
			catch
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					xz8a = (Xz8a)(object)y6H4.Default;
					xz8a = xz8a;
				}
				else
				{
					ci = null;
					ci = ci;
				}
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			_ = (k2Z8)(object)y6H4.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o6M9 o6M);
		if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (d3YR)(object)y6H4.Default;
			}
			catch
			{
				e7DL = null;
			}
			finally
			{
				o6M9 obj10 = (o6M9)y6H4.Default;
				o6M = o6M;
				o6M = obj10;
				goto IL_017a;
			}
		}
		goto IL_017a;
		IL_0543:
		do
		{
			if (uIntPtr != 0)
			{
				try
				{
					_ = (o6M9)y6H4.Default;
				}
				catch
				{
					k2Z = null;
					_ = (n2M8)(object)y6H4.Default;
					kj = kj;
				}
			}
			else
			{
				n2M8 n2M = (n2M8)(object)y6H4.Default;
			}
		}
		while (obj != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn39 nn);
		try
		{
			_ = (e7DL)(object)y6H4.Default;
		}
		finally
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					nn = null;
				}
				while (obj != null);
			}
			else
			{
				try
				{
					ci = (Ci80)(object)y6H4.Default;
				}
				catch
				{
					_ = (o6M9)y6H4.Default;
				}
			}
			goto IL_0589;
		}
		IL_05c4:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Lg1t)(object)y6H4.Default;
					_ = (e7DL)(object)y6H4.Default;
					xz8a = (Xz8a)(object)y6H4.Default;
				}
				else
				{
					_ = (k2Z8)(object)y6H4.Default;
				}
			}
			finally
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					kj = (Kj09)(object)y6H4.Default;
					y6H = y6H;
					xz8a = xz8a;
				}
				finally
				{
					j4X = j4X;
					goto IL_062c;
				}
			}
		}
		goto IL_062c;
		IL_062c:
		try
		{
			xz8a = xz8a;
		}
		catch
		{
			y6H = y6H;
			e7DL = null;
			_ = (Ap9k)(object)y6H4.Default;
		}
		dw8x = dw8x;
		try
		{
			try
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					xz8a = xz8a;
				}
				return;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					kj = kj;
				}
				else
				{
					_ = (Lg1t)(object)y6H4.Default;
				}
				return;
			}
		}
		finally
		{
			try
			{
				while (obj != null)
				{
					k2Z = null;
				}
				return;
			}
			catch
			{
				_ = (j4X8)(object)y6H4.Default;
				return;
			}
		}
		IL_017a:
		try
		{
			do
			{
				_ = (_003CModule_003E)(object)y6H4.Default;
			}
			while ((object)y6H4.Default != null);
		}
		catch
		{
		}
		finally
		{
			while (obj != null)
			{
				dw8x = null;
			}
			goto IL_01a6;
		}
		IL_01a6:
		try
		{
			o6M = (o6M9)y6H4.Default;
		}
		finally
		{
			try
			{
				while ((object)y6H4.Default != null)
				{
					_ = (Am25)y6H4.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					e7DL = e7DL;
				}
			}
			goto IL_01e0;
		}
		IL_023c:
		if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Am25 am);
			while (obj != null)
			{
				try
				{
					Am25 obj17 = (Am25)y6H4.Default;
					am = am;
					am = obj17;
				}
				catch
				{
					_ = (m3SM)(object)y6H4.Default;
				}
			}
		}
		else
		{
			try
			{
				do
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = y6H4.Default;
			}
		}
		_ = (Am25)y6H4.Default;
		ci = ci;
		try
		{
			while ((object)y6H4.Default != null)
			{
				do
				{
					_ = (n2M8)(object)y6H4.Default;
					_ = (e7DL)(object)y6H4.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
				nn = (Nn39)(object)y6H4.Default;
			}
			catch
			{
				try
				{
					_ = (n2M8)(object)y6H4.Default;
					goto end_IL_02d8;
				}
				catch
				{
					_003CModule_003E = null;
					_ = y6H4.Default;
					goto end_IL_02d8;
				}
				end_IL_02d8:;
			}
		}
		while (obj != null)
		{
			ci = ci;
		}
		do
		{
			kj = kj;
		}
		while (obj != null);
		checked
		{
			if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
			{
				try
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
						_ = (Am25)y6H4.Default;
						Am25 am = default(Am25);
						m3SM = m3SM;
					}
					catch
					{
						_ = (Kj09)(object)y6H4.Default;
					}
				}
				catch
				{
					_ = (Nn39)(object)y6H4.Default;
				}
			}
			do
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr - unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
				{
					nuint num2 = uIntPtr - unchecked(unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)));
					uIntPtr = default(UIntPtr);
					if ((num2 - uIntPtr) * uIntPtr == 0)
					{
						_ = (m7A5)(object)y6H4.Default;
						continue;
					}
					_ = (Xz8a)(object)y6H4.Default;
					_ = (k2Z8)(object)y6H4.Default;
					_ = (_003CModule_003E)(object)y6H4.Default;
					_ = (o6M9)y6H4.Default;
				}
			}
			while (obj != null);
			_ = (_003CModule_003E)(object)y6H4.Default;
			uIntPtr = default(UIntPtr);
			nuint num3 = unchecked((nuint)default(UIntPtr)) + unchecked(uIntPtr / uIntPtr);
			uIntPtr = default(UIntPtr);
			if (num3 + uIntPtr == 0)
			{
				_ = (m3SM)(object)y6H4.Default;
			}
			try
			{
				if (unchecked((nuint)(UIntPtr)y6H4.Default) - uIntPtr * unchecked((nuint)(UIntPtr)y6H4.Default) == 0 && unchecked((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u))
				{
					ap9k = (Ap9k)(object)y6H4.Default;
					ap9k = ap9k;
				}
			}
			catch
			{
				try
				{
					try
					{
						_ = (e7DL)(object)y6H4.Default;
					}
					finally
					{
						o6M = o6M;
						goto end_IL_044d;
					}
					end_IL_044d:;
				}
				finally
				{
					while ((object)y6H4.Default != null)
					{
						_ = (_003CModule_003E)(object)y6H4.Default;
					}
					goto end_IL_044c;
				}
				end_IL_044c:;
			}
			dw8x = null;
			try
			{
				while ((object)y6H4.Default != null)
				{
					_ = (n2M8)(object)y6H4.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					if (uIntPtr == 0)
					{
						_ = (Dw8x)(object)y6H4.Default;
					}
					else
					{
						m3SM = m3SM;
						k2Z = null;
					}
				}
			}
		}
		try
		{
			try
			{
				_ = (o6M9)y6H4.Default;
			}
			finally
			{
				o6M = o6M;
				goto end_IL_04bf;
			}
			end_IL_04bf:;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			nuint num4 = uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num4 / uIntPtr == 0)
			{
				nn = nn;
				kj = null;
				_ = (n2M8)(object)y6H4.Default;
			}
			else
			{
				m3SM = m3SM;
			}
		}
		finally
		{
			ci = ci;
			goto IL_0543;
		}
	}

	static void Gq69()
	{
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2M8 n2M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4X8 j4X);
		while (true)
		{
			obj = y6H4.Default;
			if (obj == null)
			{
				break;
			}
			try
			{
				_ = (Ap9k)(object)y6H4.Default;
				j4X8 obj2 = (j4X8)(object)y6H4.Default;
				j4X = j4X;
				j4X = obj2;
			}
			catch
			{
				try
				{
					n2M8 obj3 = (n2M8)(object)y6H4.Default;
					n2M = (n2M8)(object)y6H4.Default;
					n2M = obj3;
				}
				catch
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
			}
		}
		Nn39 nn = (Nn39)(object)y6H4.Default;
		nn = null;
		do
		{
			nn = nn;
		}
		while ((object)y6H4.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m3SM m3SM);
		while (obj != null)
		{
			do
			{
				m3SM obj6 = (m3SM)(object)y6H4.Default;
				m3SM = (m3SM)(object)y6H4.Default;
				m3SM = obj6;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj09 kj);
		while ((object)y6H4.Default != null)
		{
			try
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					kj = kj;
					kj = kj;
				}
			}
			catch
			{
				while ((object)y6H4.Default != null)
				{
					m3SM = m3SM;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o6M9 o6M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7DL e7DL);
		try
		{
			try
			{
				e7DL = (e7DL)(object)y6H4.Default;
			}
			catch
			{
				while (obj != null)
				{
					e7DL = null;
				}
			}
		}
		catch
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (o6M9)y6H4.Default;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)y6H4.Default;
					_003CModule_003E = _003CModule_003E;
					goto end_IL_00e6;
				}
			}
			o6M = o6M;
			o6M = default(o6M9);
			end_IL_00e6:;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y6H4 y6H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3YR d3YR);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lg1t lg1t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					k2Z8 k2Z = null;
					k2Z = k2Z;
				}
				catch
				{
					d3YR = d3YR;
					d3YR = null;
					y6H = y6H;
					y6H = y6H;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (checked(num + unchecked((nuint)(UIntPtr)y6H4.Default)) / ((nuint)(UIntPtr)y6H4.Default / (nuint)(UIntPtr)y6H4.Default) / (nuint)(UIntPtr)y6H4.Default == 0)
				{
					_ = y6H4.Default;
				}
			}
		}
		catch
		{
			while ((object)y6H4.Default != null)
			{
				do
				{
					_ = (k2Z8)(object)y6H4.Default;
					lg1t = lg1t;
					lg1t = lg1t;
					_ = (m7A5)(object)y6H4.Default;
				}
				while (obj != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw8x dw8x);
		checked
		{
			try
			{
				try
				{
					_ = (j4X8)(object)y6H4.Default;
				}
				finally
				{
					if (num == 0)
					{
						y6H = null;
					}
					goto end_IL_01c4;
				}
				end_IL_01c4:;
			}
			catch
			{
				while (obj != null)
				{
					nuint num2 = unchecked((nuint)(UIntPtr)y6H4.Default) * num;
					num = default(UIntPtr);
					if (num2 - num == 0)
					{
						_ = (e7DL)(object)y6H4.Default;
						continue;
					}
					_ = (j4X8)(object)y6H4.Default;
					m3SM = null;
					d3YR = d3YR;
				}
			}
			while ((object)y6H4.Default != null)
			{
				d3YR = d3YR;
			}
			if (num * num == 0)
			{
				try
				{
					_ = (Xz8a)(object)y6H4.Default;
				}
				finally
				{
					if (unchecked((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u))
					{
						dw8x = dw8x;
						dw8x = dw8x;
					}
					goto IL_0258;
				}
			}
			goto IL_0258;
		}
		IL_050d:
		dw8x = (Dw8x)(object)y6H4.Default;
		while (obj != null)
		{
			_ = (k2Z8)(object)y6H4.Default;
		}
		try
		{
			do
			{
				k2Z8 k2Z = null;
			}
			while (obj != null);
		}
		catch
		{
			try
			{
				k2Z8 k2Z = (k2Z8)(object)y6H4.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (d3YR)(object)y6H4.Default;
				}
				goto end_IL_0533;
			}
			end_IL_0533:;
		}
		if ((nuint)(UIntPtr)y6H4.Default / num == 0)
		{
			while (obj != null)
			{
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ap9k ap9k);
		while (obj != null)
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr)) == 0)
				{
					dw8x = null;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (checked(num * num) == 0)
				{
					ap9k = null;
				}
				else
				{
					n2M = n2M;
				}
				continue;
			}
		}
		dw8x = null;
		if (num == 0)
		{
			do
			{
				try
				{
					_ = (n2M8)(object)y6H4.Default;
				}
				catch
				{
					e7DL = e7DL;
				}
			}
			while ((object)y6H4.Default != null);
		}
		else
		{
			do
			{
				_ = (n2M8)(object)y6H4.Default;
			}
			while (obj != null);
		}
		do
		{
			if (num != 0)
			{
				_ = (k2Z8)(object)y6H4.Default;
			}
			else
			{
				_ = (Ci80)(object)y6H4.Default;
			}
		}
		while (obj != null || (object)y6H4.Default != null);
		if (checked(num + num) == 0 && num == 0)
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				j4X = (j4X8)(object)y6H4.Default;
			}
			else
			{
				dw8x = dw8x;
				m3SM = (m3SM)(object)y6H4.Default;
				_ = y6H4.Default;
				_003CModule_003E = _003CModule_003E;
			}
		}
		do
		{
			try
			{
				while (obj != null)
				{
					_ = (e7DL)(object)y6H4.Default;
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					d3YR = d3YR;
				}
				else
				{
					_ = (Lg1t)(object)y6H4.Default;
				}
				continue;
			}
		}
		while ((object)y6H4.Default != null);
		ap9k = null;
		o6M = o6M;
		try
		{
			o6M = default(o6M9);
		}
		catch
		{
			while ((object)y6H4.Default != null)
			{
				try
				{
					o6M = default(o6M9);
				}
				catch
				{
					_ = (Xz8a)(object)y6H4.Default;
				}
			}
		}
		try
		{
			_ = (Lg1t)(object)y6H4.Default;
			ap9k = null;
			d3YR = (d3YR)(object)y6H4.Default;
		}
		finally
		{
			_ = (Ap9k)(object)y6H4.Default;
			goto IL_0706;
		}
		IL_0258:
		try
		{
			do
			{
				_ = (Kj09)(object)y6H4.Default;
			}
			while (obj != null);
		}
		catch
		{
			_ = (j4X8)(object)y6H4.Default;
		}
		finally
		{
			lg1t = lg1t;
			goto IL_0281;
		}
		IL_0281:
		num = default(UIntPtr);
		if (num == 0)
		{
			if (num / (nuint)(UIntPtr)y6H4.Default == 0)
			{
				try
				{
					_ = (Xz8a)(object)y6H4.Default;
				}
				finally
				{
					_ = (Ci80)(object)y6H4.Default;
					goto IL_02eb;
				}
			}
			goto IL_02eb;
		}
		try
		{
			_ = (e7DL)(object)y6H4.Default;
		}
		finally
		{
			while (obj != null)
			{
				_ = y6H4.Default;
				lg1t = (Lg1t)(object)y6H4.Default;
			}
			goto IL_02eb;
		}
		IL_02eb:
		while (true)
		{
			if (obj != null)
			{
				e7DL = null;
			}
			else if (obj == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Am25 am);
		while (obj != null)
		{
			am = (Am25)y6H4.Default;
		}
		while ((object)y6H4.Default != null)
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Am25)y6H4.Default;
			}
		}
		if (num == 0)
		{
			try
			{
				while (obj != null)
				{
					e7DL = e7DL;
				}
			}
			catch
			{
				try
				{
					am = am;
				}
				catch
				{
					ap9k = ap9k;
					ap9k = ap9k;
				}
			}
		}
		else
		{
			while ((object)y6H4.Default != null)
			{
				_ = (Nn39)(object)y6H4.Default;
			}
		}
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Kj09)(object)y6H4.Default;
				_ = (o6M9)y6H4.Default;
				o6M = o6M;
				_ = (e7DL)(object)y6H4.Default;
			}
		}
		catch
		{
			am = am;
		}
		if (num == 0)
		{
			try
			{
				n2M = n2M;
			}
			catch
			{
				try
				{
					_ = (Nn39)(object)y6H4.Default;
				}
				finally
				{
					nn = null;
					goto end_IL_03a5;
				}
				end_IL_03a5:;
			}
		}
		else
		{
			try
			{
				while (obj != null)
				{
					_ = (Xz8a)(object)y6H4.Default;
					_ = (Xz8a)(object)y6H4.Default;
				}
			}
			catch
			{
				while (obj != null)
				{
					_ = (o6M9)y6H4.Default;
					y6H = y6H;
					dw8x = dw8x;
				}
			}
		}
		checked
		{
			do
			{
				nuint num3 = unchecked((nuint)(UIntPtr)y6H4.Default) * unchecked((nuint)(UIntPtr)y6H4.Default);
				num = default(UIntPtr);
				if (num3 + (unchecked((nuint)default(UIntPtr)) + num + unchecked((nuint)(UIntPtr)y6H4.Default)) != 0)
				{
					try
					{
						nn = null;
					}
					catch
					{
						_ = (k2Z8)(object)y6H4.Default;
						_ = (n2M8)(object)y6H4.Default;
						d3YR = (d3YR)(object)y6H4.Default;
					}
				}
				else if (num == 0)
				{
					ap9k = ap9k;
				}
			}
			while (obj != null);
			do
			{
				nuint num4 = num;
				num = default(UIntPtr);
				if (num4 * (unchecked((nuint)default(UIntPtr)) + num) != 0)
				{
					do
					{
						_ = (Dw8x)(object)y6H4.Default;
						_ = (Xz8a)(object)y6H4.Default;
						_ = (Nn39)(object)y6H4.Default;
						j4X = null;
					}
					while (obj != null);
				}
				else
				{
					e7DL = e7DL;
				}
			}
			while (obj != null);
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (m7A5)(object)y6H4.Default;
				_ = (Xz8a)(object)y6H4.Default;
				_ = (Xz8a)(object)y6H4.Default;
			}
			try
			{
			}
			finally
			{
				while ((object)y6H4.Default != null)
				{
					while (obj != null)
					{
						nn = (Nn39)(object)y6H4.Default;
						_ = (n2M8)(object)y6H4.Default;
					}
				}
				goto IL_050d;
			}
		}
		IL_0706:
		nuint num5 = num;
		checked
		{
			nuint num6 = num * unchecked((nuint)(UIntPtr)y6H4.Default);
			num = default(UIntPtr);
			if (num5 * (num6 + num - unchecked(checked(num - unchecked((nuint)(UIntPtr)y6H4.Default)) / num / (nuint)(UIntPtr)y6H4.Default)) * unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
			{
				Ci80 ci = ci;
				ci = ci;
			}
			else if (unchecked(num / checked(unchecked((nuint)(UIntPtr)y6H4.Default) + unchecked((nuint)(UIntPtr)y6H4.Default))) - num == 0)
			{
				while (obj != null)
				{
					_ = (Am25)y6H4.Default;
				}
			}
			else
			{
				do
				{
					_ = (d3YR)(object)y6H4.Default;
				}
				while (obj != null);
			}
		}
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					_ = (m7A5)(object)y6H4.Default;
					_ = (j4X8)(object)y6H4.Default;
					_ = (n2M8)(object)y6H4.Default;
					e7DL = null;
				}
			}
		}
		else
		{
			am = (Am25)y6H4.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				_ = (j4X8)(object)y6H4.Default;
				_ = (Xz8a)(object)y6H4.Default;
			}
			while (obj != null);
		}
		else
		{
			do
			{
				try
				{
					kj = (Kj09)(object)y6H4.Default;
				}
				finally
				{
					_ = (d3YR)(object)y6H4.Default;
					continue;
				}
			}
			while (obj != null);
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				try
				{
					_ = (Kj09)(object)y6H4.Default;
				}
				finally
				{
					_ = (Ap9k)(object)y6H4.Default;
					continue;
				}
			}
		}
		else
		{
			_ = (k2Z8)(object)y6H4.Default;
		}
	}
}
