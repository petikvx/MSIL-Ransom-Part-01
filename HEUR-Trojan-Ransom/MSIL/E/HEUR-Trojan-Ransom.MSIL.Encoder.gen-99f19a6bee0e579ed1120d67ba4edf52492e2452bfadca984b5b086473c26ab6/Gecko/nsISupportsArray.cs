using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("241addc8-3608-4e73-8083-2fd6fa09eba2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISupportsArray : nsICollection, nsISerializable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Read([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aInputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Write([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aOutputStream);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetElementAt(uint index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr QueryElementAt(uint index, ref Guid uuid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetElementAt(uint index, [MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AppendElement([MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveElement([MarshalAs(UnmanagedType.Interface)] nsISupports item);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIEnumerator Enumerate();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Clear();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Equals([MarshalAs(UnmanagedType.Interface)] nsISupportsArray other);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int IndexOf([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int IndexOfStartingAt([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement, uint aStartIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int LastIndexOf([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOf([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfStartingAt([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement, uint aStartIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLastIndexOf([MarshalAs(UnmanagedType.Interface)] nsISupports aPossibleElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool InsertElementAt([MarshalAs(UnmanagedType.Interface)] nsISupports aElement, uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ReplaceElementAt([MarshalAs(UnmanagedType.Interface)] nsISupports aElement, uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool RemoveElementAt(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool RemoveLastElement([MarshalAs(UnmanagedType.Interface)] nsISupports aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteLastElement([MarshalAs(UnmanagedType.Interface)] nsISupports aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteElementAt(uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool AppendElements([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aElements);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Compact();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool MoveElement(int aFrom, int aTo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool InsertElementsAt([MarshalAs(UnmanagedType.Interface)] nsISupportsArray aOther, uint aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool RemoveElementsAt(uint aIndex, uint aCount);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SizeTo(int aSize);
}
