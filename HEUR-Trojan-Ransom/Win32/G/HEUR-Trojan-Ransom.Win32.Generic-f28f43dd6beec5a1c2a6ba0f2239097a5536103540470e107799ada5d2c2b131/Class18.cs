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
internal sealed class Class18
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class19
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class19()
		{
		}

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
			return typeof(Class19);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
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

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class20<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class20()
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

	private static readonly Class20<Class17> class20_0 = new Class20<Class17>();

	private static readonly Class20<Class16> class20_1 = new Class20<Class16>();

	private static readonly Class20<User> class20_2 = new Class20<User>();

	private static readonly Class20<Class19> class20_3 = new Class20<Class19>();

	[DebuggerHidden]
	internal static Class17 smethod_0()
	{
		return class20_0.method_0();
	}

	[DebuggerHidden]
	internal static Class16 smethod_1()
	{
		return class20_1.method_0();
	}

	[DebuggerHidden]
	internal static User smethod_2()
	{
		return class20_2.method_0();
	}

	[DebuggerHidden]
	internal static Class19 smethod_3()
	{
		return class20_3.method_0();
	}
}
