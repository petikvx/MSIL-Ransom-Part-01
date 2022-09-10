using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411212-A502-11D2-BBCA-00C04F8EC294")]
[DefaultMember("Item")]
public interface IHxRegFilterList
{
	[DispId(75778)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(75778)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(0)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegFilter Item([In][MarshalAs(UnmanagedType.Struct)] object index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75776)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegFilter ItemAt([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75777)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IEnumHxRegFilter EnumRegFilter([In] int filter, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(-4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "")]
	IEnumerator GetEnumerator();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75779)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegFilter FindFilter([In][MarshalAs(UnmanagedType.BStr)] string bstrFilterName);
}
