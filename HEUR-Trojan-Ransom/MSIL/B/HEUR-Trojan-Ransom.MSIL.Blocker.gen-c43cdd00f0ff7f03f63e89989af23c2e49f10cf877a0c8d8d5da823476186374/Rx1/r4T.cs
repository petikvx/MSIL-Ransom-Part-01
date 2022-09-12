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
using c9T;
using f1X;

namespace Rx1;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class r4T
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class c4H
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool e8R(object Pg1)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Pg1));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int i6L()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type r5Z()
		{
			return typeof(c4H);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Jf8()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static d5S c2C<d5S>(d5S Xx7) where d5S : new()
		{
			if (Xx7 == null)
			{
				return new d5S();
			}
			return Xx7;
		}

		[DebuggerHidden]
		private void j6S<w3M>(ref w3M m0H)
		{
			m0H = default(w3M);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public c4H()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Tn2<y8H> where y8H : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static y8H m_ThreadStaticValue;

		internal y8H GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new y8H();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Tn2()
		{
		}
	}

	private static readonly Tn2<Qb5> m_ComputerObjectProvider = new Tn2<Qb5>();

	private static readonly Tn2<x5W> m_AppObjectProvider = new Tn2<x5W>();

	private static readonly Tn2<User> m_UserObjectProvider = new Tn2<User>();

	private static readonly Tn2<c4H> m_MyWebServicesObjectProvider = new Tn2<c4H>();

	[HelpKeyword("My.Computer")]
	internal static Qb5 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static x5W Application
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
	internal static c4H WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
