using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("31179807-9fcd-46c4-befa-2ade209a394b")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIZipReaderCache
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint cacheSize);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIZipReader GetZip([MarshalAs(UnmanagedType.Interface)] nsIFile zipFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCached([MarshalAs(UnmanagedType.Interface)] nsIFile zipFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIZipReader GetInnerZip([MarshalAs(UnmanagedType.Interface)] nsIFile zipFile, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetFd([MarshalAs(UnmanagedType.Interface)] nsIFile zipFile);
}
