using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetImportFileNameRequest : UIAgentRequest
{
	private string m_filename = string.Empty;

	public GetImportFileNameRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
	}

	protected override void OnProcess()
	{
		if (base.ParentRequest is ImportRequest)
		{
			ImportRequest importRequest = base.ParentRequest as ImportRequest;
			m_filename = importRequest.ImportedFile;
			InfoCardTrace.Assert(!string.IsNullOrEmpty(m_filename), "No file name provided for import", new object[0]);
		}
		else
		{
			InfoCardTrace.Assert(false, "The parent of this request MUST be ImportRequest", new object[0]);
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter writer = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		Utility.SerializeString(writer, m_filename);
	}
}
