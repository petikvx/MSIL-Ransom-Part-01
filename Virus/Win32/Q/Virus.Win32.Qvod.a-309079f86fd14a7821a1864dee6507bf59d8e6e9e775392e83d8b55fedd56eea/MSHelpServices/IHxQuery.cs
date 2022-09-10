using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411193-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxQuery
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67328)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopicList Query([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In] HxQuery_Options options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67329)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopic QueryForTopic([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In] HxQuery_Options options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67330)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string QueryForUrl([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In] HxQuery_Options options);
}
