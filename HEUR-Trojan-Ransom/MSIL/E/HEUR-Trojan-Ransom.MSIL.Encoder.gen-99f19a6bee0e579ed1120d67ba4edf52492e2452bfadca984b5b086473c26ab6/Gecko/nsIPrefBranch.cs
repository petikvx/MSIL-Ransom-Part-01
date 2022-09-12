using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("55d25e49-793f-4727-a69f-de8b15f4b985")]
public interface nsIPrefBranch
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrefType([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.U1)] bool aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetFloatPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.LPStr)] string aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, [MarshalAs(UnmanagedType.Interface)] nsISupports aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void LockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnlockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetChildList([MarshalAs(UnmanagedType.LPStr)] string aStartingAt, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref string[] aChildArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResetBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver, [MarshalAs(UnmanagedType.U1)] bool aHoldWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);
}
