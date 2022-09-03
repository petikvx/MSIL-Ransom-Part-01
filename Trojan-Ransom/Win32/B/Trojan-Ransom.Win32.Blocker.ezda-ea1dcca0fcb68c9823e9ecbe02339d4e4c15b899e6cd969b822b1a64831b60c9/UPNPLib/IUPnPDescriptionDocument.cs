using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[TypeLibType(4288)]
[Guid("11D1C1B2-7DAA-4C9E-9595-7F82ED206D1E")]
public interface IUPnPDescriptionDocument
{
	[DispId(-525)]
	int ReadyState
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		get;
	}

	[DispId(1610748311)]
	int LoadResult
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610748311)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748309)]
	void Load([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748310)]
	void LoadAsync([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In][MarshalAs(UnmanagedType.IUnknown)] object object_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748312)]
	void Abort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748313)]
	UPnPDevice RootDevice();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748314)]
	[return: MarshalAs(UnmanagedType.Interface)]
	UPnPDevice DeviceByUDN([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
