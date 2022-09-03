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

namespace ns1;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class a6hS23aOog55kaNfGMvgWg2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class0
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type wAanLq4ix04T13Njah34WB0()
		{
			return typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void daK9cIJSPtGUt7fJnoyVT02<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class aAmjLFaIPWF9PWiSt1Sedf4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public aAmjLFaIPWF9PWiSt1Sedf4()
		{
		}
	}

	private static readonly aAmjLFaIPWF9PWiSt1Sedf4<idSuS4XjHWTBGvxzFL53h11> m_ComputerObjectProvider = new aAmjLFaIPWF9PWiSt1Sedf4<idSuS4XjHWTBGvxzFL53h11>();

	private static readonly aAmjLFaIPWF9PWiSt1Sedf4<KzQsAEdYPKeqrq5owf0> m_AppObjectProvider = new aAmjLFaIPWF9PWiSt1Sedf4<KzQsAEdYPKeqrq5owf0>();

	private static readonly aAmjLFaIPWF9PWiSt1Sedf4<User> m_UserObjectProvider = new aAmjLFaIPWF9PWiSt1Sedf4<User>();

	private static readonly aAmjLFaIPWF9PWiSt1Sedf4<Class0> m_MyWebServicesObjectProvider = new aAmjLFaIPWF9PWiSt1Sedf4<Class0>();

	[HelpKeyword("My.Computer")]
	internal static idSuS4XjHWTBGvxzFL53h11 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static KzQsAEdYPKeqrq5owf0 Application
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
	internal static Class0 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
