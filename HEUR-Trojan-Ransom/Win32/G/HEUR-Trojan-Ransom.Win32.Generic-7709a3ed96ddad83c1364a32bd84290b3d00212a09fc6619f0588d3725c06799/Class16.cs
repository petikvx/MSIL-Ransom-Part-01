using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class16
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class17
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class17()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class17);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
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
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class18<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class18()
		{
			contextValue_0 = new ContextValue<T>();
		}

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
	}

	private static readonly Class18<Class13> class18_0 = new Class18<Class13>();

	private static readonly Class18<Class14> class18_1 = new Class18<Class14>();

	private static readonly Class18<User> class18_2 = new Class18<User>();

	private static readonly Class18<Class17> class18_3 = new Class18<Class17>();

	[DebuggerHidden]
	internal static Class13 smethod_0()
	{
		return class18_0.method_0();
	}

	[DebuggerHidden]
	internal static Class14 smethod_1()
	{
		return class18_1.method_0();
	}

	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class18_2.method_0();
	}

	[DebuggerHidden]
	internal static Class17 smethod_3()
	{
		return class18_3.method_0();
	}
}
