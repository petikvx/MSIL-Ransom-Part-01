using System.IO;

namespace Microsoft.InfoCards;

internal class RemoteCryptoDecryptRequest : RpcCryptoRequest
{
	private byte[] m_buffer;

	private int m_index;

	private int m_length;

	private bool m_final;

	private int m_flags;

	private int m_hashAlg;

	private byte[] m_hash;

	public override string Name => "RpcCryptoDecryptRequest";

	public int Length => m_length;

	public int Index => m_index;

	public RemoteCryptoDecryptRequest(RpcCryptoContext context, int flags, bool final, byte[] buffer, int index, int length, int hashAlg, byte[] hashValue)
		: base(context)
	{
		m_buffer = buffer;
		m_length = length;
		m_index = index;
		m_flags = flags;
		m_final = final;
		m_hashAlg = hashAlg;
		m_hash = hashValue;
	}

	public byte[] GetBuffer()
	{
		return m_buffer;
	}

	protected override void MarshalOutArgs(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream);
		binaryWriter.Write(m_flags);
		binaryWriter.Write(m_final);
		binaryWriter.Write(m_length);
		binaryWriter.Write(m_buffer, m_index, m_length);
		binaryWriter.Write(m_hashAlg);
		Utility.SerializeBytes(binaryWriter, m_hash);
	}

	protected override void MarshalReturnArgs(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream);
		m_length = binaryReader.ReadInt32();
		binaryReader.Read(m_buffer, m_index, m_length);
	}
}
