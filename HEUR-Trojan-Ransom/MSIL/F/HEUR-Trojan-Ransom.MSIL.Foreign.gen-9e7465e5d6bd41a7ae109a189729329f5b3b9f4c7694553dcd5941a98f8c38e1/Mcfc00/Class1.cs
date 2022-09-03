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

namespace Mcfc00;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class1
{
	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class kBDt4kAH5zwxbNSVx4<T> where T : new()
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
		public kBDt4kAH5zwxbNSVx4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class S5je8cjc3DbuQpbBJ3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public S5je8cjc3DbuQpbBJ3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type C7xzdTwcE4e0LLv940()
		{
			return typeof(S5je8cjc3DbuQpbBJ3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
		private void ULLyEcN2u75biRGlL2<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	private static readonly kBDt4kAH5zwxbNSVx4<EhvFYh4cWb1> m_ComputerObjectProvider = new kBDt4kAH5zwxbNSVx4<EhvFYh4cWb1>();

	private static readonly kBDt4kAH5zwxbNSVx4<WKKGIinsdX0> m_AppObjectProvider = new kBDt4kAH5zwxbNSVx4<WKKGIinsdX0>();

	private static readonly kBDt4kAH5zwxbNSVx4<User> m_UserObjectProvider = new kBDt4kAH5zwxbNSVx4<User>();

	private static readonly kBDt4kAH5zwxbNSVx4<S5je8cjc3DbuQpbBJ3> m_MyWebServicesObjectProvider = new kBDt4kAH5zwxbNSVx4<S5je8cjc3DbuQpbBJ3>();

	[HelpKeyword("My.Computer")]
	internal static EhvFYh4cWb1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static WKKGIinsdX0 Application
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
	internal static S5je8cjc3DbuQpbBJ3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
