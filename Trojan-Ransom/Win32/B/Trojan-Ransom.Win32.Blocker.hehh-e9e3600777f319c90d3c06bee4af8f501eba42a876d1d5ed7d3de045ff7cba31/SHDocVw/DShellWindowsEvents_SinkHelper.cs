using System.Runtime.InteropServices;

namespace SHDocVw;

[ClassInterface(ClassInterfaceType.None)]
[TypeLibType(TypeLibTypeFlags.FHidden)]
public sealed class DShellWindowsEvents_SinkHelper : DShellWindowsEvents
{
	public DShellWindowsEvents_WindowRegisteredEventHandler m_WindowRegisteredDelegate;

	public DShellWindowsEvents_WindowRevokedEventHandler m_WindowRevokedDelegate;

	public int m_dwCookie;

	public override void WindowRegistered(int param0)
	{
		if (m_WindowRegisteredDelegate != null)
		{
			m_WindowRegisteredDelegate(param0);
		}
	}

	public override void WindowRevoked(int param0)
	{
		if (m_WindowRevokedDelegate != null)
		{
			m_WindowRevokedDelegate(param0);
		}
	}

	internal DShellWindowsEvents_SinkHelper()
	{
		m_dwCookie = 0;
		m_WindowRegisteredDelegate = null;
		m_WindowRevokedDelegate = null;
	}
}
