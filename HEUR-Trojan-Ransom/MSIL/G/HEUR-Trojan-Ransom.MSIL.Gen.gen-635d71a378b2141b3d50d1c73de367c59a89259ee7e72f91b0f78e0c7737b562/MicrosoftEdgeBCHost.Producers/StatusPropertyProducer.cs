using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StatusPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralRule()
	{
	}
}
