using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Fa32;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using e7GT;

namespace Gf9;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class y6M
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class g7P
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool x6D(object At6)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(At6));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Td2()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type o0Q()
		{
			return typeof(g7P);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Sp9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static d9Y m4Y<d9Y>(d9Y Kk0) where d9Y : new()
		{
			if (Kk0 == null)
			{
				return new d9Y();
			}
			return Kk0;
		}

		[DebuggerHidden]
		private void f5B<p7T>(ref p7T Tx9)
		{
			Tx9 = default(p7T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public g7P()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Fs4<Rz1> where Rz1 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static Rz1 m_ThreadStaticValue;

		internal Rz1 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Rz1();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Fs4()
		{
		}
	}

	private static readonly Fs4<Da28> m_ComputerObjectProvider = new Fs4<Da28>();

	private static readonly Fs4<Ln13> m_AppObjectProvider = new Fs4<Ln13>();

	private static readonly Fs4<User> m_UserObjectProvider = new Fs4<User>();

	private static readonly Fs4<g7P> m_MyWebServicesObjectProvider = new Fs4<g7P>();

	[HelpKeyword("My.Computer")]
	internal static Da28 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Ln13 Application
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
	internal static g7P WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
