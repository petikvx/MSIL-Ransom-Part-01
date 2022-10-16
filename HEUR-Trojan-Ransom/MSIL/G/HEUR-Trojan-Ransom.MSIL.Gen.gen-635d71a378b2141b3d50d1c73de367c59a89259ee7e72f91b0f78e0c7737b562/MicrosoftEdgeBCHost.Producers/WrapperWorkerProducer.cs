using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WrapperWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		GetCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetCallback()
	{
	}
}
