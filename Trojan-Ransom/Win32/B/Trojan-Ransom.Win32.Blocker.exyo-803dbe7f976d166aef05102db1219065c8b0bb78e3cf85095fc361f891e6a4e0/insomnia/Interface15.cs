using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace insomnia;

[ComImport]
[TypeLibType(4288)]
[Guid("A295019C-DC65-47DD-90DC-7FE918A1AB44")]
public interface Interface15
{
	[DispId(1610746311)]
	string Property34
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746311)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610746313)]
	string Property33
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746313)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610746314)]
	int Property32
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610746314)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746309)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Method3([In][MarshalAs(UnmanagedType.BStr)] string A_1);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746310)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object Method2([In][MarshalAs(UnmanagedType.BStr)] string A_1, [In][MarshalAs(UnmanagedType.Struct)] object A_2, [In][Out][MarshalAs(UnmanagedType.Struct)] ref object A_3);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610746312)]
	void Method1([In][MarshalAs(UnmanagedType.IUnknown)] object A_1);
}
