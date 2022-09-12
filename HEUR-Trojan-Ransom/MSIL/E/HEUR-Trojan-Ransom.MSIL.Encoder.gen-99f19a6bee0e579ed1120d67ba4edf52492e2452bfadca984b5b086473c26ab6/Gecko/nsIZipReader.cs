using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9ba4ef54-e0a0-4f65-9d23-128482448885")]
public interface nsIZipReader
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open([MarshalAs(UnmanagedType.Interface)] nsIFile zipFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenInner([MarshalAs(UnmanagedType.Interface)] nsIZipReader zipReader, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenMemory(IntPtr aData, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Test([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aEntryName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Extract([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry, [MarshalAs(UnmanagedType.Interface)] nsIFile outFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIZipEntry GetEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUTF8StringEnumerator FindEntries([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPattern);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetInputStream([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIInputStream GetInputStreamWithSpec([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aJarSpec, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase zipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIX509Cert GetSigningCert([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aEntryName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetManifestEntriesCountAttribute();
}
