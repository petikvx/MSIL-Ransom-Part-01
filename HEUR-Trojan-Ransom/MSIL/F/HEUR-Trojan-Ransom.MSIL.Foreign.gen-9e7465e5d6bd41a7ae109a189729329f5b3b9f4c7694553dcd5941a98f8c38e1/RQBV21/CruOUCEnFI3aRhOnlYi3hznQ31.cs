using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RQBV21;

[ComImport]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
[InterfaceType(1)]
[ComConversionLoss]
public interface CruOUCEnFI3aRhOnlYi3hznQ31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref GStruct2 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pSubtype, [In] ref GStruct2 pInfo, [In] ref GStruct1 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pSubtype, [In] ref GStruct1 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	dHu9THhS9K9mI79r1ot66ple30 EnumTypes([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	dHu9THhS9K9mI79r1ot66ple30 EnumSubtypes([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref M1oZK26mATZcglBzs2pdLZul39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref M1oZK26mATZcglBzs2pdLZul39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	lWEmO3o1Ns6yJXRaGxwsYsNT28 EnumItems([In] UHGsp2wc0sXgQjVNOIBBJqSG38 Key, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemType, [In] ref ArQbjx1DfqTjkrs95SQBTuPg42 pItemSubtype, [In] int dwFlags);
}
