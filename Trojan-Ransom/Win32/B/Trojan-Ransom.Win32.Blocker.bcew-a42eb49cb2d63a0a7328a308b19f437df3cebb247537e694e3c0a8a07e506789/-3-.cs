using System;
using System.IO;
using System.Reflection;
using System.Text;

internal static class _003F3_003F
{
	static object _003F34_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x6C9F02E7u ^ num;
		uint num3 = 1643204539u;
		uint num4 = 2974119u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x6B542AD5;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x6B542AD5u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x6B542AD5u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 1800678101;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000006 ^ currentMethod.MetadataToken);
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

	static object _003F35_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x4A6C4141u ^ num;
		uint num3 = 612109412u;
		uint num4 = 867404721u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x19A2CE43;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x19A2CE43u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x19A2CE43u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 430100035;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000009 ^ currentMethod.MetadataToken);
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

	static object _003F36_003F(uint _003F79_003F, uint _003F80_003F)
	{
		MethodBase currentMethod = MethodBase.GetCurrentMethod();
		uint num = (uint)(currentMethod.MetadataToken ^ (currentMethod.DeclaringType!.MetadataToken * _003F79_003F));
		uint num2 = 0x727664CEu ^ num;
		uint num3 = 1151825770u;
		uint num4 = 714704613u;
		for (uint num5 = 1u; num5 <= 64; num5++)
		{
			num2 = ((num2 & 0xFFFFFF) << 8) | ((num2 & 0xFF000000u) >> 24);
			uint num6 = (num2 & 0xFF) % 64u;
			if (num6 >= 0 && num6 < 16)
			{
				num3 |= (((num2 & 0xFF00) >> 8) & ((num2 & 0xFF0000) >> 16)) ^ (~num2 & 0xFFu);
				num4 ^= (num2 * num5 + 1) % 16u;
				num2 += (num3 | num4) ^ 0x84F6373;
			}
			else if (num6 >= 16 && num6 < 32)
			{
				num3 ^= ((num2 & 0xFF00FF) << 8) ^ (((num2 & 0xFFFF00) >> 8) | (~num2 & 0xFFFFu));
				num4 += num2 * num5 % 32u;
				num2 |= (num3 + ~num4) & 0x84F6373u;
			}
			else if (num6 >= 32 && num6 < 48)
			{
				num3 += ((num2 & 0xFF) | ((num2 & 0xFF0000) >> 16)) + (~num2 & 0xFF);
				num4 -= ~(num2 + num6) % 48u;
				num2 ^= (num3 % num4) | 0x84F6373u;
			}
			else if (num6 >= 48 && num6 < 64)
			{
				num3 ^= (((num2 & 0xFF0000) >> 16) | ~(num2 & 0xFF)) * (~num2 & 0xFF0000);
				num4 += (num2 ^ (num5 - 1)) % num6;
				num2 -= ~(num3 ^ num4) + 139420531;
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
			byte[] array2 = Assembly.GetCallingAssembly().GetModule(currentMethod.Module.ScopeName)!.ResolveSignature(0x17000008 ^ currentMethod.MetadataToken);
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
