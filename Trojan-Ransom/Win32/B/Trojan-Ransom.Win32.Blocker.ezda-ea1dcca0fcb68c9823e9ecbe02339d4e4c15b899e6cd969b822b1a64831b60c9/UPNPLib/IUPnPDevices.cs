using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("FDBC0C73-BDA3-4C66-AC4F-F2D96FDAD68C")]
[TypeLibType(4288)]
public interface IUPnPDevices : IEnumerable
{
	[DispId(1610747309)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747309)]
		get;
	}

	[DispId(0)]
	UPnPDevice this[[In][MarshalAs(UnmanagedType.BStr)] string string_0]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[TypeLibFunc(65)]
	new IEnumerator GetEnumerator();
}
