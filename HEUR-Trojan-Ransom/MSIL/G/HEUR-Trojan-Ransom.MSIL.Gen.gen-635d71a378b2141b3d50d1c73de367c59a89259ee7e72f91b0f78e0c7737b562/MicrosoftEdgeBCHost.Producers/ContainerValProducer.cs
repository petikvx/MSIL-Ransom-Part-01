using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ContainerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallClient()
	{
	}
}
