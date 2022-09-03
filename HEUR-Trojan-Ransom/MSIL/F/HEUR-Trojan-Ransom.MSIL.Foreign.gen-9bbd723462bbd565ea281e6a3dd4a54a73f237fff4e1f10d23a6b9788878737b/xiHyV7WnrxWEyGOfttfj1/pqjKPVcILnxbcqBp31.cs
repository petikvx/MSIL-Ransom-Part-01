using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace xiHyV7WnrxWEyGOfttfj1;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[ComConversionLoss]
[InterfaceType(1)]
public interface pqjKPVcILnxbcqBp31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref Y3KeIhV2oJiOt71B41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref bOFo2EsXSrx3VACW42 pSubtype, [In] ref Y3KeIhV2oJiOt71B41 pInfo, [In] ref GStruct0 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref bOFo2EsXSrx3VACW42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref bOFo2EsXSrx3VACW42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref bOFo2EsXSrx3VACW42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] ref bOFo2EsXSrx3VACW42 pSubtype, [In] ref GStruct0 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ELriwRQfFDp6x0ts30 EnumTypes([In] NJ72wixG1BaLDa5v38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ELriwRQfFDp6x0ts30 EnumSubtypes([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref g4RwCKkoKHOpFqpl39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref g4RwCKkoKHOpFqpl39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	PEnEuKAe27J18LRy28 EnumItems([In] NJ72wixG1BaLDa5v38 Key, [In] ref bOFo2EsXSrx3VACW42 pItemType, [In] ref bOFo2EsXSrx3VACW42 pItemSubtype, [In] int dwFlags);
}
