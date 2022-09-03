using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("B9E84FFD-AD3C-40A4-B835-0882EBCBAAA8")]
[ClassInterface(0)]
[TypeLibType(2)]
public class UPnPDevicesClass : IEnumerable, IUPnPDevices, UPnPDevices
{
	[DispId(1610747309)]
	public virtual extern int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747309)]
		get;
	}

	[DispId(0)]
	public virtual extern UPnPDevice this[[In][MarshalAs(UnmanagedType.BStr)] string string_0]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPDevicesClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[TypeLibFunc(65)]
	[DispId(-4)]
	public virtual extern IEnumerator GetEnumerator();
}
