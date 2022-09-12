using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("83b6019c-cbc4-11d2-8cca-0060b0fc14a3")]
public interface nsICollection : nsISerializable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetElementAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr QueryElementAt(uint index, ref Guid uuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetElementAt(uint index, [MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendElement([MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveElement([MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEnumerator Enumerate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clear();
}
