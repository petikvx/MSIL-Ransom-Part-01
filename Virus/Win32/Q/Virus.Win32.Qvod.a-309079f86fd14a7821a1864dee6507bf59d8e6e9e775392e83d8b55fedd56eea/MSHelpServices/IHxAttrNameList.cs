using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("314111CE-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxAttrNameList
{
	[DispId(71168)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(71168)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71169)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttrName ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71170)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxAttrName EnumAttrName([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(71171)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttrName Item([In][MarshalAs(UnmanagedType.Struct)] object index);
}
