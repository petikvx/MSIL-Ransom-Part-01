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

[GeneratedCode("MyTemplate", "14.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class3
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		private static p83WDdfEVIIbTxo6aH smethod_0<p83WDdfEVIIbTxo6aH>(p83WDdfEVIIbTxo6aH YB58kEo13k2xo24fKH) where p83WDdfEVIIbTxo6aH : new()
		{
			if (YB58kEo13k2xo24fKH == null)
			{
				return new p83WDdfEVIIbTxo6aH();
			}
			return YB58kEo13k2xo24fKH;
		}

		[DebuggerHidden]
		private void method_1<AZdlARYunsdB1ayOL0>(ref AZdlARYunsdB1ayOL0 gparam_0)
		{
			gparam_0 = default(AZdlARYunsdB1ayOL0);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class7.amSa9D0zQvoBP();
			base._002Ector();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class5<xbbl1PXXud5Dpo94hS> where xbbl1PXXud5Dpo94hS : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static xbbl1PXXud5Dpo94hS gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal xbbl1PXXud5Dpo94hS method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new xbbl1PXXud5Dpo94hS();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class5()
		{
			Class7.amSa9D0zQvoBP();
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
	internal static User Ieqgdppn2
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
		Class7.amSa9D0zQvoBP();
		class5_0 = new Class5<Class2>();
		class5_1 = new Class5<Class1>();
		class5_2 = new Class5<User>();
		class5_3 = new Class5<Class4>();
	}
}
