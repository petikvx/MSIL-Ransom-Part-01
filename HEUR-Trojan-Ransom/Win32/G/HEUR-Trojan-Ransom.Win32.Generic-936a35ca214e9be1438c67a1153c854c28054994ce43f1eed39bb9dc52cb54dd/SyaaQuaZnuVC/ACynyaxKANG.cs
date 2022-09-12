using System;
using System.Runtime.InteropServices;

namespace SyaaQuaZnuVC;

public class ACynyaxKANG
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct gFXESaSNIgB
	{
		public uint ZQjkWQUXOubEn;

		public eTFxVOhXlqYbs qPduRPCPIII;

		public eTFxVOhXlqYbs HHkybiUYlGFK;

		public eTFxVOhXlqYbs GXJkYPblhSH;

		public uint ehZhxLPhZm;

		public uint VCcbufrEhqrKds;

		public uint LhbixBroJxuzAIj;

		public uint OomASuMbMqeggJ;

		public uint nrScwUqkPvZhrK;

		public uint NorsNGuMhonayJFq;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct eTFxVOhXlqYbs
	{
		public uint aFGcVypPVOdzG;

		public uint vjfJVCtJXAV;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct quVHmTTreMtirFh
	{
		public ulong JlqOPRGTjKe;

		public long RcmrbDqTBaqG;

		public long hxtWZKgxpP;

		public long TSXLsiGcHXS;

		public long FOJJyJfNCMDsMV;

		public ulong GxKkxpUknqoWn;

		public ulong qyAPsgAMIfOEHRJ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct fJTIdcOVqQFS
	{
		public ulong NCeaBAEDabVfyT;

		public long ZQFBhskpGj;

		public long llDpsSAKiXEd;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct adccExBvjiko
	{
		public ulong GxKkxpUknqoWn;

		public ulong qyAPsgAMIfOEHRJ;
	}

	public class FHqOuUDnubU
	{
		public uint ZQjkWQUXOubEn;

		public string WnqumptOpuqWjJ = string.Empty;

		public int DkbcYPVwjwRl;

		public int JwWsXMDxwFZ;

		public ulong QMGiDtZOpd;

		public ulong wRUEYcpoPDUDML;

		public uint TUIxTXrhCZEwhGC;

		public FHqOuUDnubU(IntPtr intptr_0)
		{
			TUIxTXrhCZEwhGC = (uint)Marshal.ReadInt32(intptr_0);
			QMGiDtZOpd = (ulong)Marshal.ReadInt64(intptr_0, 8);
			wRUEYcpoPDUDML = (ulong)Marshal.ReadInt64(intptr_0, 16);
			ZQjkWQUXOubEn = (uint)Marshal.ReadInt32(intptr_0, 52);
			DkbcYPVwjwRl = Marshal.ReadInt16(intptr_0, 56);
			JwWsXMDxwFZ = Marshal.ReadInt16(intptr_0, 58);
			WnqumptOpuqWjJ = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + JwWsXMDxwFZ), DkbcYPVwjwRl / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr GYktASrPyQAkzeiT, out gFXESaSNIgB qjACfiCwOUtqaX);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr fDreCglTjYTfe);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr mfodKTOCaJdMX, uint LLjTnzgysZHO, IntPtr KbTWwcyJIKHU, int GwjJpivvTNa, out quVHmTTreMtirFh roJTceYKHgGC, int csOvoIGloKtkE, out uint VXDfzqLiRE, IntPtr CUtnIDxnWpYd);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr qGkASdfPtJE, uint IqNRoeFPTTfyun, IntPtr pAbzzNaFgsrlX, int FztgWQucmi, IntPtr lLdSyBcMlqtKU, int ILFLZPyeYLPs, out uint uGYeVCcnanrl, IntPtr dFcHYLgcPma);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
