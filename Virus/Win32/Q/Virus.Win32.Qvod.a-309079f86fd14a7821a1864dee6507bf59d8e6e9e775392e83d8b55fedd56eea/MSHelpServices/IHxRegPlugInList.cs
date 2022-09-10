using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[DefaultMember("Item")]
[Guid("3141120B-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegPlugInList
{
	[DispId(75010)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(75010)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegPlugIn Item([In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75008)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegPlugIn ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75009)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxRegPlugIn EnumRegPlugIn([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();
}
