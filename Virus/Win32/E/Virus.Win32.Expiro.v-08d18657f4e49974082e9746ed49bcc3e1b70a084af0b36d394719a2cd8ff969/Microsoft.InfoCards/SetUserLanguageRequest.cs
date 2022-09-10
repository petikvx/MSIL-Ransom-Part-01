using System;
using System.IO;
using System.Text;

namespace Microsoft.InfoCards;

internal class SetUserLanguageRequest : UIAgentRequest
{
	private int m_lcid;

	public SetUserLanguageRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnInitializeAsSystem()
	{
		base.OnInitializeAsSystem();
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_lcid = (int)binaryReader.ReadUInt32();
	}

	protected override void OnProcess()
	{
		base.ParentRequest.UserLanguage = m_lcid;
	}

	protected override void OnMarshalOutArgs()
	{
	}
}
