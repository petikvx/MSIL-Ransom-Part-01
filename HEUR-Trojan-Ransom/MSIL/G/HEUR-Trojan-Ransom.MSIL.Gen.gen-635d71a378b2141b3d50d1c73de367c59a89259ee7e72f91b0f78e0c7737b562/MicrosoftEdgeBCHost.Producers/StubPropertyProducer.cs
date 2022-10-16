using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralRequest()
	{
	}
}
