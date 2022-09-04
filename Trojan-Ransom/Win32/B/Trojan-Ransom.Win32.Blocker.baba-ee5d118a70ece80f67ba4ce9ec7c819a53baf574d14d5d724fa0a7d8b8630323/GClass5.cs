public class GClass5
{
	public uint[] uint_0 = new uint[8];

	public unsafe byte[] method_0(byte[] byte_0)
	{
		if (byte_0.Length >= 1 && byte_0.Length > 0)
		{
			byte b = 0;
			int num = byte_0.Length;
			fixed (byte* ptr = &byte_0[0])
			{
				byte* ptr2 = ptr;
				int num2 = num & 3;
				int num3 = num >> 2;
				uint num4 = 0u;
				for (int i = 0; i < num3; i++)
				{
					uint num5 = *(uint*)ptr2;
					*(uint*)ptr2 = num5 ^ uint_0[(i + b) % uint_0.Length] ^ num4;
					uint_0[(i + b) % uint_0.Length] += *(uint*)ptr2 * 268084959 + 144156298;
					num4 = num5;
					ptr2 += 4;
				}
				switch (num2)
				{
				case 1:
				{
					byte* intPtr3 = ptr2;
					*intPtr3 = (byte)(*intPtr3 ^ (byte)uint_0[(num2 * num3 + b) % uint_0.Length]);
					uint_0[(num2 * num3 + b) % uint_0.Length] += (uint)(*ptr2 * 1990748159 + 128346280);
					break;
				}
				case 2:
				{
					byte* intPtr2 = ptr2;
					*(ushort*)intPtr2 = (ushort)(*(ushort*)intPtr2 ^ (ushort)uint_0[(num2 * num3 + b) % uint_0.Length]);
					uint_0[(num2 * num3 + b) % uint_0.Length] += (uint)(*(ushort*)ptr2 * 195914362 + 2024236667);
					break;
				}
				case 3:
				{
					byte* intPtr = ptr2;
					*(ushort*)intPtr = (ushort)(*(ushort*)intPtr ^ (ushort)uint_0[(num2 * num3 + b) % uint_0.Length]);
					byte* num6 = ptr2 + 2;
					*num6 = (byte)(*num6 ^ (byte)uint_0[(num2 * num3 + b) % uint_0.Length]);
					uint_0[(num2 * num3 + b) % uint_0.Length] += (uint)(*(ushort*)ptr2 * 90921575 + 1601479840);
					uint_0[(num2 * num3 + b) % uint_0.Length] += (uint)(ptr2[2] * 174803514 + 2073470858);
					break;
				}
				}
			}
			return byte_0;
		}
		return null;
	}
}
