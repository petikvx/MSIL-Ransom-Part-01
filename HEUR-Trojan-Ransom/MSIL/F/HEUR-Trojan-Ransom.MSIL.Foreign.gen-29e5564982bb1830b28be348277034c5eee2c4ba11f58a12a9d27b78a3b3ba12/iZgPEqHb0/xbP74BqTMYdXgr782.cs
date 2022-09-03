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

namespace iZgPEqHb0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class xbP74BqTMYdXgr782
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class S0BKOVyx4J654ZhQ3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public S0BKOVyx4J654ZhQ3()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type iet70pDsgvqRSufV0()
		{
			return typeof(S0BKOVyx4J654ZhQ3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T IR09b4lCDh3lulON1<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void GnE2Y07sn8tiuGFA2<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class uamdY7EeTRuJmiXV4<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uamdY7EeTRuJmiXV4()
		{
		}
	}

	private static readonly uamdY7EeTRuJmiXV4<Class0> m_ComputerObjectProvider = new uamdY7EeTRuJmiXV4<Class0>();

	private static readonly uamdY7EeTRuJmiXV4<rc8oEwfuW4RrD7n0jPxH0> m_AppObjectProvider = new uamdY7EeTRuJmiXV4<rc8oEwfuW4RrD7n0jPxH0>();

	private static readonly uamdY7EeTRuJmiXV4<User> m_UserObjectProvider = new uamdY7EeTRuJmiXV4<User>();

	private static readonly uamdY7EeTRuJmiXV4<S0BKOVyx4J654ZhQ3> m_MyWebServicesObjectProvider = new uamdY7EeTRuJmiXV4<S0BKOVyx4J654ZhQ3>();

	[HelpKeyword("My.Computer")]
	internal static Class0 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static rc8oEwfuW4RrD7n0jPxH0 Application
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
	internal static S0BKOVyx4J654ZhQ3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
