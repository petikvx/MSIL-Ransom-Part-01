using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace lDcmRA5rlWNq1;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
[ComConversionLoss]
public interface t7bZqy2X31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref KvdzRr3z41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref F1JwaO3a42 pSubtype, [In] ref KvdzRr3z41 pInfo, [In] ref o4ZMy2sE34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref F1JwaO3a42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref F1JwaO3a42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref F1JwaO3a42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] ref F1JwaO3a42 pSubtype, [In] ref o4ZMy2sE34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	BZjpLBbA30 EnumTypes([In] oVAlzfof38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	BZjpLBbA30 EnumSubtypes([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref CRZJBjRs39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref CRZJBjRs39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	gU80fDKA28 EnumItems([In] oVAlzfof38 Key, [In] ref F1JwaO3a42 pItemType, [In] ref F1JwaO3a42 pItemSubtype, [In] int dwFlags);
}
