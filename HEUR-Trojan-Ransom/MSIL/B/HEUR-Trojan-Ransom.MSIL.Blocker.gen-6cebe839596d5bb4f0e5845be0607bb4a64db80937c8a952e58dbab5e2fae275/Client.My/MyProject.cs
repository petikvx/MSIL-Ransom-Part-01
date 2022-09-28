using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace Client.My;

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class0
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class0()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class5.Class7.smethod_0(obj, 878, 769));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return (Type)(MemberInfo)typeof(Class0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IConvertible)base.ToString();
		}

		static Class0()
		{
			MyApplication.smethod_0();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class1
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class5.Class7.smethod_0(obj, 230, 137));
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

		static Class1()
		{
			MyApplication.smethod_0();
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
		}

		static Class2()
		{
			MyApplication.smethod_0();
		}
	}

	private static readonly Class2<MyComputer> class2_0;

	private static readonly Class2<MyApplication> class2_1;

	private static readonly Class2<User> class2_2;

	private static Class2<Class0> class2_3;

	private static readonly Class2<Class1> class2_4;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0 => class2_0.method_0();

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0 => class2_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class2_2.method_0();

	[HelpKeyword("My.Forms")]
	internal static Class0 Class0_0 => class2_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0 => class2_4.method_0();

	static MyProject()
	{
		MyApplication.smethod_0();
		class2_0 = new Class2<MyComputer>();
		class2_1 = new Class2<MyApplication>();
		class2_2 = new Class2<User>();
		class2_3 = new Class2<Class0>();
		class2_4 = new Class2<Class1>();
	}
}
