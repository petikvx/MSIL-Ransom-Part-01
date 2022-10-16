using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillTests()
	{
	}
}
