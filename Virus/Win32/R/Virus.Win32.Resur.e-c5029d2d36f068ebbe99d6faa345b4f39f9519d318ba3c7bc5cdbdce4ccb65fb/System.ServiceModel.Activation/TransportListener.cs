using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Security.Principal;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.Threading;

namespace System.ServiceModel.Activation;

internal class TransportListener
{
	private static byte[] drainBuffer;

	private static Hashtable namedPipeInstances = new Hashtable();

	private static Hashtable tcpInstances = new Hashtable();

	private int count;

	private ListenerConnectionDemuxer demuxer;

	private ListenerConnectionDemuxer demuxerV6;

	private TransportType transportType;

	private static object ThisStaticLock => tcpInstances;

	private TransportListener(IPEndPoint endPoint)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		transportType = TransportType.Tcp;
		SocketSettings socketSettings = new SocketSettings();
		IConnectionListener val = null;
		if (endPoint.Address.Equals(IPAddress.Broadcast))
		{
			if (Socket.SupportsIPv4)
			{
				val = (IConnectionListener)new SocketConnectionListener(new IPEndPoint(IPAddress.Any, endPoint.Port), (ISocketListenerSettings)(object)socketSettings, true);
				demuxer = Go(val);
			}
			if (Socket.OSSupportsIPv6)
			{
				val = (IConnectionListener)new SocketConnectionListener(new IPEndPoint(IPAddress.IPv6Any, endPoint.Port), (ISocketListenerSettings)(object)socketSettings, true);
				demuxerV6 = Go(val);
			}
		}
		else
		{
			val = (IConnectionListener)new SocketConnectionListener(endPoint, (ISocketListenerSettings)(object)socketSettings, true);
			demuxer = Go(val);
		}
	}

	private TransportListener(BaseUriWithWildcard pipeUri)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		transportType = TransportType.NamedPipe;
		IConnectionListener connectionListener = (IConnectionListener)new PipeConnectionListener(pipeUri.get_BaseAddress(), pipeUri.get_HostNameComparisonMode(), 2500, (List<SecurityIdentifier>)null, false, int.MaxValue);
		demuxer = Go(connectionListener);
	}

	private void AddRef()
	{
		count++;
	}

	private int DelRef()
	{
		return --count;
	}

	internal ListenerConnectionDemuxer Go(IConnectionListener connectionListener)
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655376, this);
		}
		ConnectionHandleDuplicated connectionHandleDuplicated = OnDupHandle;
		ListenerConnectionDemuxer listenerConnectionDemuxer = null;
		if (transportType == TransportType.Tcp)
		{
			listenerConnectionDemuxer = new ListenerConnectionDemuxer(connectionListener, transportType, ListenerConfig.NetTcp.MaxPendingAccepts, ListenerConfig.NetTcp.MaxPendingConnections, ListenerConfig.NetTcp.ReceiveTimeout, connectionHandleDuplicated);
		}
		else if (transportType == TransportType.NamedPipe)
		{
			listenerConnectionDemuxer = new ListenerConnectionDemuxer(connectionListener, transportType, ListenerConfig.NetPipe.MaxPendingAccepts, ListenerConfig.NetPipe.MaxPendingConnections, ListenerConfig.NetPipe.ReceiveTimeout, connectionHandleDuplicated);
		}
		if (ExecutionContext.IsFlowSuppressed())
		{
			if (SecurityContext.IsFlowSuppressed())
			{
				listenerConnectionDemuxer.StartDemuxing();
			}
			else
			{
				using (SecurityContext.SuppressFlow())
				{
					listenerConnectionDemuxer.StartDemuxing();
				}
			}
		}
		else
		{
			using (ExecutionContext.SuppressFlow())
			{
				if (SecurityContext.IsFlowSuppressed())
				{
					listenerConnectionDemuxer.StartDemuxing();
				}
				else
				{
					using (SecurityContext.SuppressFlow())
					{
						listenerConnectionDemuxer.StartDemuxing();
					}
				}
			}
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655375, this);
		}
		return listenerConnectionDemuxer;
	}

	internal static void Listen(IPEndPoint endPoint)
	{
		lock (tcpInstances)
		{
			if (tcpInstances[endPoint] is TransportListener transportListener)
			{
				transportListener.AddRef();
				return;
			}
			TransportListener transportListener2 = new TransportListener(endPoint);
			tcpInstances.Add(endPoint, transportListener2);
			transportListener2.AddRef();
		}
	}

	internal static void Listen(BaseUriWithWildcard pipeUri)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		lock (namedPipeInstances)
		{
			if (namedPipeInstances.ContainsKey(pipeUri))
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new CommunicationException(SR.GetString("PipeAddressAlreadyUsed")));
			}
			TransportListener value = new TransportListener(pipeUri);
			namedPipeInstances.Add(pipeUri, value);
		}
	}

	private static TransportType GetTransportTypeAndAddress(IConnection connection, out IPAddress address, out int port)
	{
		Socket socket = connection.GetCoreTransport() as Socket;
		address = null;
		port = -1;
		TransportType result = TransportType.NamedPipe;
		if (socket != null)
		{
			address = (socket.LocalEndPoint as IPEndPoint).Address;
			port = (socket.LocalEndPoint as IPEndPoint).Port;
			result = TransportType.Tcp;
		}
		return result;
	}

	internal void OnDupHandle(ListenerSessionConnection session)
	{
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655377, this);
		}
		IPAddress address;
		int port;
		TransportType transportTypeAndAddress = GetTransportTypeAndAddress(session.Connection, out address, out port);
		MessageQueue messageQueue = RoutingTable.Lookup(session.Via, address, port);
		if (messageQueue != null)
		{
			messageQueue.EnqueueSessionAndDispatch(session);
			return;
		}
		SendFault(session.Connection, "http://schemas.microsoft.com/ws/2006/05/framing/faults/EndpointNotFound");
		MessageQueue.OnDispatchFailure(transportTypeAndAddress);
	}

	internal static void SendFault(IConnection connection, string fault)
	{
		if (drainBuffer == null)
		{
			lock (ThisStaticLock)
			{
				if (drainBuffer == null)
				{
					drainBuffer = new byte[1024];
				}
			}
		}
		try
		{
			InitialServerConnectionReader.SendFault(connection, fault, drainBuffer, ListenerConstants.SharedSendTimeout, 65536);
		}
		catch (Exception ex)
		{
			if (DiagnosticUtility.IsFatal(ex))
			{
				throw;
			}
			if (DiagnosticUtility.ShouldTraceWarning)
			{
				DiagnosticUtility.ExceptionUtility.TraceHandledException(ex, TraceEventType.Warning);
			}
		}
	}

	private void Stop()
	{
		demuxer.Dispose();
		if (demuxerV6 != null)
		{
			demuxerV6.Dispose();
		}
	}

	internal static void Stop(IPEndPoint endPoint)
	{
		lock (tcpInstances)
		{
			if (tcpInstances[endPoint] is TransportListener transportListener && transportListener.DelRef() == 0)
			{
				if (DiagnosticUtility.ShouldTraceInformation)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655378, transportListener);
				}
				try
				{
					transportListener.Stop();
					return;
				}
				finally
				{
					tcpInstances.Remove(endPoint);
				}
			}
		}
	}

	internal static void Stop(BaseUriWithWildcard pipeUri)
	{
		lock (namedPipeInstances)
		{
			if (namedPipeInstances[pipeUri] is TransportListener transportListener)
			{
				if (DiagnosticUtility.ShouldTraceInformation)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655378, transportListener);
				}
				try
				{
					transportListener.Stop();
					return;
				}
				finally
				{
					namedPipeInstances.Remove(pipeUri);
				}
			}
		}
	}
}
