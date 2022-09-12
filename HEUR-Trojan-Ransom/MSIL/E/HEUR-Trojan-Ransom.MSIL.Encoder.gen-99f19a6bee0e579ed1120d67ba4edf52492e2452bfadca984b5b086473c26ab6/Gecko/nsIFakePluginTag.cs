using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("6d22c968-226d-4156-b230-da6ad6bbf6e8")]
public interface nsIFakePluginTag : nsIPluginTag
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetDescriptionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFilenameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFullpathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFullpath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aVersion);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNiceNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNiceName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetBlocklistedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetIsEnabledStateLockedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetActiveAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetBlocklistStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetDisabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetClicktoplayAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetEnabledStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetEnabledStateAttribute(uint aEnabledState);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetMimeTypes(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetMimeDescriptions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetExtensions(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResults);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetHandlerURIAttribute();
}
