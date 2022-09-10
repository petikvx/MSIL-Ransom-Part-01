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

namespace ns2;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class14
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class15
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		bool object.Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class15);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			return base.ToString();
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
		public Class15()
		{
		}

		internal static bool NkxJ72nQdtarHhKHPy()
		{
			return true;
		}

		internal static bool j1UlSIWRqu2n4ynqqj()
		{
			return false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class16<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				T val = contextValue_0.get_Value();
				if (val == null)
				{
					val = new T();
					contextValue_0.set_Value(val);
				}
				return val;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class16()
		{
			contextValue_0 = new ContextValue<T>();
		}

		internal static bool eSX3jFFH1wZF5OYrRR()
		{
			return true;
		}

		internal static bool kMYOaHRffCX0gdI8kv()
		{
			return false;
		}
	}

	private static readonly Class16<Class13> class16_0 = new Class16<Class13>();

	private static readonly Class16<Class12> class16_1 = new Class16<Class12>();

	private static readonly Class16<User> class16_2 = new Class16<User>();

	private static readonly Class16<Class15> class16_3 = new Class16<Class15>();

	[HelpKeyword("My.Computer")]
	internal static Class13 Computer
	{
		[DebuggerHidden]
		get
		{
			return class16_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class12 Application
	{
		[DebuggerHidden]
		get
		{
			return class16_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return class16_2.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class15 WebServices
	{
		[DebuggerHidden]
		get
		{
			return class16_3.GetInstance;
		}
	}

	internal static bool YLJTtOiUvFBW7j5cfv()
	{
		return true;
	}

	internal static bool yYgC7bKKAXy15MXlsO()
	{
		return false;
	}
}
