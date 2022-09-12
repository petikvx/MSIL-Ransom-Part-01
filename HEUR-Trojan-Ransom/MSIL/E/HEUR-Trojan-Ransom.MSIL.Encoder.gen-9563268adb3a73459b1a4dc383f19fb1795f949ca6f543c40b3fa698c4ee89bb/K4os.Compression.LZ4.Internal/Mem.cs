using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace K4os.Compression.LZ4.Internal;

public class Mem
{
	public const int K1 = 1024;

	public const int K2 = 2048;

	public const int K4 = 4096;

	public const int K8 = 8192;

	public const int K16 = 16384;

	public const int K32 = 32768;

	public const int K64 = 65536;

	public const int K128 = 131072;

	public const int K256 = 262144;

	public const int K512 = 524288;

	public const int M1 = 1048576;

	public const int M4 = 4194304;

	public static readonly byte[] Empty = new byte[0];

	public static int RoundUp(int value, int step)
	{
		return (value + step - 1) / step * step;
	}

	public unsafe static void Copy(byte* target, byte* source, int length)
	{
		if (length > 0)
		{
			System.Runtime.CompilerServices.Unsafe.CopyBlock((void*)target, (void*)source, (uint)length);
		}
	}

	public unsafe static void Move(byte* target, byte* source, int length)
	{
		if (length > 0)
		{
			System.Runtime.CompilerServices.Unsafe.CopyBlock((void*)target, (void*)source, (uint)length);
		}
	}

	public unsafe static void WildCopy(byte* target, byte* source, void* limit)
	{
		do
		{
			*(long*)target = *(long*)source;
			target += 8;
			source += 8;
		}
		while (target < limit);
	}

	public unsafe static void Zero(byte* target, int length)
	{
		while (length >= 8)
		{
			*(long*)target = 0L;
			target += 8;
			length -= 8;
		}
		if (length >= 4)
		{
			*(int*)target = 0;
			target += 4;
			length -= 4;
		}
		if (length >= 2)
		{
			*(short*)target = 0;
			target += 2;
			length -= 2;
		}
		if (length > 0)
		{
			*target = 0;
		}
	}

	public unsafe static void Fill(byte* target, byte value, int length)
	{
		ulong num = value;
		num |= num << 8;
		num |= num << 16;
		num |= num << 32;
		while (length >= 8)
		{
			*(ulong*)target = num;
			target += 8;
			length -= 8;
		}
		if (length >= 4)
		{
			*(int*)target = (int)num;
			target += 4;
			length -= 4;
		}
		if (length >= 2)
		{
			*(ushort*)target = (ushort)num;
			target += 2;
			length -= 2;
		}
		if (length > 0)
		{
			*target = value;
		}
	}

	public unsafe static void LoopCopy(byte* target, byte* source, int length)
	{
		while (length >= 8)
		{
			*(long*)target = *(long*)source;
			target += 8;
			source += 8;
			length -= 8;
		}
		if (length >= 4)
		{
			*(int*)target = *(int*)source;
			target += 4;
			source += 4;
			length -= 4;
		}
		if (length >= 2)
		{
			*(short*)target = *(short*)source;
			target += 2;
			source += 2;
			length -= 2;
		}
		if (length > 0)
		{
			*target = *source;
		}
	}

	private unsafe static void LoopCopyBack(byte* target, byte* source, int length)
	{
		if (length > 0)
		{
			target += length;
			source += length;
			while (length >= 8)
			{
				target -= 8;
				source -= 8;
				length -= 8;
				*(long*)target = *(long*)source;
			}
			if (length >= 4)
			{
				target -= 4;
				source -= 4;
				length -= 4;
				*(int*)target = *(int*)source;
			}
			if (length >= 2)
			{
				target -= 2;
				source -= 2;
				length -= 2;
				*(short*)target = *(short*)source;
			}
			if (length > 0)
			{
				target--;
				source--;
				*target = *source;
			}
		}
	}

	public unsafe static void LoopMove(byte* target, byte* source, int length)
	{
		if (length > 0 && source != target)
		{
			if (source < target && source + length > target)
			{
				LoopCopyBack(target, source, length);
			}
			else
			{
				LoopCopy(target, source, length);
			}
		}
	}

	public unsafe static void Copy8(byte* target, byte* source)
	{
		*(long*)target = *(long*)source;
	}

	public unsafe static void Copy16(byte* target, byte* source)
	{
		*(long*)target = *(long*)source;
		*(long*)(target + 8) = *(long*)(source + 8);
	}

	public unsafe static void Copy18(byte* target, byte* source)
	{
		*(long*)target = *(long*)source;
		*(long*)(target + 8) = *(long*)(source + 8);
		*(short*)(target + 16) = *(short*)(source + 16);
	}

	public unsafe static void* Alloc(int size)
	{
		return Marshal.AllocHGlobal(size).ToPointer();
	}

	public unsafe static void* AllocZero(int size)
	{
		void* intPtr = Alloc(size);
		Zero((byte*)intPtr, size);
		return intPtr;
	}

	public unsafe static void Free(void* ptr)
	{
		Marshal.FreeHGlobal(new IntPtr(ptr));
	}

	public unsafe static byte Peek8(void* p)
	{
		return *(byte*)p;
	}

	public unsafe static ushort Peek16(void* p)
	{
		return *(ushort*)p;
	}

	public unsafe static uint Peek32(void* p)
	{
		return *(uint*)p;
	}

	public unsafe static ulong Peek64(void* p)
	{
		return *(ulong*)p;
	}

	public unsafe static void Poke8(void* p, byte v)
	{
		*(byte*)p = v;
	}

	public unsafe static void Poke16(void* p, ushort v)
	{
		*(ushort*)p = v;
	}

	public unsafe static void Poke32(void* p, uint v)
	{
		*(uint*)p = v;
	}

	public unsafe static void Poke64(void* p, ulong v)
	{
		*(ulong*)p = v;
	}
}
