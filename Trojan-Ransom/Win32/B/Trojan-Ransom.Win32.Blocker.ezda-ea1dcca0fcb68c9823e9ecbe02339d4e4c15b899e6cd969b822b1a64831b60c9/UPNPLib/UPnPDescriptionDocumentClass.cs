using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("1D8A9B47-3A28-4CE2-8A4B-BD34E45BCEEB")]
[TypeLibType(2)]
[ClassInterface(0)]
public class UPnPDescriptionDocumentClass : IUPnPHttpHeaderControl, UPnPDescriptionDocument, IUPnPDescriptionDocument
{
	[DispId(-525)]
	public virtual extern int ReadyState
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-525)]
		get;
	}

	[DispId(1610748311)]
	public virtual extern int LoadResult
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610748311)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPDescriptionDocumentClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748309)]
	public virtual extern void Load([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748310)]
	public virtual extern void LoadAsync([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In][MarshalAs(UnmanagedType.IUnknown)] object object_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748312)]
	public virtual extern void Abort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748313)]
	public virtual extern UPnPDevice RootDevice();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610748314)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern UPnPDevice DeviceByUDN([In][MarshalAs(UnmanagedType.BStr)] string string_0);

	[MethodImpl(MethodImplOptions.InternalCall)]
	public virtual extern void AddRequestHeaders([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
