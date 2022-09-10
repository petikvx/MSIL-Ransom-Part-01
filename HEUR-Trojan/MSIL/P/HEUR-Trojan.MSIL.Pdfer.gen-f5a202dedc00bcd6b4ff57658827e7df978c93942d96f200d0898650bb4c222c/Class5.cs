using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication2;

[GeneratedCode("MyTemplate", "10.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Class5
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class6
	{
		public AboutBox1 aboutBox1_0;

		public GForm0 gform0_0;

		public GForm1 gform1_0;

		[ThreadStatic]
		private static Hashtable hashtable_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern Class6();

		[SpecialName]
		public extern AboutBox1 method_0();

		[SpecialName]
		public extern GForm0 method_1();

		[SpecialName]
		public extern GForm1 method_2();

		[SpecialName]
		public extern void method_3(AboutBox1 aboutBox1_1);

		[SpecialName]
		public extern void method_4(GForm0 gform0_1);

		[SpecialName]
		public extern void method_5(GForm1 gform1_1);

		private static extern T smethod_0<T>(T gparam_0) where T : new();

		private extern void method_6<T>(ref T gparam_0);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern bool Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern Type method_7();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern string ToString();
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class7
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern Class7();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern bool Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern int GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal extern Type method_0();

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override extern string ToString();

		private static extern T smethod_0<T>(T gparam_0) where T : new();

		private extern void method_1<T>(ref T gparam_0);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class8<T> where T : new()
	{
		[ThreadStatic]
		private static T gparam_0;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public extern Class8();

		[SpecialName]
		internal extern T method_0();
	}

	private static readonly Class8<Class4> class8_0;

	private static readonly Class8<Class3> class8_1;

	private static readonly Class8<User> class8_2;

	private static Class8<Class6> class8_3;

	private static readonly Class8<Class7> class8_4;

	internal static extern Class4 Class4_0 { get; }

	internal static extern Class3 Class3_0 { get; }

	internal static extern User User_0 { get; }

	internal static extern Class6 Class6_0 { get; }

	internal static extern Class7 Class7_0 { get; }
}
