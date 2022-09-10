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
using Microsoft.VisualBasic.MyServices.Internal;
using ns10;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class15
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class16
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		bool object.Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		int object.GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class16);
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
		public Class16()
		{
		}

		static Class16()
		{
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (!Class12.StrongNameSignatureVerificationEx_2(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(Class32.smethod_0(230)))
			{
				throw new SecurityException(Class32.smethod_0(255));
			}
		}

		internal static bool fVxcp6jkH7GvBm93TI()
		{
			return true;
		}

		internal static bool myP4JIvP1EOj4G9U5T()
		{
			return false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class17<T> where T : new()
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class17()
		{
			contextValue_0 = new ContextValue<T>();
		}

		internal static bool qSKEHhSbLxO4VMCWyd()
		{
			return true;
		}

		internal static bool t4ih8SMIfQWUBmaLSJ()
		{
			return false;
		}
	}

	private static readonly Class17<Class14> class17_0 = new Class17<Class14>();

	private static readonly Class17<Class13> class17_1 = new Class17<Class13>();

	private static readonly Class17<User> class17_2 = new Class17<User>();

	private static readonly Class17<Class16> class17_3 = new Class17<Class16>();

	[HelpKeyword("My.Computer")]
	internal static Class14 Computer
	{
		[DebuggerHidden]
		get
		{
			return class17_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class13 Application
	{
		[DebuggerHidden]
		get
		{
			return class17_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return class17_2.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class16 WebServices
	{
		[DebuggerHidden]
		get
		{
			return class17_3.GetInstance;
		}
	}

	internal static bool UIq3qPd7Jk9CQrluf6()
	{
		return true;
	}

	internal static bool DClNAcVOlueraCjNT8()
	{
		return false;
	}
}
