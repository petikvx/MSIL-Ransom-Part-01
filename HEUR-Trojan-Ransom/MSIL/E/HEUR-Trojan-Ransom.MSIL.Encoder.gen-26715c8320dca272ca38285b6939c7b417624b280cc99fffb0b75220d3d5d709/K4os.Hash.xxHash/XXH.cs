using System;

namespace K4os.Hash.xxHash;

public class XXH
{
	protected XXH()
	{
	}

	internal unsafe static uint XXH_read32(void* p)
	{
		return *(uint*)p;
	}

	internal unsafe static ulong XXH_read64(void* p)
	{
		return *(ulong*)p;
	}

	internal unsafe static void XXH_zero(void* target, int length)
	{
		byte* ptr = (byte*)target;
		while (length >= 8)
		{
			*(long*)ptr = 0L;
			ptr += 8;
			length -= 8;
		}
		if (length >= 4)
		{
			*(int*)ptr = 0;
			ptr += 4;
			length -= 4;
		}
		if (length >= 2)
		{
			*(short*)ptr = 0;
			ptr += 2;
			length -= 2;
		}
		if (length > 0)
		{
			*ptr = 0;
		}
	}

	internal unsafe static void XXH_copy(void* target, void* source, int length)
	{
		byte* ptr = (byte*)source;
		byte* ptr2 = (byte*)target;
		while (length >= 8)
		{
			*(long*)ptr2 = *(long*)ptr;
			ptr2 += 8;
			ptr += 8;
			length -= 8;
		}
		if (length >= 4)
		{
			*(int*)ptr2 = *(int*)ptr;
			ptr2 += 4;
			ptr += 4;
			length -= 4;
		}
		if (length >= 2)
		{
			*(short*)ptr2 = *(short*)ptr;
			ptr2 += 2;
			ptr += 2;
			length -= 2;
		}
		if (length > 0)
		{
			*ptr2 = *ptr;
		}
	}

	internal static void Validate(byte[] bytes, int offset, int length)
	{
		if (bytes == null || offset < 0 || length < 0 || offset + length > bytes.Length)
		{
			throw new ArgumentException("Invalid buffer boundaries");
		}
	}
}
