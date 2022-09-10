using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetCryptoTransformRequest : ClientRequest
{
	private int m_cryptoSession;

	private CipherMode m_mode;

	private PaddingMode m_padding;

	private int m_feedbackSize;

	private SymmetricCryptoSession.Direction m_direction;

	private byte[] m_iv;

	private TransformCryptoSession m_transformSession;

	public GetCryptoTransformRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cryptoSession = binaryReader.ReadInt32();
		m_mode = (CipherMode)binaryReader.ReadInt32();
		m_padding = (PaddingMode)binaryReader.ReadInt32();
		m_feedbackSize = binaryReader.ReadInt32();
		m_direction = (SymmetricCryptoSession.Direction)binaryReader.ReadInt32();
		m_iv = binaryReader.ReadBytes(binaryReader.ReadInt32());
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_feedbackSize, "feedbackSize");
	}

	protected override void OnProcess()
	{
		SymmetricCryptoSession symmetricCryptoSession = (SymmetricCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
		m_transformSession = symmetricCryptoSession.GetCryptoTransform(m_mode, m_padding, m_feedbackSize, m_direction, m_iv);
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		m_transformSession.Write(binaryWriter);
		binaryWriter.Flush();
	}
}
