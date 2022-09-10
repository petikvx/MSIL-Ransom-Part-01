using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("314111AB-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxAttributeList
{
	[DispId(70400)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(70400)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(70401)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttribute ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(70402)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxAttribute EnumAttribute([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(70403)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxAttribute Item([In][MarshalAs(UnmanagedType.Struct)] object index);
}
