using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[Guid("4EF6100A-AF88-11D0-9846-00C04FC29993")]
[InterfaceType(2)]
[TypeLibType(4112)]
public interface FontEvents
{
	[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
	[DispId(9)]
	void FontChanged([In][MarshalAs(UnmanagedType.BStr)] string PropertyName);
}
