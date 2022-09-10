using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[DefaultMember("Item")]
[Guid("31411203-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegTitleList
{
	[DispId(74242)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(74242)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegTitle Item([In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(74240)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegTitle ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(74241)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxRegTitle EnumRegTitle([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();
}
