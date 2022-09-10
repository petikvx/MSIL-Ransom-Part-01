using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4096)]
[InterfaceType(2)]
[Guid("31411223-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegisterSessionEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(75271)]
	void FiltersChanged([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object pvar);
}
