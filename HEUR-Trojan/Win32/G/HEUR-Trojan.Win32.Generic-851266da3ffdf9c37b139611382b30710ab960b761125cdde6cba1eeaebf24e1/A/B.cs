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

namespace A;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class B
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class A
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
		internal Type A()
		{
			return typeof(A);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static A A<A>(A gparam_0) where A : new()
		{
			if (gparam_0 == null)
			{
				return new A();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void A<A>(ref A gparam_0)
		{
			gparam_0 = default(A);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public A()
		{
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class a<A> where A : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static A m_ThreadStaticValue;

		internal A GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new A();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public a()
		{
		}
	}

	private static readonly a<a> a_0 = new a<a>();

	private static readonly a<global::A.A> a_1 = new a<global::A.A>();

	private static readonly a<User> a_2 = new a<User>();

	private static readonly a<A> a_3 = new a<A>();

	[HelpKeyword("My.Computer")]
	internal static a Computer
	{
		[DebuggerHidden]
		get
		{
			return a_0.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static global::A.A Application
	{
		[DebuggerHidden]
		get
		{
			return a_1.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return a_2.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static A WebServices
	{
		[DebuggerHidden]
		get
		{
			return a_3.GetInstance;
		}
	}
}
[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class b
{
	[HelpKeyword("My.Settings")]
	internal static d Settings => d.Default;
}
