using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("8892016d-07f7-4530-b5c1-d73dfcde4a1c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrefBranch2 : nsIPrefBranch
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	new string GetRootAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetPrefType([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.U1)] bool aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new float GetFloatPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	new string GetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.LPStr)] string aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, [MarshalAs(UnmanagedType.Interface)] nsISupports aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void LockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void UnlockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetChildList([MarshalAs(UnmanagedType.LPStr)] string aStartingAt, ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref string[] aChildArray);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ResetBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void AddObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver, [MarshalAs(UnmanagedType.U1)] bool aHoldWeak);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveObserver([MarshalAs(UnmanagedType.LPStr)] string aDomain, [MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);
}
