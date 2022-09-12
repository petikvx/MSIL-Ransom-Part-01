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
using Tt1;
using s1Z;

namespace z1Y;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Pk3
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Zt6
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool s8P(object b9Z)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(b9Z));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Xs6()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Dp7()
		{
			return typeof(Zt6);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string En7()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static Dz2 Tb1<Dz2>(Dz2 k7B) where Dz2 : new()
		{
			if (k7B == null)
			{
				return new Dz2();
			}
			return k7B;
		}

		[DebuggerHidden]
		private void Fe5<Wd4>(ref Wd4 Sc2)
		{
			Sc2 = default(Wd4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Zt6()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Fr8<Eb4> where Eb4 : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Eb4 m_ThreadStaticValue;

		internal Eb4 GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Eb4();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Fr8()
		{
		}
	}

	private static readonly Fr8<w5N> m_ComputerObjectProvider = new Fr8<w5N>();

	private static readonly Fr8<Hf7> m_AppObjectProvider = new Fr8<Hf7>();

	private static readonly Fr8<User> m_UserObjectProvider = new Fr8<User>();

	private static readonly Fr8<Zt6> m_MyWebServicesObjectProvider = new Fr8<Zt6>();

	[HelpKeyword("My.Computer")]
	internal static w5N Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Hf7 Application
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
	internal static Zt6 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
