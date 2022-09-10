using System;
using System.IO;
using System.Reflection;
using System.Text;

internal static class _003F4_003F
{
	static object _003F37_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x6D71776Au ^ num;
		uint num3 = 2099852701u;
		uint num4 = 694854131u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x32340EA4;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x32340EA4u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x32340EA4u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 842272420;
			}
		}
		uint num7 = num2 ^ _003F80_003F;
		if (!_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.풊_F522_E249땤锖蓌靏㚽)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.풊_F522_E249땤锖蓌靏㚽);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x1700000B ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 113363051;
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
			case 45:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 69:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 172:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 84:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 51:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4[num7] = value;
		}
		return value;
	}

	static object _003F38_003F_002E_003F39_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0xE3DEA68u ^ num;
		uint num3 = 1633865933u;
		uint num4 = 1787157149u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x3398595A;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x3398595Au;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x3398595Au;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 865622362;
			}
		}
		uint num7 = num2 ^ _003F80_003F;
		if (!_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.풊_F522_E249땤锖蓌靏㚽)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.풊_F522_E249땤锖蓌靏㚽);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x1700000A ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 113363051;
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
			case 45:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 69:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 172:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 84:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 51:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4[num7] = value;
		}
		return value;
	}

	static object _003F40_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x468AAED3u ^ num;
		uint num3 = 309505947u;
		uint num4 = 1875388104u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x2A908D40;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x2A908D40u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x2A908D40u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 714116416;
			}
		}
		uint num7 = num2 ^ _003F80_003F;
		if (!_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.풊_F522_E249땤锖蓌靏㚽)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.풊_F522_E249땤锖蓌靏㚽);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x1700000D ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 113363051;
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
			case 45:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 69:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 172:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 84:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 51:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4[num7] = value;
		}
		return value;
	}

	static object _003F41_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x5DBC8B1Au ^ num;
		uint num3 = 1951550728u;
		uint num4 = 1845328396u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x2B6492DB;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x2B6492DBu;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x2B6492DBu;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 728011483;
			}
		}
		uint num7 = num2 ^ _003F80_003F;
		if (!_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4.TryGetValue(num7, out var value))
		{
			byte b;
			byte[] array;
			lock (_003F0_003F.풊_F522_E249땤锖蓌靏㚽)
			{
				BinaryReader binaryReader = new BinaryReader(_003F0_003F.풊_F522_E249땤锖蓌靏㚽);
				binaryReader.BaseStream.Seek(num7, SeekOrigin.Begin);
				b = binaryReader.ReadByte();
				array = binaryReader.ReadBytes(binaryReader.ReadInt32());
			}
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x1700000C ^ currentMethod.MetadataToken);
			uint num8 = (num7 + b) * 113363051;
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
			case 45:
				value = BitConverter.ToDouble(array, 0);
				break;
			case 69:
				value = BitConverter.ToSingle(array, 0);
				break;
			case 172:
				value = BitConverter.ToInt32(array, 0);
				break;
			case 84:
				value = BitConverter.ToInt64(array, 0);
				break;
			case 51:
				value = Encoding.UTF8.GetString(array);
				break;
			}
			_003F0_003F.㩢焦捴䒺牏Ẕ螁_07B4[num7] = value;
		}
		return value;
	}
}
