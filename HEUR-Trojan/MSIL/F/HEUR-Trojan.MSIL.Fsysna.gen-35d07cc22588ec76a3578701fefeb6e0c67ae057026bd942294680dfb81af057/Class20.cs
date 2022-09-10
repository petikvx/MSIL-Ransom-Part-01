using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal static class Class20
{
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

	public unsafe static void smethod_0()
	{
		Module module = typeof(Class20).Module;
		IntPtr hINSTANCE = Marshal.GetHINSTANCE(module);
		if (hINSTANCE == (IntPtr)(-1))
		{
			Environment.FailFast("Module error");
		}
		bool flag = module.FullyQualifiedName != "<Unknown>";
		Stream stream = new UnmanagedMemoryStream((byte*)hINSTANCE.ToPointer(), 268435455L, 268435455L, FileAccess.ReadWrite);
		byte[] array;
		ulong num13;
		byte[] iv;
		byte[] dat;
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			stream.Seek(60L, SeekOrigin.Begin);
			uint num = binaryReader.ReadUInt32();
			stream.Seek(num, SeekOrigin.Begin);
			stream.Seek(6L, SeekOrigin.Current);
			uint num2 = binaryReader.ReadUInt16();
			stream.Seek(12L, SeekOrigin.Current);
			uint num3 = binaryReader.ReadUInt16();
			stream.Seek(num += 24, SeekOrigin.Begin);
			binaryReader.ReadUInt16();
			stream.Seek(62L, SeekOrigin.Current);
			_ = stream.Position;
			uint num4 = binaryReader.ReadUInt32() ^ 0x1CD0529Au;
			if (num4 == 483414682)
			{
				Environment.FailFast("Broken file");
			}
			stream.Seek(num += num3, SeekOrigin.Begin);
			uint num5 = 0u;
			for (int i = 0; i < num2; i++)
			{
				int num6 = 0;
				for (int j = 0; j < 8; j++)
				{
					byte b = binaryReader.ReadByte();
					if (b != 0)
					{
						num6 += b;
					}
				}
				uint num7 = binaryReader.ReadUInt32();
				uint num8 = binaryReader.ReadUInt32();
				binaryReader.ReadUInt32();
				uint num9 = binaryReader.ReadUInt32();
				if (num6 == 595)
				{
					num5 = (flag ? num8 : num9);
				}
				if (!flag && num4 > num8 && num4 < num8 + num7)
				{
					num4 = num4 - num8 + num9;
				}
				stream.Seek(16L, SeekOrigin.Current);
			}
			stream.Seek(num4, SeekOrigin.Begin);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				stream.Position += 12L;
				stream.Position += binaryReader.ReadUInt32() + 4;
				stream.Position += 2L;
				ushort num10 = binaryReader.ReadUInt16();
				for (int k = 0; k < num10; k++)
				{
					uint num11 = binaryReader.ReadUInt32() + num4;
					uint count = binaryReader.ReadUInt32();
					int num12 = 0;
					while (binaryReader.ReadByte() != 0)
					{
						num12++;
					}
					long position = (stream.Position += ((num12 + 1 + 3) & -4) - (num12 + 1));
					stream.Position = num11;
					memoryStream.Write(binaryReader.ReadBytes((int)count), 0, (int)count);
					stream.Position = position;
				}
				array = memoryStream.ToArray();
			}
			stream.Seek(num5, SeekOrigin.Begin);
			num13 = binaryReader.ReadUInt64() ^ 0xE4A61A59305AD41BuL;
			binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			iv = binaryReader.ReadBytes(binaryReader.ReadInt32() ^ 0x7E6EA36E);
			dat = binaryReader.ReadBytes(binaryReader.ReadInt32() ^ -1162432301);
		}
		byte[] value = MD5.Create().ComputeHash(array);
		ulong num14 = BitConverter.ToUInt64(value, 0) ^ BitConverter.ToUInt64(value, 8);
		if (num14 != num13)
		{
			Environment.FailFast("Broken file");
		}
		byte[] array2 = smethod_1(array, iv, dat);
		Buffer.BlockCopy(new byte[array.Length], 0, array, 0, array.Length);
		if (array2[0] != 214 || array2[1] != 111)
		{
			Environment.FailFast("Broken file");
		}
		byte[] array3 = new byte[array2.Length - 2];
		Buffer.BlockCopy(array2, 2, array3, 0, array3.Length);
		using BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array3));
		uint num15 = binaryReader2.ReadUInt32();
		int[] array4 = new int[num15];
		IntPtr[] array5 = new IntPtr[num15];
		for (int l = 0; l < num15; l++)
		{
			uint num16 = binaryReader2.ReadUInt32() ^ 0xCDE4F9B7u;
			if (num16 != 0)
			{
				uint num17 = binaryReader2.ReadUInt32() ^ 0x23710FB8u;
				byte[] array6 = binaryReader2.ReadBytes(binaryReader2.ReadInt32());
				IntPtr intPtr = (IntPtr)(uint)((int)hINSTANCE + (int)(flag ? num17 : num16));
				VirtualProtect(intPtr, (uint)array6.Length, 4u, out var lpflOldProtect);
				Marshal.Copy(array6, 0, intPtr, array6.Length);
				VirtualProtect(intPtr, (uint)array6.Length, lpflOldProtect, out lpflOldProtect);
				array4[l] = array6.Length;
				array5[l] = intPtr;
			}
		}
	}

	private static byte[] smethod_1(byte[] buff, byte[] iv, byte[] dat)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[dat.Length];
		MemoryStream stream = new MemoryStream(dat);
		using (CryptoStream cryptoStream = new CryptoStream(stream, rijndaelManaged.CreateDecryptor(SHA256.Create().ComputeHash(buff), iv), CryptoStreamMode.Read))
		{
			cryptoStream.Read(array, 0, dat.Length);
		}
		SHA512 sHA = SHA512.Create();
		byte[] array2 = sHA.ComputeHash(buff);
		for (int i = 0; i < array.Length; i += 64)
		{
			int num = ((array.Length <= i + 64) ? array.Length : (i + 64));
			for (int j = i; j < num; j++)
			{
				array[j] ^= (byte)(array2[j - i] ^ 0xDF);
			}
			array2 = sHA.ComputeHash(array, i, num - i);
		}
		return array;
	}
}
