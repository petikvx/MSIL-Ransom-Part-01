using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32;

namespace Microsoft.InfoCards;

internal class AccessibilityHelperForVista : IDisposable, IAccessibilityHelper
{
	private static readonly string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);

	private static readonly string progfilePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);

	private static readonly string baseATPath = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Accessibility\\ATs";

	private static readonly string configPath = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Accessibility\\Session";

	private List<string> m_applicationList = new List<string>();

	private ProcessManager m_manager;

	private bool m_fResetConfigKey;

	private int m_sessionId;

	private bool m_fTabletPC;

	public AccessibilityHelperForVista(bool fTabletPC)
	{
		m_fTabletPC = fTabletPC;
		InitializeATAppData();
	}

	private void InitializeATAppData()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(baseATPath);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		foreach (string name in subKeyNames)
		{
			RegistryKey registryKey2 = registryKey.OpenSubKey(name);
			string text = (string)registryKey2.GetValue("ATExe");
			if (!string.IsNullOrEmpty(text))
			{
				m_applicationList.Add(text);
			}
		}
	}

	void IAccessibilityHelper.Stop()
	{
		if (m_manager != null)
		{
			m_manager.Dispose();
			m_manager = null;
		}
	}

	bool IAccessibilityHelper.RestartOnUsersDesktop(uint userProcessId, string userDesktop, WindowsIdentity userIdentity)
	{
		InfoCardTrace.Assert(null == m_manager, "The AT applications must be terminated before they can be restarted", new object[0]);
		if (m_fResetConfigKey)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(configPath + m_sessionId, writable: true);
			string value = "";
			registryKey.SetValue("Configuration", value);
			m_fResetConfigKey = false;
			return true;
		}
		return false;
	}

	void IAccessibilityHelper.RestartOnInfoCardDesktop(uint userATApplicationFlags, SafeNativeHandle hTrustedUserToken, ref string trustedUserSid, string infocardDesktop, int userSessionId, uint userProcessId, WindowsIdentity userIdentity)
	{
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			InfoCardTrace.Assert(null == m_manager, "The AT applications are already started", new object[0]);
			m_fResetConfigKey = false;
			m_sessionId = userSessionId;
			_ = userIdentity.User!.Value;
			for (int i = 0; i < m_applicationList.Count; i++)
			{
				string text = m_applicationList[i];
				Process[] processesByName = Process.GetProcessesByName(text.Substring(0, text.LastIndexOf('.')));
				if (processesByName == null)
				{
					continue;
				}
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					if (userSessionId == process.SessionId)
					{
						m_fResetConfigKey = true;
						if (Utility.KillHelper(process))
						{
						}
						break;
					}
				}
			}
			if (m_manager == null)
			{
				m_manager = new ProcessManager(userSessionId, trustedUserSid);
			}
			string fullPath = Path.Combine(systemPath, "AtBroker.exe");
			if (userATApplicationFlags != 0)
			{
				m_manager.AddProcess(hTrustedUserToken, ref trustedUserSid, infocardDesktop, userProcessId, userIdentity, fullPath, "", fUseElevatedToken: false);
			}
			if (m_fTabletPC)
			{
				fullPath = Path.Combine(progfilePath, "microsoft shared\\ink\\tabtip.exe");
				m_manager.AddProcess(hTrustedUserToken, ref trustedUserSid, infocardDesktop, userProcessId, userIdentity, fullPath, "/SeekDesktop:", fUseElevatedToken: true);
			}
		}
	}

	public void Dispose()
	{
		if (m_manager != null)
		{
			m_manager.Dispose();
			m_manager = null;
		}
	}
}
