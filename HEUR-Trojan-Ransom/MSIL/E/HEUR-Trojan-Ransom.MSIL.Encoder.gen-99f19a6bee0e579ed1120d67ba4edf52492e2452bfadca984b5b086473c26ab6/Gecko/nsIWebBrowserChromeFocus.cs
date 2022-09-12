using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("947B2EE6-51ED-4C2B-9F45-426C27CA84C6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIWebBrowserChromeFocus
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void FocusNextElement([MarshalAs(UnmanagedType.U1)] bool aForDocumentNavigation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FocusPrevElement([MarshalAs(UnmanagedType.U1)] bool aForDocumentNavigation);
}
