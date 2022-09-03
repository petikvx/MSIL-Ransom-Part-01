using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("3F8C8E9E-9A7A-4DC8-BC41-FF31FA374956")]
[TypeLibType(4288)]
public interface IUPnPServices : IEnumerable
{
	[DispId(1610745809)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610745809)]
		get;
	}

	[DispId(0)]
	UPnPService this[[In][MarshalAs(UnmanagedType.BStr)] string string_0]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	new IEnumerator GetEnumerator();
}
