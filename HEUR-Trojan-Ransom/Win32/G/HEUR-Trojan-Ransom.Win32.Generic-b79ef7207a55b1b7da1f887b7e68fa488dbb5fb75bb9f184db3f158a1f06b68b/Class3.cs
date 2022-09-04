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
		[DebuggerHidden]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T smethod_0<T>(object instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return (T)instance;
		}

		[DebuggerHidden]
		private void obtEoZxXG<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class7.pZcHwjQzdndJT();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class7.pZcHwjQzdndJT();
			base._002Ector();
		}
	}

	private static readonly Class5<Class4> class5_0;

	private static readonly Class5<User> class5_1;

	private static readonly Class5<Class1> class5_2;

	private static readonly Class5<Class2> class5_3;

	[HelpKeyword("My.Computer")]
	internal static object gEkhqesr3
	{
		[DebuggerHidden]
		get
		{
			return class5_3.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static object Object_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static object Object_1
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static object Object_2
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	static Class3()
	{
		Class7.pZcHwjQzdndJT();
		class5_3 = new Class5<Class2>();
		class5_2 = new Class5<Class1>();
		class5_1 = new Class5<User>();
		class5_0 = new Class5<Class4>();
	}
}
