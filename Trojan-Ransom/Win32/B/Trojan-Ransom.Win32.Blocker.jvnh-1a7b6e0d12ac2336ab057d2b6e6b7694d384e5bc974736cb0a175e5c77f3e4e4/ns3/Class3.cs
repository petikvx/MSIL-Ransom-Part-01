using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;
using ns2;

namespace ns3;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
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
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}

		static Class4()
		{
			Class1.smethod_11();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<T> where T : new()
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
		public Class5()
		{
		}

		static Class5()
		{
			Class1.smethod_11();
		}
	}

	private static readonly Class5<Class2> class5_0;

	private static readonly Class5<Class0> class5_1;

	private static readonly Class5<User> class5_2;

	private static readonly Class5<Class4> class5_3;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0 => class5_0.method_0();

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0 => class5_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class5_2.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0 => class5_3.method_0();

	static Class3()
	{
		Class1.smethod_11();
		class5_0 = new Class5<Class2>();
		class5_1 = new Class5<Class0>();
		class5_2 = new Class5<User>();
		class5_3 = new Class5<Class4>();
	}
}
