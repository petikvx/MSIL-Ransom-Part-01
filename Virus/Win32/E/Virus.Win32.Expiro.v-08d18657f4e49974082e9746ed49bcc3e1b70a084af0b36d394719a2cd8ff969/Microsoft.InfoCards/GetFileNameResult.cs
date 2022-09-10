namespace Microsoft.InfoCards;

internal class GetFileNameResult
{
	private string m_fileName;

	private byte[] m_fileContent;

	public string FileName
	{
		get
		{
			return m_fileName;
		}
		set
		{
			m_fileName = value;
		}
	}

	public byte[] FileContent
	{
		get
		{
			return m_fileContent;
		}
		set
		{
			m_fileContent = value;
		}
	}
}
