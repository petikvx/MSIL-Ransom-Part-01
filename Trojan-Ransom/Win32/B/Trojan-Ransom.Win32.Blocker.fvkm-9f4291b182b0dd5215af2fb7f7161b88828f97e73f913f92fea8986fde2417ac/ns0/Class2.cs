using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
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
			return typeof(Class3);
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
		public Class3()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[SpecialName]
		internal T method_0()
		{
			if (Class4<T>.Ⴃ == null)
			{
				Class4<T>.Ⴃ = new T();
			}
			return Class4<T>.Ⴃ;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class1> class4_0 = new Class4<Class1>();

	private static readonly Class4<Class0> class4_1 = new Class4<Class0>();

	private static readonly Class4<User> class4_2 = new Class4<User>();

	private static readonly Class4<Class3> class4_3 = new Class4<Class3>();

	[HelpKeyword("My.Computer")]
	internal static Class1 Class1_0 => class4_0.method_0();

	[HelpKeyword("My.Application")]
	internal static Class0 Class0_0 => class4_1.method_0();

	[HelpKeyword("My.User")]
	internal static User User_0 => class4_2.method_0();

	[HelpKeyword("My.WebServices")]
	internal static Class3 Class3_0 => class4_3.method_0();
}
