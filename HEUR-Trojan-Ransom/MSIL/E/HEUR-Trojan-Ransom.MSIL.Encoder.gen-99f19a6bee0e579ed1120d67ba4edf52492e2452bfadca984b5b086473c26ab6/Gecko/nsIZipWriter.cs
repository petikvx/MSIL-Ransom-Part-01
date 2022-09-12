using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3ca10750-797e-4a22-bcfe-66170b5e96dd")]
public interface nsIZipWriter
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCommentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aComment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCommentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aComment);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInQueueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open([MarshalAs(UnmanagedType.Interface)] nsIFile aFile, int aIoFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIZipEntry GetEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEntryDirectory([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry, long aModTime, [MarshalAs(UnmanagedType.U1)] bool aQueue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEntryFile([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIFile aFile, [MarshalAs(UnmanagedType.U1)] bool aQueue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEntryChannel([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry, long aModTime, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel, [MarshalAs(UnmanagedType.U1)] bool aQueue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddEntryStream([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry, long aModTime, int aCompression, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.U1)] bool aQueue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveEntry([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aZipEntry, [MarshalAs(UnmanagedType.U1)] bool aQueue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ProcessQueue([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Close();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AlignStoredFiles(ushort aAlignSize);
}
