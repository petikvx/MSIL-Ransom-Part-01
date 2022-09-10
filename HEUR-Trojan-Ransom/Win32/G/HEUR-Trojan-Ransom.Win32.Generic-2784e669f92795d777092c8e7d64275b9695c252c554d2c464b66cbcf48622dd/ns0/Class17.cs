using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

namespace ns0;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class17
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class18
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return smethod_2(this, smethod_1(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return smethod_5(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return smethod_6(typeof(Class18).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return (string)smethod_7(this);
		}

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			if (gparam_0 == null)
			{
				return new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class18()
		{
			smethod_8(this);
		}

		internal static object smethod_1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		internal static bool smethod_2(object object_0, object object_1)
		{
			return object_0.Equals(object_1);
		}

		internal static bool smethod_3()
		{
			return true;
		}

		internal static bool smethod_4()
		{
			return false;
		}

		internal static int smethod_5(object object_0)
		{
			return object_0.GetHashCode();
		}

		internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		internal static object smethod_7(object object_0)
		{
			return object_0.ToString();
		}

		internal static void smethod_8(object object_0)
		{
			object_0._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class19<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			T val = contextValue_0.get_Value();
			if (val == null)
			{
				val = new T();
				contextValue_0.set_Value(val);
			}
			return val;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class19()
		{
			contextValue_0 = new ContextValue<T>();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static bool smethod_1()
		{
			return false;
		}
	}

	private static readonly Class19<Class16> class19_0 = new Class19<Class16>();

	private static readonly Class19<Class15> class19_1 = new Class19<Class15>();

	private static readonly Class19<User> class19_2;

	private static readonly Class19<Class18> class19_3;

	[HelpKeyword("My.Computer")]
	internal static Class16 Class16_0
	{
		[DebuggerHidden]
		get
		{
			return class19_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class15 Class15_0
	{
		[DebuggerHidden]
		get
		{
			return class19_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class19_2.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class18 Class18_0
	{
		[DebuggerHidden]
		get
		{
			return class19_3.method_0();
		}
	}

	static Class17()
	{
		smethod_1();
		if (smethod_0())
		{
			class19_2 = new Class19<User>();
		}
		class19_3 = new Class19<Class18>();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static bool smethod_1()
	{
		return false;
	}
}
