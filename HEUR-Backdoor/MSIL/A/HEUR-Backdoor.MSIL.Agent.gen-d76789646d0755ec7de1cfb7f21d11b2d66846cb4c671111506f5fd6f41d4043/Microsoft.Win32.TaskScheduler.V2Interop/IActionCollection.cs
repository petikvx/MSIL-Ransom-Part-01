using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Win32.TaskScheduler.V2Interop;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
[Guid("02820E19-7B98-4ED2-B2E8-FDCCCEFF619B")]
[SuppressUnmanagedCodeSecurity]
internal interface IActionCollection : IEnumerable
{
	int Count { get; }

	IAction this[int index]
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	string XmlText
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string Context
	{
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[return: MarshalAs(UnmanagedType.Interface)]
	new IEnumerator GetEnumerator();

	[return: MarshalAs(UnmanagedType.Interface)]
	IAction Create([In] TaskActionType Type);

	void Remove([In][MarshalAs(UnmanagedType.Struct)] object index);

	void Clear();
}
