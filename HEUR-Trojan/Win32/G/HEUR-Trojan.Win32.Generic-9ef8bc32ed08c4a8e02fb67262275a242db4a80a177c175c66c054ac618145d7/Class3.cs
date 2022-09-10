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

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class3
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static km81xwueGTvUKBcgvZ smethod_0<km81xwueGTvUKBcgvZ>(km81xwueGTvUKBcgvZ eyK03GaQYqutgntHgp) where km81xwueGTvUKBcgvZ : new()
		{
			if (eyK03GaQYqutgntHgp == null)
			{
				return new km81xwueGTvUKBcgvZ();
			}
			return eyK03GaQYqutgntHgp;
		}

		[DebuggerHidden]
		private void MuYyxnrvP<p0TCsiCimOIx9gC4A0>(ref p0TCsiCimOIx9gC4A0 gparam_0)
		{
			gparam_0 = default(p0TCsiCimOIx9gC4A0);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class13.F2pn6WrzFkP6h();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<DgsObbIILOkax2iBL8> where DgsObbIILOkax2iBL8 : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static DgsObbIILOkax2iBL8 gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal DgsObbIILOkax2iBL8 method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new DgsObbIILOkax2iBL8();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class13.F2pn6WrzFkP6h();
			base._002Ector();
		}
	}

	private static readonly Class5<Class2> class5_0;

	private static readonly Class5<Class1> class5_1;

	private static readonly Class5<User> class5_2;

	private static readonly Class5<Class4> class5_3;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return class5_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return class5_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return class5_2.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return class5_3.method_0();
		}
	}

	static Class3()
	{
		Class13.F2pn6WrzFkP6h();
		class5_0 = new Class5<Class2>();
		class5_1 = new Class5<Class1>();
		class5_2 = new Class5<User>();
		class5_3 = new Class5<Class4>();
	}
}
