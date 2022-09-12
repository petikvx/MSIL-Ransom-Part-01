using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3d8579f0-75fa-4e00-ba41-38661d5b5d17")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIUrlClassifierPrefixSet
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrefixes([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] aPrefixes, uint aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPrefixes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref uint[] aPrefixes);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool Contains(uint aPrefix);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEmpty();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LoadFromFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void StoreToFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
}
