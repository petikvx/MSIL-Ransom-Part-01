using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Maxi.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		public Max m_Max;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public Max Max
		{
			[DebuggerNonUserCode]
			get
			{
				m_Max = Create__Instance__(m_Max);
				return m_Max;
			}
			[DebuggerNonUserCode]
			set
			{
				bool flag;
				if (flag = value == m_Max)
				{
					_ = 0;
					if (pZrq06ywkRdFipr8RM())
					{
						return;
					}
				}
				else
				{
					flag = value != null;
				}
				if (flag)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				Dispose__Instance__(ref m_Max);
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if ((Instance == null || ((Control)Instance).get_IsDisposed()) ? true : false)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
			eWTuHHvCT4buT53cwm(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return yrAvk5WcOQdDiMjbvJ(this, gykjosiBsi5DvE69Su(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)Cs0e6m9CX2LACHRuSj(this);
		}

		internal static bool pZrq06ywkRdFipr8RM()
		{
			return true;
		}

		internal static bool C5HyMAH1eaYXmCD2Jt()
		{
			return false;
		}

		internal static void eWTuHHvCT4buT53cwm(object object_0)
		{
			object_0._002Ector();
		}

		internal static object gykjosiBsi5DvE69Su(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool yrAvk5WcOQdDiMjbvJ(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static object Cs0e6m9CX2LACHRuSj(object object_0)
		{
			return object_0.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return joFxhpr0l6Ip5TbKj1(this, XDORFsEKrtXe7dsKWo(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return VHM99tux6f7e8NkGFf(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return IoERsOAUcetAELnfao(typeof(MyWebServices).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)qMgcFVYP0IjnJf42Ua(this);
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
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
			suBSAOsFT4S8qjf3tT(this);
		}

		internal static object XDORFsEKrtXe7dsKWo(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool joFxhpr0l6Ip5TbKj1(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool EsvqgJUYIs30I88Uv7()
		{
			return true;
		}

		internal static bool aenc1v8g7jpMXxMt40()
		{
			return false;
		}

		internal static int VHM99tux6f7e8NkGFf(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type IoERsOAUcetAELnfao(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object qMgcFVYP0IjnJf42Ua(object object_0)
		{
			return object_0.ToString();
		}

		internal static void suBSAOsFT4S8qjf3tT(object object_0)
		{
			object_0._002Ector();
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}

		internal static bool vgmWBhxvkqqyeCIUKG()
		{
			return true;
		}

		internal static bool TlJBxPDG0yr5Jxbjnm()
		{
			return false;
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider;

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider;

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider;

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
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

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}

	[DebuggerNonUserCode]
	static MyProject()
	{
		_ = 0;
		if (MYPdLrjvPbi1MhAZZo())
		{
			m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
		}
		m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
		m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
		m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
	}

	internal static bool MYPdLrjvPbi1MhAZZo()
	{
		return true;
	}

	internal static bool Haw5vSKRwD9O8QuPnd()
	{
		return false;
	}
}
