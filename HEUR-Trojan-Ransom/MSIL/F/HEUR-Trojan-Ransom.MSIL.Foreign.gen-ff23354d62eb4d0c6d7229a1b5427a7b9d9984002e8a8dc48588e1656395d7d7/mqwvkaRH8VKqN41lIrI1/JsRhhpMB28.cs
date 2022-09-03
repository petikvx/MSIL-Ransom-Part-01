using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mqwvkaRH8VKqN41lIrI1;

[ComImport]
[InterfaceType(1)]
[Guid("5A6F1EC1-2DB1-11D0-8C39-00C04FD9126B")]
public interface JsRhhpMB28
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	int Next([In] int celt, [In][Out] ref int rgelt, [In][Out] ref int pceltFetched);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Skip([In] int celt);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Reset();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	JsRhhpMB28 Clone();
}
