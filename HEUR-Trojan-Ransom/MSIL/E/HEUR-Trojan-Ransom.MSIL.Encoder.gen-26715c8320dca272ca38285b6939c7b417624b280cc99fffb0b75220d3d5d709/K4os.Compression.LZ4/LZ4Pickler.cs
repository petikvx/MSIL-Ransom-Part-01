using System;
using System.IO;
using System.Runtime.InteropServices;
using K4os.Compression.LZ4.Internal;

namespace K4os.Compression.LZ4;

public static class LZ4Pickler
{
	private const byte VersionMask = 7;

	private const byte CurrentVersion = 0;

	public static byte[] Pickle(byte[] source, LZ4Level level = LZ4Level.L00_FAST)
	{
		return Pickle(source, 0, source.Length, level);
	}

	public unsafe static byte[] Pickle(byte[] source, int sourceOffset, int sourceLength, LZ4Level level = LZ4Level.L00_FAST)
	{
		source.Validate(sourceOffset, sourceLength);
		fixed (byte* ptr = source)
		{
			return Pickle(ptr + sourceOffset, sourceLength, level);
		}
	}

	public unsafe static byte[] Pickle(ReadOnlySpan<byte> source, LZ4Level level = LZ4Level.L00_FAST)
	{
		int length = source.Length;
		if (length <= 0)
		{
			return Mem.Empty;
		}
		fixed (byte* source2 = &MemoryMarshal.GetReference(source))
		{
			return Pickle(source2, length, level);
		}
	}

	public unsafe static byte[] Pickle(byte* source, int sourceLength, LZ4Level level = LZ4Level.L00_FAST)
	{
		if (sourceLength <= 0)
		{
			return Mem.Empty;
		}
		int targetLength = sourceLength - 1;
		byte* ptr = (byte*)Mem.Alloc(sourceLength);
		try
		{
			int num = LZ4Codec.Encode(source, sourceLength, ptr, targetLength, level);
			return (num <= 0) ? PickleV0(source, sourceLength, sourceLength) : PickleV0(ptr, num, sourceLength);
		}
		finally
		{
			Mem.Free(ptr);
		}
	}

	public static byte[] Unpickle(byte[] source)
	{
		return Unpickle(source, 0, source.Length);
	}

	public unsafe static byte[] Unpickle(byte[] source, int sourceOffset, int sourceLength)
	{
		source.Validate(sourceOffset, sourceLength);
		if (sourceLength <= 0)
		{
			return Mem.Empty;
		}
		fixed (byte* ptr = source)
		{
			return Unpickle(ptr + sourceOffset, sourceLength);
		}
	}

	public unsafe static byte[] Unpickle(ReadOnlySpan<byte> source)
	{
		if (source.Length <= 0)
		{
			return Mem.Empty;
		}
		fixed (byte* source2 = &MemoryMarshal.GetReference(source))
		{
			return Unpickle(source2, source.Length);
		}
	}

	public unsafe static byte[] Unpickle(byte* source, int sourceLength)
	{
		if (sourceLength <= 0)
		{
			return Mem.Empty;
		}
		byte b = *source;
		int num = b & 7;
		if (num != 0)
		{
			throw new InvalidDataException($"Pickle version {num} is not supported");
		}
		return UnpickleV0(b, source + 1, sourceLength - 1);
	}

	private static Exception CorruptedPickle(string message)
	{
		return new InvalidDataException("Pickle is corrupted: " + message);
	}

	private unsafe static byte[] PickleV0(byte* target, int targetLength, int sourceLength)
	{
		int num = sourceLength - targetLength;
		int num2 = ((num != 0) ? ((num < 256) ? 1 : ((num < 65536) ? 2 : 4)) : 0);
		byte[] array = new byte[targetLength + 1 + num2];
		fixed (byte* ptr = array)
		{
			byte v = (byte)((uint)(((num2 == 4) ? 3 : num2) << 6) | 0u);
			Mem.Poke8(ptr, v);
			switch (num2)
			{
			case 1:
				Mem.Poke8(ptr + 1, (byte)num);
				break;
			case 2:
				Mem.Poke16(ptr + 1, (ushort)num);
				break;
			case 4:
				Mem.Poke32(ptr + 1, (uint)num);
				break;
			}
			Mem.Move(ptr + num2 + 1, target, targetLength);
		}
		return array;
	}

	private unsafe static byte[] UnpickleV0(byte flags, byte* source, int sourceLength)
	{
		int num = (flags >> 6) & 3;
		if (num == 3)
		{
			num = 4;
		}
		if (sourceLength < num)
		{
			throw CorruptedPickle("Source buffer is too small.");
		}
		int num2 = num switch
		{
			4 => *(int*)source, 
			2 => *(ushort*)source, 
			1 => *source, 
			0 => 0, 
			_ => throw CorruptedPickle("Unexpected length descriptor."), 
		};
		source += num;
		sourceLength -= num;
		int num3 = sourceLength + num2;
		byte[] array = new byte[num3];
		fixed (byte* target = array)
		{
			if (num2 == 0)
			{
				Mem.Copy(target, source, num3);
			}
			else
			{
				int num4 = LZ4Codec.Decode(source, sourceLength, target, num3);
				if (num4 != num3)
				{
					throw new ArgumentException($"Expected {num3} bytes but {num4} has been decoded");
				}
			}
		}
		return array;
	}
}
