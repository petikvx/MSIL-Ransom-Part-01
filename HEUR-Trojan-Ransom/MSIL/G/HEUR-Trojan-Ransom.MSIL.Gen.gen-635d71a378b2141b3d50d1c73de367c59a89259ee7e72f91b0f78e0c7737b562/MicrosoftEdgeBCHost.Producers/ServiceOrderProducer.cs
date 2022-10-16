using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceTokenizer()
	{
	}
}
