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

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyProject
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
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
		public MyWebServices()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static _003F unknown_0
	{
		[DebuggerHidden]
		get
		{
			return (MyComputer)m_ComputerObjectProvider.unknown_0;
		}
	}

	[HelpKeyword("My.Application")]
	internal static _003F unknown_1
	{
		[DebuggerHidden]
		get
		{
			return (MyApplication)m_AppObjectProvider.unknown_0;
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
			return (MyWebServices)m_MyWebServicesObjectProvider.unknown_0;
		}
	}

	private void method_0()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_1()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_2()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_3()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_4()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_5()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_6()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_7()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_8()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_9()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_10()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_11()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_12()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_13()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_14()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_15()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_16()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_17()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_18()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_19()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_20()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_21()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_22()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_23()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_24()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_25()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_26()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_27()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_28()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_29()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_30()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_31()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_32()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_33()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_34()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_35()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_36()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_37()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_38()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_39()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_40()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_41()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_42()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_43()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_44()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_45()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_46()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_47()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_48()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_49()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_50()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_51()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_52()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_53()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_54()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_55()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_56()
	{
		/*Error: Unexpected end of block*/;
	}

	private void method_57()
	{
		/*Error: Unexpected end of block*/;
	}
}
