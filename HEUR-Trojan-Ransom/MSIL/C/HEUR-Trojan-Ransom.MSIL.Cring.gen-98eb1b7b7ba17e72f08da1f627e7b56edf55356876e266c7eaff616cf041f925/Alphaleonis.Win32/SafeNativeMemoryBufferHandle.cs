using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32;

internal abstract class SafeNativeMemoryBufferHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private readonly int m_capacity;

	public int Capacity => m_capacity;

	protected SafeNativeMemoryBufferHandle(bool callerHandle)
		: base(callerHandle)
	{
	}

	protected SafeNativeMemoryBufferHandle(int capacity)
		: this(callerHandle: true)
	{
		m_capacity = capacity;
	}

	protected SafeNativeMemoryBufferHandle(IntPtr memory, int capacity)
		: this(capacity)
	{
		SetHandle(memory);
	}

	public void CopyFrom(byte[] source, int startIndex, int length)
	{
		Marshal.Copy(source, startIndex, handle, length);
	}

	public void CopyFrom(char[] source, int startIndex, int length)
	{
		Marshal.Copy(source, startIndex, handle, length);
	}

	public void CopyFrom(char[] source, int startIndex, int length, int offset)
	{
		Marshal.Copy(source, startIndex, new IntPtr(handle.ToInt64() + offset), length);
	}

	public void CopyTo(int sourceOffset, byte[] destination)
	{
		if (destination != null && destination.Length != 0)
		{
			int num = destination.Length;
			if (num > destination.Length)
			{
				throw new ArgumentException(Resources.Destination_Buffer_Not_Large_Enough, "destination");
			}
			if (num > Capacity)
			{
				throw new ArgumentOutOfRangeException("destination", Resources.Source_OffsetAndLength_Outside_Bounds);
			}
			Marshal.Copy(new IntPtr(handle.ToInt64() + sourceOffset), destination, 0, num);
			return;
		}
		throw new ArgumentNullException("destination");
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
		if (length > Capacity)
		{
			throw new ArgumentOutOfRangeException("length", Resources.Source_OffsetAndLength_Outside_Bounds);
		}
		Marshal.Copy(handle, destination, destinationOffset, length);
	}

	public void CopyTo(int sourceOffset, byte[] destination, int destinationOffset, int length)
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
		if (length > Capacity)
		{
			throw new ArgumentOutOfRangeException("length", Resources.Source_OffsetAndLength_Outside_Bounds);
		}
		Marshal.Copy(new IntPtr(handle.ToInt64() + sourceOffset), destination, destinationOffset, length);
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

	public void WriteInt16(int offset, short value)
	{
		Marshal.WriteInt16(handle, offset, value);
	}

	public void WriteInt16(int offset, char value)
	{
		Marshal.WriteInt16(handle, offset, value);
	}

	public void WriteInt16(char value)
	{
		Marshal.WriteInt16(handle, value);
	}

	public void WriteInt16(short value)
	{
		Marshal.WriteInt16(handle, value);
	}

	public void WriteInt32(int offset, short value)
	{
		Marshal.WriteInt32(handle, offset, value);
	}

	public void WriteInt32(int value)
	{
		Marshal.WriteInt32(handle, value);
	}

	public void WriteInt64(int offset, long value)
	{
		Marshal.WriteInt64(handle, offset, value);
	}

	public void WriteInt64(long value)
	{
		Marshal.WriteInt64(handle, value);
	}

	public void WriteByte(int offset, byte value)
	{
		Marshal.WriteByte(handle, offset, value);
	}

	public void WriteByte(byte value)
	{
		Marshal.WriteByte(handle, value);
	}

	public void WriteIntPtr(int offset, IntPtr value)
	{
		Marshal.WriteIntPtr(handle, offset, value);
	}

	public void WriteIntPtr(IntPtr value)
	{
		Marshal.WriteIntPtr(handle, value);
	}

	public byte ReadByte()
	{
		return Marshal.ReadByte(handle);
	}

	public byte ReadByte(int offset)
	{
		return Marshal.ReadByte(handle, offset);
	}

	public short ReadInt16()
	{
		return Marshal.ReadInt16(handle);
	}

	public short ReadInt16(int offset)
	{
		return Marshal.ReadInt16(handle, offset);
	}

	public int ReadInt32()
	{
		return Marshal.ReadInt32(handle);
	}

	public int ReadInt32(int offset)
	{
		return Marshal.ReadInt32(handle, offset);
	}

	public long ReadInt64()
	{
		return Marshal.ReadInt64(handle);
	}

	public long ReadInt64(int offset)
	{
		return Marshal.ReadInt64(handle, offset);
	}

	public IntPtr ReadIntPtr()
	{
		return Marshal.ReadIntPtr(handle);
	}

	public IntPtr ReadIntPtr(int offset)
	{
		return Marshal.ReadIntPtr(handle, offset);
	}

	public void StructureToPtr(object structure, bool deleteOld)
	{
		Marshal.StructureToPtr(structure, handle, deleteOld);
	}

	public T PtrToStructure<T>(int offset)
	{
		return (T)Marshal.PtrToStructure(new IntPtr(handle.ToInt64() + offset), typeof(T));
	}

	public string PtrToStringAnsi(int offset)
	{
		return Marshal.PtrToStringAnsi(new IntPtr(handle.ToInt64() + offset));
	}

	public string PtrToStringUni()
	{
		return Marshal.PtrToStringUni(handle);
	}

	public string PtrToStringUni(int offset, int length)
	{
		return Marshal.PtrToStringUni(new IntPtr(handle.ToInt64() + offset), length);
	}
}
