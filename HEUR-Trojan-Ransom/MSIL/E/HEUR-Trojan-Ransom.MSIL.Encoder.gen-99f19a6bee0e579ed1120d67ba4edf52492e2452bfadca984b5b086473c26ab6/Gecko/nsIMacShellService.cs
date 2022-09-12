using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("291a27cd-ef4c-46c6-a2f8-83182498167e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMacShellService : nsIShellService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aStartupCheck, [MarshalAs(UnmanagedType.U1)] bool aForAllTypes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aClaimAllTypes, [MarshalAs(UnmanagedType.U1)] bool aForAllUsers);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetShouldCheckDefaultBrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetShouldCheckDefaultBrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aShouldCheckDefaultBrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetCanSetDesktopBackgroundAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDesktopBackground([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aPosition);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OpenApplication(int aApplication);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetDesktopBackgroundColorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetDesktopBackgroundColorAttribute(uint aDesktopBackgroundColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void OpenApplicationWithURI([MarshalAs(UnmanagedType.Interface)] nsIFile aApplication, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile GetDefaultFeedReaderAttribute();
}
