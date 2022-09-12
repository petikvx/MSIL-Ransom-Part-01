using System;
using System.IO;
using System.Text;

namespace MySql.Data.MySqlClient;

internal class MySqlStream
{
	private byte sequenceByte;

	private int maxBlockSize;

	private ulong maxPacketSize;

	private byte[] packetHeader = new byte[4];

	private MySqlPacket packet;

	private TimedStream timedStream;

	private Stream inStream;

	private Stream outStream;

	internal Stream BaseStream => timedStream;

	public Encoding Encoding
	{
		get
		{
			return packet.Encoding;
		}
		set
		{
			packet.Encoding = value;
		}
	}

	public byte SequenceByte
	{
		get
		{
			return sequenceByte;
		}
		set
		{
			sequenceByte = value;
		}
	}

	public int MaxBlockSize
	{
		get
		{
			return maxBlockSize;
		}
		set
		{
			maxBlockSize = value;
		}
	}

	public ulong MaxPacketSize
	{
		get
		{
			return maxPacketSize;
		}
		set
		{
			maxPacketSize = value;
		}
	}

	public MySqlStream(Encoding encoding)
	{
		maxPacketSize = ulong.MaxValue;
		maxBlockSize = int.MaxValue;
		packet = new MySqlPacket(encoding);
	}

	public MySqlStream(Stream baseStream, Encoding encoding, bool compress)
		: this(encoding)
	{
		timedStream = new TimedStream(baseStream);
		outStream = (inStream = ((!compress) ? ((Stream)timedStream) : ((Stream)new CompressedStream(timedStream))));
	}

	public void Close()
	{
		outStream.Dispose();
		inStream.Dispose();
		timedStream.Close();
	}

	public void ResetTimeout(int timeout)
	{
		timedStream.ResetTimeout(timeout);
	}

	public MySqlPacket ReadPacket()
	{
		LoadPacket();
		if (packet.Buffer[0] == byte.MaxValue)
		{
			packet.ReadByte();
			int errno = packet.ReadInteger(2);
			string empty = string.Empty;
			empty = ((!packet.Version.isAtLeast(5, 5, 0)) ? packet.ReadString() : packet.ReadString(Encoding.UTF8));
			if (empty.StartsWith("#", StringComparison.Ordinal))
			{
				empty.Substring(1, 5);
				empty = empty.Substring(6);
			}
			throw new MySqlException(empty, errno);
		}
		return packet;
	}

	internal static void ReadFully(Stream stream, byte[] buffer, int offset, int count)
	{
		int num = 0;
		int num2 = count;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = stream.Read(buffer, offset + num, num2);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num2 -= num3;
				continue;
			}
			return;
		}
		throw new EndOfStreamException();
	}

	public void LoadPacket()
	{
		try
		{
			packet.Length = 0;
			int num = 0;
			int num2;
			do
			{
				ReadFully(inStream, packetHeader, 0, 4);
				sequenceByte = (byte)(packetHeader[3] + 1);
				num2 = packetHeader[0] + (packetHeader[1] << 8) + (packetHeader[2] << 16);
				packet.Length += num2;
				ReadFully(inStream, packet.Buffer, num, num2);
				num += num2;
			}
			while (num2 >= maxBlockSize);
			packet.Position = 0;
		}
		catch (IOException inner)
		{
			throw new MySqlException(Resources.ReadFromStreamFailed, isFatal: true, inner);
		}
	}

	public void SendPacket(MySqlPacket packet)
	{
		byte[] buffer = packet.Buffer;
		int num = packet.Position - 4;
		if ((ulong)num > maxPacketSize)
		{
			throw new MySqlException(Resources.QueryTooLarge, 1153);
		}
		int num2 = 0;
		do
		{
			int num3 = ((num <= maxBlockSize) ? num : maxBlockSize);
			buffer[num2] = (byte)((uint)num3 & 0xFFu);
			buffer[num2 + 1] = (byte)((uint)(num3 >> 8) & 0xFFu);
			buffer[num2 + 2] = (byte)((uint)(num3 >> 16) & 0xFFu);
			buffer[num2 + 3] = sequenceByte++;
			outStream.Write(buffer, num2, num3 + 4);
			outStream.Flush();
			num -= num3;
			num2 += num3;
		}
		while (num > 0);
	}

	public void SendEntirePacketDirectly(byte[] buffer, int count)
	{
		buffer[0] = (byte)((uint)count & 0xFFu);
		buffer[1] = (byte)((uint)(count >> 8) & 0xFFu);
		buffer[2] = (byte)((uint)(count >> 16) & 0xFFu);
		buffer[3] = sequenceByte++;
		outStream.Write(buffer, 0, count + 4);
		outStream.Flush();
	}
}
