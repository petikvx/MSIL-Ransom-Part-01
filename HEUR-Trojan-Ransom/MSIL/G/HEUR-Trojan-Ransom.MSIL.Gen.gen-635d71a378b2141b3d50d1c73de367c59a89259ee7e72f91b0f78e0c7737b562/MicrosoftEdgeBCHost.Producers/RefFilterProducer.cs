using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopProccesor()
	{
	}
}
