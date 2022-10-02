using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ag14Na;
using Ag80Sw;
using Kb0k6R;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Tp7z2P;
using n4B1Pm;
using p2Y1Em;
using p6F5Wj;
using r7SMc5;
using r8XBa2;
using t1KNi0;
using t6MNx0;
using t8J4Ef;
using x2ZBs0;
using x5Q4Lq;
using x7D4Ck;
using x9LFg6;
using y8PQt3;

namespace Kz92Sn;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class z2S7Ta
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class t1A5Rz
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Sq68Ng(object Ba0f1K)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ba0f1K));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int o2FZc9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Xz7k0P()
		{
			_Type typeFromHandle = (_Type)(object)typeof(t1A5Rz);
			return (Type)(object)typeFromHandle;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string y6SZe8()
		{
			IComparable<string> comparable = base.ToString();
			return comparable as string;
		}

		private static Mj69Az Wn15Aj<Mj69Az>(Mj69Az Pt02Bp) where Mj69Az : new()
		{
			if (Pt02Bp == null)
			{
				return new Mj69Az();
			}
			return Pt02Bp;
		}

		private void Bq52Gf<Jw87Kz>(ref Jw87Kz Rc74Eb)
		{
			Rc74Eb = default(Jw87Kz);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public t1A5Rz()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class b1T4Zo<r7Z2Kq> where r7Z2Kq : new()
	{
		[ThreadStatic]
		private static r7Z2Kq m_ThreadStaticValue;

		internal r7Z2Kq GetInstance
		{
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new r7Z2Kq();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public b1T4Zo()
		{
		}
	}

	private static readonly b1T4Zo<Gd43Lj> m_ComputerObjectProvider = new b1T4Zo<Gd43Lj>();

	private static readonly b1T4Zo<Di35Ts> m_AppObjectProvider = new b1T4Zo<Di35Ts>();

	private static readonly b1T4Zo<User> m_UserObjectProvider = new b1T4Zo<User>();

	private static readonly b1T4Zo<t1A5Rz> m_MyWebServicesObjectProvider = new b1T4Zo<t1A5Rz>();

	[HelpKeyword("My.Computer")]
	internal static Gd43Lj Computer
	{
		get
		{
			object getInstance = m_ComputerObjectProvider.GetInstance;
			return (Gd43Lj)getInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Di35Ts Application
	{
		get
		{
			object getInstance = m_AppObjectProvider.GetInstance;
			return (Di35Ts)getInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		get
		{
			object getInstance = m_UserObjectProvider.GetInstance;
			return (User)((getInstance is User) ? getInstance : null);
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static t1A5Rz WebServices
	{
		get
		{
			object getInstance = m_MyWebServicesObjectProvider.GetInstance;
			return getInstance as t1A5Rz;
		}
	}

	static void Hc8r5T()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qf50Jc qf50Jc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gf7z4M gf7z4M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		try
		{
			Gf7z4M obj = (Gf7z4M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
			gf7z4M = gf7z4M;
			gf7z4M = obj;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			uIntPtr = default(UIntPtr);
			if (uIntPtr != 0)
			{
				try
				{
					Nw9r7H nw9r7H = (Nw9r7H)(object)((Qf50Jc)null).ListView1;
					nw9r7H = nw9r7H;
				}
				finally
				{
					_ = (Gd43Lj)(object)Sg5c1M.Default;
					goto end_IL_0022;
				}
			}
			if ((UIntPtr)((Qf50Jc)null).ListView1 == (UIntPtr)(nuint)0u)
			{
				_ = (Nw9r7H)(object)Sg5c1M.Default;
			}
			else
			{
				qf50Jc = qf50Jc;
				_ = (Ns12Zw)(object)qf50Jc.ListView1;
			}
			end_IL_0022:;
		}
		if (uIntPtr == 0)
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				_ = (Xe4g3L)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
			}
		}
		else if (checked(uIntPtr - uIntPtr) == 0)
		{
			if (uIntPtr == 0)
			{
				Cy89Fz cy89Fz = cy89Fz;
				cy89Fz = cy89Fz;
			}
			else
			{
				_ = (Qf50Jc)(object)Sg5c1M.Default;
			}
		}
		else
		{
			try
			{
				_ = (z2S7Ta)(object)qf50Jc.ListView1;
			}
			catch
			{
				_ = (Di35Ts)(object)Sg5c1M.Default;
			}
		}
		_ = (Gd43Lj)(object)((Qf50Jc)null).ListView1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		if (uIntPtr == 0)
		{
			qf50Jc = qf50Jc;
			_ = (_003CModule_003E)(object)Sg5c1M.Default;
			_ = (Ag58Qx)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
		}
		else
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (_003CModule_003E)(object)((Qf50Jc)null).ListView1;
				_ = (Qf50Jc)(object)Sg5c1M.Default;
				gf7z4M = gf7z4M;
			}
			else
			{
				_ = (_003CModule_003E)(object)Sg5c1M.Default;
			}
			obj4 = null;
		}
		_ = (Dq6e2L)(object)Sg5c1M.Default;
		uIntPtr = default(UIntPtr);
		UIntPtr num = uIntPtr;
		UIntPtr num2 = uIntPtr;
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wk4s1B wk4s1B);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Ag58Qx ag58Qx);
		_003CModule_003E _003CModule_003E;
		checked
		{
			if (unchecked((nuint)num) - (unchecked((nuint)num2) + uIntPtr) == 0)
			{
				if (uIntPtr == 0)
				{
					while (obj4 != null)
					{
						_ = (Xe4g3L)(object)Sg5c1M.Default;
						Nw9r7H nw9r7H = null;
						_003CModule_003E = null;
						_003CModule_003E = _003CModule_003E;
						ag58Qx = ag58Qx;
					}
				}
				else
				{
					while ((object)Sg5c1M.Default != null)
					{
						_ = (s7TYc5)(object)((Qf50Jc)null).ListView1;
					}
				}
			}
			wk4s1B = wk4s1B;
			wk4s1B = default(Wk4s1B);
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					_003CModule_003E = null;
				}
			}
			else
			{
				if (uIntPtr != 0)
				{
					try
					{
						_ = (Gd43Lj)(object)((Qf50Jc)(object)((Qf50Jc)null).ListView1).ListView1;
					}
					finally
					{
						Sg5c1M sg5c1M = Sg5c1M.Default;
						sg5c1M = sg5c1M;
						_ = (Sg5c1M)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
						_ = (Cy89Fz)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
						_ = (Di35Ts)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
						goto IL_02df;
					}
				}
				_ = (a2K0Zg)(object)Sg5c1M.Default;
			}
			goto IL_02df;
		}
		IL_02df:
		try
		{
			while (obj4 != null)
			{
				UIntPtr num3 = (UIntPtr)qf50Jc.ListView1;
				nuint num4 = uIntPtr;
				uIntPtr = default(UIntPtr);
				checked
				{
					if (unchecked((nuint)num3) + (num4 + uIntPtr) == 0)
					{
						_ = (Cy89Fz)(object)Sg5c1M.Default;
					}
					else
					{
						_ = (a2K0Zg)(object)Sg5c1M.Default;
					}
				}
			}
		}
		finally
		{
			_ = (Qf50Jc)(object)((Qf50Jc)null).ListView1;
			_003CModule_003E = null;
			_ = (Di35Ts)(object)qf50Jc.ListView1;
			_ = (a2K0Zg)(object)Sg5c1M.Default;
			goto IL_0354;
		}
		IL_0614:
		_ = (o9A2Ym)(object)Sg5c1M.Default;
		uIntPtr = default(UIntPtr);
		checked
		{
			if (uIntPtr + (uIntPtr - unchecked((nuint)default(UIntPtr))) != 0)
			{
				return;
			}
		}
		do
		{
			if ((UIntPtr)Sg5c1M.Default != (UIntPtr)(nuint)0u)
			{
				qf50Jc = qf50Jc;
			}
			else
			{
				_ = (Qf50Jc)(object)qf50Jc.ListView1;
			}
		}
		while (obj4 != null);
		return;
		IL_0354:
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Sg5c1M.Default == 0)
		{
			do
			{
				_ = (Gd43Lj)(object)Sg5c1M.Default;
			}
			while (obj4 != null);
		}
		else
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out i9XEz8 i9XEz);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Dq6e2L dq6e2L);
			while (obj4 != null)
			{
				try
				{
					Sg5c1M sg5c1M = Sg5c1M.Default;
					i9XEz = i9XEz;
					i9XEz = default(i9XEz8);
					i9XEz = i9XEz;
					_ = (Nw9r7H)(object)((Qf50Jc)null).ListView1;
					Dq6e2L obj5 = (Dq6e2L)(object)Sg5c1M.Default;
					dq6e2L = dq6e2L;
					dq6e2L = obj5;
				}
				finally
				{
					_ = (Dq6e2L)(object)Sg5c1M.Default;
					continue;
				}
			}
		}
		while (obj4 != null)
		{
			_ = (Nw9r7H)(object)((Qf50Jc)null).ListView1;
		}
		_003CModule_003E = (_003CModule_003E)(object)((Qf50Jc)(object)Sg5c1M.Default).ListView1;
		while ((object)((Qf50Jc)null).ListView1 != null)
		{
			Cy89Fz cy89Fz = (Cy89Fz)(object)Sg5c1M.Default;
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			_ = (o9A2Ym)(object)qf50Jc.ListView1;
		}
		else
		{
			try
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Gf7z4M)(object)((Qf50Jc)(object)qf50Jc.ListView1).ListView1;
				}
				else
				{
					_ = (a2K0Zg)(object)qf50Jc.ListView1;
				}
			}
			catch
			{
				Nw9r7H nw9r7H = (Nw9r7H)(object)Sg5c1M.Default;
			}
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Rx3a7Y rx3a7Y);
			do
			{
				if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
				{
					rx3a7Y = rx3a7Y;
					rx3a7Y = null;
				}
			}
			while ((object)Sg5c1M.Default != null);
		}
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == (UIntPtr)(nuint)0u)
			{
				ag58Qx = ag58Qx;
				_ = (Cy89Fz)(object)Sg5c1M.Default;
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				z2S7Ta z2S7Ta2 = null;
				z2S7Ta2 = z2S7Ta2;
			}
		}
		_ = (o9A2Ym)(object)Sg5c1M.Default;
		while (obj4 != null)
		{
			while (true)
			{
				if (obj4 != null)
				{
					_ = (a2K0Zg)(object)Sg5c1M.Default;
				}
				else if (obj4 == null)
				{
					break;
				}
			}
		}
		UIntPtr num5 = uIntPtr;
		uIntPtr = default(UIntPtr);
		checked
		{
			if ((unchecked((nuint)num5) + uIntPtr) * uIntPtr * uIntPtr == 0)
			{
				Sg5c1M sg5c1M = (Sg5c1M)(object)qf50Jc.ListView1;
			}
		}
		try
		{
			_ = (Wk4s1B)Sg5c1M.Default;
			_ = (Wk4s1B)qf50Jc.ListView1;
			_ = (Dq6e2L)(object)qf50Jc.ListView1;
			_ = (_003CModule_003E)(object)Sg5c1M.Default;
		}
		catch
		{
			if ((UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u && (UIntPtr)Sg5c1M.Default == (UIntPtr)(nuint)0u)
			{
				_ = (o9A2Ym)(object)((Qf50Jc)null).ListView1;
			}
		}
		try
		{
			try
			{
				do
				{
					wk4s1B = wk4s1B;
				}
				while ((object)qf50Jc.ListView1 != null);
			}
			finally
			{
				_ = (a2K0Zg)(object)qf50Jc.ListView1;
				goto end_IL_05c7;
			}
			end_IL_05c7:;
		}
		finally
		{
			try
			{
				_ = (_003CModule_003E)(object)Sg5c1M.Default;
			}
			catch
			{
				_ = (Ag58Qx)(object)Sg5c1M.Default;
			}
			goto IL_0614;
		}
	}
}
