using System.Collections;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Permissions;

namespace ns0;

internal sealed class Class5
{
	internal sealed class Class6 : IClientChannelSink, IChannelSinkBase, IMessageSink
	{
		internal IClientChannelSink iclientChannelSink_0;

		internal IMessageSink imessageSink_0;

		public IClientChannelSink NextChannelSink
		{
			[SecurityCritical]
			get
			{
				return iclientChannelSink_0.get_NextChannelSink();
			}
		}

		public IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				return ((IChannelSinkBase)iclientChannelSink_0).get_Properties();
			}
		}

		public IMessageSink NextSink
		{
			[SecurityCritical]
			get
			{
				return imessageSink_0.get_NextSink();
			}
		}

		public Class6(IClientChannelSink iclientChannelSink_1)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			IClientChannelSink val = (iclientChannelSink_0 = iclientChannelSink_1);
			IMessageSink val2 = (imessageSink_0 = (IMessageSink)iclientChannelSink_1);
		}

		[SecurityCritical]
		public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream)
		{
			iclientChannelSink_0.AsyncProcessRequest(sinkStack, msg, headers, stream);
		}

		[SecurityCritical]
		public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream)
		{
			iclientChannelSink_0.AsyncProcessResponse(sinkStack, state, headers, stream);
		}

		[SecurityCritical]
		public Stream GetRequestStream(IMessage msg, ITransportHeaders headers)
		{
			return iclientChannelSink_0.GetRequestStream(msg, headers);
		}

		[SecurityCritical]
		public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream)
		{
			iclientChannelSink_0.ProcessMessage(msg, requestHeaders, requestStream, ref responseHeaders, ref responseStream);
		}

		[SecurityCritical]
		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return imessageSink_0.AsyncProcessMessage(msg, replySink);
		}

		[SecurityCritical]
		public IMessage SyncProcessMessage(IMessage msg)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			((CodeAccessPermission)new SecurityPermission(SecurityPermissionFlag.SerializationFormatter | SecurityPermissionFlag.UnmanagedCode)).Assert();
			return imessageSink_0.SyncProcessMessage(msg);
		}
	}

	public static string smethod_0()
	{
		return "Me";
	}
}
