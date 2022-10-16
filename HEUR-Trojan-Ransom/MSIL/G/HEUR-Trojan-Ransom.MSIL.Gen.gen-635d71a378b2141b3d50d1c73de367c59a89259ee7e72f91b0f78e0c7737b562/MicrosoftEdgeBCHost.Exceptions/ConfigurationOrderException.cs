using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceQueue()
	{
	}
}
