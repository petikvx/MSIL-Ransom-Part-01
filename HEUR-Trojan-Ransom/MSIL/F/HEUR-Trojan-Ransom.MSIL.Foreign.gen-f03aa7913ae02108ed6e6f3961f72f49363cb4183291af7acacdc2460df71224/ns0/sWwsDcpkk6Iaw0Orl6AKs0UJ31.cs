using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
[ComConversionLoss]
public interface sWwsDcpkk6Iaw0Orl6AKs0UJ31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref tOSEeg58JwUWshcCDYQLfi3j41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] ref tOSEeg58JwUWshcCDYQLfi3j41 pInfo, [In] ref AyACWr7IkYzKNUNef9Zk1JwC34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] ref GStruct1 pSubtype, [In] ref AyACWr7IkYzKNUNef9Zk1JwC34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface1 EnumTypes([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface1 EnumSubtypes([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref oReTcbhaXxvZ6KbGezdStg7H39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref oReTcbhaXxvZ6KbGezdStg7H39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	HTXdCLa05PSjOohEYRrAkxEo28 EnumItems([In] ZhTTKRNLR9BpkyA2jFu6ds8y38 Key, [In] ref GStruct1 pItemType, [In] ref GStruct1 pItemSubtype, [In] int dwFlags);
}
