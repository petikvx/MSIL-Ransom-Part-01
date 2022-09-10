using System;
using System.Security.Principal;

namespace Microsoft.InfoCards;

internal class AccessibilityApplicationManager
{
	private const int WindowsVistaMajorVersion = 6;

	private IAccessibilityHelper m_helper;

	public AccessibilityApplicationManager()
	{
		bool fTabletPC = 0 != NativeMethods.GetSystemMetrics(86);
		if (Environment.OSVersion.Version.Major < 6)
		{
			m_helper = new AccessibilityHelperForXpWin2k3(fTabletPC);
		}
		else
		{
			m_helper = new AccessibilityHelperForVista(fTabletPC);
		}
	}

	public void Stop()
	{
		m_helper.Stop();
	}

	public void RestartOnInfoCardDesktop(uint userATApplicationFlags, SafeNativeHandle hTrustedUserToken, ref string trustedUserSid, string infocardDesktop, int userSessionId, uint userProcessId, WindowsIdentity userIdentity)
	{
		m_helper.RestartOnInfoCardDesktop(userATApplicationFlags, hTrustedUserToken, ref trustedUserSid, infocardDesktop, userSessionId, userProcessId, userIdentity);
	}

	public bool RestartOnUsersDesktop(uint userProcessId, string userDesktop, WindowsIdentity userIdentity)
	{
		return m_helper.RestartOnUsersDesktop(userProcessId, userDesktop, userIdentity);
	}
}
