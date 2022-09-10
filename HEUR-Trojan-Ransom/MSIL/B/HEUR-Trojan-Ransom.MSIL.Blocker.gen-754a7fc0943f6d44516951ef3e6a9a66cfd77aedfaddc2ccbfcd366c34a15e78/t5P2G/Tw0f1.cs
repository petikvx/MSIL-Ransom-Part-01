using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Qg52D;
using z0B8Z;

namespace t5P2G;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class Tw0f1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class f6SKq
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool x1L4C(object n0GSj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(n0GSj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int o1CNa()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Ck6e9()
		{
			return typeof(f6SKq);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string Qb7o9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Kb31B m0T7D<Kb31B>(Kb31B Ns1e5) where Kb31B : new()
		{
			if (Ns1e5 == null)
			{
				return new Kb31B();
			}
			return Ns1e5;
		}

		[DebuggerHidden]
		private void x8M4J<Zf3a6>(ref Zf3a6 t1P3Y)
		{
			t1P3Y = default(Zf3a6);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public f6SKq()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class t7FPq<a8PYc> where a8PYc : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static a8PYc m_ThreadStaticValue;

		internal a8PYc GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new a8PYc();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public t7FPq()
		{
		}
	}

	private static readonly t7FPq<Zz21N> m_ComputerObjectProvider = new t7FPq<Zz21N>();

	private static readonly t7FPq<Qi79E> m_AppObjectProvider = new t7FPq<Qi79E>();

	private static readonly t7FPq<User> m_UserObjectProvider = new t7FPq<User>();

	private static readonly t7FPq<f6SKq> m_MyWebServicesObjectProvider = new t7FPq<f6SKq>();

	[HelpKeyword("My.Computer")]
	internal static Zz21N Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Qi79E Application
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
	internal static f6SKq WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
