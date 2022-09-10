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
using RunIt;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class2
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public Form1 Form1_0
		{
			[DebuggerNonUserCode]
			get
			{
				Form1 form = default(Form1);
				try
				{
					form1_0 = smethod_0(form1_0);
					form = form1_0;
					return form;
				}
				catch (Exception exception_)
				{
					Class9.smethod_26(exception_, this, form);
					throw;
				}
			}
			[DebuggerNonUserCode]
			set
			{
				bool flag = default(bool);
				try
				{
					if (!(flag = value == form1_0))
					{
						if (flag = value != null)
						{
							throw Delegate116.smethod_0("Property can only be set to Nothing");
						}
						method_0(ref form1_0);
					}
				}
				catch (Exception exception_)
				{
					Class9.smethod_27(exception_, this, value, flag);
					throw;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			T val = default(T);
			TargetInvocationException object_ = default(TargetInvocationException);
			string[] array = default(string[]);
			string text = default(string);
			try
			{
				if (flag = ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false))
				{
					if (flag2 = hashtable_0 != null)
					{
						if (flag3 = Delegate73.smethod_0(hashtable_0, Delegate11.smethod_0(typeof(T).TypeHandle)))
						{
							throw Delegate33.smethod_0(Delegate63.smethod_0("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						hashtable_0 = Delegate92.smethod_0();
					}
					Delegate75.smethod_0(hashtable_0, Delegate11.smethod_0(typeof(T).TypeHandle), null);
					try
					{
						val = new T();
						return val;
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object_ = ex;
						Delegate112.smethod_0(ex);
						return Delegate62.smethod_0(ex) != null;
					}).Invoke())
					{
						array = new string[1] { Delegate19.smethod_0(Delegate62.smethod_0(ex)) };
						text = Delegate63.smethod_0("WinForms_SeeInnerException", array);
						throw Delegate85.smethod_0(text, Delegate62.smethod_0(ex));
					}
					finally
					{
						Delegate37.smethod_0(hashtable_0, Delegate11.smethod_0(typeof(T).TypeHandle));
					}
				}
				val = gparam_0;
				return val;
			}
			catch (Exception exception_)
			{
				Class9.smethod_32(exception_, gparam_0, val, text, object_, array, flag, flag2, flag3);
				throw;
			}
		}

		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			T val = default(T);
			try
			{
				((Component)gparam_0).Dispose();
				val = (gparam_0 = default(T));
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, this, gparam_0, val);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool flag = default(bool);
			try
			{
				return flag = Delegate83.smethod_0(this, Delegate26.smethod_0(o));
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, this, o, flag);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int num = default(int);
			try
			{
				num = Delegate25.smethod_0(this);
				return num;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, num);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type type = default(Type);
			try
			{
				type = Delegate11.smethod_0(typeof(Class3).TypeHandle);
				return type;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, type);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string text = default(string);
			try
			{
				text = Delegate61.smethod_0(this);
				return text;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, text);
				throw;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool flag = default(bool);
			try
			{
				return flag = Delegate83.smethod_0(this, Delegate26.smethod_0(o));
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, this, o, flag);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			int num = default(int);
			try
			{
				num = Delegate25.smethod_0(this);
				return num;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, num);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			Type type = default(Type);
			try
			{
				type = Delegate11.smethod_0(typeof(Class4).TypeHandle);
				return type;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, type);
				throw;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string text = default(string);
			try
			{
				text = Delegate61.smethod_0(this);
				return text;
			}
			catch (Exception exception_)
			{
				Class9.smethod_26(exception_, this, text);
				throw;
			}
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			bool flag = default(bool);
			T val = default(T);
			try
			{
				if (flag = gparam_0 == null)
				{
					val = new T();
					return val;
				}
				val = gparam_0;
				return val;
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, gparam_0, val, flag);
				throw;
			}
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			T val = default(T);
			try
			{
				val = (gparam_0 = default(T));
			}
			catch (Exception exception_)
			{
				Class9.smethod_27(exception_, this, gparam_0, val);
				throw;
			}
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				bool flag = default(bool);
				T val = default(T);
				try
				{
					if (flag = gparam_0 == null)
					{
						gparam_0 = new T();
					}
					val = gparam_0;
					return val;
				}
				catch (Exception exception_)
				{
					Class9.smethod_27(exception_, this, val, flag);
					throw;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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
			Class1 prop_ = default(Class1);
			try
			{
				prop_ = class5_0.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			Form0 prop_ = default(Form0);
			try
			{
				prop_ = class5_1.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			User prop_ = default(User);
			try
			{
				prop_ = class5_2.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class3 Class3_0
	{
		[DebuggerHidden]
		get
		{
			Class3 prop_ = default(Class3);
			try
			{
				prop_ = class5_3.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			Class4 prop_ = default(Class4);
			try
			{
				prop_ = class5_4.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class9.smethod_25(exception_, prop_);
				throw;
			}
		}
	}
}
