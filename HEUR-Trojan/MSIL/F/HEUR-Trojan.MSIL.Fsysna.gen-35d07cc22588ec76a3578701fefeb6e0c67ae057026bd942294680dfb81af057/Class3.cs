using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
internal sealed class Class3
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class4
	{
		public GForm0 gform0_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class4();

		[SpecialName]
		[DebuggerNonUserCode]
		public extern GForm0 method_0();

		[SpecialName]
		[DebuggerNonUserCode]
		public extern void method_1(GForm0 gform0_1);

		[DebuggerHidden]
		private static extern T smethod_0<T>(T gparam_0) where T : Form, new();

		[DebuggerHidden]
		private extern void method_2<T>(ref T gparam_0) where T : Form;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern bool Equals(object o);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern Type method_3();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern string ToString();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class5
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class5();

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override extern bool Equals(object o);

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal extern Type method_0();

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern string ToString();

		[DebuggerHidden]
		private static extern T smethod_0<T>(T gparam_0) where T : new();

		[DebuggerHidden]
		private extern void method_1<T>(ref T gparam_0);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class6<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern Class6();

		[SpecialName]
		[DebuggerHidden]
		internal extern T method_0();
	}

	private static readonly Class6<Class2> class6_0;

	private static readonly Class6<Class1> class6_1;

	private static readonly Class6<User> class6_2;

	private static Class6<Class4> class6_3;

	private static readonly Class6<Class5> class6_4;

	[SpecialName]
	[DebuggerHidden]
	internal static extern Class2 smethod_0();

	[SpecialName]
	[DebuggerHidden]
	internal static extern Class1 smethod_1();

	[SpecialName]
	[DebuggerHidden]
	internal static extern User smethod_2();

	[SpecialName]
	[DebuggerHidden]
	internal static extern Class4 smethod_3();

	[SpecialName]
	[DebuggerHidden]
	internal static extern Class5 smethod_4();
}
