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

namespace EmployeeData.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public blackout m_blackout;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MainForm m_MainForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public mainRunner m_mainRunner;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WriteDataForm m_WriteDataForm;

		public blackout blackout
		{
			[DebuggerHidden]
			get
			{
				m_blackout = Create__Instance__(m_blackout);
				return m_blackout;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_blackout)
				{
					if (value != null)
					{
						throw MyForms.smethod_12("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_blackout);
				}
			}
		}

		public Form1 Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Create__Instance__(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw MyForms.smethod_12("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form1);
				}
			}
		}

		public MainForm MainForm
		{
			[DebuggerHidden]
			get
			{
				m_MainForm = Create__Instance__(m_MainForm);
				return m_MainForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MainForm)
				{
					if (value != null)
					{
						throw MyForms.smethod_12("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MainForm);
				}
			}
		}

		public mainRunner mainRunner
		{
			[DebuggerHidden]
			get
			{
				m_mainRunner = Create__Instance__(m_mainRunner);
				return m_mainRunner;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_mainRunner)
				{
					if (value != null)
					{
						throw MyForms.smethod_12("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_mainRunner);
				}
			}
		}

		public WriteDataForm WriteDataForm
		{
			[DebuggerHidden]
			get
			{
				m_WriteDataForm = Create__Instance__(m_WriteDataForm);
				return m_WriteDataForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WriteDataForm)
				{
					if (value != null)
					{
						throw MyForms.smethod_12("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_WriteDataForm);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || ((Control)Instance).get_IsDisposed())
			{
				if (m_FormBeingCreated != null)
				{
					if (MyForms.smethod_1(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle)))
					{
						throw MyForms.smethod_3(MyForms.smethod_2("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = MyForms.smethod_4();
				}
				MyForms.smethod_5(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle), (object)null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException exception_) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					MyForms.smethod_6((Exception)exception_);
					return MyForms.smethod_7((Exception)exception_) != null;
				}).Invoke())
				{
					string string_ = MyForms.smethod_2("WinForms_SeeInnerException", new string[1] { MyForms.smethod_8(MyForms.smethod_7((Exception)exception_)) });
					throw MyForms.smethod_9(string_, MyForms.smethod_7((Exception)exception_));
				}
				finally
				{
					MyForms.smethod_10(m_FormBeingCreated, (object)MyForms.smethod_0(typeof(T).TypeHandle));
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return this.method_0(MyForms.smethod_11(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return MyForms.smethod_0(typeof(MyForms).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return this.method_2();
		}

		static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_1(Hashtable hashtable_0, object object_0)
		{
			return hashtable_0.ContainsKey(object_0);
		}

		static string smethod_2(string string_0, string[] string_1)
		{
			return Utils.GetResourceString(string_0, string_1);
		}

		static InvalidOperationException smethod_3(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static Hashtable smethod_4()
		{
			return new Hashtable();
		}

		static void smethod_5(Hashtable hashtable_0, object object_0, object object_1)
		{
			hashtable_0.Add(object_0, object_1);
		}

		static void smethod_6(Exception exception_0)
		{
			ProjectData.SetProjectError(exception_0);
		}

		static Exception smethod_7(Exception exception_0)
		{
			return exception_0.InnerException;
		}

		static string smethod_8(Exception exception_0)
		{
			return exception_0.Message;
		}

		static InvalidOperationException smethod_9(string string_0, Exception exception_0)
		{
			return new InvalidOperationException(string_0, exception_0);
		}

		static void smethod_10(Hashtable hashtable_0, object object_0)
		{
			hashtable_0.Remove(object_0);
		}

		static object smethod_11(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_0(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_1()
		{
			return base.GetHashCode();
		}

		string method_2()
		{
			return base.ToString();
		}

		static ArgumentException smethod_12(string string_0)
		{
			return new ArgumentException(string_0);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return this.method_0(MyWebServices.smethod_0(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return this.method_1();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return MyWebServices.smethod_1(typeof(MyWebServices).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return this.method_2();
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
		}

		static object smethod_0(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_0(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_1()
		{
			return base.GetHashCode();
		}

		static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		string method_2()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
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
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

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
}
