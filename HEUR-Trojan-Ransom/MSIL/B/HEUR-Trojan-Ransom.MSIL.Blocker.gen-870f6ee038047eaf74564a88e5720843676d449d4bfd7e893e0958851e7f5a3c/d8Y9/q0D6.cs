using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bp2s;
using Hn20;
using Lg2q;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Nw4c;
using Rm76;
using Wj80;
using f7W1;
using m7A6;
using o7R3;
using t3B2;
using t4PD;

namespace d8Y9;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class q0D6
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ep4x
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Lm8t(object Td59)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Td59));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Bn57()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type o7NG()
		{
			return typeof(Ep4x);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string f3X4()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static e7D2 He29<e7D2>(e7D2 t6G7) where e7D2 : new()
		{
			if (t6G7 == null)
			{
				return new e7D2();
			}
			return t6G7;
		}

		[DebuggerHidden]
		private void Yi7p<Fm6c>(ref Fm6c j7BQ)
		{
			j7BQ = default(Fm6c);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ep4x()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class o4ZY<Wz4o> where Wz4o : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Wz4o m_ThreadStaticValue;

		internal Wz4o GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Wz4o();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public o4ZY()
		{
		}
	}

	private static readonly o4ZY<t8X9> m_ComputerObjectProvider = new o4ZY<t8X9>();

	private static readonly o4ZY<Ps93> m_AppObjectProvider = new o4ZY<Ps93>();

	private static readonly o4ZY<User> m_UserObjectProvider = new o4ZY<User>();

	private static readonly o4ZY<Ep4x> m_MyWebServicesObjectProvider = new o4ZY<Ep4x>();

	[HelpKeyword("My.Computer")]
	internal static t8X9 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ps93 Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Ep4x WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void a6MG()
	{
		Ps93 ps = ps;
		ps = ps;
		nuint num = num / checked(unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ym89 ym);
		if (num == 0)
		{
			try
			{
				ym = ym;
				ym = ym;
			}
			finally
			{
				ym = (Ym89)(object)n2H1.Default;
				goto IL_005f;
			}
		}
		if (num == 0)
		{
			if (num == 0)
			{
				_ = n2H1.Default;
			}
			else
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
		}
		goto IL_0092;
		IL_0328:
		_ = (Pd01)(object)n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		Pd01 pd;
		try
		{
			t8X = t8X;
		}
		finally
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					pd = null;
				}
			}
			goto IL_0352;
		}
		IL_005f:
		obj = null;
		goto IL_0092;
		IL_0134:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			do
			{
				try
				{
					_ = (w4M5)(object)n2H1.Default;
				}
				catch
				{
					_ = (t8X9)(object)n2H1.Default;
					_ = (Ym89)(object)n2H1.Default;
				}
			}
			while (obj != null);
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		if (num == 0)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				y4B = y4B;
				y4B = null;
				ps = ps;
				_ = (_003CModule_003E)(object)n2H1.Default;
				_003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		else if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (checked(num + num) == 0)
			{
				_ = (w4M5)(object)n2H1.Default;
			}
		}
		else
		{
			try
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			catch
			{
				t8X = t8X;
				t8X = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		while (obj != null)
		{
			ld7n = ld7n;
			ld7n = ld7n;
		}
		pd = null;
		pd = pd;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		try
		{
			if (num == 0)
			{
				_003CModule_003E = _003CModule_003E;
			}
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Ps93)(object)n2H1.Default;
			}
			else if ((nuint)(UIntPtr)n2H1.Default / num == 0)
			{
				w4M = w4M;
			}
			goto IL_0279;
		}
		IL_0505:
		do
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		while ((object)n2H1.Default != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d3CT d3CT);
		checked
		{
			if (unchecked((nuint)(UIntPtr)n2H1.Default) - unchecked((nuint)(UIntPtr)n2H1.Default) == 0)
			{
				d3CT = d3CT;
			}
			return;
		}
		IL_0279:
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E = (_003CModule_003E)(object)n2H1.Default;
		}
		else
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		try
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_003CModule_003E = _003CModule_003E;
				}
			}
			finally
			{
				try
				{
					pd = pd;
					d3CT = (d3CT)(object)n2H1.Default;
					ym = null;
				}
				catch
				{
					t8X = (t8X9)(object)n2H1.Default;
				}
				goto end_IL_02a5;
			}
			end_IL_02a5:;
		}
		finally
		{
			while ((object)n2H1.Default != null)
			{
				num = default(UIntPtr);
				if (num == (UIntPtr)(nuint)0u)
				{
					_ = (y4B7)(object)n2H1.Default;
				}
				else
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
			}
			goto IL_0328;
		}
		IL_0352:
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (y4B7)(object)n2H1.Default;
					ld7n = (Ld7n)(object)n2H1.Default;
					d3CT = null;
				}
				finally
				{
					_ = (_003CModule_003E)(object)n2H1.Default;
					goto end_IL_0362;
				}
				end_IL_0362:;
			}
			catch
			{
				try
				{
					ps = ps;
				}
				catch
				{
					ym = ym;
				}
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (Ps93)(object)n2H1.Default;
			}
		}
		catch
		{
			try
			{
				Ge4b ge4b = (Ge4b)(object)n2H1.Default;
				ge4b = ge4b;
			}
			finally
			{
				try
				{
					ym = ym;
				}
				catch
				{
					pd = (Pd01)(object)n2H1.Default;
				}
				goto end_IL_03c8;
			}
			end_IL_03c8:;
		}
		n2H1 n2H = n2H;
		n2H = null;
		try
		{
			try
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
			finally
			{
				_ = (t8X9)(object)n2H1.Default;
				_ = (Pd01)(object)n2H1.Default;
				pd = null;
				goto end_IL_040e;
			}
			end_IL_040e:;
		}
		finally
		{
			_ = (y4B7)(object)n2H1.Default;
			goto IL_0478;
		}
		IL_0092:
		do
		{
			w4M = w4M;
			w4M = w4M;
		}
		while (obj != null || obj != null);
		if (num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = n2H1.Default;
				}
				while ((object)n2H1.Default != null);
			}
		}
		else
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				finally
				{
					_ = (Ge4b)(object)n2H1.Default;
					goto IL_0134;
				}
			}
			try
			{
				_ = (q0D6)(object)n2H1.Default;
				_ = (q0D6)(object)n2H1.Default;
			}
			catch
			{
				_ = (t8X9)(object)n2H1.Default;
				d3CT = null;
				d3CT = null;
			}
		}
		goto IL_0134;
		IL_0478:
		while (obj != null)
		{
			try
			{
				ym = ym;
				_ = (d3CT)(object)n2H1.Default;
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					y4B = y4B;
				}
				continue;
			}
		}
		ld7n = null;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (t8X9)(object)n2H1.Default;
				}
				finally
				{
					y4B = y4B;
					_ = n2H1.Default;
					w4M = w4M;
					goto IL_0505;
				}
			}
			goto IL_0505;
		}
		try
		{
			try
			{
				_ = (Xq18)(object)n2H1.Default;
			}
			finally
			{
				_ = (t8X9)(object)n2H1.Default;
				goto end_IL_04ce;
			}
			end_IL_04ce:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				d3CT = d3CT;
			}
			goto IL_0505;
		}
	}

	static void o2Z4()
	{
		_ = (_003CModule_003E)(object)n2H1.Default;
		_ = (d3CT)(object)n2H1.Default;
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y4B7 y4B);
		if (uIntPtr == 0)
		{
			_ = (Xq18)(object)n2H1.Default;
		}
		else
		{
			_ = (q0D6)(object)n2H1.Default;
			_ = (w4M5)(object)n2H1.Default;
			y4B = y4B;
			y4B = y4B;
		}
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		Ym89 ym;
		while (true)
		{
			obj = n2H1.Default;
			if (obj == null)
			{
				break;
			}
			try
			{
				while ((object)n2H1.Default != null)
				{
					_ = n2H1.Default;
				}
			}
			catch
			{
				try
				{
					Ym89 obj2 = (Ym89)(object)n2H1.Default;
					ym = (Ym89)(object)n2H1.Default;
					ym = obj2;
				}
				finally
				{
					_003CModule_003E = null;
					_003CModule_003E = _003CModule_003E;
					goto end_IL_008a;
				}
				end_IL_008a:;
			}
		}
		while ((object)n2H1.Default != null)
		{
			_ = (w4M5)(object)n2H1.Default;
			_ = n2H1.Default;
		}
		_ = n2H1.Default;
		_ = (w4M5)(object)n2H1.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ps93 ps);
		try
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					_ = (w4M5)(object)n2H1.Default;
					y4B = y4B;
					_ = (Ld7n)(object)n2H1.Default;
					_ = (w4M5)(object)n2H1.Default;
				}
				else
				{
					ps = ps;
					ps = ps;
				}
			}
			finally
			{
				_ = (Pd01)(object)n2H1.Default;
				goto end_IL_0108;
			}
			end_IL_0108:;
		}
		finally
		{
			_ = (Ps93)(object)n2H1.Default;
			ym = (Ym89)(object)n2H1.Default;
			goto IL_017c;
		}
		IL_0605:
		while (obj != null)
		{
			do
			{
				_ = (d3CT)(object)n2H1.Default;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q0D6 q0D7);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ld7n ld7n);
		try
		{
			try
			{
				ld7n = (Ld7n)(object)n2H1.Default;
			}
			catch
			{
				_ = (y4B7)(object)n2H1.Default;
				q0D7 = null;
			}
		}
		catch
		{
			do
			{
				try
				{
					_ = n2H1.Default;
				}
				catch
				{
					_ = (Pd01)(object)n2H1.Default;
				}
			}
			while (obj != null);
		}
		try
		{
			while (obj != null)
			{
				_ = (Xq18)(object)n2H1.Default;
			}
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			nuint num = uIntPtr;
			uIntPtr = default(UIntPtr);
			nuint num2 = num / uIntPtr;
			uIntPtr = default(UIntPtr);
			if (num2 / uIntPtr == 0)
			{
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
		}
		finally
		{
			ps = ps;
			goto IL_06b6;
		}
		IL_04f8:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ge4b ge4b);
		try
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					_ = n2H1.Default;
				}
				else
				{
					ge4b = ge4b;
				}
			}
		}
		finally
		{
			try
			{
				while ((object)n2H1.Default != null)
				{
					y4B = y4B;
				}
			}
			catch
			{
				try
				{
					_ = n2H1.Default;
				}
				finally
				{
					_ = (q0D6)(object)n2H1.Default;
					goto end_IL_0541;
				}
				end_IL_0541:;
			}
			goto IL_0560;
		}
		IL_0591:
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					ge4b = null;
				}
				finally
				{
					d3CT d3CT = null;
					goto end_IL_0592;
				}
			}
			try
			{
				_ = (w4M5)(object)n2H1.Default;
			}
			catch
			{
				_ = (d3CT)(object)n2H1.Default;
			}
			end_IL_0592:;
		}
		finally
		{
			try
			{
				if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
				{
					ps = ps;
				}
			}
			finally
			{
				_ = (Ps93)(object)n2H1.Default;
				goto IL_0605;
			}
		}
		IL_06b6:
		if (uIntPtr == 0)
		{
			try
			{
				ym = ym;
			}
			finally
			{
				_ = (Ym89)(object)n2H1.Default;
				goto IL_06d4;
			}
		}
		goto IL_06d4;
		IL_06d4:
		_ = (t8X9)(object)n2H1.Default;
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			d3CT d3CT = null;
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Ge4b)(object)n2H1.Default;
			}
			catch
			{
				ge4b = null;
				_ = (Xq18)(object)n2H1.Default;
				_ = (_003CModule_003E)(object)n2H1.Default;
			}
		}
		try
		{
			ym = ym;
		}
		finally
		{
			goto IL_0733;
		}
		IL_017c:
		_003CModule_003E = ((uIntPtr != 0) ? ((_003CModule_003E)(object)n2H1.Default) : _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n2H1 n2H);
		checked
		{
			if (unchecked((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u) && unchecked((nuint)(UIntPtr)n2H1.Default) + uIntPtr * unchecked((nuint)default(UIntPtr)) == 0)
			{
				try
				{
					ge4b = (Ge4b)(object)n2H1.Default;
					ge4b = ge4b;
				}
				catch
				{
					n2H1 obj11 = n2H1.Default;
					n2H = null;
					n2H = obj11;
				}
			}
			_003CModule_003E = _003CModule_003E;
			_003CModule_003E = _003CModule_003E;
			uIntPtr = default(UIntPtr);
			if (uIntPtr + uIntPtr == 0)
			{
				while (obj != null)
				{
					try
					{
						_ = (q0D6)(object)n2H1.Default;
					}
					finally
					{
						_003CModule_003E = null;
						continue;
					}
				}
				goto IL_026c;
			}
			try
			{
				try
				{
					_ = (Ld7n)(object)n2H1.Default;
				}
				finally
				{
					_ = (t8X9)(object)n2H1.Default;
					goto end_IL_0239;
				}
				end_IL_0239:;
			}
			finally
			{
				while ((object)n2H1.Default != null)
				{
					y4B = null;
				}
				goto IL_026c;
			}
		}
		IL_026c:
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out t8X9 t8X);
		checked
		{
			if (uIntPtr == 0 && uIntPtr + unchecked((nuint)(UIntPtr)n2H1.Default / uIntPtr) == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr * uIntPtr == 0)
				{
					_ = (q0D6)(object)n2H1.Default;
					d3CT d3CT = d3CT;
					d3CT = d3CT;
				}
				else
				{
					t8X = (t8X9)(object)n2H1.Default;
					t8X = t8X;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out w4M5 w4M);
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
			{
				uIntPtr = default(UIntPtr);
				nuint num3 = uIntPtr / uIntPtr;
				UIntPtr num4 = (UIntPtr)n2H1.Default;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (num3 + unchecked((nuint)num4 / uIntPtr) == 0)
					{
						d3CT d3CT = null;
						ym = (Ym89)(object)n2H1.Default;
						ge4b = (Ge4b)(object)n2H1.Default;
					}
				}
			}
			else if (uIntPtr == 0)
			{
				_ = (t8X9)(object)n2H1.Default;
			}
		}
		else
		{
			while (obj != null)
			{
				try
				{
					_ = (Ym89)(object)n2H1.Default;
				}
				catch
				{
					w4M = (w4M5)(object)n2H1.Default;
					w4M = null;
				}
			}
		}
		while (true)
		{
			if (obj != null)
			{
				do
				{
					q0D7 = q0D7;
					q0D7 = q0D7;
				}
				while (obj != null);
			}
			else if (obj == null)
			{
				break;
			}
		}
		while (obj != null)
		{
			_ = (_003CModule_003E)(object)n2H1.Default;
		}
		if (uIntPtr == 0)
		{
			try
			{
				while (obj != null)
				{
					_ = (t8X9)(object)n2H1.Default;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Ps93)(object)n2H1.Default;
				}
			}
		}
		else
		{
			w4M = w4M;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pd01 pd);
		do
		{
			UIntPtr num5 = (UIntPtr)n2H1.Default;
			uIntPtr = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)num5) + uIntPtr != 0)
				{
					try
					{
						_ = (Pd01)(object)n2H1.Default;
					}
					catch
					{
						ld7n = (Ld7n)(object)n2H1.Default;
						ld7n = ld7n;
					}
				}
				else
				{
					pd = pd;
					pd = pd;
					_ = (Pd01)(object)n2H1.Default;
					_ = (t8X9)(object)n2H1.Default;
					n2H = n2H1.Default;
				}
			}
		}
		while ((object)n2H1.Default != null);
		do
		{
			_ = (d3CT)(object)n2H1.Default;
		}
		while ((object)n2H1.Default != null);
		try
		{
			_ = (y4B7)(object)n2H1.Default;
		}
		finally
		{
			try
			{
				_ = (Pd01)(object)n2H1.Default;
				_ = (_003CModule_003E)(object)n2H1.Default;
				ld7n = null;
				_ = (Ps93)(object)n2H1.Default;
			}
			catch
			{
				do
				{
					ld7n = ld7n;
				}
				while ((object)n2H1.Default != null);
			}
			goto IL_04f8;
		}
		IL_0560:
		do
		{
			_ = (y4B7)(object)n2H1.Default;
		}
		while ((object)n2H1.Default != null);
		try
		{
			n2H = n2H;
		}
		finally
		{
			ym = (Ym89)(object)n2H1.Default;
			goto IL_0591;
		}
		IL_0733:
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (Pd01)(object)n2H1.Default;
		}
		if ((UIntPtr)n2H1.Default == (UIntPtr)(nuint)0u)
		{
			t8X = t8X;
		}
	}
}
