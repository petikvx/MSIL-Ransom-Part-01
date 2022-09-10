using System.IO;

namespace Microsoft.InfoCards;

internal class RemoteCryptoSignHashRequest : RpcCryptoRequest
{
	private byte[] m_signature;

	private byte[] m_hash;

	private int m_hashType;

	private int m_flags;

	public override string Name => "RpcCryptoSignHashRequest";

	public RemoteCryptoSignHashRequest(RpcCryptoContext context, int hashType, int flags, byte[] hash)
		: base(context)
	{
		m_hash = hash;
		m_hashType = hashType;
		m_flags = flags;
	}

	public byte[] GetSignature()
	{
		return m_signature;
	}

	protected override void MarshalOutArgs(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream);
		binaryWriter.Write(m_hashType);
		binaryWriter.Write(m_flags);
		binaryWriter.Write(m_hash.Length);
		binaryWriter.Write(m_hash, 0, m_hash.Length);
	}

	protected override void MarshalReturnArgs(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream);
		m_signature = binaryReader.ReadBytes(binaryReader.ReadInt32());
	}
}
