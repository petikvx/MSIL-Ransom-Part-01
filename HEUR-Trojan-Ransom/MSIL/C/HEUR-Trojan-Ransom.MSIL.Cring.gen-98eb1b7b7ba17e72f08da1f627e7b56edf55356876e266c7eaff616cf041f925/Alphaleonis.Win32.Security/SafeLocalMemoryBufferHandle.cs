using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Security;

internal sealed class SafeLocalMemoryBufferHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeLocalMemoryBufferHandle()
		: base(ownsHandle: true)
	{
	}

	public void CopyFrom(byte[] source, int startIndex, int length)
	{
		Marshal.Copy(source, startIndex, handle, length);
	}

	public void CopyTo(byte[] destination, int destinationOffset, int length)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (destinationOffset < 0)
		{
			throw new ArgumentOutOfRangeException("destinationOffset", Resources.Negative_Destination_Offset);
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", Resources.Negative_Length);
		}
		if (destinationOffset + length > destination.Length)
		{
			throw new ArgumentException(Resources.Destination_Buffer_Not_Large_Enough, "length");
		}
		Marshal.Copy(handle, destination, destinationOffset, length);
	}

	public byte[] ToByteArray(int startIndex, int length)
	{
		if (IsInvalid)
		{
			return null;
		}
		byte[] array = new byte[length];
		Marshal.Copy(handle, array, startIndex, length);
		return array;
	}

	protected override bool ReleaseHandle()
	{
		if (!(handle == IntPtr.Zero))
		{
			return NativeMethods.LocalFree(handle) == IntPtr.Zero;
		}
		return true;
	}
}
