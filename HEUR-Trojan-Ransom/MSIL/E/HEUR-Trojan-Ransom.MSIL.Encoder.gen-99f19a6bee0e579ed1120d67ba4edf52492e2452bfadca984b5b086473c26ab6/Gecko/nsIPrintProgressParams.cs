using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("CA89B55B-6FAF-4051-9645-1C03EF5108F8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintProgressParams
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDocTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDocTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDocURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDocURL);
}
