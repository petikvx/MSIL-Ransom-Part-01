using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;
using Microsoft.Win32;

namespace Microsoft.InfoCards;

internal class AccessibilityHelperForXpWin2k3 : IDisposable, IAccessibilityHelper
{
	internal struct DownlevelAtData
	{
		public string RegistryPath;

		public string Image;

		public string AdditionalImage;

		public DownlevelAtData(string path, string image, string additional)
		{
			RegistryPath = path;
			Image = image;
			AdditionalImage = additional;
		}
	}

	private const int OSKIndex = 0;

	private static readonly string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);

	private static readonly string baseRegistryPath = "\\SOFTWARE\\Microsoft\\Utility Manager\\";

	private static readonly string keyName = "Start on locked desktop";

	internal static DownlevelAtData[] atApplications = new DownlevelAtData[3]
	{
		new DownlevelAtData("On-Screen Keyboard", "osk.exe", "msswchx"),
		new DownlevelAtData("Magnifier", "magnify.exe", null),
		new DownlevelAtData("Narrator", "narrator.exe", null)
	};

	private List<int> m_restartList = new List<int>();

	private ProcessManager m_manager;

	private bool m_fTabletPC;

	public AccessibilityHelperForXpWin2k3(bool fTabletPC)
	{
		m_fTabletPC = fTabletPC;
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
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			foreach (int restart in m_restartList)
			{
				string application = Path.Combine(systemPath, atApplications[restart].Image);
				int pid = 0;
				NativeMcppMethods.CreateProcessAsUserHelperWrapper(application, "", userProcessId, userDesktop, userIdentity.Name, ref pid);
			}
		}
		m_restartList.Clear();
		return false;
	}

	void IAccessibilityHelper.RestartOnInfoCardDesktop(uint ATApplicationFlags, SafeNativeHandle hTrustedUserToken, ref string trustedUserSid, string infocardDesktop, int userSessionId, uint userProcessId, WindowsIdentity userIdentity)
	{
		using (new SystemIdentity(throwIfAlreadySystem: false))
		{
			InfoCardTrace.Assert(null == m_manager, "The AT applications are already started", new object[0]);
			m_restartList.Clear();
			bool flag = false;
			string value = userIdentity.User!.Value;
			for (int i = 0; i < atApplications.Length; i++)
			{
				using RegistryKey registryKey = Registry.Users.OpenSubKey(value + baseRegistryPath + atApplications[i].RegistryPath);
				bool flag2 = false;
				int? num = null;
				if (registryKey != null && RegistryValueKind.DWord == registryKey.GetValueKind(keyName))
				{
					num = (int)registryKey.GetValue(keyName);
				}
				if ((!num.HasValue || 1 != num) && (!m_fTabletPC || i != 0))
				{
					continue;
				}
				Process[] processesByName = Process.GetProcessesByName(atApplications[i].Image.Substring(0, atApplications[i].Image.LastIndexOf('.')));
				foreach (Process process in processesByName)
				{
					flag2 = false;
					if (userSessionId == process.SessionId)
					{
						flag2 = true;
						m_restartList.Add(i);
						if (Utility.KillHelper(process))
						{
						}
						break;
					}
				}
				if (flag2 && atApplications[i].AdditionalImage != null)
				{
					Process[] processesByName2 = Process.GetProcessesByName(atApplications[i].AdditionalImage);
					foreach (Process process2 in processesByName2)
					{
						if (userSessionId == process2.SessionId && Utility.KillHelper(process2))
						{
							break;
						}
					}
				}
				if (!num.HasValue)
				{
					continue;
				}
				int? num2 = num;
				if (1 == num2.GetValueOrDefault() && num2.HasValue && ATApplicationFlags != 0)
				{
					string fullPath = Path.Combine(systemPath, atApplications[i].Image);
					if (m_manager == null)
					{
						m_manager = new ProcessManager(userSessionId, trustedUserSid);
					}
					m_manager.AddProcess(hTrustedUserToken, ref trustedUserSid, infocardDesktop, userProcessId, userIdentity, fullPath, "", fUseElevatedToken: false);
					if (i == 0)
					{
						flag = true;
					}
				}
			}
			if (m_fTabletPC && !flag)
			{
				if (m_manager == null)
				{
					m_manager = new ProcessManager(userSessionId, trustedUserSid);
				}
				m_manager.AddProcess(hTrustedUserToken, ref trustedUserSid, infocardDesktop, userProcessId, userIdentity, Path.Combine(systemPath, atApplications[0].Image), "", fUseElevatedToken: false);
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
