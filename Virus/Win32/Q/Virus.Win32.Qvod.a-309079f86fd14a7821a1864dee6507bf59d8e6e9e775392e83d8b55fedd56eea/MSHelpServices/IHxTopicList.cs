using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411194-A502-11D2-BBCA-00C04F8EC294")]
[DefaultMember("Item")]
[TypeLibType(4288)]
public interface IHxTopicList
{
	[DispId(67586)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(67586)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopic Item([In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67584)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopic ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67585)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxTopic EnumTopics([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();
}
