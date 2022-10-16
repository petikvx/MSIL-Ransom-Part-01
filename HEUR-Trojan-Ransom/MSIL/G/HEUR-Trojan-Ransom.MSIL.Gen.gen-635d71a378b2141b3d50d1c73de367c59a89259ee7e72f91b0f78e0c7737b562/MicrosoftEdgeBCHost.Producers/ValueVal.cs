using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValueVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueVal()
	{
		WriterPropertyProducer.ResolveStub();
		StopContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopContainer()
	{
	}
}
