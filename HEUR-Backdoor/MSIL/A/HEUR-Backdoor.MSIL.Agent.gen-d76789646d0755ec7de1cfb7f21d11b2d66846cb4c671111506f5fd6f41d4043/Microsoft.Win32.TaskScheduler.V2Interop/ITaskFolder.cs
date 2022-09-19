using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("8CFAC062-A080-4C15-9A88-AA7C2AF80DFC")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[SuppressUnmanagedCodeSecurity]
[DefaultMember("Path")]
internal interface ITaskFolder
{
	string Name
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string Path
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskFolder GetFolder([MarshalAs(UnmanagedType.BStr)] string Path);

	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskFolderCollection GetFolders(int flags);

	[return: MarshalAs(UnmanagedType.Interface)]
	ITaskFolder CreateFolder([In][MarshalAs(UnmanagedType.BStr)] string subFolderName, [Optional][In][MarshalAs(UnmanagedType.Struct)] object sddl);

	void DeleteFolder([MarshalAs(UnmanagedType.BStr)] string subFolderName, [In] int flags);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRegisteredTask GetTask([MarshalAs(UnmanagedType.BStr)] string Path);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRegisteredTaskCollection GetTasks(int flags);

	void DeleteTask([In][MarshalAs(UnmanagedType.BStr)] string Name, [In] int flags);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRegisteredTask RegisterTask([In][MarshalAs(UnmanagedType.BStr)] string Path, [In][MarshalAs(UnmanagedType.BStr)] string XmlText, [In] int flags, [In][MarshalAs(UnmanagedType.Struct)] object UserId, [In][MarshalAs(UnmanagedType.Struct)] object password, [In] TaskLogonType LogonType, [Optional][In][MarshalAs(UnmanagedType.Struct)] object sddl);

	[return: MarshalAs(UnmanagedType.Interface)]
	IRegisteredTask RegisterTaskDefinition([In][MarshalAs(UnmanagedType.BStr)] string Path, [In][MarshalAs(UnmanagedType.Interface)] ITaskDefinition pDefinition, [In] int flags, [In][MarshalAs(UnmanagedType.Struct)] object UserId, [In][MarshalAs(UnmanagedType.Struct)] object password, [In] TaskLogonType LogonType, [Optional][In][MarshalAs(UnmanagedType.Struct)] object sddl);

	[return: MarshalAs(UnmanagedType.BStr)]
	string GetSecurityDescriptor(int securityInformation);

	void SetSecurityDescriptor([In][MarshalAs(UnmanagedType.BStr)] string sddl, [In] int flags);
}
