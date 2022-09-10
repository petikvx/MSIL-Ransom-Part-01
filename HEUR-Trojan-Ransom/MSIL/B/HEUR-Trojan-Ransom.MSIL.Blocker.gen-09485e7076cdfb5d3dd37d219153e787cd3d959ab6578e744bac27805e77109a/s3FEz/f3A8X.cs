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
using Wt7x6;
using x7X6P;

namespace s3FEz;

[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
internal sealed class f3A8X
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class r1K5P
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool g6FXk(object e0T3R)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(e0T3R));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int Lw2b9()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type Mc9k6()
		{
			return typeof(r1K5P);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string He2r9()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static x6W5L Aa0b1<x6W5L>(x6W5L Mk51P) where x6W5L : new()
		{
			if (Mk51P == null)
			{
				return new x6W5L();
			}
			return Mk51P;
		}

		[DebuggerHidden]
		private void Yj2o1<z6B2D>(ref z6B2D Rx5g0)
		{
			Rx5g0 = default(z6B2D);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public r1K5P()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class n0XQc<Bd02R> where Bd02R : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Bd02R m_ThreadStaticValue;

		internal Bd02R GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Bd02R();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public n0XQc()
		{
		}
	}

	private static readonly n0XQc<Fa35A> m_ComputerObjectProvider = new n0XQc<Fa35A>();

	private static readonly n0XQc<o7Z3F> m_AppObjectProvider = new n0XQc<o7Z3F>();

	private static readonly n0XQc<User> m_UserObjectProvider = new n0XQc<User>();

	private static readonly n0XQc<r1K5P> m_MyWebServicesObjectProvider = new n0XQc<r1K5P>();

	[HelpKeyword("My.Computer")]
	internal static Fa35A Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static o7Z3F Application
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
	internal static r1K5P WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
