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
using ns0;
using ns1;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		public Mik mik_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public Mik Mik
		{
			[DebuggerNonUserCode]
			get
			{
				mik_0 = smethod_0(mik_0);
				return mik_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != mik_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref mik_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false)
			{
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
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class2()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		bool object.Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0 = new Class4<Class0>();

	private static readonly Class4<Form0> class4_1 = new Class4<Form0>();

	private static readonly Class4<User> class4_2 = new Class4<User>();

	private static Class4<Class2> class4_3 = new Class4<Class2>();

	private static readonly Class4<Class3> class4_4 = new Class4<Class3>();

	[HelpKeyword("My.Computer")]
	internal static Class0 Computer
	{
		[DebuggerHidden]
		get
		{
			return class4_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Application
	{
		[DebuggerHidden]
		get
		{
			return class4_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return class4_2.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2 Forms
	{
		[DebuggerHidden]
		get
		{
			return class4_3.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return class4_4.GetInstance;
		}
	}
}
