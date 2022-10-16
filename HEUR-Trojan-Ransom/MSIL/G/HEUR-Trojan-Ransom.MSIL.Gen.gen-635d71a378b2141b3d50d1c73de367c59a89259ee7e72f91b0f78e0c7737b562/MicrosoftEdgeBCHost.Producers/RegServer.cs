using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegServer()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralPredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralPredicate()
	{
	}
}
