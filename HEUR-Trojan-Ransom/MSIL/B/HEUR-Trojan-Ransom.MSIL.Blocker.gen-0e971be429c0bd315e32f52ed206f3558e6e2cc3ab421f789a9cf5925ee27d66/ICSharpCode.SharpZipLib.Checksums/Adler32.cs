using System;

namespace ICSharpCode.SharpZipLib.Checksums;

public sealed class Adler32 : IChecksum
{
	private const uint XWaupNVdTzuniRUHHgeVLQZarkbT = 65521u;

	private uint hkOvlGyMyaBpITEuUhTVDIqbpZCL;

	public long Value => hkOvlGyMyaBpITEuUhTVDIqbpZCL;

	public Adler32()
	{
		Reset();
	}

	public void Reset()
	{
		hkOvlGyMyaBpITEuUhTVDIqbpZCL = 1u;
	}

	public void Update(int value)
	{
		uint num = hkOvlGyMyaBpITEuUhTVDIqbpZCL & 0xFFFFu;
		uint num2 = hkOvlGyMyaBpITEuUhTVDIqbpZCL >> 16;
		num = (uint)((num + (value & 0xFF)) % 65521L);
		num2 = (num + num2) % 65521u;
		hkOvlGyMyaBpITEuUhTVDIqbpZCL = (num2 << 16) + num;
	}

	public void Update(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		Update(buffer, 0, buffer.Length);
	}

	public void Update(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset >= 0)
		{
			if (count >= 0)
			{
				if (offset < buffer.Length)
				{
					if (offset + count <= buffer.Length)
					{
						uint num = hkOvlGyMyaBpITEuUhTVDIqbpZCL & 0xFFFFu;
						uint num2 = hkOvlGyMyaBpITEuUhTVDIqbpZCL >> 16;
						while (count > 0)
						{
							int num3 = 3800;
							if (3800 > count)
							{
								num3 = count;
							}
							count -= num3;
							while (--num3 >= 0)
							{
								num += (uint)(buffer[offset++] & 0xFF);
								num2 += num;
							}
							num %= 65521u;
							num2 %= 65521u;
						}
						hkOvlGyMyaBpITEuUhTVDIqbpZCL = (num2 << 16) | num;
						return;
					}
					throw new ArgumentOutOfRangeException("count", "exceeds buffer size");
				}
				throw new ArgumentOutOfRangeException("offset", "not a valid index into buffer");
			}
			throw new ArgumentOutOfRangeException("count", "cannot be negative");
		}
		throw new ArgumentOutOfRangeException("offset", "cannot be negative");
	}
}
