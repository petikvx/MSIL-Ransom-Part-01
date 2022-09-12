using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using MySql.Data.MySqlClient;

namespace MySql.Data.Common;

internal class SharedMemoryStream : Stream
{
	private string memoryName;

	private EventWaitHandle serverRead;

	private EventWaitHandle serverWrote;

	private EventWaitHandle clientRead;

	private EventWaitHandle clientWrote;

	private EventWaitHandle connectionClosed;

	private SharedMemory data;

	private int bytesLeft;

	private int position;

	private int connectNumber;

	private const int BUFFERLENGTH = 16004;

	private int readTimeout = -1;

	private int writeTimeout = -1;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

	public override long Length
	{
		get
		{
			throw new NotSupportedException("SharedMemoryStream does not support seeking - length");
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException("SharedMemoryStream does not support seeking - position");
		}
		set
		{
		}
	}

	public override bool CanTimeout => true;

	public override int ReadTimeout
	{
		get
		{
			return readTimeout;
		}
		set
		{
			readTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return writeTimeout;
		}
		set
		{
			writeTimeout = value;
		}
	}

	public SharedMemoryStream(string memName)
	{
		memoryName = memName;
	}

	public void Open(uint timeOut)
	{
		GetConnectNumber(timeOut);
		SetupEvents();
	}

	public override void Close()
	{
		if (connectionClosed == null)
		{
			return;
		}
		if (!connectionClosed.WaitOne(0))
		{
			connectionClosed.Set();
			connectionClosed.Close();
		}
		connectionClosed = null;
		EventWaitHandle[] array = new EventWaitHandle[4] { serverRead, serverWrote, clientRead, clientWrote };
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				array[i].Close();
			}
		}
		if (data != null)
		{
			data.Dispose();
			data = null;
		}
	}

	private void GetConnectNumber(uint timeOut)
	{
		EventWaitHandle eventWaitHandle;
		try
		{
			eventWaitHandle = EventWaitHandle.OpenExisting(memoryName + "_CONNECT_REQUEST");
		}
		catch (Exception)
		{
			string text = "Global\\" + memoryName;
			eventWaitHandle = EventWaitHandle.OpenExisting(text + "_CONNECT_REQUEST");
			memoryName = text;
		}
		EventWaitHandle eventWaitHandle2 = EventWaitHandle.OpenExisting(memoryName + "_CONNECT_ANSWER");
		using SharedMemory sharedMemory = new SharedMemory(memoryName + "_CONNECT_DATA", (IntPtr)4);
		if (!eventWaitHandle.Set())
		{
			throw new MySqlException("Failed to open shared memory connection");
		}
		if (!eventWaitHandle2.WaitOne((int)(timeOut * 1000), exitContext: false))
		{
			throw new MySqlException("Timeout during connection");
		}
		connectNumber = Marshal.ReadInt32(sharedMemory.View);
	}

	private void SetupEvents()
	{
		string text = memoryName + "_" + connectNumber;
		data = new SharedMemory(text + "_DATA", (IntPtr)16004);
		serverWrote = EventWaitHandle.OpenExisting(text + "_SERVER_WROTE");
		serverRead = EventWaitHandle.OpenExisting(text + "_SERVER_READ");
		clientWrote = EventWaitHandle.OpenExisting(text + "_CLIENT_WROTE");
		clientRead = EventWaitHandle.OpenExisting(text + "_CLIENT_READ");
		connectionClosed = EventWaitHandle.OpenExisting(text + "_CONNECTION_CLOSED");
		serverRead.Set();
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = readTimeout;
		WaitHandle[] array = new WaitHandle[2] { serverWrote, connectionClosed };
		LowResolutionStopwatch lowResolutionStopwatch = new LowResolutionStopwatch();
		int num3;
		while (true)
		{
			if (bytesLeft == 0)
			{
				lowResolutionStopwatch.Start();
				int num2 = WaitHandle.WaitAny(array, num);
				lowResolutionStopwatch.Stop();
				if (num2 != 258)
				{
					if (array[num2] != connectionClosed)
					{
						if (readTimeout != -1)
						{
							num = readTimeout - (int)lowResolutionStopwatch.ElapsedMilliseconds;
							if (num < 0)
							{
								throw new TimeoutException("Timeout when reading from shared memory");
							}
						}
						bytesLeft = Marshal.ReadInt32(data.View);
						position = 4;
						continue;
					}
					throw new MySqlException("Connection to server lost", isFatal: true, null);
				}
				throw new TimeoutException("Timeout when reading from shared memory");
			}
			num3 = Math.Min(count, bytesLeft);
			long num4 = data.View.ToInt64() + position;
			int num5 = 0;
			while (num5 < num3)
			{
				buffer[offset + num5] = Marshal.ReadByte((IntPtr)(num4 + num5));
				num5++;
				position++;
			}
			bytesLeft -= num3;
			if (bytesLeft == 0)
			{
				clientRead.Set();
			}
			break;
		}
		return num3;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("SharedMemoryStream does not support seeking");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		int num = count;
		int num2 = offset;
		WaitHandle[] array = new WaitHandle[2] { serverRead, connectionClosed };
		LowResolutionStopwatch lowResolutionStopwatch = new LowResolutionStopwatch();
		int num3 = writeTimeout;
		do
		{
			if (num <= 0)
			{
				return;
			}
			lowResolutionStopwatch.Start();
			int num4 = WaitHandle.WaitAny(array, num3);
			lowResolutionStopwatch.Stop();
			if (array[num4] != connectionClosed)
			{
				if (num4 != 258)
				{
					if (writeTimeout != -1)
					{
						num3 = writeTimeout - (int)lowResolutionStopwatch.ElapsedMilliseconds;
						if (num3 < 0)
						{
							throw new TimeoutException("Timeout when writing to shared memory");
						}
					}
					int num5 = Math.Min(num, 16004);
					long num6 = data.View.ToInt64() + 4L;
					Marshal.WriteInt32(data.View, num5);
					Marshal.Copy(buffer, num2, (IntPtr)num6, num5);
					num2 += num5;
					num -= num5;
					continue;
				}
				throw new TimeoutException("Timeout when reading from shared memory");
			}
			throw new MySqlException("Connection to server lost", isFatal: true, null);
		}
		while (clientWrote.Set());
		throw new MySqlException("Writing to shared memory failed");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("SharedMemoryStream does not support seeking");
	}
}
