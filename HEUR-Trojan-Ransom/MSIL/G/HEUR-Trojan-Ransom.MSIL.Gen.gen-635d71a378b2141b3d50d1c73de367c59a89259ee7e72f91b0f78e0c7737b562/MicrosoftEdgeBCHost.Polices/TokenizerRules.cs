using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerRules()
	{
		WriterPropertyProducer.ResolveStub();
		MapInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInitializer()
	{
	}
}
