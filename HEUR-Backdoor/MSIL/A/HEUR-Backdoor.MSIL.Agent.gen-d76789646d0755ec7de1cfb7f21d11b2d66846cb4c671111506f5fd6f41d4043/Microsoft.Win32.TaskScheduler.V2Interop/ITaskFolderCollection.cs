using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[Guid("79184A66-8664-423F-97F1-637356A5D812")]
[SuppressUnmanagedCodeSecurity]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
internal interface ITaskFolderCollection : IEnumerable
{
	int Count { get; }

	ITaskFolder this[object index]
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[return: MarshalAs(UnmanagedType.Interface)]
	new IEnumerator GetEnumerator();
}
