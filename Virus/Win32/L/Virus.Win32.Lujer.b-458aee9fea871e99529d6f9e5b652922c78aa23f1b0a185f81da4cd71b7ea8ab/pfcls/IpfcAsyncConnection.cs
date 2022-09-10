using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D6FF3ADF-A7E3-3DD9-8426-F2C745518457")]
[CompilerGenerated]
[TypeIdentifier]
public interface IpfcAsyncConnection
{
	[DispId(1610678272)]
	IpfcSession Session
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	void Disconnect([In][MarshalAs(UnmanagedType.Struct)] object _TimeoutSec);

	void _VtblGap2_3();

	bool IsRunning();
}
