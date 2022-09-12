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
using WindowsApplication1;

namespace ns0;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class4
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
					Class11.smethod_23(exception_, this, form);
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
							throw new ArgumentException("Property can only be set to Nothing");
						}
						method_0(ref form1_0);
					}
				}
				catch (Exception exception_)
				{
					Class11.smethod_24(exception_, this, value, flag);
					throw;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
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
			string resourceString = default(string);
			try
			{
				if (flag = ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false))
				{
					if (flag2 = hashtable_0 != null)
					{
						if (flag3 = hashtable_0.ContainsKey(typeof(T)))
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
						val = new T();
						return val;
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object_ = ex;
						ProjectData.SetProjectError((Exception)ex);
						return ex.InnerException != null;
					}).Invoke())
					{
						array = new string[1] { ex.InnerException!.Message };
						resourceString = Utils.GetResourceString("WinForms_SeeInnerException", array);
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						hashtable_0.Remove(typeof(T));
					}
				}
				val = gparam_0;
				return val;
			}
			catch (Exception exception_)
			{
				Class11.smethod_29(exception_, gparam_0, val, resourceString, object_, array, flag, flag2, flag3);
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
				Class11.smethod_24(exception_, this, gparam_0, val);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool flag = default(bool);
			try
			{
				return flag = base.Equals(RuntimeHelpers.GetObjectValue(o));
			}
			catch (Exception exception_)
			{
				Class11.smethod_24(exception_, this, o, flag);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			try
			{
				hashCode = base.GetHashCode();
				return hashCode;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, hashCode);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			Type typeFromHandle = default(Type);
			try
			{
				typeFromHandle = typeof(Class4);
				return typeFromHandle;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, typeFromHandle);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			string text = default(string);
			try
			{
				text = base.ToString();
				return text;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, text);
				throw;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class5
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			bool flag = default(bool);
			try
			{
				return flag = base.Equals(RuntimeHelpers.GetObjectValue(o));
			}
			catch (Exception exception_)
			{
				Class11.smethod_24(exception_, this, o, flag);
				throw;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			int hashCode = default(int);
			try
			{
				hashCode = base.GetHashCode();
				return hashCode;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, hashCode);
				throw;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			Type typeFromHandle = default(Type);
			try
			{
				typeFromHandle = typeof(Class5);
				return typeFromHandle;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, typeFromHandle);
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
				text = base.ToString();
				return text;
			}
			catch (Exception exception_)
			{
				Class11.smethod_23(exception_, this, text);
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
				Class11.smethod_24(exception_, gparam_0, val, flag);
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
				Class11.smethod_24(exception_, this, gparam_0, val);
				throw;
			}
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class6<T> where T : new()
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
					Class11.smethod_24(exception_, this, val, flag);
					throw;
				}
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class6()
		{
		}
	}

	private static readonly Class6<Class2> class6_0 = new Class6<Class2>();

	private static readonly Class6<Class0> class6_1 = new Class6<Class0>();

	private static readonly Class6<User> class6_2 = new Class6<User>();

	private static Class6<Class4> class6_3 = new Class6<Class4>();

	private static readonly Class6<Class5> class6_4 = new Class6<Class5>();

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			Class2 prop_ = default(Class2);
			try
			{
				prop_ = class6_0.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0
	{
		[DebuggerHidden]
		get
		{
			Class0 prop_ = default(Class0);
			try
			{
				prop_ = class6_1.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, prop_);
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
				prop_ = class6_2.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			Class4 prop_ = default(Class4);
			try
			{
				prop_ = class6_3.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, prop_);
				throw;
			}
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			Class5 prop_ = default(Class5);
			try
			{
				prop_ = class6_4.Prop_0;
				return prop_;
			}
			catch (Exception exception_)
			{
				Class11.smethod_22(exception_, prop_);
				throw;
			}
		}
	}
}
