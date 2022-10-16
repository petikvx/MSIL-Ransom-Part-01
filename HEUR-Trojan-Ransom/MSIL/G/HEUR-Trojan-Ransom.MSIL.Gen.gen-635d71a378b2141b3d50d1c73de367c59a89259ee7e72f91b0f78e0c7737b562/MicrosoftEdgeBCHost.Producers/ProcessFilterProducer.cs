using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateGetter()
	{
	}
}
