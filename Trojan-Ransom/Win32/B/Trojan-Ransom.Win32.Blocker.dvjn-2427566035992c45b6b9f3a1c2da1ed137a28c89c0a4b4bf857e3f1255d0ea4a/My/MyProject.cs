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
using SmartAssembly.SmartExceptionsCore;

namespace My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			try
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}
			catch (Exception exception)
			{
				bool flag = default(bool);
				StackFrameHelper.CreateException3(exception, flag, this, o);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			try
			{
				return base.GetHashCode();
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			try
			{
				return typeof(MyWebServices);
			}
			catch (Exception exception)
			{
				Type o = default(Type);
				StackFrameHelper.CreateException2(exception, o, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			try
			{
				return base.ToString();
			}
			catch (Exception exception)
			{
				string o = default(string);
				StackFrameHelper.CreateException2(exception, o, this);
				throw;
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			try
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}
			catch (Exception exception)
			{
				T val = default(T);
				StackFrameHelper.CreateException2(exception, val, instance);
				throw;
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			T val = default(T);
			try
			{
				val = (instance = default(T));
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, val, this, instance);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
			Class2.l4t8M9wzGUypc();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				try
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
				catch (Exception exception)
				{
					T val = default(T);
					StackFrameHelper.CreateException2(exception, val, this);
					throw;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
			Class2.l4t8M9wzGUypc();
			base._002Ector();
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			try
			{
				return m_ComputerObjectProvider.GetInstance;
			}
			catch (Exception exception)
			{
				MyComputer o = default(MyComputer);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			try
			{
				return m_AppObjectProvider.GetInstance;
			}
			catch (Exception exception)
			{
				MyApplication o = default(MyApplication);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			try
			{
				return m_UserObjectProvider.GetInstance;
			}
			catch (Exception exception)
			{
				User o = default(User);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			try
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
			catch (Exception exception)
			{
				MyWebServices o = default(MyWebServices);
				StackFrameHelper.CreateException1(exception, o);
				throw;
			}
		}
	}

	static MyProject()
	{
		Class2.l4t8M9wzGUypc();
		try
		{
			m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
			m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
			m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
			m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
