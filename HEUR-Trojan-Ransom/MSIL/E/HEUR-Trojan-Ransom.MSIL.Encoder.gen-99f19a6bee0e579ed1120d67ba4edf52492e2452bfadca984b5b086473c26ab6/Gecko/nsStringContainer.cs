using System;
using System.Runtime.InteropServices;

namespace Gecko;

internal struct nsStringContainer
{
	private IntPtr mData;

	private int mLength;

	private int mFlags;

	public static int Size => Marshal.SizeOf(typeof(nsStringContainer));
}
