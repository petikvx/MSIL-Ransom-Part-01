using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParamsPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralRule()
	{
	}
}
