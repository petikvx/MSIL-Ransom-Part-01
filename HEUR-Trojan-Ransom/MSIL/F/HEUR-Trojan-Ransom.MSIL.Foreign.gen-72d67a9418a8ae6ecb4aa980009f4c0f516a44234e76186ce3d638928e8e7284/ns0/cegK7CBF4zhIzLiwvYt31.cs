using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

[ComImport]
[InterfaceType(1)]
[ComConversionLoss]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
public interface cegK7CBF4zhIzLiwvYt31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref rlSG4xr2WGuwTYUslaQ41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] ref rlSG4xr2WGuwTYUslaQ41 pInfo, [In] ref UXVzli9agtqoycp0kXX34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] ref UXVzli9agtqoycp0kXX34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	zP4L0rvSmLm2Buug82g30 EnumTypes([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	zP4L0rvSmLm2Buug82g30 EnumSubtypes([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref GStruct0 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref GStruct0 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	prCHXjGItytfrZYlg5k28 EnumItems([In] ra0UbDlP1S2hIJVuNGA38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In] int dwFlags);
}
