using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ay6b0;
using En4j1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using a4J8;
using a9X5Lj;
using b1FGj4;
using c6T1;
using d4TYs8;
using e7G6;
using i1ZAj;
using n4WNr6;
using p3R2Bk;
using r7FGf;
using z4CFw3;

namespace Gz67Tp;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class z1X8Wt
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class b5FQm1
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool e1CWp6(object r4F3Ly)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(r4F3Ly));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int s1T3Af()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type f0ZDr1()
		{
			return typeof(b5FQm1);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string d4Z6Rm()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static p3FMn6 Ti02Gx<p3FMn6>(p3FMn6 i5Z8Bm) where p3FMn6 : new()
		{
			if (i5Z8Bm == null)
			{
				return new p3FMn6();
			}
			return i5Z8Bm;
		}

		[DebuggerHidden]
		private void b1LYr3<Mq9n1Q>(ref Mq9n1Q Bc40Zt)
		{
			Bc40Zt = default(Mq9n1Q);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public b5FQm1()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class At49To<t5EXp8> where t5EXp8 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static t5EXp8 m_ThreadStaticValue;

		internal t5EXp8 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new t5EXp8();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public At49To()
		{
		}
	}

	private static readonly At49To<Hn0x4W> m_ComputerObjectProvider = new At49To<Hn0x4W>();

	private static readonly At49To<Fx3n6R> m_AppObjectProvider = new At49To<Fx3n6R>();

	private static readonly At49To<User> m_UserObjectProvider = new At49To<User>();

	private static readonly At49To<b5FQm1> m_MyWebServicesObjectProvider = new At49To<b5FQm1>();

	[HelpKeyword("My.Computer")]
	internal static Hn0x4W Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Fx3n6R Application
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
	internal static b5FQm1 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	static void Re60Xn()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0W2 f0W);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mn3s8 mn3s);
		try
		{
			try
			{
				while (((q2A7D)((Mn3s8)(object)((f0W2)(object)g7FZc5.Default).Text).GroupBox2).ErrorProvider1 != null)
				{
					_003CModule_003E = (_003CModule_003E)Yp0w5.OK;
					_003CModule_003E = null;
					_ = (_003CModule_003E)Yp0w5.Button1;
				}
			}
			finally
			{
				try
				{
					Ey0e9Q ey0e9Q = null;
					_ = (Xj70)ey0e9Q.ErrorProvider1;
				}
				catch
				{
					f0W = null;
					_ = (f0W2)f0W.GroupBox2;
				}
				goto end_IL_0000;
			}
			end_IL_0000:;
		}
		finally
		{
			try
			{
				_ = (g7FZc5)Mn3s8.Button1;
				_003CModule_003E = null;
				mn3s = mn3s;
				mn3s = mn3s;
			}
			finally
			{
				try
				{
					mn3s = (Mn3s8)p5A6T.Button1;
					f0W = (f0W2)(object)o2FH.Ee91();
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (Hn0x4W)((Xj70)Ey0e9Q.Button1).ErrorProvider1;
					goto IL_00e5;
				}
			}
		}
		IL_00e5:
		Ft83Xn ft83Xn = (Ft83Xn)Ey0e9Q.Button1;
		ft83Xn = ft83Xn;
		_ = (q2A7D)p5A6T.OK;
		UIntPtr uIntPtr = uIntPtr;
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Xj70)(object)((q2A7D)Xj70.Button1).Text;
			}
			finally
			{
				ft83Xn = null;
				_ = (Ey0e9Q)Xj70.Button1;
				_ = (Fa16Ls)Mn3s8.OK;
				_ = (q2A7D)((Mn3s8)(object)g7FZc5.Default).GroupBox2;
				goto IL_017a;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z1X8Wt z1X8Wt2);
		try
		{
			_ = (Fx3n6R)p5A6T.OK;
		}
		finally
		{
			z1X8Wt2 = null;
			z1X8Wt2 = z1X8Wt2;
			goto IL_017a;
		}
		IL_017a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Xj70 xj);
		q2A7D q2A7D;
		checked
		{
			try
			{
				if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)q2A7D.OK) == 0)
				{
					while (true)
					{
						xj = xj;
						if (xj.ErrorProvider1 != null)
						{
							mn3s = null;
							_ = (p5A6T)(object)f0W.Text;
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				q2A7D obj2 = (q2A7D)(object)o2FH.Ee91();
				q2A7D = null;
				q2A7D = obj2;
				goto IL_022b;
			}
		}
		IL_022b:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			if (default(UIntPtr) != (UIntPtr)(nuint)0u)
			{
				obj3 = null;
				continue;
			}
			try
			{
				_ = (z1X8Wt)Xj70.OK;
				_ = (Ft83Xn)(object)o2FH.Ee91();
				_ = (p5A6T)f0W.GroupBox2;
				_ = (z1X8Wt)(object)g7FZc5.Default;
			}
			catch
			{
				z1X8Wt2 = z1X8Wt2;
			}
		}
		while ((object)o2FH.Ee91() != null);
		do
		{
			try
			{
				xj = xj;
			}
			catch
			{
				_ = (g7FZc5)(object)mn3s.Text;
			}
		}
		while ((object)q2A7D.Text != null || obj3 != null);
		p5A6T p5A6T;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			p5A6T = null;
			if ((UIntPtr)p5A6T.Text == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (g7FZc5)((Mn3s8)(object)g7FZc5.Default).ErrorProvider1;
				}
				while (obj3 != null);
			}
		}
		else
		{
			do
			{
				ft83Xn = ft83Xn;
				_ = (Fx3n6R)Xj70.Button1;
				_ = (Ey0e9Q)((Ey0e9Q)null).GroupBox2;
				_ = (o2FH)Ey0e9Q.Button1;
			}
			while (obj3 != null);
		}
		Yp0w5 yp0w = (Yp0w5)(object)((f0W2)null).Text;
		_ = (Fa16Ls)(object)yp0w.Text;
		_ = (Fa16Ls)Xj70.OK;
		p5A6T = null;
		_ = (f0W2)mn3s.GroupBox2;
		do
		{
			Ey0e9Q ey0e9Q = null;
		}
		while (obj3 != null || obj3 != null);
		mn3s = mn3s;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o2FH o2FH);
		while (((Ey0e9Q)((Mn3s8)null).ErrorProvider1).GroupBox2 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Ft83Xn)(object)g7FZc5.Default;
					_ = (g7FZc5)Ey0e9Q.Button1;
					_ = (Mn3s8)((p5A6T)null).GroupBox2;
					_ = (Ey0e9Q)(object)((p5A6T)null).Text;
				}
				finally
				{
					_ = (Fx3n6R)((Ey0e9Q)q2A7D.OK).ErrorProvider1;
					continue;
				}
			}
			try
			{
				o2FH = o2FH;
				o2FH = null;
			}
			finally
			{
				_ = (_003CModule_003E)(object)o2FH.Ee91();
				_ = (_003CModule_003E)(object)o2FH.Ee91();
				continue;
			}
		}
	}
}
