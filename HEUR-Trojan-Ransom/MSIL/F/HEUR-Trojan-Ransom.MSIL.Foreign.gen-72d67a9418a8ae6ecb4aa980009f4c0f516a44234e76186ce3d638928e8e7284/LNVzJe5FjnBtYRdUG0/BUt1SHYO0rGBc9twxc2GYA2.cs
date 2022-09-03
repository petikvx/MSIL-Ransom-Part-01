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

namespace LNVzJe5FjnBtYRdUG0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class BUt1SHYO0rGBc9twxc2GYA2
{
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class A2W6Om3O5rKcN2OWIWptWp4<T> where T : new()
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public A2W6Om3O5rKcN2OWIWptWp4()
		{
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class NPDhF4WQzo4WynB6VPysaJ3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public NPDhF4WQzo4WynB6VPysaJ3()
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(NPDhF4WQzo4WynB6VPysaJ3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T xgA5Urgc8wq4HhNFP33pxl1<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void syhYJjNFz0SQPdq9YlTDAX2<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	private static readonly A2W6Om3O5rKcN2OWIWptWp4<oai57OwwgaaPYGaIpkmSps1> m_ComputerObjectProvider = new A2W6Om3O5rKcN2OWIWptWp4<oai57OwwgaaPYGaIpkmSps1>();

	private static readonly A2W6Om3O5rKcN2OWIWptWp4<ydfLYFCXPNlbWgt0> m_AppObjectProvider = new A2W6Om3O5rKcN2OWIWptWp4<ydfLYFCXPNlbWgt0>();

	private static readonly A2W6Om3O5rKcN2OWIWptWp4<User> m_UserObjectProvider = new A2W6Om3O5rKcN2OWIWptWp4<User>();

	private static readonly A2W6Om3O5rKcN2OWIWptWp4<NPDhF4WQzo4WynB6VPysaJ3> m_MyWebServicesObjectProvider = new A2W6Om3O5rKcN2OWIWptWp4<NPDhF4WQzo4WynB6VPysaJ3>();

	[HelpKeyword("My.Computer")]
	internal static oai57OwwgaaPYGaIpkmSps1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static ydfLYFCXPNlbWgt0 Application
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
	internal static NPDhF4WQzo4WynB6VPysaJ3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
