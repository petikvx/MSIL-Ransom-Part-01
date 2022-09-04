using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;
using SmartAssembly.SmartExceptionsCore;

namespace My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			try
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(obj));
			}
			catch (Exception exception_)
			{
				bool flag = default(bool);
				StackFrameHelper.CreateException3(exception_, flag, this, obj);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			try
			{
				return base.GetHashCode();
			}
			catch (Exception exception_)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception_, num, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			try
			{
				return base.ToString();
			}
			catch (Exception exception_)
			{
				string object_ = default(string);
				StackFrameHelper.CreateException2(exception_, object_, this);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
			try
			{
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
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
				catch (Exception exception_)
				{
					T val = default(T);
					StackFrameHelper.CreateException2(exception_, val, this);
					throw;
				}
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
			try
			{
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	internal static MyComputer Computer
	{
		get
		{
			try
			{
				return m_ComputerObjectProvider.GetInstance;
			}
			catch (Exception exception_)
			{
				MyComputer object_ = default(MyComputer);
				StackFrameHelper.CreateException1(exception_, object_);
				throw;
			}
		}
	}

	static MyProject()
	{
		try
		{
			m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
			m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
			m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
			m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}
}
