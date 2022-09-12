using System;
using System.Collections.Generic;
using Renci.SshNet.Common;

namespace Renci.SshNet.Channels;

internal interface IChannelSession : IDisposable, IChannel
{
	void Open();

	bool SendPseudoTerminalRequest(string environmentVariable, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues);

	bool SendX11ForwardingRequest(bool isSingleConnection, string protocol, byte[] cookie, uint screenNumber);

	bool SendEnvironmentVariableRequest(string variableName, string variableValue);

	bool SendShellRequest();

	bool SendExecRequest(string command);

	bool SendBreakRequest(uint breakLength);

	bool SendSubsystemRequest(string subsystem);

	bool SendWindowChangeRequest(uint columns, uint rows, uint width, uint height);

	bool SendLocalFlowRequest(bool clientCanDo);

	bool SendSignalRequest(string signalName);

	bool SendExitStatusRequest(uint exitStatus);

	bool SendExitSignalRequest(string signalName, bool coreDumped, string errorMessage, string language);

	bool SendEndOfWriteRequest();

	bool SendKeepAliveRequest();
}
