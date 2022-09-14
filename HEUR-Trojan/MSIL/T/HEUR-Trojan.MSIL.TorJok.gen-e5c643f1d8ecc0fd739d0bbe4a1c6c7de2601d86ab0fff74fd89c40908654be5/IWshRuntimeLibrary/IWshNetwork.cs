using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("F935DC25-1CF0-11D0-ADB9-00C04FD58A0B")]
[TypeLibType(4176)]
public interface IWshNetwork
{
	[DispId(1610743808)]
	string UserDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743809)]
	string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743809)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743810)]
	string UserProfile
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743810)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743811)]
	string ComputerName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743811)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743812)]
	string Organization
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743812)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743813)]
	string Site
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[TypeLibFunc(64)]
		[DispId(1610743813)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1000)]
	void MapNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1001)]
	void RemoveNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IWshCollection EnumNetworkDrives();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	void AddPrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	void RemovePrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IWshCollection EnumPrinterConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2003)]
	void SetDefaultPrinter([In][MarshalAs(UnmanagedType.BStr)] string Name);
}
