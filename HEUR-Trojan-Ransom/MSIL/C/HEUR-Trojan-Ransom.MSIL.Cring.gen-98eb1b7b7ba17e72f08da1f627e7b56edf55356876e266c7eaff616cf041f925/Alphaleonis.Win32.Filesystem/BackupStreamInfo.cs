namespace Alphaleonis.Win32.Filesystem;

public sealed class BackupStreamInfo
{
	private readonly long m_size;

	private readonly string m_name;

	private readonly STREAM_ID m_streamType;

	private readonly STREAM_ATTRIBUTES m_attributes;

	public long Size => m_size;

	public string Name => m_name;

	public STREAM_ID StreamType => m_streamType;

	public STREAM_ATTRIBUTES Attributes => m_attributes;

	internal BackupStreamInfo(NativeMethods.WIN32_STREAM_ID streamID, string name)
	{
		m_name = name;
		m_size = (long)streamID.Size;
		m_attributes = streamID.dwStreamAttributes;
		m_streamType = streamID.dwStreamId;
	}
}
