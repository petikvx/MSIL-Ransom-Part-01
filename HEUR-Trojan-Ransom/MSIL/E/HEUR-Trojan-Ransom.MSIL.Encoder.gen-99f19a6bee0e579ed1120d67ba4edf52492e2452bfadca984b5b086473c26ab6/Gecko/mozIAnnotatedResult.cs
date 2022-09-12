using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("81fd0188-db6a-492e-80b6-f6414913b396")]
public interface mozIAnnotatedResult
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetGuidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aGuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetUriAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetItemIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAnnotationNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAnnotationName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetAnnotationValueAttribute();
}
