using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9840d564-42c8-4d78-9a4d-71002343c918")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIFilePicker
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, short mode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendFilters(int filterMask);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendFilter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultExtensionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultExtensionAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDefaultExtension);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetFilterIndexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFilterIndexAttribute(int aFilterIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDisplayDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDisplayDirectoryAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aDisplayDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetFileURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetFilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetDomfileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetDomfilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAddToRecentDocsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAddToRecentDocsAttribute([MarshalAs(UnmanagedType.U1)] bool aAddToRecentDocs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short Show();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Open([MarshalAs(UnmanagedType.Interface)] nsIFilePickerShownCallback aFilePickerShownCallback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetModeAttribute();
}
