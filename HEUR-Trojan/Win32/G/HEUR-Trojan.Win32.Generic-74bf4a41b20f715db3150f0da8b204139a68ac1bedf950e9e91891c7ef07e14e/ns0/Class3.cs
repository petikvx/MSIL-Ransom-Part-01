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

namespace ns0;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class3
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class4
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
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
		private static T smethod_0<T>(object instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return (T)instance;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class4()
		{
			Class7.smethod_0();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal T method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new T();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB()
		{
			Class7.smethod_0();
			base._002Ector();
		}
	}

	private static readonly ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class2> onkholbldobkeedkpglnlagfiicihjplphpb_0;

	private static readonly ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class1> onkholbldobkeedkpglnlagfiicihjplphpb_1;

	private static readonly ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<User> onkholbldobkeedkpglnlagfiicihjplphpb_2;

	private static readonly ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class4> onkholbldobkeedkpglnlagfiicihjplphpb_3;

	[HelpKeyword("My.Computer")]
	internal static Class2 Class2_0
	{
		[DebuggerHidden]
		get
		{
			return onkholbldobkeedkpglnlagfiicihjplphpb_0.method_0();
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class1 Class1_0
	{
		[DebuggerHidden]
		get
		{
			return onkholbldobkeedkpglnlagfiicihjplphpb_1.method_0();
		}
	}

	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return onkholbldobkeedkpglnlagfiicihjplphpb_2.method_0();
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class4 Class4_0
	{
		[DebuggerHidden]
		get
		{
			return onkholbldobkeedkpglnlagfiicihjplphpb_3.method_0();
		}
	}

	static Class3()
	{
		Class7.smethod_0();
		onkholbldobkeedkpglnlagfiicihjplphpb_0 = new ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class2>();
		onkholbldobkeedkpglnlagfiicihjplphpb_1 = new ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class1>();
		onkholbldobkeedkpglnlagfiicihjplphpb_2 = new ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<User>();
		onkholbldobkeedkpglnlagfiicihjplphpb_3 = new ONKHOLBLDOBKEEDKPGLNLAGFIICIHJPLPHPB<Class4>();
	}
}
