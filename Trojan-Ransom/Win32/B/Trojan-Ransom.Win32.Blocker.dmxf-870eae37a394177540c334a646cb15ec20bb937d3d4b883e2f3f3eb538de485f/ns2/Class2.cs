using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns2;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Class2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class3
	{
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(Class3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class3()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal _003F unknown_0
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
		}
	}

	private static readonly Class4<Class1> m_ComputerObjectProvider = new Class4<Class1>();

	private static readonly Class4<Class0> m_AppObjectProvider = new Class4<Class0>();

	private static readonly Class4<User> m_UserObjectProvider = new Class4<User>();

	private static readonly Class4<Class3> m_MyWebServicesObjectProvider = new Class4<Class3>();

	[HelpKeyword("My.Computer")]
	internal static _003F unknown_0
	{
		[DebuggerHidden]
		get
		{
			return (Class1)m_ComputerObjectProvider.unknown_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static _003F unknown_1
	{
		[DebuggerHidden]
		get
		{
			return (Class0)m_AppObjectProvider.unknown_0;
		}
	}

	[HelpKeyword("My.User")]
	internal static _003F unknown_2
	{
		[DebuggerHidden]
		get
		{
			return (User)m_UserObjectProvider.unknown_0;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static _003F unknown_3
	{
		[DebuggerHidden]
		get
		{
			return (Class3)m_MyWebServicesObjectProvider.unknown_0;
		}
	}

	static MessageData SVpSWkgQdDDdmyb()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IContributeClientContextSink xdBTsTeYqawgrwt()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static RemotingException hyNVWfDxbdKQjrh()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static EventWaitHandle GCCBFqwFVvuLBEv()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static FlagsAttribute XBfdLzULCPZIIvv()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static IdOps NViKdJhyLywqJGc()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static MdSigCallingConvention CNSOarsOdmKqUkR()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ControlCDelegateData zTbQvrrpugZgLlX()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static ISubcategoryMembershipEntry qtwoNqVFBpKzqFP()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static GetPackagePropertyFlags oobOoLYmTlXbBom()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static SuppressIldasmAttribute LdaxTrxtGJXsuEO()
	{
		/*Error: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
