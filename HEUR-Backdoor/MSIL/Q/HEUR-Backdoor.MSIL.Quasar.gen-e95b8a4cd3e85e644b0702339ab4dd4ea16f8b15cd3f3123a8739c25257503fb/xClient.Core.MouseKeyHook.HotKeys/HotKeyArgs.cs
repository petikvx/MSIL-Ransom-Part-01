using System;

namespace xClient.Core.MouseKeyHook.HotKeys;

public sealed class HotKeyArgs : EventArgs
{
	private readonly DateTime m_TimeOfExecution;

	public DateTime Time => m_TimeOfExecution;

	public HotKeyArgs(DateTime triggeredAt)
	{
		m_TimeOfExecution = triggeredAt;
	}
}
