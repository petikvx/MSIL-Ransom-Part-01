using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[ClassInterface(0)]
[Guid("A32552C5-BA61-457A-B59A-A2561E125E33")]
[TypeLibType(2)]
public class UPnPDeviceClass : IUPnPDevice, UPnPDevice
{
	[DispId(1610747809)]
	public virtual extern bool IsRootDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747809)]
		get;
	}

	[DispId(1610747810)]
	public virtual extern UPnPDevice RootDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747810)]
		get;
	}

	[DispId(1610747811)]
	public virtual extern UPnPDevice ParentDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747811)]
		get;
	}

	[DispId(1610747812)]
	public virtual extern bool HasChildren
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747812)]
		get;
	}

	[DispId(1610747813)]
	public virtual extern UPnPDevices Children
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747813)]
		get;
	}

	[DispId(1610747814)]
	public virtual extern string UniqueDeviceName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747814)]
		get;
	}

	[DispId(1610747815)]
	public virtual extern string FriendlyName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747815)]
		get;
	}

	[DispId(1610747816)]
	public virtual extern string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747816)]
		get;
	}

	[DispId(1610747817)]
	public virtual extern string PresentationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747817)]
		get;
	}

	[DispId(1610747818)]
	public virtual extern string ManufacturerName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747818)]
		get;
	}

	[DispId(1610747819)]
	public virtual extern string ManufacturerURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747819)]
		get;
	}

	[DispId(1610747820)]
	public virtual extern string ModelName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747820)]
		get;
	}

	[DispId(1610747821)]
	public virtual extern string ModelNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747821)]
		get;
	}

	[DispId(1610747822)]
	public virtual extern string Description
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747822)]
		get;
	}

	[DispId(1610747823)]
	public virtual extern string ModelURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747823)]
		get;
	}

	[DispId(1610747824)]
	public virtual extern string UPC
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747824)]
		get;
	}

	[DispId(1610747825)]
	public virtual extern string SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747825)]
		get;
	}

	[DispId(1610747828)]
	public virtual extern UPnPServices Services
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747828)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UPnPDeviceClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610747827)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string IconURL([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] int int_0, [In] int int_1, [In] int int_2);
}
