using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns2;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
[ComConversionLoss]
public interface GInterface3
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] Enum1 Key, [In] ref Guid pType, [In] ref Struct20 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] Enum1 Key, [In] ref Guid pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] Enum1 Key, [In] ref Guid pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] Enum1 Key, [In] ref Guid pType, [In] ref Guid pSubtype, [In] ref Struct20 pInfo, [In] ref Struct18 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] Enum1 Key, [In] ref Guid pType, [In] ref Guid pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] Enum1 Key, [In] ref Guid pType, [In] ref Guid pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] Enum1 Key, [In] ref Guid pType, [In] ref Guid pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] Enum1 Key, [In] ref Guid pType, [In] ref Guid pSubtype, [In] ref Struct18 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface2 EnumTypes([In] Enum1 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface2 EnumSubtypes([In] Enum1 Key, [In] ref Guid pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref IntPtr ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref Struct19 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref Struct19 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface0 EnumItems([In] Enum1 Key, [In] ref Guid pItemType, [In] ref Guid pItemSubtype, [In] int dwFlags);
}
