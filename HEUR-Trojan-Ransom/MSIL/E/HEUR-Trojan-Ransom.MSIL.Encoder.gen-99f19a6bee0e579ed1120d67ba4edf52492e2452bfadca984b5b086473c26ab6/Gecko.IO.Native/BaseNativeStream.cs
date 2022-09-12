using System;
using System.Runtime.InteropServices;

namespace Gecko.IO.Native;

public abstract class BaseNativeStream
{
	private IntPtr _buffer;

	private unsafe byte* _currentPointer;

	private int _length;

	private uint _position;

	internal IntPtr Buffer => _buffer;

	internal unsafe byte* CurrentPointer => _currentPointer;

	public int Length => _length;

	public uint Position => _position;

	internal BaseNativeStream()
	{
	}

	internal unsafe void Init(IntPtr buffer, int length)
	{
		_buffer = buffer;
		_length = length;
		_position = (uint)Math.Min(_position, _length);
		_currentPointer = (byte*)_buffer.ToPointer() + _position;
	}

	internal unsafe void MovePointer(uint count)
	{
		_currentPointer += count;
		_position += count;
	}

	public byte[] ReadData()
	{
		byte[] array = new byte[_position];
		Marshal.Copy(_buffer, array, 0, (int)_position);
		return array;
	}
}
