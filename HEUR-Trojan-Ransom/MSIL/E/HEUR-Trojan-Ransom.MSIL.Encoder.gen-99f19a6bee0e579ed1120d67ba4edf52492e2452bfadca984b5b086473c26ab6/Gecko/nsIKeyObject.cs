using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4b31f4ed-9424-4710-b946-79b7e33cf3a8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIKeyObject
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitKey(short aAlgorithm, IntPtr aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetKeyObj();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new short GetType();
}
