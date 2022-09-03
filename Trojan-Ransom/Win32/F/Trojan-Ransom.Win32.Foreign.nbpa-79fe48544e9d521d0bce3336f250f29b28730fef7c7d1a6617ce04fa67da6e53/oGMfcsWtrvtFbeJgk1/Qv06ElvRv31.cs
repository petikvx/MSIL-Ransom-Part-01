using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace oGMfcsWtrvtFbeJgk1;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[ComConversionLoss]
[InterfaceType(1)]
public interface Qv06ElvRv31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref zQYV8FAGn41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref EHBABUqog42 pSubtype, [In] ref zQYV8FAGn41 pInfo, [In] ref GStruct0 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref EHBABUqog42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref EHBABUqog42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref EHBABUqog42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] ref EHBABUqog42 pSubtype, [In] ref GStruct0 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	UFGzSxgbL30 EnumTypes([In] GpZc5murp38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	UFGzSxgbL30 EnumSubtypes([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref zjt5ZbrxS39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref zjt5ZbrxS39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	MHwu6TdAL28 EnumItems([In] GpZc5murp38 Key, [In] ref EHBABUqog42 pItemType, [In] ref EHBABUqog42 pItemSubtype, [In] int dwFlags);
}
