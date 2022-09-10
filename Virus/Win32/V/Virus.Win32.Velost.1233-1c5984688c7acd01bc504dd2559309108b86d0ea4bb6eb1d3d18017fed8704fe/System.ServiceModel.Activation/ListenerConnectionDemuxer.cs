using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal class ListenerConnectionDemuxer
{
	private ConnectionAcceptor acceptor;

	private List<InitialServerConnectionReader> connectionReaders;

	private bool isDisposed;

	private ListenerConnectionModeCallback onConnectionModeKnown;

	private ConnectionClosedCallback onConnectionClosed;

	private ConnectionHandleDuplicated connectionHandleDuplicated;

	private ViaDecodedCallback onViaDecoded;

	private TransportType transportType;

	private TimeSpan channelInitializationTimeout;

	private object ThisLock => this;

	public ListenerConnectionDemuxer(IConnectionListener listener, TransportType transportType, int maxAccepts, int initialMaxPendingConnections, TimeSpan channelInitializationTimeout, ConnectionHandleDuplicated connectionHandleDuplicated)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		this.transportType = transportType;
		connectionReaders = new List<InitialServerConnectionReader>();
		this.connectionHandleDuplicated = connectionHandleDuplicated;
		acceptor = new ConnectionAcceptor(listener, maxAccepts, initialMaxPendingConnections, new ConnectionAvailableCallback(OnConnectionAvailable));
		this.channelInitializationTimeout = channelInitializationTimeout;
		onConnectionClosed = new ConnectionClosedCallback(OnConnectionClosed);
		onViaDecoded = OnViaDecoded;
	}

	public void Dispose()
	{
		lock (ThisLock)
		{
			if (isDisposed)
			{
				return;
			}
			isDisposed = true;
		}
		for (int i = 0; i < connectionReaders.Count; i++)
		{
			connectionReaders[i].Dispose();
		}
		connectionReaders.Clear();
		acceptor.Dispose();
	}

	private ListenerConnectionModeReader SetupModeReader(IConnection connection)
	{
		if (onConnectionModeKnown == null)
		{
			onConnectionModeKnown = OnConnectionModeKnown;
		}
		ListenerConnectionModeReader listenerConnectionModeReader = new ListenerConnectionModeReader(connection, onConnectionModeKnown, onConnectionClosed);
		lock (ThisLock)
		{
			if (isDisposed)
			{
				((InitialServerConnectionReader)listenerConnectionModeReader).Dispose();
				return null;
			}
			connectionReaders.Add((InitialServerConnectionReader)(object)listenerConnectionModeReader);
			return listenerConnectionModeReader;
		}
	}

	private void OnConnectionAvailable(IConnection connection, ItemDequeuedCallback connectionDequeuedCallback)
	{
		if (transportType == TransportType.Tcp)
		{
			ListenerPerfCounters.IncrementConnectionsAcceptedTcp();
		}
		else
		{
			ListenerPerfCounters.IncrementConnectionsAcceptedNamedPipe();
		}
		ListenerConnectionModeReader listenerConnectionModeReader = SetupModeReader(connection);
		if (listenerConnectionModeReader != null)
		{
			listenerConnectionModeReader.StartReading(channelInitializationTimeout, connectionDequeuedCallback);
		}
		else
		{
			connectionDequeuedCallback.Invoke();
		}
	}

	private void OnConnectionModeKnown(ListenerConnectionModeReader modeReader)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a8: Expected O, but got Unknown
		lock (ThisLock)
		{
			if (isDisposed)
			{
				return;
			}
			connectionReaders.Remove((InitialServerConnectionReader)(object)modeReader);
		}
		try
		{
			FramingMode connectionMode = modeReader.GetConnectionMode();
			FramingMode val = connectionMode;
			switch (val - 1)
			{
			case 0:
				OnSingletonConnection(modeReader);
				return;
			case 1:
				OnDuplexConnection(modeReader);
				return;
			}
			Exception ex = new InvalidDataException(SR.GetString("FramingModeNotSupported", connectionMode));
			Exception ex2 = (Exception)new ProtocolException(ex.Message, ex);
			FramingEncodingString.AddFaultString(ex2, "http://schemas.microsoft.com/ws/2006/05/framing/faults/UnsupportedMode");
			throw DiagnosticUtility.ExceptionUtility.ThrowHelperError(ex2);
		}
		catch (ProtocolException val2)
		{
			ProtocolException val3 = val2;
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException((Exception)(object)val3, TraceEventType.Information);
			}
			((InitialServerConnectionReader)modeReader).Dispose();
		}
		catch (Exception ex3)
		{
			if (DiagnosticUtility.IsFatal(ex3))
			{
				throw;
			}
			if (DiagnosticUtility.ShouldTraceError)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException(ex3, TraceEventType.Error);
			}
			((InitialServerConnectionReader)modeReader).Dispose();
		}
	}

	private void OnViaDecoded(InitialServerConnectionReader connectionReader, ListenerSessionConnection session)
	{
		try
		{
			connectionHandleDuplicated(session);
		}
		finally
		{
			session.TriggerDequeuedCallback();
		}
		lock (ThisLock)
		{
			if (!isDisposed)
			{
				connectionReaders.Remove(connectionReader);
			}
		}
	}

	private void OnConnectionClosed(InitialServerConnectionReader connectionReader)
	{
		lock (ThisLock)
		{
			if (!isDisposed)
			{
				connectionReaders.Remove(connectionReader);
			}
		}
	}

	private void OnSingletonConnection(ListenerConnectionModeReader modeReader)
	{
		ListenerSingletonConnectionReader listenerSingletonConnectionReader = new ListenerSingletonConnectionReader(((InitialServerConnectionReader)modeReader).get_Connection(), ((InitialServerConnectionReader)modeReader).GetConnectionDequeuedCallback(), transportType, modeReader.StreamPosition, modeReader.BufferOffset, modeReader.BufferSize, onConnectionClosed, onViaDecoded);
		lock (ThisLock)
		{
			if (isDisposed)
			{
				((InitialServerConnectionReader)listenerSingletonConnectionReader).Dispose();
				return;
			}
			connectionReaders.Add((InitialServerConnectionReader)(object)listenerSingletonConnectionReader);
		}
		listenerSingletonConnectionReader.StartReading(modeReader.AccruedData, modeReader.GetRemainingTimeout());
	}

	private void OnDuplexConnection(ListenerConnectionModeReader modeReader)
	{
		ListenerSessionConnectionReader listenerSessionConnectionReader = new ListenerSessionConnectionReader(((InitialServerConnectionReader)modeReader).get_Connection(), ((InitialServerConnectionReader)modeReader).GetConnectionDequeuedCallback(), transportType, modeReader.StreamPosition, modeReader.BufferOffset, modeReader.BufferSize, onConnectionClosed, onViaDecoded);
		lock (ThisLock)
		{
			if (isDisposed)
			{
				((InitialServerConnectionReader)listenerSessionConnectionReader).Dispose();
				return;
			}
			connectionReaders.Add((InitialServerConnectionReader)(object)listenerSessionConnectionReader);
		}
		listenerSessionConnectionReader.StartReading(modeReader.AccruedData, modeReader.GetRemainingTimeout());
	}

	public void StartDemuxing()
	{
		acceptor.StartAccepting();
	}
}
