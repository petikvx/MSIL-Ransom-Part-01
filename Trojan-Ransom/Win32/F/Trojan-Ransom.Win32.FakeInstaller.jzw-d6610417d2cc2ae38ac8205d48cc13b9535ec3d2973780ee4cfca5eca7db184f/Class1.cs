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
using stub;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class2
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		[DebuggerNonUserCode]
		public Form1 method_0()
		{
			form1_0 = smethod_0(form1_0);
			return form1_0;
		}

		[SpecialName]
		[DebuggerNonUserCode]
		public void method_1(Form1 form1_1)
		{
			if (form1_1 != form1_0)
			{
				if (form1_1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				method_2(ref form1_0);
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
		private void method_2<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
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
		internal Type method_3()
		{
			return typeof(Class2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
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
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		private void ojwoerkAp<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T ojwoerkAp;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			if (ojwoerkAp == null)
			{
				ojwoerkAp = new T();
			}
			return ojwoerkAp;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0;

	private static readonly Class4<Form0> class4_1;

	private static readonly Class4<User> class4_2;

	private static Class4<Class2> class4_3;

	private static readonly Class4<Class3> class4_4;

	[HelpKeyword("My.Computer")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			return class4_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return class4_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class4_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class4_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			return class4_4.method_0();
		}
	}

	[DebuggerNonUserCode]
	static Class1()
	{
		class4_0 = new Class4<Class0>();
		class4_1 = new Class4<Form0>();
		class4_2 = new Class4<User>();
		class4_3 = new Class4<Class2>();
		class4_4 = new Class4<Class3>();
	}
}
