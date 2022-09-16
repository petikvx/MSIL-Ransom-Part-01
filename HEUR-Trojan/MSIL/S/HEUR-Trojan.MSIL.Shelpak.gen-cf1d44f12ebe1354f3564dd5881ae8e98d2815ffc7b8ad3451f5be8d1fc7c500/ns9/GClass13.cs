using System;
using System.Runtime.InteropServices;

namespace ns9;

public static class GClass13
{
	public enum GEnum3
	{
		const_0 = -1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14
	}

	public enum GEnum4
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 100,
		const_7 = 10000
	}

	public struct GStruct3
	{
		public Guid guid_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public ulong ulong_0;

		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_5;
	}

	public struct GStruct4
	{
		public Guid guid_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public ulong ulong_0;

		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_4;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct GStruct5
	{
		[FieldOffset(0)]
		public GEnum4 genum4_0;

		[FieldOffset(8)]
		public GEnum3 genum3_0;
	}

	[DllImport("vaultcli.dll")]
	public static extern int VaultOpenVault(ref Guid guid_0, uint uint_0, ref IntPtr intptr_0);

	[DllImport("vaultcli.dll")]
	public static extern int VaultCloseVault(ref IntPtr intptr_0);

	[DllImport("vaultcli.dll")]
	public static extern int VaultFree(ref IntPtr intptr_0);

	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateVaults(int int_0, ref int int_1, ref IntPtr intptr_0);

	[DllImport("vaultcli.dll")]
	public static extern int VaultEnumerateItems(IntPtr intptr_0, int int_0, ref int int_1, ref IntPtr intptr_1);

	[DllImport("vaultcli.dll")]
	public static extern int VaultGetItem(IntPtr intptr_0, ref Guid guid_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, int int_0, ref IntPtr intptr_5);

	[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
	public static extern int VaultGetItem_1(IntPtr intptr_0, ref Guid guid_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, int int_0, ref IntPtr intptr_4);
}
