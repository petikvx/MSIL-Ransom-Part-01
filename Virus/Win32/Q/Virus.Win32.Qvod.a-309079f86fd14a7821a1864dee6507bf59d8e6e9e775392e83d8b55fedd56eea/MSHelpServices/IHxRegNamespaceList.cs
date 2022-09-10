using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[DefaultMember("Item")]
[TypeLibType(4288)]
[Guid("314111F3-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegNamespaceList
{
	[DispId(73474)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(73474)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegNamespace Item([In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(73472)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegNamespace ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(73473)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxRegNamespace EnumRegNamespace([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();
}
