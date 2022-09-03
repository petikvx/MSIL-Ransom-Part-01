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

namespace K2RXZlwrOKS2JKKDPaK50;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class1
{
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class FwTF4AFcVeCoi1Va4<T> where T : new()
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
		public FwTF4AFcVeCoi1Va4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class wbLKpBj93Vvq3brr3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public wbLKpBj93Vvq3brr3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		internal Type gQtmhkezB8hOypgY0()
		{
			return typeof(wbLKpBj93Vvq3brr3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T wn7QL3VeKT1cDr3D1<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void ppGHqfdcXc9hkvAD2<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	private static readonly FwTF4AFcVeCoi1Va4<OkQ42588R1> m_ComputerObjectProvider = new FwTF4AFcVeCoi1Va4<OkQ42588R1>();

	private static readonly FwTF4AFcVeCoi1Va4<pmOR8SE1x0> m_AppObjectProvider = new FwTF4AFcVeCoi1Va4<pmOR8SE1x0>();

	private static readonly FwTF4AFcVeCoi1Va4<User> m_UserObjectProvider = new FwTF4AFcVeCoi1Va4<User>();

	private static readonly FwTF4AFcVeCoi1Va4<wbLKpBj93Vvq3brr3> m_MyWebServicesObjectProvider = new FwTF4AFcVeCoi1Va4<wbLKpBj93Vvq3brr3>();

	[HelpKeyword("My.Computer")]
	internal static OkQ42588R1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static pmOR8SE1x0 Application
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
	internal static wbLKpBj93Vvq3brr3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
