using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class ManageRequest : ClientUIRequest
{
	public ManageRequest(Process callingProcess, WindowsIdentity callingIdentity, InfoCardUIAgent uiAgent, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, uiAgent, rpcHandle, inArgs, outArgs, InfoCardUIAgent.CallMode.Manage, ExceptionList.AllNonFatal)
	{
		if (0L != inArgs.Length)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(SR.GetString("ServiceRequestBufferLengthInvalid")));
		}
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		try
		{
			StartAndWaitForUIAgent();
		}
		catch (UserCancelledException)
		{
		}
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
