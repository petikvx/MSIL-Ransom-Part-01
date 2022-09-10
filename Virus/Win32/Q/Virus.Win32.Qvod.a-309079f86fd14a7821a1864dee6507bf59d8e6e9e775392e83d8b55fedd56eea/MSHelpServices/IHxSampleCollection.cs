using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111E6-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxSampleCollection
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72448)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxSample GetSampleFromId([In][MarshalAs(UnmanagedType.BStr)] string bstrTopicUrl, [In][MarshalAs(UnmanagedType.BStr)] string bstrId, [In][MarshalAs(UnmanagedType.BStr)] string bstrSFLName);
}
