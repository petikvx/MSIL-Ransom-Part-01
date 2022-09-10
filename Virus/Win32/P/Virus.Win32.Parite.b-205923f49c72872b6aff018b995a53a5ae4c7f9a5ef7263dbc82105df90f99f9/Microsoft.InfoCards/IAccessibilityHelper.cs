using System.Security.Principal;

namespace Microsoft.InfoCards;

internal interface IAccessibilityHelper
{
	void Stop();

	void RestartOnInfoCardDesktop(uint userATApplicationFlags, SafeNativeHandle hTrustedUserToken, ref string trustedUserSid, string infocardDesktop, int userSessionId, uint userProcessId, WindowsIdentity userIdentity);

	bool RestartOnUsersDesktop(uint userProcessId, string userDesktop, WindowsIdentity userIdentity);
}
