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
using b6A;
using z7Y;

namespace j9F;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
[StandardModule]
internal sealed class Rn9
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class r4X
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Tp1(object i9P)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(i9P));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int Ga8()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Rc1()
		{
			return typeof(r4X);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string As5()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static r5C Cr3<r5C>(r5C n6M) where r5C : new()
		{
			if (n6M == null)
			{
				return new r5C();
			}
			return n6M;
		}

		[DebuggerHidden]
		private void Qp2<w6X>(ref w6X e7Y)
		{
			e7Y = default(w6X);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public r4X()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class z5Z<n9R> where n9R : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static n9R m_ThreadStaticValue;

		internal n9R GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new n9R();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public z5Z()
		{
		}
	}

	private static readonly z5Z<w3C> m_ComputerObjectProvider = new z5Z<w3C>();

	private static readonly z5Z<Lq5> m_AppObjectProvider = new z5Z<Lq5>();

	private static readonly z5Z<User> m_UserObjectProvider = new z5Z<User>();

	private static readonly z5Z<r4X> m_MyWebServicesObjectProvider = new z5Z<r4X>();

	[HelpKeyword("My.Computer")]
	internal static w3C Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static Lq5 Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static r4X WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
