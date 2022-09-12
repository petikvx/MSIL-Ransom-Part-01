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

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "14.0.0.0")]
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

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class4);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static v8fVhsqTv921vp0mnE smethod_0<v8fVhsqTv921vp0mnE>(v8fVhsqTv921vp0mnE e2w63Mj9Aj65UZyKUP) where v8fVhsqTv921vp0mnE : new()
		{
			if (e2w63Mj9Aj65UZyKUP == null)
			{
				return new v8fVhsqTv921vp0mnE();
			}
			return e2w63Mj9Aj65UZyKUP;
		}

		[DebuggerHidden]
		private void method_1<tds6vsOkaXINJnB7AO>(ref tds6vsOkaXINJnB7AO gparam_0)
		{
			gparam_0 = default(tds6vsOkaXINJnB7AO);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class4()
		{
			Class7.FjOGF5QzEpyy7();
			base._002Ector();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class5<OliKLs6HBVtwMI1DYG> where OliKLs6HBVtwMI1DYG : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static OliKLs6HBVtwMI1DYG gparam_0;

		[SpecialName]
		[DebuggerHidden]
		internal OliKLs6HBVtwMI1DYG method_0()
		{
			if (gparam_0 == null)
			{
				gparam_0 = new OliKLs6HBVtwMI1DYG();
			}
			return gparam_0;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class5()
		{
			Class7.FjOGF5QzEpyy7();
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
	internal static User WyAuOegNu
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
		Class7.FjOGF5QzEpyy7();
		class5_0 = new Class5<Class2>();
		class5_1 = new Class5<Class1>();
		class5_2 = new Class5<User>();
		class5_3 = new Class5<Class4>();
	}
}
