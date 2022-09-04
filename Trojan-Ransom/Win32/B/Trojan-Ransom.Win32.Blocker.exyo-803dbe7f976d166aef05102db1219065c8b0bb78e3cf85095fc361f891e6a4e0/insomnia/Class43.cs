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

namespace insomnia;

[StandardModule]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
internal sealed class Class43
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class44
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class44()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Method3()
		{
			return typeof(Class44);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Method2<T>(T A_0) where T : new()
		{
			if (A_0 == null)
			{
				return new T();
			}
			return A_0;
		}

		[DebuggerHidden]
		private void Method1<T>(ref T A_1)
		{
			A_1 = default(T);
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class45<T> where T : new()
	{
		private readonly ContextValue<T> Field1;

		internal T Property1
		{
			[DebuggerHidden]
			get
			{
				T val = this._003F.get_Value();
				if (val == null)
				{
					val = new T();
					this._003F.set_Value(val);
				}
				return val;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class45()
		{
			this._003F = new ContextValue<T>();
		}
	}

	private static readonly Class45<Computer1> Field4 = new Class45<Computer1>();

	private static readonly Class45<ApplicationBase1> Field3 = new Class45<ApplicationBase1>();

	private static readonly Class45<User> Field2 = new Class45<User>();

	private static readonly Class45<Class44> Field1 = new Class45<Class44>();

	[HelpKeyword("My.Computer")]
	internal static Computer1 Property4
	{
		[DebuggerHidden]
		get
		{
			return Field4.get__003F();
		}
	}

	[HelpKeyword("My.Application")]
	internal static ApplicationBase1 Property3
	{
		[DebuggerHidden]
		get
		{
			return Field3.get__003F();
		}
	}

	[HelpKeyword("My.User")]
	internal static User Property2
	{
		[DebuggerHidden]
		get
		{
			return Field2.get__003F();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class44 Property1
	{
		[DebuggerHidden]
		get
		{
			return Field1.get__003F();
		}
	}
}
