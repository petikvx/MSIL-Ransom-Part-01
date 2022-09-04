using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
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
		private static T smethod_0<T>(T gparam_0) where T : new()
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
		private void method_2<T>(ref T gparam_0)
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
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
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class2<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}
	}

	private static readonly Class2<Class0> class2_0 = new Class2<Class0>();

	private static readonly Class2<Form0> class2_1 = new Class2<Form0>();

	private static readonly Class2<User> class2_2 = new Class2<User>();

	private static Class2<MyForms> class2_3 = new Class2<MyForms>();

	private static readonly Class2<MyWebServices> class2_4 = new Class2<MyWebServices>();

	[SpecialName]
	[DebuggerHidden]
	internal static Class0 smethod_0()
	{
		return class2_0.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static Form0 smethod_1()
	{
		return class2_1.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class2_2.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static MyForms smethod_3()
	{
		return class2_3.method_0();
	}

	[SpecialName]
	[DebuggerHidden]
	internal static MyWebServices smethod_4()
	{
		return class2_4.method_0();
	}
}
