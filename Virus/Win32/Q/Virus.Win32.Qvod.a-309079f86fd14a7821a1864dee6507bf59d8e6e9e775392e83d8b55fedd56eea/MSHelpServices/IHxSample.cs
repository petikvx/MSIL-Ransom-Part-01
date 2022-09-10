using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("314111E8-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxSample
{
	[DispId(72704)]
	string SampleId
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72704)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(72705)]
	string LoadString
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72705)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(72706)]
	string DestinationDir
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72706)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(72707)]
	string ProjectFileExt
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72707)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(72709)]
	int FileCount
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(72709)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72710)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileNameAtIndex([In] int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72711)]
	void CopyFileAtIndex([In] int index, [In][MarshalAs(UnmanagedType.BStr)] string bstrDest, [In] HxSampleFileCopyOption option);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72713)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string ChooseDirectory([In][MarshalAs(UnmanagedType.BStr)] string bstrDefaultDir, [In][MarshalAs(UnmanagedType.BStr)] string bstrTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(72714)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFileTextAtIndex([In] int index);
}
