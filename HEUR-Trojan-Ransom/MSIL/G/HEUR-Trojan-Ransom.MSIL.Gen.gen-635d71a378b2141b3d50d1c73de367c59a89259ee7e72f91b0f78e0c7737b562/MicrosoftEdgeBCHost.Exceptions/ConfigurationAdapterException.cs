using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceConsumer()
	{
	}
}
