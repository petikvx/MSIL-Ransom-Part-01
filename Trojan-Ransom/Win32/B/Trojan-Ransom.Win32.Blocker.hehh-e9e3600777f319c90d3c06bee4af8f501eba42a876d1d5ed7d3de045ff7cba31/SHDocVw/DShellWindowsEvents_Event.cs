using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[ComEventInterface(typeof(DShellWindowsEvents), typeof(DShellWindowsEvents_EventProvider))]
[ComVisible(false)]
public interface DShellWindowsEvents_Event
{
	event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;

	event DShellWindowsEvents_WindowRevokedEventHandler WindowRevoked;
}
