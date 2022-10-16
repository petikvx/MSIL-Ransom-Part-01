using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class WriterFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterFacade()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralRule()
	{
	}
}
