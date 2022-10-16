using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginCreator()
	{
	}
}
