using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
internal sealed class Class13
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class14
	{
		public GForm0 gform0_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		public GForm0 GForm0_0
		{
			[DebuggerNonUserCode]
			get
			{
				throw /*Error near IL_0001: Stack underflow*/;
			}
			[DebuggerNonUserCode]
			set;
		}

		[DebuggerHidden]
		private static extern T smethod_0<T>(T gparam_0) where T : Form, new();

		[DebuggerHidden]
		private extern void method_0<T>(ref T gparam_0) where T : Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class14();

		[EditorBrowsable(EditorBrowsableState.Never)]
		extern bool object.Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		extern int object.GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			//Discarded unreachable code: IL_0005, IL_0007
			/*Error: Invalid metadata token*/;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		extern string object.ToString();

		static string smethod_1()
		{
			return Class22.smethod_382();
		}

		static object smethod_2(string string_0)
		{
			return new ArgumentException(string_0);
		}

		static object smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static bool smethod_4(object object_0, object object_1)
		{
			return ((Hashtable)object_0).ContainsKey(object_1);
		}

		static string smethod_5()
		{
			return Class22.smethod_383();
		}

		static string smethod_6(string string_0, string[] string_1)
		{
			return Utils.GetResourceString(string_0, string_1);
		}

		static object smethod_7(string string_0)
		{
			return new InvalidOperationException(string_0);
		}

		static object smethod_8()
		{
			return new Hashtable();
		}

		static void smethod_9(object object_0, object object_1, object object_2)
		{
			((Hashtable)object_0).Add(object_1, object_2);
		}

		static void smethod_10(Exception exception_0)
		{
			ProjectData.SetProjectError(exception_0);
		}

		static object smethod_11(object object_0)
		{
			return ((Exception)object_0).InnerException;
		}

		static string smethod_12()
		{
			return Class22.smethod_384();
		}

		static string smethod_13(object object_0)
		{
			return ((Exception)object_0).Message;
		}

		static object smethod_14(string string_0, object object_0)
		{
			return new InvalidOperationException(string_0, (Exception?)object_0);
		}

		static void smethod_15()
		{
			ProjectData.ClearProjectError();
		}

		static void smethod_16(object object_0, object object_1)
		{
			((Hashtable)object_0).Remove(object_1);
		}

		static object smethod_17(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		string method_4()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class15
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		extern bool object.Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		extern int object.GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal extern Type method_0();

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		extern string object.ToString();

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			//Discarded unreachable code: IL_0006
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			_ = ((double[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Invalid metadata token*/;
		}

		[DebuggerHidden]
		private extern void method_1<T>(ref T gparam_0);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class15();

		static object smethod_1(object object_0)
		{
			return RuntimeHelpers.GetObjectValue(object_0);
		}

		bool method_2(object object_0)
		{
			return base.Equals(object_0);
		}

		int method_3()
		{
			return base.GetHashCode();
		}

		static object smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		string method_4()
		{
			return base.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class16<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		internal extern T Prop_0
		{
			[DebuggerHidden]
			get;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class16();
	}

	private static readonly Class16<Class12> class16_0;

	private static readonly Class16<Class11> class16_1;

	private static readonly Class16<User> class16_2;

	private static Class16<Class14> class16_3;

	private static readonly Class16<Class15> class16_4;

	[HelpKeyword("My.Computer")]
	internal static extern Class12 Class12_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.Application")]
	internal static extern Class11 Class11_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.User")]
	internal static extern User User_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.Forms")]
	internal static extern Class14 Class14_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.WebServices")]
	internal static extern Class15 Class15_0
	{
		[DebuggerHidden]
		get;
	}
}
