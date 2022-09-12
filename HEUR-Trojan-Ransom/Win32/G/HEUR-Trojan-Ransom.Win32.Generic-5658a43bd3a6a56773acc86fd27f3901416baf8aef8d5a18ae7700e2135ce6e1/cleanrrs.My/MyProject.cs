using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace cleanrrs.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class0
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		public Form1 method_0()
		{
			form1_0 = smethod_0(form1_0);
			return form1_0;
		}

		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false)
			{
				if (hashtable_0 != null)
				{
					if (Class3.Class5.Class6.smethod_7(hashtable_0, (object)typeof(T), (short)313, 341))
					{
						throw new InvalidOperationException(Class3.Class5.Class6.smethod_8("WinForms_RecursiveFormCreate", new string[0], 821, 817));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				Class3.Class5.Class6.smethod_9<Hashtable, object, object>(hashtable_0, typeof(T), null, 92, 15);
				try
				{
					return new T();
				}
				catch (TargetInvocationException gparam_) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					Class3.Class5.smethod_13((Exception)gparam_, (short)42, 4);
					return Class7.smethod_13((Exception)gparam_, (short)844, 818) != null;
				}).Invoke())
				{
					string message = (string)(IComparable)Class3.Class5.Class6.smethod_8("WinForms_SeeInnerException", new string[1] { Class3.Class5.Class6.smethod_10(Class7.smethod_13((Exception)gparam_, (short)359, 281), 955, 954) }, 48, 52);
					throw new InvalidOperationException(message, Class12.smethod_1((Exception)gparam_, 460, 'Ǿ'));
				}
				finally
				{
					Class12.Class14.smethod_1(hashtable_0, (object)typeof(T), 20, '\u0005');
				}
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class3.smethod_5(obj, 628, 'ȣ'));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return (Type)(IReflect)typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IEnumerable)base.ToString();
		}

		[SecuritySafeCritical]
		static Class0()
		{
			Class3.Class5.Class6.smethod_0();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class3.smethod_5(obj, 817, '\u0366'));
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
			return (string)(IComparable)base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[SecuritySafeCritical]
		static Class1()
		{
			Class3.Class5.Class6.smethod_0();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
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
		}

		[SecuritySafeCritical]
		static Class2()
		{
			Class3.Class5.Class6.smethod_0();
		}
	}

	private static readonly Class2<MyComputer> class2_0;

	private static readonly Class2<MyApplication> class2_1;

	private static readonly Class2<User> class2_2;

	private static Class2<Class0> class2_3;

	private static readonly Class2<Class1> class2_4;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0 => (MyComputer)(ServerComputer)class2_0.method_0();

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0 => (MyApplication)(ConsoleApplicationBase)class2_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class2_2.method_0();

	[HelpKeyword("My.Forms")]
	internal static Class0 Class0_0 => class2_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0 => class2_4.method_0();

	[SecuritySafeCritical]
	static MyProject()
	{
		Class3.Class5.Class6.smethod_0();
		class2_0 = new Class2<MyComputer>();
		class2_1 = new Class2<MyApplication>();
		class2_2 = new Class2<User>();
		class2_3 = new Class2<Class0>();
		class2_4 = new Class2<Class1>();
	}
}
