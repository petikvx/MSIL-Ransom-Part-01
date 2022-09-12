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
using ns1;
using ns12;
using ns13;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns19;
using ns2;
using ns8;
using ns9;

namespace ns3;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EnterNameForm m_EnterNameForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form1 m_Form1;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ignore m_Ignore;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public InformationForm m_InformationForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public LeaderBoardForm m_LeaderBoardForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MainMenu m_MainMenu;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MultiPlayer m_MultiPlayer;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public QuitForm m_QuitForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public SomeoneWon m_SomeoneWon;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public StartUpForm m_StartUpForm;

		public EnterNameForm EnterNameForm
		{
			[DebuggerHidden]
			get
			{
				m_EnterNameForm = Create__Instance__(m_EnterNameForm);
				return m_EnterNameForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EnterNameForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EnterNameForm);
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
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form1);
				}
			}
		}

		public Ignore Ignore
		{
			[DebuggerHidden]
			get
			{
				m_Ignore = Create__Instance__(m_Ignore);
				return m_Ignore;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Ignore)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Ignore);
				}
			}
		}

		public InformationForm InformationForm
		{
			[DebuggerHidden]
			get
			{
				m_InformationForm = Create__Instance__(m_InformationForm);
				return m_InformationForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_InformationForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_InformationForm);
				}
			}
		}

		public LeaderBoardForm LeaderBoardForm
		{
			[DebuggerHidden]
			get
			{
				m_LeaderBoardForm = Create__Instance__(m_LeaderBoardForm);
				return m_LeaderBoardForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_LeaderBoardForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_LeaderBoardForm);
				}
			}
		}

		public MainMenu MainMenu
		{
			[DebuggerHidden]
			get
			{
				m_MainMenu = Create__Instance__(m_MainMenu);
				return m_MainMenu;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MainMenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MainMenu);
				}
			}
		}

		public MultiPlayer MultiPlayer
		{
			[DebuggerHidden]
			get
			{
				m_MultiPlayer = Create__Instance__(m_MultiPlayer);
				return m_MultiPlayer;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MultiPlayer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MultiPlayer);
				}
			}
		}

		public QuitForm QuitForm
		{
			[DebuggerHidden]
			get
			{
				m_QuitForm = Create__Instance__(m_QuitForm);
				return m_QuitForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_QuitForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_QuitForm);
				}
			}
		}

		public SomeoneWon SomeoneWon
		{
			[DebuggerHidden]
			get
			{
				m_SomeoneWon = Create__Instance__(m_SomeoneWon);
				return m_SomeoneWon;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_SomeoneWon)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_SomeoneWon);
				}
			}
		}

		public StartUpForm StartUpForm
		{
			[DebuggerHidden]
			get
			{
				m_StartUpForm = Create__Instance__(m_StartUpForm);
				return m_StartUpForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_StartUpForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_StartUpForm);
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
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
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
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
		}
	}

	private static readonly ThreadSafeObjectProvider<Class1> threadSafeObjectProvider_0 = new ThreadSafeObjectProvider<Class1>();

	private static readonly ThreadSafeObjectProvider<Class0> threadSafeObjectProvider_1 = new ThreadSafeObjectProvider<Class0>();

	private static readonly ThreadSafeObjectProvider<User> threadSafeObjectProvider_2 = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> threadSafeObjectProvider_3 = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> threadSafeObjectProvider_4 = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static Class1 Computer
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class0 Application
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
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_3.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return threadSafeObjectProvider_4.GetInstance;
		}
	}
}
