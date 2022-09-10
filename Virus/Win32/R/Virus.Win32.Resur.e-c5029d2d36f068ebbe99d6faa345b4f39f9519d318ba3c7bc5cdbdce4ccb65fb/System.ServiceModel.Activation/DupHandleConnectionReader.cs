using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.Threading;

namespace System.ServiceModel.Activation;

internal abstract class DupHandleConnectionReader : InitialServerConnectionReader
{
	private byte[] connectionBuffer;

	private ViaDecodedCallback viaDecodedCallback;

	private byte[] dataRead;

	private int offset;

	private static WaitCallback readCallback;

	private int size;

	private TransportType transportType;

	private TimeoutHelper receiveTimeoutHelper;

	protected DupHandleConnectionReader(IConnection connection, ItemDequeuedCallback connectionDequeuedCallback, TransportType transportType, int offset, int size, ConnectionClosedCallback closedCallback, ViaDecodedCallback viaDecodedCallback)
		: base(connection, closedCallback, 2048, 256)
	{
		this.transportType = transportType;
		this.offset = offset;
		this.size = size;
		this.viaDecodedCallback = viaDecodedCallback;
		((InitialServerConnectionReader)this).set_ConnectionDequeuedCallback(connectionDequeuedCallback);
	}

	private TimeSpan GetRemainingTimeout()
	{
		return ((TimeoutHelper)(ref receiveTimeoutHelper)).RemainingTime();
	}

	private void AbortAndCount(Exception exception)
	{
		if (transportType == TransportType.Tcp)
		{
			ListenerPerfCounters.IncrementProtocolFailuresTcp();
		}
		else if (transportType == TransportType.NamedPipe)
		{
			ListenerPerfCounters.IncrementProtocolFailuresNamedPipe();
		}
		((InitialServerConnectionReader)this).Abort(exception);
	}

	protected abstract bool CanDupHandle(out Uri viaString);

	private void ContinueReading()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Invalid comparison between Unknown and I4
		try
		{
			while (true)
			{
				if (size == 0)
				{
					if (readCallback == null)
					{
						readCallback = ReadCallback;
					}
					if ((int)((InitialServerConnectionReader)this).get_Connection().BeginRead(0, connectionBuffer.Length, GetRemainingTimeout(), readCallback, (object)this) == 1)
					{
						break;
					}
					GetReadResult();
				}
				do
				{
					int num = Decode(connectionBuffer, offset, size);
					if (num > 0)
					{
						offset += num;
						size -= num;
					}
					Uri viaString = null;
					if (CanDupHandle(out viaString))
					{
						ListenerSessionConnection session = new ListenerSessionConnection(((InitialServerConnectionReader)this).get_Connection(), dataRead, viaString, ((InitialServerConnectionReader)this).GetConnectionDequeuedCallback());
						viaDecodedCallback((InitialServerConnectionReader)(object)this, session);
						((InitialServerConnectionReader)this).ReleaseConnection();
						return;
					}
				}
				while (size != 0);
			}
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			AbortAndCount(exception);
		}
	}

	protected abstract int Decode(byte[] buffer, int offset, int size);

	protected abstract Exception CreatePrematureEOFException();

	private void GetReadResult()
	{
		offset = 0;
		size = ((InitialServerConnectionReader)this).get_Connection().EndRead();
		if (size == 0)
		{
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(CreatePrematureEOFException());
		}
		byte[] dst = new byte[dataRead.Length + size];
		Buffer.BlockCopy(dataRead, 0, dst, 0, dataRead.Length);
		Buffer.BlockCopy(connectionBuffer, 0, dst, dataRead.Length, size);
		dataRead = dst;
	}

	private static void ReadCallback(object state)
	{
		DupHandleConnectionReader dupHandleConnectionReader = (DupHandleConnectionReader)state;
		try
		{
			dupHandleConnectionReader.GetReadResult();
			dupHandleConnectionReader.ContinueReading();
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			dupHandleConnectionReader.AbortAndCount(exception);
		}
	}

	public void StartReading(byte[] accruedData, TimeSpan timeout)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		int dstOffset = 0;
		receiveTimeoutHelper = new TimeoutHelper(timeout);
		if (accruedData != null)
		{
			dataRead = new byte[accruedData.Length + offset + size];
			Buffer.BlockCopy(accruedData, 0, dataRead, 0, accruedData.Length);
			dstOffset = accruedData.Length;
		}
		else
		{
			dataRead = new byte[offset + size];
		}
		connectionBuffer = ((InitialServerConnectionReader)this).get_Connection().get_AsyncReadBuffer();
		Buffer.BlockCopy(connectionBuffer, 0, dataRead, dstOffset, offset + size);
		ContinueReading();
	}
}
