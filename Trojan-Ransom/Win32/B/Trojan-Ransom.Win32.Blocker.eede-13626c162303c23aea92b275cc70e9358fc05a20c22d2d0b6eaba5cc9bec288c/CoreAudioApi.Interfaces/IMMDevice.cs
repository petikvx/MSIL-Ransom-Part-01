using System;
using System.Runtime.InteropServices;

namespace CoreAudioApi.Interfaces;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D666063F-1587-4E43-81F1-B948E807363F")]
internal interface IMMDevice
{
	[PreserveSig]
	int Activate(ref Guid iid, CLSCTX dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);

	[PreserveSig]
	int OpenPropertyStore(EStgmAccess stgmAccess, out IPropertyStore propertyStore);

	[PreserveSig]
	int GetId([MarshalAs(UnmanagedType.LPWStr)] out string ppstrId);

	[PreserveSig]
	int GetState(out EDeviceState pdwState);
}
