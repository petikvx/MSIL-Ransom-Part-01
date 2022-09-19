using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[SuppressUnmanagedCodeSecurity]
[Guid("39038068-2B46-4AFD-8662-7BB6F868D221")]
[DefaultMember("Name")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface ITaskNamedValuePair
{
	string Name
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string Value
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}
}
