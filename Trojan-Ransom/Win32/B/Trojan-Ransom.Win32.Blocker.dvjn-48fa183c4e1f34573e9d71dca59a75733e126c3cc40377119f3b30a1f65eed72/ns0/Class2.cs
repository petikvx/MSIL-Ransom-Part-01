using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns10;

namespace ns0;

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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}

		static Class3()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx_12(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool iDUlOS1rXr051unkpW()
		{
			return true;
		}

		internal static bool QtZDNtfrTF61vX3W7c()
		{
			return false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class1> class4_0;

	private static readonly Class4<Class0> class4_1;

	private static readonly Class4<User> class4_2;

	private static readonly Class4<Class3> class4_3;

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

	static Class2()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (yFRpV4Om1NOaIETIjv())
		{
			switch (0)
			{
			case 0:
				break;
			case 1:
			case 3:
				goto IL_007c;
			default:
				goto IL_0086;
			case 5:
				goto IL_0090;
			}
		}
		if (Class12.StrongNameSignatureVerificationEx_6(executingAssembly.Location, bool_0: true, out bool_) && bool_ && executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
		{
			class4_0 = new Class4<Class1>();
			goto IL_007c;
		}
		throw new SecurityException(Class32.smethod_0(255));
		IL_007c:
		class4_1 = new Class4<Class0>();
		goto IL_0086;
		IL_0090:
		class4_3 = new Class4<Class3>();
		return;
		IL_0086:
		class4_2 = new Class4<User>();
		goto IL_0090;
	}

	internal static bool yFRpV4Om1NOaIETIjv()
	{
		return true;
	}

	internal static bool uyLdY8qK6sIJwQgsgS()
	{
		return false;
	}
}
