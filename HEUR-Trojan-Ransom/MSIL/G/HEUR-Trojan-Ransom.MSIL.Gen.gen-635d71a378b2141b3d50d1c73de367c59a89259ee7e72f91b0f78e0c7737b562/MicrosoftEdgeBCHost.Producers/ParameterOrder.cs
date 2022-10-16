using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParameterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		StopConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopConsumer()
	{
	}
}
