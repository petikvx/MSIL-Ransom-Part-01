using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Xg0;
using i1C;

namespace Cg6;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Cx9
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Dz2
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Dd0(object Ws6)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Ws6));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int c2H()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Tm7()
		{
			MemberInfo typeFromHandle = typeof(Dz2);
			return (Type)typeFromHandle;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string n7J()
		{
			object obj = base.ToString();
			return obj as string;
		}

		private static Xc6 p4D<Xc6>(Xc6 Gd3) where Xc6 : new()
		{
			if (Gd3 == null)
			{
				return new Xc6();
			}
			return Gd3;
		}

		private void x6Y<s6L>(ref s6L x6K)
		{
			x6K = default(s6L);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Dz2()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Fd7<o1R> where o1R : new()
	{
		[ThreadStatic]
		private static o1R m_ThreadStaticValue;

		internal o1R GetInstance
		{
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new o1R();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fd7()
		{
		}
	}

	private static readonly Fd7<a4B> m_ComputerObjectProvider = new Fd7<a4B>();

	private static readonly Fd7<e5M> m_AppObjectProvider = new Fd7<e5M>();

	private static readonly Fd7<User> m_UserObjectProvider = new Fd7<User>();

	private static readonly Fd7<Dz2> m_MyWebServicesObjectProvider = new Fd7<Dz2>();

	[HelpKeyword("My.Computer")]
	internal static a4B Computer
	{
		get
		{
			Computer getInstance = (Computer)(object)m_ComputerObjectProvider.GetInstance;
			return getInstance as a4B;
		}
	}

	[HelpKeyword("My.Application")]
	internal static e5M Application
	{
		get
		{
			ConsoleApplicationBase getInstance = (ConsoleApplicationBase)(object)m_AppObjectProvider.GetInstance;
			return getInstance as e5M;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		get
		{
			object getInstance = m_UserObjectProvider.GetInstance;
			return (User)((getInstance is User) ? getInstance : null);
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Dz2 WebServices
	{
		get
		{
			object getInstance = m_MyWebServicesObjectProvider.GetInstance;
			return getInstance as Dz2;
		}
	}
}
