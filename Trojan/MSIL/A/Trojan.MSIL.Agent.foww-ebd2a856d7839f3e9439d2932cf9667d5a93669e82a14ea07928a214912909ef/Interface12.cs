using System.Runtime.InteropServices;

[ComImport]
[Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface Interface12
{
	int FilterCollection
	{
		[PreserveSig]
		get;
	}

	int RegFilterCollection
	{
		[PreserveSig]
		get;
	}

	[PreserveSig]
	int Run();

	[PreserveSig]
	int Pause();

	[PreserveSig]
	int Stop();

	[PreserveSig]
	int GetState(int timeout, out int filterState);

	[PreserveSig]
	int RenderFile(string fileName);

	[PreserveSig]
	int AddSourceFilter([In] string fileName, [MarshalAs(UnmanagedType.IDispatch)] out object filterInfo);

	[PreserveSig]
	int StopWhenReady();
}
