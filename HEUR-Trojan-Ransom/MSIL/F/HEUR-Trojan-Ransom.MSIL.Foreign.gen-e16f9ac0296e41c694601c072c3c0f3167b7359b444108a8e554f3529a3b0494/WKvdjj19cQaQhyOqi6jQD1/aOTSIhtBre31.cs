using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WKvdjj19cQaQhyOqi6jQD1;

[ComImport]
[ComConversionLoss]
[InterfaceType(1)]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
public interface aOTSIhtBre31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref CF4HZ9tHoV41 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref TULqFcHlSK42 pSubtype, [In] ref CF4HZ9tHoV41 pInfo, [In] ref gc4sXa9ats34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref TULqFcHlSK42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref TULqFcHlSK42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref TULqFcHlSK42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] ref TULqFcHlSK42 pSubtype, [In] ref gc4sXa9ats34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	rRhdEX5rV730 EnumTypes([In] fjzDyoCrPu38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	rRhdEX5rV730 EnumSubtypes([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref grW0ydR69r39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref grW0ydR69r39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	EV2TYlDZA728 EnumItems([In] fjzDyoCrPu38 Key, [In] ref TULqFcHlSK42 pItemType, [In] ref TULqFcHlSK42 pItemSubtype, [In] int dwFlags);
}