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
using hsnLdkMtt9W3LiVovy;

namespace My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		internal static object U7r7ekMFq57xCc7fxR;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return true;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		private void Dispose__Instance__<T>(ref T instance)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}

		static MyWebServices()
		{
			dlLFmbU8fZgjw22Fes.l42RINlY5i();
			PieCVtAD6pxb0t9bBN();
		}

		internal static bool ybgDCHaPfoMebenc7Y()
		{
			return true;
		}

		internal static MyWebServices yoY7xAYhDtSvrAp1ul()
		{
			return null;
		}

		internal static int lTidBVvHMpsps5fpI5(object object_0)
		{
			return 0;
		}

		internal static RuntimeTypeHandle OmQFUsGJC5XWdAD4M3(int token)
		{
			return (RuntimeTypeHandle)(object)null;
		}

		internal static Type XBbZ9xJCDxBZmZGFbF(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return null;
		}

		internal static object GxeIbKHwa3s0oXJESP(object object_0)
		{
			return null;
		}

		internal static void U1Zug3OSxkh4FQDvrZ()
		{
		}

		internal static void PieCVtAD6pxb0t9bBN()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal static object Gmak5ooeOcGtiWAd0y;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}

		static ThreadSafeObjectProvider()
		{
			dlLFmbU8fZgjw22Fes.l42RINlY5i();
			dlLFmbU8fZgjw22Fes.fgRRjcGSFF();
		}

		internal static bool gac5wZs8KfChbgsgNv()
		{
			return true;
		}

		internal static object c9PNfZlGmPjxxQn07H()
		{
			return null;
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	internal static object icW5CLi923X5RNMxVy;

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return null;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return null;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return null;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return null;
		}
	}

	static MyProject()
	{
		dlLFmbU8fZgjw22Fes.l42RINlY5i();
		rGSESbErkFu7xJwq6O();
		gTUZ8vIhG1nupBwCl7();
		m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
		m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
		m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
		m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
	}

	internal static void rGSESbErkFu7xJwq6O()
	{
	}

	internal static void gTUZ8vIhG1nupBwCl7()
	{
	}

	internal static bool agXZAC0sp3Ug5fAn4n()
	{
		return true;
	}

	internal static MyProject IAdQbhPyZViJG5WPUs()
	{
		return null;
	}
}
