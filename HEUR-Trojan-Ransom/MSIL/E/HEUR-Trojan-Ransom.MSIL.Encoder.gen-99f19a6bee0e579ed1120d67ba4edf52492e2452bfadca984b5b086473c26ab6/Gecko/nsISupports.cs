using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("00000000-0000-0000-c000-000000000046")]
public interface nsISupports
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr QueryInterface(ref Guid uuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int AddRef();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int Release();
}
