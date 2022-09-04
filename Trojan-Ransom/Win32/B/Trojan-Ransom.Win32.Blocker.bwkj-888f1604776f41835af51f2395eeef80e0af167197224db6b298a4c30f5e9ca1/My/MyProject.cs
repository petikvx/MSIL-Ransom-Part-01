using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class MyProject
{
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
			Class4.Class5.Class6.smethod_2();
		}

		[SecuritySafeCritical]
		static Class1()
		{
			MyApplication.Class0.smethod_12();
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
			Class4.Class5.Class6.smethod_9();
		}

		[SecuritySafeCritical]
		static Class2()
		{
			MyApplication.Class0.smethod_12();
		}
	}

	private static readonly Class2<MyComputer> class2_0;

	private static readonly Class2<MyApplication> class2_1;

	private static readonly Class2<User> class2_2;

	private static readonly Class2<Class1> class2_3;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0
	{
		get
		{
			MyComputer result = class2_0.method_0();
			MyApplication.Class0.smethod_10();
			return result;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0
	{
		get
		{
			MyApplication result = class2_1.method_0();
			Class4.Class5.smethod_7();
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
			Class4.smethod_6();
			return result;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class1 Class1_0
	{
		get
		{
			Class1 result = class2_3.method_0();
			Class4.smethod_7();
			return result;
		}
	}

	[SecuritySafeCritical]
	static MyProject()
	{
		MyApplication.Class0.smethod_12();
		class2_0 = new Class2<MyComputer>();
		class2_1 = new Class2<MyApplication>();
		class2_2 = new Class2<User>();
		class2_3 = new Class2<Class1>();
	}
}
