using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("a592a60e-3621-4f19-a318-2bf233cfad3e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIIDNService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertUTF8toACE([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertACEtoUTF8([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsACE([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase input);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Normalize([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ConvertToDisplayIDN([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase input, [MarshalAs(UnmanagedType.U1)] ref bool isASCII, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
