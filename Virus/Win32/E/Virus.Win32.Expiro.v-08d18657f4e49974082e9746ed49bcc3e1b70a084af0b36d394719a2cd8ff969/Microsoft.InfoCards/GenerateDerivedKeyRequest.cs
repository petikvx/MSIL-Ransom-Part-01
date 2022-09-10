using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;

namespace Microsoft.InfoCards;

internal class GenerateDerivedKeyRequest : ClientRequest
{
	private int m_sessionId;

	private byte[] m_label;

	private byte[] m_nonce;

	private int m_derivedKeyLength;

	private int m_offset;

	private string m_derivationAlgUri;

	private byte[] m_key;

	public GenerateDerivedKeyRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
		m_key = null;
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_sessionId = binaryReader.ReadInt32();
		int count = binaryReader.ReadInt32();
		m_label = binaryReader.ReadBytes(count);
		count = binaryReader.ReadInt32();
		m_nonce = binaryReader.ReadBytes(count);
		m_derivedKeyLength = binaryReader.ReadInt32();
		m_offset = binaryReader.ReadInt32();
		m_derivationAlgUri = Utility.DeserializeString(binaryReader);
	}

	protected override void OnProcess()
	{
		SymmetricCryptoSession symmetricCryptoSession = (SymmetricCryptoSession)CryptoSession.Find(m_sessionId, base.CallerPid, RequestorIdentity.User);
		m_key = symmetricCryptoSession.GenerateDerivedKey(m_derivationAlgUri, m_label, m_nonce, m_derivedKeyLength, m_offset);
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(m_key.Length);
		binaryWriter.Write(m_key);
	}
}
