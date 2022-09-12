using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("53f4bc4a-5b86-4643-8e67-4907ecbab34c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIShellService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aStartupCheck, [MarshalAs(UnmanagedType.U1)] bool aForAllTypes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aClaimAllTypes, [MarshalAs(UnmanagedType.U1)] bool aForAllUsers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShouldCheckDefaultBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShouldCheckDefaultBrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aShouldCheckDefaultBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCanSetDesktopBackgroundAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDesktopBackground([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenApplication(int aApplication);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetDesktopBackgroundColorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDesktopBackgroundColorAttribute(uint aDesktopBackgroundColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenApplicationWithURI([MarshalAs(UnmanagedType.Interface)] nsIFile aApplication, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetDefaultFeedReaderAttribute();
}
