using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("C0BC4B4A-A406-4EFC-932F-B8546B8100CC")]
[TypeLibType(2)]
[ClassInterface(0)]
public class UPnPServicesClass : IEnumerable, IUPnPServices, UPnPServices
{
	[DispId(1610745809)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610745809)]
		get;
	}

	[DispId(0)]
	public virtual extern UPnPService this[[In][MarshalAs(UnmanagedType.BStr)] string string_0]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPServicesClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[TypeLibFunc(65)]
	public virtual extern IEnumerator GetEnumerator();
}
