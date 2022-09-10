using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F6D1A6A5-A762-3FBF-9184-502D74214BC9")]
public interface IpfcModelDescriptor
{
	[DispId(1610678280)]
	string Device
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(1610678282)]
	string Path
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_8();

	void _VtblGap2_4();

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileName();
}
