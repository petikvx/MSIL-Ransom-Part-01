using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0;

[ComImport]
[InterfaceType(1)]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[ComConversionLoss]
public interface MujwtrQVjzgg7Dglnv31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref cQ7tCf0msTivxZPt2841 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref tAS0h4aRlkCM52XPTX42 pSubtype, [In] ref cQ7tCf0msTivxZPt2841 pInfo, [In] ref u249pAIVR0eSzJjCPc34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref tAS0h4aRlkCM52XPTX42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref tAS0h4aRlkCM52XPTX42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref tAS0h4aRlkCM52XPTX42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] ref tAS0h4aRlkCM52XPTX42 pSubtype, [In] ref u249pAIVR0eSzJjCPc34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	HqpGuhPn9LV8LNT3Nt30 EnumTypes([In] qasCJO7PUltL5D8ioP38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	HqpGuhPn9LV8LNT3Nt30 EnumSubtypes([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref GStruct0 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref GStruct0 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	JRM76TKpNIKZJob4W328 EnumItems([In] qasCJO7PUltL5D8ioP38 Key, [In] ref tAS0h4aRlkCM52XPTX42 pItemType, [In] ref tAS0h4aRlkCM52XPTX42 pItemSubtype, [In] int dwFlags);
}
