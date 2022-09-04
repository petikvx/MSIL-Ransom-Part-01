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

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class Class3
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[DebuggerHidden]
		private unsafe static T smethod_0<T>(object Instance) where T : Form, new()
		{
			if ((Instance == null || ((Control)(*(T*)(&Instance))).get_IsDisposed()) ? true : false)
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
			return (T)Instance;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			((Component)gparam_0).Dispose();
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class14.u5Gt82DzXHpxk();
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class5
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
			return typeof(Class5);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(object instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return (T)instance;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class14.u5Gt82DzXHpxk();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class6<T> where T : new()
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
		public Class6()
		{
			Class14.u5Gt82DzXHpxk();
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

	[DebuggerNonUserCode]
	static Class3()
	{
		Class14.u5Gt82DzXHpxk();
		class6_0 = new Class6<Class2>();
		class6_1 = new Class6<Class1>();
		class6_2 = new Class6<User>();
		class6_3 = new Class6<Class4>();
		class6_4 = new Class6<Class5>();
	}
}
