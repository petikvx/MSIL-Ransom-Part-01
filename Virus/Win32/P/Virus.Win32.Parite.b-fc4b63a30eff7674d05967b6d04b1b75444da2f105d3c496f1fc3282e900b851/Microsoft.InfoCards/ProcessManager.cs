using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ProcessManager : IDisposable
{
	private const int WindowsVistaMajorVersion = 6;

	private const string s_OnScreenKeyboardExeName = "osk";

	private const string s_SwitcherExeName = "msswchx";

	private const string s_TcserverExeName = "tcserver";

	private SafeJobHandle m_hJob;

	private List<Process> m_processList;

	private uint m_userSessionId;

	private string m_trustedUserSid;

	internal bool IsConsoleOrVista
	{
		get
		{
			if (m_userSessionId != NativeMethods.WTSGetActiveConsoleSessionId())
			{
				return Environment.OSVersion.Version.Major >= 6;
			}
			return true;
		}
	}

	internal bool IsXPTablet
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 6)
			{
				return 0 != NativeMethods.GetSystemMetrics(86);
			}
			return false;
		}
	}

	public ProcessManager(int userSessionId, string trustedUserSid)
	{
		m_hJob = null;
		m_userSessionId = (uint)userSessionId;
		m_processList = new List<Process>();
		m_trustedUserSid = trustedUserSid;
	}

	public void AddProcess(SafeNativeHandle hTrustedUserToken, ref string trustedUserSid, string infocardDesktop, uint userProcessId, WindowsIdentity userIdentity, string fullPath, string commandLine, bool fUseElevatedToken)
	{
		IntPtr processHandle = IntPtr.Zero;
		int pid = 0;
		bool success = false;
		bool success2 = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (IsConsoleOrVista && m_hJob == null)
			{
				m_hJob = Utility.CreateJobObjectWithSdHelper(trustedUserSid);
				if (m_hJob == null)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new Win32Exception(Marshal.GetLastWin32Error()));
				}
			}
			hTrustedUserToken.DangerousAddRef(ref success);
			IntPtr trustedUserToken = hTrustedUserToken.DangerousGetHandle();
			IntPtr jobHandle = IntPtr.Zero;
			if (IsConsoleOrVista)
			{
				m_hJob.DangerousAddRef(ref success2);
				jobHandle = m_hJob.DangerousGetHandle();
			}
			if (NativeMcppMethods.CreateProcessAsTrustedUserWrapper(fullPath, (commandLine == null) ? "" : commandLine, userProcessId, infocardDesktop, userIdentity.Name, m_userSessionId, ref trustedUserToken, ref processHandle, ref pid, jobHandle, ref trustedUserSid, fUseElevatedToken) != 0)
			{
				return;
			}
			using SafeNativeHandle safeNativeHandle = new SafeNativeHandle(processHandle, ownsHandle: true);
			if (!IsConsoleOrVista)
			{
				m_processList.Add(Process.GetProcessById(pid));
			}
			safeNativeHandle.Dispose();
		}
		finally
		{
			if (success)
			{
				hTrustedUserToken.DangerousRelease();
			}
			if (success2)
			{
				m_hJob.DangerousRelease();
			}
		}
	}

	public void Dispose()
	{
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			if (IsConsoleOrVista)
			{
				if (m_hJob != null)
				{
					m_hJob.Dispose();
					m_hJob = null;
				}
			}
			else
			{
				bool flag = false;
				for (int i = 0; i < m_processList.Count; i++)
				{
					Process process = m_processList[i];
					if (process.HasExited)
					{
						continue;
					}
					try
					{
						if (m_userSessionId == process.SessionId)
						{
							if (string.Compare(process.ProcessName, "osk", StringComparison.OrdinalIgnoreCase) == 0)
							{
								flag = true;
							}
							Utility.KillHelper(process);
						}
					}
					catch (InvalidOperationException)
					{
					}
				}
				if (flag)
				{
					Process[] processesByName = Process.GetProcessesByName("msswchx");
					foreach (Process process2 in processesByName)
					{
						if (m_userSessionId != process2.SessionId)
						{
							((IDisposable)process2).Dispose();
							continue;
						}
						if (!process2.HasExited)
						{
							Utility.KillHelper(process2);
						}
						break;
					}
				}
				m_processList.Clear();
			}
		}
		if (IsXPTablet)
		{
			KillTcserverInstancesForInfoCardDesktop();
		}
	}

	private void KillTcserverInstancesForInfoCardDesktop()
	{
		Process[] processesByName = Process.GetProcessesByName("tcserver");
		foreach (Process process in processesByName)
		{
			if (NativeMcppMethods.IsCardSpaceTcserverInstance(process.Id, m_trustedUserSid))
			{
				Utility.KillHelper(process);
			}
			((IDisposable)process).Dispose();
		}
	}
}
