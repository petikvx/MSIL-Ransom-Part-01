using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("acf2a516-7d7f-4771-8b22-6c4a559c088e")]
public interface nsIHelperAppLauncher : nsICancelable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Cancel(int aReason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMIMEInfo GetMIMEInfoAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSuggestedFileNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSuggestedFileName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveToDisk([MarshalAs(UnmanagedType.Interface)] nsIFile aNewFileLocation, [MarshalAs(UnmanagedType.U1)] bool aRememberThisPreference);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LaunchWithApplication([MarshalAs(UnmanagedType.Interface)] nsIFile aApplication, [MarshalAs(UnmanagedType.U1)] bool aRememberThisPreference);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SaveDestinationAvailable([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWebProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener2 aWebProgressListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetTargetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetTargetFileIsExecutableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetTimeDownloadStartedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetContentLengthAttribute();
}
