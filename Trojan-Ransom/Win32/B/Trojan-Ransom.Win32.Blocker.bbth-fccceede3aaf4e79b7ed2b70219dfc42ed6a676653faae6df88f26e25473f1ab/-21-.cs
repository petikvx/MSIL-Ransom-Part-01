using System;
using System.IO;
using System.Reflection;
using System.Text;

internal static class _003F21_003F
{
	static object _003F94_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x2C9E3611u ^ num;
		uint num3 = 1258008617u;
		uint num4 = 120898909u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x618379C1;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x618379C1u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x618379C1u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 1636006337;
			}
		}
		uint num7 = num2 ^ _003F166_003F;
		if (!_003F0_003F.쯘祋拥륋菄䁷㪷m.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.ᾐ_FB08죂䜨餴_2AA6ꆲ鰿)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.ᾐ_FB08죂䜨餴_2AA6ꆲ鰿);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000061 ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 107755118;
			ushort num9 = (ushort)(num8 >> 16);
			ushort num10 = (ushort)(num8 & 0xFFFFu);
			ushort num11 = num10;
			ushort num12 = num9;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)(((num8 * num11 + num12) % 256u) ^ array2[i % 8]);
				num11 = (ushort)((num8 * num11 + num9) % 65536u);
				num12 = (ushort)((num8 * num12 + num10) % 65536u);
			}
			switch (b)
			{
			case 37:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 121:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 112:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 90:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 254:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.쯘祋拥륋菄䁷㪷m[num7] = value;
		}
		return value;
	}

	static object _003F95_003F_002E_003F96_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x26D8069Eu ^ num;
		uint num3 = 1326606466u;
		uint num4 = 944130129u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x49F96233;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x49F96233u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x49F96233u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 1241080371;
			}
		}
		uint num7 = num2 ^ _003F166_003F;
		if (!_003F0_003F.쯘祋拥륋菄䁷㪷m.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.ᾐ_FB08죂䜨餴_2AA6ꆲ鰿)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.ᾐ_FB08죂䜨餴_2AA6ꆲ鰿);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000060 ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 107755118;
			ushort num9 = (ushort)(num8 >> 16);
			ushort num10 = (ushort)(num8 & 0xFFFFu);
			ushort num11 = num10;
			ushort num12 = num9;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] ^= (byte)(((num8 * num11 + num12) % 256u) ^ array2[i % 8]);
				num11 = (ushort)((num8 * num11 + num9) % 65536u);
				num12 = (ushort)((num8 * num12 + num10) % 65536u);
			}
			switch (b)
			{
			case 37:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 121:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 112:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 90:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 254:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.쯘祋拥륋菄䁷㪷m[num7] = value;
		}
		return value;
	}
}
