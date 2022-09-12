using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("48d7f7fd-bb85-4c04-9b8b-5cd9131acdef")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMCrypto
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(IntPtr parent);
}
