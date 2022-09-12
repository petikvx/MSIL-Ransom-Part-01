using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("07b6b2f5-6d97-47b4-9584-e65bc467fe9e")]
public interface mozIStorageService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenAsyncDatabase([MarshalAs(UnmanagedType.Interface)] nsIVariant aDatabaseStore, [MarshalAs(UnmanagedType.Interface)] nsIPropertyBag2 aOptions, mozIStorageCompletionCallback aCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection OpenSpecialDatabase([MarshalAs(UnmanagedType.LPStr)] string aStorageKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection OpenDatabase([MarshalAs(UnmanagedType.Interface)] nsIFile aDatabaseFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection OpenUnsharedDatabase([MarshalAs(UnmanagedType.Interface)] nsIFile aDatabaseFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	mozIStorageConnection OpenDatabaseWithFileURL([MarshalAs(UnmanagedType.Interface)] nsIFileURL aFileURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile BackupDatabaseFile([MarshalAs(UnmanagedType.Interface)] nsIFile aDBFile, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aBackupFileName, [MarshalAs(UnmanagedType.Interface)] nsIFile aBackupParentDirectory);
}
