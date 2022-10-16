using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TestsReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsReponse()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralIdentifier()
	{
	}
}
