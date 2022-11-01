using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace My;

[GeneratedCode("MyTemplate", "14.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject_007BF70320EE_002D3D0B_002D4CD5_002D836D_002D55D1FF9A70A0_007D
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return true;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return 0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return null;
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			return (T)null;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T gparam_0)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}

		static MyWebServices()
		{
			Class0.smethod_13();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			return (T)null;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}

		static ThreadSafeObjectProvider()
		{
			Class0.smethod_13();
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer_007B54819337_002D10D9_002D4DD8_002DB8CC_002D9B6F4C6CF957_007D> m_ComputerObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyApplication_007B5347A255_002D9DA5_002D4EC0_002D9063_002D0FACB63F3AAA_007D> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	static MyProject_007BF70320EE_002D3D0B_002D4CD5_002D836D_002D55D1FF9A70A0_007D()
	{
		Class0.smethod_13();
		m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
		m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
	}
}
