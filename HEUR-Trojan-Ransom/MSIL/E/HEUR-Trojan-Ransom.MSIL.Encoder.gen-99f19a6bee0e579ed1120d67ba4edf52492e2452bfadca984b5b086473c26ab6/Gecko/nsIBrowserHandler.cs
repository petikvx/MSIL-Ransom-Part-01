using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8D3F5A9D-118D-4548-A137-CF7718679069")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIBrowserHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetStartPageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aStartPage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartPageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aStartPage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultArgsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDefaultArgs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultArgsAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDefaultArgs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFeatures([MarshalAs(UnmanagedType.Interface)] nsICommandLine aCmdLine, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
