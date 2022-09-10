using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("00000100-0000-0000-C000-000000000046")]
internal interface IEnumUnknown
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In][MarshalAs(UnmanagedType.U4)] int elementArrayLength, [Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown, SizeParamIndex = 0)] object[] elementArray, [MarshalAs(UnmanagedType.U4)] out int fetchedElementCount);

	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Skip([In][MarshalAs(UnmanagedType.U4)] int count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumUnknown enumerator);
}
