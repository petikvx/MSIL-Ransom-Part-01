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
using Xp2;
using j3F;

namespace g9A;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Nb1
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Ey8
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool f7X(object m0K)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(m0K));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int g2X()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type i2A()
		{
			return typeof(Ey8);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Ro8()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static i5P Px2<i5P>(i5P Zb0) where i5P : new()
		{
			if (Zb0 == null)
			{
				return new i5P();
			}
			return Zb0;
		}

		[DebuggerHidden]
		private void Ep9<Zy3>(ref Zy3 a3Q)
		{
			a3Q = default(Zy3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Ey8()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class k9H<Md5> where Md5 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Md5 m_ThreadStaticValue;

		internal Md5 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Md5();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public k9H()
		{
		}
	}

	private static readonly k9H<w7C> m_ComputerObjectProvider = new k9H<w7C>();

	private static readonly k9H<t0F> m_AppObjectProvider = new k9H<t0F>();

	private static readonly k9H<User> m_UserObjectProvider = new k9H<User>();

	private static readonly k9H<Ey8> m_MyWebServicesObjectProvider = new k9H<Ey8>();

	[HelpKeyword("My.Computer")]
	internal static w7C Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static t0F Application
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
	internal static Ey8 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
