using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal class UIAgentAsyncParams : AsyncParams
{
	private UIAgentRequest m_agentRequest;

	public UIAgentRequest AgentRequest => m_agentRequest;

	public UIAgentAsyncParams(string opType, ClientRequest request, SafeWaitHandle externEvent, UIAgentRequest agentRequest)
		: base(request, opType, externEvent)
	{
		m_agentRequest = agentRequest;
	}
}
