using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ff60;
using Jc0j;
using Xn90;
using Yk3n;
using b4HG;
using b5SD;
using b7SY;
using c4SC;
using d2BW;
using f3MN;
using i4AJ;
using m1H0;
using m9L3;
using n2CG;
using r3ST;
using t2F3;

namespace b2LG;

public class d3YR
{
	internal static bool C = false;

	internal static byte[] w0TZ(int int_0)
	{
		Assembly assembly_ = Ra2r();
		string[] array = Wy6z(assembly_);
		byte[] result = default(byte[]);
		foreach (string string_ in array)
		{
			using Stream stream = Dc0y(assembly_, string_);
			if (stream == null || stream.Length != int_0)
			{
				continue;
			}
			byte[] array2 = new byte[checked((int)(stream.Length - 1L) + 1)];
			stream.Read(array2, 0, array2.Length);
			C = true;
			result = array2;
			return result;
		}
		return result;
	}

	internal static Assembly Ra2r()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static string[] Wy6z(Assembly assembly_0)
	{
		return assembly_0.GetManifestResourceNames();
	}

	internal static Stream Dc0y(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	static void Ra5s()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			num = (UIntPtr)y6H4.Default;
			if (checked(num - unchecked((nuint)(UIntPtr)y6H4.Default) * num) == 0)
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Nn39)(object)y6H4.Default;
					_ = (o6M9)y6H4.Default;
				}
				else
				{
					_ = (k2Z8)(object)y6H4.Default;
				}
			}
		}
		catch
		{
			obj = null;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Kj09 kj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ci80 ci);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j4X8 j4X);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nn39 nn);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m3SM m3SM);
		try
		{
			do
			{
				if (num != 0)
				{
					ci = (Ci80)(object)y6H4.Default;
					ci = ci;
				}
				else
				{
					Kj09 obj3 = (Kj09)(object)y6H4.Default;
					kj = kj;
					kj = obj3;
				}
			}
			while (obj != null);
		}
		finally
		{
			if (num == 0)
			{
				while (obj != null)
				{
					m3SM = null;
					m3SM = null;
				}
				goto IL_00b2;
			}
			try
			{
				Nn39 obj4 = (Nn39)(object)y6H4.Default;
				nn = null;
				nn = obj4;
			}
			finally
			{
				j4X8 obj5 = (j4X8)(object)y6H4.Default;
				j4X = null;
				j4X = obj5;
				goto IL_00b2;
			}
		}
		IL_0833:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o6M9 o6M);
		while (obj != null)
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (m3SM)(object)y6H4.Default;
				}
				while (obj != null);
			}
			else
			{
				o6M = o6M;
			}
		}
		try
		{
			_ = (Ci80)(object)y6H4.Default;
		}
		catch
		{
			num = default(UIntPtr);
			if (num / checked(unchecked((nuint)(UIntPtr)y6H4.Default) * num) == 0)
			{
				do
				{
					_ = y6H4.Default;
				}
				while ((object)y6H4.Default != null);
			}
		}
		kj = kj;
		m3SM = (m3SM)(object)y6H4.Default;
		if (num != 0)
		{
			return;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dw8x dw8x);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out e7DL e7DL);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3YR d3YR2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if (checked((num + num) * num) == 0)
			{
				_003CModule_003E = null;
			}
			else
			{
				e7DL = e7DL;
			}
			return;
		}
		finally
		{
			num = default(UIntPtr);
			if (checked(num * num) / (nuint)(UIntPtr)y6H4.Default == 0)
			{
				d3YR2 = d3YR2;
				return;
			}
			dw8x = dw8x;
			d3YR2 = null;
			kj = null;
			return;
		}
		IL_00b2:
		y6H4 y6H;
		try
		{
			while (obj != null)
			{
				try
				{
					_ = (j4X8)(object)y6H4.Default;
					_ = (d3YR)(object)y6H4.Default;
				}
				catch
				{
					m3SM = m3SM;
				}
			}
		}
		finally
		{
			while ((object)y6H4.Default != null)
			{
				try
				{
					y6H = null;
					y6H = y6H;
				}
				finally
				{
					_ = y6H4.Default;
					continue;
				}
			}
			goto IL_0103;
		}
		IL_0103:
		checked
		{
			if (unchecked(num / num) - num + unchecked((nuint)(UIntPtr)y6H4.Default) != 0)
			{
				_ = (Lg1t)(object)y6H4.Default;
			}
		}
		while (obj != null)
		{
			if (num / checked(num - (unchecked((nuint)(UIntPtr)y6H4.Default) + num)) / num == 0)
			{
				try
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
				finally
				{
					j4X = j4X;
					continue;
				}
			}
			try
			{
				kj = (Kj09)(object)y6H4.Default;
			}
			finally
			{
				y6H = y6H4.Default;
				continue;
			}
		}
		try
		{
			try
			{
				_ = y6H4.Default;
			}
			finally
			{
				o6M = default(o6M9);
				o6M = o6M;
				o6M = o6M;
				goto end_IL_0168;
			}
			end_IL_0168:;
		}
		catch
		{
			if (num == 0)
			{
				try
				{
					kj = (Kj09)(object)y6H4.Default;
					_ = (Lg1t)(object)y6H4.Default;
				}
				catch
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xz8a xz8a);
		checked
		{
			if (unchecked((nuint)(UIntPtr)y6H4.Default) + (num + num) == 0)
			{
				xz8a = xz8a;
				xz8a = null;
			}
		}
		try
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Nn39)(object)y6H4.Default;
			}
		}
		catch
		{
			_ = (Dw8x)(object)y6H4.Default;
		}
		finally
		{
			try
			{
				checked
				{
					if (unchecked((nuint)(UIntPtr)y6H4.Default) - num == 0)
					{
						_ = (j4X8)(object)y6H4.Default;
					}
					else
					{
						xz8a = null;
					}
				}
			}
			finally
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					m3SM = m3SM;
					_ = (e7DL)(object)y6H4.Default;
					j4X = j4X;
					_ = (Lg1t)(object)y6H4.Default;
				}
				else
				{
					_ = (Nn39)(object)y6H4.Default;
				}
				goto IL_0253;
			}
		}
		IL_06e7:
		while (obj != null)
		{
			_ = (Dw8x)(object)y6H4.Default;
			xz8a = xz8a;
			j4X = j4X;
		}
		try
		{
			kj = (Kj09)(object)y6H4.Default;
		}
		finally
		{
			goto IL_06f9;
		}
		IL_0253:
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				m3SM = m3SM;
			}
			while ((object)y6H4.Default != null);
		}
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				j4X = j4X;
				e7DL = e7DL;
				e7DL = e7DL;
				_ = (_003CModule_003E)(object)y6H4.Default;
			}
			else
			{
				do
				{
					_ = (Lg1t)(object)y6H4.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			try
			{
				do
				{
					_ = (e7DL)(object)y6H4.Default;
				}
				while (obj != null);
			}
			finally
			{
				_ = (o6M9)y6H4.Default;
				goto end_IL_0293;
			}
			end_IL_0293:;
		}
		checked
		{
			try
			{
				ci = null;
			}
			catch
			{
				if (unchecked((nuint)(UIntPtr)y6H4.Default) - unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
				{
					do
					{
						_ = (d3YR)(object)y6H4.Default;
					}
					while (obj != null);
				}
			}
			num = default(UIntPtr);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					n2M8 n2M = null;
					n2M = n2M;
				}
			}
			catch
			{
				try
				{
					_ = (Kj09)(object)y6H4.Default;
				}
				catch
				{
					_ = (Dw8x)(object)y6H4.Default;
				}
			}
		}
		_ = (Kj09)(object)y6H4.Default;
		checked
		{
			while (true)
			{
				if (obj != null)
				{
					if (unchecked((nuint)(UIntPtr)y6H4.Default) - unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
					{
						ci = null;
					}
				}
				else if (obj == null)
				{
					break;
				}
			}
			y6H = y6H4.Default;
			e7DL = null;
			num = default(UIntPtr);
		}
		if (unchecked((nuint)default(UIntPtr)) / num == 0)
		{
			_ = (Ap9k)(object)y6H4.Default;
		}
		else
		{
			_ = (e7DL)(object)y6H4.Default;
		}
		Am25 am;
		do
		{
			try
			{
				do
				{
					_ = (Ci80)(object)y6H4.Default;
					_ = (e7DL)(object)y6H4.Default;
				}
				while (obj != null);
			}
			finally
			{
				try
				{
					e7DL = null;
					n2M8 n2M = (n2M8)(object)y6H4.Default;
					_ = (k2Z8)(object)y6H4.Default;
				}
				finally
				{
					Am25 obj15 = (Am25)y6H4.Default;
					am = (Am25)y6H4.Default;
					am = obj15;
					continue;
				}
			}
		}
		while (obj != null);
		_003CModule_003E = _003CModule_003E;
		_003CModule_003E = null;
		_ = (d3YR)(object)y6H4.Default;
		if (num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				try
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
				catch
				{
					_ = (Lg1t)(object)y6H4.Default;
				}
			}
			else
			{
				try
				{
					_ = (k2Z8)(object)y6H4.Default;
				}
				catch
				{
					_ = (m7A5)(object)y6H4.Default;
				}
			}
		}
		else
		{
			while ((object)y6H4.Default != null)
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					d3YR2 = null;
					d3YR2 = d3YR2;
				}
				else
				{
					_ = (m7A5)(object)y6H4.Default;
				}
			}
		}
		while (obj != null)
		{
			if (num == 0)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					y6H = y6H4.Default;
					continue;
				}
			}
		}
		e7DL = null;
		try
		{
			if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
			{
				dw8x = (Dw8x)(object)y6H4.Default;
				dw8x = null;
			}
		}
		catch
		{
			try
			{
				_ = (Ap9k)(object)y6H4.Default;
			}
			finally
			{
				_ = (m3SM)(object)y6H4.Default;
				n2M8 n2M = (n2M8)(object)y6H4.Default;
				_ = (Nn39)(object)y6H4.Default;
				_ = (m3SM)(object)y6H4.Default;
				goto end_IL_049f;
			}
			end_IL_049f:;
		}
		finally
		{
			while (obj != null)
			{
				if ((nuint)(UIntPtr)y6H4.Default / (nuint)(UIntPtr)y6H4.Default == 0)
				{
					ci = ci;
				}
				else
				{
					_ = (m7A5)(object)y6H4.Default;
				}
			}
			goto IL_050e;
		}
		IL_0787:
		do
		{
			UIntPtr num2 = (UIntPtr)y6H4.Default;
			nuint num3 = num;
			checked
			{
				nuint num4 = unchecked((nuint)(UIntPtr)y6H4.Default) + num;
				num = default(UIntPtr);
				if (unchecked((nuint)num2) - (num3 - unchecked(num4 / num)) != 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						j4X = null;
						o6M = (o6M9)y6H4.Default;
					}
				}
				else
				{
					_ = (j4X8)(object)y6H4.Default;
					d3YR2 = d3YR2;
					_ = (Dw8x)(object)y6H4.Default;
					ci = (Ci80)(object)y6H4.Default;
				}
			}
		}
		while (obj != null);
		try
		{
			while ((object)y6H4.Default != null)
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					ci = null;
				}
			}
		}
		catch
		{
			_ = (_003CModule_003E)(object)y6H4.Default;
		}
		try
		{
			_ = (Ap9k)(object)y6H4.Default;
		}
		finally
		{
			if (num == 0)
			{
				if ((UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u)
				{
					_ = (j4X8)(object)y6H4.Default;
				}
				else
				{
					j4X = (j4X8)(object)y6H4.Default;
				}
			}
			goto IL_0833;
		}
		IL_06f9:
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				_ = (_003CModule_003E)(object)y6H4.Default;
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					y6H = y6H;
				}
				else
				{
					nn = nn;
				}
				goto IL_0787;
			}
		}
		while ((object)y6H4.Default != null)
		{
			_ = y6H4.Default;
		}
		goto IL_0787;
		IL_050e:
		do
		{
			try
			{
				try
				{
					_ = (Ap9k)(object)y6H4.Default;
				}
				catch
				{
					_ = (d3YR)(object)y6H4.Default;
				}
			}
			catch
			{
				try
				{
					_ = (m7A5)(object)y6H4.Default;
				}
				finally
				{
					_ = (j4X8)(object)y6H4.Default;
					goto end_IL_052c;
				}
				end_IL_052c:;
			}
		}
		while (obj != null);
		_ = (e7DL)(object)y6H4.Default;
		UIntPtr num5 = (UIntPtr)y6H4.Default;
		num = default(UIntPtr);
		checked
		{
			if (unchecked((nuint)num5 / num == 0 && (UIntPtr)y6H4.Default == (UIntPtr)(nuint)0u) && num - unchecked((nuint)(UIntPtr)y6H4.Default) == 0)
			{
				kj = null;
			}
			_ = (d3YR)(object)y6H4.Default;
			_ = (Ci80)(object)y6H4.Default;
			_ = (Ci80)(object)y6H4.Default;
			kj = kj;
			m7A5 m7A = null;
			m7A = m7A;
			try
			{
				try
				{
					do
					{
						d3YR2 = (d3YR)(object)y6H4.Default;
					}
					while ((object)y6H4.Default != null);
				}
				catch
				{
					while (obj != null)
					{
						o6M = (o6M9)y6H4.Default;
					}
				}
			}
			catch
			{
				_003CModule_003E = null;
			}
			do
			{
				num = default(UIntPtr);
				if (num + (unchecked((nuint)(UIntPtr)y6H4.Default) + unchecked((nuint)(UIntPtr)y6H4.Default) - num) != 0)
				{
					do
					{
						_ = (_003CModule_003E)(object)y6H4.Default;
					}
					while (obj != null);
					continue;
				}
				try
				{
					_ = (j4X8)(object)y6H4.Default;
					_ = (n2M8)(object)y6H4.Default;
					_ = (Lg1t)(object)y6H4.Default;
				}
				catch
				{
					ci = ci;
					_ = (Kj09)(object)y6H4.Default;
					_ = (k2Z8)(object)y6H4.Default;
				}
			}
			while ((object)y6H4.Default != null);
			_ = (Lg1t)(object)y6H4.Default;
			y6H = y6H;
			am = am;
		}
		if (num == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Dw8x)(object)y6H4.Default;
				}
				else
				{
					j4X = j4X;
				}
			}
			finally
			{
				goto IL_06e7;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				m3SM = m3SM;
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				d3YR2 = (d3YR)(object)y6H4.Default;
			}
			else
			{
				y6H = y6H;
			}
			goto IL_06e7;
		}
	}
}
