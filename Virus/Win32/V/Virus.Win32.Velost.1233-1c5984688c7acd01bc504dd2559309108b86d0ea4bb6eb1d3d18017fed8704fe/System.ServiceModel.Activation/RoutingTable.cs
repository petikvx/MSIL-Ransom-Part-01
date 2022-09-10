using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel.Activation.Diagnostics;
using System.ServiceModel.Channels;
using System.ServiceModel.Diagnostics;
using System.Text;

namespace System.ServiceModel.Activation;

internal static class RoutingTable
{
	private class MessageQueueAndPath
	{
		private MessageQueue messageQueue;

		private Uri uri;

		internal MessageQueue MessageQueue => messageQueue;

		internal Uri Uri => uri;

		internal MessageQueueAndPath(MessageQueue messageQueue, Uri uri)
		{
			this.messageQueue = messageQueue;
			this.uri = uri;
		}
	}

	private static UriPrefixTable<MessageQueueAndPath> namedPipeMessageQueues = new UriPrefixTable<MessageQueueAndPath>();

	private static UriPrefixTable<MessageQueueAndPath> tcpMessageQueues = new UriPrefixTable<MessageQueueAndPath>(true);

	internal static MessageQueue Lookup(Uri uri, IPAddress address, int port)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		Uri uri2 = uri;
		UriPrefixTable<MessageQueueAndPath> val = namedPipeMessageQueues;
		if (address != null)
		{
			UriBuilder uriBuilder = new UriBuilder(uri.Scheme, uri.Host, port, uri.PathAndQuery);
			uri2 = uriBuilder.Uri;
			val = tcpMessageQueues;
		}
		MessageQueueAndPath found = null;
		bool flag;
		if ((flag = val.TryLookupUri(uri2, (HostNameComparisonMode)0, ref found)) && address != null)
		{
			flag = ValidateAddress(address, ref found);
		}
		if (!flag && (flag = val.TryLookupUri(uri, (HostNameComparisonMode)1, ref found)) && address != null)
		{
			flag = ValidateAddress(address, ref found);
		}
		if (!flag && (flag = val.TryLookupUri(uri2, (HostNameComparisonMode)2, ref found)) && address != null)
		{
			flag = ValidateAddress(address, ref found);
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655369, (TraceRecord)new StringTraceRecord("Uri", uri.ToString()), null, null);
		}
		return found?.MessageQueue;
	}

	private static bool ValidateAddress(IPAddress address, ref MessageQueueAndPath found)
	{
		if (found.Uri.HostNameType != UriHostNameType.IPv4 && found.Uri.HostNameType != UriHostNameType.IPv6)
		{
			return true;
		}
		IPAddress iPAddress = IPAddress.Parse(found.Uri.DnsSafeHost);
		bool flag = address.Equals(iPAddress) || (iPAddress.Equals(IPAddress.Any) && iPAddress.AddressFamily == AddressFamily.InterNetwork) || iPAddress.Equals(IPAddress.IPv6Any);
		found = (flag ? found : null);
		return flag;
	}

	internal static ListenerExceptionStatus NamedPipeStart(MessageQueue messageQueue, BaseUriWithWildcard path)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		int byteCount = Encoding.UTF8.GetByteCount(path.get_BaseAddress().AbsoluteUri);
		if (byteCount > 2048)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655371, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
			}
			return (ListenerExceptionStatus)1;
		}
		lock (namedPipeMessageQueues)
		{
			if (namedPipeMessageQueues.IsRegistered(path))
			{
				if (DiagnosticUtility.ShouldTraceInformation)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655370, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
				}
				return (ListenerExceptionStatus)4;
			}
			TransportListener.Listen(path);
			namedPipeMessageQueues.RegisterUri(path.get_BaseAddress(), path.get_HostNameComparisonMode(), new MessageQueueAndPath(messageQueue, path.get_BaseAddress()));
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655372, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
		}
		return (ListenerExceptionStatus)0;
	}

	internal static ListenerExceptionStatus Start(MessageQueue messageQueue, BaseUriWithWildcard path)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (messageQueue.TransportType == TransportType.Tcp)
		{
			return TcpStart(messageQueue, path);
		}
		return NamedPipeStart(messageQueue, path);
	}

	private static IPEndPoint GetEndPoint(Uri path)
	{
		IPAddress address = IPAddress.Broadcast;
		if (path.HostNameType == UriHostNameType.IPv4 || path.HostNameType == UriHostNameType.IPv6)
		{
			address = IPAddress.Parse(path.DnsSafeHost);
		}
		return new IPEndPoint(address, path.Port);
	}

	internal static void Stop(MessageQueue messageQueue, BaseUriWithWildcard path)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		if (messageQueue.TransportType == TransportType.Tcp)
		{
			IPEndPoint endPoint = GetEndPoint(path.get_BaseAddress());
			TransportListener.Stop(endPoint);
			tcpMessageQueues.UnregisterUri(path.get_BaseAddress(), path.get_HostNameComparisonMode());
		}
		else
		{
			TransportListener.Stop(path);
			namedPipeMessageQueues.UnregisterUri(path.get_BaseAddress(), path.get_HostNameComparisonMode());
		}
	}

	private static ListenerExceptionStatus TcpStart(MessageQueue messageQueue, BaseUriWithWildcard path)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		int byteCount = Encoding.UTF8.GetByteCount(path.get_BaseAddress().AbsoluteUri);
		if (byteCount > 2048)
		{
			if (DiagnosticUtility.ShouldTraceInformation)
			{
				ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655371, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
			}
			return (ListenerExceptionStatus)1;
		}
		IPEndPoint endPoint = GetEndPoint(path.get_BaseAddress());
		lock (tcpMessageQueues)
		{
			if (tcpMessageQueues.IsRegistered(path))
			{
				if (DiagnosticUtility.ShouldTraceInformation)
				{
					ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655370, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
				}
				return (ListenerExceptionStatus)4;
			}
			TransportListener.Listen(endPoint);
			tcpMessageQueues.RegisterUri(path.get_BaseAddress(), path.get_HostNameComparisonMode(), new MessageQueueAndPath(messageQueue, path.get_BaseAddress()));
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			ListenerTraceUtility.TraceEvent(TraceEventType.Information, (TraceCode)655372, (TraceRecord)new StringTraceRecord("Path", ((object)path).ToString()), null, null);
		}
		return (ListenerExceptionStatus)0;
	}
}
