using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SendAgentStatusRequest : UIAgentRequest
{
	public enum AgentStatusType
	{
		AGENT_INITIALIZING,
		AGENT_DESKTOP_CREATED,
		AGENT_DESKTOP_SWITCH_OUT,
		AGENT_DESKTOP_SWITCH_IN,
		AGENT_SHUTTING_DOWN
	}

	private AgentStatusType m_agentStatus;

	private bool m_retVal;

	private uint m_ATApplicationsFlags;

	public SendAgentStatusRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parentRequest)
		: base(rpcHandle, inArgs, outArgs, parentRequest)
	{
	}

	protected override void OnMarshalInArgs()
	{
		InfoCardTrace.Assert(base.InArgs.Length > 0L, "The agent status must be specified", new object[0]);
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_agentStatus = (AgentStatusType)binaryReader.ReadUInt32();
		m_ATApplicationsFlags = binaryReader.ReadUInt32();
	}

	protected override void OnProcess()
	{
		m_retVal = false;
		switch (m_agentStatus)
		{
		case AgentStatusType.AGENT_DESKTOP_SWITCH_OUT:
			m_retVal = base.ParentRequest.RestartAccessibilityApplications();
			break;
		case AgentStatusType.AGENT_DESKTOP_CREATED:
		case AgentStatusType.AGENT_DESKTOP_SWITCH_IN:
			base.ParentRequest.StartAccessibilityApplications(m_ATApplicationsFlags);
			break;
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(m_retVal);
	}
}
