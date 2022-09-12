using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using Bp2s;
using Lg2q;
using Microsoft.VisualBasic.CompilerServices;
using Nw4c;
using Rm76;
using Wj80;
using d8Y9;
using f7W1;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace Hn20;

[StandardModule]
internal sealed class y4B7
{
	public static SqlConnection conn;

	public static SqlDataAdapter da;

	public static DataSet ds;

	public static SqlCommand cmd;

	public static SqlDataReader dr;

	public static void j1DM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		conn = new SqlConnection("data source=.\\SQLEXPRESS;initial catalog=note_tugas;integrated security=true");
		conn.Open();
	}

	static void w7GK()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		try
		{
			do
			{
				_ = (Pd01)(object)n2H1.Default;
				obj = n2H1.Default;
			}
			while (obj != null);
		}
		catch
		{
		}
		try
		{
			try
			{
				_ = (Pd01)(object)n2H1.Default;
			}
			finally
			{
				_ = (q0D6)(object)n2H1.Default;
				goto end_IL_0026;
			}
			end_IL_0026:;
		}
		finally
		{
			do
			{
				_ = (Ps93)(object)n2H1.Default;
				d3CT obj3 = (d3CT)(object)n2H1.Default;
				d3CT d3CT = (d3CT)(object)n2H1.Default;
				d3CT = obj3;
				n2H1 n2H = n2H1.Default;
				n2H = n2H;
				d3CT = d3CT;
			}
			while (obj != null || (object)n2H1.Default != null);
			goto IL_00a1;
		}
		IL_02fc:
		try
		{
			_ = (Pd01)(object)n2H1.Default;
		}
		catch
		{
			do
			{
				if ((UIntPtr)n2H1.Default != (UIntPtr)(nuint)0u)
				{
					_ = (q0D6)(object)n2H1.Default;
				}
				else
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
			while (obj != null);
		}
		w4M5 w4M = w4M;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		do
		{
			try
			{
				n2H1 n2H = n2H1.Default;
			}
			catch
			{
				ld7n = ld7n;
				ld7n = ld7n;
			}
		}
		while ((object)n2H1.Default != null);
		if ((UIntPtr)n2H1.Default != (UIntPtr)(nuint)0u)
		{
			ld7n = ld7n;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		try
		{
			while (obj != null)
			{
				_ = (d3CT)(object)n2H1.Default;
				_ = (d3CT)(object)n2H1.Default;
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
		}
		catch
		{
			do
			{
				_ = (Xq18)(object)n2H1.Default;
				d3CT d3CT = null;
				ps = (Ps93)(object)n2H1.Default;
			}
			while ((object)n2H1.Default != null);
		}
		finally
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
			goto IL_03ef;
		}
		IL_00a1:
		_ = (Ld7n)(object)n2H1.Default;
		while ((object)n2H1.Default != null)
		{
			try
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				finally
				{
					ps = ps;
					ps = ps;
					goto end_IL_00af;
				}
				end_IL_00af:;
			}
			finally
			{
				try
				{
					_ = (q0D6)(object)n2H1.Default;
					_ = (d3CT)(object)n2H1.Default;
				}
				catch
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				continue;
			}
		}
		nuint num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xq18 xq);
		if (num / (nuint)(UIntPtr)n2H1.Default == 0 && num == 0)
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (t8X9)(object)n2H1.Default;
			}
			else
			{
				_ = n2H1.Default;
				_ = (t8X9)(object)n2H1.Default;
				Xq18 obj8 = (Xq18)(object)n2H1.Default;
				xq = xq;
				xq = obj8;
				d3CT d3CT = null;
			}
		}
		if (num == 0)
		{
			do
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
			while (obj != null);
		}
		do
		{
			num = default(UIntPtr);
			if (num != (UIntPtr)(nuint)0u)
			{
				_ = (d3CT)(object)n2H1.Default;
				continue;
			}
			while (obj != null)
			{
				Ym89 ym = null;
				ym = ym;
			}
		}
		while (obj != null);
		try
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
					w4M = w4M;
					w4M = null;
					d3CT d3CT = null;
					_ = (Xq18)(object)n2H1.Default;
				}
				catch
				{
					_ = (t8X9)(object)n2H1.Default;
				}
			}
		}
		catch
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
			catch
			{
				xq = xq;
			}
		}
		_ = n2H1.Default;
		Pd01 pd;
		try
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				Pd01 obj12 = (Pd01)(object)n2H1.Default;
				pd = (Pd01)(object)n2H1.Default;
				pd = obj12;
			}
		}
		finally
		{
			_ = n2H1.Default;
			goto IL_0277;
		}
		IL_0277:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		if (num == (UIntPtr)(nuint)0u)
		{
			do
			{
				q0D = q0D;
				q0D = q0D;
			}
			while ((object)n2H1.Default != null || obj != null);
		}
		pd = (Pd01)(object)n2H1.Default;
		_ = (Ym89)(object)n2H1.Default;
		try
		{
			try
			{
				y4B7 y4B8 = y4B8;
				y4B8 = y4B8;
			}
			finally
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					q0D = q0D;
				}
				goto end_IL_02bc;
			}
			end_IL_02bc:;
		}
		finally
		{
			try
			{
				pd = (Pd01)(object)n2H1.Default;
			}
			finally
			{
				goto IL_02fc;
			}
		}
		IL_04df:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = n2H1.Default;
		}
		else
		{
			do
			{
				_ = (Ld7n)(object)n2H1.Default;
				_ = (Xq18)(object)n2H1.Default;
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
			}
			while (obj != null);
		}
		try
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		finally
		{
			_ = (Ym89)(object)n2H1.Default;
			ps = ps;
			_ = (w4M5)(object)n2H1.Default;
			_ = (Ld7n)(object)n2H1.Default;
			goto IL_0560;
		}
		IL_0560:
		while (obj != null)
		{
		}
		if ((nuint)(UIntPtr)n2H1.Default / (nuint)(UIntPtr)n2H1.Default == 0)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				pd = null;
				_ = (Ps93)(object)n2H1.Default;
			}
			else
			{
				_ = (Ps93)(object)n2H1.Default;
			}
		}
		while ((object)n2H1.Default != null)
		{
		}
		return;
		IL_03ef:
		try
		{
			do
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			while (obj != null);
		}
		finally
		{
			try
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (Ym89)(object)n2H1.Default;
					_ = (y4B7)(object)n2H1.Default;
					_003CModule_003E _003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				while (obj != null)
				{
					_ = (d3CT)(object)n2H1.Default;
				}
				goto IL_0443;
			}
		}
		IL_0443:
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = n2H1.Default;
		}
		try
		{
			UIntPtr num2 = (UIntPtr)n2H1.Default;
			num = default(UIntPtr);
			if (checked(unchecked((nuint)num2) - (num + num)) == 0)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = n2H1.Default;
				}
			}
			else
			{
				w4M = (w4M5)(object)n2H1.Default;
			}
		}
		finally
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Ld7n)(object)n2H1.Default;
					pd = pd;
					_ = (Pd01)(object)n2H1.Default;
					_ = (d3CT)(object)n2H1.Default;
				}
				while (obj != null);
			}
			goto IL_04df;
		}
	}

	static void Ms38()
	{
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				Ld7n ld7n = null;
				ld7n = ld7n;
			}
			finally
			{
				Xq18 xq = (Xq18)(object)n2H1.Default;
				xq = xq;
				goto IL_0067;
			}
		}
		do
		{
			try
			{
				t8X9 t8X = (t8X9)(object)n2H1.Default;
				t8X = t8X;
			}
			catch
			{
				_ = (q0D6)(object)n2H1.Default;
			}
		}
		while ((object)n2H1.Default != null);
		goto IL_0067;
		IL_0237:
		object obj2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
		nuint uIntPtr;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)n2H1.Default) * unchecked((nuint)default(UIntPtr)) == 0)
				{
					q0D = q0D;
				}
			}
		}
		else
		{
			do
			{
				_ = (t8X9)(object)n2H1.Default;
			}
			while (obj2 != null);
		}
		_ = n2H1.Default;
		try
		{
			_ = (q0D6)(object)n2H1.Default;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			goto IL_02a8;
		}
		IL_02a8:
		q0D = q0D;
		try
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Ge4b)(object)n2H1.Default;
				}
				finally
				{
					_ = (w4M5)(object)n2H1.Default;
					goto end_IL_02b0;
				}
			}
			_ = (Ld7n)(object)n2H1.Default;
			end_IL_02b0:;
		}
		finally
		{
			Ge4b obj3 = (Ge4b)(object)n2H1.Default;
			Ge4b ge4b = ge4b;
			ge4b = obj3;
			goto IL_0302;
		}
		IL_0302:
		_ = (t8X9)(object)n2H1.Default;
		_003CModule_003E _003CModule_003E = _003CModule_003E;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Ym89)(object)n2H1.Default;
		}
		else
		{
			_ = (Ym89)(object)n2H1.Default;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				t8X9 t8X = (t8X9)(object)n2H1.Default;
			}
			catch
			{
				while (obj2 != null)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		else
		{
			checked
			{
				do
				{
					uIntPtr = default(UIntPtr);
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) * uIntPtr == 0)
					{
						_ = (Pd01)(object)n2H1.Default;
						Ge4b ge4b = (Ge4b)(object)n2H1.Default;
						_ = (y4B7)(object)n2H1.Default;
						_ = (d3CT)(object)n2H1.Default;
					}
				}
				while ((object)n2H1.Default != null);
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		try
		{
			try
			{
				do
				{
					n2H = n2H;
				}
				while ((object)n2H1.Default != null);
			}
			finally
			{
				do
				{
					Ps93 ps = (Ps93)(object)n2H1.Default;
				}
				while (obj2 != null);
				goto end_IL_03df;
			}
			end_IL_03df:;
		}
		catch
		{
			try
			{
				while (obj2 != null)
				{
					_ = (y4B7)(object)n2H1.Default;
					_ = (Ge4b)(object)n2H1.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					ym = (Ym89)(object)n2H1.Default;
					_ = (Ld7n)(object)n2H1.Default;
				}
				else
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
		}
		q0D = q0D;
		return;
		IL_0067:
		_ = (Xq18)(object)n2H1.Default;
		checked
		{
			try
			{
				try
				{
					try
					{
						_ = (q0D6)(object)n2H1.Default;
					}
					finally
					{
						Ym89 obj7 = (Ym89)(object)n2H1.Default;
						ym = (Ym89)(object)n2H1.Default;
						ym = obj7;
						goto end_IL_0073;
					}
					end_IL_0073:;
				}
				finally
				{
					goto end_IL_0072;
				}
				end_IL_0072:;
			}
			finally
			{
				uIntPtr = unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)));
				if (uIntPtr - unchecked((nuint)(UIntPtr)n2H1.Default / (nuint)(UIntPtr)n2H1.Default) == 0 && uIntPtr == 0)
				{
					Ps93 ps = (Ps93)(object)n2H1.Default;
					ps = ps;
				}
				goto IL_010f;
			}
		}
		IL_010f:
		_ = (w4M5)(object)n2H1.Default;
		_ = (w4M5)(object)n2H1.Default;
		_ = (t8X9)(object)n2H1.Default;
		_003CModule_003E obj8 = (_003CModule_003E)(object)n2H1.Default;
		_003CModule_003E = null;
		_003CModule_003E = obj8;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
			}
		}
		obj2 = null;
		ym = ym;
		try
		{
			_ = n2H1.Default;
		}
		catch
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				_ = (Ps93)(object)n2H1.Default;
			}
			else
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
					t8X9 t8X = null;
				}
				catch
				{
				}
			}
		}
		_ = (Ld7n)(object)n2H1.Default;
		try
		{
			q0D = (q0D6)(object)n2H1.Default;
			q0D = q0D;
		}
		finally
		{
			try
			{
				while ((object)n2H1.Default != null)
				{
					_ = (Ps93)(object)n2H1.Default;
					_ = (w4M5)(object)n2H1.Default;
				}
			}
			finally
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
					Pd01 pd = pd;
					n2H = n2H1.Default;
					n2H = null;
					_ = (Ge4b)(object)n2H1.Default;
				}
				catch
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				goto IL_0237;
			}
		}
	}

	static void Kf16()
	{
		Ld7n obj = (Ld7n)(object)n2H1.Default;
		Ld7n ld7n = ld7n;
		ld7n = obj;
		try
		{
			_ = (d3CT)(object)n2H1.Default;
			_ = (d3CT)(object)n2H1.Default;
		}
		catch
		{
			y4B7 y4B8 = y4B8;
			y4B8 = y4B8;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		nuint uIntPtr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (d3CT)(object)n2H1.Default;
				}
			}
			else
			{
				Ps93 ps = (Ps93)(object)n2H1.Default;
				ps = ps;
			}
		}
		catch
		{
			try
			{
				do
				{
					ym = ym;
					ym = null;
					obj3 = obj3;
				}
				while (obj3 != null);
			}
			catch
			{
				try
				{
					_ = (Ps93)(object)n2H1.Default;
					_ = (Ym89)(object)n2H1.Default;
					Pd01 obj4 = (Pd01)(object)n2H1.Default;
					pd = pd;
					pd = obj4;
					goto end_IL_00b4;
				}
				finally
				{
					_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
					_003CModule_003E = null;
					goto end_IL_00b4;
				}
				end_IL_00b4:;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		else if (uIntPtr == 0)
		{
			while (obj3 != null)
			{
				_ = (Xq18)(object)n2H1.Default;
			}
		}
		while (obj3 != null)
		{
			if (uIntPtr == 0 && uIntPtr == 0)
			{
				_ = (Ge4b)(object)n2H1.Default;
			}
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)n2H1.Default) - unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
				{
					try
					{
						_ = (y4B7)(object)n2H1.Default;
					}
					finally
					{
						pd = pd;
						goto IL_01bb;
					}
				}
				do
				{
					_ = (t8X9)(object)n2H1.Default;
				}
				while (obj3 != null);
			}
		}
		else
		{
			while (obj3 != null)
			{
				while ((object)n2H1.Default != null)
				{
					_ = (Ym89)(object)n2H1.Default;
				}
			}
		}
		goto IL_01bb;
		IL_04ea:
		if (uIntPtr == 0)
		{
			while (obj3 != null)
			{
			}
			goto IL_0539;
		}
		try
		{
			if (uIntPtr == 0)
			{
				_ = (Ym89)(object)n2H1.Default;
			}
			else
			{
				_ = (Xq18)(object)n2H1.Default;
			}
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Pd01)(object)n2H1.Default;
			}
			goto IL_0539;
		}
		IL_020e:
		while (obj3 != null)
		{
			while ((object)n2H1.Default != null)
			{
			}
		}
		_ = (Xq18)(object)n2H1.Default;
		while (obj3 != null)
		{
			if (uIntPtr == 0)
			{
				try
				{
					ym = ym;
				}
				finally
				{
					_ = (d3CT)(object)n2H1.Default;
					continue;
				}
			}
			while (obj3 != null)
			{
				_ = (Ym89)(object)n2H1.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (checked(uIntPtr - uIntPtr) == 0)
				{
					w4M5 obj7 = (w4M5)(object)n2H1.Default;
					w4M = (w4M5)(object)n2H1.Default;
					w4M = obj7;
				}
				else
				{
					_ = (y4B7)(object)n2H1.Default;
				}
			}
			catch
			{
				do
				{
					_ = n2H1.Default;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			_ = (Ps93)(object)n2H1.Default;
		}
		while (obj3 != null)
		{
			pd = (Pd01)(object)n2H1.Default;
		}
		try
		{
			do
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				catch
				{
					_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
					_ = (Xq18)(object)n2H1.Default;
				}
			}
			while (obj3 != null);
		}
		catch
		{
			ym = (Ym89)(object)n2H1.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		if (uIntPtr == 0)
		{
			try
			{
				try
				{
					_ = (d3CT)(object)n2H1.Default;
				}
				finally
				{
					_ = (Ym89)(object)n2H1.Default;
					y4B7 y4B8 = null;
					_ = (t8X9)(object)n2H1.Default;
					goto end_IL_0318;
				}
				end_IL_0318:;
			}
			finally
			{
				try
				{
					n2H = n2H;
					n2H = null;
				}
				finally
				{
					w4M = (w4M5)(object)n2H1.Default;
					goto IL_0367;
				}
			}
		}
		goto IL_0367;
		IL_01bb:
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u && uIntPtr == 0)
			{
				_ = (y4B7)(object)n2H1.Default;
			}
		}
		finally
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D);
			do
			{
				if (uIntPtr == 0)
				{
					q0D = q0D;
					q0D = q0D;
				}
			}
			while (obj3 != null);
			goto IL_020e;
		}
		IL_0539:
		uIntPtr = default(UIntPtr);
		if (uIntPtr / checked(unchecked((nuint)(UIntPtr)n2H1.Default) - uIntPtr) == 0)
		{
			try
			{
			}
			catch
			{
				_ = (Ym89)(object)n2H1.Default;
			}
		}
		if (uIntPtr == 0)
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		else
		{
			try
			{
				_ = (t8X9)(object)n2H1.Default;
			}
			catch
			{
				try
				{
					pd = pd;
				}
				finally
				{
					_ = (Ge4b)(object)n2H1.Default;
					ym = (Ym89)(object)n2H1.Default;
					goto end_IL_058a;
				}
				end_IL_058a:;
			}
		}
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
			return;
		}
		finally
		{
			_ = (y4B7)(object)n2H1.Default;
			return;
		}
		IL_0367:
		try
		{
			while ((object)n2H1.Default != null)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				while (obj3 != null)
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
		}
		do
		{
			_ = (w4M5)(object)n2H1.Default;
		}
		while ((object)n2H1.Default != null);
		try
		{
			try
			{
				do
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				while (obj3 != null);
			}
			catch
			{
				try
				{
					t8X9 obj15 = (t8X9)(object)n2H1.Default;
					t8X9 t8X = t8X;
					t8X = obj15;
				}
				catch
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
				}
			}
		}
		catch
		{
			try
			{
				_ = (d3CT)(object)n2H1.Default;
			}
			catch
			{
				_ = (Pd01)(object)n2H1.Default;
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (Ym89)(object)n2H1.Default;
					ym = ym;
				}
				goto end_IL_03fe;
			}
			end_IL_03fe:;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = n2H1.Default;
				}
				finally
				{
					w4M = (w4M5)(object)n2H1.Default;
					continue;
				}
			}
			while (obj3 != null);
		}
		else
		{
			while (obj3 != null)
			{
				if (uIntPtr == 0)
				{
				}
			}
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				y4B7 y4B8 = (y4B7)(object)n2H1.Default;
			}
		}
		w4M = w4M;
		try
		{
			while (obj3 != null)
			{
				try
				{
					n2H = n2H;
				}
				finally
				{
					_ = (Xq18)(object)n2H1.Default;
					continue;
				}
			}
		}
		finally
		{
			try
			{
				ld7n = ld7n;
			}
			catch
			{
				w4M = w4M;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_003CModule_003E = null;
				}
				goto IL_04ea;
			}
		}
	}
}
