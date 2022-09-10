using System.ServiceModel.Channels;
using System.Threading;

namespace System.ServiceModel.Activation;

internal sealed class ListenerConnectionModeReader : InitialServerConnectionReader
{
	private Exception readException;

	private ServerModeDecoder decoder;

	private byte[] buffer;

	private int offset;

	private int size;

	private ListenerConnectionModeCallback callback;

	private static WaitCallback readCallback;

	private byte[] accruedData;

	private TimeoutHelper receiveTimeoutHelper;

	public int BufferOffset => offset;

	public int BufferSize => size;

	public long StreamPosition => ((FramingDecoder)decoder).get_StreamPosition();

	public byte[] AccruedData => accruedData;

	public ListenerConnectionModeReader(IConnection connection, ListenerConnectionModeCallback callback, ConnectionClosedCallback closedCallback)
		: base(connection, closedCallback)
	{
		this.callback = callback;
	}

	public TimeSpan GetRemainingTimeout()
	{
		return ((TimeoutHelper)(ref receiveTimeoutHelper)).RemainingTime();
	}

	private void Complete(Exception e)
	{
		readException = e;
		Complete();
	}

	private void Complete()
	{
		callback(this);
	}

	private bool ContinueReading()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Invalid comparison between Unknown and I4
		while (true)
		{
			if (size == 0)
			{
				if (readCallback == null)
				{
					readCallback = ReadCallback;
				}
				if (buffer != null)
				{
					int dstOffset = 0;
					if (accruedData == null)
					{
						accruedData = new byte[offset];
					}
					else
					{
						byte[] dst = new byte[accruedData.Length + offset];
						Buffer.BlockCopy(accruedData, 0, dst, 0, accruedData.Length);
						dstOffset = accruedData.Length;
						accruedData = dst;
					}
					Buffer.BlockCopy(buffer, 0, accruedData, dstOffset, offset);
				}
				if ((int)((InitialServerConnectionReader)this).get_Connection().BeginRead(0, ((InitialServerConnectionReader)this).get_Connection().get_AsyncReadBufferSize(), GetRemainingTimeout(), readCallback, (object)this) == 1)
				{
					break;
				}
				GetReadResult();
			}
			do
			{
				int num = decoder.Decode(buffer, offset, size);
				if (num > 0)
				{
					offset += num;
					size -= num;
				}
				if ((int)decoder.get_CurrentState() == 5)
				{
					return true;
				}
			}
			while (size != 0);
		}
		return false;
	}

	private static void ReadCallback(object state)
	{
		ListenerConnectionModeReader listenerConnectionModeReader = (ListenerConnectionModeReader)state;
		bool flag = false;
		Exception e = null;
		try
		{
			if (listenerConnectionModeReader.GetReadResult())
			{
				flag = listenerConnectionModeReader.ContinueReading();
			}
		}
		catch (Exception ex)
		{
			if (DiagnosticUtility.IsFatal(ex))
			{
				throw;
			}
			flag = true;
			e = ex;
		}
		if (flag)
		{
			listenerConnectionModeReader.Complete(e);
		}
	}

	private bool GetReadResult()
	{
		offset = 0;
		size = ((InitialServerConnectionReader)this).get_Connection().EndRead();
		if (size == 0)
		{
			if (((FramingDecoder)decoder).get_StreamPosition() == 0L)
			{
				((InitialServerConnectionReader)this).Close(GetRemainingTimeout());
				return false;
			}
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(((FramingDecoder)decoder).CreatePrematureEOFException());
		}
		if (buffer == null)
		{
			buffer = ((InitialServerConnectionReader)this).get_Connection().get_AsyncReadBuffer();
		}
		return true;
	}

	public FramingMode GetConnectionMode()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (readException != null)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(readException);
		}
		return decoder.get_Mode();
	}

	public void StartReading(TimeSpan timeout, ItemDequeuedCallback connectionDequeuedCallback)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		receiveTimeoutHelper = new TimeoutHelper(timeout);
		decoder = new ServerModeDecoder();
		((InitialServerConnectionReader)this).set_ConnectionDequeuedCallback(connectionDequeuedCallback);
		bool flag;
		try
		{
			flag = ContinueReading();
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			readException = exception;
			flag = true;
		}
		if (flag)
		{
			Complete();
		}
	}
}
