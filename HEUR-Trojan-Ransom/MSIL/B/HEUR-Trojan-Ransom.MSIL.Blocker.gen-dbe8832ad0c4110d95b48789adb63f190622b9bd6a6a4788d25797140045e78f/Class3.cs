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

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class4
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[DebuggerHidden]
		private static q8ZHCO5sk0Kr3MnaF7 smethod_0<q8ZHCO5sk0Kr3MnaF7>(q8ZHCO5sk0Kr3MnaF7 VMd89BPY3lb8Dlob1I) where q8ZHCO5sk0Kr3MnaF7 : Form, new()
		{
			if (VMd89BPY3lb8Dlob1I != null && !((Control)VMd89BPY3lb8Dlob1I).get_IsDisposed())
			{
				return VMd89BPY3lb8Dlob1I;
			}
			if (hashtable_0 != null)
			{
				if (hashtable_0.ContainsKey(typeof(q8ZHCO5sk0Kr3MnaF7)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
				}
			}
			else
			{
				hashtable_0 = new Hashtable();
			}
			hashtable_0.Add(typeof(q8ZHCO5sk0Kr3MnaF7), null);
			try
			{
				return new q8ZHCO5sk0Kr3MnaF7();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError((Exception)ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException!.Message }), ex.InnerException);
			}
			finally
			{
				hashtable_0.Remove(typeof(q8ZHCO5sk0Kr3MnaF7));
			}
		}

		[DebuggerHidden]
		private void method_0<fb2nutWmf4uA6RRY5I>(ref fb2nutWmf4uA6RRY5I gparam_0) where fb2nutWmf4uA6RRY5I : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(fb2nutWmf4uA6RRY5I);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class10.tgfoa2wzNAwc9();
			base._002Ector();
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
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class5);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static vGC0P0uRKlf71qTFg7 smethod_0<vGC0P0uRKlf71qTFg7>(vGC0P0uRKlf71qTFg7 XZNw0XgetHAqLaMGxp) where vGC0P0uRKlf71qTFg7 : new()
		{
			if (XZNw0XgetHAqLaMGxp == null)
			{
				return new vGC0P0uRKlf71qTFg7();
			}
			return XZNw0XgetHAqLaMGxp;
		}

		[DebuggerHidden]
		private void method_1<mFpUoljNo9uWAskXoU>(ref mFpUoljNo9uWAskXoU gparam_0)
		{
			gparam_0 = default(mFpUoljNo9uWAskXoU);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class10.tgfoa2wzNAwc9();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class6<OKraJ2UCWdtHwFxeMe> where OKraJ2UCWdtHwFxeMe : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static OKraJ2UCWdtHwFxeMe gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal OKraJ2UCWdtHwFxeMe method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new OKraJ2UCWdtHwFxeMe();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class6()
		{
			Class10.tgfoa2wzNAwc9();
			base._002Ector();
		}
	}

	private static readonly Class6<Class2> class6_0;

	private static readonly Class6<Class1> class6_1;

	private static readonly Class6<User> class6_2;

	private static Class6<Class4> class6_3;

	private static readonly Class6<Class5> class6_4;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class6_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class6_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class6_2.method_0();
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class6_3.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			return class6_4.method_0();
		}
	}

	static Class3()
	{
		Class10.tgfoa2wzNAwc9();
		class6_0 = new Class6<Class2>();
		class6_1 = new Class6<Class1>();
		class6_2 = new Class6<User>();
		class6_3 = new Class6<Class4>();
		class6_4 = new Class6<Class5>();
	}
}
