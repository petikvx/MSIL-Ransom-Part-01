using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns4;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class7
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class8
	{
		public A a_0;

		public B b_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class8()
		{
		}

		[SpecialName]
		public A method_0()
		{
			a_0 = smethod_0(a_0);
			return a_0;
		}

		[SpecialName]
		public B method_1()
		{
			b_0 = smethod_0(b_0);
			return b_0;
		}

		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if (gparam_0 != null && !((Control)gparam_0).get_IsDisposed())
			{
				return gparam_0;
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
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class9
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class9()
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
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class10<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class10()
		{
		}

		[SpecialName]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}
	}

	private static readonly Class10<Class6> class10_0 = new Class10<Class6>();

	private static readonly Class10<Form0> class10_1 = new Class10<Form0>();

	private static readonly Class10<User> class10_2 = new Class10<User>();

	private static Class10<Class8> class10_3 = new Class10<Class8>();

	private static readonly Class10<Class9> class10_4 = new Class10<Class9>();

	[SpecialName]
	internal static Class6 smethod_0()
	{
		return class10_0.method_0();
	}

	[SpecialName]
	internal static Form0 smethod_1()
	{
		return class10_1.method_0();
	}

	[SpecialName]
	internal static Class8 smethod_2()
	{
		return class10_3.method_0();
	}
}
