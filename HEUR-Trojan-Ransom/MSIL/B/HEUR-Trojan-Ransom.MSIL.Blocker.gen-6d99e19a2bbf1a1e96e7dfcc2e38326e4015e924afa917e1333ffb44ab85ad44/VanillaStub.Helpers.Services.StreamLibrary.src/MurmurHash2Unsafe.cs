namespace VanillaStub.Helpers.Services.StreamLibrary.src;

public class MurmurHash2Unsafe
{
	private const uint m = 1540483477u;

	private const int r = 24;

	public unsafe uint Hash(byte* data, int length)
	{
		if (length == 0)
		{
			return 0u;
		}
		uint num = 0xC58F1A7Bu ^ (uint)length;
		int num2 = length & 3;
		int num3 = length >> 2;
		uint* ptr = (uint*)data;
		while (num3 != 0)
		{
			uint num4 = *ptr;
			num4 *= 1540483477;
			num4 ^= num4 >> 24;
			num4 *= 1540483477;
			num *= 1540483477;
			num ^= num4;
			num3--;
			ptr++;
		}
		switch (num2)
		{
		case 1:
			num ^= *(byte*)ptr;
			num *= 1540483477;
			break;
		case 2:
			num ^= (ushort)(*ptr);
			num *= 1540483477;
			break;
		case 3:
			num ^= (ushort)(*ptr);
			num ^= (uint)(((byte*)ptr)[2] << 16);
			num *= 1540483477;
			break;
		}
		num ^= num >> 13;
		num *= 1540483477;
		return num ^ (num >> 15);
	}
}
