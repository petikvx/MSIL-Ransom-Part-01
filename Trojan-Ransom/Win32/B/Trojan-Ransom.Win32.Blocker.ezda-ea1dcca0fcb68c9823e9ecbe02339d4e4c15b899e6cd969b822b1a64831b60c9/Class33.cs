using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices.Internal;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class Class33
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class34
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return Delegate365.smethod_0(this, Delegate364.smethod_0(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return Delegate366.smethod_0(this);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return Delegate98.smethod_0(typeof(Class34).TypeHandle);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return Delegate69.smethod_1(this);
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
		private void method_0<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class34()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class35<T> where T : new()
	{
		private readonly ContextValue<T> contextValue_0;

		internal T Prop_0
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class35()
		{
			contextValue_0 = new ContextValue<T>();
		}
	}

	private static readonly Class35<Class32> class35_0 = new Class35<Class32>();

	private static readonly Class35<Class31> class35_1 = new Class35<Class31>();

	private static readonly Class35<User> class35_2 = new Class35<User>();

	private static readonly Class35<Class34> class35_3 = new Class35<Class34>();

	[HelpKeyword("My.Computer")]
	internal static Class32 Class32_0
	{
		[DebuggerHidden]
		get
		{
			return class35_0.Prop_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class31 Class31_0
	{
		[DebuggerHidden]
		get
		{
			return class35_1.Prop_0;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class35_2.Prop_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class34 Class34_0
	{
		[DebuggerHidden]
		get
		{
			return class35_3.Prop_0;
		}
	}
}
