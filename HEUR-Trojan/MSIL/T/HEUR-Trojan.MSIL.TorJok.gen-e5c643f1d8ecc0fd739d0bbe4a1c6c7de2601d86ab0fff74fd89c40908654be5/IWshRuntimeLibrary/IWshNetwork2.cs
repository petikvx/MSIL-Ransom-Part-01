using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(4160)]
[Guid("24BE5A31-EDFE-11D2-B933-00104B365C9F")]
public interface IWshNetwork2 : IWshNetwork
{
	[DispId(1610743808)]
	new string UserDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743809)]
	new string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743809)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743810)]
	new string UserProfile
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743810)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743811)]
	new string ComputerName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743811)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743812)]
	new string Organization
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743812)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743813)]
	new string Site
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[TypeLibFunc(64)]
		[DispId(1610743813)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1000)]
	new void MapNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1001)]
	new void RemoveNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new IWshCollection EnumNetworkDrives();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	new void AddPrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	new void RemovePrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new IWshCollection EnumPrinterConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2003)]
	new void SetDefaultPrinter([In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2004)]
	void AddWindowsPrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string PrinterName, [In][MarshalAs(UnmanagedType.BStr)] string DriverName = "", [In][MarshalAs(UnmanagedType.BStr)] string Port = "LPT1");
}
