using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Tk0a7;
using Wc93E;

namespace x0G2P;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Fg9i2
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class r3LTb
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool k8DPm(object n0B4F)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(n0B4F));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int n7RJw()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Qz0m7()
		{
			IReflect typeFromHandle = typeof(r3LTb);
			return (Type)typeFromHandle;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string c6D3P()
		{
			IEnumerable enumerable = base.ToString();
			return (string)enumerable;
		}

		private static Jm76R p1Q4B<Jm76R>(Jm76R Hz3g1) where Jm76R : new()
		{
			if (Hz3g1 == null)
			{
				return new Jm76R();
			}
			return Hz3g1;
		}

		private void j3L5E<o6N5Z>(ref o6N5Z b2K1E)
		{
			b2K1E = default(o6N5Z);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public r3LTb()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Ao25N<i0F5L> where i0F5L : new()
	{
		[ThreadStatic]
		private static i0F5L m_ThreadStaticValue;

		internal i0F5L GetInstance
		{
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new i0F5L();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ao25N()
		{
		}
	}

	private static readonly Ao25N<Np7d3> m_ComputerObjectProvider = new Ao25N<Np7d3>();

	private static readonly Ao25N<c6Y3H> m_AppObjectProvider = new Ao25N<c6Y3H>();

	private static readonly Ao25N<User> m_UserObjectProvider = new Ao25N<User>();

	private static readonly Ao25N<r3LTb> m_MyWebServicesObjectProvider = new Ao25N<r3LTb>();

	[HelpKeyword("My.Computer")]
	internal static Np7d3 Computer
	{
		get
		{
			object getInstance = m_ComputerObjectProvider.GetInstance;
			return (Np7d3)getInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static c6Y3H Application
	{
		get
		{
			ConsoleApplicationBase getInstance = (ConsoleApplicationBase)(object)m_AppObjectProvider.GetInstance;
			return getInstance as c6Y3H;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			object getInstance = m_UserObjectProvider.GetInstance;
			return (User)getInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static r3LTb WebServices
	{
		get
		{
			object getInstance = m_MyWebServicesObjectProvider.GetInstance;
			return (r3LTb)getInstance;
		}
	}
}
