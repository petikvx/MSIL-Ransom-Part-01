using System;
using System.Runtime.InteropServices;

namespace ns12;

public static class GClass14
{
	public struct GStruct6
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public int int_0;

		public GStruct6(string pszAlgId, int cbSalt)
		{
			string_0 = pszAlgId;
			int_0 = cbSalt;
		}
	}

	public struct GStruct7 : IDisposable
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public int int_2;

		public IntPtr intptr_1;

		public int int_3;

		public IntPtr intptr_2;

		public int int_4;

		public IntPtr intptr_3;

		public int int_5;

		public int int_6;

		public long long_0;

		public int int_7;

		public GStruct7(byte[] iv, byte[] aad, byte[] tag)
		{
			this = default(GStruct7);
			int_1 = GClass14.int_1;
			int_0 = Marshal.SizeOf(typeof(GStruct7));
			if (iv != null)
			{
				int_2 = iv.Length;
				intptr_0 = Marshal.AllocHGlobal(int_2);
				Marshal.Copy(iv, 0, intptr_0, int_2);
			}
			if (aad != null)
			{
				int_3 = aad.Length;
				intptr_1 = Marshal.AllocHGlobal(int_3);
				Marshal.Copy(aad, 0, intptr_1, int_3);
			}
			if (tag != null)
			{
				int_4 = tag.Length;
				intptr_2 = Marshal.AllocHGlobal(int_4);
				Marshal.Copy(tag, 0, intptr_2, int_4);
				int_5 = tag.Length;
				intptr_3 = Marshal.AllocHGlobal(int_5);
			}
		}

		public void Dispose()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
			}
			if (intptr_2 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_2);
			}
			if (intptr_1 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_1);
			}
			if (intptr_3 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_3);
			}
		}
	}

	public struct GStruct8
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	public struct GStruct9
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public IntPtr intptr_0;

		public int int_0;

		public GStruct9(string alg)
		{
			string_0 = alg;
			intptr_0 = IntPtr.Zero;
			int_0 = 0;
		}
	}

	public const uint uint_0 = 0u;

	public const uint uint_1 = 8u;

	public const uint uint_2 = 4u;

	public static readonly byte[] byte_0 = BitConverter.GetBytes(1296188491);

	public static readonly string string_0 = "ObjectLength";

	public static readonly string string_1 = "ChainingModeGCM";

	public static readonly string string_2 = "AuthTagLength";

	public static readonly string string_3 = "ChainingMode";

	public static readonly string string_4 = "KeyDataBlob";

	public static readonly string string_5 = "AES";

	public static readonly string string_6 = "Microsoft Primitive Provider";

	public static readonly int int_0 = 1;

	public static readonly int int_1 = 1;

	public static readonly uint uint_3 = 3221266434u;

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, [MarshalAs(UnmanagedType.LPWStr)] string string_8, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr intptr_0, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, ref int int_3, uint uint_4);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptSetProperty(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_7, byte[] byte_1, int int_2, int int_3);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr intptr_0, IntPtr intptr_1, [MarshalAs(UnmanagedType.LPWStr)] string string_7, out IntPtr intptr_2, IntPtr intptr_3, int int_2, byte[] byte_1, int int_3, uint uint_4);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr intptr_0);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptEncrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct7 gstruct7_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, uint uint_4);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr intptr_0, byte[] byte_1, int int_2, ref GStruct7 gstruct7_0, byte[] byte_2, int int_3, byte[] byte_3, int int_4, ref int int_5, int int_6);
}
