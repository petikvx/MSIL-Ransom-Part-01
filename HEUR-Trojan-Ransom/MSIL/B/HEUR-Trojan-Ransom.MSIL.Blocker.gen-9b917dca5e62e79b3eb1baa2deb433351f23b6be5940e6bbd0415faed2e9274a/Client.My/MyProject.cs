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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class1
	{
		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class1()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(MyComputer.Class0.smethod_1(obj, 168, 157));
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
			return base.ToString();
		}

		static Class1()
		{
			Class6.smethod_0();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(MyComputer.Class0.smethod_1(obj, 75, 126));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			return (Type)(_Type)typeof(Class2);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IConvertible)base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class2()
		{
		}

		static Class2()
		{
			Class6.smethod_0();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3<T> where T : new()
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
		public Class3()
		{
		}

		static Class3()
		{
			Class6.smethod_0();
		}
	}

	private static readonly Class3<MyComputer> class3_0;

	private static readonly Class3<MyApplication> class3_1;

	private static readonly Class3<User> class3_2;

	private static Class3<Class1> class3_3;

	private static readonly Class3<Class2> class3_4;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0 => class3_0.method_0();

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0 => class3_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class3_2.method_0();

	[HelpKeyword("My.Forms")]
	internal static Class1 Class1_0 => class3_3.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class2 Class2_0 => class3_4.method_0();

	static MyProject()
	{
		Class6.smethod_0();
		class3_0 = new Class3<MyComputer>();
		class3_1 = new Class3<MyApplication>();
		class3_2 = new Class3<User>();
		class3_3 = new Class3<Class1>();
		class3_4 = new Class3<Class2>();
	}
}
