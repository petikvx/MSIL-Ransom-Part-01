using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralBase()
	{
	}
}
