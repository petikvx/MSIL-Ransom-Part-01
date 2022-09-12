using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f76c0901-437a-11d3-b7a0-e35db351b4bc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDialogParamBlock
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetInt(int inIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInt(int inIndex, int inInt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNumberStrings(int inNumStrings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetString(int inIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetString(int inIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string inString);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIMutableArray GetObjectsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetObjectsAttribute([MarshalAs(UnmanagedType.Interface)] nsIMutableArray aObjects);
}
