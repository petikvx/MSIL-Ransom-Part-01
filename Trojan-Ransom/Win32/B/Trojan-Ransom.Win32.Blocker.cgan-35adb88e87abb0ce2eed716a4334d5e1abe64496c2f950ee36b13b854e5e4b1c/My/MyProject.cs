using System;
using System.CodeDom.Compiler;
using System.Collections;
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

[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(Class6.smethod_13(obj, 587, 521));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return (string)(IEnumerable)base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
			MyApplication.Class2.smethod_7();
			Class7.Class8.smethod_8();
		}

		[SecuritySafeCritical]
		static Class3()
		{
			Class7.smethod_6();
			MyApplication.smethod_9();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
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
		public Class4()
		{
			MyApplication.smethod_6();
			Class7.smethod_1();
		}

		[SecuritySafeCritical]
		static Class4()
		{
			Class7.smethod_6();
			MyApplication.smethod_9();
		}
	}

	private static readonly Class4<MyComputer> class4_0;

	private static readonly Class4<MyApplication> class4_1;

	private static readonly Class4<User> class4_2;

	private static readonly Class4<Class3> class4_3;

	[HelpKeyword("My.Computer")]
	internal static MyComputer MyComputer_0
	{
		get
		{
			MyComputer result = class4_0.method_0();
			MyApplication.Class0.Class1.smethod_1();
			Class11.smethod_9();
			return result;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication MyApplication_0
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			MyApplication result = (MyApplication)(ApplicationBase)class4_1.method_0();
			MyApplication.smethod_5();
			Class11.smethod_8();
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
			User result = class4_2.method_0();
			MyApplication.smethod_7();
			Class7.Class8.smethod_8();
			return result;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0
	{
		get
		{
			Class3 result = class4_3.method_0();
			MyApplication.Class0.Class1.smethod_6();
			Class11.smethod_7();
			return result;
		}
	}

	[SecuritySafeCritical]
	static MyProject()
	{
		Class7.smethod_6();
		MyApplication.smethod_9();
		class4_0 = new Class4<MyComputer>();
		class4_1 = new Class4<MyApplication>();
		class4_2 = new Class4<User>();
		class4_3 = new Class4<Class3>();
	}
}
