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
using RW;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class3
	{
		public R1 r1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public R1 R1
		{
			get
			{
				r1_0 = smethod_0(r1_0);
				return r1_0;
			}
			set
			{
				if (value != r1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					method_0(ref r1_0);
				}
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T Instance) where T : Form, new()
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
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class3()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
		}
	}

	private static readonly Class5<Class1> class5_0 = new Class5<Class1>();

	private static readonly Class5<Form0> class5_1 = new Class5<Form0>();

	private static readonly Class5<User> class5_2 = new Class5<User>();

	private static Class5<Class3> class5_3 = new Class5<Class3>();

	private static readonly Class5<Class4> class5_4 = new Class5<Class4>();

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return class5_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 iAmhrelTc
	{
		[DebuggerHidden]
		get
		{
			return class5_4.method_0();
		}
	}
}
