using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9B8B3A33-88D6-3DF3-9D4F-1DB684AA108B")]
[CompilerGenerated]
public interface IpfcParameter
{
	[DispId(1610678273)]
	IpfcUnit Units
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	[return: MarshalAs(UnmanagedType.Interface)]
	IpfcParamValue GetScaledValue();

	void SetScaledValue([In][MarshalAs(UnmanagedType.Interface)] IpfcParamValue _value, [In][MarshalAs(UnmanagedType.Struct)] object _Units);
}
