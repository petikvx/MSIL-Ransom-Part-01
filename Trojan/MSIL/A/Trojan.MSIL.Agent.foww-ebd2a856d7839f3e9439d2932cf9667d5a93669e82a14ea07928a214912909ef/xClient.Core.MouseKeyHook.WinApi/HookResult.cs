using System;

namespace xClient.Core.MouseKeyHook.WinApi;

internal class HookResult : IDisposable
{
	private readonly Class9 m_Handle;

	private readonly GDelegate0 m_Procedure;

	public Class9 Handle => m_Handle;

	public GDelegate0 Procedure => m_Procedure;

	public HookResult(Class9 handle, GDelegate0 procedure)
	{
		m_Handle = handle;
		m_Procedure = procedure;
	}

	public void Dispose()
	{
		m_Handle.Dispose();
	}
}
