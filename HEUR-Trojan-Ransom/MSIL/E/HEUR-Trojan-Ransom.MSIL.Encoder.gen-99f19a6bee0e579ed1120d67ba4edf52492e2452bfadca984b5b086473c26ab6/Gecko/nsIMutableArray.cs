using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("af059da0-c85b-40ec-af07-ae4bfdc192cc")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMutableArray : nsIArray
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr QueryElementAt(uint index, ref Guid uuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint IndexOf(uint startIndex, [MarshalAs(UnmanagedType.Interface)] nsISupports element);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISimpleEnumerator Enumerate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendElement([MarshalAs(UnmanagedType.Interface)] nsISupports element, [MarshalAs(UnmanagedType.U1)] bool weak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveElementAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertElementAt([MarshalAs(UnmanagedType.Interface)] nsISupports element, uint index, [MarshalAs(UnmanagedType.U1)] bool weak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReplaceElementAt([MarshalAs(UnmanagedType.Interface)] nsISupports element, uint index, [MarshalAs(UnmanagedType.U1)] bool weak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clear();
}
