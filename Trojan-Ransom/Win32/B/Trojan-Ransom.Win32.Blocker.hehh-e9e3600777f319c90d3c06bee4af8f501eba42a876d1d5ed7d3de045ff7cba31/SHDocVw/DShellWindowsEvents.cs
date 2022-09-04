using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4096)]
[InterfaceType(2)]
[Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
public interface DShellWindowsEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(200)]
	void WindowRegistered([In] int lCookie);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(201)]
	void WindowRevoked([In] int lCookie);
}
