using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveDescriptor()
	{
	}
}
