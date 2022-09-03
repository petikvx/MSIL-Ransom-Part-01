using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace vamZuJ921;

[ComImport]
[ComConversionLoss]
[InterfaceType(1)]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
public interface AcJLyiDtOLhNkvVSAYOerJUX31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref U2mr2NrNDtIRG5pOQdIdn4Cr41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pSubtype, [In] ref U2mr2NrNDtIRG5pOQdIdn4Cr41 pInfo, [In] ref RmI1kYNLCWeWawqxOib5NYqm34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pSubtype, [In] ref RmI1kYNLCWeWawqxOib5NYqm34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	YvKIGBPEJaSeHrw7QaVVPa6G30 EnumTypes([In] GEnum1 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	YvKIGBPEJaSeHrw7QaVVPa6G30 EnumSubtypes([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref VRcqmzutYeg5gWNcm2XeB8eI39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref VRcqmzutYeg5gWNcm2XeB8eI39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	KaqgvGHQc4MpltIv0xO9M5qg28 EnumItems([In] GEnum1 Key, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemType, [In] ref N2SNJDzncUu1NXZzBL66bnff42 pItemSubtype, [In] int dwFlags);
}
