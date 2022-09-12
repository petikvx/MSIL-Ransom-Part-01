using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0D68D6D0-D93D-4d08-A30D-F00DD1F45B24")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ISimpleDOMDocument
{
	string URL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string Title
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string MimeType
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string DocType
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string AlternateViewMediaTypes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	string NameSpaceURIForID
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
