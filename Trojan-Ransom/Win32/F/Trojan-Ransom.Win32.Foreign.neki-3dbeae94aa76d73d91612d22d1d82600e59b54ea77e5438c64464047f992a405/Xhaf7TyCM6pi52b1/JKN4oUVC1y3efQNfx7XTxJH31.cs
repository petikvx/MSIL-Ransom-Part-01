using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Xhaf7TyCM6pi52b1;

[ComImport]
[ComConversionLoss]
[InterfaceType(1)]
[Guid("5A6F1EC0-2DB1-11D0-8C39-00C04FD9126B")]
public interface JKN4oUVC1y3efQNfx7XTxJH31
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetInfo([In][Out] IntPtr ppProperties);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetProvParam([In] int dwParam, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProvParam([In] int dwParam, [In] int cbData, [In] int pbData, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateType([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref GStruct1 pInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTypeInfo([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteType([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateSubtype([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pSubtype, [In] ref GStruct1 pInfo, [In] ref d4TEEM1RFIdoY9w5CpshfxB34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSubtypeInfo([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pSubtype, [In][Out] ref int ppInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteSubtype([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pSubtype, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadAccessRuleset([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pSubtype, [In][Out] ref int ppRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteAccessRuleset([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pSubtype, [In] ref d4TEEM1RFIdoY9w5CpshfxB34 pRules, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IU0kYJQc29TAzDCidUVG9zA30 EnumTypes([In] GEnum1 Key, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IU0kYJQc29TAzDCidUVG9zA30 EnumSubtypes([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pType, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteItem([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReadItem([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In][Out] ref int pcbData, [In][Out] ref int ppbData, [In] int pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteItem([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int cbData, [In] int pbData, [In] ref yLG4Dc8usPOB9IbvOxEjVec39 pPromptInfo, [In] int dwDefaultConfirmationStyle, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OpenItem([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int ModeFlags, [In] ref yLG4Dc8usPOB9IbvOxEjVec39 pPromptInfo, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CloseItem([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In][MarshalAs(UnmanagedType.LPWStr)] string szItemName, [In] int dwFlags);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	Sj1nzN9l8cEjvhm2AkLEHIq28 EnumItems([In] GEnum1 Key, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemType, [In] ref SAvYx91r2YtNjgGhe2WHZJd42 pItemSubtype, [In] int dwFlags);
}
