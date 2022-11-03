using System;

namespace xClient.Core.MouseKeyHook.WinApi;

internal struct CallbackData
{
	private readonly IntPtr m_LParam;

	private readonly IntPtr m_WParam;

	public IntPtr WParam => m_WParam;

	public IntPtr LParam => m_LParam;

	public CallbackData(IntPtr wParam, IntPtr lParam)
	{
		m_WParam = wParam;
		m_LParam = lParam;
	}
}
