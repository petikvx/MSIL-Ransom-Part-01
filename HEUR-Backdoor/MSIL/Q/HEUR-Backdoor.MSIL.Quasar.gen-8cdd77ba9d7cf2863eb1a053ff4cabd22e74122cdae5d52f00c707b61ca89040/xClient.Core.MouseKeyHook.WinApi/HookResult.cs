using System;

namespace xClient.Core.MouseKeyHook.WinApi;

internal class HookResult : IDisposable
{
	private readonly HookProcedureHandle m_Handle;

	private readonly HookProcedure m_Procedure;

	public HookProcedureHandle Handle => m_Handle;

	public HookProcedure Procedure => m_Procedure;

	public HookResult(HookProcedureHandle handle, HookProcedure procedure)
	{
		m_Handle = handle;
		m_Procedure = procedure;
	}

	public void Dispose()
	{
		m_Handle.Dispose();
	}
}
