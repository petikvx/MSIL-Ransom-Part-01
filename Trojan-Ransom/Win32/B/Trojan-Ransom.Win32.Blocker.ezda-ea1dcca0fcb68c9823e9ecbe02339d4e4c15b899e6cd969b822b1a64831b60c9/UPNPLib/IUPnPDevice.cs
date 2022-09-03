using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[Guid("3D44D0D1-98C9-4889-ACD1-F9D674BF2221")]
[TypeLibType(4288)]
public interface IUPnPDevice
{
	[DispId(1610747809)]
	bool IsRootDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747809)]
		get;
	}

	[DispId(1610747810)]
	UPnPDevice RootDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747810)]
		get;
	}

	[DispId(1610747811)]
	UPnPDevice ParentDevice
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747811)]
		get;
	}

	[DispId(1610747812)]
	bool HasChildren
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747812)]
		get;
	}

	[DispId(1610747813)]
	UPnPDevices Children
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747813)]
		get;
	}

	[DispId(1610747814)]
	string UniqueDeviceName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747814)]
		get;
	}

	[DispId(1610747815)]
	string FriendlyName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747815)]
		get;
	}

	[DispId(1610747816)]
	string Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747816)]
		get;
	}

	[DispId(1610747817)]
	string PresentationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747817)]
		get;
	}

	[DispId(1610747818)]
	string ManufacturerName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747818)]
		get;
	}

	[DispId(1610747819)]
	string ManufacturerURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747819)]
		get;
	}

	[DispId(1610747820)]
	string ModelName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747820)]
		get;
	}

	[DispId(1610747821)]
	string ModelNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747821)]
		get;
	}

	[DispId(1610747822)]
	string Description
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747822)]
		get;
	}

	[DispId(1610747823)]
	string ModelURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747823)]
		get;
	}

	[DispId(1610747824)]
	string UPC
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747824)]
		get;
	}

	[DispId(1610747825)]
	string SerialNumber
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747825)]
		get;
	}

	[DispId(1610747828)]
	UPnPServices Services
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610747828)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610747827)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string IconURL([In][MarshalAs(UnmanagedType.BStr)] string string_0, [In] int int_0, [In] int int_1, [In] int int_2);
}
