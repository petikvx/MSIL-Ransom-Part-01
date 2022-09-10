using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class GetLastErrorDetailsRequest : UIAgentRequest
{
	public GetLastErrorDetailsRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(base.ParentRequest is GetBrowserTokenRequest);
		int value = -1073413888;
		Exception ex = base.ParentRequest.ProcessingException;
		if (ex != null)
		{
			Exception ex2 = null;
			while (ex is InfoCardBaseException)
			{
				ex2 = ex;
				if (ex.InnerException == null)
				{
					break;
				}
				ex = ex.InnerException;
			}
			if (ex2 != null)
			{
				value = ((InfoCardBaseException)((ex2 is InfoCardBaseException) ? ex2 : null)).get_NativeHResult();
			}
		}
		binaryWriter.Write(value);
	}
}
