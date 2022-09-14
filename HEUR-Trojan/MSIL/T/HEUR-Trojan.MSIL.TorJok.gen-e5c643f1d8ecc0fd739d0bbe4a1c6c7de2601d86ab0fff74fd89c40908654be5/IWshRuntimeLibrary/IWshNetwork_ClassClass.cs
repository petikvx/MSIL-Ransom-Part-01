using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(18)]
[ClassInterface(0)]
[Guid("F935DC26-1CF0-11D0-ADB9-00C04FD58A0B")]
public sealed class IWshNetwork_ClassClass : IWshNetwork2, IWshNetwork_Class
{
	[DispId(1610743808)]
	public virtual extern string UserDomain
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743809)]
	public virtual extern string UserName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743809)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743810)]
	public virtual extern string UserProfile
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[TypeLibFunc(64)]
		[DispId(1610743810)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743811)]
	public virtual extern string ComputerName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743811)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743812)]
	public virtual extern string Organization
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743812)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743813)]
	public virtual extern string Site
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743813)]
		[TypeLibFunc(64)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern IWshNetwork_ClassClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1000)]
	public virtual extern void MapNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1001)]
	public virtual extern void RemoveNetworkDrive([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IWshCollection EnumNetworkDrives();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	public virtual extern void AddPrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string LocalName, [In][MarshalAs(UnmanagedType.BStr)] string RemoteName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UserName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Password);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	public virtual extern void RemovePrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string Name, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Force, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object UpdateProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2002)]
	[return: MarshalAs(UnmanagedType.Interface)]
	public virtual extern IWshCollection EnumPrinterConnections();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2003)]
	public virtual extern void SetDefaultPrinter([In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2004)]
	public virtual extern void AddWindowsPrinterConnection([In][MarshalAs(UnmanagedType.BStr)] string PrinterName, [In][MarshalAs(UnmanagedType.BStr)] string DriverName = "", [In][MarshalAs(UnmanagedType.BStr)] string Port = "LPT1");
}
