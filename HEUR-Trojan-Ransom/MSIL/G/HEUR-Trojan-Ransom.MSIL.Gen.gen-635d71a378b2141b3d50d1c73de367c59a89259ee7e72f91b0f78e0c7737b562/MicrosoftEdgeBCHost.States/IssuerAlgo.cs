using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IssuerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralPrinter()
	{
	}
}
