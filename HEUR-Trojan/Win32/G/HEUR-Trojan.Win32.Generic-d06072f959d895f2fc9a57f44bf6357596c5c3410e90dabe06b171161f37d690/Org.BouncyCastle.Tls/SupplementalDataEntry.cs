namespace Org.BouncyCastle.Tls;

public sealed class SupplementalDataEntry
{
	private readonly int m_dataType;

	private readonly byte[] m_data;

	public int DataType => m_dataType;

	public byte[] Data => m_data;

	public SupplementalDataEntry(int dataType, byte[] data)
	{
		m_dataType = dataType;
		m_data = data;
	}
}
