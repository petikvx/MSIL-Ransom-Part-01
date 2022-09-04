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

namespace werdbn.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		public uytrdfgh m_uytrdfgh;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public uytrdfgh uytrdfgh
		{
			get
			{
				m_uytrdfgh = Create__Instance__(m_uytrdfgh);
				return m_uytrdfgh;
			}
			set
			{
				nKTlasq6Atbk9fb2RS();
				if (WrnpaS3QuvjQYVjgnO() && value != m_uytrdfgh)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_uytrdfgh);
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
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return MNF6Q5mTO8fO2m8Gky(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)NknxaP5paoKmW1G678(this);
		}

		internal static bool WrnpaS3QuvjQYVjgnO()
		{
			return true;
		}

		internal static bool nKTlasq6Atbk9fb2RS()
		{
			return false;
		}

		internal static int MNF6Q5mTO8fO2m8Gky(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static object NknxaP5paoKmW1G678(object object_0)
		{
			return object_0.ToString();
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
			Dg70sryIf0ZJDj2len(this);
		}

		internal static bool XsHZR7FIhigRZpmPGR()
		{
			return true;
		}

		internal static bool lD30wj1Db4fOEXQ8F4()
		{
			return false;
		}

		internal static void Dg70sryIf0ZJDj2len(object object_0)
		{
			object_0._002Ector();
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

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

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

	static MyProject()
	{
		while (true)
		{
			m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
			while (true)
			{
				m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
				_ = 1;
				if (WRhr08ZMkuUKMDafeD())
				{
					goto IL_0016;
				}
				goto IL_0059;
				IL_0059:
				m_UserObjectProvider = new ThreadSafeObjectProvider<User>();
				goto IL_0016;
				IL_0016:
				while (true)
				{
					m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
					m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();
					if (WRhr08ZMkuUKMDafeD())
					{
					}
					switch (6)
					{
					case 4:
						break;
					default:
						continue;
					case 2:
					case 5:
						goto IL_0059;
					case 1:
						goto end_IL_0003;
					case 6:
						return;
					}
					break;
				}
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	internal static bool Dg1U0REgBHQYWNSKri()
	{
		return true;
	}

	internal static bool WRhr08ZMkuUKMDafeD()
	{
		return false;
	}
}
