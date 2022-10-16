using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralIdentifier()
	{
	}
}
