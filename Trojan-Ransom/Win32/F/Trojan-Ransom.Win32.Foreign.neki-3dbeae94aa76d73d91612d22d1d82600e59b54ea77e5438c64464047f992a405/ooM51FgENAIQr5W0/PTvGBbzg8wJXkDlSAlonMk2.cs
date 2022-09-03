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

namespace ooM51FgENAIQr5W0;

[HideModuleName]
[GeneratedCode("MyTemplate", "8.0.0.0")]
[StandardModule]
internal sealed class PTvGBbzg8wJXkDlSAlonMk2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Hvdl1Lsh9z9yQeoDQ3g3
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Hvdl1Lsh9z9yQeoDQ3g3()
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

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type lMHhBmhLSDXgnQucZtf0()
		{
			return typeof(Hvdl1Lsh9z9yQeoDQ3g3);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T aNNRn9NMM7uXul7rxZe1<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void BZK0zDbiMIm1paBTsxV2<T>(ref T instance)
		{
			instance = default(T);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class k7OAuEoGsVfpWcLRgpM4<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
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
		public k7OAuEoGsVfpWcLRgpM4()
		{
		}
	}

	private static readonly k7OAuEoGsVfpWcLRgpM4<bF8TksePBVd1zHU7LdiFLC1> m_ComputerObjectProvider = new k7OAuEoGsVfpWcLRgpM4<bF8TksePBVd1zHU7LdiFLC1>();

	private static readonly k7OAuEoGsVfpWcLRgpM4<TwjuLUODdogUwN3WTdvreV0> m_AppObjectProvider = new k7OAuEoGsVfpWcLRgpM4<TwjuLUODdogUwN3WTdvreV0>();

	private static readonly k7OAuEoGsVfpWcLRgpM4<User> m_UserObjectProvider = new k7OAuEoGsVfpWcLRgpM4<User>();

	private static readonly k7OAuEoGsVfpWcLRgpM4<Hvdl1Lsh9z9yQeoDQ3g3> m_MyWebServicesObjectProvider = new k7OAuEoGsVfpWcLRgpM4<Hvdl1Lsh9z9yQeoDQ3g3>();

	[HelpKeyword("My.Computer")]
	internal static bF8TksePBVd1zHU7LdiFLC1 Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static TwjuLUODdogUwN3WTdvreV0 Application
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
	internal static Hvdl1Lsh9z9yQeoDQ3g3 WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
