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

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class0
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class1
	{
		public Form1 form1_0;

		public Form2 form2_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public Form1 Form1_0
		{
			get
			{
				form1_0 = Create__Instance__(form1_0);
				return form1_0;
			}
			set
			{
				if (value != form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref form1_0);
				}
			}
		}

		public Form2 Form2_0
		{
			get
			{
				form2_0 = Create__Instance__(form2_0);
				return form2_0;
			}
			set
			{
				if (value != form2_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref form2_0);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !((Control)Instance).get_IsDisposed())
			{
				return Instance;
			}
			if (hashtable_0 != null)
			{
				if (hashtable_0.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				hashtable_0 = new Hashtable();
			}
			hashtable_0.Add(typeof(T), null);
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
				hashtable_0.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool vmethod_0(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int vmethod_1()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string vmethod_2()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool vmethod_0(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int vmethod_1()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class2);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string vmethod_2()
		{
			return base.ToString();
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
		public Class2()
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
		}
	}

	private static readonly ThreadSafeObjectProvider<Class3> threadSafeObjectProvider_0 = new ThreadSafeObjectProvider<Class3>();

	private static readonly ThreadSafeObjectProvider<Form0> threadSafeObjectProvider_1 = new ThreadSafeObjectProvider<Form0>();

	private static readonly ThreadSafeObjectProvider<User> threadSafeObjectProvider_2 = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<Class1> threadSafeObjectProvider_3 = new ThreadSafeObjectProvider<Class1>();

	private static readonly ThreadSafeObjectProvider<Class2> threadSafeObjectProvider_4 = new ThreadSafeObjectProvider<Class2>();

	[HelpKeyword("My.Computer")]
	internal static Class3 Computer
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Application
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_2.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class1 Forms
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_3.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class2 WebServices
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_4.GetInstance;
		}
	}
}
