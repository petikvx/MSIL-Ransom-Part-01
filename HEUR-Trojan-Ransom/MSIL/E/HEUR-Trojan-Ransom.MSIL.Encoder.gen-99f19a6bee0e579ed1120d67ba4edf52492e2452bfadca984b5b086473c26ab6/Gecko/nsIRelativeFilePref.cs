using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("2f977d4e-5485-11d4-87e2-0010a4e75ef2")]
public interface nsIRelativeFilePref
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFileAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetRelativeToKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRelativeToKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRelativeToKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aRelativeToKey);
}
