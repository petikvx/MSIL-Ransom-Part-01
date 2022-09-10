using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[CompilerGenerated]
[Guid("F266A38C-E52D-3BC0-A2EE-BE40392507EE")]
public interface IpfcModel
{
	[DispId(1610678272)]
	IpfcModelDescriptor Descr
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_23();

	void Display();
}
