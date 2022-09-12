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
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class CO_My_MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class CO_My_MyProject_002FMyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public CO_My_MyProject_002FMyWebServices()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return cf4914ce407d70d5bc62ce8e707dbbc38.ce9259f91a915c575f208c8c25866101a(this, c67ffde7bea1a3a2d56557c54d9fb2dff.ce9259f91a915c575f208c8c25866101a(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return c72fc176c96558a97eec8fbe21117689e.ce9259f91a915c575f208c8c25866101a(this);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type CO_GetType()
		{
			return cdcd0ca0f4e98eb8bdfff3e23f9b19dbb.ce9259f91a915c575f208c8c25866101a(typeof(CO_My_MyProject_002FMyWebServices).TypeHandle);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return c3c52308230b75de824923426520a739a.ce9259f91a915c575f208c8c25866101a(this);
		}

		[DebuggerHidden]
		private static CO_T CO_Create__Instance__<CO_T>(CO_T CO_instance) where CO_T : new()
		{
			if (CO_instance == null)
			{
				return new CO_T();
			}
			return CO_instance;
		}

		[DebuggerHidden]
		private void CO_Dispose__Instance__<CO_T>(ref CO_T CO_instance)
		{
			CO_instance = default(CO_T);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class CO_My_MyProject_002FThreadSafeObjectProvider<CO_T> where CO_T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static CO_T CO_m_ThreadStaticValue;

		internal CO_T CO_GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (CO_m_ThreadStaticValue == null)
				{
					CO_m_ThreadStaticValue = new CO_T();
				}
				return CO_m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public CO_My_MyProject_002FThreadSafeObjectProvider()
		{
		}
	}

	private static readonly CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyComputer> CO_m_ComputerObjectProvider = new CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyComputer>();

	private static readonly CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyApplication> CO_m_AppObjectProvider = new CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyApplication>();

	private static readonly CO_My_MyProject_002FThreadSafeObjectProvider<User> CO_m_UserObjectProvider = new CO_My_MyProject_002FThreadSafeObjectProvider<User>();

	private static readonly CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyProject_002FMyWebServices> CO_m_MyWebServicesObjectProvider = new CO_My_MyProject_002FThreadSafeObjectProvider<CO_My_MyProject_002FMyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static CO_My_MyComputer CO_Computer
	{
		[DebuggerHidden]
		get
		{
			return CO_m_ComputerObjectProvider.CO_GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static CO_My_MyApplication CO_Application
	{
		[DebuggerHidden]
		get
		{
			return CO_m_AppObjectProvider.CO_GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User CO_User
	{
		[DebuggerHidden]
		get
		{
			return CO_m_UserObjectProvider.CO_GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static CO_My_MyProject_002FMyWebServices CO_WebServices
	{
		[DebuggerHidden]
		get
		{
			return CO_m_MyWebServicesObjectProvider.CO_GetInstance;
		}
	}
}
