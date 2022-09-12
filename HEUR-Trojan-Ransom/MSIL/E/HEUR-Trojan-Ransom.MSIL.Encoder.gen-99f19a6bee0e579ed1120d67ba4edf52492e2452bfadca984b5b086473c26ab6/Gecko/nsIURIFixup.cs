using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1da7e9d4-620b-4949-849a-1cd6077b1b2d")]
public interface nsIURIFixup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI CreateExposableURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI CreateFixupURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIText, uint aFixupFlags, [MarshalAs(UnmanagedType.Interface)] ref nsIInputStream aPostData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURIFixupInfo GetFixupURIInfo([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURIText, uint aFixupFlags, [MarshalAs(UnmanagedType.Interface)] ref nsIInputStream aPostData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURIFixupInfo KeywordToURI([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKeyword, [MarshalAs(UnmanagedType.Interface)] ref nsIInputStream aPostData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDomainWhitelisted([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDomain, uint aDotPos);
}
