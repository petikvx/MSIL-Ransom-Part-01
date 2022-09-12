using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4e747be5-2052-4265-8af0-8ecad7aad1c0")]
public interface ISimpleDOMText
{
	string DomText
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	string FontFamily
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Get_clippedSubstringBounds(uint startIndex, uint endIndex, ref int x, ref int y, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint Get_unclippedSubstringBounds(uint startIndex, uint endIndex, ref int x, ref int y, ref int width, ref int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint ScrollToSubstring(uint startIndex, uint endIndex);
}
