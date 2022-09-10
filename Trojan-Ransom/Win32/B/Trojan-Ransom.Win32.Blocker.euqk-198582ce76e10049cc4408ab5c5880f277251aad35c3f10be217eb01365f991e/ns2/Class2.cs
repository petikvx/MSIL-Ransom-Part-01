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
using ns0;
using ns1;

namespace ns2;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class Class2
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class3
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		unsafe bool object.Equals(object obj)
		{
			void* ptr = stackalloc byte[2];
			((byte*)ptr)[1] = (base.Equals(RuntimeHelpers.GetObjectValue(obj)) ? ((byte)1) : ((byte)0));
			return ((byte*)ptr)[1] != 0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		unsafe int object.GetHashCode()
		{
			void* ptr = stackalloc byte[8];
			*(int*)((byte*)ptr + 4) = base.GetHashCode();
			return *(int*)((byte*)ptr + 4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		public Class3()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (gparam_0 == null)
				{
					gparam_0 = new T();
				}
				return gparam_0;
			}
		}

		[DebuggerHidden]
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
	internal static Class1 Computer
	{
		[DebuggerHidden]
		get
		{
			return class4_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class0 Application
	{
		[DebuggerHidden]
		get
		{
			return class4_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return class4_2.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return class4_3.GetInstance;
		}
	}
}
