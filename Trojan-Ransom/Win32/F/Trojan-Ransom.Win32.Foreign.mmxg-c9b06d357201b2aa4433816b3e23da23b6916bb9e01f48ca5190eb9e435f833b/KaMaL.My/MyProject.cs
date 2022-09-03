using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace KaMaL.My;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class0
	{
		public AboutBox1 aboutBox1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		public AboutBox1 method_0()
		{
			aboutBox1_0 = smethod_0(aboutBox1_0);
			return aboutBox1_0;
		}

		[SpecialName]
		public void method_1(AboutBox1 aboutBox1_1)
		{
			if (aboutBox1_1 != aboutBox1_0)
			{
				if (aboutBox1_1 != null)
				{
					throw new ArgumentException("Property can only be set to Nothing");
				}
				method_2(ref aboutBox1_0);
			}
		}

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

		private void method_2<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
			MyComputer.smethod_4();
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
			return typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class1
	{
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
		internal Type method_0()
		{
			return typeof(Class1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
			Class6.smethod_7();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
			Class3.smethod_3();
		}
	}

	private static readonly Class2<MyComputer> class2_0 = new Class2<MyComputer>();

	private static readonly Class2<MyApplication> class2_1 = new Class2<MyApplication>();

	private static readonly Class2<User> class2_2 = new Class2<User>();

	private static Class2<Class0> class2_3 = new Class2<Class0>();

	private static readonly Class2<Class1> class2_4 = new Class2<Class1>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0
	{
		get
		{
			MyComputer result = class2_0.method_0();
			Class3.Class4.smethod_9();
			return result;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0
	{
		get
		{
			MyApplication result = class2_1.method_0();
			MyComputer.smethod_4();
			return result;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			User result = class2_2.method_0();
			Class3.Class4.smethod_2();
			return result;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class0 Class0_0
	{
		get
		{
			Class0 result = class2_3.method_0();
			MyComputer.smethod_4();
			return result;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0
	{
		get
		{
			Class1 result = class2_4.method_0();
			Class5.smethod_9();
			return result;
		}
	}
}
