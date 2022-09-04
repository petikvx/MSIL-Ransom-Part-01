using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns0;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class1
{
	[EditorBrowsable(EditorBrowsableState.Never)]
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

		private unsafe static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			void* ptr = stackalloc byte[2];
			if ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false)
			{
				*(bool*)ptr = hashtable_0 != null;
				if (*(bool*)ptr)
				{
					((byte*)ptr)[1] = (hashtable_0.ContainsKey(typeof(T)) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[1] != 0)
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

		[EditorBrowsable(EditorBrowsableState.Never)]
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
		string object.ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
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
		string object.ToString()
		{
			return base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
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
		public Class4()
		{
		}
	}

	private static readonly Class4<Class0> class4_0 = new Class4<Class0>();

	private static readonly Class4<Form0> class4_1 = new Class4<Form0>();

	private static readonly Class4<User> class4_2 = new Class4<User>();

	private static Class4<Class2> class4_3 = new Class4<Class2>();

	private static readonly Class4<Class3> class4_4 = new Class4<Class3>();

	[SpecialName]
	internal static Class0 smethod_0()
	{
		return class4_0.method_0();
	}

	[SpecialName]
	internal static Form0 smethod_1()
	{
		return class4_1.method_0();
	}

	[SpecialName]
	internal static Class2 smethod_2()
	{
		return class4_3.method_0();
	}
}
