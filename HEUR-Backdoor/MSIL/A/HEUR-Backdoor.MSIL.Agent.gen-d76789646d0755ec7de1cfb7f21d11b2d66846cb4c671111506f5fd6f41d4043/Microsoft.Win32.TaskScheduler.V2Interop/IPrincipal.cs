using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("D98D51E5-C9B4-496A-A9C1-18980261CF0F")]
internal interface IPrincipal
{
	string Id
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string DisplayName
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string UserId
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	TaskLogonType LogonType { get; set; }

	string GroupId
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	TaskRunLevel RunLevel { get; set; }
}
