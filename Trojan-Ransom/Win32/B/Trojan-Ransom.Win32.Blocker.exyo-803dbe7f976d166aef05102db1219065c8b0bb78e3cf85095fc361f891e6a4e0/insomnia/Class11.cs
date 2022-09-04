using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[Guid("C624BA95-FBCB-4409-8C03-8CCEEC533EF1")]
[ClassInterface(0)]
[TypeLibType(2)]
public class Class11 : Interface15, Interface22
{
	[DispId(1610746311)]
	virtual extern string Interface15.Property34
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746311)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610746313)]
	virtual extern string Interface15.Property33
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746313)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610746314)]
	virtual extern int Interface15.Property32
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746314)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern Class11();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746309)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object Method3([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746310)]
	[return: MarshalAs(UnmanagedType.Struct)]
	public virtual extern object Method2([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In][MarshalAs(UnmanagedType.Struct)] object A_2, [In][Out][MarshalAs(UnmanagedType.Struct)] ref object A_3);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746312)]
	public virtual extern void Method1([In][MarshalAs(UnmanagedType.IUnknown)] object A_1);
}
