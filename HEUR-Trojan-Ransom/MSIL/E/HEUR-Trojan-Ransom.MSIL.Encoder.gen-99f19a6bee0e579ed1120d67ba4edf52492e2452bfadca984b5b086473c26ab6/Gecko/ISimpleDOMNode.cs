using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1814ceeb-49e2-407f-af99-fa755a7d2607")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ISimpleDOMNode
{
	ISimpleDOMNode ParentNode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	ISimpleDOMNode FirstChild
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	ISimpleDOMNode LastChild
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	ISimpleDOMNode PreviousSibling
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	ISimpleDOMNode NextSibling
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	string InnerHTML
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	IntPtr LocalInterface
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	string Language
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	ushort NodeInfo
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	ushort Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	string AttributesForNames
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	ushort ComputedStyle
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	string ComputedStyleForProperties
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	ISimpleDOMNode ChildAt
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ScrollTo([MarshalAs(UnmanagedType.U1)] bool placeTopLeft);
}
