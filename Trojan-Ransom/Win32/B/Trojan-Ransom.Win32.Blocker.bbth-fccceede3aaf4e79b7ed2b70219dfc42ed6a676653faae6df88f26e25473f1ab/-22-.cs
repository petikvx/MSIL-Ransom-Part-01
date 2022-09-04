using System;
using System.IO;
using System.Reflection;
using System.Text;

internal static class _003F22_003F
{
	static object _003F97_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x7E9B2B12u ^ num;
		uint num3 = 472311784u;
		uint num4 = 1865422345u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x3E77275E;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x3E77275Eu;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x3E77275Eu;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 1047996254;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000063 ^ currentMethod.MetadataToken);
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

	static object _003F98_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x4F408697u ^ num;
		uint num3 = 2063135223u;
		uint num4 = 1689507268u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x54DA1CDF;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x54DA1CDFu;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x54DA1CDFu;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 1423580383;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000062 ^ currentMethod.MetadataToken);
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

	static object _003F99_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x3F196606u ^ num;
		uint num3 = 452213547u;
		uint num4 = 1221681293u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x7FF196D0;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x7FF196D0u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x7FF196D0u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 2146539216;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000065 ^ currentMethod.MetadataToken);
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

	static object _003F100_003F(uint _003F165_003F, uint _003F166_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F165_003F));
		uint num2 = 0x79EAD192u ^ num;
		uint num3 = 1487509015u;
		uint num4 = 793552980u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x2C49794;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x2C49794u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x2C49794u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 46438292;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000064 ^ currentMethod.MetadataToken);
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
