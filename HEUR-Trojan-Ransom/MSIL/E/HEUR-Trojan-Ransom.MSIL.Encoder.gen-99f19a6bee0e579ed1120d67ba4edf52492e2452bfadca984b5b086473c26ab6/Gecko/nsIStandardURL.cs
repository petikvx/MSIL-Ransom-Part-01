using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("babd6cca-ebe7-4329-967c-d6b9e33caa81")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIStandardURL : nsIMutable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetMutableAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetMutableAttribute([MarshalAs(UnmanagedType.U1)] bool aMutable);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(uint aUrlType, int aDefaultPort, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
}
