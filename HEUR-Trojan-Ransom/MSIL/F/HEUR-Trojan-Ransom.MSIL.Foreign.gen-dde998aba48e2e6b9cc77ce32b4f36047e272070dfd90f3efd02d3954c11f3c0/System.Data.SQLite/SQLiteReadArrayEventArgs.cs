namespace System.Data.SQLite;

public sealed class SQLiteReadArrayEventArgs : SQLiteReadEventArgs
{
	private long dataOffset;

	private byte[] byteBuffer;

	private char[] charBuffer;

	private int bufferOffset;

	private int length;

	public long DataOffset
	{
		get
		{
			return dataOffset;
		}
		set
		{
			dataOffset = value;
		}
	}

	public byte[] ByteBuffer => byteBuffer;

	public char[] CharBuffer => charBuffer;

	public int BufferOffset
	{
		get
		{
			return bufferOffset;
		}
		set
		{
			bufferOffset = value;
		}
	}

	public int Length
	{
		get
		{
			return length;
		}
		set
		{
			length = value;
		}
	}

	internal SQLiteReadArrayEventArgs(long dataOffset, byte[] byteBuffer, int bufferOffset, int length)
	{
		this.dataOffset = dataOffset;
		this.byteBuffer = byteBuffer;
		this.bufferOffset = bufferOffset;
		this.length = length;
	}

	internal SQLiteReadArrayEventArgs(long dataOffset, char[] charBuffer, int bufferOffset, int length)
	{
		this.dataOffset = dataOffset;
		this.charBuffer = charBuffer;
		this.bufferOffset = bufferOffset;
		this.length = length;
	}
}
