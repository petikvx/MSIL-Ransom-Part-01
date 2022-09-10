using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111D4-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxAttrValueList
{
	[DispId(71936)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(71936)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71937)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttrValue ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71938)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxAttrValue EnumAttrValue([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71939)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttrValue Item([In][MarshalAs(UnmanagedType.Struct)] object index);
}
