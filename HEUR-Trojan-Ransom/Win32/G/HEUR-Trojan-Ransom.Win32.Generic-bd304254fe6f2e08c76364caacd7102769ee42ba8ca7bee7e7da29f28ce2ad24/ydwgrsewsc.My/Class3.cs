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

namespace ydwgrsewsc.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
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
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(object instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return (T)instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
			Class5.pBI4Dj8zjqlWv();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
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
		public ThreadSafeObjectProvider()
		{
			Class5.pBI4Dj8zjqlWv();
			base._002Ector();
		}
	}

	private static readonly ThreadSafeObjectProvider<User> threadSafeObjectProvider_0;

	private static readonly ThreadSafeObjectProvider<Class1> threadSafeObjectProvider_1;

	private static readonly ThreadSafeObjectProvider<MyWebServices> threadSafeObjectProvider_2;

	private static readonly ThreadSafeObjectProvider<Class2> threadSafeObjectProvider_3;

	[HelpKeyword("My.Application")]
	internal static object Object_0
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_1.GetInstance;
		}
	}

	[HelpKeyword("My.Computer")]
	internal static object Object_1
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_3.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static object Object_2
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_0.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static object Object_3
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_2.GetInstance;
		}
	}

	static Class3()
	{
		Class5.pBI4Dj8zjqlWv();
		threadSafeObjectProvider_3 = new ThreadSafeObjectProvider<Class2>();
		threadSafeObjectProvider_1 = new ThreadSafeObjectProvider<Class1>();
		threadSafeObjectProvider_0 = new ThreadSafeObjectProvider<User>();
		threadSafeObjectProvider_2 = new ThreadSafeObjectProvider<MyWebServices>();
	}
}
