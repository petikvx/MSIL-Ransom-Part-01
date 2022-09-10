using System;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("D5F569D0-593B-101A-B569-08002B2DBF7A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IPSFactoryBuffer
{
	void CreateProxy(IntPtr inner, [In][MarshalAs(UnmanagedType.LPStruct)] Guid riid, out object proxy, out object ppv);

	void CreateStub();
}
