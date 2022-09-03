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

namespace ns1;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class ACXI0nnlHiqmG3Ru0QxC52
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class BTK3DtTMGJkoDdPCw0y3Y4<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
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
		public BTK3DtTMGJkoDdPCw0y3Y4()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class koX453oCp4FZnSwgg5JwD3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public koX453oCp4FZnSwgg5JwD3()
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type y3I6S4OwkEy95ge0EVjYJ0()
		{
			return typeof(koX453oCp4FZnSwgg5JwD3);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T ieKmialeJLO5rMkeXcZA51<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void method_0<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	private static readonly BTK3DtTMGJkoDdPCw0y3Y4<t8dZ57TZgm9sz7F0lu6Lb1> m_ComputerObjectProvider = new BTK3DtTMGJkoDdPCw0y3Y4<t8dZ57TZgm9sz7F0lu6Lb1>();

	private static readonly BTK3DtTMGJkoDdPCw0y3Y4<WFv5AK6xEb4CKyMKy0> m_AppObjectProvider = new BTK3DtTMGJkoDdPCw0y3Y4<WFv5AK6xEb4CKyMKy0>();

	private static readonly BTK3DtTMGJkoDdPCw0y3Y4<User> m_UserObjectProvider = new BTK3DtTMGJkoDdPCw0y3Y4<User>();

	private static readonly BTK3DtTMGJkoDdPCw0y3Y4<koX453oCp4FZnSwgg5JwD3> m_MyWebServicesObjectProvider = new BTK3DtTMGJkoDdPCw0y3Y4<koX453oCp4FZnSwgg5JwD3>();

	[HelpKeyword("My.Computer")]
	internal static t8dZ57TZgm9sz7F0lu6Lb1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static WFv5AK6xEb4CKyMKy0 Application
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
	internal static koX453oCp4FZnSwgg5JwD3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
