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

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class Class11
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class12
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return smethod_2(this, smethod_1(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return smethod_5(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return smethod_6(typeof(Class12).TypeHandle);
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
		public Class12()
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

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class13<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			T val = contextValue_0.get_Value();
			int num = 0;
			while (true)
			{
				if (num == 0)
				{
					if (val != null)
					{
						break;
					}
					val = new T();
					num = 1;
					continue;
				}
				contextValue_0.set_Value(val);
				break;
			}
			return val;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class13()
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

	private static readonly Class13<Class10> class13_0;

	private static readonly Class13<Class9> class13_1;

	private static readonly Class13<User> class13_2;

	private static readonly Class13<Class12> class13_3;

	[HelpKeyword("My.Computer")]
	internal static Class10 Class10_0
	{
		[DebuggerHidden]
		get
		{
			return class13_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class9 Class9_0
	{
		[DebuggerHidden]
		get
		{
			return class13_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class13_2.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class12 Class12_0
	{
		[DebuggerHidden]
		get
		{
			return class13_3.method_0();
		}
	}

	[DebuggerNonUserCode]
	static Class11()
	{
		while (true)
		{
			class13_0 = new Class13<Class10>();
			while (true)
			{
				IL_0003:
				class13_1 = new Class13<Class9>();
				smethod_1();
				if (!smethod_0())
				{
					goto IL_001a;
				}
				goto IL_0053;
				IL_0053:
				class13_2 = new Class13<User>();
				goto IL_001a;
				IL_001a:
				while (true)
				{
					class13_3 = new Class13<Class12>();
					if (smethod_1())
					{
						break;
					}
					switch (6)
					{
					case 5:
						break;
					default:
						continue;
					case 1:
					case 2:
						goto IL_0053;
					case 4:
						goto end_IL_001a;
					case 6:
						return;
					}
					goto IL_0003;
					continue;
					end_IL_001a:
					break;
				}
				break;
			}
		}
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
