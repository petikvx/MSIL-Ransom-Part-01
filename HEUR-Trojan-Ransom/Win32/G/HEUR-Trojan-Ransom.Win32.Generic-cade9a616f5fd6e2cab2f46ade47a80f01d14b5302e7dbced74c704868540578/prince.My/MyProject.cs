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

namespace prince.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class0
	{
		public Form1 form1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[SpecialName]
		public Form1 method_0()
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			form1_0 = smethod_0(form1_0);
			return (Form1)(ContainerControl)form1_0;
		}

		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			if ((gparam_0 == null || ((Control)gparam_0).get_IsDisposed()) ? true : false)
			{
				if (hashtable_0 != null)
				{
					if (Class3.Class7.smethod_14(hashtable_0, (object)typeof(T), 272, 'ţ'))
					{
						throw new InvalidOperationException(Class9.smethod_8("WinForms_RecursiveFormCreate", new string[0], 'ʴ', 'ʈ'));
					}
				}
				else
				{
					hashtable_0 = new Hashtable();
				}
				Class3.Class5.smethod_13<Hashtable, object, object>(hashtable_0, typeof(T), null, 578, 'Ʌ');
				try
				{
					return new T();
				}
				catch (TargetInvocationException gparam_) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					Class3.Class5.Class6.smethod_7((Exception)gparam_, (short)712, (short)722);
					return Class3.Class7.smethod_15((Exception)gparam_, 1004, 927) != null;
				}).Invoke())
				{
					string message = (string)(IComparable)Class9.smethod_8("WinForms_SeeInnerException", new string[1] { Class3.smethod_16(Class3.Class7.smethod_15((Exception)gparam_, 494, 413), 965, 998) }, '3', '\u000f');
					throw new InvalidOperationException(message, Class12.Class16.smethod_0((Exception)gparam_, (short)1011, 'ε'));
				}
				finally
				{
					Class10.Class11.smethod_4(hashtable_0, (object)typeof(T), 700, (short)665);
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
			return base.Equals(Class3.Class5.smethod_3(obj, 653, 735));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return (Type)(ICustomAttributeProvider)typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IComparable)base.ToString();
		}

		[SecuritySafeCritical]
		static Class0()
		{
			Class3.Class5.smethod_2();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class3.Class5.smethod_3(obj, 429, 511));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return (Type)(IReflect)typeof(Class1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IConvertible)base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[SecuritySafeCritical]
		static Class1()
		{
			Class3.Class5.smethod_2();
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
			Class3.Class5.smethod_2();
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
	internal static MyApplication MyApplication_0 => class2_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class2_2.method_0();

	[HelpKeyword("My.Forms")]
	internal static Class0 Class0_0 => class2_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0 => class2_4.method_0();

	[SecuritySafeCritical]
	static MyProject()
	{
		Class3.Class5.smethod_2();
		class2_0 = new Class2<MyComputer>();
		class2_1 = new Class2<MyApplication>();
		class2_2 = new Class2<User>();
		class2_3 = new Class2<Class0>();
		class2_4 = new Class2<Class1>();
	}
}
