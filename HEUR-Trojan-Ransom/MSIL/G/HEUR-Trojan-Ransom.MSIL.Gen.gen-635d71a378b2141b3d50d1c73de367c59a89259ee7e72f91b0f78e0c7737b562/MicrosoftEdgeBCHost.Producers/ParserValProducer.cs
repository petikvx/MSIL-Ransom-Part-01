using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParserValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyIterator()
	{
	}
}
