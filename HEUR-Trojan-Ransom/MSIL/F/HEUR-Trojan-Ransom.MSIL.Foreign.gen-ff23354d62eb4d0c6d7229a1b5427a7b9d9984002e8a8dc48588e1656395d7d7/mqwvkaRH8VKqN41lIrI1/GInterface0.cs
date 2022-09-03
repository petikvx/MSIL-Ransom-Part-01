using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mqwvkaRH8VKqN41lIrI1;

[ComImport]
[ComConversionLoss]
[InterfaceType(1)]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
public interface GInterface0
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref dcuLqsk241 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref tBwDhG5Z42 pSubtype, [In] ref dcuLqsk241 pInfo, [In] ref VmS3S2yt34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref tBwDhG5Z42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref tBwDhG5Z42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref tBwDhG5Z42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] ref tBwDhG5Z42 pSubtype, [In] ref VmS3S2yt34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface1 EnumTypes([In] m5hhGQrO38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface1 EnumSubtypes([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref VrCaatwg39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref VrCaatwg39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	JsRhhpMB28 EnumItems([In] m5hhGQrO38 Key, [In] ref tBwDhG5Z42 pItemType, [In] ref tBwDhG5Z42 pItemSubtype, [In] int dwFlags);
}
