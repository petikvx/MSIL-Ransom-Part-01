using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5daa99d5-265a-4397-b429-c943803e2619")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPluginTag
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFullpathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFullpath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNiceNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNiceName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBlocklistedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsEnabledStateLockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetBlocklistStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetClicktoplayAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetEnabledStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEnabledStateAttribute(uint aEnabledState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMimeTypes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMimeDescriptions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetExtensions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);
}
