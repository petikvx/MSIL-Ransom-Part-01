using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralIssuer()
	{
	}
}
