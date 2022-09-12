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
using Ps2;
using c9P;

namespace Ji5;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Jd2
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Qs0
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Mj5(object Zp2)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Zp2));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int t7C()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type n3D()
		{
			return typeof(Qs0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string p7B()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static b7X Mw5<b7X>(b7X x3S) where b7X : new()
		{
			if (x3S == null)
			{
				return new b7X();
			}
			return x3S;
		}

		[DebuggerHidden]
		private void Jq0<r3P>(ref r3P Pc7)
		{
			Pc7 = default(r3P);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Qs0()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class d4M<La2> where La2 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static La2 m_ThreadStaticValue;

		internal La2 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new La2();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public d4M()
		{
		}
	}

	private static readonly d4M<s7Q> m_ComputerObjectProvider = new d4M<s7Q>();

	private static readonly d4M<Ky5> m_AppObjectProvider = new d4M<Ky5>();

	private static readonly d4M<User> m_UserObjectProvider = new d4M<User>();

	private static readonly d4M<Qs0> m_MyWebServicesObjectProvider = new d4M<Qs0>();

	[HelpKeyword("My.Computer")]
	internal static s7Q Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ky5 Application
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
	internal static Qs0 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
